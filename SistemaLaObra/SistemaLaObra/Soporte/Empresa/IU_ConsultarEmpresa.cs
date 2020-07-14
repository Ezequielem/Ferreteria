using SistemaLaObra.Modelo;
using SistemaLaObra.Soporte.Empresa.Sucursal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte
{
    public partial class IU_ConsultarEmpresa : Form
    {
        public MiEmpresa MiEmpresa { get; set; }
        public List<MiEmpresa> ListaMiEmpresa { get; set; }
        public IU_MenuPrincipal IU_Contenedora { get; set; }


        public IU_ConsultarEmpresa()
        {
            InitializeComponent();
            MiEmpresa = new MiEmpresa();
            ListaMiEmpresa = new List<MiEmpresa>();
        }

        //BOTONES

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            IU_RegistrarEmpresa interfaz = new IU_RegistrarEmpresa();
            interfaz.ShowDialog();
            cargarDataGrid();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_empresas.Rows.Count != 0)
            {
                IU_ModificarEmpresa interfaz = new IU_ModificarEmpresa();
                interfaz.opcionModificarEmpresa(int.Parse(dgv_empresas.CurrentRow.Cells[4].Value.ToString()));
                interfaz.IUContenedora = this.IU_Contenedora;
                interfaz.ShowDialog();
                cargarDataGrid();
            }            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_empresas.Rows.Count != 0)
            {
                IU_EliminarMiEmpresa interfaz = new IU_EliminarMiEmpresa();
                interfaz.opcionEliminar(ListaMiEmpresa.Where(x => x.CodigoMiEmpresa== int.Parse(dgv_empresas.CurrentRow.Cells[4].Value.ToString())).FirstOrDefault(), IU_Contenedora);
                interfaz.ShowDialog();
                cargarDataGrid();
            }
        }

        private void btn_sucursales_Click(object sender, EventArgs e)
        {
            if (dgv_empresas.Rows.Count != 0)
            {
                IU_ConsultarPuntoVenta interfaz = new IU_ConsultarPuntoVenta();
                interfaz.opcionConsultarSucursal(ListaMiEmpresa.Where(x => x.CodigoMiEmpresa == int.Parse(dgv_empresas.CurrentRow.Cells[4].Value.ToString())).FirstOrDefault());
                interfaz.ShowDialog();
            }
        }

        //METODOS

        private void cargarDataGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_empresas.Rows.Clear();
            ListaMiEmpresa.Clear();
            listadoEmpresas();
            foreach (var item in ListaMiEmpresa)
            {
                dgv_empresas.Rows.Add(
                    item.NombreFantasia,
                    item.RazonSocial,
                    item.Cuit,
                    item.FechaInicio.ToShortDateString(),
                    item.CodigoMiEmpresa
                    );
            }
            Cursor.Current = Cursors.Default;
        }

        private void cargarDataGrid(List<MiEmpresa> lista)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_empresas.Rows.Clear();
            foreach (var item in lista)
            {
                dgv_empresas.Rows.Add(
                    item.NombreFantasia,
                    item.RazonSocial,
                    item.Cuit,
                    item.FechaInicio.ToShortDateString(),
                    item.CodigoMiEmpresa
                    );
            }
            Cursor.Current = Cursors.Default;
        }

        private void listadoEmpresas()
        {
            ListaMiEmpresa = MiEmpresa.mostrarDatos();
        }

        //EVENTOS

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            cargarDataGrid();
        }

        private void txt_nombreEmpresa_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombreEmpresa.Text == string.Empty)
            {
                cargarDataGrid();
            }
            else
            {
                ListaMiEmpresa = ListaMiEmpresa.Where(x => x.NombreFantasia.Contains(txt_nombreEmpresa.Text)).ToList();
                cargarDataGrid(ListaMiEmpresa);
            }
        }

        private void dgv_empresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IU_DetalleMiEmpresa interfaz = new IU_DetalleMiEmpresa();
            interfaz.opcionDetalle(ListaMiEmpresa.Where(x => x.CodigoMiEmpresa == int.Parse(dgv_empresas.CurrentRow.Cells[4].Value.ToString())).FirstOrDefault());
            interfaz.ShowDialog();            
        }        
    }
}
