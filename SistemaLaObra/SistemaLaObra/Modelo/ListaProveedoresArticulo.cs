using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaLaObra
{
    public class ListaProveedoresArticulo
    {
        //INSTANCIAS
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataAdapter adaptador;
        private SqlDataReader lector;
        private AccesoDatos acceso ;

        public int CodigoProveedor { get; set; }
        public int CodigoArticulo { get; set; }
        public float PrecioProveedor { get; set; }
        public Articulo Articulo { get; set; }

        public ListaProveedoresArticulo()
    {
            CodigoProveedor = 0;
            CodigoArticulo = 0;
            PrecioProveedor = 0f;
            Articulo = new Articulo();
    }

        //METODOS

        public void crear(ListaProveedoresArticulo listaProveedoresArticulo )
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();
            SqlCommand alta = new SqlCommand("insert into ListaProveedoresArticulos (codigoProveedor, codigoArticulo, precioProveedor) values (@codigoProveedor, @codigoArticulo, @precioProveedor)", conexion);
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoArticulo", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@precioProveedor", SqlDbType.Money));

            adaptador.InsertCommand.Parameters["@codigoProveedor"].Value = listaProveedoresArticulo.CodigoProveedor;
            adaptador.InsertCommand.Parameters["@codigoArticulo"].Value = listaProveedoresArticulo.CodigoArticulo;
            adaptador.InsertCommand.Parameters["@precioProveedor"].Value = listaProveedoresArticulo.PrecioProveedor;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();

            }
            catch (SqlException excepcion)
            {
                string log = excepcion.ToString();
            }
            finally
            {
                conexion.Close();
            }
        }

        public void actualizar(ListaProveedoresArticulo listaProveedoresArticulo)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            comando = new SqlCommand("update ListaProveedoresArticulos set precioProveedor=@precioProveedor where codigoProveedor=@codigoProveedor and codigoArticulo=@codigoArticulo", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = comando;            
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoArticulo", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@precioProveedor", SqlDbType.Money));
            
            adaptador.UpdateCommand.Parameters["@codigoProveedor"].Value = listaProveedoresArticulo.CodigoProveedor;
            adaptador.UpdateCommand.Parameters["@codigoArticulo"].Value = listaProveedoresArticulo.CodigoArticulo;
            adaptador.UpdateCommand.Parameters["@precioProveedor"].Value = listaProveedoresArticulo.PrecioProveedor;
            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
            }
            catch (SqlException excepcion)
            {
                string log = excepcion.ToString();
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<ListaProveedoresArticulo> mostrarDatos()
        {
            List<ListaProveedoresArticulo> lista = new List<ListaProveedoresArticulo>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            comando = new SqlCommand("select codigoProveedor, codigoArticulo, precioProveedor from ListaProveedoresArticulos", conexion);
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new ListaProveedoresArticulo()
                    {
                        CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString()),
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        PrecioProveedor = float.Parse(lector["precioProveedor"].ToString()),
                        Articulo= Articulo.retornarDatos(int.Parse(lector["codigoArticulo"].ToString()))
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

        public List<Proveedor> mostrarColeccionProveedores(int codigoArticulo)
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            comando = new SqlCommand("select LAP.codigoProveedor as codigo, P.razonSocial as nombre from ListaProveedoresArticulos LAP inner join Proveedores P on LAP.codigoProveedor=P.codigoProveedor where LAP.codigoArticulo='"+codigoArticulo+"'", conexion);            
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    listaProveedores.Add(new Proveedor() {
                                                            CodigoProveedor=int.Parse(lector["codigo"].ToString()),
                                                            RazonSocial=lector["nombre"].ToString()
                    });
                }
                return listaProveedores;
            }
            catch (Exception)
            {
                return listaProveedores;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public float mostrarPrecioCoste(int codigoProveedor, int codigoArticulo)
        {
            float precioCoste = 0f;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            comando = new SqlCommand("select precioProveedor from ListaProveedoresArticulos where codigoArticulo='"+codigoArticulo+"' and codigoProveedor='"+codigoProveedor+"'", conexion);
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    precioCoste = float.Parse(lector["precioProveedor"].ToString());
                }
                return precioCoste;
            }
            catch (Exception e)
            {
                string log = e.ToString();
                return precioCoste;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public bool esProveedorAsociado(int codigoArticulo, int codigoProveedor)
        {
            List<ListaProveedoresArticulo> lista = new List<ListaProveedoresArticulo>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            comando = new SqlCommand("select codigoProveedor, codigoArticulo, precioProveedor from ListaProveedoresArticulos where codigoArticulo='"+codigoArticulo+"'", conexion);
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new ListaProveedoresArticulo() {
                        CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString()),
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        PrecioProveedor = float.Parse(lector["precioProveedor"].ToString())
                    });                                        
                }                
                if (lista.Select(x=>x.CodigoProveedor).Contains(codigoProveedor))
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
                lector.Close();
                conexion.Close();
            }
        }
    }
}
