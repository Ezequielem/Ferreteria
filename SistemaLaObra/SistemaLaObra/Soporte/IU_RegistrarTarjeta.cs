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

namespace SistemaLaObra.Soporte
{
    public partial class IU_RegistrarTarjeta : Form
    {
        Banco banco;
        NombreTarjeta nombreTarjeta;
        ListaTarjetas listaTarjetas;
        List<Banco> listaBancos;
        List<NombreTarjeta> listaNombreTarjeta;
        string bancoTarjeta;
        string tipoTarjeta;
        string seleccionTipoTarjta;
        string nombreTarjetaTxb;

        public IU_RegistrarTarjeta()
        {
            InitializeComponent();
            banco = new Banco();
            nombreTarjeta = new NombreTarjeta();
            listaTarjetas = new ListaTarjetas();
        }

        private void IU_RegistrarTarjeta_Load(object sender, EventArgs e)
        {
            cargarDatosBanco();
            cargarDatosTipoTarjeta();
            this.chb_tipoTarjeta.Checked = false;
        }

        public void tomarTarjeta()
        {
            bancoTarjeta = txt_NombreTarjeta.Text;
        }
        
        public void tomarTipoTarjeta()
        {
            tipoTarjeta = txt_tipoTarjeta.Text;
        }

        public void tomarSeleccion()
        {
            seleccionTipoTarjta = cb_nombreTarjeta.Text;
        }

       public void cargarDatosBanco()
        {
            listaBancos = banco.mostrarDatosColeccion();
            cb_nombreBanco.DataSource = listaBancos;
            cb_nombreBanco.DisplayMember = "Descripcion";       
        }

        public void tomarTxbNombreTarjeta()
        {
            nombreTarjetaTxb = txt_tipoTarjeta.Text;
        }

        public void cargarDatosTipoTarjeta()
        {
            
            listaNombreTarjeta = nombreTarjeta.mostrarDatosColeccion();
            cb_nombreTarjeta.DataSource = listaNombreTarjeta;
            cb_nombreTarjeta.DisplayMember = "Descripcion";
            
        }


        public void registrarTarjeta(string descripcion)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chb_tipoTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_tipoTarjeta.Checked == true)
            {
                txt_tipoTarjeta.Enabled = true;
                cb_nombreTarjeta.DataSource = null;
                cb_nombreTarjeta.Enabled = false;
                txt_NombreTarjeta.Enabled = false;

            }
            else
            {
                txt_tipoTarjeta.Enabled = false;
                cargarDatosTipoTarjeta();
                cb_nombreTarjeta.Enabled = true;
                txt_NombreTarjeta.Enabled = true;
            }        

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (chb_tipoTarjeta.Checked == true)
            {
                tomarTxbNombreTarjeta();
                int codigoTarjeta = nombreTarjeta.mostrarUltimoNombreTarjetas() + 1;
                nombreTarjeta.crear(codigoTarjeta, nombreTarjetaTxb);
                chb_tipoTarjeta.Checked = false;
                txt_tipoTarjeta.Text = "";
            }
            else
            {
                tomarTarjeta();
                tomarSeleccion();
                int existeBanco = banco.existeBanco(bancoTarjeta);
                if (existeBanco == -1)
                {
                    int cod = banco.mostrarUltimoCodigoBanco() + 1;
                    banco.crear(cod, bancoTarjeta);
                    int codigo = listaTarjetas.mostrarUltimoListaTarjetas() + 1;
                    int codigoTarjeta = nombreTarjeta.mostrarCodigo(seleccionTipoTarjta);
                    int codigoTipoTarj = 2;
                    listaTarjetas.crear(codigo, codigoTipoTarj, cod, codigoTarjeta);
                    MessageBox.Show("La tarjeta se registro exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int codigo = listaTarjetas.mostrarUltimoListaTarjetas() + 1;
                    int codigoTarjeta = nombreTarjeta.mostrarCodigo(seleccionTipoTarjta);
                    int codigoTipoTarj = -1;
                    int codigoBanco = banco.mostrarCodigo(bancoTarjeta);
                    listaTarjetas.crear(codigo, codigoTipoTarj, codigoBanco, codigoTarjeta);
                }
            }
        }
    }
}
