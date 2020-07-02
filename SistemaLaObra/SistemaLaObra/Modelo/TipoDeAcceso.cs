using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class TipoDeAcceso
    {
        private AccesoDatos acceso;
        private SqlConnection conexion;
        private SqlDataReader lector;
        private SqlCommand consulta;

        public int CodigoTipoAcceso { get; set; }
        public string Descripcion { get; set; }

        public TipoDeAcceso()
        {
            CodigoTipoAcceso = 0;
            Descripcion = "";
        }        

        public void mostrarDatos(int codigoTipoDeAcceso)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand(@"select codigoTipoAcceso, descripcion from TiposDeAccesos 
                                        where codigoTipoAcceso='"+ codigoTipoDeAcceso +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    codigoTipoDeAcceso = int.Parse(lector["codigoTipoAcceso"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<TipoDeAcceso> mostrarDatos()
        {
            List<TipoDeAcceso> lista = new List<TipoDeAcceso>();

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoTipoAcceso, descripcion from TiposDeAccesos", conexion);            
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new TipoDeAcceso() { 
                        CodigoTipoAcceso = int.Parse(lector["codigoTipoAcceso"].ToString()), 
                        Descripcion = lector["descripcion"].ToString() });
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
