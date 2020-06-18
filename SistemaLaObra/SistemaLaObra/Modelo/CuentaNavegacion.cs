using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class CuentaNavegacion
    {
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        public int CodigoCuentaNavegacion { get; set; }
        public string ProveedorCuenta { get; set; }
        public string ApiKey { get; set; }
        public string ClientKey { get; set; }
        public bool Predeterminada { get; set; }
        public bool Habilitada { get; set; }
        public int CodigoMiEmpresa { get; set; }
        public MiEmpresa MiEmpresa { get; set; }

        public CuentaNavegacion()
        {
            CodigoCuentaNavegacion = 0;
            ProveedorCuenta = string.Empty;
            ApiKey = string.Empty;
            ClientKey = string.Empty;
            Predeterminada = false;
            Habilitada = false;
            CodigoMiEmpresa = 0;
            MiEmpresa = new MiEmpresa();
        }

        public void crear(CuentaNavegacion cuentaNavegacion)
        { 
        
        }

        public void modificar(CuentaNavegacion cuentaNavegacion)
        {

        }

        public void mostrarDatos(int codigo)
        {

        }

        public List<CuentaNavegacion> mostrarDatos()
        {
            List<CuentaNavegacion> lista = new List<CuentaNavegacion>();
            return lista;
        }

        public bool existe(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select * from CuentasNavegacion where codigoCuentaNavegacion='"+ codigo +"'", conexion);
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
