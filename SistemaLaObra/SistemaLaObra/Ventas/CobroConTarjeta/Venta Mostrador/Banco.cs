using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaLaObra.Ventas.CobroConTarjeta.Venta_Mayorista;

namespace SistemaLaObra.Ventas.CobroConTarjeta
{
    class Banco
    {
        private SqlConnection conexion;
        IU_CobroConTarjeta interfazTarjeta;
        IU_CobroConTarjetaMayorista interfazTarjetaMay;


        public Banco()
        {

        }
        public void recibirInterfazCobroConTarjeta(IU_CobroConTarjeta interfazCT)
        {
            this.interfazTarjeta = interfazCT;
        }

        public void recibirInterfazCobroConTarjetaMay(IU_CobroConTarjetaMayorista interfazCT)
        {
            this.interfazTarjetaMay = interfazCT;
        }

        public void mostrarDatosBanco(string id_tipoTarjeta)
        {

            AccesoDatos acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            conexion.Open();

            SqlCommand comando = new SqlCommand(" select st1.codigoBanco as csub1, st1.descripcion dsub1 from Bancos st1 inner join ListaTarjetas lta on st1.codigoBanco = lta.codigoBanco where lta.codigoTipoTarjeta = @id_tipoTarjeta", conexion);

            comando.Parameters.AddWithValue("id_tipoTarjeta", id_tipoTarjeta);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);


            conexion.Close();

            DataRow dr = dt.NewRow();
            dr["dsub1"] = "Seleccione";
            dt.Rows.InsertAt(dr, 0);

            if (interfazTarjeta != null)
            {
                interfazTarjeta.cb_Banco.ValueMember = "csub1";
                interfazTarjeta.cb_Banco.DisplayMember = "dsub1";
                interfazTarjeta.cb_Banco.DataSource = dt;
            }
            if (interfazTarjetaMay != null)
            {
                interfazTarjetaMay.cb_Banco.ValueMember = "csub1";
                interfazTarjetaMay.cb_Banco.DisplayMember = "dsub1";
                interfazTarjetaMay.cb_Banco.DataSource = dt;
            }

        }


      /*  private int obtenerCodigoBanco()
        {
            try
            {
                conexion = new SqlConnection(acceso.CadenaConexion());
                conexion.Open();
                consulta = new SqlCommand("select codigoBanco from Bancos where descripcion='" + nombreBanco + "'", conexion);
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigoBanco"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return 0;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }

        }
        */
    }
}
