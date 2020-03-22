using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        /*Aqui declaro las variables de instancia*/

        //operando1 guardará el primer número
        double operando1 = 0;
        //en el string de la operación guardo la operación
        //que ha sido pulsada
        String operacion = "";
        String cero = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void botonPulsado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else {
                label1.Text += boton.Text;
            }
            
        }

        private void pantallaLimpia(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            
            label1.Text = cero;
        }

        private void ponerPunto(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            label1.Text += ".";
        }


        private void operacionPulsada(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }

        private void igualPulsado(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if ( operacion == "/")
            {
                resultado = Math.Round((operando1 / operando2),5);
            }
            else if (operacion == "^")
            {
                resultado = Math.Round(Math.Pow(operando1, operando2),5);
            }
            else if (operacion == "√ ")
            {
                resultado = Math.Sqrt(operando1);
            }
            label1.Text = Convert.ToString(resultado);
        }
    }
}
