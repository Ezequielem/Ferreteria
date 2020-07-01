using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaLaObra
{
    public class Compra
    {
        //Sql
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;

        //Instancias
        AccesoDatos acceso;

        private int _codigoCompra;
        private DateTime _fechaHora;
        private float _importeTotal;
        private int _codigoEncargadoCompra;
        private List<DetalleCompra> _detalleCompra;
        private Proveedor _proveedor;

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

        public int CodigoEncargadoCompra
        {
            get
            {
                return _codigoEncargadoCompra;
            }

            set
            {
                _codigoEncargadoCompra = value;
            }
        }

        public List<DetalleCompra> DetalleCompra
        {
            get
            {
                return _detalleCompra;
            }

            set
            {
                _detalleCompra = value;
            }
        }

        public Proveedor Proveedor
        {
            get
            {
                return _proveedor;
            }

            set
            {
                _proveedor = value;
            }
        }

        public Compra()
        {
            CodigoCompra = 0;
            FechaHora = DateTime.Now;
            ImporteTotal=0f;
            CodigoEncargadoCompra = 0;
            DetalleCompra = new List<DetalleCompra>();
            Proveedor = new Proveedor();
        }

        //METODOS

        public void crear(Compra compra )
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            try
            {
                SqlCommand alta = new SqlCommand("insert into Compras (codigoCompra, fechaCompra, importeTotal, codigoEncargadoCompra) values (@codigoCompra, @fechaCompra, @importeTotal, @codigoEncargadoCompra)", conexion);
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoCompra", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaCompra", SqlDbType.DateTime));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@importeTotal", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEncargadoCompra", SqlDbType.Int));                

                adaptador.InsertCommand.Parameters["@codigoCompra"].Value = compra.CodigoCompra;
                adaptador.InsertCommand.Parameters["@fechaCompra"].Value = compra.FechaHora;
                adaptador.InsertCommand.Parameters["@importeTotal"].Value = compra.ImporteTotal;
                adaptador.InsertCommand.Parameters["@codigoEncargadoCompra"].Value = compra.CodigoEncargadoCompra;
                
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

        public Compra mostrarDatos(int codigoCompra)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select fechaCompra, importeTotal, codigoCompra, codigoEncargadoCompra from Compras where codigoCompra='" + codigoCompra +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    FechaHora = DateTime.Parse(lector["fechaCompra"].ToString());
                    ImporteTotal = float.Parse(lector["importeTotal"].ToString());
                    CodigoCompra = int.Parse(lector["codigoCompra"].ToString());
                    CodigoEncargadoCompra = int.Parse(lector["codigoEncargadoCompra"].ToString());
                }
                return this;
            }
            catch (Exception e)
            {
                string log = e.ToString();
                return this;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<Compra> mostrarDatosColeccionComprasRecibidas()
        {
            List<Compra> lista = new List<Compra>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select C.codigoCompra as codigo, C.fechaCompra as fecha, C.importeTotal as importe, C.codigoEncargadoCompra as encargado from Compras C inner join Recepciones R on C.codigoCompra=R.codigoCompra where R.codigoEstadoRecepcion=1", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Compra() {
                        CodigoCompra = int.Parse(lector["codigo"].ToString()),
                        FechaHora=DateTime.Parse(lector["fecha"].ToString()),
                        ImporteTotal = float.Parse(lector["importe"].ToString()),
                        CodigoEncargadoCompra = int.Parse(lector["encargado"].ToString())
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

        public Encargado conocerEncargado(int codigoEncargado)
        {
            Encargado encargado= new Encargado();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select legajo, nombre, apellido, codigoTipoDocumento, nroDocumento, fechaNacimiento, codigoTipoTelefono, nroTelefono, calle, numero, depto, piso, codigoPostal, nombreBarrio, codigoUsuario, codigoProvincia, codigoDepartamento, codigoLocalidad from Encargados where codigoEncargado='"+ codigoEncargado +"'", conexion);
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

        public int ultimoCodigoDeCompra()
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


        public float calcularImporteTotal(List<DetalleCompra> detallle)
        {
            float importeTotal = 0f;
            foreach (var item in detallle)
            {
                importeTotal += item.PrecioCoste * item.Cantidad;
            }
            return importeTotal;
        }

        public List<DetalleCompra> mostrarDetalleCompra(int codigoCompra)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoDetalleCompra, codigoCompra, codigoArticulo, cantidad, precioCoste, codigoProveedor from DetallesCompra where codigoCompra='"+ codigoCompra +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                        DetalleCompra.Add(new SistemaLaObra.DetalleCompra() {
                        CodigoDetalleCompra=int.Parse(lector["codigoDetalleCompra"].ToString()),
                        CodigoCompra=int.Parse(lector["codigoCompra"].ToString()),
                        CodigoArticulo=int.Parse(lector["codigoArticulo"].ToString()),
                        Cantidad=int.Parse(lector["cantidad"].ToString()),
                        PrecioCoste=float.Parse(lector["precioCoste"].ToString()),
                        CodigoProveedor=int.Parse(lector["codigoProveedor"].ToString())
                    });
                }
                return DetalleCompra;
            }
            catch (Exception e)
            {
                string log = e.ToString();
                return DetalleCompra;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }
    }
}
