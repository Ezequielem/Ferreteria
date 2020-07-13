using SistemaLaObra.Compras;
using SistemaLaObra.Logistica;
using SistemaLaObra.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.InicioSesion
{
    class Controlador_InicioSesion
    {
        public IU_InicioSesion interfazInicioSesion { get; set; }
        public Encargado Encargado { get; set; }
        public TipoDeAcceso TipoDeAcceso { get; set; }
        public List<TipoDeAcceso_X_Usuario> ListaTipoDeAcceso_X_Usuario { get; set; }
        public HistorialSesion HistorialSesion { get; set; }

        public Controlador_InicioSesion()
        {
            Encargado = new Encargado();
            TipoDeAcceso = new TipoDeAcceso();
            ListaTipoDeAcceso_X_Usuario = new List<TipoDeAcceso_X_Usuario>();
            HistorialSesion = new HistorialSesion();
        }

        public bool usuarioEmpleado(string nombreUsuario)
        {
            int codigoUsuario = Encargado.Usuario.obtenerCodigoUsuario(nombreUsuario);
            if (codigoUsuario != 0)
            {
                Encargado.Usuario.mostrarDatos(codigoUsuario);
                Encargado.mostrarDatos(Encargado.obtenerCodigoEncargado(Encargado.Usuario.CodigoUsuario));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool contraseñaEmpleado(string contraseña)
        {
            if (Encargado.Usuario.comprobarContraseña(contraseña))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void tomarFechaHora()
        {
            HistorialSesion.FechaHoraInicio = DateTime.Now;
        }

        public void iniciarSesion()
        {
            //Se registra en historial inicio
            HistorialSesion.CodigoUsuario = Encargado.Usuario.CodigoUsuario;
            HistorialSesion.CodigoHistorial = HistorialSesion.ultimoNumeroHistorial() + 1;
            HistorialSesion.crear(HistorialSesion);
            ListaTipoDeAcceso_X_Usuario = Encargado.Usuario.obtenerTipoAcceso(Encargado.Usuario.CodigoUsuario);        
            //Verificamos que interfaz traer
            iniciarInterfazCorrespondiente();
            //Enviamos informacion del usuario y el historial al contenedor principal
            interfazInicioSesion.interfazContenedora.CodigoHistorial = HistorialSesion.CodigoHistorial;
            interfazInicioSesion.interfazContenedora.EncargadoActivo.MiEmpresa.mostrarDatos(interfazInicioSesion.interfazContenedora.EncargadoActivo.CodigoMiEmpresa);
        }

        private void iniciarInterfazCorrespondiente()
        {
            foreach (var item in ListaTipoDeAcceso_X_Usuario)
            {
                if (item.CodigoTipoAcceso == 1)
                {
                    interfazInicioSesion.interfazContenedora.btn_ventas.Enabled = true;
                    interfazInicioSesion.interfazContenedora.lbl_tipoDeAcceso.Text += "VENTA ";
                }
                else if (item.CodigoTipoAcceso == 2)
                {
                    interfazInicioSesion.interfazContenedora.btn_compras.Enabled = true;
                    interfazInicioSesion.interfazContenedora.lbl_tipoDeAcceso.Text += "COMPRA ";
                }
                else if (item.CodigoTipoAcceso == 3)
                {
                    interfazInicioSesion.interfazContenedora.btn_logistica.Enabled = true;
                    interfazInicioSesion.interfazContenedora.lbl_tipoDeAcceso.Text += "LOGISTICA ";
                }
                else if (item.CodigoTipoAcceso == 4)
                {
                    interfazInicioSesion.interfazContenedora.btn_soporte.Enabled = true;
                    interfazInicioSesion.interfazContenedora.lbl_tipoDeAcceso.Text += "SOPORTE ";
                }
                else if (item.CodigoTipoAcceso == 5)
                {
                    interfazInicioSesion.interfazContenedora.btn_estadistica.Enabled = true;
                    interfazInicioSesion.interfazContenedora.lbl_tipoDeAcceso.Text += "ESTADISTICA ";
                }
            }
            interfazInicioSesion.interfazContenedora.pnl_opciones.Visible=true;
            interfazInicioSesion.interfazContenedora.btn_ventas.Visible = true;
            interfazInicioSesion.interfazContenedora.btn_compras.Visible = true;
            interfazInicioSesion.interfazContenedora.btn_logistica.Visible = true;
            interfazInicioSesion.interfazContenedora.btn_estadistica.Visible = true;
            interfazInicioSesion.interfazContenedora.btn_soporte.Visible = true;
            interfazInicioSesion.interfazContenedora.pnl_subMenu.Visible = true;
            interfazInicioSesion.interfazContenedora.pnl_inferior.Visible = true;
            interfazInicioSesion.Close();
            //Depositamos la info despues del inicio para consulta
            interfazInicioSesion.interfazContenedora.EncargadoActivo = Encargado;
            //Luego de traer la interfaz correspondiente
            interfazInicioSesion.interfazContenedora.ms_btnInicioSesion.Visible = false;
            interfazInicioSesion.interfazContenedora.ms_btnCerrarSesion.Visible = true;
            interfazInicioSesion.interfazContenedora.lbl_usuario.Text = 
                interfazInicioSesion.interfazContenedora.EncargadoActivo.Usuario.NombreUsuario;
            interfazInicioSesion.interfazContenedora.lbl_nombreApellidoEncargado.Text = 
                interfazInicioSesion.interfazContenedora.EncargadoActivo.Nombre + " " + 
                interfazInicioSesion.interfazContenedora.EncargadoActivo.Apellido;
            interfazInicioSesion.interfazContenedora.lbl_usuario.Visible = true;
            interfazInicioSesion.interfazContenedora.lbl_nombreApellidoEncargado.Visible = true;
            interfazInicioSesion.interfazContenedora.lbl_tipoDeAcceso.Visible = true;            
        }

    }
}
