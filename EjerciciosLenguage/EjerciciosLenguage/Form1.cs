using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLenguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            decimal numero1 = 0;
            decimal numero2 =0;

            numero1 = Convert.ToDecimal(Numero1textBox1.Text);
            numero2 = Convert.ToDecimal(Numero2textBox2.Text);

            decimal suma = numero1 + numero2;

            //MessageBox.Show("La suma es:" + suma);
           // MostrarMensaje();
            MessageBox.Show(Convert.ToString(Calcular1(numero1, numero2)));
        }
        //procedimiento
        private void MostrarMensaje() 
        {
            MessageBox.Show("HOLA BEBE");
        }
        // funcion 

        private decimal Calcular1(decimal n1, decimal n2)
        { 
        
        return n1 + n2;
        }
    }
}
