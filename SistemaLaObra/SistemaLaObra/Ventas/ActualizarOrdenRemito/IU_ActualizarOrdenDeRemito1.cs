using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLaObra.Ventas.RegistrarNotaDeCredito;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace SistemaLaObra.Ventas.ActualizarOrdenRemito
{
    public partial class IU_ActualizarOrdenDeRemito1 : Form
    {
        //VARIABLE GLOBAL
        string distancia = "";

        //INSTANCIAS
        private GDirections direccion;
        private GeoCoderStatusCode status;
        GMapOverlay marcadores;
        Controlador_ActualizarOrdenRemito controladorAOR;
        private Venta _venta;
        private Entrega _entrega;        
        private IU_RegistrarVenta _interfazVenta;
        private IU_RegistrarNotaCredito _interfazNotaCredito;
        private IU_MenuPrincipal _interfazContenedora;
        private Validaciones validacion;

        public Venta Venta
        {
            get
            {
                return _venta;
            }

            set
            {
                _venta = value;
            }
        }

        public Entrega Entrega
        {
            get
            {
                return _entrega;
            }

            set
            {
                _entrega = value;
            }
        }

        public IU_MenuPrincipal InterfazContenedora
        {
            get
            {
                return _interfazContenedora;
            }

            set
            {
                _interfazContenedora = value;
            }
        }

        public IU_RegistrarVenta InterfazVenta
        {
            get
            {
                return _interfazVenta;
            }

            set
            {
                _interfazVenta = value;
            }
        }

        public IU_RegistrarNotaCredito InterfazNotaCredito
        {
            get
            {
                return _interfazNotaCredito;
            }

            set
            {
                _interfazNotaCredito = value;
            }
        }

        public IU_ActualizarOrdenDeRemito1(Controlador_ActualizarOrdenRemito controladorInstanciado)
        {
            controladorAOR = controladorInstanciado;
            marcadores = new GMapOverlay("capaMarcador");
            validacion = new Validaciones();
            InterfazVenta = new IU_RegistrarVenta();
            InterfazNotaCredito = new IU_RegistrarNotaCredito();
            Entrega = new Entrega();
            InitializeComponent();
        }

        //BOTONES

        private void btn_actualizarDatos_Click(object sender, EventArgs e)
        {
            if (controladorAOR.Entrega.DistanciaEntrega== float.Parse(txt_distancia.Text))
            {
                //actualizar sin diferencia de precios
                tomarDireccionCliente();
                tomarBarrio();
                tomarSelecProvincia();
                tomarSelecDepartamento();
                tomarSelecLocalidad();
                tomarSelecTipoTelefono();
                tomarNroTelefono();
                tomarObservacion();
                tomarDistancia();
                tomarFechaEntrega();
                tomarHoraEntregaDesde();
                tomarHoraEntregaHasta();
                if (!controladorAOR.verificarCambios())
                {
                    if (controladorAOR.verificarDistanciaCorrecta())
                    {
                        controladorAOR.actualizarEntrega();
                        MessageBox.Show(this, "Se ha modificado correctamente el envío", "ORDEN DE REMITO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "No ha modificado la distancia del envío", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No ha introducido dato alguno a ser modificado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (controladorAOR.Entrega.DistanciaEntrega < float.Parse(txt_distancia.Text))
                {
                    tomarDireccionCliente();
                    tomarBarrio();
                    tomarSelecProvincia();
                    tomarSelecDepartamento();
                    tomarSelecLocalidad();
                    tomarSelecTipoTelefono();
                    tomarNroTelefono();
                    tomarObservacion();
                    tomarDistancia();
                    tomarFechaEntrega();
                    tomarHoraEntregaDesde();
                    tomarHoraEntregaHasta();
                    controladorAOR.calcularDiferenciaPrecios();
                    //Entrega = controladorAOR.EntregaActualizacion;
                    InterfazVenta.opcionRegistrarVenta(controladorAOR.EntregaActualizacion);
                    InterfazVenta.InterfazContenedora = InterfazContenedora; //AGREGADO POR GERARDO
                    InterfazVenta.ShowDialog();
                    controladorAOR.EntregaActualizacion.Venta.CodigoVenta = InterfazVenta.controlador.venta.CodigoVenta;
                    //si llego a este punto debo realizar la actualizacion de la entrega

                    /*if (controladorAOR.EntregaActualizacion.Venta.CodigoVenta==0)
                    {
                        this.Close();
                    }
                    else
                    {
                        controladorAOR.actualizarEntrega();
                        MessageBox.Show(this, "Se ha modificado correctamente el envío", "ORDEN DE REMITO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }*/
                    if (!InterfazVenta.ventaRegistrada)
                    {                     
                        this.Close();
                    }
                    else
                    {
                        InterfazVenta.Close();
                        controladorAOR.actualizarEntrega();
                        MessageBox.Show(this, "Se ha modificado correctamente el envío", "ORDEN DE REMITO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                }
                else
                {
                    tomarDireccionCliente();
                    tomarBarrio();
                    tomarSelecProvincia();
                    tomarSelecDepartamento();
                    tomarSelecLocalidad();
                    tomarSelecTipoTelefono();
                    tomarNroTelefono();
                    tomarObservacion();
                    tomarDistancia();
                    tomarFechaEntrega();
                    tomarHoraEntregaDesde();
                    tomarHoraEntregaHasta();
                    controladorAOR.calcularDiferenciaPrecios();
                    //Entrega = controladorAOR.EntregaActualizacion;
                    controladorAOR.EntregaActualizacion.Venta = controladorAOR.Venta;
                    InterfazNotaCredito.InterfazContenedora = InterfazContenedora; //AGREGADO POR GERARDO
                    InterfazNotaCredito.opcionRegistrarNotaDeCredito(controladorAOR.EntregaActualizacion);
                    InterfazNotaCredito.ShowDialog();
                    int codigoNotaCredito = InterfazNotaCredito.controlador.notaCredito.CodigoNotaCredito;
                    //si llego a este punto debo realizar la actualizacion de la entrega

                    if (codigoNotaCredito==0)
                    {
                        this.Close();
                    }
                    else
                    {
                        //Ver si todo quedo bien
                        controladorAOR.actualizarEntrega();
                        MessageBox.Show(this, "Se ha modificado correctamente el envío", "ORDEN DE REMITO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }                    
                }
            }            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VerMapa_Click(object sender, EventArgs e)
        {
            if (validacion.campoVacio(txt_calle.Text))
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
                cargarMarcadorDestino();
            }
        }

        //METODOS

        //todos los tomar para el botón actualizar

        public void tomarDireccionCliente()
        {
            controladorAOR.EntregaActualizacion.NombreCalle = txt_calle.Text;
            controladorAOR.EntregaActualizacion.NumeroCalle = int.Parse(txt_numero.Text);
            controladorAOR.EntregaActualizacion.CodigoPostal = txt_codigoPostal.Text;            
        }

        public void tomarBarrio()
        {
            controladorAOR.EntregaActualizacion.NombreBarrio = txt_barrio.Text;            
        }

        public void tomarSelecProvincia()
        {
            controladorAOR.EntregaActualizacion.NombreProvincia = cbx_provincia.Text;            
        }

        public void tomarSelecDepartamento()
        {
            controladorAOR.EntregaActualizacion.NombreDepartamento = cbx_departamento.Text;            
        }

        public void tomarSelecLocalidad()
        {
            controladorAOR.EntregaActualizacion.NombreLocalidad = cbx_localidad.Text;
        }
                
        public void tomarSelecTipoTelefono()
        {
            controladorAOR.EntregaActualizacion.NombreTipoTelefono = cbx_tipoTelefono.Text;            
        }

        public void tomarNroTelefono()
        {
            controladorAOR.EntregaActualizacion.NumeroTelefono = txt_numeroTelefono.Text;            
        }

        public void tomarObservacion()
        {
            controladorAOR.EntregaActualizacion.Descripcion = txt_observacion.Text;            
        }

        public void tomarDistancia()
        {
            controladorAOR.EntregaActualizacion.DistanciaEntrega = float.Parse(txt_distancia.Text);
        }

        public void tomarFechaEntrega()
        {
            controladorAOR.EntregaActualizacion.FechaEntrega = dtp_fecha.Value;
        }

        public void tomarHoraEntregaDesde()
        {
            controladorAOR.EntregaActualizacion.HoraEntregaDesde = dtp_horaDesde.Value;
        }

        public void tomarHoraEntregaHasta()
        {
            controladorAOR.EntregaActualizacion.HoraEntregaHasta = dtp_horaHasta.Value;
        }

        //

        //METODOS PRIVADOS

        private void cargarDatos()
        {
            lbl_numeroVenta.Text = controladorAOR.Venta.CodigoVenta.ToString("00000000");
            lbl_numeroRemito.Text = controladorAOR.Entrega.CodigoEntrega.ToString("00000000");
            lbl_nombreCliente.Text = controladorAOR.Entrega.NombreCliente;
            txt_codigoPostal.Text = controladorAOR.Entrega.CodigoPostal;
            txt_calle.Text = controladorAOR.Entrega.NombreCalle;
            txt_numero.Text = controladorAOR.Entrega.NumeroCalle.ToString();
            txt_barrio.Text = controladorAOR.Entrega.NombreBarrio;
            txt_numeroTelefono.Text = controladorAOR.Entrega.NumeroTelefono;
            txt_observacion.Text = controladorAOR.Entrega.Descripcion;
            txt_distancia.Text = controladorAOR.Entrega.DistanciaEntrega.ToString("0.00");
            cargarMapa();
            cargarProvincias();
            cargarDepartamentos();
            cargarLocalidades();
            cargarTipoDeTelefonos();
            cbx_provincia.SelectedValue= controladorAOR.Provincia.mostrarCodigo(controladorAOR.Entrega.NombreProvincia);            
            cbx_departamento.SelectedValue = controladorAOR.Departamento.mostrarCodigo(controladorAOR.Entrega.NombreDepartamento, int.Parse(cbx_provincia.SelectedValue.ToString()));
            cbx_localidad.SelectedValue = controladorAOR.Localidad.mostrarCodigo(controladorAOR.Entrega.NombreLocalidad, int.Parse(cbx_departamento.SelectedValue.ToString()));
            cbx_tipoTelefono.SelectedValue = controladorAOR.TipoTelefono.mostrarCodigo(controladorAOR.Entrega.NombreTipoTelefono);
            dtp_fecha.Text = controladorAOR.Entrega.FechaEntrega.ToShortDateString();
            dtp_horaDesde.Text = controladorAOR.Entrega.HoraEntregaDesde.ToShortTimeString();
            dtp_horaHasta.Text = controladorAOR.Entrega.HoraEntregaHasta.ToShortTimeString();
            rbtn_manual.Checked = true;
        }

        private void cargarMapa()
        {
            gMapControl2.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl2.SetPositionByKeywords("Cordoba, Argentina");
            gMapControl2.ShowCenter = false;
            gMapControl2.DragButton = MouseButtons.Left;
            gMapControl2.CanDragMap = true;
            gMapControl2.AutoScroll = true;
        }

        private void cargarProvincias()
        {
            cbx_provincia.ValueMember = "CodigoProvincia";
            cbx_provincia.DisplayMember = "NombreProvincia";
            cbx_provincia.DataSource = controladorAOR.mostrarSelecProvincia();
        }

        private void cargarDepartamentos()
        {
            int codigoProv = int.Parse(cbx_provincia.SelectedValue.ToString());
            cbx_departamento.ValueMember = "CodigoDepartamento";
            cbx_departamento.DisplayMember = "NombreDepartamento";
            cbx_departamento.DataSource = controladorAOR.mostrarSelecDepartamento(codigoProv);
        }

        private void cargarLocalidades()
        {
            int codigoDepto = int.Parse(cbx_departamento.SelectedValue.ToString());
            cbx_localidad.ValueMember = "CodigoLocalidad";
            cbx_localidad.DisplayMember = "NombreLocalidad";
            cbx_localidad.DataSource = controladorAOR.mostrarSelecLocalidad(codigoDepto);
        }

        private void cargarTipoDeTelefonos()
        {
            cbx_tipoTelefono.ValueMember = "CodigoTipoTelefono";
            cbx_tipoTelefono.DisplayMember = "Descripcion";
            cbx_tipoTelefono.DataSource = controladorAOR.mostrarSelectTipoTelefono();
        }

        private void cargarMarcadorDestino()
        {
            //OBTENGO DIRECCION    
            string hasta = txt_calle.Text + ", " + txt_numero.Text + ", " + cbx_provincia.Text + ", argentina";
            //DEVUELVO COORDENADAS
            var puntoFin = GMapProviders.GoogleMap.GetPoint(hasta, out status);
            if (puntoFin == null)
            {
                MessageBox.Show(this, "No ingreso una dirección válida por favor reingrese la dirección", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //CALCULO RUTA
                    gMapControl2.Refresh();
                    PointLatLng laObra = new PointLatLng(-31.4671849, -64.2239958);
                    var RutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion, laObra, puntoFin.Value, false, false, false, false, false);
                    GMapRoute rutaObtenida = new GMapRoute(direccion.Route, "Ruta");
                    //CALUCLO DE  DISTANCIA
                    distancia = rutaObtenida.Distance.ToString("0.00");
                    lbl_Distancia.Text = distancia + " Km";
                    txt_distancia.Text = distancia;
                    //LIMPIO CAPA DE MARCADORES                             
                    marcadores.Clear();
                    //MARCADOR DE INICIO    
                    GMarkerGoogle puntoInicioViaje = new GMarkerGoogle(laObra, GMarkerGoogleType.blue);
                    puntoInicioViaje.ToolTipMode = MarkerTooltipMode.Always;
                    puntoInicioViaje.ToolTipText = string.Format("Ferretería \n LA OBRA \n de Mario Labarre");
                    //MARCADOR DE FIN
                    GMarkerGoogle puntoFinViaje = new GMarkerGoogle(puntoFin.Value, GMarkerGoogleType.red);
                    puntoFinViaje.ToolTipMode = MarkerTooltipMode.Always;
                    puntoFinViaje.ToolTipText = string.Format(lbl_nombreCliente.Text);
                    //AGREGO MARCADORES A LA CAPA
                    marcadores.Markers.Add(puntoInicioViaje);
                    marcadores.Markers.Add(puntoFinViaje);
                    //AGREGO CAPA AL CONTROL GMAP                
                    gMapControl2.Overlays.Add(marcadores);
                    gMapControl2.ZoomAndCenterMarkers("capaMarcador");
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "No ingreso una dirección válida por favor reingrese la dirección", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //EVENTOS

        private void IU_ActualizarOrdenDeRemito1_Load(object sender, EventArgs e)
        {
            cargarDatos();
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
            if (rbtn_manual.Checked == true)
            {
                lbl_dist.Enabled = true;
                txt_distancia.Enabled = true;
                gMapControl2.Enabled = false;
                btn_VerMapa.Enabled = false;
                lbl_Distancia.Enabled = false;
            }
            else
            {
                lbl_dist.Enabled = false;
                txt_distancia.Enabled = false;
                gMapControl2.Enabled = true;
                btn_VerMapa.Enabled = true;
                lbl_Distancia.Enabled = true;
            }
        }
    }
}
