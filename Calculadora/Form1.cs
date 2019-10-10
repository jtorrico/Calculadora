using System;
using System.Data;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Castro, Aaron\n- Salcedo, Florencia\n- Torrico, Jonathan", "Integrantes del Grupo.");
        }

        private void Operacion_Click(object sender, EventArgs e)
        {
            if (txtbFormula.Text == "0")
            {
                txtbFormula.Clear();
            }

            Button button = (Button)sender;
            txtbFormula.Text += button.Text;

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtbFormula.Text = "0";
        }

        private void BtnPA_Click(object sender, EventArgs e)
        {
            if (txtbFormula.Text == "0")
            {
                txtbFormula.Clear();
            }
            txtbFormula.Text += "(";
            //btnPA.Enabled = false;
            //btnPC.Enabled = true;

        }

        private void BtnPC_Click(object sender, EventArgs e)
        {
            if (txtbFormula.Text == "0")
            {
                txtbFormula.Clear();
            }

            txtbFormula.Text += ")";
            //btnPA.Enabled = true;
            //btnPC.Enabled = false;
        }

        private void BtnPosNeg_Click(object sender, EventArgs e)
        {
            if (txtbFormula.Text.StartsWith("-"))
            {
                txtbFormula.Text = txtbFormula.Text.Substring(1);

            }else if (!string.IsNullOrEmpty(txtbFormula.Text))
            {
                txtbFormula.Text = "-" + txtbFormula.Text;
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                txtbFormula.Text = txtbFormula.Text.Substring(0, txtbFormula.Text.Length - 1);

                if (string.IsNullOrEmpty(txtbFormula.Text))
                {
                    txtbFormula.Text = "0";
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                txtbFormula.Text = "0";
                lblError.Text = "Campo Vacio!";

            }
            finally
            {
                Timer(sender, e);
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = new DataTable().Compute(txtbFormula.Text, null).ToString().Replace(",", ".");

                if (Double.IsInfinity(Convert.ToDouble(resultado)))
                {
                    throw new ArithmeticException();
                }
                else
                {
                    txtbFormula.Text = resultado.ToString();
                }
            }
            catch (DivideByZeroException)
            {
                txtbFormula.Text = "0";
                lblError.Text = "Division por 0!";
            }
            catch (InvalidCastException)
            {
                txtbFormula.Text = "0";
                lblError.Text = "Error de Casteo, revisar operacion!";
            }
            catch (SyntaxErrorException)
            {
                txtbFormula.Text = "0";
                lblError.Text = "Error de Sintaxis!";
            }
            catch (ArithmeticException)
            {
                txtbFormula.Text = "0";
                lblError.Text = "No se puede dividir por 0! / Infinity - Negative Infinity";
            }
            finally
            {
                Timer(sender, e);
            }
        }

        private void Timer (Object sender, EventArgs e)
        {
            var t = new Timer();
            t.Interval = 3000;

            t.Tick += (s, a) =>
            {
                lblError.Text = "";
                t.Stop();
            };

            t.Start();
        }
    }
}