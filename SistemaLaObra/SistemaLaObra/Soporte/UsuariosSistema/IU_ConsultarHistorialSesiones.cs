using SistemaLaObra.InicioSesion;
using SistemaLaObra.Modelo;
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
        public Encargado Encargado { get; set; }
        public TipoDeAcceso TipoDeAcceso { get; set; }
        public TipoDeAcceso_X_Usuario TipoDeAcceso_X_Usuario { get; set; }
        public HistorialSesion HistorialSesion { get; set; }

        public IU_ConsultarHistorialSesiones()
        {
            InitializeComponent();            
            Encargado = new Encargado();            
            TipoDeAcceso = new TipoDeAcceso();
            TipoDeAcceso_X_Usuario = new TipoDeAcceso_X_Usuario();
            HistorialSesion = new HistorialSesion();
        }

        private void btn_buscarHistorial_Click(object sender, EventArgs e)
        {
            if (txt_nombreUsuario.Text != string.Empty)
            {
                dgv_historial.Rows.Clear();
                Encargado.Usuario.mostrarDatos(txt_nombreUsuario.Text);                
                if (Encargado.Usuario.CodigoUsuario != 0)
                {
                    string acceso=string.Empty;
                    foreach (var item in TipoDeAcceso_X_Usuario.mostrarDatos(Encargado.Usuario))
                    {
                        TipoDeAcceso.mostrarDatos(item.CodigoTipoAcceso);
                        acceso += TipoDeAcceso.Descripcion + " ";
                    }
                    Encargado.mostrarDatos(Encargado.obtenerCodigoEncargado(Encargado.Usuario.CodigoUsuario));
                    List<HistorialSesion> lista = HistorialSesion.mostrarDatos(Encargado.Usuario.CodigoUsuario);
                    foreach (var item in lista)
                    {

                        if (item.FechaHoraCierre.ToString("dd/MM/yyyy") != "01/01/0001")
                        {
                            dgv_historial.Rows.Add(
                                item.FechaHoraInicio.ToString("dd/MM/yyyy HH:mm"), 
                                item.FechaHoraCierre.ToString("dd/MM/yyyy HH:mm"), 
                                Encargado.Nombre, Encargado.Apellido, 
                                acceso
                                );
                        }
                        else
                        {
                            dgv_historial.Rows.Add(
                                item.FechaHoraInicio.ToString("dd/MM/yyyy HH:mm"), 
                                "No cerro sesion" , 
                                Encargado.Nombre, 
                                Encargado.Apellido, 
                                acceso
                                );
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
