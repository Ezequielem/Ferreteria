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
        public Usuario Usuario { get; set; }
        public Encargado Encargado { get; set; }
        public TipoDeAcceso TipoDeAcceso { get; set; }
        public HistorialSesion HistorialSesion { get; set; }

        public Controlador_InicioSesion()
        {
            Usuario = new Usuario();
            Encargado = new Encargado();
            TipoDeAcceso = new TipoDeAcceso();
            HistorialSesion = new HistorialSesion();
        }

        public bool usuarioEmpleado(string nombreUsuario)
        {
            int codigoUsuario = Usuario.obtenerCodigoUsuario(nombreUsuario);
            if (codigoUsuario != 0)
            {
                Usuario.mostrarDatos(codigoUsuario);
                Encargado.mostrarDatos(Encargado.obtenerCodigoEncargado(Usuario.CodigoUsuario));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool contraseñaEmpleado(string contraseña)
        {
            if (Usuario.comprobarContraseña(contraseña))
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
            HistorialSesion.CodigoUsuario = Usuario.CodigoUsuario;
            HistorialSesion.CodigoHistorial = HistorialSesion.ultimoNumeroHistorial() + 1;
            HistorialSesion.crear(HistorialSesion);

            //Obtenemos el tipo de encargado
            TipoDeAcceso.mostrarDatos(Usuario.obtenerCodigoTipoDeEncargado(Usuario.CodigoUsuario));

            //Verificamos que interfaz traer
            iniciarInterfazCorrespondiente();

            //Enviamos informacion del usuario y el historial al contenedor principal
            interfazInicioSesion.interfazContenedora.CodigoHistorial = HistorialSesion.CodigoHistorial;
        }

        private void iniciarInterfazCorrespondiente()
        {
            if (TipoDeAcceso.Descripcion == "VENTA")
            {
                interfazInicioSesion.interfazContenedora.pnl_opciones.Visible = true;
                interfazInicioSesion.interfazContenedora.btn_ventas.Visible = true;
                interfazInicioSesion.interfazContenedora.btn_ventas.Enabled = true;
                interfazInicioSesion.interfazContenedora.btn_ventas.PerformClick();
                interfazInicioSesion.interfazContenedora.btn_compras.Visible = true;
                interfazInicioSesion.interfazContenedora.btn_logistica.Visible = true;
                interfazInicioSesion.interfazContenedora.btn_estadistica.Visible = true;
                interfazInicioSesion.interfazContenedora.btn_soporte.Visible = true;
                interfazInicioSesion.interfazContenedora.pnl_subMenu.Visible = true;

                interfazInicioSesion.Close();
            }
            else
            {
                if (TipoDeAcceso.Descripcion == "COMPRA")
                {
                    interfazInicioSesion.interfazContenedora.pnl_opciones.Visible = true;
                    interfazInicioSesion.interfazContenedora.btn_ventas.Visible = true;
                    interfazInicioSesion.interfazContenedora.btn_compras.Visible = true;
                    interfazInicioSesion.interfazContenedora.btn_compras.Enabled = true;
                    interfazInicioSesion.interfazContenedora.btn_compras.PerformClick();
                    interfazInicioSesion.interfazContenedora.btn_logistica.Visible = true;
                    interfazInicioSesion.interfazContenedora.btn_estadistica.Visible = true;
                    interfazInicioSesion.interfazContenedora.btn_soporte.Visible = true;
                    interfazInicioSesion.interfazContenedora.pnl_subMenu.Visible = true;

                    interfazInicioSesion.Close();
                }
                else
                {
                    if (TipoDeAcceso.Descripcion == "LOGISTICA")
                    {
                        interfazInicioSesion.interfazContenedora.pnl_opciones.Visible = true;
                        interfazInicioSesion.interfazContenedora.btn_ventas.Visible = true;
                        interfazInicioSesion.interfazContenedora.btn_compras.Visible = true;
                        interfazInicioSesion.interfazContenedora.btn_logistica.Visible = true;
                        interfazInicioSesion.interfazContenedora.btn_logistica.Enabled = true;
                        interfazInicioSesion.interfazContenedora.btn_logistica.PerformClick();
                        interfazInicioSesion.interfazContenedora.btn_estadistica.Visible = true;
                        interfazInicioSesion.interfazContenedora.btn_soporte.Visible = true;
                        interfazInicioSesion.interfazContenedora.pnl_subMenu.Visible = true;

                        interfazInicioSesion.Close();
                    }
                    else
                    {
                        if (TipoDeAcceso.Descripcion == "SOPORTE")
                        {
                            interfazInicioSesion.interfazContenedora.pnl_opciones.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_ventas.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_compras.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_logistica.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_estadistica.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_soporte.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_soporte.Enabled = true;
                            interfazInicioSesion.interfazContenedora.btn_soporte.PerformClick();
                            interfazInicioSesion.interfazContenedora.pnl_subMenu.Visible = true;

                            interfazInicioSesion.Close();
                        }
                        else
                        {
                            interfazInicioSesion.interfazContenedora.pnl_opciones.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_ventas.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_ventas.Enabled = true;
                            interfazInicioSesion.interfazContenedora.btn_compras.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_compras.Enabled = true;
                            interfazInicioSesion.interfazContenedora.btn_logistica.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_logistica.Enabled = true;
                            interfazInicioSesion.interfazContenedora.btn_estadistica.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_estadistica.Enabled = true;
                            interfazInicioSesion.interfazContenedora.btn_soporte.Visible = true;
                            interfazInicioSesion.interfazContenedora.btn_soporte.Enabled = true;
                            interfazInicioSesion.interfazContenedora.pnl_subMenu.Visible = true;

                            interfazInicioSesion.Close();
                        }
                    }
                }
            }

            //Depositamos la info despues del inicio para consulta
            interfazInicioSesion.interfazContenedora.UsuarioActivo = Usuario;
            interfazInicioSesion.interfazContenedora.EncargadoActivo = Encargado;

            //Luego de traer la interfaz correspondiente
            interfazInicioSesion.interfazContenedora.ms_btnInicioSesion.Visible = false;
            interfazInicioSesion.interfazContenedora.ms_btnCerrarSesion.Visible = true;
            interfazInicioSesion.interfazContenedora.lbl_usuario.Text = interfazInicioSesion.interfazContenedora.UsuarioActivo.NombreUsuario;
            interfazInicioSesion.interfazContenedora.lbl_nombreApellidoEncargado.Text = interfazInicioSesion.interfazContenedora.EncargadoActivo.Nombre + " " + interfazInicioSesion.interfazContenedora.EncargadoActivo.Apellido;
            interfazInicioSesion.interfazContenedora.lbl_tipoEncargado.Text = TipoDeAcceso.Descripcion;
            interfazInicioSesion.interfazContenedora.lbl_usuario.Visible = true;
            interfazInicioSesion.interfazContenedora.lbl_nombreApellidoEncargado.Visible = true;
            interfazInicioSesion.interfazContenedora.lbl_tipoEncargado.Visible = true;            
        }

    }
}
