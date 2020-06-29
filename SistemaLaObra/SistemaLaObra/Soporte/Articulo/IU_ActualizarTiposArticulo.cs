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
    public partial class IU_ActualizarTiposArticulo : Form
    {
        //INSTANCIAS
        private TipoArticulo _tipoArticulo;
        private Sub1TipoArticulo _sub1TipoArticulo;
        private Sub2TipoArticulo _sub2TipoArticulo;
        private Sub3TipoArticulo _sub3TipoArticulo;

        public TipoArticulo TipoArticulo
        {
            get
            {
                return _tipoArticulo;
            }

            set
            {
                _tipoArticulo = value;
            }
        }

        public Sub1TipoArticulo Sub1TipoArticulo
        {
            get
            {
                return _sub1TipoArticulo;
            }

            set
            {
                _sub1TipoArticulo = value;
            }
        }

        public Sub2TipoArticulo Sub2TipoArticulo
        {
            get
            {
                return _sub2TipoArticulo;
            }

            set
            {
                _sub2TipoArticulo = value;
            }
        }

        public Sub3TipoArticulo Sub3TipoArticulo
        {
            get
            {
                return _sub3TipoArticulo;
            }

            set
            {
                _sub3TipoArticulo = value;
            }
        }

        public IU_ActualizarTiposArticulo()
        {
            TipoArticulo = new TipoArticulo();
            Sub1TipoArticulo = new Sub1TipoArticulo();
            Sub2TipoArticulo = new Sub2TipoArticulo();
            Sub3TipoArticulo = new Sub3TipoArticulo();
            InitializeComponent();
        }

        //BOTONES

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (rbtn_nombreTipo.Checked&&txt_nombreTipo.Text=="")
            {
                MessageBox.Show(this, "Debe ingresar el nombre de la categoría", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rbtn_nombreSubTipo1.Checked&&txt_nombreSubTipo1.Text=="")
            {
                MessageBox.Show(this, "Debe ingresar el nombre de la subcategoría", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rbtn_nombreSubTipo2.Checked&&txt_nombreSubTipo2.Text=="")
            {
                MessageBox.Show(this, "Debe ingresar el nombre de la subcategoría", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rbtn_nombreSubTipo3.Checked&&txt_nombreSubTipo3.Text=="")
            {
                MessageBox.Show(this, "Debe ingresar el nombre de la subcategoría", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rbtn_nombreTipo.Checked)
                {
                    tomarDatosTipoArticulo();
                    TipoArticulo.actualizar(TipoArticulo);
                }
                if (rbtn_nombreSubTipo1.Checked)
                {
                    tomarDatosSub1TipoArticulo();
                    Sub1TipoArticulo.actualizar(Sub1TipoArticulo);
                }
                if (rbtn_nombreSubTipo2.Checked)
                {
                    tomarDatosSub2TipoArticulo();
                    Sub2TipoArticulo.actualizar(Sub2TipoArticulo);
                }
                if (rbtn_nombreSubTipo3.Checked)
                {
                    tomarDatosSub3TipoArticulo();
                    Sub3TipoArticulo.actualizar(Sub3TipoArticulo);
                }
                if (rbtn_elegirtipo.Checked && rbtn_elegirSubTipo1.Checked && rbtn_elegirSubTipo2.Checked && rbtn_elegirSubTipo3.Checked)
                {
                    MessageBox.Show(this, "No ha modificado ninguna categoría o subcategoría", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(this, "Se ha modificado correctamente el tipo de artículo", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    reestablecerFormulario();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_subNivel1_Click(object sender, EventArgs e)
        {
            gbx_tipoArticulo.Enabled = false;
            gbx_sub1.Enabled = true;
        }

        private void btn_nivel_Click(object sender, EventArgs e)
        {
            gbx_sub1.Enabled = false;
            gbx_tipoArticulo.Enabled = true;
        }

        private void btn_subNivel2_Click(object sender, EventArgs e)
        {
            gbx_sub1.Enabled = false;
            gbx_sub2.Enabled = true;
        }

        private void btn_nivel1_Click(object sender, EventArgs e)
        {
            gbx_sub2.Enabled = false;
            gbx_sub1.Enabled = true;
        }

        private void bnt_subNivel3_Click(object sender, EventArgs e)
        {
            gbx_sub2.Enabled = false;
            gbx_sub3.Enabled = true;
        }

        private void btn_nivel2_Click(object sender, EventArgs e)
        {
            gbx_sub3.Enabled = false;
            gbx_sub2.Enabled = true;
        }

        //METODOS

        private void cargarComboTipoArticulo()
        {
            cbx_seleccionarTipo.DisplayMember = "Descripcion";
            cbx_seleccionarTipo.ValueMember = "CodigoTipoArticulo";
            cbx_seleccionarTipo.DataSource = TipoArticulo.mostrarDatos();
        }

        private void cargarComboSub1TipoArticulo()
        {
            cbx_seleccionaSubTipo1.DisplayMember = "Descripcion";
            cbx_seleccionaSubTipo1.ValueMember = "CodigoSub1TipoArticulo";
            if (cbx_seleccionarTipo.Items.Count == 0)
            {
                cbx_seleccionaSubTipo1.DataSource = TipoArticulo.mostrarSubCategoria(0);
            }
            else
            {
                cbx_seleccionaSubTipo1.DataSource = TipoArticulo.mostrarSubCategoria(int.Parse(cbx_seleccionarTipo.SelectedValue.ToString()));
            }
        }

        private void cargarComboSub2TipoArticulo()
        {
            cbx_seleccionaSubTipo2.DisplayMember = "Descripcion";
            cbx_seleccionaSubTipo2.ValueMember = "CodigoSub2TipoArticulo";
            if (cbx_seleccionaSubTipo1.Items.Count == 0)
            {
                cbx_seleccionaSubTipo2.DataSource = Sub1TipoArticulo.mostrarSubCategorias(0);
            }
            else
            {
                cbx_seleccionaSubTipo2.DataSource = Sub1TipoArticulo.mostrarSubCategorias(int.Parse(cbx_seleccionaSubTipo1.SelectedValue.ToString()));
            }
        }

        private void cargarComboSub3TipoArticulo()
        {
            cbx_seleccionaSubTipo3.DisplayMember = "Descripcion";
            cbx_seleccionaSubTipo3.ValueMember = "CodigoSub3TipoArticulo";
            if (cbx_seleccionaSubTipo2.Items.Count == 0)
            {
                cbx_seleccionaSubTipo3.DataSource = Sub2TipoArticulo.mostrarSubCategorias(0);
            }
            else
            {
                cbx_seleccionaSubTipo3.DataSource = Sub2TipoArticulo.mostrarSubCategorias(int.Parse(cbx_seleccionaSubTipo2.SelectedValue.ToString()));
            }
        }

        private void reestablecerFormulario()
        {
            gbx_tipoArticulo.Enabled = true;
            gbx_sub1.Enabled = false;
            gbx_sub2.Enabled = false;
            gbx_sub3.Enabled = false;
            rbtn_elegirtipo.Checked = true;
            rbtn_elegirSubTipo1.Checked = true;
            rbtn_elegirSubTipo2.Checked = true;
            rbtn_elegirSubTipo3.Checked = true;
            txt_nombreTipo.Text = "";
            txt_nombreSubTipo1.Text = "";
            txt_nombreSubTipo2.Text = "";
            txt_nombreSubTipo3.Text = "";
            cargarComboTipoArticulo();
        }

        public void tomarDatosTipoArticulo()
        {
            TipoArticulo.CodigoTipoArticulo = int.Parse(cbx_seleccionarTipo.SelectedValue.ToString());
            TipoArticulo.Descripcion = txt_nombreTipo.Text;
        }

        public void tomarDatosSub1TipoArticulo()
        {
            Sub1TipoArticulo.CodigoSub1TipoArticulo = int.Parse(cbx_seleccionaSubTipo1.SelectedValue.ToString());
            Sub1TipoArticulo.Descripcion = txt_nombreSubTipo1.Text;
        }

        public void tomarDatosSub2TipoArticulo()
        {
            Sub2TipoArticulo.CodigoSub2TipoArticulo = int.Parse(cbx_seleccionaSubTipo2.SelectedValue.ToString());
            Sub2TipoArticulo.Descripcion = txt_nombreSubTipo2.Text;
        }

        public void tomarDatosSub3TipoArticulo()
        {
            Sub3TipoArticulo.CodigoSub3TipoArticulo = int.Parse(cbx_seleccionaSubTipo3.SelectedValue.ToString());
            Sub3TipoArticulo.Descripcion = txt_nombreSubTipo3.Text;
        }

        //EVENTOS

        private void IU_ActualizarTiposArticulo_Load(object sender, EventArgs e)
        {
            gbx_sub1.Enabled = false;
            gbx_sub2.Enabled = false;
            gbx_sub3.Enabled = false;
            cargarComboTipoArticulo();
        }

        private void rbtn_elegirtipo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_elegirtipo.Checked)
            {
                cbx_seleccionarTipo.Enabled = true;
                txt_nombreTipo.Enabled = false;
                txt_nombreTipo.Text = "";
            }
            else
            {
                if (cbx_seleccionarTipo.Text=="")
                {
                    MessageBox.Show(this, "No hay ninguna categoría que editar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rbtn_elegirtipo.Checked = true;
                }
                else
                {
                    cbx_seleccionarTipo.Enabled = false;
                    txt_nombreTipo.Enabled = true;
                    txt_nombreTipo.Text = cbx_seleccionarTipo.Text;
                }                
            }
        }

        private void rbtn_elegirSubTipo1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_elegirSubTipo1.Checked)
            {
                cbx_seleccionaSubTipo1.Enabled = true;
                txt_nombreSubTipo1.Enabled = false;
                txt_nombreSubTipo1.Text = "";
            }
            else
            {
                if (cbx_seleccionaSubTipo1.Text=="")
                {
                    MessageBox.Show(this, "No hay ninguna subcategoría que editar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rbtn_elegirSubTipo1.Checked = true;
                }
                else
                {
                    cbx_seleccionaSubTipo1.Enabled = false;
                    txt_nombreSubTipo1.Enabled = true;
                    txt_nombreSubTipo1.Text = cbx_seleccionaSubTipo1.Text;
                }                
            }
        }

        private void rbtn_elegirSubTipo2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_elegirSubTipo2.Checked)
            {
                cbx_seleccionaSubTipo2.Enabled = true;
                txt_nombreSubTipo2.Enabled = false;
                txt_nombreSubTipo2.Text = "";
            }
            else
            {
                if (cbx_seleccionaSubTipo2.Text=="")
                {
                    MessageBox.Show(this, "No hay ninguna subcategoría que editar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rbtn_elegirSubTipo2.Checked = true;
                }
                else
                {
                    cbx_seleccionaSubTipo2.Enabled = false;
                    txt_nombreSubTipo2.Enabled = true;
                    txt_nombreSubTipo2.Text = cbx_seleccionaSubTipo2.Text;
                }                
            }
        }

        private void rbtn_elegirSubTipo3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_elegirSubTipo3.Checked)
            {
                cbx_seleccionaSubTipo3.Enabled = true;
                txt_nombreSubTipo3.Enabled = false;
                txt_nombreSubTipo3.Text = "";
            }
            else
            {
                if (cbx_seleccionaSubTipo3.Text=="")
                {
                    MessageBox.Show(this, "No hay ninguna subcategoría que editar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rbtn_elegirSubTipo3.Checked = true;
                }
                else
                {
                    cbx_seleccionaSubTipo3.Enabled = false;
                    txt_nombreSubTipo3.Enabled = true;
                    txt_nombreSubTipo3.Text = cbx_seleccionaSubTipo3.Text;
                }                
            }
        }

        private void cbx_seleccionarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboSub1TipoArticulo();
            cargarComboSub2TipoArticulo();
            cargarComboSub3TipoArticulo();
        }

        private void cbx_seleccionaSubTipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboSub2TipoArticulo();
            cargarComboSub3TipoArticulo();
        }

        private void cbx_seleccionaSubTipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboSub3TipoArticulo();
        }
    }
}
