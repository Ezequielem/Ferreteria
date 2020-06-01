using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaLaObra.Ventas.ReporteDeVentas
{
    public partial class Reporte : Form
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlCommand comando;
        DataTable tabla;
        AccesoDatos acceso;
        
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }

        public void cargarReporteDia(string fecha)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            //cargar datagridview
            conexion.Open();
            comando = new SqlCommand("select codigoVenta, importeTotal, codigoClienteMayorista, codigoNC, dniCliente, codigoEntrega, fechaEntrega, nombreCliente from Ventas where CAST(fechaHoraVenta as date)='" + fecha+"'", conexion);
            adaptador = new SqlDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_reporte.DataSource = tabla;
            conexion.Close();

        }

        public void cargaReporteAcotado(string fecha1, string fecha2)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            //cargar datagridview
            conexion.Open();
            comando = new SqlCommand("select codigoVenta, importeTotal, codigoClienteMayorista, codigoNC, dniCliente, codigoEntrega, fechaEntrega, nombreCliente from Ventas where CAST(fechaHoraVenta as date) BETWEEN '" + fecha1 + "'AND '"+ fecha2 +"'", conexion);
            adaptador = new SqlDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_reporte.DataSource = tabla;
            conexion.Close();
        }

        public void cantidadVentasMayoristas()
        {
            int nroVentasMayoristas = dgv_reporte.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells["codigoClienteMayorista"].Value) != "").Count();
            lbl_nroVentasMayoristas.Text = nroVentasMayoristas.ToString();
        }

        public void cantidadVentasMinoristas()
        {
            int nroVentasMinoristas = dgv_reporte.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells["codigoClienteMayorista"].Value) == "").Count()-1;
            lbl_nroVentasMinoristas.Text = nroVentasMinoristas.ToString();
        }

        public void cantidadVentasTotales()
        {
            lbl_nroTotalVentas.Text = tabla.Rows.Count.ToString();
        }

        public void tomarFechaInicio(string fehaInicio)
        {
            lbl_fechaInicio.Text = fehaInicio;
        }

        public void tomarFechaFin(string fechaFin)
        {
            lbl_fechaFin.Text = fechaFin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
