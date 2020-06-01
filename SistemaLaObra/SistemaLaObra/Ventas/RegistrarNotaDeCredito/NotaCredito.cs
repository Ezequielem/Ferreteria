using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.RegistrarNotaDeCredito
{
    public class NotaCredito
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;
        AccesoDatos acceso;
        private List<ClienteMayorista> _clientesMayoristas;
        private List<NotaCredito> _notasCredito;

        public int CodigoNotaCredito { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string NombreCliente { get; set; }
        public int DniCliente { get; set; }
        public int CodigoClienteMayorista { get; set; }
        public float SaldoAnterior { get; set; }
        public float Saldo { get; set; }
        public int CodigoVenta { get; set; }
        public int CodigoEncargado { get; set; }

        public NotaCredito()
        {
            CodigoNotaCredito = 0;
            Fecha = DateTime.Now;
            FechaVencimiento = Fecha.AddDays(31);
            NombreCliente = "";
            DniCliente = 0;
            CodigoClienteMayorista = 0;
            SaldoAnterior = 0f;
            Saldo = 0f;
            CodigoVenta = 0;
            CodigoEncargado = 0;
        }

        public void crearNotaCreditoMinorista(NotaCredito notaCredito)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();

            try
            {
                consulta = new SqlCommand("INSERT INTO NotasCredito (codigoNotaCredito,fecha,fechaVencimiento,nombreCliente,dniCliente,saldoAnterior,saldo,codigoVenta,codigoEncargado) VALUES (@codigoNotaCredito,@fecha,@fechaVencimiento,@nombreCliente,@dniCliente,@saldoAnterior,@saldo,@codigoVenta,@codigoEncargado)", conexion);
                adaptador.InsertCommand = consulta;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoNotaCredito", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaVencimiento", SqlDbType.Date));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreCliente", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@dniCliente", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@saldoAnterior", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoVenta", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEncargado", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@codigoNotaCredito"].Value = notaCredito.CodigoNotaCredito;
                adaptador.InsertCommand.Parameters["@fecha"].Value = notaCredito.Fecha;
                adaptador.InsertCommand.Parameters["@fechaVencimiento"].Value = notaCredito.FechaVencimiento;
                adaptador.InsertCommand.Parameters["@nombreCliente"].Value = notaCredito.NombreCliente;
                adaptador.InsertCommand.Parameters["@dniCliente"].Value = notaCredito.DniCliente;
                adaptador.InsertCommand.Parameters["@saldoAnterior"].Value = notaCredito.Saldo;
                adaptador.InsertCommand.Parameters["@saldo"].Value = notaCredito.Saldo;
                adaptador.InsertCommand.Parameters["@codigoVenta"].Value = notaCredito.CodigoVenta;
                adaptador.InsertCommand.Parameters["@codigoEncargado"].Value = notaCredito.CodigoEncargado;

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

        public void crearNotaCreditoMayorista(NotaCredito notaCredito)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();

            try
            {
                consulta = new SqlCommand("INSERT INTO NotasCredito (codigoNotaCredito,fecha,fechaVencimiento,codigoClienteMayorista,saldoAnterior,saldo,codigoVenta,codigoEncargado) VALUES (@codigoNotaCredito,@fecha,@fechaVencimiento,@codigoClienteMayorista,@saldoAnterior,@saldo,@codigoVenta,@codigoEncargado)", conexion);
                adaptador.InsertCommand = consulta;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoNotaCredito", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaVencimiento", SqlDbType.Date));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoClienteMayorista", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@saldoAnterior", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoVenta", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEncargado", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@codigoNotaCredito"].Value = notaCredito.CodigoNotaCredito;
                adaptador.InsertCommand.Parameters["@fecha"].Value = notaCredito.Fecha;
                adaptador.InsertCommand.Parameters["@fechaVencimiento"].Value = notaCredito.FechaVencimiento;
                adaptador.InsertCommand.Parameters["@codigoClienteMayorista"].Value = notaCredito.CodigoClienteMayorista;
                adaptador.InsertCommand.Parameters["@saldoAnterior"].Value = notaCredito.Saldo;
                adaptador.InsertCommand.Parameters["@saldo"].Value = notaCredito.Saldo;
                adaptador.InsertCommand.Parameters["@codigoVenta"].Value = notaCredito.CodigoVenta;
                adaptador.InsertCommand.Parameters["@codigoEncargado"].Value = notaCredito.CodigoEncargado;

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

        public void actualizarNotaDeCredito(NotaCredito notaCredito)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("update NotasCredito set saldoAnterior=@saldoAnterior, saldo=@saldo where codigoNotaCredito=@codigoNotaCredito", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = consulta;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@saldoAnterior", SqlDbType.Money));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Money));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoNotaCredito", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@saldoAnterior"].Value = notaCredito.SaldoAnterior;
            adaptador.UpdateCommand.Parameters["@saldo"].Value = notaCredito.Saldo;
            adaptador.UpdateCommand.Parameters["@codigoNotaCredito"].Value = notaCredito.CodigoNotaCredito;

            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
            }
            catch (SqlException excepcion)
            {
                //supuestamente se registra un log
                excepcion.ToString();
            }
            finally
            {
                conexion.Close();
            }
        }

        public string obtenerFormaPago(int codigoFormaPago)
        {
            string formaPago = "EFECTIVO";

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM FormaPagos WHERE codigoFormaPago='"+codigoFormaPago+"'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    formaPago = lector["descripcion"].ToString();
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
            return formaPago;
        }

        public int ultimoCodigoNotaCredito()
        {
            int ultimoNroNotaCredito = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT MAX(codigoNotaCredito) AS codigo FROM NotasCredito", conexion);
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
                        ultimoNroNotaCredito = valor;
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
            return ultimoNroNotaCredito;
        }

        public List<ClienteMayorista> mostrarDatosColeccionMayorista()
        {
            _clientesMayoristas = new List<ClienteMayorista>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            conexion.Open();
            try
            {
                SqlCommand consulta = new SqlCommand("select NotasCredito.codigoNotaCredito, NotasCredito.fecha, NotasCredito.fechaVencimiento, NotasCredito.codigoClienteMayorista, NotasCredito.saldo, NotasCredito.codigoVenta, NotasCredito.codigoEncargado, ClientesMayoristas.razonSocial, ClientesMayoristas.cuit from NotasCredito inner join  ClientesMayoristas on NotasCredito.codigoClienteMayorista=ClientesMayoristas.codigoClienteMayorista where NotasCredito.codigoClienteMayorista is not null", conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                string cuit = "";
                int b = 0;
                while (lector.Read())
                {
                    if (b==0)
                    {
                        _clientesMayoristas.Add(new ClienteMayorista() {
                            CodigoClienteMayorista = int.Parse(lector["codigoClienteMayorista"].ToString()),
                            RazonSocial = lector["razonSocial"].ToString(),
                            Cuit = lector["cuit"].ToString()
                        });                        
                        cuit = lector["cuit"].ToString();
                        b = 1;
                    }
                    else
                    {
                        if (cuit!= lector["cuit"].ToString())
                        {
                            _clientesMayoristas.Add(new ClienteMayorista()
                            {
                                CodigoClienteMayorista = int.Parse(lector["codigoClienteMayorista"].ToString()),
                                RazonSocial = lector["razonSocial"].ToString(),
                                Cuit = lector["cuit"].ToString()
                            });
                        }                        
                    }
                    
                }
                return _clientesMayoristas;
            }
            catch (SqlException e)
            {
                string error = e.ToString();
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<NotaCredito> mostrarDatosColeccionMinorista()
        {
            _notasCredito = new List<NotaCredito>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            conexion.Open();
            try
            {
                SqlCommand consulta = new SqlCommand("select codigoNotaCredito, fecha, fechaVencimiento, nombreCliente, dniCliente, codigoClienteMayorista, saldo, codigoVenta, codigoEncargado from NotasCredito where codigoClienteMayorista is null", conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                int dni = 0;
                int b = 0;
                while (lector.Read())
                {
                    if (b==0)
                    {
                        _notasCredito.Add(new NotaCredito()
                        {
                            CodigoNotaCredito = int.Parse(lector["codigoNotaCredito"].ToString()),
                            Fecha = DateTime.Parse(lector["fecha"].ToString()),
                            FechaVencimiento = DateTime.Parse(lector["fechaVencimiento"].ToString()),
                            NombreCliente = lector["nombreCliente"].ToString(),
                            DniCliente = int.Parse(lector["dniCliente"].ToString()),
                            Saldo = float.Parse(lector["saldo"].ToString()),
                            CodigoVenta = int.Parse(lector["codigoVenta"].ToString()),
                            CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString())
                        });
                        dni = int.Parse(lector["dniCliente"].ToString());
                        b = 1;
                    }
                    else
                    {
                        if (dni!= int.Parse(lector["dniCliente"].ToString()))
                        {
                            _notasCredito.Add(new NotaCredito()
                            {
                                CodigoNotaCredito = int.Parse(lector["codigoNotaCredito"].ToString()),
                                Fecha = DateTime.Parse(lector["fecha"].ToString()),
                                FechaVencimiento = DateTime.Parse(lector["fechaVencimiento"].ToString()),
                                NombreCliente = lector["nombreCliente"].ToString(),
                                DniCliente = int.Parse(lector["dniCliente"].ToString()),
                                Saldo = float.Parse(lector["saldo"].ToString()),
                                CodigoVenta = int.Parse(lector["codigoVenta"].ToString()),
                                CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString())
                            });
                        }                        
                    }                    
                }
                return _notasCredito;
            }
            catch (SqlException e)
            {
                string error = e.ToString();
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool esCliente(int dni)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select * from NotasCredito where dniCliente='" + dni + "'", conexion);

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

        public List<NotaCredito> buscarDatosNotaDeCreditoMayorista(string cuit)
        {
            _notasCredito = new List<NotaCredito>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            conexion.Open();
            try
            {
                SqlCommand consulta = new SqlCommand("select NotasCredito.codigoNotaCredito, NotasCredito.fecha, NotasCredito.fechaVencimiento, NotasCredito.codigoClienteMayorista, NotasCredito.saldo, NotasCredito.codigoVenta, NotasCredito.codigoEncargado from NotasCredito inner join ClientesMayoristas on NotasCredito.codigoClienteMayorista=ClientesMayoristas.codigoClienteMayorista where ClientesMayoristas.cuit='" + cuit +"'", conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    _notasCredito.Add(new NotaCredito()
                    {
                        CodigoNotaCredito = int.Parse(lector["codigoNotaCredito"].ToString()),
                        Fecha = DateTime.Parse(lector["fecha"].ToString()),
                        FechaVencimiento = DateTime.Parse(lector["fechaVencimiento"].ToString()),
                        CodigoClienteMayorista = int.Parse(lector["codigoClienteMayorista"].ToString()),
                        Saldo = float.Parse(lector["saldo"].ToString()),
                        CodigoVenta = int.Parse(lector["codigoVenta"].ToString()),
                        CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString())
                    });
                }
                return _notasCredito;
            }
            catch (SqlException e)
            {
                string error = e.ToString();
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<NotaCredito> buscarDatosNotaDeCreditoMinorista(int dni)
        {
            _notasCredito = new List<NotaCredito>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            conexion.Open();
            try
            {
                SqlCommand consulta = new SqlCommand("select codigoNotaCredito, fecha, fechaVencimiento, nombreCliente, dniCliente, saldo, codigoVenta, codigoEncargado from NotasCredito where dniCliente='"+ dni +"'", conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    _notasCredito.Add(new NotaCredito()
                    {
                        CodigoNotaCredito = int.Parse(lector["codigoNotaCredito"].ToString()),
                        Fecha = DateTime.Parse(lector["fecha"].ToString()),
                        FechaVencimiento = DateTime.Parse(lector["fechaVencimiento"].ToString()),
                        NombreCliente = lector["nombreCliente"].ToString(),
                        DniCliente = int.Parse(lector["dniCliente"].ToString()),
                        Saldo = float.Parse(lector["saldo"].ToString()),
                        CodigoVenta = int.Parse(lector["codigoVenta"].ToString()),
                        CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString())
                    });
                }
                return _notasCredito;
            }
            catch (SqlException e)
            {
                string error = e.ToString();
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
