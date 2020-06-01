using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SistemaLaObra
{
    public class DetalleLogistica
    {
        //INSTANCIAS
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        AccesoDatos acceso;
        Articulo articulo;

        //ATRIBUTOS
        private int _codigoDetalleLogistica;
        private int _codigoArticulo;
        private int _cantidad;
        private int _cantidadRecibida;
        private int _codigoEntrega;
        private int _codigoRecepcion;
        private int _codigoProveedor;
        private Entrega _entrega;
        private Recepcion _recepcion;

        public int CodigoDetalleLogistica
        {
            get
            {
                return _codigoDetalleLogistica;
            }

            set
            {
                _codigoDetalleLogistica = value;
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

        public int CantidadRecibida
        {
            get
            {
                return _cantidadRecibida;
            }

            set
            {
                _cantidadRecibida = value;
            }
        }

        public int CodigoEntrega
        {
            get
            {
                return _codigoEntrega;
            }

            set
            {
                _codigoEntrega = value;
            }
        }

        public int CodigoRecepcion
        {
            get
            {
                return _codigoRecepcion;
            }

            set
            {
                _codigoRecepcion = value;
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

        public Entrega Entrega
        {
            get
            {
                return _entrega;
            }

            set
            {
                _entrega = value;
            }
        }

        public Recepcion Recepcion
        {
            get
            {
                return _recepcion;
            }

            set
            {
                _recepcion = value;
            }
        }

        public DetalleLogistica()
        {
            CodigoDetalleLogistica = 0;
            CodigoArticulo = 0;
            Cantidad = 0;
            CantidadRecibida = 0;
            CodigoEntrega = 0;
            CodigoRecepcion = 0;
            CodigoProveedor = 0;
            Entrega = new Entrega();
            Recepcion = new Recepcion();
        }

        public void crearDetalleLogisticaEntrega(int codigoArticulo, int cantidad, int codigoEntrega)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());

            try
            {
                SqlCommand alta = new SqlCommand("insert into DetallesLogistica (codigoArticulo, cantidad, codigoEntrega) values (@codigoArticulo, @cantidad, @codigoEntrega)", conexion);
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoArticulo", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEntrega", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@codigoArticulo"].Value = codigoArticulo;
                adaptador.InsertCommand.Parameters["@cantidad"].Value = cantidad;
                adaptador.InsertCommand.Parameters["@codigoEntrega"].Value = codigoEntrega;

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

        public void crearDetalleLogisticaRecepcion(int codigoArticulo, int cantidad, int cantidadRecibida, int codigoRecepcion, int codigoProveedor)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());

            try
            {
                SqlCommand alta = new SqlCommand("insert into DetallesLogistica (codigoArticulo, cantidad, cantidadRecibida, codigoRecepcion, codigoProveedor) values (@codigoArticulo, @cantidad, @cantidadRecibida, @codigoRecepcion, @codigoProveedor)", conexion);
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoArticulo", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cantidadRecibida", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoRecepcion", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@codigoArticulo"].Value = codigoArticulo;
                adaptador.InsertCommand.Parameters["@cantidad"].Value = cantidad;
                adaptador.InsertCommand.Parameters["@cantidadRecibida"].Value = cantidadRecibida;
                adaptador.InsertCommand.Parameters["@codigoRecepcion"].Value = codigoRecepcion;
                adaptador.InsertCommand.Parameters["@codigoProveedor"].Value = codigoProveedor;

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

        public List<DetalleLogistica> mostrarDatos(int codigoEntrega)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            List<DetalleLogistica> listaDetalles = new List<DetalleLogistica>();
            conexion.Open();
            try
            {
                SqlCommand consulta = new SqlCommand("select codigoDetalleLogistica, codigoArticulo, cantidad from DetallesLogistica where codigoEntrega=" + codigoEntrega, conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaDetalles.Add(new DetalleLogistica()
                    {
                        CodigoDetalleLogistica = int.Parse(lector["codigoDetalleLogistica"].ToString()),
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        Cantidad = int.Parse(lector["cantidad"].ToString())
                    });
                }
                return listaDetalles;
            }
            catch (SqlException)
            {
                return listaDetalles = null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<DetalleLogistica> mostrarDatosBase(int codigoEntrega)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            List<DetalleLogistica> listaDetalles = new List<DetalleLogistica>();
            conexion.Open();
            try
            {
                SqlCommand consulta = new SqlCommand("select codigoEntrega,codigoDetalleLogistica, codigoArticulo, cantidad from DetallesLogistica where codigoEntrega=" + codigoEntrega, conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaDetalles.Add(new DetalleLogistica()
                    {
                        CodigoEntrega = int.Parse(lector["codigoEntrega"].ToString()),
                        CodigoDetalleLogistica = int.Parse(lector["codigoDetalleLogistica"].ToString()),
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        Cantidad = int.Parse(lector["cantidad"].ToString())
                    });
                }
                return listaDetalles;
            }
            catch (SqlException)
            {
                return listaDetalles = null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<DetalleLogistica> mostrarDatosDetalle(int codigoRecepcion)
        {
            CodigoRecepcion = codigoRecepcion;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            List<DetalleLogistica> listaDetalles = new List<DetalleLogistica>();
            conexion.Open();
            try
            {
                SqlCommand consulta = new SqlCommand("select * from DetallesLogistica where codigoRecepcion ='"+ codigoRecepcion + "'" + "and cantidadRecibida < cantidad", conexion);
                //    SqlCommand consulta = new SqlCommand("select * from DetallesLogistica where codigoRecepcion='" + codigoRecepcion + "'", conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    if (lector["cantidadRecibida"]==DBNull.Value)
                    {
                        listaDetalles.Add(new DetalleLogistica()
                        {
                            CodigoDetalleLogistica = int.Parse(lector["codigoDetalleLogistica"].ToString()),
                            CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                            Cantidad = int.Parse(lector["cantidad"].ToString()),
                            CantidadRecibida = 0,
                            CodigoRecepcion = int.Parse(lector["codigoRecepcion"].ToString()),
                            CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString())
                        });
                    }
                    else
                    {
                        listaDetalles.Add(new DetalleLogistica()
                        {
                            CodigoDetalleLogistica = int.Parse(lector["codigoDetalleLogistica"].ToString()),
                            CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                            Cantidad = int.Parse(lector["cantidad"].ToString()),
                            CantidadRecibida = int.Parse(lector["cantidadRecibida"].ToString()),
                            CodigoRecepcion = int.Parse(lector["codigoRecepcion"].ToString()),
                            CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString())
                        });
                    }
                   
                }

            }
            catch (SqlException exepcion)
            {
                MessageBox.Show(exepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return listaDetalles;
        }

        public Articulo conocerArticulo()
        {
            articulo = new Articulo();
            articulo.mostrarDatos(CodigoArticulo);
            return articulo;
        }

        public int mostrarCantidad(int codigoDetalle)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select cantidad from DetallesLogistica where codigoDetalleLogistica='" + codigoDetalle + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["cantidad"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (SqlException)
            {
                return 0;
            }
            finally
            {
                conexion.Close();
            }
        }

        public string buscarNombreProveedor(int codigoProveedor)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select razonSocial from Proveedores where codigoProveedor='" + codigoProveedor + "'", conexion);
            string nombreProveedor = "";
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    nombreProveedor = lector["razonSocial"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return nombreProveedor;
        }

        public string buscarNombreArticulo(int codigoArticulo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Articulos where codigoArticulo='" + codigoArticulo + "'", conexion);
            string nombreArticulo = "";
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    nombreArticulo = lector["descripcion"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return nombreArticulo;
        }

        public void actualizarDatos()
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            conexion.Open();
            SqlCommand consulta = new SqlCommand("update DetallesLogistica set cantidadRecibida='" + CantidadRecibida + "' where codigoDetalleLogistica='" + CodigoDetalleLogistica + "'", conexion);
            try
            {
                consulta.ExecuteNonQuery();
            }
            catch (SqlException exepcion)
            {
                MessageBox.Show(exepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void actualizarEstadoRecepcion(int codigoEstado)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            conexion.Open();
            SqlCommand consulta = new SqlCommand("update Recepciones set codigoEstadoRecepcion='" + codigoEstado + "' where codigoRecepcion='" + CodigoRecepcion + "'", conexion);
            try
            {
                consulta.ExecuteNonQuery();
            }
            catch (SqlException exepcion)
            {
                MessageBox.Show(exepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }

        }
    }
}
