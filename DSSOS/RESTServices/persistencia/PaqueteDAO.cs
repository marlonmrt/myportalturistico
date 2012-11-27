using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServices.dominio;
using System.Data.SqlClient;

namespace RESTServices.persistencia
{
    public class PaqueteDAO
    {
        public Paquete Crear(Paquete PaqueteACrear)
        {
            Paquete PaqueteCreado = null;
            string sql = "insert into Paquete (codTipoPaquete, NombrePaquete, FechaInicio, FechaFin, " +
                "HoraInicio, HoraFin,Descripcion, Lugares, InformacionAdicional, Precio, Cupos, Registrados, codAgente) " +
                "values (@codTipoPaquete,   @nombrePaquete, @FechaInicio,   @FechaFin,  @HoraInicio, @HoraFin, @Descripcion, " +
                        "@lugares,          @infoAdicional, @Precio,        @cupos,     @registrados,          @codAgente )";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@codTipoPaquete", PaqueteACrear.TipoPaquete.CodTipoPaquete));
                    com.Parameters.Add(new SqlParameter("@nombrePaquete", PaqueteACrear.NombrePaquete));
                    com.Parameters.Add(new SqlParameter("@FechaInicio", PaqueteACrear.FechaInicio));
                    com.Parameters.Add(new SqlParameter("@FechaFin", PaqueteACrear.FechaFin));
                    com.Parameters.Add(new SqlParameter("@HoraInicio", PaqueteACrear.HoraInicio));
                    com.Parameters.Add(new SqlParameter("@HoraFin", PaqueteACrear.HoraFin));
                    com.Parameters.Add(new SqlParameter("@Descripcion", PaqueteACrear.Descripcion));
                    com.Parameters.Add(new SqlParameter("@lugares", PaqueteACrear.Lugares));
                    com.Parameters.Add(new SqlParameter("@infoAdicional", PaqueteACrear.InformacionAdicional));
                    com.Parameters.Add(new SqlParameter("@Precio", PaqueteACrear.Precio));
                    com.Parameters.Add(new SqlParameter("@cupos", PaqueteACrear.Cupos));
                    com.Parameters.Add(new SqlParameter("@registrados", PaqueteACrear.Registrados));
                    com.Parameters.Add(new SqlParameter("@codAgente", PaqueteACrear.TipoPaquete.CodTipoPaquete));
                    com.ExecuteNonQuery();
                }
            }
            //PaqueteCreado = Obtener(PaqueteACrear.CodPaquete);
            return PaqueteCreado;
        }

        /*
        public Alumno Obtener(string codigo)
        {
            Alumno alumnoEncontrado = null;
            string sql = "select * from t_alumno where codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            alumnoEncontrado = new Alumno()
                            {
                                Codigo = (string)resultado["codigo"],
                                Nombre = (string)resultado["nombre"]
                            };
                        }
                    }
                }
            }
            return alumnoEncontrado;
        }

        
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
        
        
        public void Eliminar(string codigo)
        {
            //Alumno alumnoCreado = null;
            string sql = "delete from t_alumno where codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    com.ExecuteNonQuery();
                }
            }
            //alumnoCreado = Obtener(AlumnoCrear.Codigo);
            //return alumnoCreado;
        }

        public List<Alumno> ListarTodos()
        {
            List<Alumno> ListaAlumnoEncontrado = null;
            ListaAlumnoEncontrado = new List<Alumno>();
            string sql = "select * from t_alumno";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            Alumno alumnoEncontrado = new Alumno()
                            {
                                Codigo = (string)resultado["codigo"],
                                Nombre = (string)resultado["nombre"]
                            };
                            ListaAlumnoEncontrado.Add(alumnoEncontrado);
                        }
                    }
                }
            }
            return ListaAlumnoEncontrado;
        }
        */
    }
}