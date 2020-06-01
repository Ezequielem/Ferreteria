using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaLaObra
{
    public class Sub3TipoArticulo
    {
        //INSTANCIAS
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand consulta;
        SqlCommand alta;
        SqlCommand modificacion;
        SqlDataAdapter adaptador;

        private int _codigoSub3TipoArticulo;
        private string descripcion;
        private int _codigoSub2TipoArticulo;

        public int CodigoSub3TipoArticulo
        {
            get
            {
                return _codigoSub3TipoArticulo;
            }

            set
            {
                _codigoSub3TipoArticulo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

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

        public Sub3TipoArticulo()
        {
            CodigoSub3TipoArticulo = 0;
            Descripcion = "";
            CodigoSub2TipoArticulo = 0;
        }

        //METODOS

        public void crear(Sub3TipoArticulo sub3TipoArticulo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            alta = new SqlCommand("insert into Sub3TiposArticulos (descripcion, codigoSub2TipoArticulo) values (@descripcion, @codigoSub2TipoArticulo)", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoSub2TipoArticulo", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@descripcion"].Value = sub3TipoArticulo.Descripcion;
                adaptador.InsertCommand.Parameters["@codigoSub2TipoArticulo"].Value = sub3TipoArticulo.CodigoSub2TipoArticulo;

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

        public Sub3TipoArticulo mostrarDatos(int codigoSub3TipoArticulo)
        {            
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoSub3TipoArticulo, descripcion, codigoSub2TipoArticulo from Sub3TiposArticulos where codigoSub3TipoArticulo='"+ codigoSub3TipoArticulo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoSub3TipoArticulo = int.Parse(lector["codigoSub3TipoArticulo"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                    CodigoSub2TipoArticulo = int.Parse(lector["codigoSub2TipoArticulo"].ToString());
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

        public List<Sub3TipoArticulo> mostrarDatos()
        {
            List<Sub3TipoArticulo> lista = new List<Sub3TipoArticulo>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoSub3TipoArticulo, descripcion, codigoSub2TipoArticulo from Sub3TiposArticulos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Sub3TipoArticulo()
                    {
                        CodigoSub3TipoArticulo = int.Parse(lector["codigoSub3TipoArticulo"].ToString()),
                        Descripcion = lector["descripcion"].ToString(),
                        CodigoSub2TipoArticulo = int.Parse(lector["codigoSub2TipoArticulo"].ToString())
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

        public void actualizar(Sub3TipoArticulo sub3TipoArticulo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            modificacion = new SqlCommand("update Sub3TiposArticulos set descripcion=@descripcion where codigoSub3TipoArticulo=@codigoSub3TipoArticulo", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoSub3TipoArticulo", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@descripcion"].Value = sub3TipoArticulo.Descripcion;
            adaptador.UpdateCommand.Parameters["@codigoSub3TipoArticulo"].Value = sub3TipoArticulo.CodigoSub3TipoArticulo;

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
    }
}
