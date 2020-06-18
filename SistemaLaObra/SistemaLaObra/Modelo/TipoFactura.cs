using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class TipoFactura
    {
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adptador;

        public int CodigoTipoFactura { get; set; }
        public string Descripcion { get; set; }
        public Factura Factura { get; set; }

        public TipoFactura()
        {
            CodigoTipoFactura = 0;
            Descripcion = string.Empty;
        }

        public void mostrarDatos(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select codigoTipoFactura, descripcion from TiposFacturas where codigoTipoFactura='"+ codigo +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoTipoFactura = int.Parse(lector["codigoTipoFactura"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public List<TipoFactura> mostrarDatos()
        {
            List<TipoFactura> lista = new List<TipoFactura>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select codigoTipoFactura, descripcion from TiposFacturas", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new TipoFactura()
                    {
                        CodigoTipoFactura = int.Parse(lector["codigoTipoFactura"].ToString()),
                        Descripcion = lector["descripcion"].ToString()
                    });
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
