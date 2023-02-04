using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLenguage
{
    public partial class Tarea : Form
    {
        public Tarea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NumtextBox1.Text == "")
            {
                TareaerrorProvider1.SetError(NumtextBox1, "Ingrese un numero");
                return;
            }
            decimal numero = Convert.ToDecimal(NumtextBox1.Text);
            decimal valor = Convert.ToDecimal(NumtextBox1.Text);
            Resultadolabel2.Text = Paroimpar(numero).ToString();
            label4.Text = calculo(valor).ToString();


        }
        // funcio que devuelve si el numero es Par o Impar 
        private string Paroimpar(decimal num)
        {
               
           
            string resultado = "";
           
            if ( num %2 == 0)
            {
                resultado = "El numero es par";
              
            }
            else if ( num %2 != 0)
            {
                resultado = "El numero es Impar";
            }
            return resultado;
        }

        private string calculo(decimal nume) 
        {
            string resultado2 = "";
            

            if (nume <= 0)
            {
                resultado2 = "El numero es negativo";

            }
            else if (nume> 0)
            {
                resultado2 = "El numero es positivo";
            }
            return resultado2;
        }
    }
}
