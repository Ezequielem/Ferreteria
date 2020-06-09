using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaLaObra
{
    public class Localidad
    {
        //INSTANCIAS
        private AccesoDatos acceso;
        private SqlDataReader lector;
        private SqlConnection conexion;

        public int CodigoLocalidad { get; set; }
        public string NombreLocalidad { get; set; }
        public Departamento Departamento { get; set; }

        public Localidad()
        {
            CodigoLocalidad = 0;
            NombreLocalidad = "";
            Departamento = new Departamento();
        }

        //METODOS

        public List<Localidad> mostrarDatos()
        {
            List<Localidad> listaLocalidad = new List<Localidad>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoLocalidad, descripcion from Localidades", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaLocalidad.Add(new Localidad() { CodigoLocalidad=int.Parse(lector["codigoLocalidad"].ToString()), NombreLocalidad=lector["descripcion"].ToString() });
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

        public void mostrarDatos(int localidad)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoDepartamento, codigoLocalidad, descripcion from Localidades where codigoLocalidad='" + localidad + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());
                    NombreLocalidad = lector["descripcion"].ToString() ;
                    Departamento.mostrarDatos(int.Parse(lector["codigoDepartamento"].ToString()));
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

        public int mostrarCodigo (string nombreLocalidad, int codigoLocalidad)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoLocalidad from Localidades where codigoDepartamento= '" + codigoLocalidad + "'and descripcion='" + nombreLocalidad + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());
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
            return CodigoLocalidad;
        }       

        public string mostrarNombre(int codigoLocalidad)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Localidades where codigoLocalidad='" + codigoLocalidad + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    NombreLocalidad = lector["descripcion"].ToString();
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
            return NombreLocalidad;
        }       
    }
}
