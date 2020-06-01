﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra.Logistica;
using SistemaLaObra.Compras;
using SistemaLaObra.InicioSesion;
using SistemaLaObra.CerrarSesion;
using SistemaLaObra.Estadística;

namespace SistemaLaObra
{
    public partial class IU_MenuPrincipal : Form
    {
        IU_InicioSesion interfazInicioSesion;
        IU_CerrarSesion interfazCerrarSesion;
        HistorialSesion historialSesion;

        public int CodigoHistorial { get; set; }

        //PROPIEDADES DONDE SE ALMACENAN LA INFORMACION DEL USUARIO Y ENCARGADO
        public Usuario UsuarioActivo { get; set; }
        public Encargado EncargadoActivo { get; set; }

        public IU_MenuPrincipal()
        {
            InitializeComponent();
            interfazInicioSesion = new IU_InicioSesion();
        }

        private void IU_MenuPrincipal_Load(object sender, EventArgs e)
        {
            interfazInicioSesion.interfazContenedora = this;
            interfazInicioSesion.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ms_btnInicioSesion_Click(object sender, EventArgs e)
        {
            interfazInicioSesion.ShowDialog();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            if (this.pnl_subMenu.Controls.Count > 0) 
                this.pnl_subMenu.Controls.RemoveAt(0);
            IU_MenuPrincipalVentas menuVentas = new IU_MenuPrincipalVentas();
            menuVentas.TopLevel = false;
            menuVentas.Dock = DockStyle.Fill; 
            this.pnl_subMenu.Controls.Add(menuVentas);
            menuVentas.interfazContenedora = this;
            menuVentas.Show();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            if (this.pnl_subMenu.Controls.Count > 0)
                this.pnl_subMenu.Controls.RemoveAt(0);
            IU_MenuPrincipalCompras menuCompras = new IU_MenuPrincipalCompras();
            menuCompras.TopLevel = false;
            menuCompras.Dock = DockStyle.Fill;
            this.pnl_subMenu.Controls.Add(menuCompras);
            menuCompras.interfazContenedora = this;
            menuCompras.Show();
        }

        private void btn_logistica_Click(object sender, EventArgs e)
        {
            if (this.pnl_subMenu.Controls.Count > 0)
                this.pnl_subMenu.Controls.RemoveAt(0);
            IU_MenuPrincipalLogistica menuLogistica = new IU_MenuPrincipalLogistica();
            menuLogistica.TopLevel = false;
            menuLogistica.Dock = DockStyle.Fill;
            this.pnl_subMenu.Controls.Add(menuLogistica);
            menuLogistica.interfazContenedora = this;
            menuLogistica.Show();
        }


        private void btn_estadistica_Click(object sender, EventArgs e)
        {
            if (this.pnl_subMenu.Controls.Count > 0)
                this.pnl_subMenu.Controls.RemoveAt(0);
            IU_MenuPrincipalEstadistica menuEstadistica = new IU_MenuPrincipalEstadistica();
            menuEstadistica.TopLevel = false;
            menuEstadistica.Dock = DockStyle.Fill;
            this.pnl_subMenu.Controls.Add(menuEstadistica);
            menuEstadistica.interfazContenedora = this;
            menuEstadistica.Show();
        }

        private void btn_soporte_Click(object sender, EventArgs e)
        {
            if (this.pnl_subMenu.Controls.Count > 0)
                this.pnl_subMenu.Controls.RemoveAt(0);
            IU_MenuPrincipalSoporte menuSoporte = new IU_MenuPrincipalSoporte();
            menuSoporte.TopLevel = false;
            menuSoporte.Dock = DockStyle.Fill;
            this.pnl_subMenu.Controls.Add(menuSoporte);
            menuSoporte.interfazContenedora = this;
            menuSoporte.Show();
        }

        private void ms_btnCerrarSesion_Click(object sender, EventArgs e)
        {
            interfazCerrarSesion = new IU_CerrarSesion();
            interfazCerrarSesion.InterfazContenedora = this;
            interfazCerrarSesion.ShowDialog();
        }

        private void IU_MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            historialSesion = new HistorialSesion();
            historialSesion.actualizarHistorial(CodigoHistorial, DateTime.Now);
        }

    }
}
