using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLaObra.Ventas.CobroConTarjeta;

namespace SistemaLaObra.Ventas.CobroConTarjeta
{
    public partial class IU_InfoTarjeta : Form
    {
        //Instancias
        List<Tarjeta> listaTarjeta;
        Tarjeta claseTarjeta;
      
        private List<Label> _importeTotalCobrado;
        private List<Label> _tarjeta;
        private List<Label> _tipoTarjeta;
        private List<Label> _numeroTarjeta;
        private List<Label> _nombre;
        private List<Label> _interesGenerado;
        private List<Label> _interesPorcentaje;
        private List<Label> _cuota;

        private int codigoTarjeta = 0;
 
        

        public IU_InfoTarjeta(List<Tarjeta> tar)
        {
            InitializeComponent();

            listaTarjeta = tar;
            _importeTotalCobrado = new List<Label>();
            _tarjeta = new List<Label>();
            _tipoTarjeta = new List<Label>();
            _numeroTarjeta = new List<Label>();
            _nombre = new List<Label>();
            _interesGenerado = new List<Label>();
           _interesPorcentaje = new List<Label>();
            _cuota = new List<Label>();


            cargarTabControl();
           cargarDetalles(tar);
        }

        private void cargarTabControl()
        {
            for (int i = 0; i < listaTarjeta.Count ; i++)
            {
                string title = "Tarjeta " + (tabControl1.TabCount + 1).ToString();
                TabPage miTabPage = new TabPage(title);
                tabControl1.TabPages.Add(miTabPage);
                rellenarTabControl(miTabPage);
            }
        }

     

        private void rellenarTabControl(TabPage tabPage)
        {
            //nombreTitular
            Label lbl_nombre = new Label();
            lbl_nombre.AutoSize = false;
            lbl_nombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_nombre.Location = new Point(3, 10);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(145, 20);
            lbl_nombre.Text = "Nombre Titular:";

            //dato nombre titular
            Label lbl_nombreActual = new Label();
            lbl_nombreActual.AutoSize = false;
            lbl_nombreActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_nombreActual.Location = new Point(150, 10);
            lbl_nombreActual.Name = "lbl_nombreActual";
            lbl_nombreActual.Size = new Size(150, 20);
            lbl_nombreActual.Text = "";

            //tarjeta
            Label lbl_tarjeta = new Label();
            lbl_tarjeta.AutoSize = false;
            lbl_tarjeta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_tarjeta.Location = new Point(3, 40);
            lbl_tarjeta.Name = "lbl_tarjeta";
            lbl_tarjeta.Size = new Size(100, 30);
            lbl_tarjeta.Text = "Tarjeta:";


            //datosTarjeta
            Label lbl_tarjetaActual = new Label();
            lbl_tarjetaActual.AutoSize = false;
            lbl_tarjetaActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_tarjetaActual.Location = new Point(104, 40);
            lbl_tarjetaActual.Name = "lbl_tarjetaActual";
            lbl_tarjetaActual.Size = new Size(100, 20);
            lbl_tarjetaActual.Text = "";

            //tipoTarjeta
            Label lbl_tipoTarjeta = new Label();
            lbl_tipoTarjeta.AutoSize = false;
            lbl_tipoTarjeta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_tipoTarjeta.Location = new Point(3, 70);
            lbl_tipoTarjeta.Name = "lbl_tipoTarjeta";
            lbl_tipoTarjeta.Size = new Size(145, 30);
            lbl_tipoTarjeta.Text = "Tipo de Tarjeta:";

            //datosIipoTarjeta
            Label lbl_tipoTarjetaActual = new Label();
            lbl_tipoTarjetaActual.AutoSize = false;
            lbl_tipoTarjetaActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_tipoTarjetaActual.Location = new Point(150, 70);
            lbl_tipoTarjetaActual.Name = "lbl_tipoTarjetaActual";
            lbl_tipoTarjetaActual.Size = new Size(100, 20);
            lbl_tipoTarjetaActual.Text = "";

            //numeroTarjeta
            Label lbl_numeroTarjeta = new Label();
            lbl_numeroTarjeta.AutoSize = false;
            lbl_numeroTarjeta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_numeroTarjeta.Location = new Point(3, 100);
            lbl_numeroTarjeta.Name = "lbl_numeroTarjeta";
            lbl_numeroTarjeta.Size = new Size(170, 20);
            lbl_numeroTarjeta.Text = "Numero de Tarjeta:";

            //datosNumeroTarjeta
            Label lbl_numeroTarjetaActual = new Label();
            lbl_numeroTarjetaActual.AutoSize = false;
            lbl_numeroTarjetaActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_numeroTarjetaActual.Location = new Point(175, 100);
            lbl_numeroTarjetaActual.Name = "lbl_numeroTarjetaActual";
            lbl_numeroTarjetaActual.Size = new Size(300, 20);
            lbl_numeroTarjetaActual.Text = "";

            //importeCobrado
            Label lbl_importeCobrado = new Label();
            lbl_importeCobrado.AutoSize = false;
            lbl_importeCobrado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_importeCobrado.Location = new Point(3, 130);
            lbl_importeCobrado.Name = "lbl_importeCobrado";
            lbl_importeCobrado.Size = new Size(100, 20);
            lbl_importeCobrado.Text = "Importe: ";

            //datosImporteCobrado
            Label lbl_importeCobradoActual = new Label();
            lbl_importeCobradoActual.AutoSize = false;
            lbl_importeCobradoActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_importeCobradoActual.Location = new Point(104, 130);
            lbl_importeCobradoActual.Name = "lbl_importeCobradoActual";
            lbl_importeCobradoActual.Size = new Size(100, 20);
            lbl_importeCobradoActual.Text = "";

            //interesGenerado
            Label lbl_interesGenerado = new Label();
            lbl_interesGenerado.AutoSize = false;
            lbl_interesGenerado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_interesGenerado.Location = new Point(3, 160);
            lbl_interesGenerado.Name = "lbl_interesGenerado";
            lbl_interesGenerado.Size = new Size(100, 20);
            lbl_interesGenerado.Text = "Interes:";

            //datosInteresGenerado
            Label lbl_interesGeneradoActual = new Label();
            lbl_interesGeneradoActual.AutoSize = false;
            lbl_interesGeneradoActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_interesGeneradoActual.Location = new Point(104, 160);
            lbl_interesGeneradoActual.Name = "lbl_interesGeneradoActual";
            lbl_interesGeneradoActual.Size = new Size(100, 30);
            lbl_interesGeneradoActual.Text = "";           
            
            //interesPorcentaje
            Label lbl_interesPorcentaje = new Label();
            lbl_interesPorcentaje.AutoSize = false;
            lbl_interesPorcentaje.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_interesPorcentaje.Location = new Point(3, 190);
            lbl_interesPorcentaje.Name = "lbl_interesPorcentaje";
            lbl_interesPorcentaje.Size = new Size(189, 20);
            lbl_interesPorcentaje.Text = "Porcentaje de Interes: ";

            //DatosInteresPorcentaje
            Label lbl_interesPorcentajeActual = new Label();
            lbl_interesPorcentajeActual.AutoSize = false;
            lbl_interesPorcentajeActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_interesPorcentajeActual.Location = new Point(190, 190);
            lbl_interesPorcentajeActual.Name = "lbl_interesPorcentajeActual";
            lbl_interesPorcentajeActual.Size = new Size(100, 20);
            lbl_interesPorcentajeActual.Text = "";

            //cuotas
            Label lbl_cuota = new Label();
            lbl_cuota.AutoSize = false;
            lbl_cuota.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lbl_cuota.Location = new Point(3, 220);
            lbl_cuota.Name = "lbl_cuota";
            lbl_cuota.Size = new Size(100, 20);
            lbl_cuota.Text = "Cuotas: ";

            //DatosCuotas
            Label lbl_cuotaActual = new Label();
            lbl_cuotaActual.AutoSize = false;
            lbl_cuotaActual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_cuotaActual.Location = new Point(104, 220);
            lbl_cuotaActual.Name = "lbl_cuotaActual";
            lbl_cuotaActual.Size = new Size(100, 20);
            lbl_cuotaActual.Text = "";

            //Agregar controles al tabControl
            tabPage.Controls.Add(lbl_nombre);
            tabPage.Controls.Add(lbl_nombreActual);
            tabPage.Controls.Add(lbl_tarjeta);
            tabPage.Controls.Add(lbl_tarjetaActual);
            tabPage.Controls.Add(lbl_tipoTarjeta);
            tabPage.Controls.Add(lbl_tipoTarjetaActual);
            tabPage.Controls.Add(lbl_numeroTarjeta);
            tabPage.Controls.Add(lbl_numeroTarjetaActual);
            tabPage.Controls.Add(lbl_importeCobrado);
            tabPage.Controls.Add(lbl_importeCobradoActual);
            tabPage.Controls.Add(lbl_interesGenerado);
            tabPage.Controls.Add(lbl_interesGeneradoActual);
            tabPage.Controls.Add(lbl_interesPorcentaje);
            tabPage.Controls.Add(lbl_interesPorcentajeActual);
            tabPage.Controls.Add(lbl_cuota);
            tabPage.Controls.Add(lbl_cuotaActual);

            //Se asigna el control dinamico a una lista de controles
            _nombre.Add(lbl_nombreActual);
            _tarjeta.Add(lbl_tarjetaActual);
            _tipoTarjeta.Add(lbl_tipoTarjetaActual);
            _numeroTarjeta.Add(lbl_numeroTarjetaActual);
            _importeTotalCobrado.Add(lbl_importeCobradoActual);
            _interesPorcentaje.Add(lbl_interesPorcentajeActual);
            _interesGenerado.Add(lbl_interesGeneradoActual);
            _cuota.Add(lbl_cuotaActual);



        }

        private void cargarDetalles(List<Tarjeta> tarjetaDatos)
        {
            claseTarjeta = new Tarjeta();

            foreach (var item in tarjetaDatos)
            {

                _nombre[codigoTarjeta].Text = item.Nombre + " " + item.Apellido;

                

                _tarjeta[codigoTarjeta].Text = claseTarjeta.mostrarTipoTarjeta(item.CodigoTipoTarjeta);
                _tipoTarjeta[codigoTarjeta].Text = claseTarjeta.mostrarTarjeta(item.CodigoTarjeta);
                _numeroTarjeta[codigoTarjeta].Text = item.NumeroTarjeta.ToString();
                if (item.ImporteTotalVentaCalculado==0)
                    _importeTotalCobrado[codigoTarjeta].Text = "$ " + item.ImporteTarjeta.ToString("0.00");
              else
                _importeTotalCobrado[codigoTarjeta].Text ="$ " + item.ImporteTotalVentaCalculado.ToString("0.00");
              if (item.Interes==0)
                    _interesPorcentaje[codigoTarjeta].Text = "0" + " %";
              else
                _interesPorcentaje[codigoTarjeta].Text = item.Interes.ToString()+ " %";

                float calculo= item.ImporteTotalVentaCalculado- item.ImporteTarjeta;

                if (item.Interes==0)
                    _interesGenerado[codigoTarjeta].Text = "$ " + "0.00";
                else
                _interesGenerado[codigoTarjeta].Text = "$ " + calculo.ToString("0.00");

                _cuota[codigoTarjeta].Text = item.Cuota.ToString();
                codigoTarjeta++;
            }
        }

   
    }
}
