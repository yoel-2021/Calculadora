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
    public partial class Frm1 : Form
    {
        Double valor = 0;
        String operacion = "";
        bool secuencia = false;

        public Frm1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((resultado.Text == "0")||(secuencia))
                resultado.Clear();

            secuencia = false;
            Button b = (Button)sender;
            resultado.Text = resultado.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
        }

        private void operador_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacion = b.Text;
            valor = Double.Parse(resultado.Text);
            secuencia = true;
            proceso.Text = valor + " " + operacion;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            proceso.Text = "";
            switch (operacion)
            {
                case "+" :
                    resultado.Text = (valor + Double.Parse(resultado.Text)).ToString();
                    break;
                case "-":
                    resultado.Text = (valor - Double.Parse(resultado.Text)).ToString();
                    break;
                case "*":
                    resultado.Text = (valor * Double.Parse(resultado.Text)).ToString();
                    break;
                case "/":
                    resultado.Text = (valor / Double.Parse(resultado.Text)).ToString();
                    break;
                default:
                    break;
            }// Fin de la funcion Switch

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultado.Clear();
            valor = 0;
        }


        
    }
}
