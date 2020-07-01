using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaLaObra.Ventas;

namespace SistemaLaObra
{
    public class Entrega
    {
        //INSTANCIAS
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;
        AccesoDatos acceso;
        private List<Entrega> _entrega;

        //ATRIBUTOS
        private int _codigoEntrega;
        private DateTime _fechaEntrega;
        private DateTime _horaEntregaDesde;
        private DateTime _horaEntregaHasta;
        private string _nombreCliente;
        private string _nombreProvincia;
        private string _nombreDepartamento;
        private string _nombreLocalidad;
        private string _nombreCalle;
        private int _numeroCalle;
        private string _codigoPostal;
        private string _nombreBarrio;
        private string _nombreTipoTelefono;
        private string _numeroTelefono;
        private string _descripcion;
        private float _precioEntrega;
        private float _distanciaEntrega;
        private int _codigoEstadoEntrega;
        private int _codigoEncargado;
        private List<DetalleLogistica> _detalle;
        private Venta _venta;

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

        public DateTime FechaEntrega
        {
            get
            {
                return _fechaEntrega;
            }

            set
            {
                _fechaEntrega = value;
            }
        }

        public DateTime HoraEntregaDesde
        {
            get
            {
                return _horaEntregaDesde;
            }

            set
            {
                _horaEntregaDesde = value;
            }
        }

        public DateTime HoraEntregaHasta
        {
            get
            {
                return _horaEntregaHasta;
            }

            set
            {
                _horaEntregaHasta = value;
            }
        }

        public string NombreCliente
        {
            get
            {
                return _nombreCliente;
            }

            set
            {
                _nombreCliente = value;
            }
        }

        public string NombreProvincia
        {
            get
            {
                return _nombreProvincia;
            }

            set
            {
                _nombreProvincia = value;
            }
        }

        public string NombreDepartamento
        {
            get
            {
                return _nombreDepartamento;
            }

            set
            {
                _nombreDepartamento = value;
            }
        }

        public string NombreLocalidad
        {
            get
            {
                return _nombreLocalidad;
            }

            set
            {
                _nombreLocalidad = value;
            }
        }

        public string NombreCalle
        {
            get
            {
                return _nombreCalle;
            }

            set
            {
                _nombreCalle = value;
            }
        }

        public int NumeroCalle
        {
            get
            {
                return _numeroCalle;
            }

            set
            {
                _numeroCalle = value;
            }
        }

        public string CodigoPostal
        {
            get
            {
                return _codigoPostal;
            }

            set
            {
                _codigoPostal = value;
            }
        }

        public string NombreTipoTelefono
        {
            get
            {
                return _nombreTipoTelefono;
            }

            set
            {
                _nombreTipoTelefono = value;
            }
        }

        public string NumeroTelefono
        {
            get
            {
                return _numeroTelefono;
            }

            set
            {
                _numeroTelefono = value;
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

        public float PrecioEntrega
        {
            get
            {
                return _precioEntrega;
            }

            set
            {
                _precioEntrega = value;
            }
        }

        public float DistanciaEntrega
        {
            get
            {
                return _distanciaEntrega;
            }

            set
            {
                _distanciaEntrega = value;
            }
        }

        public string NombreBarrio
        {
            get
            {
                return _nombreBarrio;
            }

            set
            {
                _nombreBarrio = value;
            }
        }

        public int CodigoEstadoEntrega
        {
            get
            {
                return _codigoEstadoEntrega;
            }

            set
            {
                _codigoEstadoEntrega = value;
            }
        }

        public List<DetalleLogistica> Detalle
        {
            get
            {
                return _detalle;
            }

            set
            {
                _detalle = value;
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

        public Venta Venta
        {
            get
            {
                return _venta;
            }

            set
            {
                _venta = value;
            }
        }
        
        public Entrega()
        {
            CodigoEntrega = 0;
            FechaEntrega = DateTime.Today;
            HoraEntregaDesde = DateTime.Today;
            HoraEntregaHasta = DateTime.Today;
            NombreCliente = "";
            NombreProvincia = "";
            NombreDepartamento = "";
            NombreLocalidad = "";
            NombreCalle = "";
            NumeroCalle = 0;
            CodigoPostal = "";
            NombreTipoTelefono = "";
            NumeroTelefono = "";
            Descripcion = "";
            PrecioEntrega = 0;
            DistanciaEntrega = 0;
            NombreBarrio = "";
            CodigoEstadoEntrega = 1;
            Venta = new Venta();
            CodigoEncargado = 1;//ver mas adelante esto es solo para probar
        }

        //METODOS

        public void crear(int codigoEntrega, int codigoVenta, DateTime fechaEntrega, DateTime horaEntregaDesde, DateTime horaEntregaHasta, string nombreCliente, string nombreProvincia, string nombreDepartamento, string nombreLocalidad, string nombreCalle, string numeroCalle, string codigoPostal, string nombreBarrio, string tipoTelefono, string numeroTelefono, string descripcion, float precio, float distancia, int codigoEstadoEntrega, int codigoEncargado)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            try
            {
                SqlCommand alta = new SqlCommand("insert into Entregas (codigoEntrega, codigoVenta, fechaEntrega, horaEntregaDesde, horaEntregaHasta, nombreCliente, provincia, departamento, localidad, calle, numero, codigoPostal, nombreBarrio, tipoTelefono, numeroTelefono, descripcion, precio, distancia, codigoEstadoEntrega, codigoEncargado) values (@codigoEntrega, @codigoVenta, @fechaEntrega, @horaEntregaDesde, @horaEntregaHasta, @nombreCliente, @provincia, @departamento, @localidad, @calle, @numero, @codigoPostal, @nombreBarrio, @tipoTelefono, @numeroTelefono, @descripcion, @precio, @distancia, @codigoEstadoEntrega, @codigoEncargado)", conexion);
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEntrega", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoVenta", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaEntrega", SqlDbType.Date));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@horaEntregaDesde", SqlDbType.Time));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@horaEntregaHasta", SqlDbType.Time));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreCliente", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@localidad", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numeroTelefono", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@precio", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@distancia", SqlDbType.Float));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEstadoEntrega", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEncargado", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@codigoEntrega"].Value = codigoEntrega;
                adaptador.InsertCommand.Parameters["@codigoVenta"].Value = codigoVenta;
                adaptador.InsertCommand.Parameters["@fechaEntrega"].Value = fechaEntrega.Date;
                adaptador.InsertCommand.Parameters["@horaEntregaDesde"].Value = horaEntregaDesde.TimeOfDay;
                adaptador.InsertCommand.Parameters["@horaEntregaHasta"].Value = horaEntregaHasta.TimeOfDay;
                adaptador.InsertCommand.Parameters["@nombreCliente"].Value = nombreCliente;
                adaptador.InsertCommand.Parameters["@provincia"].Value = nombreProvincia;
                adaptador.InsertCommand.Parameters["@departamento"].Value = nombreDepartamento;
                adaptador.InsertCommand.Parameters["@localidad"].Value = nombreLocalidad;
                adaptador.InsertCommand.Parameters["@calle"].Value = nombreCalle;
                adaptador.InsertCommand.Parameters["@numero"].Value = numeroCalle;
                adaptador.InsertCommand.Parameters["@codigoPostal"].Value = codigoPostal;
                adaptador.InsertCommand.Parameters["@nombreBarrio"].Value = nombreBarrio;
                adaptador.InsertCommand.Parameters["@tipoTelefono"].Value = tipoTelefono;
                adaptador.InsertCommand.Parameters["@numeroTelefono"].Value = numeroTelefono;
                adaptador.InsertCommand.Parameters["@descripcion"].Value = descripcion;
                adaptador.InsertCommand.Parameters["@precio"].Value = precio;
                adaptador.InsertCommand.Parameters["@distancia"].Value = distancia;
                adaptador.InsertCommand.Parameters["@codigoEstadoEntrega"].Value = codigoEstadoEntrega;
                adaptador.InsertCommand.Parameters["@codigoEncargado"].Value = codigoEncargado;

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

        public List<Entrega> mostrarDatosColeccion()
        {
            _entrega = new List<Entrega>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            conexion.Open();
            try
            {
                SqlCommand consulta = new SqlCommand("select codigoEntrega, codigoEstadoEntrega, codigoEncargado, codigoVenta, fechaEntrega, horaEntregaDesde, horaEntregaHasta, nombreCliente, provincia, departamento, localidad, calle, numero, codigoPostal, nombreBarrio, tipoTelefono, numeroTelefono, descripcion, precio, distancia from Entregas", conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    _entrega.Add(new Entrega() {
                        CodigoEntrega= int.Parse(lector["codigoEntrega"].ToString()),
                        CodigoEstadoEntrega= int.Parse(lector["codigoEstadoEntrega"].ToString()),
                        CodigoEncargado= int.Parse(lector["codigoEncargado"].ToString()),                        
                        FechaEntrega=DateTime.Parse(lector["fechaEntrega"].ToString()),
                        HoraEntregaDesde= DateTime.Parse(lector["horaEntregaDesde"].ToString()),
                        HoraEntregaHasta= DateTime.Parse(lector["horaEntregaHasta"].ToString()),
                        NombreCliente= lector["nombreCliente"].ToString(),
                        NombreProvincia = lector["provincia"].ToString(),
                        NombreDepartamento = lector["departamento"].ToString(),
                        NombreLocalidad = lector["localidad"].ToString(),
                        NombreCalle = lector["calle"].ToString(),
                        NumeroCalle= int.Parse(lector["numero"].ToString()),
                        CodigoPostal= lector["codigoPostal"].ToString(),
                        NombreBarrio= lector["nombreBarrio"].ToString(),
                        NombreTipoTelefono= lector["tipoTelefono"].ToString(),
                        NumeroTelefono= lector["numeroTelefono"].ToString(),
                        Descripcion= lector["descripcion"].ToString(),
                        PrecioEntrega= float.Parse(lector["precio"].ToString()),
                        DistanciaEntrega= float.Parse(lector["distancia"].ToString())
                    });                    
                }
                return _entrega;
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

        public List<Entrega> mostrarDatos(int codigoVenta)
        {
            _entrega = new List<Entrega>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            conexion.Open();
            try
            {
                SqlCommand consulta = new SqlCommand("select codigoEntrega, codigoEstadoEntrega, codigoEncargado, codigoVenta, fechaEntrega, horaEntregaDesde, horaEntregaHasta, nombreCliente, provincia, departamento, localidad, calle, numero, codigoPostal, nombreBarrio, tipoTelefono, numeroTelefono, descripcion, precio, distancia from Entregas where codigoVenta='"+codigoVenta+"'", conexion);
                SqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    _entrega.Add(new Entrega()
                    {
                        CodigoEntrega = int.Parse(lector["codigoEntrega"].ToString()),
                        CodigoEstadoEntrega = int.Parse(lector["codigoEstadoEntrega"].ToString()),
                        CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString()),
                        FechaEntrega = DateTime.Parse(lector["fechaEntrega"].ToString()),
                        HoraEntregaDesde = DateTime.Parse(lector["horaEntregaDesde"].ToString()),
                        HoraEntregaHasta = DateTime.Parse(lector["horaEntregaHasta"].ToString()),
                        NombreCliente = lector["nombreCliente"].ToString(),
                        NombreProvincia = lector["provincia"].ToString(),
                        NombreDepartamento = lector["departamento"].ToString(),
                        NombreLocalidad = lector["localidad"].ToString(),
                        NombreCalle = lector["calle"].ToString(),
                        NumeroCalle = int.Parse(lector["numero"].ToString()),
                        CodigoPostal = lector["codigoPostal"].ToString(),
                        NombreBarrio = lector["nombreBarrio"].ToString(),
                        NombreTipoTelefono = lector["tipoTelefono"].ToString(),
                        NumeroTelefono = lector["numeroTelefono"].ToString(),
                        Descripcion = lector["descripcion"].ToString(),
                        PrecioEntrega = float.Parse(lector["precio"].ToString()),
                        DistanciaEntrega = float.Parse(lector["distancia"].ToString())
                    });                    
                }
                return _entrega;
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

        public int conocerVenta(int codigoEntrega)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoVenta from Entregas where codigoEntrega='"+codigoEntrega+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigoVenta"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<DetalleLogistica> conocerDetalleLogistica(int codigoEntrega)
        {            
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoDetalleLogistica, codigoArticulo, cantidad from DetallesLogistica where codigoEntrega='" + codigoEntrega +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    Detalle.Add(new DetalleLogistica() { CodigoDetalleLogistica=int.Parse(lector["codigoDetalleLogistica"].ToString()), Cantidad=int.Parse(lector["cantidad"].ToString()), CodigoArticulo=int.Parse(lector["codigoArticulo"].ToString())});
                }
                return Detalle;
            }
            catch (SqlException)
            {
                return Detalle;
            }
            finally
            {
                conexion.Close();
            }
        }

        public int mostrarUltimoNroEntrega()
        {
            int ultimoCodigo=0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select max(codigoEntrega) as ultimoCodigo from Entregas", conexion);
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
                conexion.Close();
            }
        }

        public void actualizar(Entrega entregaInstanciada)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("update Entregas set codigoEncargado=@codigoEncargado, codigoVenta=@codigoVenta, fechaEntrega=@fechaEntrega, horaEntregaDesde=@horaEntregaDesde, horaEntregaHasta=@horaEntregaHasta, provincia=@provincia, departamento=@departamento, localidad=@localidad, calle=@calle, numero=@numero, codigoPostal=@codigoPostal, nombreBarrio=@nombreBarrio, tipoTelefono=@tipoTelefono, numeroTelefono=@numeroTelefono, descripcion=@descripcion, precio=@precio, distancia=@distancia where codigoEntrega=@codigoEntrega", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = consulta;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoEntrega", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoEncargado", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoVenta", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fechaEntrega", SqlDbType.Date));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@horaEntregaDesde", SqlDbType.Time));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@horaEntregaHasta", SqlDbType.Time));            
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@localidad", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@tipoTelefono", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numeroTelefono", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@precio", SqlDbType.Money));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@distancia", SqlDbType.Float));

            adaptador.UpdateCommand.Parameters["@codigoEntrega"].Value = entregaInstanciada.CodigoEntrega;
            adaptador.UpdateCommand.Parameters["@codigoEncargado"].Value = entregaInstanciada.CodigoEncargado;
            adaptador.UpdateCommand.Parameters["@codigoVenta"].Value = entregaInstanciada.Venta.CodigoVenta;
            adaptador.UpdateCommand.Parameters["@fechaEntrega"].Value = entregaInstanciada.FechaEntrega.Date;
            adaptador.UpdateCommand.Parameters["@horaEntregaDesde"].Value = entregaInstanciada.HoraEntregaDesde.ToShortTimeString();
            adaptador.UpdateCommand.Parameters["@horaEntregaHasta"].Value = entregaInstanciada.HoraEntregaHasta.ToShortTimeString();
            adaptador.UpdateCommand.Parameters["@provincia"].Value = entregaInstanciada.NombreProvincia;
            adaptador.UpdateCommand.Parameters["@departamento"].Value = entregaInstanciada.NombreDepartamento;
            adaptador.UpdateCommand.Parameters["@localidad"].Value = entregaInstanciada.NombreLocalidad;
            adaptador.UpdateCommand.Parameters["@calle"].Value = entregaInstanciada.NombreCalle;
            adaptador.UpdateCommand.Parameters["@numero"].Value = entregaInstanciada.NumeroCalle;
            adaptador.UpdateCommand.Parameters["@codigoPostal"].Value = entregaInstanciada.CodigoPostal;
            adaptador.UpdateCommand.Parameters["@nombreBarrio"].Value = entregaInstanciada.NombreBarrio;
            adaptador.UpdateCommand.Parameters["@tipoTelefono"].Value = entregaInstanciada.NombreTipoTelefono;
            adaptador.UpdateCommand.Parameters["@numeroTelefono"].Value = entregaInstanciada.NumeroTelefono;
            adaptador.UpdateCommand.Parameters["@descripcion"].Value = entregaInstanciada.Descripcion;
            adaptador.UpdateCommand.Parameters["@precio"].Value = entregaInstanciada.PrecioEntrega;
            adaptador.UpdateCommand.Parameters["@distancia"].Value = entregaInstanciada.DistanciaEntrega;

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

        public void actualizarEstadoEntrega(int codigoEntrega, int codigoEstadoEntrega, int codigoEncargado)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("update Entregas set codigoEstadoEntrega=@codigoEstadoEntrega, codigoEncargado=@codigoEncargado where codigoEntrega=@codigoEntrega", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = consulta;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoEstadoEntrega", SqlDbType.Int));            
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoEntrega", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoEncargado", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@codigoEstadoEntrega"].Value = codigoEstadoEntrega;            
            adaptador.UpdateCommand.Parameters["@codigoEntrega"].Value = codigoEntrega;
            adaptador.UpdateCommand.Parameters["@codigoEncargado"].Value = codigoEncargado;

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

        public int mostrarEstadoEntrega(int codigoEntrega)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoEstadoEntrega from Entregas where codigoEntrega='"+codigoEntrega+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoEstadoEntrega = int.Parse(lector["codigoEstadoEntrega"].ToString());
                    return CodigoEstadoEntrega;
                }
                else
                {
                    return CodigoEstadoEntrega;
                }
            }
            catch (NullReferenceException)
            {
                return CodigoEstadoEntrega;
            }
            finally
            {
                conexion.Close();
            }
        }

        public Encargado conocerEncargado(int codigoEncargado)
        {
            Encargado encargado = new Encargado();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select legajo, nombre, apellido, codigoTipoDocumento, nroDocumento, fechaNacimiento, codigoTipoTelefono, nroTelefono, calle, numero, depto, piso, codigoPostal, nombreBarrio, codigoUsuario, codigoProvincia, codigoDepartamento, codigoLocalidad from Encargados where codigoEncargado='" + codigoEncargado + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    encargado.Legajo = int.Parse(lector["legajo"].ToString());
                    encargado.Nombre = lector["nombre"].ToString();
                    encargado.Apellido = lector["apellido"].ToString();
                    encargado.CodigoTipoDocumento = int.Parse(lector["codigoTipoDocumento"].ToString());
                    encargado.NroDocumento = lector["nroDocumento"].ToString();
                    encargado.FechaNacimiento = DateTime.Parse(lector["fechaNacimiento"].ToString());
                    encargado.CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString());
                    encargado.CodigoTipoTelefono = int.Parse(lector["nroTelefono"].ToString());
                    encargado.Calle = lector["calle"].ToString();
                    encargado.Numero = lector["numero"].ToString();
                    encargado.Depto = lector["depto"].ToString();
                    encargado.Piso = lector["piso"].ToString();
                    encargado.CodigoPostal = lector["codigoPostal"].ToString();
                    encargado.NombreBarrio = lector["nombreBarrio"].ToString();
                    encargado.CodigoUsuario = int.Parse(lector["codigoUsuario"].ToString());
                    encargado.CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());

                }
                return encargado;
            }
            catch (Exception e)
            {
                string log = e.ToString();
                return encargado;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }
    }
}
