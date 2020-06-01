using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    class TipoEncargado
    {
        public List<TipoEncargado> listaTipoEncargado;

        public int CodigoTipoEncargado { get; set; }
        public string Descripcion { get; set; }

        public TipoEncargado()
        {
            CodigoTipoEncargado = 0;
            Descripcion = "";
        }

        private AccesoDatos acceso;
        private SqlConnection conexion;
        private SqlDataReader lector;
        private SqlCommand consulta;

        public void mostrarDatos(int codigoTipoEncargado)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM TiposEncargados WHERE codigoTipoEncargado='" + codigoTipoEncargado + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoTipoEncargado = int.Parse(lector["codigoTipoEncargado"].ToString());
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

        public List<TipoEncargado> mostrarDatosColeccion()
        {
            listaTipoEncargado = new List<TipoEncargado>();

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            conexion.Open();

            try
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM TiposEncargados", conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaTipoEncargado.Add(new TipoEncargado() { CodigoTipoEncargado = int.Parse(lector["codigoTipoEncargado"].ToString()), Descripcion = lector["descripcion"].ToString() });
                }
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return listaTipoEncargado;
        }

    }
}
