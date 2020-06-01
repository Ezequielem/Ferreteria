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

        private int _codigoListaProveedoresArticulo;
        private int _codigoProveedor;
        private int _codigoArticulo;
        private float _precioProveedor;
        private Articulo _articulo;

        public int CodigoListaProveedoresArticulo
        {
            get
            {
                return _codigoListaProveedoresArticulo;
            }

            set
            {
                _codigoListaProveedoresArticulo = value;
            }
        }

        public int CodigoProveedor
        {
            get
            {
                return _codigoProveedor;
            }

            set
            {
                _codigoProveedor = value;
            }
        }

        public int CodigoArticulo
        {
            get
            {
                return _codigoArticulo;
            }

            set
            {
                _codigoArticulo = value;
            }
        }

        public float PrecioProveedor
        {
            get
            {
                return _precioProveedor;
            }

            set
            {
                _precioProveedor = value;
            }
        }

        public Articulo Articulo
        {
            get
            {
                return _articulo;
            }

            set
            {
                _articulo = value;
            }
        }

        public ListaProveedoresArticulo()
    {
            CodigoListaProveedoresArticulo = 0;
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
            comando = new SqlCommand("update ListaProveedoresArticulos set precioProveedor=@precioProveedor where codigoListaProveedorArticulo=@codigoListaProveedorArticulo", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = comando;            
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoListaProveedorArticulo", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@precioProveedor", SqlDbType.Money));
            
            adaptador.UpdateCommand.Parameters["@codigoListaProveedorArticulo"].Value = listaProveedoresArticulo.CodigoListaProveedoresArticulo;
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
            comando = new SqlCommand("select codigoListaProveedorArticulo, codigoProveedor, codigoArticulo, precioProveedor from ListaProveedoresArticulos", conexion);
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new ListaProveedoresArticulo()
                    {
                        CodigoListaProveedoresArticulo = int.Parse(lector["codigoListaProveedorArticulo"].ToString()),
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
            comando = new SqlCommand("select codigoListaProveedorArticulo, codigoProveedor, codigoArticulo, precioProveedor from ListaProveedoresArticulos where codigoArticulo='"+codigoArticulo+"'", conexion);
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new ListaProveedoresArticulo() {
                        CodigoListaProveedoresArticulo = int.Parse(lector["codigoListaProveedorArticulo"].ToString()),
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
