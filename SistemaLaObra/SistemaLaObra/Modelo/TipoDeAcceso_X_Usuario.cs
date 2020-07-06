using SistemaLaObra.InicioSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class TipoDeAcceso_X_Usuario
    {
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        public int CodigoTipoAcceso { get; set; }
        public int CodigoUsuario { get; set; }

        public TipoDeAcceso_X_Usuario()
        {
            CodigoTipoAcceso = 0;
            CodigoUsuario = 0;
        }

        //METODOS

        public void crear(TipoDeAcceso tipoAcceso, Usuario usuario)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("insert into TiposDeAccesos_X_Usuarios (CodigoTipoAcceso, CodigoUsuario) values (@CodigoTipoAcceso, @CodigoUsuario)", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = consulta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@CodigoTipoAcceso", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@CodigoUsuario", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@CodigoTipoAcceso"].Value = tipoAcceso.CodigoTipoAcceso;
                adaptador.InsertCommand.Parameters["@CodigoUsuario"].Value = usuario.CodigoUsuario;

                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void actualizar()
        {

        }

        public List<TipoDeAcceso_X_Usuario> mostrarDatos()
        {
            List<TipoDeAcceso_X_Usuario> lista = new List<TipoDeAcceso_X_Usuario>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select CodigoTipoAcceso, CodigoUsuario from TiposDeAccesos_X_Usuarios", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new TipoDeAcceso_X_Usuario()
                    {
                        CodigoTipoAcceso = int.Parse(lector["CodigoTipoAcceso"].ToString()),
                        CodigoUsuario = int.Parse(lector["CodigoUsuario"].ToString())
                    });
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return lista;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public List<TipoDeAcceso_X_Usuario> mostrarDatos(TipoDeAcceso tipoDeAcceso)
        {
            List<TipoDeAcceso_X_Usuario> lista = new List<TipoDeAcceso_X_Usuario>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"select CodigoTipoAcceso, CodigoUsuario from TiposDeAccesos_X_Usuarios 
                                        where CodigoTipoAcceso='"+ tipoDeAcceso.CodigoTipoAcceso +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new TipoDeAcceso_X_Usuario() 
                    {
                        CodigoTipoAcceso = int.Parse(lector["CodigoTipoAcceso"].ToString()),
                        CodigoUsuario = int.Parse(lector["CodigoUsuario"].ToString())
                    });                    
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return lista;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public List<TipoDeAcceso_X_Usuario> mostrarDatos(Usuario usuario)
        {
            List<TipoDeAcceso_X_Usuario> lista = new List<TipoDeAcceso_X_Usuario>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"select CodigoTipoAcceso, CodigoUsuario from TiposDeAccesos_X_Usuarios 
                                        where CodigoUsuario='" + usuario.CodigoUsuario + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new TipoDeAcceso_X_Usuario()
                    {
                        CodigoTipoAcceso = int.Parse(lector["CodigoTipoAcceso"].ToString()),
                        CodigoUsuario = int.Parse(lector["CodigoUsuario"].ToString())
                    });                    
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return lista;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public bool existe(TipoDeAcceso_X_Usuario objeto)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select CodigoTipoAcceso, CodigoUsuario from TiposDeAccesos_X_Usuarios where CodigoTipoAcceso='"+ objeto.CodigoTipoAcceso +"' and CodigoUsuario='"+ objeto.CodigoUsuario +"'", conexion);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
