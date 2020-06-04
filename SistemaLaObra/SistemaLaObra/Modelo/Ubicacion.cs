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
    public class Ubicacion
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;
        AccesoDatos acceso;

        //INSTANCIAS
        private int _codigoUbicacion;
        private string _descripcion;

        public int CodigoUbicacion
        {
            get
            {
                return _codigoUbicacion;
            }

            set
            {
                _codigoUbicacion = value;
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

        public Ubicacion()
        {
            CodigoUbicacion = 0;
            Descripcion = "";
        }

        public void crear(Ubicacion ubicacion)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("insert into Ubicaciones (descripcion) values(@descripcion)", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.InsertCommand = consulta;

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));

            adaptador.InsertCommand.Parameters["@descripcion"].Value = ubicacion.Descripcion;

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

        public Ubicacion mostrarDatos(int codigoUbicacion)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoUbicacion, descripcion from Ubicaciones where codigoUbicacion='"+codigoUbicacion+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoUbicacion = int.Parse(lector["codigoUbicacion"].ToString());
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
        
        public List<Ubicacion> mostrarDatos()
        {
            List<Ubicacion> lista = new List<Ubicacion>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoUbicacion, descripcion from Ubicaciones", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Ubicacion() {
                        CodigoUbicacion = int.Parse(lector["codigoUbicacion"].ToString()),
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

        public void actualizarDatos(Ubicacion ubicacion)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("update Ubicaciones set descripcion=@descripcion where codigoUbicacion=@codigoUbicacion", conexion);
            adaptador = new SqlDataAdapter();

            adaptador.UpdateCommand = consulta;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoUbicacion", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));

            adaptador.UpdateCommand.Parameters["@codigoUbicacion"].Value = ubicacion.CodigoUbicacion;
            adaptador.UpdateCommand.Parameters["@descripcion"].Value = ubicacion.Descripcion;

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

        public bool existe(int id)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoUbicacion, descripcion from Ubicaciones where codigoUbicacion='"+ id +"'", conexion);
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

        public bool existe(string nombre)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoUbicacion, descripcion from Ubicaciones where descripcion='" + nombre + "'", conexion);
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
