using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra
{
    public class EstadoEntrega
    {        
        //INSTANCIAS
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        AccesoDatos acceso;

        //ATRIBUTOS
        private int _codigoEstadoEntrega;
        private string _descripcion;

        public int CodigoEstadoEntrega
        {
            get
            {
                return _codigoEstadoEntrega;
            }

            set
            {
                _codigoEstadoEntrega = value;
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


        //CONSTRUCTOR
        public EstadoEntrega()
        {
            CodigoEstadoEntrega = 1;
            Descripcion = "EN CURSO";
        }

        //METODOS

        public void crear()
        {

        }

        public string mostrarDescripcion(int codigoEstado)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select descripcion from EstadoEntregas where codigoEstadoEntrega='"+codigoEstado+"'", conexion);
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
                    return Descripcion;
                }
            }
            catch (Exception)
            {
                return Descripcion;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
