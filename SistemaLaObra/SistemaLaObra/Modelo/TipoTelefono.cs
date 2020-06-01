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

        //ATRIBUTOS
        int _codigoTipoTelefono;
        string _descripcion;
        
        public int CodigoTipoTelefono
        {
            get
            {
                return _codigoTipoTelefono;
            }

            set
            {
                _codigoTipoTelefono = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

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

        public List<TipoTelefono> mostrarDatosColeccion()
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
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
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
            }
        }

    }
}
