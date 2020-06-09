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

        public int CodigoDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public Provincia Provincia { get; set; }

        public Departamento()
        {
            CodigoDepartamento = 0;
            NombreDepartamento = "";
            Provincia = new Provincia();
        }

        //METODOS

        public void mostrarDatos(int departamento)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoDepartamento, codigoProvincia, descripcion from Departamentos where codigoDepartamento='"+ departamento +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoDepartamento = int.Parse(lector["codigoDepartamento"].ToString());
                    NombreDepartamento = lector["descripcion"].ToString();
                    Provincia.mostrarDatos(int.Parse(lector["codigoProvincia"].ToString()));
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

        public List<Departamento> mostrarDatos()
        {
            List<Departamento> lista = new List<Departamento>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoDepartamento, codigoProvincia, descripcion from Departamentos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Departamento(){
                        CodigoDepartamento = int.Parse(lector["codigoDepartamento"].ToString()),
                        NombreDepartamento = lector["descripcion"].ToString()
                    });                    
                }
                return lista;
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                return lista;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<Localidad> conocerLocalidad(int codigoDepartamento)
        {
            List<Localidad> listaLocalidad = new List<Localidad>();
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

