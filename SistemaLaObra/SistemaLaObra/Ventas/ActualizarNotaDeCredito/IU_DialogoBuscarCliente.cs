using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra.Ventas.RegistrarNotaDeCredito;

namespace SistemaLaObra.Ventas.ActualizarNotaDeCredito
{
    public partial class IU_DialogoBuscarCliente : Form
    {
        //INSTANCIAS
        private Controlador_ActualizarNotaDeCredito _controladorANC;

        public IU_DialogoBuscarCliente(Controlador_ActualizarNotaDeCredito controlador)
        {
            InitializeComponent();
            _controladorANC = controlador;
        }

        public void cargarDatosClienteMayorista(ClienteMayorista itemClienteMayorista)
        {
            dgv_Clientes.Rows.Add("Seleccionar", itemClienteMayorista.RazonSocial, "MAYORISTA", itemClienteMayorista.Cuit);
        }

        public void cargarDatosClienteMinorista(NotaCredito itemNotaCredito)
        {
            dgv_Clientes.Rows.Add("Seleccionar", itemNotaCredito.NombreCliente, "MINORISTA", itemNotaCredito.DniCliente);
        }

        private void mostrarDatosListaNotaCredito(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridView dgv_actual = sender as DataGridView;
                if (_controladorANC.InterfazActualizarNotaDeCredito.rbtn_1.Checked==true)
                {
                    _controladorANC.verificarExistenciaMinorista(int.Parse(dgv_actual.CurrentRow.Cells[3].Value.ToString()));
                    this.Close();
                }
                else
                {
                    _controladorANC.verificarExistenciaMayorista(dgv_actual.CurrentRow.Cells[3].Value.ToString());
                    this.Close();
                }                                
            }
        }
    }
}
