using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    class MenuOpciones
    {
        MainMenu menuOpciones;

        MenuItem itemArchivo;
        MenuItem itemPersonalizar;
        MenuItem itemColorFondo;
        MenuItem itemColor0;
        MenuItem itemColor1;
        MenuItem itemColor2;
        MenuItem itemColor3;
        MenuItem itemSalir;

        Form formulario;
        Preferencias preferencias;

        public MenuOpciones(Form formulario)
        {
            menuOpciones = new MainMenu();
            formulario.Menu = menuOpciones;

            this.formulario = formulario;
  
            agregarMenuOpciones();
        }


        private void agregarMenuOpciones()
        {
            crearItemsMenu();
            agregarItemsMenu();
            agregarEventos();
        }

        private void crearItemsMenu()
        {
            itemArchivo = new MenuItem("Archivo");
            itemPersonalizar = new MenuItem("Personalizar");
            itemColorFondo = new MenuItem("Color de fondo");
            itemColor0 = new MenuItem("Por defecto");
            itemColor1 = new MenuItem("Verde claro");
            itemColor2 = new MenuItem("Amarillo");
            itemColor3 = new MenuItem("Active Caption");
            itemSalir = new MenuItem("Salir");
        }
        
        private void agregarItemsMenu()
        {
            menuOpciones.MenuItems.Add(itemArchivo);
            itemArchivo.MenuItems.Add(itemPersonalizar);
            itemPersonalizar.MenuItems.Add(itemColorFondo);
            itemColorFondo.MenuItems.Add(itemColor0);
            itemColorFondo.MenuItems.Add(itemColor1);
            itemColorFondo.MenuItems.Add(itemColor2);
            itemColorFondo.MenuItems.Add(itemColor3);
            itemArchivo.MenuItems.Add(itemSalir);
        }

        private void agregarEventos()
        {
            itemSalir.Click += new EventHandler(itemSalir_Click);

            itemColor0.Click += new EventHandler(itemColor0_Click);
            itemColor1.Click += new EventHandler(itemColor1_Click);
            itemColor2.Click += new EventHandler(itemColor2_Click);
            itemColor3.Click += new EventHandler(itemColor3_Click);
        }

        //Eventos

        private void itemSalir_Click(object sender, EventArgs e)
        {
            formulario.Close();
        }

        private void itemColor0_Click(object sender, EventArgs e)
        {
            formulario.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            preferencias = new Preferencias();
            preferencias.escribirPreferenciaColorFondo("//Color fondo//", "224,224,224");
        }

        private void itemColor1_Click(object sender, EventArgs e)
        {
            formulario.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            preferencias = new Preferencias();
            preferencias.escribirPreferenciaColorFondo("//Color fondo//","192,255,192");
        }

        private void itemColor2_Click(object sender, EventArgs e)
        {
            formulario.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            preferencias = new Preferencias();
            preferencias.escribirPreferenciaColorFondo("//Color fondo//", "255,255,192");
        }

        private void itemColor3_Click(object sender, EventArgs e)
        {
            formulario.BackColor = System.Drawing.Color.FromArgb(153, 180, 209);
            preferencias = new Preferencias();
            preferencias.escribirPreferenciaColorFondo("//Color fondo//", "153,180,209");
        }
    }
}
