using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaMensual
{
    public partial class Calculadora : Form
    {

        enum Operacion { suma, resta, multiplicacion, division };
      
        float primero;
        float segundo;
        float resultado;
        string operacion, borrado;


        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 9;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if(txtPantalla.Text == "0")
            {
                return ;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "0";
            }
            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion = "x";
            primero = float.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }


        private void btnDivi_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "-";
                primero = float.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }


        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "+";
                primero = float.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                  
        }


        private void btnRest_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "-";
                primero = float.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {

            try
            {
                segundo = float.Parse(txtPantalla.Text);




                switch (operacion)
                {
                    case "+":
                        resultado = primero + segundo;
                        txtPantalla.Text = resultado.ToString();
                        break;

                    case "-":
                        resultado = primero - segundo;
                        txtPantalla.Text = resultado.ToString();
                        break;

                    case "x":
                        resultado = primero * segundo;
                        txtPantalla.Text = resultado.ToString();
                        break;


                    case "/":
                        resultado = primero / segundo;
                        txtPantalla.Text = resultado.ToString();
                        break;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

            private void button11_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (txtPantalla.Text == ".")
            {
                return;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + ".";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = txtPantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0,x);
            txtPantalla.Text = borrado;
        }
    }
  }

        
