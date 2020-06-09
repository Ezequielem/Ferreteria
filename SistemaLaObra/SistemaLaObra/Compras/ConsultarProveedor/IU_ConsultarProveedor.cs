using SistemaLaObra.Compras.ActualizarProveedor;
using SistemaLaObra.Compras.RegistrarProveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Compras.ConsultarProveedor
{
    public partial class IU_ConsultarProveedor : Form
    {
        private Controlador_ConsultarProveedor controladorCP;

        public IU_ConsultarProveedor()
        {
            InitializeComponent();
            controladorCP = new Controlador_ConsultarProveedor(this);
        }

        //BOTONES

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            IU_RegistrarProveedor interfaz = new IU_RegistrarProveedor();
            interfaz.ShowDialog();
            cargarDataGrid();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_proveedores.Rows.Count!=0)
            {
                IU_ActualizarProveedor interfaz = new IU_ActualizarProveedor();
                interfaz.opcionModificarProveedor(int.Parse(dgv_proveedores.CurrentRow.Cells[6].Value.ToString()));
                interfaz.ShowDialog();
                cargarDataGrid();
            }            
        }

        //METODOS

        private void cargarDataGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_proveedores.Rows.Clear();
            controladorCP.ListaProveedores.Clear();
            controladorCP.listadoProveedores();
            foreach (var item in controladorCP.ListaProveedores)
            {
                item.TipoTelefono.mostrarDatos(item.IdTipoTelefonoUno);
                dgv_proveedores.Rows.Add(
                    item.NombreFantasia,
                    item.Cuit,
                    item.NombreContactoUno,
                    item.CargoContactoUno,
                    item.TipoTelefono.mostrarNombre(item.IdTipoTelefonoUno),
                    item.NumeroDeTelefonoUno,
                    item.CodigoProveedor
                    );
            }
            Cursor.Current = Cursors.Default;
        }

        private void cargarDataGrid(List<Proveedor> lista)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_proveedores.Rows.Clear();
            foreach (var item in lista)
            {
                dgv_proveedores.Rows.Add(
                    item.NombreFantasia,
                    item.Cuit,
                    item.NombreContactoUno,
                    item.CargoContactoUno,
                    item.TipoTelefono.mostrarNombre(item.IdTipoTelefonoUno),
                    item.NumeroDeTelefonoUno,
                    item.CodigoProveedor
                    );
            }
            Cursor.Current = Cursors.Default;
        }

        //EVENTOS

        private void IU_ConsultarProveedor_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            if (txt_filtro.Text == string.Empty)
            {
                cargarDataGrid();
            }
            else
            {
                controladorCP.ListaProveedores = controladorCP.ListaProveedores.Where(x => x.NombreFantasia.Contains(txt_filtro.Text)).ToList();
                cargarDataGrid(controladorCP.ListaProveedores);
            }
        }
    }
}
