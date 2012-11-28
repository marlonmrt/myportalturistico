﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServices.dominio;
using System.Data.SqlClient;

namespace RESTServices.persistencia
{
    public class ClienteDAO
    {
        public Cliente Crear(Cliente ClienteACrear)
        {
            Cliente clienteCreado = null;
            string sql = "insert into Cliente (NombreCliente, ApellidoCliente, DNI, CorreoCliente ) " +
                    "values (@nomCli, @apeCli, @dniCli, @correoCli)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@nomCli", ClienteACrear.nombreCli));
                    com.Parameters.Add(new SqlParameter("@apeCli", ClienteACrear.apellidoCli));
                    com.Parameters.Add(new SqlParameter("@dniCli", ClienteACrear.dni));
                    com.Parameters.Add(new SqlParameter("@correoCli", ClienteACrear.correo));
                    com.ExecuteNonQuery();
                }
            }
            clienteCreado = Obtener(ClienteACrear.dni);
            return clienteCreado;
        }


        public Cliente Obtener(string dni)
        {
            Cliente clienteEncontrado = null;
            string sql = "select NombreCliente, ApellidoCliente, DNI,CorreoCliente from cliente where dni=@dni";
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
                                nombreCli = (string)resultado["NombreCliente"],
                                apellidoCli = (string)resultado["ApellidoCliente"],
                                dni = (string)resultado["DNI"],
                                correo = (string)resultado["CorreoCliente"],
                            };
                        }
                    }
                }
            }
            return clienteEncontrado;
        }

        /*

        public Alumno Modificar(Alumno alumnoAModificar)
        {
            Alumno alumnoModif = null;
            string sql = "update t_alumno set nombre=@nom where codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", alumnoAModificar.Codigo));
                    com.Parameters.Add(new SqlParameter("@nom", alumnoAModificar.Nombre));
                    com.ExecuteNonQuery();
                }
            }
            alumnoModif = Obtener(alumnoAModificar.Codigo);
            return alumnoModif;
        }

        */

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
                                nombreCli = (string)resultado["NombreCliente"],
                                apellidoCli = (string)resultado["ApellidoCliente"],
                                dni = (string)resultado["DNI"],
                                correo = (string)resultado["CorreoCliente"],
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