using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SistemaLaObra;

namespace SistemaLaObra
{

   public class Tarjeta
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;
        AccesoDatos acceso;


        // Variables
        private int codigoTarjeta;
        private float importeTarjeta;
        private float importeTotalVentaCalculado;
        private string nombre;
        private string apellido;
        private int interes;
        private int cuotas;
        int codigoNombreTarjeta;
        int codigoBanco;
        int codigoTipoTarjeta;
        private long numeroTarjeta;
        private int codigoVenta;


        public Tarjeta()
        {
            codigoTarjeta=0;
            importeTarjeta = 0.00f;
            importeTotalVentaCalculado = 0.00f;
            nombre = "";
            apellido="";
            interes = 0;
            cuotas = 0;
            codigoNombreTarjeta = 0;
            codigoBanco = 0;
            codigoTipoTarjeta = 0;
            numeroTarjeta = 0;
        }

        public int CodigoTarjeta
        {
            set { this.codigoTarjeta = value; }
            get { return codigoTarjeta; }

        }

       public string Nombre
        {
            set { this.nombre = value; }
            get { return nombre; }
        }

        public string Apellido
        {
            set { this.apellido = value; }
            get { return apellido; }
        }

        public int Interes
        {
            set { this.interes= value; }
            get { return interes; }
        }

        public int Cuota
        {
            set { this.cuotas = value; }
            get { return cuotas; }
        }

        public int CodigoNombreTarjeta
        {
            set { this.codigoNombreTarjeta = value; }
            get { return codigoNombreTarjeta; }
        }

        public int CodigoBanco
        {
            set { this.codigoBanco = value; }
            get { return codigoBanco; }
        }

        public int CodigoTipoTarjeta
        {
            set { this.codigoTipoTarjeta = value; }
            get { return codigoTipoTarjeta; }
        }

        public float ImporteTarjeta
        {
            set { this.importeTarjeta = value; }
            get { return importeTarjeta; }
        }

        public float ImporteTotalVentaCalculado
        {
            set { this.importeTotalVentaCalculado = value; }
            get { return importeTotalVentaCalculado; }
        }

        public long NumeroTarjeta
        {
            set { this.numeroTarjeta = value; }
            get { return numeroTarjeta; }
        }

        public int CodigoVenta
        {
            get
            {
                return codigoVenta;
            }

            set
            {
                codigoVenta = value;
            }
        }


        //METODOS


        public void crear(string nombre, string apellido, int interes, int cuota, int codigoNombreTarjeta, int codigoTipoTarjeta, int codigoBanco, long numeroTarjeta, float importeTarjeta, int codigoVenta ) 
        { 
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();
            consulta = new SqlCommand("INSERT INTO Tarjetas (nombre, apellido, interes, cuota, codigoNombreTarjeta, codigoTipoTarjeta, codigoBanco, numeroTarjeta, importeTarjeta, codigoVenta) VALUES (@nombre, @apellido, @interes, @cuota, @codigoNombreTarjeta, @codigoTipoTarjeta, @codigoBanco, @numeroTarjeta, @importeTarjeta, @codigoVenta)", conexion);
            adaptador.InsertCommand = consulta;

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@interes", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuota", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoNombreTarjeta", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTipoTarjeta", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoBanco", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numeroTarjeta", SqlDbType.BigInt));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@importeTarjeta", SqlDbType.Money));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoVenta", SqlDbType.Int));

            adaptador.InsertCommand.Parameters["@nombre"].Value = nombre;
            adaptador.InsertCommand.Parameters["@apellido"].Value = apellido;
            adaptador.InsertCommand.Parameters["@interes"].Value = interes;
            adaptador.InsertCommand.Parameters["@cuota"].Value = cuota;
            adaptador.InsertCommand.Parameters["@codigoNombreTarjeta"].Value = codigoNombreTarjeta;
            adaptador.InsertCommand.Parameters["@codigoTipoTarjeta"].Value = codigoTipoTarjeta;
            adaptador.InsertCommand.Parameters["@codigoBanco"].Value = codigoBanco;
            adaptador.InsertCommand.Parameters["@numeroTarjeta"].Value = numeroTarjeta;
            adaptador.InsertCommand.Parameters["@importeTarjeta"].Value = importeTarjeta;
            adaptador.InsertCommand.Parameters["@codigoVenta"].Value = codigoVenta;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public int mostrarUltimoNroTarjeta()
        {
            int ultimoCodigo = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select max(codigoTarjeta) as ultimoCodigo from Entregas", conexion);
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

        //visa, master, cordobesa, etc
        public string mostrarTarjeta (int codigo)
            
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from NombreTarjetas where codigoTarjeta='" + codigo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return lector["descripcion"].ToString();

               
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                return "false";
            }
            finally
            {
                conexion.Close();
            }
        }

        //debito, credito
        public string mostrarTipoTarjeta(int codigo)

        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from TiposTarjetas where codigoTipoTarjeta='" + codigo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return lector["descripcion"].ToString();


                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                return "false";
            }
            finally
            {
                conexion.Close();
            }
        }

        //galicia, santander Rio, Nacion, etc
        public string mostrarBancoTarjeta(int codigo)

        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Bancos where codigoBanco='" + codigo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return lector["descripcion"].ToString();


                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                return "false";
            }
            finally
            {
                conexion.Close();
            }
        }

        ////////////////////////////////////////////NO BORRAR///////////////////////////////////////////////
        public List<Tarjeta> obtenerListaTarjeta(int codigoVenta)
        {
            List<Tarjeta> listaTarjeta = new List<Tarjeta>();

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Tarjetas WHERE codigoVenta='"+codigoVenta+"'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaTarjeta.Add(new Tarjeta { CodigoTarjeta = int.Parse(lector["codigoTarjeta"].ToString()),
                                                   Nombre = lector["nombre"].ToString(),
                                                   Apellido = lector["apellido"].ToString(),
                                                   Interes = int.Parse(lector["interes"].ToString()),
                                                   Cuota = int.Parse(lector["cuota"].ToString()),
                                                   CodigoNombreTarjeta = int.Parse(lector["codigoNombreTarjeta"].ToString()),
                                                   CodigoTipoTarjeta = int.Parse(lector["codigoTipoTarjeta"].ToString()),
                                                   CodigoBanco = int.Parse(lector["codigoBanco"].ToString()),
                                                   NumeroTarjeta = long.Parse(lector["numeroTarjeta"].ToString()),
                                                   ImporteTarjeta = float.Parse(lector["importeTarjeta"].ToString()),
                                                   CodigoVenta = int.Parse(lector["codigoVenta"].ToString())
                    });
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return null;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return listaTarjeta;
        }
        ////////////////////////////////////////////NO BORRAR///////////////////////////////////////////////

    }
}


