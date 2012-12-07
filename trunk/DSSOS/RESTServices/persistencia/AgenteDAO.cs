using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServices.dominio;
using System.Data.SqlClient;

namespace RESTServices.persistencia
{
    public class AgenteDAO
    {
        public Agente Crear(Agente AgenteACrear)
        {
            Agente agenteCreado = null;
            string sql = "insert into Agente (RazonSocial, RUC, CorreoAgente, Direccion, NroCuentaInterbancaria ) " +
                    "values (@razonsocial, @ruc, @correoagente, @direccion, @nrocta)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {                    
                    com.Parameters.Add(new SqlParameter("@razonsocial", AgenteACrear.RazonSocial));
                    com.Parameters.Add(new SqlParameter("@ruc", AgenteACrear.RUC));
                    com.Parameters.Add(new SqlParameter("@correoagente", AgenteACrear.CorreoAgente));
                    com.Parameters.Add(new SqlParameter("@direccion", AgenteACrear.Direccion));
                    com.Parameters.Add(new SqlParameter("@nrocta", AgenteACrear.NroCuentaInterbancaria));
                    com.ExecuteNonQuery();
                }
            }
            agenteCreado = Obtener(AgenteACrear.RUC);
            return agenteCreado;
        }


        public Agente Obtener(string ruc)
        {
            Agente agenteCreado = null;
            string sql = "select Razonsocial, Ruc, Direccion, CorreoAgente, NroCuentaInterbancaria from Agente where ruc=@ruc";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@ruc", ruc));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            agenteCreado = new Agente()
                            {
                                RazonSocial = (string)resultado["RazonSocial"],
                                RUC = (string)resultado["Ruc"],
                                Direccion = (string)resultado["Direccion"],
                                CorreoAgente = (string)resultado["CorreoAgente"],
                                NroCuentaInterbancaria = (string)resultado["NroCuentaInterbancaria"],
                            };
                        }
                    }
                }
            }
            return agenteCreado;
        }


        public Agente ObtenerCorreo(string correo)
        {
            Agente correoCreado = null;
            string sql = "select Razonsocial, Ruc, Direccion, CorreoAgente, NroCuentaInterbancaria from Agente where correoagente=@correoagente";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@correoagente", correo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            correoCreado = new Agente()
                            {
                                RazonSocial = (string)resultado["RazonSocial"],
                                RUC = (string)resultado["Ruc"],
                                Direccion = (string)resultado["Direccion"],
                                CorreoAgente = (string)resultado["CorreoAgente"],
                                NroCuentaInterbancaria = (string)resultado["NroCuentaInterbancaria"],
                            };
                        }
                    }
                }
            }
            return correoCreado;
        }

        /*

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

        */

        /*
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

        */

        public List<Agente> ListarTodos()
        {
            List<Agente> agentesEncontrado = null;
            agentesEncontrado = new List<Agente>();
            string sql = "select RazonSocial, Ruc, Direccion, CorreoCliente, NroCuentaInterbancaria from agente";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            Agente agenteEncontrado = new Agente()
                            {
                                RazonSocial = (string)resultado["RazonSocial"],
                                RUC = (string)resultado["Ruc"],
                                Direccion = (string)resultado["Direccion"],
                                CorreoAgente = (string)resultado["CorreoAgente"],
                            };
                            agentesEncontrado.Add(agenteEncontrado);
                        }
                    }
                }
            }
            return agentesEncontrado;
        }
        
    }
}