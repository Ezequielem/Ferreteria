using SistemaLaObra.Ventas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class Factura
    {
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        public int CodigoFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FacturadoDesde { get; set; }
        public DateTime FacturadoHasta { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Cae { get; set; }
        public DateTime FechaVencimientoCae { get; set; }
        public int CodigoOtrosAtributos { get; set; }        
        public int CodigoMiEmpresa { get; set; }
        public int CodigoTipoFactura { get; set; }
        public int CodigoProveedor { get; set; }
        public int CodigoVenta { get; set; }
        public MiEmpresa MiEmpresa { get; set; }
        public TipoFactura TipoFactura { get; set; }
        public Proveedor Proveedor { get; set; }
        public Venta Venta { get; set; }

        public Factura()
        {
            CodigoFactura = 0;
            FechaEmision = DateTime.Today;
            FacturadoDesde = DateTime.Today;
            FacturadoHasta = DateTime.Today;
            FechaVencimiento = DateTime.Today;
            Cae = string.Empty;
            FechaVencimientoCae = DateTime.Today;
            CodigoOtrosAtributos = 0;
            CodigoMiEmpresa = 0;
            CodigoTipoFactura = 0;
            CodigoProveedor = 0;
            CodigoVenta = 0;
            MiEmpresa = new MiEmpresa();
            TipoFactura = new TipoFactura();
            Proveedor = new Proveedor();
            Venta = new Venta();
        }

        public void crear(Factura factura)
        {

        }

        public void modificar(Factura factura)
        {

        }

        public void mostrarDatos(int codigo)
        {

        }

        public List<Factura> mostrarDatos()
        {
            List<Factura> lista = new List<Factura>();
            return lista;
        }

        public bool existe(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select * from Facturas where codigoFactura='"+ codigo +"'", conexion);
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
