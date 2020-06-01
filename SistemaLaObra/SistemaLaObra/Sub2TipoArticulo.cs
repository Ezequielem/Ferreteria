using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaLaObra
{
    public class Sub2TipoArticulo
    {
        //INSTANCIAS
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand consulta;
        SqlCommand alta;
        SqlCommand modificacion;
        SqlDataAdapter adaptador;

        private int _codigoSub2TipoArticulo;
        private string _descripcion;
        private int _codigoSub1TipoArticulo;
        private List<Sub3TipoArticulo> _listaSub3TipoArticulo;

        public int CodigoSub2TipoArticulo
        {
            get
            {
                return _codigoSub2TipoArticulo;
            }

            set
            {
                _codigoSub2TipoArticulo = value;
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

        public int CodigoSub1TipoArticulo
        {
            get
            {
                return _codigoSub1TipoArticulo;
            }

            set
            {
                _codigoSub1TipoArticulo = value;
            }
        }

        public List<Sub3TipoArticulo> ListaSub3TipoArticulo
        {
            get
            {
                return _listaSub3TipoArticulo;
            }

            set
            {
                _listaSub3TipoArticulo = value;
            }
        }

        public Sub2TipoArticulo()
        {
            CodigoSub2TipoArticulo = 0;
            Descripcion = "";
            CodigoSub1TipoArticulo = 0;
            ListaSub3TipoArticulo = new List<Sub3TipoArticulo>();
        }

        //METODOS

        public void crear(Sub2TipoArticulo sub2TipoArticulo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            alta = new SqlCommand("insert into Sub2TiposArticulos (descripcion, codigoSub1TipoArticulo) values (@descripcion, @codigoSub1TipoArticulo)", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoSub1TipoArticulo", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@descripcion"].Value = sub2TipoArticulo.Descripcion;
                adaptador.InsertCommand.Parameters["@codigoSub1TipoArticulo"].Value = sub2TipoArticulo.CodigoSub1TipoArticulo;

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

        public Sub2TipoArticulo mostrarDatos( int codigoSub2TipoArticulo)
        {            
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoSub2TipoArticulo, descripcion, codigoSub1TipoArticulo from Sub2TiposArticulos where codigoSub2TipoArticulo='"+ codigoSub2TipoArticulo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoSub2TipoArticulo = int.Parse(lector["codigoSub2TipoArticulo"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                    CodigoSub1TipoArticulo = int.Parse(lector["codigoSub1TipoArticulo"].ToString());
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

        public List<Sub2TipoArticulo> mostrarDatos()
        {
            List<Sub2TipoArticulo> lista = new List<Sub2TipoArticulo>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoSub2TipoArticulo, descripcion, codigoSub1TipoArticulo from Sub2TiposArticulos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Sub2TipoArticulo()
                    {
                        CodigoSub2TipoArticulo = int.Parse(lector["codigoSub2TipoArticulo"].ToString()),
                        Descripcion = lector["descripcion"].ToString(),
                        CodigoSub1TipoArticulo = int.Parse(lector["codigoSub1TipoArticulo"].ToString())
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

        public List<Sub3TipoArticulo> mostrarSubCategorias(int codigoSub2TipoArticulo)
        {
            List<Sub3TipoArticulo> lista = new List<Sub3TipoArticulo>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoSub3TipoArticulo, descripcion from Sub3TiposArticulos where codigoSub2TipoArticulo='" + codigoSub2TipoArticulo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Sub3TipoArticulo()
                    {
                        CodigoSub3TipoArticulo = int.Parse(lector["codigoSub3TipoArticulo"].ToString()),
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

        public void actualizar(Sub2TipoArticulo sub2TipoArticulo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            modificacion = new SqlCommand("update Sub2TiposArticulos set descripcion=@descripcion where codigoSub2TipoArticulo=@codigoSub2TipoArticulo", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoSub2TipoArticulo", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@descripcion"].Value = sub2TipoArticulo.Descripcion;
            adaptador.UpdateCommand.Parameters["@codigoSub2TipoArticulo"].Value = sub2TipoArticulo.CodigoSub2TipoArticulo;

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
            consulta = new SqlCommand("select max(codigoSub2TipoArticulo) as codigo from Sub2TiposArticulos", conexion);
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
