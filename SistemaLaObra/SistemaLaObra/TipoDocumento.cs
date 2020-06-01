using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    class TipoDocumento
    {

        AccesoDatos acceso;
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        List<TipoDocumento> listaTiposDocumento;

        public int CodigoTipoDocumento { get; set; }
        public string Descripcion { get; set; }

        public TipoDocumento()
        {
            CodigoTipoDocumento = 0;
            Descripcion = "";
        }

        public void mostrarDatos(int codigoTipoDocumento)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM TiposDocumentos WHERE codigoTipoDocumento='"+codigoTipoDocumento+"'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoTipoDocumento = int.Parse(lector["codigoTipoDocumento"].ToString());
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

        public List<TipoDocumento> mostrarDatosColeccion()
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM TiposDocumentos", conexion);
            listaTiposDocumento = new List<TipoDocumento>();

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaTiposDocumento.Add(new TipoDocumento { CodigoTipoDocumento = int.Parse(lector["codigoTipoDocumento"].ToString()), Descripcion = lector["descripcion"].ToString() });
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

            return listaTiposDocumento;
        }
    }
}
