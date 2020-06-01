using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas
{
    public class Venta
    {
        //Sql
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;

        //Instancias
        AccesoDatos acceso;

        private int _codigoVenta;
        private DateTime _fechaHora;
        private float _importeTotal;
        private int _codigoClienteMayorista;
        private int _codigoEncargado;     
        private List<DetalleVP> detalleVP;

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

        public DateTime FechaHora
        {
            get
            {
                return _fechaHora;
            }

            set
            {
                _fechaHora = value;
            }
        }

        public float ImporteTotal
        {
            get
            {
                return _importeTotal;
            }

            set
            {
                _importeTotal = value;
            }
        }

        public int CodigoClienteMayorista
        {
            get
            {
                return _codigoClienteMayorista;
            }

            set
            {
                _codigoClienteMayorista = value;
            }
        }

        public int CodigoEncargado
        {
            get
            {
                return _codigoEncargado;
            }

            set
            {
                _codigoEncargado = value;
            }
        }

        public List<DetalleVP> DetalleVP
        {
            get
            {
                return detalleVP;
            }

            set
            {
                detalleVP = value;
            }
        }

        public Venta()
        {
            CodigoVenta = 0;
            FechaHora = DateTime.Now;
            ImporteTotal = 0;
            CodigoEncargado = 0;
            CodigoClienteMayorista = 0;
            DetalleVP = new List<DetalleVP>();
        }
        
        public void crearVentaMinorista(Venta venta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("INSERT INTO Ventas(codigoVenta,fechaHoraVenta,importeTotal,codigoEncargado) VALUES(@codigoVenta,@fechaHoraVenta,@importeTotal,@codigoEncargado)", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.InsertCommand = consulta;

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoVenta", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaHoraVenta", SqlDbType.DateTime));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@importeTotal", SqlDbType.Float));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEncargado", SqlDbType.Int));

            adaptador.InsertCommand.Parameters["@codigoVenta"].Value = venta.CodigoVenta;
            adaptador.InsertCommand.Parameters["@fechaHoraVenta"].Value = venta.FechaHora;
            adaptador.InsertCommand.Parameters["@importeTotal"].Value = venta.ImporteTotal;
            adaptador.InsertCommand.Parameters["@codigoEncargado"].Value = venta.CodigoEncargado;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void crearVentaMayorista(Venta venta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("INSERT INTO Ventas(codigoVenta,fechaHoraVenta,importeTotal,codigoClienteMayorista,codigoEncargado) VALUES(@codigoVenta,@fechaHoraVenta,@importeTotal,@codigoClienteMayorista,@codigoEncargado)", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.InsertCommand = consulta;

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoVenta", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaHoraVenta", SqlDbType.DateTime));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@importeTotal", SqlDbType.Float));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoClienteMayorista", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEncargado", SqlDbType.Int));

            adaptador.InsertCommand.Parameters["@codigoVenta"].Value = venta.CodigoVenta;
            adaptador.InsertCommand.Parameters["@fechaHoraVenta"].Value = venta.FechaHora;
            adaptador.InsertCommand.Parameters["@importeTotal"].Value = venta.ImporteTotal;
            adaptador.InsertCommand.Parameters["@codigoClienteMayorista"].Value = venta.CodigoClienteMayorista;
            adaptador.InsertCommand.Parameters["@codigoEncargado"].Value = venta.CodigoEncargado;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void mostrarDatos(int codigoVenta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Ventas WHERE codigoVenta='" + codigoVenta + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoVenta = int.Parse(lector["codigoVenta"].ToString());
                    FechaHora = (DateTime)lector["fechaHoraVenta"];
                    ImporteTotal = float.Parse(lector["importeTotal"].ToString());

                    int numero2;
                    bool resultado2 = int.TryParse(lector["codigoClienteMayorista"].ToString(), out numero2);
                    if (resultado2) CodigoClienteMayorista = numero2;
                    else CodigoClienteMayorista = 0;

                    CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString());
                }
                else
                {
                    MessageBox.Show("La venta no existe");
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
        
        public int ultimoNroVenta()
        {
            int ultimoNroVenta = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT MAX(codigoVenta) AS codigo FROM Ventas", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    int valor;
                    bool resultado = int.TryParse(lector["codigo"].ToString(), out valor);
                    if (resultado)
                    {
                        ultimoNroVenta = valor;
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
            }
            return ultimoNroVenta;
        }
       
        public bool existeVenta(int codigoVenta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoVenta from Ventas where codigoVenta='"+ codigoVenta +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
            }
            return false;
        }

        public List<DetalleVP> conocerDetalleVP(int codigoVenta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoDetalleVP, codigoArticulo, cantidad, codigoPresupuesto from DetallesVP where codigoVenta='" + codigoVenta + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    if (lector["codigoPresupuesto"] != null)
                    {
                        DetalleVP.Add(new DetalleVP() { CodigoDetalleVP = int.Parse(lector["codigoDetalleVP"].ToString()), CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()), Cantidad = int.Parse(lector["cantidad"].ToString()), CodigoPresupuesto = 0 });
                    }
                    else
                    {
                        DetalleVP.Add(new DetalleVP() { CodigoDetalleVP = int.Parse(lector["codigoDetalleVP"].ToString()), CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()), Cantidad = int.Parse(lector["cantidad"].ToString()), CodigoPresupuesto = int.Parse(lector["codigoPresupuesto"].ToString()) });
                    }
                }
                return DetalleVP;
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                return DetalleVP;
            }
            finally
            {
                conexion.Close();
            }
        }

        public Encargado conocerEncargadoVenta(int codigoEncargado)
        {
            Encargado encargado = new Encargado();
            encargado.mostrarDatos(codigoEncargado);
            return encargado;
        }

        public ClienteMayorista conocerClienteMayorista(int codigoClienteMayorista)
        {
            ClienteMayorista clienteMayorista = new ClienteMayorista();
            clienteMayorista.mostrarDatos(codigoClienteMayorista);
            return clienteMayorista;
        }

        public bool existeEntregaAsignada(int codigoVenta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select * from Entregas where codigoVenta='"+codigoVenta+"'", conexion);
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

        public List<Venta> obtenerPeriodoVentas(DateTime desde, DateTime hasta)
        {
            List<Venta> listaVenta = new List<Venta>();

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Ventas WHERE fechaHoraVenta BETWEEN '" + desde.ToString("dd/MM/yyyy") + "' and '" +hasta.ToString("dd/MM/yyyy") + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {

                    int codigoClienteObtenido = 0;

                    int numero;
                    bool resultado = int.TryParse(lector["codigoClienteMayorista"].ToString(), out numero);
                    if (resultado) codigoClienteObtenido = numero;
                    
                    listaVenta.Add(new Venta
                    {
                        CodigoVenta = int.Parse(lector["codigoVenta"].ToString()),
                        FechaHora = (DateTime)lector["fechaHoraVenta"],
                        ImporteTotal = float.Parse(lector["importeTotal"].ToString()),
                        CodigoClienteMayorista = codigoClienteObtenido,
                        CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString())
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
            return listaVenta;
        }
    }
}
