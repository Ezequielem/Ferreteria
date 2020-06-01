using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaLaObra.Ventas.Presupuesto;
using SistemaLaObra.Ventas;

namespace SistemaLaObra
{
    public class DetalleVP
    {
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        AccesoDatos acceso;
        Articulo articulo;

        private int _codigoDetalleVP;
        private int _codigoArticulo;
        private float _precioUnitario;
        private int _cantidad;
        private int _codigoVenta;
        private int _codigoPresupuesto;
        private int _codigoNotaCredito;
        private int _cantidadDevuelta;

        public int CodigoDetalleVP
        {
            get
            {
                return _codigoDetalleVP;
            }

            set
            {
                _codigoDetalleVP = value;
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

        public float PrecioUnitario
        {
            get
            {
                return _precioUnitario;
            }

            set
            {
                _precioUnitario = value;
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

        public int CodigoVenta
        {
            get
            {
                return _codigoVenta;
            }

            set
            {
                _codigoVenta = value;
            }
        }

        public int CodigoPresupuesto
        {
            get
            {
                return _codigoPresupuesto;
            }

            set
            {
                _codigoPresupuesto = value;
            }
        }

        public int CodigoNotaCredito
        {
            get
            {
                return _codigoNotaCredito;
            }

            set
            {
                _codigoNotaCredito = value;
            } 
        }

        public int CantidadDevuelta
        {
            get
            {
                return _cantidadDevuelta;
            }
            set
            {
                _cantidadDevuelta = value;
            }
        }

        public DetalleVP()
        {
            
            CodigoDetalleVP = 0;
            CodigoArticulo = 0;
            PrecioUnitario = 0f;
            Cantidad = 0;
            CodigoVenta = 0;
            CodigoPresupuesto = 0;
            CodigoNotaCredito = 0;
            CantidadDevuelta = 0;
            
        }

        public void crearDetalleVenta(int codigoArticulo,float precioUnitario,int cantidad, int codigoVenta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();
            consulta = new SqlCommand("INSERT INTO DetallesVP (codigoArticulo,precioUnitario,cantidad,codigoVenta) VALUES (@codigoArticulo,@precioUnitario,@cantidad,@codigoVenta)", conexion);
            adaptador.InsertCommand = consulta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoArticulo", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@precioUnitario", SqlDbType.Money));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoVenta", SqlDbType.Int));

            adaptador.InsertCommand.Parameters["@codigoArticulo"].Value = codigoArticulo;
            adaptador.InsertCommand.Parameters["@precioUnitario"].Value = precioUnitario;
            adaptador.InsertCommand.Parameters["@cantidad"].Value = cantidad;
            adaptador.InsertCommand.Parameters["@codigoVenta"].Value = codigoVenta;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void crearDetallePresupuesto(int codigoArticulo, float precioUnitario, int cantidad,int codigoPresupuesto)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();
            consulta = new SqlCommand("INSERT INTO DetallesVP (codigoArticulo,precioUnitario,cantidad,codigoPresupuesto) VALUES (@codigoArticulo,@precioUnitario,@cantidad,@codigoPresupuesto)", conexion);
            adaptador.InsertCommand = consulta;
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoArticulo", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@precioUnitario", SqlDbType.Money));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPresupuesto", SqlDbType.Int));

            adaptador.InsertCommand.Parameters["@codigoArticulo"].Value = codigoArticulo;
            adaptador.InsertCommand.Parameters["@precioUnitario"].Value = precioUnitario;
            adaptador.InsertCommand.Parameters["@cantidad"].Value = cantidad;
            adaptador.InsertCommand.Parameters["@codigoPresupuesto"].Value = codigoPresupuesto;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void actualizarDetalleNC(int codigoDetalleVP, int codigoNotaCredito, int cantidadDevuelta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();
            consulta = new SqlCommand("UPDATE DetallesVP SET codigoNotaCredito=@codigoNotaCredito, cantidadDevuelta=@cantidadDevuelta WHERE codigoDetalleVP=@codigoDetalleVP", conexion);
            adaptador.UpdateCommand = consulta;
            
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoNotaCredito", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cantidadDevuelta", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoDetalleVP", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@codigoNotaCredito"].Value = codigoNotaCredito;
            adaptador.UpdateCommand.Parameters["@cantidadDevuelta"].Value = cantidadDevuelta;
            adaptador.UpdateCommand.Parameters["@codigoDetalleVP"].Value = codigoDetalleVP;

            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        } 

        ////////////////////////////////////////
        //OJO Si se utiliza este metodo seguirlo paso a paso.
        public void mostrarDatos(int codigoDetalleVP)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select * from DetallesVP where codigoDetalleVP='" + codigoDetalleVP + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {

                    CodigoDetalleVP = int.Parse(lector["codigoDetalleVP"].ToString());
                    CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString());
                    PrecioUnitario = float.Parse(lector["precioUnitario"].ToString());
                    Cantidad = int.Parse(lector["cantidad"].ToString());

                    int numero1;
                    bool resultado1 = int.TryParse(lector["codigoVenta"].ToString(), out numero1);
                    if (resultado1) CodigoVenta = numero1;
                    else CodigoVenta = 0;

                    int numero2;
                    bool resultado2 = int.TryParse(lector["codigoPresupuesto"].ToString(), out numero2);
                    if (resultado2) CodigoPresupuesto = numero2;
                    else CodigoPresupuesto = 0;
                }
                else
                {
                    MessageBox.Show("El Detalle no existe");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }
        ////////////////////////////////////////

        public float calcularSubTotal(float precioUnitario, int cantidad)
        {
            float subtotal = precioUnitario * cantidad;
            return subtotal;
        }

        public Articulo conocerArticulo()
        {
            articulo = new Articulo();
            articulo.mostrarDatos(CodigoArticulo);
            return articulo;
        }

        public List<DetalleVP> obtenerListaDetalleVP(Presupuesto presupuesto)
        {
            List<DetalleVP> listaDetalle = new List<DetalleVP>();

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM DetallesVP WHERE codigoPresupuesto='" + presupuesto.CodigoPresupuesto + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaDetalle.Add(new DetalleVP{ CodigoDetalleVP = int.Parse(lector["codigoDetalleVP"].ToString()),
                                                    CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                                                    PrecioUnitario = float.Parse(lector["precioUnitario"].ToString()),
                                                    Cantidad = int.Parse(lector["cantidad"].ToString()),
                                                    CodigoPresupuesto = int.Parse(lector["codigoPresupuesto"].ToString())
                                     });
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return listaDetalle;
        }

        public List<DetalleVP> obtenerListaDetalleVP(Venta venta)
        {
            List<DetalleVP> listaDetalle = new List<DetalleVP>();

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM DetallesVP WHERE codigoVenta='" + venta.CodigoVenta + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaDetalle.Add(new DetalleVP
                    {
                        CodigoDetalleVP = int.Parse(lector["codigoDetalleVP"].ToString()),
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        PrecioUnitario = float.Parse(lector["precioUnitario"].ToString()),
                        Cantidad = int.Parse(lector["cantidad"].ToString()),
                        CodigoVenta = int.Parse(lector["codigoVenta"].ToString()),
                    });
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return listaDetalle;
        }

        public List<DetalleVP> obtenerListaDetalleVP_NC(Venta venta)
        {
            List<DetalleVP> listaDetalle = new List<DetalleVP>();

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM DetallesVP WHERE codigoVenta='" + venta.CodigoVenta + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    int valorSalida = 0;
                    bool resultadoConversion = int.TryParse(lector["codigoNotaCredito"].ToString(), out valorSalida);

                    if (resultadoConversion)
                    {
                        listaDetalle.Add(new DetalleVP
                        {
                            CodigoDetalleVP = int.Parse(lector["codigoDetalleVP"].ToString()),
                            CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                            PrecioUnitario = float.Parse(lector["precioUnitario"].ToString()),
                            Cantidad = int.Parse(lector["cantidad"].ToString()),
                            CodigoVenta = int.Parse(lector["codigoVenta"].ToString()),
                            CodigoNotaCredito = int.Parse(lector["codigoNotaCredito"].ToString()),
                            CantidadDevuelta = int.Parse(lector["cantidadDevuelta"].ToString())
                        });
                    }
                    else
                    {
                        listaDetalle.Add(new DetalleVP
                        {
                            CodigoDetalleVP = int.Parse(lector["codigoDetalleVP"].ToString()),
                            CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                            PrecioUnitario = float.Parse(lector["precioUnitario"].ToString()),
                            Cantidad = int.Parse(lector["cantidad"].ToString()),
                            CodigoVenta = int.Parse(lector["codigoVenta"].ToString())
                        });
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return listaDetalle;
        }
    }
}
