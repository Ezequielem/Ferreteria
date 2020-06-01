using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaLaObra
{
    public class Sub1TipoArticulo
    {
        //INSTANCIAS
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand consulta;
        SqlCommand alta;
        SqlCommand modificacion;
        SqlDataAdapter adaptador;

        private int _codigoSub1TipoArticulo;
        private string _descripcion;
        private int _codigoTipoArticulo;
        private List<Sub2TipoArticulo> _listaSub2TipoArticulo;

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

        public List<Sub2TipoArticulo> ListaSub2TipoArticulo
        {
            get
            {
                return _listaSub2TipoArticulo;
            }

            set
            {
                _listaSub2TipoArticulo = value;
            }
        }

        public Sub1TipoArticulo()
        {
            CodigoSub1TipoArticulo = 0;
            Descripcion = "";
            CodigoTipoArticulo = 0;
            ListaSub2TipoArticulo = new List<Sub2TipoArticulo>();
        }

        //METODOS

        public void crear(Sub1TipoArticulo sub1TipoArticulo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            alta = new SqlCommand("insert into Sub1TiposArticulos (descripcion, codigoTipoArticulo) values (@descripcion, @codigoTipoArticulo)", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTipoArticulo", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@descripcion"].Value = sub1TipoArticulo.Descripcion;
                adaptador.InsertCommand.Parameters["@codigoTipoArticulo"].Value = sub1TipoArticulo.CodigoTipoArticulo;

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

        public Sub1TipoArticulo mostrarDatos(int codigoSub1TipoArticulo)
        {            
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoSub1TipoArticulo, descripcion, codigoTipoArticulo from Sub1TiposArticulos where codigoSub1TipoArticulo='"+codigoSub1TipoArticulo+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoSub1TipoArticulo = int.Parse(lector["codigoSub1TipoArticulo"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                    CodigoTipoArticulo = int.Parse(lector["codigoTipoArticulo"].ToString());
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

        public List<Sub1TipoArticulo> mostrarDatos()
        {
            List<Sub1TipoArticulo> lista = new List<Sub1TipoArticulo>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoSub1TipoArticulo, descripcion, codigoTipoArticulo from Sub1TiposArticulos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Sub1TipoArticulo()
                    {
                        CodigoSub1TipoArticulo = int.Parse(lector["codigoSub1TipoArticulo"].ToString()),
                        Descripcion = lector["descripcion"].ToString(),
                        CodigoTipoArticulo = int.Parse(lector["codigoTipoArticulo"].ToString())
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

        public List<Sub2TipoArticulo> mostrarSubCategorias(int codigoSub1TipoArticulo)
        {
            List<Sub2TipoArticulo> lista = new List<Sub2TipoArticulo>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoSub2TipoArticulo, descripcion from Sub2TiposArticulos where codigoSub1TipoArticulo='" + codigoSub1TipoArticulo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Sub2TipoArticulo()
                    {
                        CodigoSub2TipoArticulo = int.Parse(lector["codigoSub2TipoArticulo"].ToString()),
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

        public void actualizar(Sub1TipoArticulo sub1TipoArticulo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            modificacion = new SqlCommand("update Sub1TiposArticulos set descripcion=@descripcion where codigoSub1TipoArticulo=@codigoSub1TipoArticulo", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoSub1TipoArticulo", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@descripcion"].Value = sub1TipoArticulo.Descripcion;
            adaptador.UpdateCommand.Parameters["@codigoSub1TipoArticulo"].Value = sub1TipoArticulo.CodigoSub1TipoArticulo;

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
            consulta = new SqlCommand("select max(codigoSub1TipoArticulo) as codigo from Sub1TiposArticulos", conexion);
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
