﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using SistemaLaObra.Ventas.OrdenDeRemito;

namespace SistemaLaObra.Ventas.RegistrarOrdenDeRemito
{
    public partial class IU_DatosDialogo : Form
    {
        //INSTANCIAS
        private Controlador_RegistrarOrden controladorOR;
        private Validaciones validacion;
        private List<Entrega> listaEntrega;

        //MAPA
        public GMapOverlay Capa { get; set; }
        public GMarkerGoogle MarcaFerreteria { get; set; }
        public GMarkerGoogle MarcaDestino { get; set; }
        public PointLatLng CoordenadaFerreteria { get; set; }
        public PointLatLng CoordenadaDestino { get; set; }
        public GMapRoute Ruta { get; set; }

        //VARIABLE GLOBAL
        string distancia="";

        //CONSTRUCTOR
        public IU_DatosDialogo(Controlador_RegistrarOrden controlador)
        {            
            InitializeComponent();
            controladorOR = controlador;
            listaEntrega = controlador.EntregaColeccion;
            validacion = new Validaciones();
        }        

        //BOTONES

        private void btn_cargarDatos_Click(object sender, EventArgs e)
        {
            //aca deberia ir cargando todo
            if (validacion.campoVacio(txt_nombreCliente.Text))
            {
                MessageBox.Show(this, "Debe ingesar el nombre del cliente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validacion.campoVacio(txt_calle.Text))
            {
                MessageBox.Show(this, "Debe ingresar el nombre de la calle", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validacion.campoVacio(txt_numero.Text))
            {
                MessageBox.Show(this, "Debe ingresar el número de la dirección", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validacion.campoVacio(txt_codigoPostal.Text))
            {
                MessageBox.Show(this, "Debe ingresar el codigo postal", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validacion.campoVacio(txt_barrio.Text))
            {
                MessageBox.Show(this, "Debe ingresar el barrio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validacion.campoVacio(txt_numeroTelefono.Text))
            {
                MessageBox.Show(this, "Debe ingresar un número de teléfono", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                
            else if (validacion.campoVacio(txt_distancia.Text)&&validacion.campoVacio(lbl_Distancia.Text))
            {
                MessageBox.Show(this, "Debe ingresar la distancia de envío manualmente o a través del mapa", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validacion.campoVacio(txt_observacion.Text))
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Seguro que no desea ingresar una observación?", "Alerta!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);                
                if (opcion==DialogResult.OK)
                {
                    txt_observacion.Text = "Sin descripción";
                    tomarNombreCliente();
                    controladorOR.nombreClienteEnvio(listaEntrega);
                    tomarDireccionCliente();
                    controladorOR.domicilioEnvio(listaEntrega);
                    tomarBarrio();
                    controladorOR.barrioEnvio(listaEntrega);
                    tomarSelecProvincia();
                    controladorOR.provinciaEnvio(listaEntrega);
                    tomarSelecDepartamento();
                    controladorOR.departamentoEnvio(listaEntrega);
                    tomarSelecLocalidad();
                    controladorOR.localidadEnvio(listaEntrega);
                    tomarSelecTipoTelefono();
                    controladorOR.tipoNroTelefonoEnvio(listaEntrega);
                    tomarNroTelefono();
                    controladorOR.nroTelefonoEnvio(listaEntrega);
                    tomarObservacion();
                    controladorOR.observacionEnvio(listaEntrega);
                    if (rbtn_manual.Checked)
                    {
                        tomarDistancia(float.Parse(txt_distancia.Text));
                    }
                    else
                    {
                        tomarDistancia(float.Parse(distancia));
                    }
                    controladorOR.distanciaEnvio(listaEntrega);
                    controladorOR.cargarDatosAInterfaz();
                    this.Close();
                }
            }
            else
            {
                tomarNombreCliente();
                controladorOR.nombreClienteEnvio(listaEntrega);
                tomarDireccionCliente();
                controladorOR.domicilioEnvio(listaEntrega);
                tomarBarrio();
                controladorOR.barrioEnvio(listaEntrega);
                tomarSelecProvincia();
                controladorOR.provinciaEnvio(listaEntrega);
                tomarSelecDepartamento();
                controladorOR.departamentoEnvio(listaEntrega);
                tomarSelecLocalidad();
                controladorOR.localidadEnvio(listaEntrega);
                tomarSelecTipoTelefono();
                controladorOR.tipoNroTelefonoEnvio(listaEntrega);
                tomarNroTelefono();
                controladorOR.nroTelefonoEnvio(listaEntrega);
                tomarObservacion();
                controladorOR.observacionEnvio(listaEntrega);
                if (rbtn_manual.Checked)
                {
                    tomarDistancia(float.Parse(txt_distancia.Text));
                }
                else
                {
                    tomarDistancia(float.Parse(distancia));
                }
                controladorOR.distanciaEnvio(listaEntrega);
                controladorOR.cargarDatosAInterfaz();
                this.Close();
            }                        
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VerMapa_Click(object sender, EventArgs e)
        {
            if (validacion.campoVacio(txt_nombreCliente.Text))
                MessageBox.Show(this, "Debe ingesar el nombre del cliente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (validacion.campoVacio(txt_calle.Text))
                MessageBox.Show(this, "Debe ingresar el nombre de la calle", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (validacion.campoVacio(txt_numero.Text))
                MessageBox.Show(this, "Debe ingresar el número de la dirección", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (validacion.campoVacio(txt_codigoPostal.Text))
                MessageBox.Show(this, "Debe ingresar el codigo postal", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (validacion.campoVacio(txt_barrio.Text))
                MessageBox.Show(this, "Debe ingresar el barrio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (validacion.campoVacio(txt_numeroTelefono.Text))
                MessageBox.Show(this, "Debe ingresar un número de teléfono", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else 
            {
                Cursor.Current = Cursors.WaitCursor;
                cargarMarcadorDestino();
                Cursor.Current = Cursors.Default;
            }            
        }

        //METODOS

        public void tomarSelecProvincia()
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).NombreProvincia = cbx_provincia.Text;
            //ORIGINAL//entrega.NombreProvincia = cbx_provincia.Text;
        }

        public void tomarSelecDepartamento()
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).NombreDepartamento = cbx_departamento.Text;
            //ORIGINAL//entrega.NombreDepartamento = cbx_departamento.Text;
        }

        public void tomarSelecLocalidad()
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).NombreLocalidad = cbx_localidad.Text;
            //ORIGINAL//entrega.NombreLocalidad = cbx_localidad.Text;
        }

        public void tomarBarrio()
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).NombreBarrio = txt_barrio.Text;
            //ORIGINAL//entrega.NombreBarrio = txt_barrio.Text;
        }

        public void tomarNombreCliente()
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).NombreCliente = txt_nombreCliente.Text;
            //ORIGINAL//entrega.NombreCliente = txt_nombreCliente.Text;
        }

        public void tomarDireccionCliente()
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).NombreCalle = txt_calle.Text;
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).NumeroCalle= int.Parse(txt_numero.Text);
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).CodigoPostal = txt_codigoPostal.Text;
            //ORIGINAL//entrega.NombreCalle = txt_calle.Text;
            //ORIGINAL//entrega.NumeroCalle = int.Parse(txt_numero.Text);
            //ORIGINAL//entrega.CodigoPostal = txt_codigoPostal.Text;
        }

        public void tomarSelecTipoTelefono()
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).NombreTipoTelefono = cbx_tipoTelefono.Text;
            //ORIGINAL//entrega.NombreTipoTelefono = cbx_tipoTelefono.Text;
        }

        public void tomarNroTelefono()
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).NumeroTelefono = txt_numeroTelefono.Text;
            //ORIGINAL//entrega.NumeroTelefono = txt_numeroTelefono.Text;
        }

        public void tomarObservacion()
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).Descripcion = txt_observacion.Text;
            //ORIGINAL//entrega.Descripcion = txt_observacion.Text;
        }

        public void tomarDistancia(float distanciaEnvio)
        {
            listaEntrega.ElementAt(controladorOR.IndiceEntrega).DistanciaEntrega = distanciaEnvio;
            //ORIGINAL//entrega.DistanciaEntrega = distanciaEnvio;            
        }

        //METODOS PRIVADOS

        private void cargarProvincias()
        {
            cbx_provincia.ValueMember = "CodigoProvincia";
            cbx_provincia.DisplayMember = "NombreProvincia";
            cbx_provincia.DataSource = controladorOR.mostrarSelecProvincia();
        }

        private void cargarDepartamentos()
        {
            int codigoProv = int.Parse(cbx_provincia.SelectedValue.ToString());
            cbx_departamento.ValueMember = "CodigoDepartamento";
            cbx_departamento.DisplayMember = "NombreDepartamento";
            cbx_departamento.DataSource = controladorOR.mostrarSelecDepartamento(codigoProv);
        }

        private void cargarLocalidades()
        {
            int codigoDepto = int.Parse(cbx_departamento.SelectedValue.ToString());
            cbx_localidad.ValueMember = "CodigoLocalidad";
            cbx_localidad.DisplayMember = "NombreLocalidad";
            cbx_localidad.DataSource = controladorOR.mostrarSelecLocalidad(codigoDepto);
        }

        private void cargarTipoDeTelefonos()
        {
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = controladorOR.mostrarSelectTipoTelefono();
        }

        private void cargarMarcadorDestino()
        {                           
            string hasta = txt_calle.Text + ", " + txt_numero.Text + ", " + cbx_provincia.Text + ", argentina";            
            var puntoFin = GMapProviders.GoogleMap.GetPoint(hasta, out GeoCoderStatusCode status);
            if (status == GeoCoderStatusCode.OK)
            {
                mapa.Refresh();
                double lat = double.Parse(puntoFin?.Lat.ToString());
                double lnn = double.Parse(puntoFin?.Lng.ToString());
                CoordenadaDestino = new PointLatLng(lat, lnn);
                var route = GoogleMapProvider.Instance.GetRoute(CoordenadaFerreteria, CoordenadaDestino, false, false, 14);                
                if (route.Status == RouteStatusCode.OK)
                {
                    Ruta = new GMapRoute(route.Points, "Mi Ruta");
                    distancia = Ruta.Distance.ToString("0.00");
                    lbl_Distancia.Text = Ruta.Distance.ToString("0.00") + " Km";
                    MarcaDestino = new GMarkerGoogle(CoordenadaDestino, GMarkerGoogleType.red_dot);
                    MarcaDestino.ToolTipMode = MarkerTooltipMode.Always;
                    MarcaDestino.ToolTipText = string.Format(txt_nombreCliente.Text);
                    Capa.Clear();
                    Capa.Markers.Add(MarcaFerreteria);
                    Capa.Markers.Add(MarcaDestino);
                    mapa.Overlays.Clear();
                    mapa.Overlays.Add(Capa);
                    mapa.ZoomAndCenterMarkers("capaMarcador");
                }
                else if (route.Status == RouteStatusCode.REQUEST_DENIED)
                {
                    MessageBox.Show(this, "Habilite Directions API en Google Cloud Platform", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (route.Status == RouteStatusCode.PERMISSION_DENIED)
                {
                    MessageBox.Show(this, "No tiene permiso para realizar la consulta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (route.Status == RouteStatusCode.OVER_QUERY_LIMIT)
                {
                    MessageBox.Show(this, "Ha alcanzado el limite de consultas mensual", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(this, "Ha habido un error", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (status == GeoCoderStatusCode.ZERO_RESULTS)
            {
                MessageBox.Show(this, "Ha ingresado una dirección inválida", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (status == GeoCoderStatusCode.REQUEST_DENIED)
            {
                MessageBox.Show(this, "Habilite Geocoding API en Google Cloud Platform", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (status == GeoCoderStatusCode.OVER_QUERY_LIMIT)
            {
                MessageBox.Show(this, "Ha alcanzado el limite de consultas mensual", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, "Ha habido un error", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void estadoInicialDistancia()
        {
            rbtn_manual.Checked = true;
            lbl_dist.Enabled = true;
            txt_distancia.Enabled = true;
            btn_VerMapa.Enabled = false;
            lbl_Distancia.Enabled = false;
            cbx_provincia.SelectedIndex = 18;
            cbx_departamento.SelectedIndex = 10;
            cbx_localidad.SelectedIndex = 3;            
        }

        private void cargarMapaInicial()
        {            
            GoogleMapProvider.Instance.ApiKey = @"AIzaSyDVX6uMd3YxiS2FmXK8LCOgLIdh90xmet4";
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            CoordenadaFerreteria = new PointLatLng(-31.3247304, -64.2477592);
            mapa.Position = CoordenadaFerreteria;
            mapa.DragButton = MouseButtons.Left;
            mapa.MapProvider = GoogleMapProvider.Instance;
            mapa.ShowCenter = false;
            mapa.MinZoom = 0;
            mapa.MaxZoom = 24;
            mapa.Zoom = 16;
            mapa.CanDragMap = true;
            mapa.AutoScroll = true;

            Capa = new GMapOverlay("capaMarcador");
            MarcaFerreteria = new GMarkerGoogle(CoordenadaFerreteria, GMarkerGoogleType.blue_dot);
            MarcaFerreteria.ToolTipMode = MarkerTooltipMode.Always;
            MarcaFerreteria.ToolTipText = "FERRETERIA";
            Capa.Markers.Add(MarcaFerreteria);
            mapa.Overlays.Add(Capa);            
        }

        //EVENTOS

        private void IU_DatosDialogo_Load(object sender, EventArgs e)
        {
            lbl_Distancia.Text = string.Empty;
            cargarMapaInicial();
            cargarProvincias();
            cargarTipoDeTelefonos();
            estadoInicialDistancia();
            if (controladorOR.Venta.CodigoClienteMayorista != 0)
            {
                controladorOR.ClienteMayorista = controladorOR.Venta.conocerClienteMayorista(controladorOR.Venta.CodigoClienteMayorista);

                txt_nombreCliente.Text = controladorOR.ClienteMayorista.RazonSocial;
                txt_codigoPostal.Text = controladorOR.ClienteMayorista.CodigoPostal.ToString();
                txt_calle.Text = controladorOR.ClienteMayorista.Calle;
                txt_numero.Text = controladorOR.ClienteMayorista.Numero.ToString();
                txt_barrio.Text = controladorOR.ClienteMayorista.NombreBarrio;
                cbx_provincia.SelectedValue = controladorOR.ClienteMayorista.CodigoProvincia;
                cbx_departamento.SelectedValue = controladorOR.ClienteMayorista.CodigoDepartamento;
                cbx_localidad.SelectedValue = controladorOR.ClienteMayorista.CodigoLocalidad;
                cbx_tipoTelefono.SelectedValue = controladorOR.ClienteMayorista.CodigoTipoTelefono;
                txt_numeroTelefono.Text = controladorOR.ClienteMayorista.NumeroTelefono.ToString();
            }
            if (controladorOR.ControladorRV.venta.CodigoClienteMayorista != 0)
            {
                controladorOR.ClienteMayorista = controladorOR.Venta.conocerClienteMayorista(controladorOR.ControladorRV.venta.CodigoClienteMayorista);

                txt_nombreCliente.Text = controladorOR.ClienteMayorista.RazonSocial;
                txt_codigoPostal.Text = controladorOR.ClienteMayorista.CodigoPostal.ToString();
                txt_calle.Text = controladorOR.ClienteMayorista.Calle;
                txt_numero.Text = controladorOR.ClienteMayorista.Numero.ToString();
                txt_barrio.Text = controladorOR.ClienteMayorista.NombreBarrio;
                cbx_provincia.SelectedValue = controladorOR.ClienteMayorista.CodigoProvincia;
                cbx_departamento.SelectedValue = controladorOR.ClienteMayorista.CodigoDepartamento;
                cbx_localidad.SelectedValue = controladorOR.ClienteMayorista.CodigoLocalidad;
                cbx_tipoTelefono.SelectedValue = controladorOR.ClienteMayorista.CodigoTipoTelefono;
                txt_numeroTelefono.Text = controladorOR.ClienteMayorista.NumeroTelefono.ToString();
            }
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_codigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_distancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloDecimalesConComa(e);
        }

        private void txt_numeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void cbx_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDepartamentos();
        }

        private void cbx_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarLocalidades();
        }

        private void rbtn_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_manual.Checked==true)
            {
                lbl_dist.Enabled = true;
                txt_distancia.Enabled = true;
                //gMapControl2.Enabled = false;
                btn_VerMapa.Enabled = false;
                lbl_Distancia.Enabled = false;
            }
            else
            {
                lbl_dist.Enabled = false;
                txt_distancia.Enabled = false;
                //gMapControl2.Enabled = true;
                btn_VerMapa.Enabled = true;
                lbl_Distancia.Enabled = true;
            }
        }        
    }
}
