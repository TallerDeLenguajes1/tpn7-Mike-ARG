﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "9";
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + "0";
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + ',';
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + '+';
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + '-';
        }

        private void botonMultip_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + '*';
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = casillaTexto.Text + '/';
        }

        private void botonC_Click(object sender, EventArgs e)
        {
            casillaTexto.Text = string.Empty;
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            string[] ecuacion;
            Calculadora calc = new Calculadora();

            if (casillaTexto.Text.Contains("+"))
            {
                ecuacion = casillaTexto.Text.Split('+');
                calc.Numero1 = Convert.ToSingle(ecuacion[0]);
                calc.Numero2 = Convert.ToSingle(ecuacion[1]);
                casillaTexto.Text = Convert.ToString(calc.Suma(calc.Numero1, calc.Numero2));

            } else if (casillaTexto.Text.Contains("-"))
            {
                ecuacion = casillaTexto.Text.Split('-');
                calc.Numero1 = Convert.ToSingle(ecuacion[0]);
                calc.Numero2 = Convert.ToSingle(ecuacion[1]);
                casillaTexto.Text = Convert.ToString(calc.Resta(calc.Numero1, calc.Numero2));
            } else if (casillaTexto.Text.Contains("*"))
            {
                ecuacion = casillaTexto.Text.Split('*');
                calc.Numero1 = Convert.ToSingle(ecuacion[0]);
                calc.Numero2 = Convert.ToSingle(ecuacion[1]);
                casillaTexto.Text = Convert.ToString(calc.Multiplicacion(calc.Numero1, calc.Numero2));
            } else if (casillaTexto.Text.Contains("/"))
            {
                ecuacion = casillaTexto.Text.Split('/');
                calc.Numero1 = Convert.ToSingle(ecuacion[0]);
                calc.Numero2 = Convert.ToSingle(ecuacion[1]);
                casillaTexto.Text = Convert.ToString(calc.Division(calc.Numero1, calc.Numero2));
            }
        }
    }
}
