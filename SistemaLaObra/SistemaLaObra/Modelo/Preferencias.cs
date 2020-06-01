using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    class Preferencias
    {
        string rutaArchivo;
        string rutaCarpeta;

        public Preferencias()
        {
            rutaCarpeta = "configuraciones";
            rutaArchivo = rutaCarpeta+"\\preferencias.txt";
        }

        public void escribirPreferenciaColorFondo(string titulo, string rgb)
        {
            try
            {
                FileStream archivo = new FileStream(rutaArchivo, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter lapiz = new StreamWriter(archivo);
                lapiz.WriteLine(titulo);
                lapiz.WriteLine(rgb);
                
                lapiz.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void leerPreferenciaColorFondo(Form formulario)
        {
            string linea;

            string titulo = "//Color fondo//"; //Titulo de la configuracion, luego de esta linea se toma los valores rgb

            string[] valores = new string[3];
            char[] separador = { ',' };

            try
            {
                FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read);
                StreamReader lector = new StreamReader(archivo);

                linea = lector.ReadLine(); //Si encuentra algo que leer en la primera linea devuelve true

                while (linea != null)
                {
                    if (linea.ToString() == titulo)
                    {
                        linea = lector.ReadLine(); //Avanzamos una linea hacia los valores
                        valores = linea.Split(separador);
                        break;
                    }
                }
                lector.Close();
                setColorFondo(valores, formulario);
            }
            catch (FileNotFoundException)
            {
                crearPreferenciasPorDefecto();
            }
            catch (DirectoryNotFoundException)
            {
                crearPreferenciasPorDefecto();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void setColorFondo(string [] valores, Form formulario)
        {
            int r = int.Parse(valores[0]);
            int g = int.Parse(valores[1]);
            int b = int.Parse(valores[2]);
            formulario.BackColor = System.Drawing.Color.FromArgb(r,g,b);
        }

        private void crearPreferenciasPorDefecto()
        {
            try
            {
                Directory.CreateDirectory(rutaCarpeta);

                FileStream archivo = new FileStream(rutaArchivo, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter lapiz = new StreamWriter(archivo);
                lapiz.WriteLine("//Color fondo//");
                lapiz.WriteLine("224,224,224");

                lapiz.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
