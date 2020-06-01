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
    public partial class IU_ActualizarNotaDeCredito : Form
    {
        //INSTANCIAS
        private Controlador_ActualizarNotaDeCredito _controladorANC;
        Validaciones validar;

        private Controlador_Venta _controladorV;
        private Controlador_VentaMayorista _controladorVM;

        float valor = 0f;

        public Controlador_Venta ControladorV
        {
            get
            {
                return _controladorV;
            }

            set
            {
                _controladorV = value;
            }
        }

        public Controlador_VentaMayorista ControladorVM
        {
            get
            {
                return _controladorVM;
            }

            set
            {
                _controladorVM = value;
            }
        }

        public IU_ActualizarNotaDeCredito()
        {
            InitializeComponent();
            _controladorANC = new Controlador_ActualizarNotaDeCredito(this);
            validar = new Validaciones();
        }

        //BOTONES

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            valor = 0f;
            lbl_saldoNC.Text = valor.ToString("$ 0.00");
            if (ControladorVM==null)
            {
                lbl_saldoRestanteNC.Text = (valor - ControladorV.venta.ImporteTotal).ToString("$ 0.00");
                tomarNombreCliente();
                _controladorANC.interfazCliente();
            }
            else
            {
                lbl_saldoRestanteNC.Text = (valor - ControladorVM.venta.ImporteTotal).ToString("$ 0.00");
                tomarNombreCliente();
                _controladorANC.interfazCliente();
            }            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            tomarConfirmacionAtualizacion();
        }

        //METODOS

        public void opcionActualizarNotaDeCredito(Controlador_Venta controladorV)
        {
            ControladorV = controladorV;            
        }

        public void opcionActualizarNotaDeCredito(Controlador_VentaMayorista controladorVM)
        {
            ControladorVM = controladorVM;
        }

        public void tomarNombreCliente()
        {
            _controladorANC.nombreClienteIngresado(txt_nombreCliente.Text);
        }

        public void mostrarListaDatosNotaDeCredito(List<NotaCredito> notasDeCredito)
        {
            dgv_notasDeCredito.Rows.Clear();
            _controladorANC.ListaNotaCreditoStandBy.Clear();
            valor = 0f;
            if (ControladorVM==null)
            {
                lbl_saldoRestanteNC.Text = (valor - ControladorV.venta.ImporteTotal).ToString("$ 0.00");
            }
            else
            {
                lbl_saldoRestanteNC.Text = (valor - ControladorVM.venta.ImporteTotal).ToString("$ 0.00");
            }
            foreach (var item in notasDeCredito)
            {
                dgv_notasDeCredito.Rows.Add(false ,item.CodigoNotaCredito, item.Saldo, item.Fecha, item.FechaVencimiento, item.CodigoVenta);
                _controladorANC.ListaNotaCreditoStandBy.Add(item);
            }
        }

        public void tomarSeleccionNotaDeCredito(int codigoNotaCredito)
        {
            foreach (var item in _controladorANC.ListaNotaCreditoStandBy)
            {
                if (item.CodigoNotaCredito == codigoNotaCredito)
                {
                    _controladorANC.ListaAActualizar.Add(item);
                }
            }
        }

        public void tomarDeseleccionNotaDeCredito(int codigoNotaCredito)
        {
            foreach (var item in _controladorANC.ListaNotaCreditoStandBy)
            {
                if (item.CodigoNotaCredito == codigoNotaCredito)
                {
                    _controladorANC.ListaAActualizar.Remove(item);
                }
            }
        }

        public void tomarConfirmacionAtualizacion()
        {
            if (_controladorANC.ListaAActualizar.Count==0)
            {
                MessageBox.Show(this, "Debe seleccionar al menos una nota de crédito o cancele la operación", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ControladorVM==null)
                {
                    if (valorTotalNotasDeCredito() < ControladorV.venta.ImporteTotal)
                    {
                        ponerACeroNotasDeCredito();
                    }
                    else
                    {
                        asignarSaldoANotasCredito();
                    }
                    ControladorV.tomarActualizacionNotaCredito(_controladorANC.ListaAActualizar);
                    this.Close();
                }
                else
                {
                    if (valorTotalNotasDeCredito() < ControladorVM.venta.ImporteTotal)
                    {
                        ponerACeroNotasDeCredito();
                    }
                    else
                    {
                        asignarSaldoANotasCredito();
                    }
                    ControladorVM.tomarActualizacionNotaCredito(_controladorANC.ListaAActualizar);
                    this.Close();
                }
            }  
        }

        private float valorTotalNotasDeCredito()
        {
            float total = 0f;
            foreach (var item in _controladorANC.ListaAActualizar)
            {
                total = total + item.Saldo;
            }
            return total;
        }

        private void ponerACeroNotasDeCredito()
        {

            float valorAuxiliar;
            if (ControladorVM==null)
            {
                valorAuxiliar = ControladorV.venta.ImporteTotal;
            }
            else
            {
                valorAuxiliar = ControladorVM.venta.ImporteTotal;
            }
            _controladorANC.ListaAActualizar.OrderBy(x => x.Saldo);
            foreach (var item in _controladorANC.ListaAActualizar)
            {
                if (valorAuxiliar > item.Saldo)
                {
                    valorAuxiliar = valorAuxiliar - item.Saldo;
                    item.SaldoAnterior = item.Saldo;
                    item.Saldo = 0;
                }
                else
                {
                    item.SaldoAnterior = item.Saldo;
                    item.Saldo = item.Saldo - valorAuxiliar;
                }
            }
        }

        private void asignarSaldoANotasCredito()
        {
            float valorAuxiliar;
            if (ControladorVM == null)
            {
                valorAuxiliar = ControladorV.venta.ImporteTotal;
            }
            else
            {
                valorAuxiliar = ControladorVM.venta.ImporteTotal;
            }
            _controladorANC.ListaAActualizar.OrderBy(x=>x.Saldo);
            foreach (var item in _controladorANC.ListaAActualizar)
            {
                if (valorAuxiliar > item.Saldo)
                {
                    valorAuxiliar = valorAuxiliar - item.Saldo;
                    item.SaldoAnterior = item.Saldo;
                    item.Saldo = 0;
                }
                else
                {
                    item.SaldoAnterior = item.Saldo;
                    item.Saldo = item.Saldo - valorAuxiliar;
                }
            }
        }

        //EVENTOS

        private void IU_ActualizarNotaDeCredito_Load(object sender, EventArgs e)
        {
            if (ControladorVM==null)
            {
                lbl_importeAPagar.Text = ControladorV.venta.ImporteTotal.ToString("$ 0.00");
                lbl_saldoNC.Text = valor.ToString("$ 0.00");
                lbl_saldoRestanteNC.Text = (valor - ControladorV.venta.ImporteTotal).ToString("$ 0.00");
            }
            else
            {
                lbl_importeAPagar.Text = ControladorVM.venta.ImporteTotal.ToString("$ 0.00");
                lbl_saldoNC.Text = valor.ToString("$ 0.00");
                lbl_saldoRestanteNC.Text = (valor - ControladorVM.venta.ImporteTotal).ToString("$ 0.00");
            }
            _controladorANC.mostrarClientesMayoristas();
            _controladorANC.mostrarClientesMinoristas();
            rbtn_1.Checked = true;
        }

        private void rbtn_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_1.Checked)
            {
                txt_nombreCliente.AutoCompleteCustomSource.Clear();
                foreach (var item in _controladorANC._clientesMinoristas)
                {
                    txt_nombreCliente.AutoCompleteCustomSource.Add(item.NombreCliente);
                }
            }
            else
            {
                txt_nombreCliente.AutoCompleteCustomSource.Clear();
                foreach (var item in _controladorANC._clientesMayoristas)
                {
                    txt_nombreCliente.AutoCompleteCustomSource.Add(item.RazonSocial);
                }
            }
        }

        private void dgv_notasDeCredito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_notasDeCredito.Columns[e.ColumnIndex].Name== "Seleccionar")
            {                
                DataGridViewRow row = dgv_notasDeCredito.Rows[e.RowIndex];
                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSeleccion.EditingCellFormattedValue))
                {
                    if (ControladorVM==null)
                    {
                        if (valor < (ControladorV.venta.ImporteTotal))
                        {
                            valor = valor + float.Parse(row.Cells[2].Value.ToString());
                            lbl_saldoNC.Text = valor.ToString("$ 0.00");
                            lbl_saldoRestanteNC.Text = (valor - ControladorV.venta.ImporteTotal).ToString("$ 0.00");
                            tomarSeleccionNotaDeCredito(int.Parse(row.Cells[1].Value.ToString()));
                        }
                        else
                        {
                            cellSeleccion.EditingCellFormattedValue = false;
                        }
                    }
                    else
                    {
                        if (valor < (ControladorVM.venta.ImporteTotal))
                        {
                            valor = valor + float.Parse(row.Cells[2].Value.ToString());
                            lbl_saldoNC.Text = valor.ToString("$ 0.00");
                            lbl_saldoRestanteNC.Text = (valor - ControladorVM.venta.ImporteTotal).ToString("$ 0.00");
                            tomarSeleccionNotaDeCredito(int.Parse(row.Cells[1].Value.ToString()));
                        }
                        else
                        {
                            cellSeleccion.EditingCellFormattedValue = false;
                        }
                    }                             
                }
                else
                {
                    if (ControladorVM == null)
                    {
                        valor = valor - float.Parse(row.Cells[2].Value.ToString());
                        lbl_saldoNC.Text = valor.ToString("$ 0.00");
                        lbl_saldoRestanteNC.Text = (valor - ControladorV.venta.ImporteTotal).ToString("$ 0.00");
                        tomarDeseleccionNotaDeCredito(int.Parse(row.Cells[1].Value.ToString()));
                    }
                    else
                    {
                        valor = valor - float.Parse(row.Cells[2].Value.ToString());
                        lbl_saldoNC.Text = valor.ToString("$ 0.00");
                        lbl_saldoRestanteNC.Text = (valor - ControladorVM.venta.ImporteTotal).ToString("$ 0.00");
                        tomarDeseleccionNotaDeCredito(int.Parse(row.Cells[1].Value.ToString()));
                    }                    
                }
            }
        }        
    }
}
