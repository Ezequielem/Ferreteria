using System;
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

namespace SistemaLaObra.Ventas.OrdenDeRemito
{
    public partial class IU_RegistrarOrden_4 : Form
    {
        //REFERENCIA
        private Controlador_RegistrarOrden controladorOR;

        //INSTANCIAS
        Validaciones validar;
        private List<Entrega> _listaEntrega;
        List<RadioButton> listaRbtnOpcion1;
        List<RadioButton> listaRbtnOpcion2;
        List<RadioButton> listaRbtnOpcion3;
        List<RadioButton> listaRbtnOpcion4;
        List<RadioButton> listaRbtnManual;
        List<Label> listaLblManual;
        List<Label> listaLblDistancia;
        List<TextBox> listaTxtManual;
        public List<GMapControl> listaDeMapas;
        private IU_RegistrarVenta _interfazVenta;
        private IU_MenuPrincipal _interfazContenedora;

        //ATRIBUTOS

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

        public IU_RegistrarOrden_4(Controlador_RegistrarOrden controlador)
        {
            InitializeComponent();
            controladorOR = controlador;
            validar = new Validaciones();
            listaRbtnManual = new List<RadioButton>();
            listaLblManual = new List<Label>();
            listaLblDistancia = new List<Label>();
            listaTxtManual = new List<TextBox>();
            listaRbtnOpcion1 = new List<RadioButton>();
            listaRbtnOpcion2 = new List<RadioButton>();
            listaRbtnOpcion3 = new List<RadioButton>();
            listaRbtnOpcion4 = new List<RadioButton>();
            listaDeMapas = new List<GMapControl>();
            InterfazVenta = new IU_RegistrarVenta();
        }

        private void IU_RegistrarOrden_4_Load(object sender, EventArgs e)
        {
            cargarTabControl();
            for (int i = 0; i < _listaEntrega.Count; i++)
            {
                mostrarRutaRecomendada(i);
            }            
        }

        //BOTONES

        private void btn_registrar_Click(object sender, EventArgs e)//Al ultimo ver como hacer para registrar
        {
            int contador = 0;
            for (int i = 0; i < _listaEntrega.Count; i++)
            {
                if (listaRbtnManual[i].Checked)
                {
                    if (!validar.campoVacio(listaTxtManual[i].Text))
                    {
                        tomarPrecioPorDistancia(i);
                        contador++;
                    }
                }                                 
                else
                {
                    tomarPrecioPorDistancia(i);
                    contador++;
                    
                }
            }
            if (contador==_listaEntrega.Count)
            {
                tomarConfirmacionOrden();
            }
            else
            {
                MessageBox.Show(this, "Debe ingresar el precio del envío en la opcion Manual", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            controladorOR.iu_registrarOrden1.Owner.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            controladorOR.iu_registrarOrden3.Show();
        }

        //METODOS

        public void tomarPrecioPorDistancia(int viaje)
        {
            if (listaRbtnOpcion1[viaje].Checked)
                controladorOR.precioPorDistancia(100f, viaje);
            else if (listaRbtnOpcion2[viaje].Checked)
                controladorOR.precioPorDistancia(200f, viaje);
            else if (listaRbtnOpcion3[viaje].Checked)
                controladorOR.precioPorDistancia(300f, viaje);
            else if (listaRbtnOpcion4[viaje].Checked)
                controladorOR.precioPorDistancia(400f, viaje);
            else 
            {
                controladorOR.precioPorDistancia(float.Parse(listaTxtManual[viaje].Text), viaje);
            }       
        }

        public void tomarConfirmacionOrden()
        {
            if (controladorOR.Venta.CodigoVenta==0) 
            {
                if (controladorOR.ControladorRVM.razonSocial!=null)
                {
                    //Hilo proveniente de venta mayorista
                    controladorOR.ControladorRVM.tomarRegistroOrdenRemito(controladorOR.EntregaColeccion, controladorOR.DetalleLogistica);
                    Close();
                    controladorOR.iu_registrarOrden1.Owner.Show();//Regresa a la interfaz de venta
                }
                else
                {
                    //Hilo proveniente de venta minorista
                    controladorOR.ControladorRV.tomarRegistroOrdenRemito(controladorOR.EntregaColeccion, controladorOR.DetalleLogistica);
                    Close();
                    controladorOR.iu_registrarOrden1.Owner.Show();//Regresa a la interfaz de venta
                }                
            }
            else //Hilo desde Menu de Ventas
            {                
                //ACA DEBO LLAMAR A VENTA PARA FACTURAR EL ENVIO
                controladorOR.iu_registrarVenta = new IU_RegistrarVenta();
                controladorOR.iu_registrarVenta.opcionRegistrarVenta(controladorOR.EntregaColeccion);
                controladorOR.iu_registrarVenta.InterfazContenedora = InterfazContenedora;
                controladorOR.iu_registrarVenta.ShowDialog();

                //ACA DEBO PREGUNTAR POR SI REALIZO O NO LA VENTA Y DE ACUERDO A LA SALIDA HACER O NO EL REGISTRO DE LA ORDEN DE REMITO
                if (controladorOR.iu_registrarVenta.ventaRegistrada)
                {
                    //LA SIGUIENTE LINEA DE CODIGO HACE EL REGISTRO DE LA ORDEN DE REMITO
                    controladorOR.generarOrdenPorViaje(controladorOR.buscarUltimoNroEntrega());
                    MessageBox.Show(this, "La Entrega se registro correctamente", "ORDEN DE REMITO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "No se realizó correctamente la facturación", "ORDEN DE REMITO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        public void mostrarRutaRecomendada(int viaje)
        {            
            listaDeMapas[viaje].MapProvider= GoogleMapProvider.Instance;
            //gMapControl2.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            listaDeMapas[viaje].SetPositionByKeywords("Cordoba, Argentina");
            //gMapControl2.SetPositionByKeywords("Cordoba, Argentina");
            listaDeMapas[viaje].ShowCenter = false;
            //gMapControl2.ShowCenter = false;
            listaDeMapas[viaje].DragButton = MouseButtons.Left;
            //gMapControl2.DragButton = MouseButtons.Left;
            listaDeMapas[viaje].CanDragMap = true;
            //gMapControl2.CanDragMap = true;
            listaDeMapas[viaje].AutoScroll = true;
            //gMapControl2.AutoScroll = true;

            //CREO CAPA DE MARCADORES             
            GMapOverlay marcadores = new GMapOverlay("capaMarcador");
            //MARCADOR DE INICIO   
            PointLatLng laObra = new PointLatLng(-31.4671849, -64.2239958);
            GMarkerGoogle puntoInicioViaje = new GMarkerGoogle(laObra, GMarkerGoogleType.blue);
            puntoInicioViaje.ToolTipMode = MarkerTooltipMode.Always;
            puntoInicioViaje.ToolTipText = string.Format("Ferretería \n LA OBRA \n de Mario Labarre");
            //MARCADOR DE FIN
            GeoCoderStatusCode status = new GeoCoderStatusCode();
            string hasta = controladorOR.EntregaColeccion[viaje].NombreCalle + ", " + controladorOR.EntregaColeccion[viaje].NumeroCalle + ", " + controladorOR.EntregaColeccion[viaje].NombreProvincia + ", Argentina";
            var puntoFin = GMapProviders.GoogleMap.GetPoint(hasta, out status);
            if (puntoFin==null)
            {
                puntoFin = laObra;
                GMarkerGoogle puntoFinViaje = new GMarkerGoogle(puntoFin.Value, GMarkerGoogleType.red);
                puntoFinViaje.ToolTipMode = MarkerTooltipMode.Always;
                puntoFinViaje.ToolTipText = string.Format(controladorOR.EntregaColeccion[viaje].NombreCliente);
                //AGREGO MARCADORES A LA CAPA
                marcadores.Markers.Add(puntoInicioViaje);
                marcadores.Markers.Add(puntoFinViaje);
                listaDeMapas[viaje].Overlays.Add(marcadores);
                //gMapControl2.Overlays.Add(marcadores);

                GMapOverlay capaRuta = new GMapOverlay("Capa de la ruta");
                capaRuta.Routes.Add(controladorOR.buscarRutaRecomendada(viaje));
                listaDeMapas[viaje].Overlays.Add(capaRuta);
                //gMapControl2.Overlays.Add(capaRuta);
                listaDeMapas[viaje].ZoomAndCenterRoutes("Capa de la ruta");
                //gMapControl2.ZoomAndCenterRoutes("Capa de la ruta");
            }
            else
            {
                GMarkerGoogle puntoFinViaje = new GMarkerGoogle(puntoFin.Value, GMarkerGoogleType.red);
                puntoFinViaje.ToolTipMode = MarkerTooltipMode.Always;
                puntoFinViaje.ToolTipText = string.Format(controladorOR.EntregaColeccion[viaje].NombreCliente);
                //AGREGO MARCADORES A LA CAPA
                marcadores.Markers.Add(puntoInicioViaje);
                marcadores.Markers.Add(puntoFinViaje);
                listaDeMapas[viaje].Overlays.Add(marcadores);
                //gMapControl2.Overlays.Add(marcadores);

                GMapOverlay capaRuta = new GMapOverlay("Capa de la ruta");
                capaRuta.Routes.Add(controladorOR.buscarRutaRecomendada(viaje));
                listaDeMapas[viaje].Overlays.Add(capaRuta);
                //gMapControl2.Overlays.Add(capaRuta);
                listaDeMapas[viaje].ZoomAndCenterRoutes("Capa de la ruta");
                //gMapControl2.ZoomAndCenterRoutes("Capa de la ruta");
            }
        }

        private void cargarTabControl()
        {
            _listaEntrega = controladorOR.EntregaColeccion;
            for (int i = 0; i < controladorOR.EntregaColeccion.Count; i++)
            {
                string title = "Viaje " + (tabControl1.TabCount + 1).ToString();
                TabPage miTabPage = new TabPage(title);
                tabControl1.TabPages.Add(miTabPage);
                crearControlesDinamicosTabPage(miTabPage, i);
            }
        }

        private void crearControlesDinamicosTabPage(TabPage tabpage, int viaje)
        {
            listaDeMapas.Add(new GMapControl());            
            Label lbl_4 = new Label();
            GroupBox gb_distancia = new GroupBox();
            listaTxtManual.Add(new TextBox());            
            listaLblManual.Add(new Label());
            listaRbtnManual.Add(new RadioButton());
            listaRbtnOpcion4.Add(new RadioButton());
            listaRbtnOpcion3.Add(new RadioButton());
            listaRbtnOpcion2.Add(new RadioButton());
            listaRbtnOpcion1.Add(new RadioButton());            
            Label lbl_14 = new Label();
            Label lbl_distancia = new Label();
            gb_distancia.SuspendLayout();
            SuspendLayout();            
            // 
            // gMapControl2
            // 
            listaDeMapas[viaje].Bearing = 0F;
            listaDeMapas[viaje].CanDragMap = true;
            listaDeMapas[viaje].EmptyTileColor = Color.Navy;
            listaDeMapas[viaje].GrayScaleMode = false;
            listaDeMapas[viaje].HelperLineOption = HelperLineOptions.DontShow;
            listaDeMapas[viaje].LevelsKeepInMemmory = 5;
            listaDeMapas[viaje].Location = new Point(335, 37);
            listaDeMapas[viaje].MarkersEnabled = true;
            listaDeMapas[viaje].MaxZoom = 18;
            listaDeMapas[viaje].MinZoom = 2;
            listaDeMapas[viaje].MouseWheelZoomEnabled = true;
            listaDeMapas[viaje].MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            listaDeMapas[viaje].Name = "gMapControl2";
            listaDeMapas[viaje].NegativeMode = false;
            listaDeMapas[viaje].PolygonsEnabled = true;
            listaDeMapas[viaje].RetryLoadTile = 0;
            listaDeMapas[viaje].RoutesEnabled = true;
            listaDeMapas[viaje].ScaleMode = ScaleModes.Integer;
            listaDeMapas[viaje].SelectedAreaFillColor = Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            listaDeMapas[viaje].ShowTileGridLines = false;
            listaDeMapas[viaje].Size = new Size(437, 197);
            listaDeMapas[viaje].TabIndex = 29;
            listaDeMapas[viaje].Zoom = 13D;
            // 
            // lbl_4
            // 
            lbl_4.AutoSize = true;
            lbl_4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_4.Location = new Point(331, 12);
            lbl_4.Name = "lbl_4";
            lbl_4.Size = new Size(162, 20);
            lbl_4.TabIndex = 27;
            lbl_4.Text = "Ruta recomendada";
            // 
            // gb_distancia
            // 
            gb_distancia.BackColor = SystemColors.GradientActiveCaption;
            gb_distancia.Controls.Add(listaTxtManual[viaje]);
            gb_distancia.Controls.Add(listaLblManual[viaje]);
            gb_distancia.Controls.Add(listaRbtnManual[viaje]);
            gb_distancia.Controls.Add(listaRbtnOpcion4[viaje]);
            gb_distancia.Controls.Add(listaRbtnOpcion3[viaje]);
            gb_distancia.Controls.Add(listaRbtnOpcion2[viaje]);
            gb_distancia.Controls.Add(listaRbtnOpcion1[viaje]);
            gb_distancia.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            gb_distancia.Location = new Point(12, 12);
            gb_distancia.Name = "gb_distancia";
            gb_distancia.Size = new Size(307, 222);
            gb_distancia.TabIndex = 30;
            gb_distancia.TabStop = false;
            gb_distancia.Text = "Seleccionar distancia";
            // 
            // txt_precioManual
            // 
            listaTxtManual[viaje].Location = new Point(131, 179);
            listaTxtManual[viaje].Name = "txt_precioManual";
            listaTxtManual[viaje].Size = new Size(131, 22);
            listaTxtManual[viaje].TabIndex = 6;
            listaTxtManual[viaje].Visible = false;
            listaTxtManual[viaje].KeyPress += new KeyPressEventHandler(txt_precioManual_KeyPress);
            // 
            // label1
            // 
            listaLblManual[viaje].AutoSize = true;
            listaLblManual[viaje].Location = new Point(14, 182);
            listaLblManual[viaje].Name = "label1";
            listaLblManual[viaje].Size = new Size(111, 16);
            listaLblManual[viaje].TabIndex = 5;
            //lo hago invisible al principio
            listaLblManual[viaje].Visible = false;
            listaLblManual[viaje].Text = "Ingrese el precio:";
            // 
            // rbt_opcionManual
            // 
            listaRbtnManual[viaje].AutoSize = true;
            listaRbtnManual[viaje].Location = new Point(17, 145);
            listaRbtnManual[viaje].Name = "rbt_opcionManual";
            listaRbtnManual[viaje].Size = new Size(159, 20);
            listaRbtnManual[viaje].TabIndex = 4;
            listaRbtnManual[viaje].TabStop = true;
            listaRbtnManual[viaje].Text = "Ingresar manualmente";
            if (_listaEntrega[viaje].DistanciaEntrega > 28)
            {
                listaRbtnManual[viaje].Checked = true;
                listaLblManual[tabControl1.SelectedIndex].Visible = true;
                listaTxtManual[tabControl1.SelectedIndex].Visible = true;

                //se agrega a pedido de la profesora
                listaRbtnOpcion1[viaje].Enabled = false;
                listaRbtnOpcion2[viaje].Enabled = false;
                listaRbtnOpcion3[viaje].Enabled = false;
                listaRbtnOpcion4[viaje].Enabled = false;
            }
            else
            {
                listaRbtnManual[viaje].Checked = false;
            }
            listaRbtnManual[viaje].UseVisualStyleBackColor = true;
            listaRbtnManual[viaje].CheckedChanged += new EventHandler(rbt_opcionManual_CheckedChanged);
            // 
            // rbt_opcion4
            // 
            listaRbtnOpcion4[viaje].AutoSize = true;
            listaRbtnOpcion4[viaje].Location = new Point(17, 115);
            listaRbtnOpcion4[viaje].Name = "rbt_opcion4";
            listaRbtnOpcion4[viaje].Size = new Size(124, 20);
            listaRbtnOpcion4[viaje].TabIndex = 3;
            listaRbtnOpcion4[viaje].TabStop = true;
            listaRbtnOpcion4[viaje].Text = "21 - 28 Km $400";
            if (_listaEntrega[viaje].DistanciaEntrega > 21 && _listaEntrega[viaje].DistanciaEntrega <= 28)
            {
                listaRbtnOpcion4[viaje].Checked = true;

                //se agrega a pedido de la profesora
                listaRbtnOpcion1[viaje].Enabled = false;
                listaRbtnOpcion2[viaje].Enabled = false;
                listaRbtnOpcion3[viaje].Enabled = false;
            }
            else
            {
                listaRbtnOpcion4[viaje].Checked = false;
            }
            listaRbtnOpcion4[viaje].UseVisualStyleBackColor = true;
            listaRbtnOpcion4[viaje].CheckedChanged += new EventHandler(rbt_opcion4_CheckedChanged);
            // 
            // rbt_opcion3
            // 
            listaRbtnOpcion3[viaje].AutoSize = true;
            listaRbtnOpcion3[viaje].Location = new Point(17, 85);
            listaRbtnOpcion3[viaje].Name = "rbt_opcion3";
            listaRbtnOpcion3[viaje].Size = new Size(117, 20);
            listaRbtnOpcion3[viaje].TabIndex = 2;
            listaRbtnOpcion3[viaje].TabStop = true;
            listaRbtnOpcion3[viaje].Text = "14 - 21 Km $300";
            if (_listaEntrega[viaje].DistanciaEntrega > 14 && _listaEntrega[viaje].DistanciaEntrega <= 21)
            {
                listaRbtnOpcion3[viaje].Checked = true;

                //se agrega a pedido de la profesora
                listaRbtnOpcion1[viaje].Enabled = false;
                listaRbtnOpcion2[viaje].Enabled = false;
                listaRbtnOpcion4[viaje].Enabled = false;
            }
            else
            {
                listaRbtnOpcion3[viaje].Checked = false;
            }
            listaRbtnOpcion3[viaje].UseVisualStyleBackColor = true;
            listaRbtnOpcion3[viaje].CheckedChanged += new EventHandler(rbt_opcion3_CheckedChanged);
            // 
            // rbt_opcion2
            // 
            listaRbtnOpcion2[viaje].AutoSize = true;
            listaRbtnOpcion2[viaje].Location = new Point(17, 55);
            listaRbtnOpcion2[viaje].Name = "rbt_opcion2";
            listaRbtnOpcion2[viaje].Size = new Size(117, 20);
            listaRbtnOpcion2[viaje].TabIndex = 1;
            listaRbtnOpcion2[viaje].TabStop = true;
            listaRbtnOpcion2[viaje].Text = "7 - 14 Km $200";
            if (_listaEntrega[viaje].DistanciaEntrega > 7 && _listaEntrega[viaje].DistanciaEntrega <= 14)
            {
                listaRbtnOpcion2[viaje].Checked = true;

                //se agrega a pedido de la profesora
                listaRbtnOpcion1[viaje].Enabled = false;
                listaRbtnOpcion3[viaje].Enabled = false;
                listaRbtnOpcion4[viaje].Enabled = false;
            }
            else
            {
                listaRbtnOpcion2[viaje].Checked = false;
            }
            listaRbtnOpcion2[viaje].UseVisualStyleBackColor = true;
            listaRbtnOpcion2[viaje].CheckedChanged += new EventHandler(rbt_opcion2_CheckedChanged);
            // 
            // rbt_opcion1
            // 
            listaRbtnOpcion1[viaje].AutoSize = true;
            listaRbtnOpcion1[viaje].Location = new Point(17, 25);
            listaRbtnOpcion1[viaje].Name = "rbt_opcion1";
            listaRbtnOpcion1[viaje].Size = new Size(110, 20);
            listaRbtnOpcion1[viaje].TabIndex = 0;
            listaRbtnOpcion1[viaje].TabStop = true;
            listaRbtnOpcion1[viaje].Text = "0 - 7 Km $100";
            if (_listaEntrega[viaje].DistanciaEntrega>=0&& _listaEntrega[viaje].DistanciaEntrega<=7)
            {
                listaRbtnOpcion1[viaje].Checked = true;

                //se agrega a pedido de la profesora
                listaRbtnOpcion2[viaje].Enabled = false;
                listaRbtnOpcion3[viaje].Enabled = false;
                listaRbtnOpcion4[viaje].Enabled = false;
            }
            else
            {
                listaRbtnOpcion1[viaje].Checked = false;
            }
            listaRbtnOpcion1[viaje].UseVisualStyleBackColor = true;
            listaRbtnOpcion1[viaje].CheckedChanged += new EventHandler(rbt_opcion1_CheckedChanged);
            // 
            // lbl_14
            // 
            lbl_14.AutoSize = true;
            lbl_14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_14.Location = new Point(512, 12);
            lbl_14.Name = "lbl_14";
            lbl_14.Size = new Size(175, 20);
            lbl_14.TabIndex = 31;
            lbl_14.Text = "Cantidad de kilómetros:";            
            // 
            // lbl_distancia
            // 
            lbl_distancia.AutoSize = true;
            lbl_distancia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_distancia.Location = new Point(679, 12);
            lbl_distancia.Name = "lbl_distancia";
            lbl_distancia.Size = new Size(0, 20);
            lbl_distancia.TabIndex = 32;
            lbl_distancia.Text= controladorOR.EntregaColeccion[viaje].DistanciaEntrega.ToString("0.00 km");
            listaLblDistancia.Add(new Label());
            // 
            // TabControl1
            //
            tabpage.Controls.Add(lbl_distancia);
            tabpage.Controls.Add(lbl_14);
            tabpage.Controls.Add(gb_distancia);
            tabpage.Controls.Add(listaDeMapas[viaje]);
            tabpage.Controls.Add(lbl_4);            
        }

        //EVENTOS

        private void rbt_opcionManual_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn_Actual = sender as RadioButton;
            if (rbtn_Actual.Checked)
            {                
                listaLblManual[tabControl1.SelectedIndex].Visible = true;
                listaTxtManual[tabControl1.SelectedIndex].Visible = true;
            }
        }

        private void rbt_opcion1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn_Actual = sender as RadioButton;
            if (rbtn_Actual.Checked)
            {
                listaLblManual[tabControl1.SelectedIndex].Visible = false;
                listaTxtManual[tabControl1.SelectedIndex].Visible = false;
            }
        }

        private void rbt_opcion2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn_Actual = sender as RadioButton;
            if (rbtn_Actual.Checked)
            {
                listaLblManual[tabControl1.SelectedIndex].Visible = false;
                listaTxtManual[tabControl1.SelectedIndex].Visible = false;
            }
        }

        private void rbt_opcion3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn_Actual = sender as RadioButton;
            if (rbtn_Actual.Checked)
            {
                listaLblManual[tabControl1.SelectedIndex].Visible = false;
                listaTxtManual[tabControl1.SelectedIndex].Visible = false;
            }
        }

        private void rbt_opcion4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn_Actual = sender as RadioButton;
            if (rbtn_Actual.Checked)
            {
                listaLblManual[tabControl1.SelectedIndex].Visible = false;
                listaTxtManual[tabControl1.SelectedIndex].Visible = false;
            }
        }

        private void txt_precioManual_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloDecimales(e);
        }
    }
}
