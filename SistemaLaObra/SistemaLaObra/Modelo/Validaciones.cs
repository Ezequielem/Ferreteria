using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    class Validaciones
    {

        public void SoloDosDigitos(TextBox validacion)
        {
            int entero = 0;
           try
            {
                entero = int.Parse(validacion.Text);
                if (entero > 99)
                {
                    MessageBox.Show("Por favor, ingrese un numero 'MENOR' ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    validacion.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void soloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {

                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, solo ingrese 'LETRAS' ", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }  
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {

                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;                    
                }
                else
                {
                    e.Handled = true;                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public bool campoVacio(string valor)
        {
            if (valor == "")
                return true;
            else
                return false;                         
        }

        public void soloDecimales(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.Equals(','))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("No se permite ingresar 'ESPACIOS' ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, solo ingrese 'NUMEROS o PUNTOS' ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }


        public void soloDecimalesConComa(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.Equals(','))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("No se permite ingresar 'ESPACIOS' ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, solo ingrese 'NUMEROS o COMAS' ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void soloEnteros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar.Equals('.'))
                {
                    e.Handled = true;                    

                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;                    
                }
              
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public bool mayor(float a, float b)
        {
            if (a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool mayor(int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool mayorIgualCero(int a)
        {
            if (a >= 0)
                return true;
            else
                return false;
        }

        public bool mayorACero(int a)
        {
            if (a > 0)
                return true;
            else
                return false;
        }

        public bool fechaMayor(string fechaA, string fechaB)
        {
            if (Convert.ToDateTime(fechaA) > Convert.ToDateTime(fechaB))
                return true;
            else
                return false;
        }

        public bool decimalValido(string numero)
        {
            int contador = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i]=='.')
                {
                    contador++;
                }
            }
            if (contador>1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool soloNumerosEnteros(string numero)
        {
            try
            {
                int valor = int.Parse(numero.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }        

        public void permitirNumeroMonetarioDosDecimales(KeyPressEventArgs e, string cadena)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                if (cadena.Contains("."))
                {
                    int b = 0;
                    int contador = 0;
                    foreach (var item in cadena)
                    {
                        if (b == 1)
                        {
                            contador++;
                        }
                        if (item.ToString() == ".")
                        {
                            b = 1;
                        }
                    }
                    if (contador < 2)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar.ToString() == ".")
                    {
                        if (!cadena.Contains("."))
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
