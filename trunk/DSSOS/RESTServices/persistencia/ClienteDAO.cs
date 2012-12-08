using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServices.dominio;
using System.Data.SqlClient;
using System.Messaging;

namespace RESTServices.persistencia
{
    public class ClienteDAO
    {
        ////crear cliente tradicionalmente por BD
        //public Cliente Crear(Cliente ClienteACrear)
        //{
        //    Cliente clienteCreado = null;
        //    string sql = "insert into Cliente (NombreCliente, ApellidoCliente, DNI, CorreoCliente ) " +
        //            "values (@nomCli, @apeCli, @dniCli, @correoCli)";
        //    using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
        //    {
        //        con.Open();
        //        using (SqlCommand com = new SqlCommand(sql, con))
        //        {
        //            com.Parameters.Add(new SqlParameter("@nomCli", ClienteACrear.NombreCliente));
        //            com.Parameters.Add(new SqlParameter("@apeCli", ClienteACrear.ApellidoCliente));
        //            com.Parameters.Add(new SqlParameter("@dniCli", ClienteACrear.DNI));
        //            com.Parameters.Add(new SqlParameter("@correoCli", ClienteACrear.CorreoCliente));
        //            com.ExecuteNonQuery();
        //        }
        //    }
        //    clienteCreado = Obtener(ClienteACrear.DNI);
        //    return clienteCreado;
        //}

        
        //Crear cliente utilizando MENSAJERIA
        public Cliente Crear(Cliente ClienteACrear)
        {
            string rutaCola = @".\private$\RegistroClientes";
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);
            MessageQueue cola = new MessageQueue(rutaCola);
            Message mensaje = new Message();
            mensaje.Label = "Nuevo Cliente";
            mensaje.Body = new Cliente()
            {
                ApellidoCliente = ClienteACrear.ApellidoCliente,
                NombreCliente = ClienteACrear.NombreCliente,
                DNI = ClienteACrear.DNI,
                CorreoCliente = ClienteACrear.CorreoCliente
            };
            cola.Send(mensaje);
            //clienteCreado = Obtener(ClienteACrear.DNI);
            return ClienteACrear;
        }

        public Cliente Obtener(string dni)
        {
            Cliente clienteEncontrado = null;
            string sql = "select NombreCliente, ApellidoCliente, DNI, CorreoCliente from cliente where dni=@dni";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            clienteEncontrado = new Cliente()
                            {
                                NombreCliente = (string)resultado["NombreCliente"],
                                ApellidoCliente = (string)resultado["ApellidoCliente"],
                                DNI = (string)resultado["DNI"],
                                CorreoCliente = (string)resultado["CorreoCliente"],
                            };
                        }
                    }
                }
            }
            return clienteEncontrado;
        }

        public Cliente Modificar(Cliente ClienteAModificar)
        {
            Cliente clienteModif = null;
            string sql = "update cliente set NombreCliente=@nom, ApellidoCliente=@ape, CorreoCliente=@correo  where DNI=@dni";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@dni", ClienteAModificar.DNI));
                    com.Parameters.Add(new SqlParameter("@nom", ClienteAModificar.NombreCliente));
                    com.Parameters.Add(new SqlParameter("@ape", ClienteAModificar.ApellidoCliente));
                    com.Parameters.Add(new SqlParameter("@correo", ClienteAModificar.CorreoCliente));
                    com.ExecuteNonQuery();
                }
            }
            clienteModif = Obtener(ClienteAModificar.DNI);
            return clienteModif;
        }

        public void Eliminar(string dni)
        {
            //Alumno alumnoCreado = null;
            string sql = "delete from cliente where DNI=@dni";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@dni", dni));
                    com.ExecuteNonQuery();
                }
            }
            //alumnoCreado = Obtener(AlumnoCrear.Codigo);
            //return alumnoCreado;
        }

        public List<Cliente> ListarTodos()
        {
            //***************Antes de listar Inserta a todos los clientes ENCOLADOS
            string rutaCola = @".\private$\RegistroClientes";
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);
            MessageQueue cola = new MessageQueue(rutaCola);
            int cantidad = cola.GetAllMessages().Length;
            cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Cliente) });
            Message mensaje = null;
            for (int i = 0; i < cantidad; i++)
            {
                mensaje = cola.Receive();
                Cliente p = (Cliente)mensaje.Body;
                //insertar a la DB clientes encolados
                string sql2 = "insert into Cliente (NombreCliente, ApellidoCliente, DNI, CorreoCliente ) " +
                    "values (@nomCli, @apeCli, @dniCli, @correoCli)";
                using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(sql2, con))
                    {
                        com.Parameters.Add(new SqlParameter("@nomCli", p.NombreCliente));
                        com.Parameters.Add(new SqlParameter("@apeCli", p.ApellidoCliente));
                        com.Parameters.Add(new SqlParameter("@dniCli", p.DNI));
                        com.Parameters.Add(new SqlParameter("@correoCli", p.CorreoCliente));
                        com.ExecuteNonQuery();
                    }
                }
            }
            //***************
            List<Cliente> clientesEncontrado = null;
            clientesEncontrado = new List<Cliente>();
            string sql = "select NombreCliente, ApellidoCliente, DNI, CorreoCliente from cliente";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            Cliente clienteEncontrado = new Cliente()
                            {
                                NombreCliente = (string)resultado["NombreCliente"],
                                ApellidoCliente = (string)resultado["ApellidoCliente"],
                                DNI = (string)resultado["DNI"],
                                CorreoCliente = (string)resultado["CorreoCliente"],
                            };
                            clientesEncontrado.Add(clienteEncontrado);
                        }
                    }
                }
            }
            return clientesEncontrado;
        }
        
    }
}