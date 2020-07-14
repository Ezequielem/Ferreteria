using SistemaLaObra.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte.Empresa.Sucursal
{
    public partial class IU_ConsultarPuntoVenta : Form
    {
        public MiEmpresa MiEmpresa { get; set; }
        public PuntoDeVenta PuntoDeVenta { get; set; }
        public List<PuntoDeVenta> ListaPuntoDeVenta { get; set; }

        public IU_ConsultarPuntoVenta()
        {
            InitializeComponent();
            PuntoDeVenta = new PuntoDeVenta();
            ListaPuntoDeVenta = new List<PuntoDeVenta>();
        }

        //BOTONES

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        //METODOS

        public void opcionConsultarSucursal(MiEmpresa empresa)
        {
            MiEmpresa = empresa;
        }

        private void cargarDataGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_sucursales.Rows.Clear();
            ListaPuntoDeVenta.Clear();
            ListaPuntoDeVenta = PuntoDeVenta.mostrarDatos(MiEmpresa);
            foreach (var item in ListaPuntoDeVenta)
            {
                item.Localidad.mostrarDatos(item.CodigoLocalidad);
                dgv_sucursales.Rows.Add(
                    item.CodigoPuntoVenta.ToString("0000"),
                    item.NombreFantasia,
                    item.Calle + " " + item.Numero,
                    item.Localidad.NombreLocalidad,
                    item.CodigoPuntoVenta
                    );
            }
            Cursor.Current = Cursors.Default;
        }

        private void cargarDataGrid(List<PuntoDeVenta> lista)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_sucursales.Rows.Clear();
            foreach (var item in lista)
            {
                item.Localidad.mostrarDatos(item.CodigoLocalidad);
                dgv_sucursales.Rows.Add(
                    item.CodigoPuntoVenta.ToString("0000"),
                    item.NombreFantasia,
                    item.Calle + " " + item.Numero,
                    item.Localidad.NombreLocalidad,
                    item.CodigoPuntoVenta
                    );
            }
            Cursor.Current = Cursors.Default;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            cargarDataGrid();
        }

        private void txt_nombreSucursal_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombreSucursal.Text.Trim() == string.Empty)
            {
                cargarDataGrid();
            }
            else
            {
                ListaPuntoDeVenta = ListaPuntoDeVenta.Where(x => x.NombreFantasia.Contains(txt_nombreSucursal.Text)).ToList();
                cargarDataGrid(ListaPuntoDeVenta);
            }
        }
    }
}
