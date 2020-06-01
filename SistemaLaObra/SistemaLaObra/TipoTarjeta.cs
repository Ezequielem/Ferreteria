using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SistemaLaObra.Ventas.CobroConTarjeta.Venta_Mayorista;

namespace SistemaLaObra
{
    class TipoTarjeta
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private SqlCommand modificacion;
        IU_CobroConTarjeta interfazTarjeta;
        IU_CobroConTarjetaMayorista interfazTarjetaMay;
        
 

        public TipoTarjeta()
        {
           
        }


        public void recibirInterfazCobroConTarjeta(IU_CobroConTarjeta interfazCT)
        {
            this.interfazTarjeta = interfazCT;
        }

        public void recibirInterfazCobroConTarjetaMayorista(IU_CobroConTarjetaMayorista interfazCT)
        {
            this.interfazTarjetaMay = interfazCT;
        }

        public void mostrarDatosTipoTarjeta()

         {
             AccesoDatos acceso = new AccesoDatos();
             conexion = new SqlConnection(acceso.CadenaConexion());
             conexion.Open();

             SqlCommand comandoConsulta = new SqlCommand("select codigoTipoTarjeta, descripcion from TiposTarjetas ", conexion);

             SqlDataAdapter da = new SqlDataAdapter(comandoConsulta);
             DataTable dt = new DataTable();
             da.Fill(dt);
             conexion.Close();

             DataRow fila = dt.NewRow();
             fila["descripcion"] = "Seleccione";
             dt.Rows.InsertAt(fila, 0);

            if (interfazTarjeta != null)
            {

                interfazTarjeta.cb_tipoTarjeta.ValueMember = "codigoTipoTarjeta";
                interfazTarjeta.cb_tipoTarjeta.DisplayMember = "descripcion";
                interfazTarjeta.cb_tipoTarjeta.DataSource = dt;
            }

            if (interfazTarjetaMay !=null)
            {
                interfazTarjetaMay.cb_tipoTarjeta.ValueMember = "codigoTipoTarjeta";
                interfazTarjetaMay.cb_tipoTarjeta.DisplayMember = "descripcion";
                interfazTarjetaMay.cb_tipoTarjeta.DataSource = dt;
            }

         }

    /*       private int obtenerCodigoTipoTarjeta()
         {
             try
             {
                 conexion = new SqlConnection(acceso.CadenaConexion());
                 conexion.Open();
                 consulta = new SqlCommand("select codigoTipoTarjeta from TiposTarjetas where descripcion='" + nombreTipoTarjeta + "'", conexion);
                 lector = consulta.ExecuteReader();
                 if (lector.Read())
                 {
                     return int.Parse(lector["codigoTipoTarjeta"].ToString());
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
