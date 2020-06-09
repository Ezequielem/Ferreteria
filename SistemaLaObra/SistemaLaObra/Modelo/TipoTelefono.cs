using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    public class TipoTelefono
    {
        //INSTANCIAS
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        List<TipoTelefono> tiposTelefonos;

        public int CodigoTipoTelefono { get; set; }
        public string Descripcion { get; set; }

        public TipoTelefono()
        {
            CodigoTipoTelefono = 0;
            Descripcion = "";
        }

        //METODOS

        public void mostrarDatos(int codigoTipoTelefono)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM TiposTelefonos WHERE codigoTipoTelefono='" + codigoTipoTelefono + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString());
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

        public List<TipoTelefono> mostrarDatos()
        {
            tiposTelefonos = new List<TipoTelefono>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM TiposTelefonos",conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    tiposTelefonos.Add(new TipoTelefono { CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString()), Descripcion = lector["descripcion"].ToString()});
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
            return tiposTelefonos;
        }

        public int mostrarCodigo(string tipoTel)

        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoTipoTelefono from TiposTelefonos where descripcion='" + tipoTel + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigoTipoTelefono"].ToString());
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public string mostrarNombre(int codigo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoTipoTelefono, descripcion from TiposTelefonos where codigoTipoTelefono='" + codigo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return lector["descripcion"].ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }
    }
}
