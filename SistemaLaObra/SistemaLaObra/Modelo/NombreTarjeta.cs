using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaLaObra.Ventas.CobroConTarjeta.Venta_Mayorista;
using System.Windows.Forms;


namespace SistemaLaObra
{

   public class NombreTarjeta
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador = new SqlDataAdapter();
        private SqlCommand alta;
        IU_CobroConTarjeta interfazTarjeta;
        IU_CobroConTarjetaMayorista interfazTarjetaMay;
        AccesoDatos acceso;
        SqlCommand consulta;
        SqlDataReader lector;
        List<NombreTarjeta> listaNombreTarjeta;

        //atributos

        int codigoNombreTarjeta;
        string descripcion;

        public NombreTarjeta()
        {
            CodigoNombreTarjeta = 0;
            Descripcion = "";
            listaNombreTarjeta = new List<NombreTarjeta>();
        }

        public int CodigoNombreTarjeta
        {
            get
            {
                return codigoNombreTarjeta;
            }

            set
            {
                codigoNombreTarjeta = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public List <NombreTarjeta> ListaNombreTarjeta
        {
            get
            {
                return listaNombreTarjeta;
            }

            set
            {
                listaNombreTarjeta = value;
            }
        }

        public void crear(int codigo, string nombre)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            alta = new SqlCommand("insert into NombreTarjetas (codigoTarjeta, descripcion) values (@codigoTarjeta, @descripcion)", conexion);
            adaptador.InsertCommand = alta;

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTarjeta", SqlDbType.Int));
            adaptador.InsertCommand.Parameters["@codigoTarjeta"].Value = codigo;


            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters["@descripcion"].Value = nombre;

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

        public List<NombreTarjeta> mostrarDatosColeccion()
        {
            listaNombreTarjeta = new List<NombreTarjeta>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select * from NombreTarjetas", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    ListaNombreTarjeta.Add(new NombreTarjeta { CodigoNombreTarjeta = int.Parse(lector["codigoTarjeta"].ToString()), Descripcion = lector["descripcion"].ToString() });
                }
                return ListaNombreTarjeta;
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
        }

        public void recibirInterfazCobroConTarjeta(IU_CobroConTarjeta interfazCT)
        {
            this.interfazTarjeta = interfazCT;
        }

        public void recibirInterfazCobroConTarjetaMay(IU_CobroConTarjetaMayorista interfazCT)
        {
            this.interfazTarjetaMay = interfazCT;
        }


        public void mostrarDatosNomTarjeta(string id_nombreTarjeta)
        {

            AccesoDatos acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            conexion.Open();

            SqlCommand comando = new SqlCommand("select st1.codigoTarjeta as csub1, st1.descripcion dsub1 from NombreTarjetas st1 inner join ListaTarjetas lta on st1.codigoTarjeta = lta.codigoTarjeta where lta.codigoBanco = @id_nombreTarjeta", conexion);

            comando.Parameters.AddWithValue("id_nombreTarjeta", id_nombreTarjeta);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);


            conexion.Close();

            DataRow dr = dt.NewRow();
            dr["dsub1"] = "Seleccione";
            dt.Rows.InsertAt(dr, 0);

            if (interfazTarjeta != null)
            {

                interfazTarjeta.cb_tarjeta.ValueMember = "csub1";
                interfazTarjeta.cb_tarjeta.DisplayMember = "dsub1";
                interfazTarjeta.cb_tarjeta.DataSource = dt;
            }

            if (interfazTarjetaMay!= null)
            {

                interfazTarjetaMay.cb_tarjeta.ValueMember = "csub1";
                interfazTarjetaMay.cb_tarjeta.DisplayMember = "dsub1";
                interfazTarjetaMay.cb_tarjeta.DataSource = dt;
            }

        }

        public int mostrarCodigo(string tarjeta)

        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoTarjeta from NombreTarjetas where descripcion='" + tarjeta + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigoTarjeta"].ToString());


                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conexion.Close();
            }
        }

        public int mostrarUltimoNombreTarjetas()
        {
            int ultimoCodigo = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select max(codigoTarjeta) as ultimoCodigo from NombreTarjetas ", conexion);
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

        public void actualizarNombreTarjeta(string nombreActual, string nombreTarjeta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand actualizar = new SqlCommand("update NombreTarjetas set descripcion= '" + nombreTarjeta +"' where descripcion ='" + nombreActual + "'", conexion);
            try
            {
                conexion.Open();
                lector = actualizar.ExecuteReader();
                if (lector.RecordsAffected>0)
                {
                    MessageBox.Show("Los datos se actualizaron correctamente");
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
        }
    }
}

