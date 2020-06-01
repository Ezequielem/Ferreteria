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
    public partial class IU_RegistrarTiposArticulo : Form
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

        public IU_RegistrarTiposArticulo()
        {
            TipoArticulo = new TipoArticulo();
            Sub1TipoArticulo = new Sub1TipoArticulo();
            Sub2TipoArticulo = new Sub2TipoArticulo();
            Sub3TipoArticulo = new Sub3TipoArticulo();
            InitializeComponent();
        }

        //BOTONES

        private void btn_registrar_Click(object sender, EventArgs e)
        {                                    
            if (rbtn_nombreSubTipo3.Checked&&txt_nombreSubTipo3.Text!="")
            {
                if (rbtn_elegirSubTipo2.Checked)
                {
                    tomarDatosSub3TipoArticulo();
                    Sub3TipoArticulo.crear(Sub3TipoArticulo);                    
                    MessageBox.Show(this, "Se ha registrado correctamente la subcategoría", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    reestablecerFormulario();
                }
                else if (rbtn_elegirSubTipo1.Checked)
                {
                    if (txt_nombreSubTipo2.Text!="")
                    {
                        tomarDatosSub2TipoArticulo();
                        Sub2TipoArticulo.crear(Sub2TipoArticulo);
                        tomarDatosSub3TipoArticulo();
                        Sub3TipoArticulo.crear(Sub3TipoArticulo);
                        MessageBox.Show(this, "Se ha registrado correctamente la subcategoría", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        reestablecerFormulario();
                    }
                    else
                    {
                        MessageBox.Show(this, "No ingresó alguna de las categorías anteriores", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rbtn_elegirtipo.Checked)
                {
                    if (txt_nombreSubTipo2.Text != "" && txt_nombreSubTipo1.Text != "")
                    {
                        tomarDatosSub1TipoArticulo();
                        Sub1TipoArticulo.crear(Sub1TipoArticulo);
                        tomarDatosSub2TipoArticulo();
                        Sub2TipoArticulo.crear(Sub2TipoArticulo);
                        tomarDatosSub3TipoArticulo();
                        Sub3TipoArticulo.crear(Sub3TipoArticulo);
                        MessageBox.Show(this, "Se ha registrado correctamente la subcategoría", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        reestablecerFormulario();
                    }
                    else
                    {
                        MessageBox.Show(this, "No ingresó alguna de las categorías anteriores", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (txt_nombreSubTipo2.Text != "" && txt_nombreSubTipo1.Text != "" && txt_nombreTipo.Text != "")
                    {                                                                        
                        tomarDatosTipoArticulo();
                        TipoArticulo.crear(TipoArticulo);
                        tomarDatosSub1TipoArticulo();
                        Sub1TipoArticulo.crear(Sub1TipoArticulo);
                        tomarDatosSub2TipoArticulo();
                        Sub2TipoArticulo.crear(Sub2TipoArticulo);
                        tomarDatosSub3TipoArticulo();
                        Sub3TipoArticulo.crear(Sub3TipoArticulo);
                        MessageBox.Show(this, "Subcategoria registrada \ncorrectamente", "Mensaje");
                        reestablecerFormulario();
                    }
                    else
                    {
                        MessageBox.Show(this, "No ingresó alguna de las categorías anteriores", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            else if (rbtn_nombreSubTipo2.Checked&&txt_nombreSubTipo2.Text!="")
            {
                if (rbtn_elegirSubTipo1.Checked)
                {
                    tomarDatosSub2TipoArticulo();
                    Sub2TipoArticulo.crear(Sub2TipoArticulo);
                    MessageBox.Show(this, "Se ha registrado correctamente la subcategoría", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    reestablecerFormulario();
                }
                else if (rbtn_elegirtipo.Checked)
                {
                    if (txt_nombreSubTipo1.Text!="")
                    {
                        tomarDatosSub1TipoArticulo();
                        Sub1TipoArticulo.crear(Sub1TipoArticulo);
                        tomarDatosSub2TipoArticulo();
                        Sub2TipoArticulo.crear(Sub2TipoArticulo);
                        MessageBox.Show(this, "Se ha registrado correctamente la subcategoría", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        reestablecerFormulario();
                    }
                    else
                    {
                        MessageBox.Show(this, "No ingresó alguna de las categorías anteriores", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                    
                }
                else
                {
                    if (txt_nombreSubTipo1.Text != "" && txt_nombreTipo.Text != "")
                    {                        
                        tomarDatosTipoArticulo();
                        TipoArticulo.crear(TipoArticulo);
                        tomarDatosSub1TipoArticulo();
                        Sub1TipoArticulo.crear(Sub1TipoArticulo);
                        tomarDatosSub2TipoArticulo();
                        Sub2TipoArticulo.crear(Sub2TipoArticulo);
                        MessageBox.Show(this, "Se ha registrado correctamente la subcategoría", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        reestablecerFormulario();
                    }
                    else
                    {
                        MessageBox.Show(this, "No ingresó alguna de las categorías anteriores", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }                
            }
            else if (rbtn_nombreSubTipo1.Checked&&txt_nombreSubTipo1.Text!="")
            {
                if (rbtn_elegirtipo.Checked)
                {
                    tomarDatosSub1TipoArticulo();
                    Sub1TipoArticulo.crear(Sub1TipoArticulo);
                    MessageBox.Show(this, "Se ha registrado correctamente la subcategoría", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    reestablecerFormulario();
                }
                else
                {
                    if (txt_nombreTipo.Text != "")
                    {
                        tomarDatosTipoArticulo();
                        TipoArticulo.crear(TipoArticulo);
                        tomarDatosSub1TipoArticulo();
                        Sub1TipoArticulo.crear(Sub1TipoArticulo);
                        MessageBox.Show(this, "Se ha registrado correctamente la subcategoría", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        reestablecerFormulario();
                    }
                    else
                    {
                        MessageBox.Show(this, "No ingresó la categoría anterior", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (rbtn_nombreTipo.Checked&&txt_nombreTipo.Text!="")
            {
                tomarDatosTipoArticulo();
                TipoArticulo.crear(TipoArticulo);
                MessageBox.Show(this, "Se ha registrado correctamente la categoría", "TIPO DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                reestablecerFormulario();
            }
            else
            {
                MessageBox.Show(this, "Debe ingresar al menos una categoria para poder registrarla", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (rbtn_nombreTipo.Checked)
            {
                rbtn_nombreSubTipo1.Checked = true;
            }
            else
            {
                rbtn_elegirSubTipo1.Checked = true;
            }
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
            if (rbtn_nombreSubTipo1.Checked)
            {
                rbtn_nombreSubTipo2.Checked = true;
            }
            else
            {
                rbtn_elegirSubTipo2.Checked = true;
            }
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
            if (rbtn_nombreSubTipo2.Checked)
            {
                rbtn_nombreSubTipo3.Checked = true;
            }
            else
            {
                rbtn_elegirSubTipo3.Checked = true;
            }
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
            if (cbx_seleccionarTipo.Items.Count==0)
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
            if (cbx_seleccionaSubTipo1.Items.Count==0)
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
            if (cbx_seleccionaSubTipo2.Items.Count==0)
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
            TipoArticulo.Descripcion = txt_nombreTipo.Text;                  
        }

        public void tomarDatosSub1TipoArticulo()
        {
            if (rbtn_nombreTipo.Checked)
            {
                Sub1TipoArticulo.CodigoTipoArticulo = TipoArticulo.mostrarCodigoUltimoRegistro();
                Sub1TipoArticulo.Descripcion = txt_nombreSubTipo1.Text;
            }
            else
            {
                Sub1TipoArticulo.CodigoTipoArticulo = int.Parse(cbx_seleccionarTipo.SelectedValue.ToString());
                Sub1TipoArticulo.Descripcion = txt_nombreSubTipo1.Text;
            }           
        }

        public void tomarDatosSub2TipoArticulo()
        {
            if (rbtn_nombreSubTipo1.Checked)
            {
                Sub2TipoArticulo.CodigoSub1TipoArticulo = Sub1TipoArticulo.mostrarCodigoUltimoRegistro();
                Sub2TipoArticulo.Descripcion = txt_nombreSubTipo2.Text;
            }
            else
            {
                Sub2TipoArticulo.CodigoSub1TipoArticulo = int.Parse(cbx_seleccionaSubTipo1.SelectedValue.ToString());
                Sub2TipoArticulo.Descripcion = txt_nombreSubTipo2.Text;
            }            
        }

        public void tomarDatosSub3TipoArticulo()
        {
            if (rbtn_nombreSubTipo2.Checked)
            {
                Sub3TipoArticulo.CodigoSub2TipoArticulo = Sub2TipoArticulo.mostrarCodigoUltimoRegistro();
                Sub3TipoArticulo.Descripcion = txt_nombreSubTipo3.Text;
            }
            else
            {
                Sub3TipoArticulo.CodigoSub2TipoArticulo = int.Parse(cbx_seleccionaSubTipo2.SelectedValue.ToString());
                Sub3TipoArticulo.Descripcion = txt_nombreSubTipo3.Text;
            }
            
        }

        //EVENTOS

        private void IU_RegistrarTiposArticulo_Load(object sender, EventArgs e)
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
            }
            else
            {
                cbx_seleccionarTipo.Enabled = false;
                txt_nombreTipo.Enabled = true;
            }
        }

        private void rbtn_elegirSubTipo1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_elegirSubTipo1.Checked)
            {
                if (rbtn_nombreTipo.Checked)
                {
                    MessageBox.Show(this, "Si ha creado una categoría debe continuar editando la subcategoría", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rbtn_nombreSubTipo1.Checked = true;
                }
                else
                {
                    cbx_seleccionaSubTipo1.Enabled = true;
                    txt_nombreSubTipo1.Enabled = false;
                }                
            }
            else
            {
                cbx_seleccionaSubTipo1.Enabled = false;
                txt_nombreSubTipo1.Enabled = true;
            }
        }

        private void rbtn_elegirSubTipo2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_elegirSubTipo2.Checked)
            {
                if (rbtn_nombreSubTipo1.Checked)
                {
                    MessageBox.Show(this, "Si ha creado una categoría debe continuar editando la subcategoría", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rbtn_nombreSubTipo2.Checked = true;
                }
                else
                {
                    cbx_seleccionaSubTipo2.Enabled = true;
                    txt_nombreSubTipo2.Enabled = false;
                }                
            }
            else
            {
                cbx_seleccionaSubTipo2.Enabled = false;
                txt_nombreSubTipo2.Enabled = true;
            }
        }

        private void rbtn_elegirSubTipo3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_elegirSubTipo3.Checked)
            {
                if (rbtn_nombreSubTipo2.Checked)
                {
                    MessageBox.Show(this, "Si ha creado una categoría debe continuar editando la subcategoría", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rbtn_nombreSubTipo3.Checked = true;
                }
                else
                {
                    cbx_seleccionaSubTipo3.Enabled = true;
                    txt_nombreSubTipo3.Enabled = false;
                }                
            }
            else
            {
                cbx_seleccionaSubTipo3.Enabled = false;
                txt_nombreSubTipo3.Enabled = true;
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
