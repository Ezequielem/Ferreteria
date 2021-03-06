﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;


namespace SistemaLaObra.Ventas.CobroConTarjeta.Venta_Mayorista
{
    class Controlador_TarjetaVentaMayorista
    {

        // Instancias referencias
        AccesoDatos acceso;
        IU_CobroConTarjetaMayorista interfazTarjeta;
        Controlador_VentaMayorista controladorV;
        Tarjeta tarjeta;
        Banco banco;
        TipoTarjeta tipoTarjeta;
        NombreTarjeta nombreTarjeta;
        Validaciones validacion;
        private List<Tarjeta> tarjetaColeccion;
        private int _indiceTarjeta;

        private float interesEnPesos;


        //Constructor
        public Controlador_TarjetaVentaMayorista(IU_CobroConTarjetaMayorista interfazTarjeta1)
        {
            validacion = new Validaciones();
            interfazTarjeta = interfazTarjeta1;
            acceso = new AccesoDatos();
            tarjeta = new Tarjeta();
            banco = new Banco();
            tipoTarjeta = new TipoTarjeta();
            nombreTarjeta = new NombreTarjeta();
            tarjetaColeccion = new List<Tarjeta>();

        }

        public void recibirControladorVenta(Controlador_VentaMayorista controlador)
        {
            controladorV = controlador;

        }

        public Tarjeta Tarjeta
        {
            set { this.tarjeta = value; }
            get { return tarjeta; }
        }

        public List<Tarjeta> TarjetaColeccion
        {
            get
            {
                return tarjetaColeccion;
            }

            set
            {
                tarjetaColeccion = value;
            }
        }

        public float InteresEnPesos
        {
            set { this.interesEnPesos = value; }
            get { return interesEnPesos; }
        }

        public int IndiceTarjeta
        {
            get
            {
                return _indiceTarjeta;
            }

            set
            {
                _indiceTarjeta = value;
            }
        }

        public void nombreIngresado(List<Tarjeta> listaTarjetaInstanciada)
        {
            TarjetaColeccion = listaTarjetaInstanciada;
        }

        public void apellidoIngresado(List<Tarjeta> listaTarjetaInstanciada)
        {
            TarjetaColeccion = listaTarjetaInstanciada;
        }

        public void datosTipoTarjeta()
        {
            tipoTarjeta.recibirInterfazCobroConTarjetaMayorista(interfazTarjeta);
            tipoTarjeta.mostrarDatosTipoTarjeta();
        }

        public void seleccionTipoTarjeta(List<Tarjeta> listaTarjetaInstanciada)
        {
            TarjetaColeccion = listaTarjetaInstanciada;
        }

        public void datosNombreTarjeta()
        {
            nombreTarjeta.recibirInterfazCobroConTarjetaMay(interfazTarjeta);

            if (interfazTarjeta.cb_tipoTarjeta.SelectedValue.ToString() != null)
            {
                string id_nombreTarjeta = interfazTarjeta.cb_Banco.SelectedValue.ToString();
                nombreTarjeta.mostrarDatosNomTarjeta(id_nombreTarjeta);
            }
        }

        public void seleccionNombreTarjeta(List<Tarjeta> listaTarjetaInstanciada)
        {
            TarjetaColeccion = listaTarjetaInstanciada;
        }

        public void seleccionBanco(List<Tarjeta> listaTarjetaInstanciada)
        {
            TarjetaColeccion = listaTarjetaInstanciada;
        }

        public void datosBAnco()
        {
            banco.recibirInterfazCobroConTarjetaMay(interfazTarjeta);

            if (interfazTarjeta.cb_tipoTarjeta.SelectedValue.ToString() != null)
            {
                string id_tipoTarjeta = interfazTarjeta.cb_tipoTarjeta.SelectedValue.ToString();
                banco.mostrarDatosBanco(id_tipoTarjeta);
            }
            if (interfazTarjeta.cb_tipoTarjeta.Text == "Debito")
                interfazTarjeta.txt_cuotas.Enabled = false;
            else
                interfazTarjeta.txt_cuotas.Enabled = true;
        }

        public void cantidadCuota(List<Tarjeta> listaTarjetaInstanciada)
        {
            TarjetaColeccion = listaTarjetaInstanciada;
        }

        public void porcentajeInteresTomado(List<Tarjeta> listaTarjetaInstanciada)
        {
            TarjetaColeccion = listaTarjetaInstanciada;
        }

        public void opcionCalcularTomado()
        {

            float acumulador = 0f;

            if (validacion.campoVacio(interfazTarjeta.txt_interes.Text))
            {
                MessageBox.Show("No ingreso el interes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (controladorV.listaEntrega == null)

            {
                if (interfazTarjeta.cb_importe.Checked != true)
                {
                    float importeParcialFactura = controladorV.venta.ImporteTotal;
                    interfazTarjeta.tomarPorcentajeInteres();
                    float interesTotal = importeParcialFactura * TarjetaColeccion.ElementAt(IndiceTarjeta).Interes / 100;
                    float total = importeParcialFactura + interesTotal;
                    interfazTarjeta.lbl_importeTotal.Text = total.ToString("0.00");
                }
                else
                {
                    string otroImporte0 = interfazTarjeta.txt_otroImporte.Text;
                    float otroImporte = float.Parse(otroImporte0);
                    float importeParcialFactura = otroImporte;
                    interfazTarjeta.tomarPorcentajeInteres();
                    float interesTotal = importeParcialFactura * TarjetaColeccion.ElementAt(IndiceTarjeta).Interes / 100;
                    float total = importeParcialFactura + interesTotal;
                    interfazTarjeta.lbl_importeTotal.Text = total.ToString("0.00");
                }

            }

            else
            {
                if (interfazTarjeta.cb_importe.Checked != true)
                {
                    foreach (var item in controladorV.listaEntrega)
                    {
                        acumulador += item.PrecioEntrega;
                    }

                    float importeParcialFactura = controladorV.venta.ImporteTotal;
                    interfazTarjeta.tomarPorcentajeInteres();
                    float suma = importeParcialFactura + acumulador;
                    float interesTotal = suma * TarjetaColeccion.ElementAt(IndiceTarjeta).Interes / 100;
                    float total = suma + interesTotal;
                    interfazTarjeta.lbl_importeTotal.Text = total.ToString("0.00");
                }

                else
                {

                    foreach (var item in controladorV.listaEntrega)
                    {
                        acumulador += item.PrecioEntrega;
                    }

                    string otroImporte0 = interfazTarjeta.txt_otroImporte.Text;
                    float otroImporte = float.Parse(otroImporte0);
                    float importeParcialFactura = otroImporte;
                    interfazTarjeta.tomarPorcentajeInteres();
                    float interesTotal = importeParcialFactura * TarjetaColeccion.ElementAt(IndiceTarjeta).Interes / 100;
                    float total = importeParcialFactura + interesTotal;
                    interfazTarjeta.lbl_importeTotal.Text = total.ToString("0.00");

                }

            }

        }

        public int buscarUltimoNumeroTarjeta()
        {
            return Tarjeta.mostrarUltimoNroTarjeta();
        }

        public void calcularTotal()
        {

            float acumulador = 0f;

            if (controladorV.listaEntrega == null)

            {
                if (interfazTarjeta.cb_importe.Checked != true)
                {
                    float importeParcialFactura = controladorV.venta.ImporteTotal;
                    float interesTotal = importeParcialFactura * TarjetaColeccion.ElementAt(IndiceTarjeta).Interes / 100;
                    float total = importeParcialFactura + interesTotal;

                    TarjetaColeccion.ElementAt(IndiceTarjeta).ImporteTotalVentaCalculado = total;
                    //Tarjeta.ImporteTotalVentaCalculado = total;                   

                }
                else
                {
                    string otroImporte0 = interfazTarjeta.txt_otroImporte.Text;
                    float otroImporte = float.Parse(otroImporte0);
                    float importeParcialFactura = otroImporte;
                    float interesTotal = otroImporte * TarjetaColeccion.ElementAt(IndiceTarjeta).Interes / 100;
                    float total = importeParcialFactura + interesTotal;

                    TarjetaColeccion.ElementAt(IndiceTarjeta).ImporteTotalVentaCalculado = total;

                    //Tarjeta.ImporteTotalVentaCalculado = controladorV.venta.ImporteTotal + interesTotal;

                }
            }
            else
            {
                foreach (var item in controladorV.listaEntrega)
                {
                    acumulador += item.PrecioEntrega;
                }
                if (interfazTarjeta.cb_importe.Checked != true)
                {
                    float importeParcialFactura = controladorV.venta.ImporteTotal;
                    float suma = importeParcialFactura + acumulador;
                    float interesTotal = suma * TarjetaColeccion.ElementAt(IndiceTarjeta).Interes / 100;
                    float total = suma + interesTotal;

                    TarjetaColeccion.ElementAt(IndiceTarjeta).ImporteTotalVentaCalculado = total;

                    // Tarjeta.ImporteTotalVentaCalculado = total;

                }
                else
                {
                    string otroImporte0 = interfazTarjeta.txt_otroImporte.Text;
                    float otroImporte = float.Parse(otroImporte0);
                    float importeParcialFactura = otroImporte;
                    float interesTotal = otroImporte * TarjetaColeccion.ElementAt(IndiceTarjeta).Interes / 100;
                    float total = importeParcialFactura + interesTotal;

                    TarjetaColeccion.ElementAt(IndiceTarjeta).ImporteTotalVentaCalculado = total;

                    // Tarjeta.ImporteTotalVentaCalculado = controladorV.venta.ImporteTotal + interesTotal;
                }
            }
        }

        public void cantidadTarjeta(int cantidadTarjeta)
        {
            for (int i = 0; i < cantidadTarjeta; i++)
            {
                TarjetaColeccion.Add(new Tarjeta() { CodigoTarjeta = i + 1 });
            }
        }

        public void importeTarjetaTomado(List<Tarjeta> listaTarjetaInstanciada)
        {
            TarjetaColeccion = listaTarjetaInstanciada;
        }

        public void numeroTarjetaTomado(List<Tarjeta> listaTarjetaInstanciada)
        {
            TarjetaColeccion = listaTarjetaInstanciada;
        }

        private void calcularInteresEnPesos()
        {
            InteresEnPesos = Tarjeta.ImporteTotalVentaCalculado * Tarjeta.Interes / 100;
        }

        public void calcularDiferenciaCobro(List<Tarjeta> listaTarjeta)
        {
            float acumulador = 0;
            tarjetaColeccion = listaTarjeta;



            if (listaTarjeta.Count >1)
            {
                foreach (var item in listaTarjeta)
                {
                    if (item.ImporteTarjeta != 0)
                    
                        acumulador = acumulador + item.ImporteTarjeta;
                    
                }
                float importe = float.Parse(interfazTarjeta.lbl_importeFactura.Text) - acumulador;
                interfazTarjeta.txt_otroImporte.Text = importe.ToString();

            }

            }

        public void actualizarInterfazVenta()
        {
            calcularInteresEnPesos();


        }

    

    }
}