using SistemaLaObra.InicioSesion;
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
    public partial class IU_ConsultarUsuario : Form
    {
        Usuario usuario;
        ListaTipoEncargado listaTipoEncargado;
        Encargado encargado;
        TipoEncargado tipoEncargado;
        IU_DatosUsuario interfazDatosUsuario;

        public IU_ConsultarUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();
            listaTipoEncargado = new ListaTipoEncargado();
            encargado = new Encargado();
            tipoEncargado = new TipoEncargado();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_busquedaGeneral_CheckedChanged(object sender, EventArgs e)
        {
            txt_nombreUsuario.Text = "";
            txt_nombreUsuario.Enabled = false;
            btn_buscarDatos.Enabled = false;

            List<Usuario> listaUsuario = usuario.mostrarDatosColeccion();
            foreach (var item in listaUsuario)
            {
                encargado.mostrarDatos(encargado.obtenerCodigoEncargado(item.CodigoUsuario));
                tipoEncargado.mostrarDatos(listaTipoEncargado.obtenerCodigoTipoEncargado(item.CodigoUsuario));

                dgv_usuarios.Rows.Add(item.NombreUsuario,encargado.Nombre,encargado.Apellido,tipoEncargado.Descripcion);
            }
        }

        private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                usuario.mostrarDatos(usuario.obtenerCodigoUsuario(dgv_usuarios.Rows[e.RowIndex].Cells[0].Value.ToString()));
                encargado.mostrarDatos(encargado.obtenerCodigoEncargado(usuario.CodigoUsuario));
                tipoEncargado.mostrarDatos(listaTipoEncargado.obtenerCodigoTipoEncargado(usuario.CodigoUsuario));

                interfazDatosUsuario = new IU_DatosUsuario();

                interfazDatosUsuario.lbl_nombreUsuario.Text = usuario.NombreUsuario;
                interfazDatosUsuario.lbl_tipoEncargado.Text = tipoEncargado.Descripcion;
                interfazDatosUsuario.lbl_legajo.Text = encargado.Legajo.ToString();
                interfazDatosUsuario.lbl_nombreEncargado.Text = encargado.Nombre;
                interfazDatosUsuario.lbl_apellidoEncargado.Text = encargado.Apellido;
                TipoDocumento tipoDocumento = new TipoDocumento();
                tipoDocumento.mostrarDatos(encargado.CodigoTipoDocumento);
                interfazDatosUsuario.lbl_tipoDocumento.Text = tipoDocumento.Descripcion;
                interfazDatosUsuario.lbl_nroDocumento.Text = encargado.NroDocumento;
                interfazDatosUsuario.lbl_fechaNacimiento.Text = encargado.FechaNacimiento.ToString("dd/MM/yyyy");
                TipoTelefono tipoTelefono = new TipoTelefono();
                tipoTelefono.mostrarDatos(encargado.CodigoTipoTelefono);
                interfazDatosUsuario.lbl_tipoTelefono.Text = tipoTelefono.Descripcion;
                interfazDatosUsuario.lbl_nroTelefono.Text = encargado.NroTelefono;
                interfazDatosUsuario.lbl_calle.Text = encargado.Calle;
                interfazDatosUsuario.lbl_numero.Text = encargado.Numero.ToString();
                interfazDatosUsuario.lbl_depto.Text = encargado.Depto;
                interfazDatosUsuario.lbl_piso.Text = encargado.Piso;
                interfazDatosUsuario.lbl_barrio.Text = encargado.NombreBarrio;
                interfazDatosUsuario.lbl_codigoPostal.Text = encargado.CodigoPostal.ToString();
                Provincia provincia = new Provincia();
                provincia.mostrarDatos(encargado.CodigoProvincia);
                interfazDatosUsuario.lbl_provincia.Text = provincia.NombreProvincia;
                Departamento departamento = new Departamento();
                interfazDatosUsuario.lbl_departamento.Text = departamento.mostrarNombre(encargado.CodigoDepartamento);
                Localidad localidad = new Localidad();
                interfazDatosUsuario.lbl_localidad.Text = localidad.mostrarNombre(encargado.CodigoLocalidad);

                interfazDatosUsuario.ShowDialog();
            }
        }

        private void rb_busquedaEspecifica_CheckedChanged(object sender, EventArgs e)
        {
            dgv_usuarios.Rows.Clear();
            txt_nombreUsuario.Enabled = true;
            btn_buscarDatos.Enabled = true;
        }

        private void btn_buscarDatos_Click(object sender, EventArgs e)
        {
            if (txt_nombreUsuario.Text != "")
            {
                usuario.mostrarDatos(usuario.obtenerCodigoUsuario(txt_nombreUsuario.Text));
                encargado.mostrarDatos(encargado.obtenerCodigoEncargado(usuario.CodigoUsuario));
                tipoEncargado.mostrarDatos(listaTipoEncargado.obtenerCodigoTipoEncargado(usuario.CodigoUsuario));

                interfazDatosUsuario = new IU_DatosUsuario();

                interfazDatosUsuario.lbl_nombreUsuario.Text = usuario.NombreUsuario;
                interfazDatosUsuario.lbl_tipoEncargado.Text = tipoEncargado.Descripcion;
                interfazDatosUsuario.lbl_legajo.Text = encargado.Legajo.ToString();
                interfazDatosUsuario.lbl_nombreEncargado.Text = encargado.Nombre;
                interfazDatosUsuario.lbl_apellidoEncargado.Text = encargado.Apellido;
                TipoDocumento tipoDocumento = new TipoDocumento();
                tipoDocumento.mostrarDatos(encargado.CodigoTipoDocumento);
                interfazDatosUsuario.lbl_tipoDocumento.Text = tipoDocumento.Descripcion;
                interfazDatosUsuario.lbl_nroDocumento.Text = encargado.NroDocumento;
                interfazDatosUsuario.lbl_fechaNacimiento.Text = encargado.FechaNacimiento.ToString("dd/MM/yyyy");
                TipoTelefono tipoTelefono = new TipoTelefono();
                tipoTelefono.mostrarDatos(encargado.CodigoTipoTelefono);
                interfazDatosUsuario.lbl_tipoTelefono.Text = tipoTelefono.Descripcion;
                interfazDatosUsuario.lbl_nroTelefono.Text = encargado.NroTelefono;
                interfazDatosUsuario.lbl_calle.Text = encargado.Calle;
                interfazDatosUsuario.lbl_numero.Text = encargado.Numero.ToString();
                interfazDatosUsuario.lbl_depto.Text = encargado.Depto;
                interfazDatosUsuario.lbl_piso.Text = encargado.Piso;
                interfazDatosUsuario.lbl_barrio.Text = encargado.NombreBarrio;
                interfazDatosUsuario.lbl_codigoPostal.Text = encargado.CodigoPostal.ToString();
                Provincia provincia = new Provincia();
                provincia.mostrarDatos(encargado.CodigoProvincia);
                interfazDatosUsuario.lbl_provincia.Text = provincia.NombreProvincia;
                Departamento departamento = new Departamento();
                interfazDatosUsuario.lbl_departamento.Text = departamento.mostrarNombre(encargado.CodigoDepartamento);
                Localidad localidad = new Localidad();
                interfazDatosUsuario.lbl_localidad.Text = localidad.mostrarNombre(encargado.CodigoLocalidad);

                interfazDatosUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No ingreso ninugun nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
