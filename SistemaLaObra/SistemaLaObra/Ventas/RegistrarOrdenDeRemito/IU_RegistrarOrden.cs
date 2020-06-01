using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra.Properties;

namespace SistemaLaObra.Ventas.OrdenDeRemito
{
    public partial class IU_RegistrarOrden : Form
    {
        //INSTANCIAS
        private Controlador_RegistrarOrden controladorOR;
        private Venta venta;
        private List<DetalleVP> detalleVenta;
        private DetalleLogistica detalleLogistica;
        private Validaciones validacion;
        private List<Button> btn_viaje;
        private IU_MenuPrincipal _interfazContenedora;
        public List<Label> lbl_viaje;

        //VARIABLE GLOBAL EN LA INTERFAZ
        private int _cantidadDeEnvios;

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



        //CONSTRUCTOR
        public IU_RegistrarOrden()
        {
            InitializeComponent();
            controladorOR = new Controlador_RegistrarOrden(this);
            venta = new Venta();
            detalleLogistica = new DetalleLogistica();
            detalleVenta = new List<DetalleVP>();                       
            validacion = new Validaciones();
            btn_viaje = new List<Button>();
            lbl_viaje = new List<Label>();
            InterfazContenedora = new IU_MenuPrincipal();
        }

        private void IU_RegistrarOrden_Load(object sender, EventArgs e)
        {            
            btn_siguiente.Enabled = false;          
            gbx_datos.Enabled = false;
                     
        }

        //BOTONES

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (validacion.campoVacio(txt_cantidadEnvios.Text))
            {
                MessageBox.Show(this, "Debe ingresar la cantidad de envíos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(txt_cantidadEnvios.Text) < 1)
            {
                MessageBox.Show(this, "La cantidad mínima de envíos es uno", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(txt_cantidadEnvios.Text) > 15)
            {
                MessageBox.Show(this, "La cantidad máxima de envíos es quince", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validacion.campoVacio(txt_codigoVenta.Text))
            {
                if (detalleVenta.Count==0)
                {
                    MessageBox.Show(this, "Debe ingresar un codigo de venta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (detalleVenta.Count < int.Parse(txt_cantidadEnvios.Text))
                    {
                        MessageBox.Show(this, "La cantidad de envíos es mayor a la de artículos del mismo tipo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Por aca va el hilo que viene desde la interfaz de venta                    
                        tomarCantidadEnvios();
                        controladorOR.cantidadEnvios(_cantidadDeEnvios);
                        txt_cantidadEnvios.Visible = true;
                        gbx_datos.Enabled = true;
                        borrarEntrada();
                        crearBotonesDinamicos(_cantidadDeEnvios);
                        mostrarFleteAnimado();
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                    }                    
                }
            }
            else
            {
                //Por aca va el hilo que viene desde el menu
                tomarNroVenta(int.Parse(txt_codigoVenta.Text));
                controladorOR.nroVenta(venta);
                if (controladorOR.verificarNroVenta())
                {
                    if (controladorOR.verificarExistenciaEntrega(controladorOR.Venta.CodigoVenta) == true)
                    {
                        MessageBox.Show(this, "La venta ingresada posee entregas asociadas ingrese al menú modificar envíos desde el menú de ventas si desea modificar la entrega", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //agregar validacion de si existe detalle de venta
                    else if (venta.conocerDetalleVP(venta.CodigoVenta).Count==0)
                    {
                        MessageBox.Show(this, "La venta ingresada no posee artículos para enviar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                    
                    else
                    {
                        controladorOR.Venta.mostrarDatos(venta.CodigoVenta);
                        //detalleVenta = venta.conocerDetalleVP(venta.CodigoVenta);
                        detalleVenta = venta.DetalleVP;
                        controladorOR.tomarDetalleVenta(detalleVenta);
                        tomarCantidadEnvios();
                        controladorOR.cantidadEnvios(_cantidadDeEnvios);
                        if (detalleVenta.Count < int.Parse(txt_cantidadEnvios.Text))
                        {
                            MessageBox.Show(this, "La cantidad de envíos es mayor a la de artículos del mismo tipo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txt_cantidadEnvios.Visible = true;
                            gbx_datos.Enabled = true;
                            borrarEntrada();
                            crearBotonesDinamicos(_cantidadDeEnvios);
                            mostrarFleteAnimado();
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                        }                        
                    }                    
                }
                else
                {
                    MessageBox.Show(this, "No existe la venta ingresada", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }                                                                      

        }
        
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            controladorOR.interfazCargarFechaHora();
        }

        //METODOS
        
        //sobrecarga para el hilo de venta minorista
        public void opcionEnvioDomicilio(Controlador_Venta controladorRV)
        {
            controladorOR.tomarVenta(controladorRV);
            lbl_importeParcial.Text = "$ " + controladorRV.venta.ImporteTotal.ToString("0.00");

            lbl_1.Visible = false;
            txt_codigoVenta.Visible = false;
            label1.Visible = true;
            lbl_importeParcial.Visible = true;
            detalleVenta = controladorRV.listaDetalle;
            controladorOR.tomarDetalleVenta(detalleVenta);                        
            verEntrada();        
        }

        //sobrecarga para el hilo de venta mayorista
        public void opcionEnvioDomicilio(Controlador_VentaMayorista controladorRVM)
        {
            controladorOR.tomarVenta(controladorRVM);
            lbl_importeParcial.Text = "$ " + controladorRVM.venta.ImporteTotal.ToString("0.00");

            lbl_1.Visible = false;
            txt_codigoVenta.Visible = false;
            label1.Visible = true;
            lbl_importeParcial.Visible = true;
            detalleVenta = controladorRVM.listaDetalle;
            controladorOR.tomarDetalleVenta(detalleVenta);
            verEntrada();
        }

        //sobrecarga para el menu de ventas
        public void opcionEnvioDomicilio()
        {                        
            label1.Visible = false;
            lbl_importeParcial.Visible = false;
            lbl_1.Visible = true;
            txt_codigoVenta.Visible = true;
            controladorOR.ControladorRVM = new Controlador_VentaMayorista();
            controladorOR.ControladorRV = new Controlador_Venta();
            controladorOR.InterfazContenedora = InterfazContenedora;
        }

        public void tomarNroVenta(int nroVenta)
        {            
            venta.CodigoVenta = nroVenta;
        }

        public void tomarCantidadEnvios()
        {
            _cantidadDeEnvios = int.Parse(txt_cantidadEnvios.Text);
        }



        //METODOS PRIVADOS

        private void crearBotonesDinamicos(int cantidadEnvios)
        {
            int y = 5;
            for (int i = 0; i < cantidadEnvios; i++)
            {
                //BOTONES DINAMICOS
                btn_viaje.Add(new Button() {
                    Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    Image = Image.FromFile("images/btn_camion.png"),
                    ImageAlign = ContentAlignment.TopLeft,
                    Location = new Point(10, y),
                    Name = "btn_viaje" + i,
                    Size = new Size(113, 65),
                    TabIndex = 0 + i,
                    Text = "Viaje " + (i+1),
                    TextAlign= ContentAlignment.BottomCenter,
                    TextImageRelation= TextImageRelation.TextAboveImage,
                    UseVisualStyleBackColor=true
                });                
                pnl_datosEnvio.Controls.Add(btn_viaje[i]);
                btn_viaje[i].Click += new EventHandler(cargarDatos);
                //LABELS DINAMICAS
                lbl_viaje.Add(new Label() {
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 13.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    Location = new Point(135, (y+25)),
                    Name = "lbl_viaje" + i,
                    Size = new Size(400,20),
                    Text="",
                    
                });
                pnl_datosEnvio.Controls.Add(lbl_viaje[i]);
                y = y+70;
            }
            
        }

        private void mostrarFleteAnimado()
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile("images/fleteAnimado.gif");
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(750, 75);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            Controls.Add(pictureBox1);
        }

        private void borrarEntrada()
        {
            lbl_1.Visible = false;
            lbl_2.Visible = false;
            lbl_importeParcial.Visible = false;
            label1.Visible = false;
            txt_codigoVenta.Visible = false;
            txt_cantidadEnvios.Visible = false;
            btn_confirmar.Visible = false;
        }

        private void verEntrada()
        {
            label1.Visible = true;
            lbl_importeParcial.Visible = true;
            lbl_1.Visible = false;
            lbl_2.Visible = true;
            txt_codigoVenta.Visible = false;
            txt_cantidadEnvios.Visible = true;
            btn_confirmar.Visible = true;
        }

        //EVENTOS

        private void txt_codigoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txt_cantidadEnvios_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void cargarDatos(object sender, EventArgs e)
        {
            Button btn_actual = sender as Button;
            controladorOR.interfazCargarDireccion(btn_actual.Name);            
        }
    }
}
