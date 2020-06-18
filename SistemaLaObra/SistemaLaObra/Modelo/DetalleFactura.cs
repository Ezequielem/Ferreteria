using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class DetalleFactura
    {
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        public int CodigoDetalleFactura { get; set; }
        public float Iva { get; set; }
        public float Bonificacion { get; set; }
        public int Cantidad { get; set; }
        public int CodigoArticulo { get; set; }
        public int CodigoFactura { get; set; }
        public Articulo Articulo { get; set; }
        public Factura Factura { get; set; }

        public DetalleFactura()
        {
            CodigoDetalleFactura = 0;
            Iva = 0f;
            Bonificacion = 0f;
            Cantidad = 0;
            CodigoArticulo = 0;
            CodigoFactura = 0;
            Articulo = new Articulo();
            Factura = new Factura();
        }

        public void crear(DetalleFactura detalleFactura)
        {

        }

        public void modificar(DetalleFactura detalleFactura)
        {

        }

        public void mostrarDatos(int codigo)
        {

        }

        public List<DetalleFactura> mostrarDatos()
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            return lista;
        }

        public bool existe(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select * from DetallesFactura where codigoDetalleFactura='"+ codigo +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }
    }
}
