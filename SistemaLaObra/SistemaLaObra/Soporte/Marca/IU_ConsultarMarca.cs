using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Soporte
{
    public partial class IU_ConsultarMarca : Form
    {
        public Marca Marca { get; set; }
        public List<Marca> ListaMarcas { get; set; }

        public IU_ConsultarMarca()
        {
            InitializeComponent();
            Marca = new Marca();
            ListaMarcas = new List<Marca>();
        }

        //BOTONES

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            IU_RegistrarMarca interfaz = new IU_RegistrarMarca();
            interfaz.ShowDialog();
            cargarMarcas();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dgv_marcas.Rows.Count != 0)
            {                
                IU_ActualizarMarca interfaz = new IU_ActualizarMarca();
                interfaz.opcionActualizarMarca(int.Parse(dgv_marcas.CurrentRow.Cells[1].Value.ToString()));
                interfaz.ShowDialog();
                cargarMarcas();
            }
        }

        //METODOS

        private void cargarMarcas()
        {
            Cursor.Current = Cursors.WaitCursor;
            ListaMarcas.Clear();
            ListaMarcas = Marca.mostrarDatos();
            dgv_marcas.Rows.Clear();
            foreach (var item in ListaMarcas)
            {
                dgv_marcas.Rows.Add(item.Descripcion, item.CodigoMarca);
            }
            Cursor.Current = Cursors.Default;
        }

        private void cargarMarcas(List<Marca> lista)
        {
            Cursor.Current = Cursors.WaitCursor;
            dgv_marcas.Rows.Clear();
            foreach (var item in lista)
            {
                dgv_marcas.Rows.Add(item.Descripcion, item.CodigoMarca);
            }
            Cursor.Current = Cursors.Default;
        }

        //EVENTOS

        private void IU_ConsultarMarca_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            if (txt_filtro.Text == String.Empty)
            {
                cargarMarcas();
            }
            else
            {
                cargarMarcas(ListaMarcas.Where(x => x.Descripcion.Contains(txt_filtro.Text)).ToList());
            }
        }
    }
}
