using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SistemaLaObra.Ventas.Presupuesto
{
    public class Presupuesto
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataReader lector;
        SqlCommand consulta;

        AccesoDatos acceso;

        int _codigoPresupuesto;
        string _nombreCliente;
        DateTime _fecha;
        DateTime _fechaVencimiento;
        float _importeTotal;
        int _codigoClienteMayorista;
        int _codigoEncargado;

        public int CodigoPresupuesto { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public float ImporteTotal { get; set; }
        public int CodigoClienteMayorista { get; set; }
        public int CodigoEncargado { get; set; }

        public Presupuesto()
        {
            CodigoPresupuesto = 0;
            NombreCliente = "";
            ImporteTotal = 0f;
            CodigoClienteMayorista = 0;
            CodigoEncargado = 0;
        }

        public void crear(Presupuesto presupuesto)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();

            try
            {
                consulta = new SqlCommand("insert into Presupuestos (codigoPresupuesto,nombreCliente,fecha,fechaVencimiento,importeTotal,codigoClienteMayorista,codigoEncargado) values (@codigoPresupuesto,@nombreCliente,@fecha,@fechaVencimiento,@importeTotal,@codigoClienteMayorista,@codigoEncargado)", conexion);
                adaptador.InsertCommand = consulta;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPresupuesto", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreCliente", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaVencimiento", SqlDbType.Date));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@importeTotal", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoClienteMayorista", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoEncargado", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@codigoPresupuesto"].Value = presupuesto.CodigoPresupuesto;

                //Esta validacion se hace para que se carge null la columna nombreCliente
                if (presupuesto.NombreCliente=="") adaptador.InsertCommand.Parameters["@nombreCliente"].Value = DBNull.Value;
                else adaptador.InsertCommand.Parameters["@nombreCliente"].Value = presupuesto.NombreCliente;
                //

                adaptador.InsertCommand.Parameters["@fecha"].Value = presupuesto.Fecha;
                adaptador.InsertCommand.Parameters["@fechaVencimiento"].Value = presupuesto.FechaVencimiento;
                adaptador.InsertCommand.Parameters["@importeTotal"].Value = presupuesto.ImporteTotal;

                //Esta validacion se hace para que se carge null la columna codigoClienteMayorista
                if(presupuesto.CodigoClienteMayorista == 0) adaptador.InsertCommand.Parameters["@codigoClienteMayorista"].Value = DBNull.Value;
                else adaptador.InsertCommand.Parameters["@codigoClienteMayorista"].Value = presupuesto.CodigoClienteMayorista;
                //

                adaptador.InsertCommand.Parameters["@codigoEncargado"].Value = presupuesto.CodigoEncargado;

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

        public void mostrarDatos(int codigoPresupuesto){
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select * from Presupuestos where codigoPresupuesto='"+codigoPresupuesto+"'",conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read()){

                    CodigoPresupuesto = int.Parse(lector["codigoPresupuesto"].ToString());

                    //Si se lee null se carga VACIO por defecto
                    if (lector["nombreCliente"] == null) NombreCliente = "";
                    else NombreCliente = lector["nombreCliente"].ToString();
                    //

                    Fecha = (DateTime)lector["fecha"];
                    FechaVencimiento = (DateTime)lector["fechaVencimiento"];
                    ImporteTotal = float.Parse(lector["importeTotal"].ToString());

                    //Se hace esta comprobacion para evitar error si el codigoClienteMayorista se encuentra null, en caso de ser verdadero se carga con el valor 0
                    int numero;
                    bool resultado = int.TryParse(lector["codigoClienteMayorista"].ToString(), out numero);
                    if (resultado) CodigoClienteMayorista = numero;
                    else CodigoClienteMayorista = 0; 
                    //

                    CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString());
                }
                else
                {
                    MessageBox.Show("El presupuesto no existe");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public void conocerDetalleVP(){

        }

        public Encargado conocerEncargado(int codigoEncargado)
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

        public int conocerClienteMayorista(string razonSocial){

            int codigoClienteMayorista = 0;

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoClienteMayorista from ClientesMayoristas where razonSocial='" + razonSocial + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    codigoClienteMayorista = int.Parse(lector["codigoClienteMayorista"].ToString());
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
            return codigoClienteMayorista;
        }

        public bool verificarNumeroPresupuesto (int codigoPresupuesto){

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select codigoPresupuesto from Presupuestos where codigoPresupuesto='"+codigoPresupuesto+"'", conexion);
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
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public int ultimoCodigoPresupuesto()
        {
            int ultimoCodigoPresupuesto = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT MAX(codigoPresupuesto) AS codigoPresupuesto FROM Presupuestos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    int valor;
                    bool resultado = int.TryParse(lector["codigoPresupuesto"].ToString(), out valor);
                    if (resultado)
                    {
                        ultimoCodigoPresupuesto = valor;
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());        
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return ultimoCodigoPresupuesto;
        }

        public List<Presupuesto> obtenerListaPorNombreCliente(string nombreCliente)
        {
            List<Presupuesto> listaPresupuesto = new List<Presupuesto>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Presupuestos WHERE nombreCliente='"+nombreCliente+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaPresupuesto.Add(new Presupuesto {
                        CodigoPresupuesto = int.Parse(lector["codigoPresupuesto"].ToString()),
                        NombreCliente = lector["nombreCliente"].ToString(),
                        Fecha = (DateTime)lector["fecha"],
                        FechaVencimiento = (DateTime)lector["fechaVencimiento"],
                        ImporteTotal = float.Parse(lector["importeTotal"].ToString()),
                        CodigoClienteMayorista = 0,
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
            return listaPresupuesto;
        }

        public List<Presupuesto> obtenerListaPorRazonSocial(int codigoClienteMayorista)
        {
            List<Presupuesto> listaPresupuesto = new List<Presupuesto>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Presupuestos WHERE codigoClienteMayorista='" + codigoClienteMayorista + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaPresupuesto.Add(new Presupuesto
                    {
                        CodigoPresupuesto = int.Parse(lector["codigoPresupuesto"].ToString()),
                        NombreCliente = lector["nombreCliente"].ToString(),
                        Fecha = (DateTime)lector["fecha"],
                        FechaVencimiento = (DateTime)lector["fechaVencimiento"],
                        ImporteTotal = float.Parse(lector["importeTotal"].ToString()),
                        CodigoClienteMayorista = int.Parse(lector["codigoClienteMayorista"].ToString()),
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
            return listaPresupuesto;
        }
    }
}