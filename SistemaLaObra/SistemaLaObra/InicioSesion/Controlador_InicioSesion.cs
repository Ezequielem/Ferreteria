using SistemaLaObra.Compras;
using SistemaLaObra.Logistica;
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
        Usuario usuario;
        Encargado encargado;
        TipoEncargado tipoEncargado;
        HistorialSesion historialSesion;
        
        public Controlador_InicioSesion()
        {
            usuario = new Usuario();
            encargado = new Encargado();
            tipoEncargado = new TipoEncargado();
            historialSesion = new HistorialSesion();
        }

        public bool usuarioEmpleado(string nombreUsuario)
        {
            int codigoUsuario = usuario.obtenerCodigoUsuario(nombreUsuario);
            if (codigoUsuario != 0)
            {
                usuario.mostrarDatos(codigoUsuario);
                encargado.mostrarDatos(encargado.obtenerCodigoEncargado(usuario.CodigoUsuario));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool contraseñaEmpleado(string contraseña)
        {
            if (usuario.comprobarContraseña(contraseña))
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
            historialSesion.FechaHoraInicio = DateTime.Now;
        }

        public void iniciarSesion()
        {
            //Se registra en historial inicio
            historialSesion.CodigoUsuario = usuario.CodigoUsuario;
            historialSesion.CodigoHistorial = historialSesion.ultimoNumeroHistorial() + 1;
            historialSesion.crear(historialSesion);

            //Obtenemos el tipo de encargado
            tipoEncargado.mostrarDatos(usuario.obtenerCodigoTipoDeEncargado(usuario.CodigoUsuario));

            //Verificamos que interfaz traer
            iniciarInterfazCorrespondiente();

            //Enviamos informacion del usuario y el historial al contenedor principal
            interfazInicioSesion.interfazContenedora.CodigoHistorial = historialSesion.CodigoHistorial;
        }

        private void iniciarInterfazCorrespondiente()
        {
            if (tipoEncargado.Descripcion == "VENTA")
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
                if (tipoEncargado.Descripcion == "COMPRA")
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
                    if (tipoEncargado.Descripcion == "LOGISTICA")
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
                        if (tipoEncargado.Descripcion == "SOPORTE")
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
            interfazInicioSesion.interfazContenedora.UsuarioActivo = usuario;
            interfazInicioSesion.interfazContenedora.EncargadoActivo = encargado;

            //Luego de traer la interfaz correspondiente
            interfazInicioSesion.interfazContenedora.ms_btnInicioSesion.Visible = false;
            interfazInicioSesion.interfazContenedora.ms_btnCerrarSesion.Visible = true;
            interfazInicioSesion.interfazContenedora.lbl_usuario.Text = interfazInicioSesion.interfazContenedora.UsuarioActivo.NombreUsuario;
            interfazInicioSesion.interfazContenedora.lbl_nombreApellidoEncargado.Text = interfazInicioSesion.interfazContenedora.EncargadoActivo.Nombre + " " + interfazInicioSesion.interfazContenedora.EncargadoActivo.Apellido;
            interfazInicioSesion.interfazContenedora.lbl_tipoEncargado.Text = tipoEncargado.Descripcion;
            interfazInicioSesion.interfazContenedora.lbl_usuario.Visible = true;
            interfazInicioSesion.interfazContenedora.lbl_nombreApellidoEncargado.Visible = true;
            interfazInicioSesion.interfazContenedora.lbl_tipoEncargado.Visible = true;            
        }

    }
}
