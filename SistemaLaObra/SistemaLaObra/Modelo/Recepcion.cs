using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaLaObra
{
    public class Recepcion
    {
        //Sql
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;
        SqlCommand alta;

        //Instancias
        AccesoDatos acceso;

        private int _codigoRecepcion;
        private DateTime _fechaHoraRecepcion;
        private int _codigoEstadoRecepcion;
        private int _codigoCompra;
        private Compra _compra;
        private List<DetalleLogistica> _detalle;
        private List<Recepcion> _listadoRecepcion;

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

        public DateTime FechaHoraRecepcion
        {
            get
            {
                return _fechaHoraRecepcion;
            }

            set
            {
                _fechaHoraRecepcion = value;
            }
        }

        public int CodigoEstadoRecepcion
        {
            get
            {
                return _codigoEstadoRecepcion;
            }

            set
            {
                _codigoEstadoRecepcion = value;
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

        public Compra Compra
        {
            get
            {
                return _compra;
            }

            set
            {
                _compra = value;
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

        public List<Recepcion> ListadoRecepcion
        {
            get
            {
                return _listadoRecepcion;
            }

            set
            {
                _listadoRecepcion = value;
            }
        }

        public Recepcion()
        {
            CodigoRecepcion = 0;
            FechaHoraRecepcion = DateTime.Now;
            CodigoEstadoRecepcion = 0;
            CodigoCompra = 0;
            Compra = new Compra();
            Detalle = new List<DetalleLogistica>();
        }

        //METODOS

        public void crear(Recepcion recepcion)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            alta = new SqlCommand("insert into Recepciones (codigoRecepcion, fechaHoraRecepcion, codigoEstadoRecepcion, codigoCompra) values (@codigoRecepcion, @fechaHoraRecepcion, @codigoEstadoRecepcion, @codigoCompra)", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoRecepcion", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaHoraRecepcion", SqlDbType.DateTime));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEstadoRecepcion", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoCompra", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@codigoRecepcion"].Value = recepcion.CodigoRecepcion;
                adaptador.InsertCommand.Parameters["@fechaHoraRecepcion"].Value = recepcion.FechaHoraRecepcion;
                adaptador.InsertCommand.Parameters["@codigoEstadoRecepcion"].Value = recepcion.CodigoEstadoRecepcion;
                adaptador.InsertCommand.Parameters["@codigoCompra"].Value = recepcion.CodigoCompra;

                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string log = e.ToString();
            }
            finally
            {
                conexion.Close();
            }
        }


        //solo muestra los estados pendiente o parcial.
        public List<Recepcion> mostrarColeccionRecepciones()
        {
            ListadoRecepcion = new List<Recepcion>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            //consulta = new SqlCommand("SELECT * FROM Recepciones", conexion);
            consulta = new SqlCommand("SELECT * FROM Recepciones where codigoEstadoRecepcion = 1 or codigoEstadoRecepcion= 2", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    ListadoRecepcion.Add(new Recepcion()
                    {
                        CodigoRecepcion = int.Parse(lector["codigoRecepcion"].ToString()),
                        FechaHoraRecepcion = DateTime.Parse(lector["fechaHoraRecepcion"].ToString()),
                        CodigoEstadoRecepcion = int.Parse(lector["codigoEstadoRecepcion"].ToString()),
                        CodigoCompra = int.Parse(lector["codigoCompra"].ToString())
                    });
                }

            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return ListadoRecepcion;
        }





        public Compra conocerCompra()
        {

            return Compra;
        }

        public List<DetalleLogistica> conocerDetalleLogistica()
        {
            return Detalle;
        }

        public int ultimoCodigoRecepcion()
        {
            int ultimocodigo = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select max(codigoRecepcion) as ultimoCodigo from Recepciones", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    ultimocodigo = int.Parse(lector["ultimoCodigo"].ToString());
                }
                return ultimocodigo;
            }
            catch (Exception e)
            {
                string log = e.ToString();
                return ultimocodigo;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public string conocerDescripcionEstado(int codigoEstado)
        {
            string descrip = "";
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select descripcion from EstadoRecepciones where codigoEstadoRecepcion='" + codigoEstado + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    descrip = lector["descripcion"].ToString();
                }              
            }
           
            catch (SqlException exepcion)
            {
                MessageBox.Show(exepcion.ToString());
            }
            finally
            { 
           
             lector.Close();
             conexion.Close();
            }
            return descrip;
        }
    }
}

