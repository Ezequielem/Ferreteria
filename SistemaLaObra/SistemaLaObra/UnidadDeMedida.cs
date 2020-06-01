using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaLaObra
{
    public class UnidadDeMedida
    {
        //INSTANCIAS
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;

        private int _codigoUnidadDeMedida;
        private string _descripcion;

        public int CodigoUnidadDeMedida
        {
            get
            {
                return _codigoUnidadDeMedida;
            }

            set
            {
                _codigoUnidadDeMedida = value;
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

        public UnidadDeMedida()
        {
            CodigoUnidadDeMedida = 0;
            Descripcion = "";
        }

        //METODOS

        public UnidadDeMedida mostrarDatos(int codigoUnidadDeMedida)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoUnidadDeMedida, descripcion from UnidadesDeMedida where codigoUnidadDeMedida='"+codigoUnidadDeMedida+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoUnidadDeMedida = int.Parse(lector["codigoUnidadDeMedida"].ToString());
                    Descripcion = lector["descripcion"].ToString();                   
                }
                return this;
            }
            catch (Exception e)
            {
                string error = e.ToString();
                return this;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<UnidadDeMedida> mostrarDatos()
        {
            List<UnidadDeMedida> lista = new List<UnidadDeMedida>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoUnidadDeMedida, descripcion from UnidadesDeMedida", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new UnidadDeMedida() {
                        CodigoUnidadDeMedida = int.Parse(lector["codigoUnidadDeMedida"].ToString()),
                        Descripcion=lector["descripcion"].ToString()
                    });                                        
                }
                return lista;
            }
            catch (Exception e)
            {
                string error = e.ToString();
                return lista;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }
    }
}
