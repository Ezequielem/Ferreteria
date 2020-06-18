using SistemaLaObra.Soporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace SistemaLaObra
{
    public partial class IU_MenuPrincipalSoporte : Form
    {
        public IU_MenuPrincipal interfazContenedora { get; set; }        
        public IU_RegistrarTarjeta InterfazRegistrarTarjeta { get; set; }
        public IU_ActualizarTarjeta InterfazActualizarTarjeta { get; set; }
        public IU_ActualizarArticulo InterfazActualizarArticulo { get; set; }
        public IU_RegistrarArticulo InterfazRegistrarArticulo { get; set; }
        public IU_ConsultarArticulo InterfazConsultarArticulo { get; set; }
        public IU_RegistrarUbicacion InterfazRegistrarUbicacion { get; set; }
        public IU_ActualizarUbicacion InterfazActualizarUbicacion { get; set; }
        public IU_RegistrarMarca InterfazRegistrarMarcas { get; set; }
        public IU_ActualizarMarca InterfazActualizarMarca { get; set; }
        public IU_RegistrarTiposArticulo InterfazRegistrarTiposArticulo { get; set; }
        public IU_ActualizarTiposArticulo InterfazActualizarTiposArticulo { get; set; }
        public IU_RegistrarProveedorArticulo InterfazRegistrarProveedorArticulo { get; set; }
        public IU_ActualizarProveedorArticulo InterfazActualizarProveedorArticulo { get; set; }
        public IU_ConsultarMarca InterfazConsultarMarca { get; set; }
        public IU_ConsultarUbicacion InterfazConsultarUbicacion { get; set; }

        public IU_MenuPrincipalSoporte()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            InterfazRegistrarArticulo = new IU_RegistrarArticulo();
            InterfazRegistrarArticulo.ShowDialog();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            InterfazActualizarArticulo = new IU_ActualizarArticulo();
            InterfazActualizarArticulo.ShowDialog();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            InterfazConsultarArticulo = new IU_ConsultarArticulo();
            InterfazConsultarArticulo.ShowDialog();
        }

        private void btn_registrarUsuario_Click(object sender, EventArgs e)
        {
            IU_RegistrarUsuario interfazRegistrarUsuario = new IU_RegistrarUsuario();
            interfazRegistrarUsuario.ShowDialog();
        }

        private void btn_actualizarUsuario_Click(object sender, EventArgs e)
        {
            IU_ActualizarUsuario interfazActualizarUsuario = new IU_ActualizarUsuario();
            interfazActualizarUsuario.ShowDialog();
        }

        private void btn_registrarTarjeta_Click(object sender, EventArgs e)
        {
            InterfazRegistrarTarjeta = new IU_RegistrarTarjeta();
            InterfazRegistrarTarjeta.ShowDialog();
        }

        private void btn_consultarHistorialSesiones_Click(object sender, EventArgs e)
        {
            IU_ConsultarHistorialSesiones interfazConsultarHistorialSesiones = new IU_ConsultarHistorialSesiones();
            interfazConsultarHistorialSesiones.ShowDialog();
        }

        private void btn_consultarUsuario_Click(object sender, EventArgs e)
        {
            IU_ConsultarUsuario interfazConsultarUsuario = new IU_ConsultarUsuario();
            interfazConsultarUsuario.ShowDialog();
        }

        private void btn_articuloProveedor_Click(object sender, EventArgs e)
        {
            InterfazRegistrarProveedorArticulo = new IU_RegistrarProveedorArticulo();
            InterfazRegistrarProveedorArticulo.ShowDialog();
        }

        private void btn_registrarUbicacion_Click(object sender, EventArgs e)
        {
            InterfazRegistrarUbicacion = new IU_RegistrarUbicacion();
            InterfazRegistrarUbicacion.ShowDialog();
        }

        private void btn_actualizarUbicacion_Click(object sender, EventArgs e)
        {
            InterfazActualizarUbicacion = new IU_ActualizarUbicacion();
            InterfazActualizarUbicacion.ShowDialog();
        }

        private void btn_registrarMarca_Click(object sender, EventArgs e)
        {
            InterfazRegistrarMarcas = new IU_RegistrarMarca();
            InterfazRegistrarMarcas.ShowDialog();
        }

        private void btn_actualizarMarca_Click(object sender, EventArgs e)
        {
            InterfazActualizarMarca = new IU_ActualizarMarca();
            InterfazActualizarMarca.ShowDialog();
        }

        private void btn_actualizarArticuloProveedor_Click(object sender, EventArgs e)
        {
            InterfazActualizarProveedorArticulo = new IU_ActualizarProveedorArticulo();
            InterfazActualizarProveedorArticulo.ShowDialog();
        }

        private void btn_registrarTipoArticulo_Click(object sender, EventArgs e)
        {
            InterfazRegistrarTiposArticulo = new IU_RegistrarTiposArticulo();
            InterfazRegistrarTiposArticulo.ShowDialog();
        }

        private void btn_actualizarTipoArticulo_Click(object sender, EventArgs e)
        {
            InterfazActualizarTiposArticulo = new IU_ActualizarTiposArticulo();
            InterfazActualizarTiposArticulo.ShowDialog();
        }

        private void btn_actualizarTarjeta_Click(object sender, EventArgs e)
        {
            InterfazActualizarTarjeta = new IU_ActualizarTarjeta();
            InterfazActualizarTarjeta.ShowDialog();
        }

        private void btn_ConsultarMarca_Click(object sender, EventArgs e)
        {
            InterfazConsultarMarca = new IU_ConsultarMarca();
            InterfazConsultarMarca.ShowDialog();
        }

        private void btn_ConsultarUbicacion_Click(object sender, EventArgs e)
        {
            InterfazConsultarUbicacion = new IU_ConsultarUbicacion();
            InterfazConsultarUbicacion.ShowDialog();
        }

        private void btn_consultarEmpresa_Click(object sender, EventArgs e)
        {

        }
    }
}
