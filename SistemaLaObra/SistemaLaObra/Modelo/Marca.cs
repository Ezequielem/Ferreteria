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
    public class Marca
    {
        //SQL
        AccesoDatos acceso;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;
        SqlConnection conexion;

        //INSTANCIAS
        private int _codigoMarca;
        private string _descripcion;

        public int CodigoMarca
        {
            get
            {
                return _codigoMarca;
            }

            set
            {
                _codigoMarca = value;
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

        public Marca()
        {
            CodigoMarca = 0;
            Descripcion = "";
        }

        //METODOS  

        public void crear(Marca marca)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("insert into Marcas (descripcion) values (@descripcion)", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.InsertCommand = consulta;

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@descripcion"].Value = marca.Descripcion;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void actualizar(Marca marca)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("update Marcas set descripcion=@descripcion where codigoMarca=@codigoMarca", conexion);
            adaptador = new SqlDataAdapter();

            adaptador.UpdateCommand = consulta;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoMarca", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codigoMarca"].Value = marca.CodigoMarca;
            adaptador.UpdateCommand.Parameters["@descripcion"].Value = marca.Descripcion;

            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public Marca mostrarDatos(int id)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoMarca, descripcion from Marcas where codigoMarca='" + id + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoMarca= int.Parse(lector["codigoMarca"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                }
                return this;
            }
            catch (Exception)
            {
                return this;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<Marca> mostrarDatos()
        {
            List<Marca> lista = new List<Marca>();            
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoMarca, descripcion from Marcas", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Marca() 
                    {
                        CodigoMarca = int.Parse(lector["codigoMarca"].ToString()),
                        Descripcion = lector["descripcion"].ToString()
                    });

                }
                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public bool existe(int id)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoMarca, descripcion from Marcas where codigoMarca='"+ id +"'", conexion);
            try
            {
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
         }

        public bool existe(string nombre)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoMarca, descripcion from Marcas where descripcion='" + nombre + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }
    }
}
