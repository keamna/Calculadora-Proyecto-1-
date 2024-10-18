using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Calculadora1.Clases;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        // Asignacion de variables globales
        static double  num1 = 0, num2 = 0;
        static bool activacion = false;
        static string aux1 = "";
        static string aux2 = "";
        static int operacion = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b0_Click(object sender, EventArgs e)
        {

            if (activacion)
            {
                aux1 = aux1 + "0";


            }

            resultadoBox.Text = resultadoBox.Text + "0";
        }

        private void b1_Click(object sender, EventArgs e)
        {

            if (activacion)
            {
                aux1 = aux1 + "1";


            }

            resultadoBox.Text = resultadoBox.Text + "1";
            

        }

        private void b2_Click(object sender, EventArgs e)
        {

            if (activacion)
            {
                aux1 = aux1 + "2";


            }

            resultadoBox.Text = resultadoBox.Text + "2";

        }

        private void b3_Click(object sender, EventArgs e)
        {

            if (activacion)
            {
                aux1 = aux1 + "3";


            }

            resultadoBox.Text = resultadoBox.Text + "3";

        }

        private void b4_Click(object sender, EventArgs e)
        {


            if (activacion)
            {
                aux1 = aux1 + "4";


            }

            resultadoBox.Text = resultadoBox.Text + "4";

        }

        private void b5_Click(object sender, EventArgs e)
        {

            if (activacion)
            {
                aux1 = aux1 + "5";


            }

            resultadoBox.Text = resultadoBox.Text + "5";

        }

        private void b6_Click(object sender, EventArgs e)
        {


            if (activacion)
            {
                aux1 = aux1 + "6";


            }

            resultadoBox.Text = resultadoBox.Text + "6";

        }

        private void b7_Click(object sender, EventArgs e)
        {
           

            if (activacion)
            {
                aux1 = aux1 + "7";


            }

            resultadoBox.Text = resultadoBox.Text + "7";

        }

        private void b8_Click(object sender, EventArgs e)
        {

            if (activacion)
            {
                aux1 = aux1 + "8";


            }

            resultadoBox.Text = resultadoBox.Text + "8";

        }

        private void b9_Click(object sender, EventArgs e)
        {

            if (activacion)
            {
                aux1 = aux1 + "9";


            }

            resultadoBox.Text = resultadoBox.Text + "9";

        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            // Se llaman a las clases con la logica de las operaciones

            switch (operacion)
            {

                case 1:
                    num2 = double.Parse(aux1);
                    resultadoBox.Text = resultadoBox.Text + " = " + Suma.Sumar(num1, num2).ToString();
                    break;
                case 2:
                    num2 = double.Parse(aux1);
                    resultadoBox.Text = resultadoBox.Text + " = " + Resta.Restar(num1, num2).ToString();
                    break;
                case 3:
                    num2 = double.Parse(aux1);
                    resultadoBox.Text = resultadoBox.Text + " = " + Multiplicacion.Multiplicar(num1, num2).ToString();
                    break;
                case 4:
                    num2 = double.Parse(aux1);
                    resultadoBox.Text = resultadoBox.Text + " = " + Division.Dividir(num1, num2).ToString();
                    break;
                case 5:
                    resultadoBox.Text = resultadoBox.Text + " = " + RaizCuadrada.OpRaizCuadrada(num1, num2).ToString();
                    break;
                case 6:
                    resultadoBox.Text = resultadoBox.Text + " = " + ElevaNumCuadrado.ElevarNumCuadrado(num1, num2).ToString();
                    break;
                case 7:
                    resultadoBox.Text = resultadoBox.Text + " = " + LogaritmoNum.ObtenerLogaritmoNum(num1, num2).ToString();
                    break;
                case 8:
                    resultadoBox.Text = resultadoBox.Text + " = " + ElevaDiezAlNum.ElevarDiezAlNum(num1, num2).ToString();
                    break;
                case 9:
                    resultadoBox.Text = resultadoBox.Text + " = " + ElevaNumAlNum.ElevarNumAlNum(num1, num2).ToString();
                    break;
                case 10:
                    resultadoBox.Text = resultadoBox.Text + " = " + FactorialNum.FactorialNumerico(num1, num2).ToString();
                    break;
                case 11:
                    resultadoBox.Text = resultadoBox.Text + " = " + PositivoNegativo.NumPositivoNegativo(num1, num2).ToString();
                    break;


            }
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            operacion = 4;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + " / ";
            activacion = true;

        }

        private void bBorrarTodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            aux1 = string.Empty;
            resultadoBox.Text = string.Empty;
            resultadoBoxAnterior.Text = string.Empty;
            activacion = false;
        }

        private void bComa_Click(object sender, EventArgs e)
        {
            // Permite que el usuario no ingrese multiples ,
            if (resultadoBox.Text.Contains(",")) 
            {
                return;
            }
            resultadoBox.Text = resultadoBox.Text + ",";
        }

        private void bMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + " X ";
            activacion = true;

        }

        private void bRestar_Click(object sender, EventArgs e)
        {
            operacion = 2;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + "-";
            activacion = true;

        }

        private void bRaizCuadrada_Click(object sender, EventArgs e)
        {
            operacion = 5;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + "";
            activacion = true;
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (resultadoBox.Text.Length > 1)
            {
                string txtResultado = resultadoBox.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    resultadoBox.Text = "0";
                }
                else
                {
                    resultadoBox.Text = txtResultado;
                }
            }
            else
            {
                resultadoBox.Text = "";        
            }
        }

        private void bElevarADos_Click(object sender, EventArgs e)
        {
            operacion = 6;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + " ² ";
            activacion = true;
        }

        private void bElevarEscogerNums_Click(object sender, EventArgs e)
        {
            operacion = 9;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + " ^ ";
            activacion = true;
        }

        private void bLogaritmoDeNum_Click(object sender, EventArgs e)
        {

            operacion = 7;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + "";
            activacion = true;
        }

        private void bDiezElevadoNum_Click(object sender, EventArgs e)
        {
            operacion = 8;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + "";
            activacion = true;
        }

        private void bFactorialNum_Click(object sender, EventArgs e)
        {
            operacion = 10;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + "";
            activacion = true;
        }

        private void bPositivoNegativo_Click(object sender, EventArgs e)
        {
            operacion = 11;
            num1 = double.Parse(resultadoBox.Text);
            resultadoBox.Text = resultadoBox.Text + "";
            activacion = true;
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
                operacion = 1;
                num1 = double.Parse(resultadoBox.Text); 
                resultadoBox.Text = resultadoBox.Text + " + ";
                activacion = true;

       

           
           
        }


    }
}
