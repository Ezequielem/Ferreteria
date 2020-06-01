using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaLaObra
{
    public class TipoArticulo
    {
        //INSTANCIAS
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand consulta;
        SqlCommand alta;
        SqlCommand modificacion;
        SqlDataAdapter adaptador;

        private int _codigoTipoArticulo;
        private string _descripcion;
        private List<Sub1TipoArticulo> _listaSub1TipoArticulo;

        public int CodigoTipoArticulo
        {
            get
            {
                return _codigoTipoArticulo;
            }

            set
            {
                _codigoTipoArticulo = value;
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

        public List<Sub1TipoArticulo> ListaSub1TipoArticulo
        {
            get
            {
                return _listaSub1TipoArticulo;
            }

            set
            {
                _listaSub1TipoArticulo = value;
            }
        }

        public TipoArticulo()
        {
            CodigoTipoArticulo = 0;
            Descripcion = "";
            ListaSub1TipoArticulo = new List<Sub1TipoArticulo>();
        }

        //METODOS

        public void crear(TipoArticulo tipoArticulo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            alta = new SqlCommand("insert into TiposArticulos (descripcion) values (@descripcion)", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));

                adaptador.InsertCommand.Parameters["@descripcion"].Value = tipoArticulo.Descripcion;

                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string error = e.ToString();
            }
            finally
            {
                conexion.Close();
            }
        }

        public TipoArticulo mostrarDatos(int codigoTipoArticulo)
        {            
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoTipoArticulo, descripcion from TiposArticulos where codigoTipoArticulo='"+codigoTipoArticulo+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoTipoArticulo = int.Parse(lector["codigoTipoArticulo"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                    return this;
                }
                else
                {
                    return this;
                }
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

        public List<TipoArticulo> mostrarDatos()
        {
            List<TipoArticulo> lista=new List<TipoArticulo>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoTipoArticulo, descripcion from TiposArticulos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new TipoArticulo() {
                        CodigoTipoArticulo = int.Parse(lector["codigoTipoArticulo"].ToString()),
                        Descripcion = lector["descripcion"].ToString()
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

        public List<Sub1TipoArticulo> mostrarSubCategoria(int codigoTipoArticulo)
        {
            List<Sub1TipoArticulo> lista = new List<Sub1TipoArticulo>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoSub1TipoArticulo, descripcion from Sub1TiposArticulos where codigoTipoArticulo='"+codigoTipoArticulo+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Sub1TipoArticulo()
                    {
                        CodigoSub1TipoArticulo=int.Parse(lector["codigoSub1TipoArticulo"].ToString()),
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

        public void actualizar(TipoArticulo tipoArticulo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            modificacion = new SqlCommand("update TiposArticulos set descripcion=@descripcion where codigoTipoArticulo=@codigoTipoArticulo", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoTipoArticulo", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@descripcion"].Value = tipoArticulo.Descripcion;
            adaptador.UpdateCommand.Parameters["@codigoTipoArticulo"].Value = tipoArticulo.CodigoTipoArticulo;

            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string error = e.ToString();
            } 
            finally
            {
                conexion.Close();
            }
        }

        public int mostrarCodigoUltimoRegistro()
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select max(codigoTipoArticulo) as codigo from TiposArticulos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigo"].ToString());
                }
                return 0;
            }
            catch (Exception e)
            {
                string error = e.ToString();
                return 0;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }
    }
}
