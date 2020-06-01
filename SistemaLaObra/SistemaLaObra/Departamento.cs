using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaLaObra
{
    public class Departamento
    {
        //INSTANCIAS
        private AccesoDatos acceso;
        private SqlDataReader lector;
        private SqlConnection conexion;
        private List<Localidad> listaLocalidad;

        //ATRIBUTOS
        private int _codigoDepartamento;
        private string _nombreDepartamento;
        

        public int CodigoDepartamento
        {
            get
            {
                return _codigoDepartamento;
            }

            set
            {
                _codigoDepartamento = value;
            }
        }

        public string NombreDepartamento
        {
            get
            {
                return _nombreDepartamento;
            }

            set
            {
                _nombreDepartamento = value;
            }
        }

        public Departamento()
        {
            CodigoDepartamento = 0;
            NombreDepartamento = "";                 
        }

        //METODOS

        public List<Localidad> conocerLocalidad(int codigoDepartamento)
        {
            listaLocalidad = new List<Localidad>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoLocalidad, descripcion from Localidades where codigoDepartamento='" + codigoDepartamento + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaLocalidad.Add(new Localidad() { CodigoLocalidad=int.Parse(lector["codigoLocalidad"].ToString()), NombreLocalidad=lector["descripcion"].ToString()});
                }
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return listaLocalidad;
        }

        public string mostrarNombre(int codigoDepartamento)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Departamentos where codigoDepartamento='" + codigoDepartamento + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    NombreDepartamento = lector["descripcion"].ToString();
                } 
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return NombreDepartamento;
        }

        public int mostrarCodigo(string nombreDepartamento, int codigoProvincia)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoDepartamento from Departamentos where codigoProvincia ='" + codigoProvincia + "' and  descripcion ='" + nombreDepartamento + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoDepartamento = int.Parse(lector["codigoDepartamento"].ToString());
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
            return CodigoDepartamento;
        }        
    }
}

