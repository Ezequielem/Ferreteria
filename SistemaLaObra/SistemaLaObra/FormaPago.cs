using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    public class FormaPago
    {
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        List<FormaPago> formaPagos;

        public int CodigoFormaPago { get; set; }
        public string Descripcion { get; set; }

        public FormaPago()
        {
            CodigoFormaPago = 0;
            Descripcion = "";
            formaPagos = new List<FormaPago>();
        }

        public void mostrarDatos(int codigoFormaPago)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM FormaPagos WHERE codigoFormaPago='"+codigoFormaPago+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoFormaPago = int.Parse(lector["codigoFormaPago"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<FormaPago> mostrarDatosColeccion()
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM FormaPagos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    formaPagos.Add(new FormaPago { CodigoFormaPago = int.Parse(lector["codigoFormaPago"].ToString()), Descripcion = lector["descripcion"].ToString() });
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return formaPagos;
        }

        public int obtenerCodigoFormaPago(string formaPago)
        {
            int codigoFormaPago = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoFormaPago FROM FormaPagos WHERE descripcion='"+formaPago+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    codigoFormaPago = int.Parse(lector["codigoFormaPago"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return codigoFormaPago;
        }

    }
}
