using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class SistemaDeFacturacion
    {
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;

        public int CodigoSistemaFacturacion { get; set; }
        public string Descripcion { get; set; }

        public SistemaDeFacturacion()
        {
            CodigoSistemaFacturacion = 0;
            Descripcion = string.Empty;
        }

        public void mostrarDatos(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select codigoSistemaFacturacion, descripcion from SistemasFacturacion where codigoSistemaFacturacion='" + codigo +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoSistemaFacturacion = int.Parse(lector["codigoPuntoVenta"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public List<SistemaDeFacturacion> mostrarDatos()
        {
            List<SistemaDeFacturacion> lista = new List<SistemaDeFacturacion>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select codigoSistemaFacturacion, descripcion from SistemasFacturacion", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new SistemaDeFacturacion() 
                    {
                        CodigoSistemaFacturacion = int.Parse(lector["codigoPuntoVenta"].ToString()),
                    Descripcion = lector["descripcion"].ToString()
                    });                    
                }
                return lista;
            }
            catch (Exception e)
            {                
                MessageBox.Show(e.Message);
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
