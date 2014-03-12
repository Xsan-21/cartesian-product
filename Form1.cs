using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Producto_Cartesiano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valoresCasillaA = textBoxA.Text;
            string valoresCasillaB = textBoxB.Text;
            string valoresCasillaC = textBoxC.Text;
            string[] arreglo1 = new string[textBoxA.TextLength], arreglo2 = new string[textBoxB.TextLength], arreglo3 = new string[textBoxC.TextLength];
            int cantidadDeNumeros = (textBoxA.TextLength + textBoxB.TextLength + textBoxC.TextLength);

            for (int i = 0; i < valoresCasillaA.Length; i++)
            {
                string value = valoresCasillaA.Substring(i, 1);
                arreglo1[i] = value;
            }

            for (int j = 0; j < valoresCasillaB.Length; j++)
            {
                string value = valoresCasillaB.Substring(j, 1);
                arreglo2[j] = value;
            }

            for (int k = 0; k < valoresCasillaC.Length; k++)
            {
                string value = valoresCasillaC.Substring(k, 1);
                arreglo3[k] = value;
            }


            //**********************************************************************************************************
            // **********************************Calculo del producto cartesiano**************************************** 
            
            
            if (textBoxA.Text == "" || textBoxB.Text == "" || textBoxC.Text == "")
            {
                MessageBox.Show("Complete todos los encasillados para proceder a calcular el Producto cartesiano", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (button1.Text == "Borrar")
            {
                this.Height = 229;
                result_Box.Text = null;
                button1.Text = "Solución";
                textBoxA.Text = ""; 
                textBoxB.Text = "";
                textBoxC.Text = "";
            }
            else if(button1.Text == "Solución")
            {
                result_Box.Text = "El Producto Cartesiano A x B es: { ";

                foreach (var item in arreglo1)
                {
                    foreach (var valores in arreglo2)
                    {
                        result_Box.Text += "(" + item + ", " + valores + "), ";
                    }
                }

                result_Box.Text += "}\n\n\nEl Producto Cartesiano B x A es: {";


                foreach (var item in arreglo2)
                {
                    foreach (var valores in arreglo1)
                    {
                        result_Box.Text += "(" + item + ", " + valores + "), ";
                    }
                }

                result_Box.Text += "}\n\n\nEl Producto Cartesiano A x B x C es: { ";

                foreach (var item in arreglo1)
                {
                    foreach (var valores in arreglo2)
                    {
                        foreach (var valoresFinales in arreglo3)
                        {
                            result_Box.Text += "(" + item + ", " + valores + ", " + valoresFinales + "), ";
                        }
                    }

                }

                result_Box.Text += "}\n\n\nEl Producto Cartesiano C x B x A es: { ";

                foreach (var item in arreglo3)
                {
                    foreach (var valores in arreglo2)
                    {
                        foreach (var valoresFinales in arreglo1)
                        {
                            result_Box.Text += "(" + item + ", " + valores + ", " + valoresFinales + "), ";
                        }
                    }

                }

                this.Height = 349;
                button1.Text = "Borrar";
            }
            }
        

        private void label_A_Click(object sender, EventArgs e)
        {
            Random rand1 = new Random();

            int number = rand1.Next(1000);
            textBoxA.Text = number.ToString();
        }

        private void labelB_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            Random rand2 = new Random();
            char ch;

            for (int i = 0; i < 2; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand2.NextDouble() + 65)));
                builder.Append(ch);
                textBoxB.Text = builder.ToString();
                textBoxC.Text = builder.ToString().ToLower();
            }
}

       /* private void borrar_btn_Click(object sender, EventArgs e)
        {
            this.Height = 229;
            result_Box.Text = null;
            this.borrar_btn.Visible = false;
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            //Llena la casilla A
            Random rand1 = new Random();

            int number = rand1.Next(1000);
            textBoxA.Text = number.ToString();

            //Llena la casilla B y C
            StringBuilder builder = new StringBuilder();
            Random rand2 = new Random();
            char ch;

            for (int i = 0; i < 2; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand2.NextDouble() + 65)));
                builder.Append(ch);
                textBoxB.Text = builder.ToString();
                textBoxC.Text = builder.ToString().ToLower(); // Esta linea llena la casilla C
            }
        }

        private void labelC_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            Random rand2 = new Random();
            char ch;

            for (int i = 0; i < 2; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand2.NextDouble() + 65)));
                builder.Append(ch);
                textBoxC.Text = builder.ToString().ToLower(); // Esta linea llena la casilla C
            }
        }
    }
}
