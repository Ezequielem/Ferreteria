using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.OrdenDeRemito
{
    public partial class IU_RegistrarOrden_2 : Form
    {
        //REFERENCIA
        private Controlador_RegistrarOrden controladorOR;

        //INSTANCIAS
        private List<Entrega> _listaEntrega;
        public List<DateTimePicker> fechaEntrega;
        public List<DateTimePicker> horaInicio;
        public List<DateTimePicker> horaFin;

        //int codigo = 0;

        public IU_RegistrarOrden_2(Controlador_RegistrarOrden controlador)
        {
            InitializeComponent();
            controladorOR = controlador;
            fechaEntrega = new List<DateTimePicker>();
            horaInicio = new List<DateTimePicker>();
            horaFin = new List<DateTimePicker>();
        }

        private void IU_RegistrarOrden_2_Load(object sender, EventArgs e)
        {
            cargarTabControl();
        }

        //BOTONES

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            cargarPropiedadesEntregaAColeccion();                    
            controladorOR.interfazCargarArticulosPorViaje();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            controladorOR.cerrarInterfazCargarFechaHora();
            controladorOR.iu_registrarOrden1.Close();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            controladorOR.cerrarInterfazCargarFechaHora();
        }

        //METODOS

        private void cargarTabControl()
        {
            _listaEntrega = controladorOR.EntregaColeccion;
            for (int i = 0; i < controladorOR.EntregaColeccion.Count; i++)
            {
                string title = "Viaje " + (tabControl1.TabCount + 1).ToString();
                TabPage miTabPage = new TabPage(title);
                tabControl1.TabPages.Add(miTabPage);
                rellenarTabControl(miTabPage);                
            }            
        }

        private void rellenarTabControl(TabPage tabPage)
        {
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(117, 16);
            label1.TabIndex = 0;
            label1.Text = "Fecha de entrega:";
            tabPage.Controls.Add(label1);

            DateTimePicker dtp_fechaEntrega = new DateTimePicker();
            dtp_fechaEntrega.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtp_fechaEntrega.Location = new Point(173, 40);
            dtp_fechaEntrega.Name = "dtp_fechaEntrega";
            dtp_fechaEntrega.Size = new Size(242, 22);            
            dtp_fechaEntrega.TabIndex = 1;
            tabPage.Controls.Add(dtp_fechaEntrega);
            //AGREGO CONTROL A LISTA
            fechaEntrega.Add(dtp_fechaEntrega);
            //AGREGO EVENTO AL CONTROL
            dtp_fechaEntrega.ValueChanged += new EventHandler(tomarFechaPorViaje);

            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(50, 90);
            label2.Name = "label2";
            label2.Size = new Size(165, 16);
            label2.TabIndex = 2;
            label2.Text = "Rango horario de entrega:";
            tabPage.Controls.Add(label2);

            Label label3 = new Label();
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new Point(50, 120);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 3;
            label3.Text = "Desde:";
            tabPage.Controls.Add(label3);

            DateTimePicker dtp_horaDesde = new DateTimePicker();
            dtp_horaDesde.Format = DateTimePickerFormat.Time;
            dtp_horaDesde.Location = new Point(112, 116);
            dtp_horaDesde.Name = "dtp_horaDesde";
            dtp_horaDesde.Size = new Size(103, 20);
            dtp_horaDesde.TabIndex = 4;
            dtp_horaDesde.ShowUpDown = true;   
            dtp_horaDesde.Value = new System.DateTime(2017, 9, 1, 9, 0, 0, 0);
            tabPage.Controls.Add(dtp_horaDesde);
            //AGREGO CONTROL A LISTA
            horaInicio.Add(dtp_horaDesde);
            //AGREGO EVENTO AL CONTROL
            dtp_horaDesde.ValueChanged += new EventHandler(tomarHoraDesdePorViaje);

            DateTimePicker dtp_horaHasta = new DateTimePicker();
            dtp_horaHasta.Format = DateTimePickerFormat.Time;
            dtp_horaHasta.Location = new Point(312, 116);
            dtp_horaHasta.Name = "dateTimePicker1";
            dtp_horaHasta.Size = new Size(103, 20);
            dtp_horaHasta.TabIndex = 6;
            dtp_horaHasta.ShowUpDown = true;
            dtp_horaHasta.Value= new System.DateTime(2017, 9, 1, 17, 0, 0, 0);
            tabPage.Controls.Add(dtp_horaHasta);
            //AGREGO CONTROL A LISTA
            horaFin.Add(dtp_horaHasta);
            //AGREGO EVENTO AL CONTROL
            dtp_horaHasta.ValueChanged += new EventHandler(tomarHoraHastaPorViaje);

            Label label4 = new Label();
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new Point(259, 120);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 5;
            label4.Text = "Hasta:";
            tabPage.Controls.Add(label4);            
        }       

        private void cargarPropiedadesEntregaAColeccion()
        {
            for (int i = 0; i < _listaEntrega.Count; i++)
            {
                _listaEntrega[i].FechaEntrega = fechaEntrega[i].Value;
                _listaEntrega[i].HoraEntregaDesde = horaInicio[i].Value;
                _listaEntrega[i].HoraEntregaHasta = horaFin[i].Value;
            }
            controladorOR.fechaPorViaje(_listaEntrega);
            controladorOR.horaDesdePorViaje(_listaEntrega);
            controladorOR.horaDesdePorViaje(_listaEntrega);
        }


        //EVENTOS

        private void tomarFechaPorViaje(object sender, EventArgs e)
        {
            DateTimePicker dtp_actual = sender as DateTimePicker;
            if (dtp_actual.Value.Date>=DateTime.Today)
            {
                _listaEntrega[tabControl1.SelectedIndex].FechaEntrega = dtp_actual.Value;                
            }
            else
            {
                dtp_actual.Value = DateTime.Today;
                MessageBox.Show(this, "Debe ingresar un fecha posterior a la actual", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);       
            }                                           
        }

        private void tomarHoraDesdePorViaje(object sender, EventArgs e)
        {
            DateTimePicker dtp_actual = sender as DateTimePicker;
            _listaEntrega[tabControl1.SelectedIndex].HoraEntregaDesde = dtp_actual.Value;          
        }

        private void tomarHoraHastaPorViaje(object sender, EventArgs e)
        {
            DateTimePicker dtp_actual = sender as DateTimePicker;
            _listaEntrega[tabControl1.SelectedIndex].HoraEntregaHasta = dtp_actual.Value;
        }        
    }
}
