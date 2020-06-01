using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaLaObra
{
    public class Provincia
    {
        //INSTANCIAS
        private List<Provincia> listaProvincia;
        private AccesoDatos acceso;
        private SqlConnection conexion;
        private SqlDataReader lector;
        private List<Departamento> listaDepartamento;

        //ATRIBUTOS
        private int _codigoProvincia;
        private string _nombreProvincia;

        public int CodigoProvincia
        {
            get
            {
                return _codigoProvincia;
            }

            set
            {
                _codigoProvincia = value;
            }
        }
        public string NombreProvincia
        {
            get
            {
                return _nombreProvincia;
            }

            set
            {
                _nombreProvincia = value;
            }
        }

        public Provincia()
        {
            CodigoProvincia = 0;
            NombreProvincia = "";
        }

        //METODOS

        public void mostrarDatos(int codProvincia)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("SELECT codigoProvincia, descripcion FROM Provincias WHERE codigoProvincia = '" + codProvincia + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoProvincia = int.Parse(lector["codigoProvincia"].ToString());
                    NombreProvincia = lector["descripcion"].ToString();
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
        }
    
        public List<Provincia> mostrarDatosColeccion()
        {
            listaProvincia = new List<Provincia>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoProvincia, descripcion from Provincias", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaProvincia.Add(new Provincia() {CodigoProvincia=int.Parse(lector["codigoProvincia"].ToString()), NombreProvincia=lector["descripcion"].ToString() });
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
            return listaProvincia;
        }

        public List<Departamento> conocerDepartamento(int codigoProvincia)
        {
            listaDepartamento = new List<Departamento>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoDepartamento, descripcion from Departamentos where codigoProvincia='" + codigoProvincia + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaDepartamento.Add(new Departamento() { CodigoDepartamento=int.Parse(lector["codigoDepartamento"].ToString()), NombreDepartamento=lector["descripcion"].ToString()});
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
            return listaDepartamento;
        }

        public string mostrarNombre(int codigoProvincia)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Provincias where codigoProvincia='" + codigoProvincia + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {                    
                    NombreProvincia = lector["descripcion"].ToString();
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
            return NombreProvincia;
        }

        public int mostrarCodigo(string nombreProvincia)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoProvincia from Provincias where descripcion='" + nombreProvincia + "'", conexion);
            try
            {
                conexion.Open();    
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoProvincia = int.Parse(lector["codigoProvincia"].ToString());
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
            return CodigoProvincia;
        }
    }
}
