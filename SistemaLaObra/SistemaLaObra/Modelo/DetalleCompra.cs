using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaLaObra
{
    public class DetalleCompra
    {
        //Sql
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;

        //Instancias
        AccesoDatos acceso;

        private int _codigoDetalleCompra;
        private int _codigoCompra;
        private int _codigoArticulo;
        private int _cantidad;
        private float _precioCoste;
        private int _codigoProveedor;        
        private Articulo _articulo;

        public int CodigoDetalleCompra
        {
            get
            {
                return _codigoDetalleCompra;
            }

            set
            {
                _codigoDetalleCompra = value;
            }
        }

        public int CodigoCompra
        {
            get
            {
                return _codigoCompra;
            }

            set
            {
                _codigoCompra = value;
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

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }

            set
            {
                _cantidad = value;
            }
        }

        public float PrecioCoste
        {
            get
            {
                return _precioCoste;
            }

            set
            {
                _precioCoste = value;
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

        public DetalleCompra()
        {
            CodigoDetalleCompra = 0;
            CodigoArticulo = 0;
            Cantidad = 0;
            PrecioCoste = 0;
            CodigoProveedor = 0;
            CodigoCompra = 0;
            Articulo = new Articulo();
        }

        //METODOS

        public void crear(DetalleCompra detalle)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            try
            {
                SqlCommand alta = new SqlCommand("insert into DetallesCompra (codigoCompra, codigoArticulo, cantidad, precioCoste, codigoProveedor) values (@codigoCompra, @codigoArticulo, @cantidad, @precioCoste, @codigoProveedor)", conexion);
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoCompra", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoArticulo", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@precioCoste", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@codigoCompra"].Value = detalle.CodigoCompra;
                adaptador.InsertCommand.Parameters["@codigoArticulo"].Value = detalle.CodigoArticulo;
                adaptador.InsertCommand.Parameters["@cantidad"].Value = detalle.Cantidad;
                adaptador.InsertCommand.Parameters["@precioCoste"].Value = detalle.PrecioCoste;
                adaptador.InsertCommand.Parameters["@codigoProveedor"].Value = detalle.CodigoProveedor;
                
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                string error = e.ToString();
            }
            finally
            {
                conexion.Close();
            }
        }

        public DetalleCompra mostrarDatos(int codigoDetalle)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta=new SqlCommand("select codigoCompra, codigoArticulo, cantidad, precioCoste, codigoProveedor from DetallesCompras where codigoDetalleCompra='" + codigoDetalle + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoCompra = int.Parse(lector["codigoCompra"].ToString());
                    CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString());
                    Cantidad = int.Parse(lector["cantidad"].ToString());
                    PrecioCoste = float.Parse(lector["precioCoste"].ToString());
                    CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString());
                }
            }
            catch (Exception e)
            {
                string log = e.ToString();                
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return this;
        }

        public List<DetalleCompra> mostrarDatosColeccion(int codigoCompra)
        {
            List<DetalleCompra> lista = new List<DetalleCompra>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoCompra, codigoArticulo, cantidad, precioCoste, codigoProveedor from DetallesCompra where codigoCompra='" + codigoCompra + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new DetalleCompra() {
                        CodigoCompra = int.Parse(lector["codigoCompra"].ToString()),
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        Cantidad = int.Parse(lector["cantidad"].ToString()),
                        PrecioCoste = float.Parse(lector["precioCoste"].ToString()),
                        CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString())
                                                });                    
                }
                return lista;
            }
            catch (Exception e)
            {
                string log = e.ToString();
                return lista;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }           
        }

        public Articulo conocerArticulo(int codigoArticulo)
        {
            Articulo.mostrarDatos(CodigoArticulo);
            return Articulo;
        }

        public int ultimoCodigoCompra()
        {
            int ultimoCodigo = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select max(codigoCompra) as ultimoCodigo from Compras", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    int resultado;
                    bool ultimoCod = int.TryParse(lector["ultimoCodigo"].ToString(), out resultado);
                    if (ultimoCod)
                    {
                        ultimoCodigo = resultado;
                    }
                    else
                    {
                        ultimoCodigo = 0;
                    }
                }
                return ultimoCodigo;
            }
            catch (NullReferenceException)
            {
                return ultimoCodigo;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }
    }
}
