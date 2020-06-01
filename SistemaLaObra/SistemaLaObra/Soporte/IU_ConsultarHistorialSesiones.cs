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
    public partial class IU_ConsultarHistorialSesiones : Form
    {

        Usuario usuario;
        Encargado encargado;
        TipoEncargado tipoEncargado;
        ListaTipoEncargado listaTipoEncargado;
        HistorialSesion historialSesion;

        int codigoUsuario;
        List<HistorialSesion> listaHistorialSesion;

        public IU_ConsultarHistorialSesiones()
        {
            InitializeComponent();
            usuario = new Usuario();
            encargado = new Encargado();
            tipoEncargado = new TipoEncargado();
            listaTipoEncargado = new ListaTipoEncargado();
            historialSesion = new HistorialSesion();
        }

        private void btn_buscarHistorial_Click(object sender, EventArgs e)
        {
            if (txt_nombreUsuario.Text != "")
            {
                dgv_historial.Rows.Clear();
                codigoUsuario = usuario.obtenerCodigoUsuario(txt_nombreUsuario.Text);
                if (codigoUsuario != 0)
                {
                    tipoEncargado.mostrarDatos(listaTipoEncargado.obtenerCodigoTipoEncargado(codigoUsuario));
                    encargado.mostrarDatos(encargado.obtenerCodigoEncargado(codigoUsuario));
                    listaHistorialSesion = historialSesion.mostrarDatosColeccion(codigoUsuario);

                    foreach (var item in listaHistorialSesion)
                    {
                        if (item.FechaHoraCierre.ToString("dd/MM/yyyy") != "01/01/0001")
                        {
                            dgv_historial.Rows.Add(item.FechaHoraInicio.ToString("dd/MM/yyyy HH:mm"), item.FechaHoraCierre.ToString("dd/MM/yyyy HH:mm"), encargado.Nombre, encargado.Apellido, tipoEncargado.Descripcion);
                        }
                        else
                        {
                            dgv_historial.Rows.Add(item.FechaHoraInicio.ToString("dd/MM/yyyy HH:mm"), "No cerro sesion" , encargado.Nombre, encargado.Apellido, tipoEncargado.Descripcion);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No existe el usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No ingreso ningun nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
