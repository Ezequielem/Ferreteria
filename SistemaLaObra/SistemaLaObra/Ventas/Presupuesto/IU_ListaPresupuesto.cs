using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.Presupuesto
{
    public partial class IU_ListaPresupuesto : Form
    {

        public Controlador_ConsultarPresupuesto Controlador_ConsultarPresupuesto { get; set; }
        Validaciones validacion;
        Presupuesto presupuesto;
        List<Presupuesto> listaPresupuestos;
        ClienteMayorista clienteMayorista;

        public IU_ListaPresupuesto()
        {
            InitializeComponent();
            validacion = new Validaciones();
            presupuesto = new Presupuesto();
            listaPresupuestos = new List<Presupuesto>();
            clienteMayorista = new ClienteMayorista();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            Controlador_ConsultarPresupuesto.interfazConsultarPresupuesto.txt_numeroPresupuesto.Text = dgv_presupuestos.CurrentRow.Cells[0].Value.ToString();
            Controlador_ConsultarPresupuesto.interfazConsultarPresupuesto.btn_buscarPresupuesto.Enabled = true;
            Controlador_ConsultarPresupuesto.interfazConsultarPresupuesto.btn_buscarPresupuesto.PerformClick();
            Controlador_ConsultarPresupuesto.interfazConsultarPresupuesto.btn_buscarPresupuesto.Enabled = false;
            Controlador_ConsultarPresupuesto.interfazConsultarPresupuesto.txt_numeroPresupuesto.Enabled = false;
            this.Close();
        }

        private void btn_buscarAvanzado_Click(object sender, EventArgs e)
        {
            dgv_presupuestos.Rows.Clear();
            if (!validacion.campoVacio(txt_nombreCliente.Text))
            {
                buscarPorNombre();
            }
            else
            {
                if (!validacion.campoVacio(txt_razonSocial.Text))
                {
                    buscarPorRazonSocial();
                }
                else
                {
                    MessageBox.Show("No ingreso ningun criterio de busqueda avanzada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }    
        }

        public void buscarPorNombre()
        {
            listaPresupuestos = presupuesto.obtenerListaPorNombreCliente(txt_nombreCliente.Text);
            if (listaPresupuestos.Count != 0)
            {
                foreach (var item in listaPresupuestos)
                {
                    Encargado encargado = presupuesto.conocerEncargado(item.CodigoEncargado);
                    dgv_presupuestos.Rows.Add(item.CodigoPresupuesto,
                                                                     item.NombreCliente,
                                                                     "",
                                                                     item.Fecha.ToString("dd/MM/yyyy"),
                                                                     item.FechaVencimiento.ToString("dd/MM/yyyy"),
                                                                     item.ImporteTotal,
                                                                     encargado.Nombre + " " + encargado.Apellido);
                }
            }
            else
            {
                MessageBox.Show("No hay presupuestos asociados al criterio de busqueda ingresado");
            }
        }

        public void buscarPorRazonSocial()
        {
            listaPresupuestos = presupuesto.obtenerListaPorRazonSocial(presupuesto.conocerClienteMayorista(txt_razonSocial.Text));
            if (listaPresupuestos.Count != 0)
            {
                foreach (var item in listaPresupuestos)
                {
                    Encargado encargado = presupuesto.conocerEncargado(item.CodigoEncargado);
                    dgv_presupuestos.Rows.Add(item.CodigoPresupuesto,
                                                                     "",
                                                                     presupuesto.conocerClienteMayorista(item.CodigoClienteMayorista).RazonSocial,
                                                                     item.Fecha.ToString("dd/MM/yyyy"),
                                                                     item.FechaVencimiento.ToString("dd/MM/yyyy"),
                                                                     item.ImporteTotal,
                                                                     encargado.Nombre + " " + encargado.Apellido);
                }
            }
            else
            {
                MessageBox.Show("No hay presupuestos asociados al criterio de busqueda ingresado");
            }
        }

        public void autoCompletarRazonSocial(TextBox txt_razonSocial)
        {
            List<string> nombreClientes = clienteMayorista.mostrarColeccionNombreClientes(txt_razonSocial.Text);
            foreach (var item in nombreClientes)
            {
                txt_razonSocial.AutoCompleteCustomSource.Add(item);
            }
        }

        private void IU_ListaPresupuesto_Load(object sender, EventArgs e)
        {
            autoCompletarRazonSocial(txt_razonSocial);
        }

        private void txt_nombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_razonSocial.Text = "";
            validacion.soloLetras(e);
        }

        private void txt_razonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_nombreCliente.Text = "";
        }
    }
}
