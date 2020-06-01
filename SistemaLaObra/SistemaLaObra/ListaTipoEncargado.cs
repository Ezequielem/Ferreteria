using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    class ListaTipoEncargado
    {

        AccesoDatos acceso;
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;

        public int CodigoListaTipoEncargado { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoTipoEncargado { get; set; }

        List<ListaTipoEncargado> listaTipoEncargado;

        public ListaTipoEncargado()
        {
            CodigoListaTipoEncargado = 0;
            CodigoUsuario = 0;
            CodigoTipoEncargado = 0;
        }

        public void actualizarTipoEncargado(int codigoTipoEncargado, int codigoUsuario)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("UPDATE ListaTiposEncargados SET codigoTipoEncargado='"+codigoTipoEncargado+"' WHERE codigoUsuario='"+codigoUsuario+"'",conexion);
            try
            {
                conexion.Open();
                consulta.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<ListaTipoEncargado> mostrarDatosColeccion()
        {
            listaTipoEncargado = new List<ListaTipoEncargado>();

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            conexion.Open();

            try
            {
                consulta = new SqlCommand("SELECT * FROM ListaTiposEncargados", conexion);
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaTipoEncargado.Add(new ListaTipoEncargado() { CodigoListaTipoEncargado = int.Parse(lector["codigoListaTipoEncargado"].ToString()), CodigoUsuario = int.Parse(lector["codigoUsuario"].ToString()), CodigoTipoEncargado = int.Parse(lector["codigoTipoEncargado"].ToString()) });
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

        public int obtenerCodigoTipoEncargado(int codigoUsuario)
        {
            int codigoTipoEncargado = 0;

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            conexion.Open();

            try
            {
                consulta = new SqlCommand("SELECT codigoTipoEncargado FROM ListaTiposEncargados WHERE codigoUsuario='"+codigoUsuario+"'", conexion);
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    codigoTipoEncargado = int.Parse(lector["codigoTipoEncargado"].ToString());    
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
            return codigoTipoEncargado;
        }

    }
}
