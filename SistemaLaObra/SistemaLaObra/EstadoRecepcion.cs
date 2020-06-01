using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaLaObra
{
    public class EstadoRecepcion
    {
        //INSTANCIAS
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;
        AccesoDatos acceso;

        //ATRIBUTOS
        private int _codigoEstadoRecepcion;
        private string _descripcion;

        public int CodigoEstadoRecepcion
        {
            get
            {
                return _codigoEstadoRecepcion;
            }

            set
            {
                _codigoEstadoRecepcion = value;
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
        public EstadoRecepcion()
        {
            CodigoEstadoRecepcion = 0;
            Descripcion = "PENDIENTE";
        }        

        //METODOS

        public void crear()
        {

        }

        public string mostrarDescripcion(int codigoEstado)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select descripcion from EstadoRecepciones where codigoEstadoRecepcion='" + codigoEstado + "'", conexion);
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
