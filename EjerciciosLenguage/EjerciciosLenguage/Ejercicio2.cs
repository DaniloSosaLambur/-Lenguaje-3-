﻿using System;
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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }



        private void Calcular_Click(object sender, EventArgs e)
        {
            if (Numero1textBox1.Text == "")
            {
                errorProvider1.SetError(Numero1textBox1, "Ingrese un valor");
                return;
            }

            errorProvider1.Clear();
            if (Numero2textBox2.Text == string.Empty) {

                errorProvider1.SetError(Numero2textBox2, "Ingrese un valor");
                return;

            }
            errorProvider1.Clear();
            if (OperacionescomboBox1.Text == string.Empty)
            {
                errorProvider1.SetError(OperacionescomboBox1, "Seleccione una operacion");
                return;
            }
            errorProvider1.Clear();

            decimal num1 = Convert.ToDecimal(Numero1textBox1.Text);
            decimal num2 = Convert.ToDecimal(Numero2textBox2.Text);
            Resultadolabel.Text = Calculars(num1, num2).ToString();

        } 





        private decimal Calculars(decimal n1, decimal n2)
        {
            string operacion = OperacionescomboBox1.Text;

            decimal resultado = 0;

            if (operacion == "Suma")
            {
                resultado = n1 + n2;
            }
            else if (operacion == "Resta")
            {
                resultado = n1 - n2;
            }
            else if (operacion == "Multiplicacion")
            {
                resultado = n1 * n2;

            }
            else if (operacion == "Division")
            {
                if (n2 == 0)
                    resultado = 0;
                else 
               resultado= n1 / n2;

            }
            return resultado;
        }
    }
}
