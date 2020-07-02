using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    public class HistorialSesion
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;

        public int CodigoHistorial { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraCierre { get; set; }
        public int CodigoUsuario { get; set; }
        
        public HistorialSesion()
        {
            CodigoHistorial = 0;
            CodigoUsuario = 0;
        }

        public void crear(HistorialSesion historial)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            adaptador = new SqlDataAdapter();

            SqlCommand alta = new SqlCommand("INSERT INTO HistorialSesiones (codigoHistorial,fechaHoraInicio,codigoUsuario) VALUES (@codigoHistorial,@fechaHoraInicio,@codigoUsuario)", conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoHistorial", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaHoraInicio", SqlDbType.DateTime));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoUsuario", SqlDbType.Int));

            adaptador.InsertCommand.Parameters["@codigoHistorial"].Value = historial.CodigoHistorial;
            adaptador.InsertCommand.Parameters["@fechaHoraInicio"].Value = historial.FechaHoraInicio;
            adaptador.InsertCommand.Parameters["@codigoUsuario"].Value = historial.CodigoUsuario;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public int ultimoNumeroHistorial()
        {
            int ultimoNumeroHistorial = 0;
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("SELECT MAX(codigoHistorial) AS codigo FROM HistorialSesiones", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    int valor;
                    bool resultado = int.TryParse(lector["codigo"].ToString(), out valor);
                    if (resultado)
                    {
                        ultimoNumeroHistorial = valor;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
            }
            return ultimoNumeroHistorial;
        }

        public void actualizarHistorial(int codigoHistorial, DateTime fechaHoraCierre)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            adaptador = new SqlDataAdapter();

            SqlCommand modificacion = new SqlCommand("UPDATE HistorialSesiones SET fechaHoraCierre=@fechaHoraCierre WHERE codigoHistorial=@codigoHistorial", conexion);
            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoHistorial", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fechaHoraCierre", SqlDbType.DateTime));

            adaptador.UpdateCommand.Parameters["@codigoHistorial"].Value = codigoHistorial;
            adaptador.UpdateCommand.Parameters["@fechaHoraCierre"].Value = fechaHoraCierre;

            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<HistorialSesion> mostrarDatos(int codigoUsuario)
        {
            List<HistorialSesion> lista = new List<HistorialSesion>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand(@"SELECT * FROM HistorialSesiones 
                                                    WHERE codigoUsuario='" + codigoUsuario + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    DateTime fechaHoraCierre;
                    bool resultado = DateTime.TryParse(lector["fechaHoraCierre"].ToString(), out fechaHoraCierre);
                    if (resultado)
                    {
                        lista.Add(new HistorialSesion()
                        {
                            CodigoHistorial = int.Parse(lector["codigoHistorial"].ToString()),
                            FechaHoraInicio = (DateTime)lector["fechaHoraInicio"],
                            FechaHoraCierre = fechaHoraCierre
                        });
                    }
                    else
                    {
                        lista.Add(new HistorialSesion()
                        {
                            CodigoHistorial = int.Parse(lector["codigoHistorial"].ToString()),
                            FechaHoraInicio = (DateTime)lector["fechaHoraInicio"]
                        });
                    }
                }
                return lista;
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                return lista;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }            
        }
    }
}
