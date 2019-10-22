using System;
using System.Data;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private int contParentesis;
        private string resultado;
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
            } else if (txtbFormula.Text == resultado)
            {
                txtbFormula.Text = resultado;
                txtbHistorial.Text = resultado;
            }
            
            //Se habilitan todos los botones
            btnMultiplicar.Enabled = true;
            btnDividir.Enabled = true;
            btnSumar.Enabled = true;
            btnRestar.Enabled = true;
            btnPunto.Enabled = true;

            Button button = (Button)sender;

            //CONTROL DE BOTONES
            if (button.Text == btnSumar.Text)
            {
                //No puede seguir un signo * o / después de -
                btnMultiplicar.Enabled = false;
                btnDividir.Enabled = false;
                //No se puede repetir el mismo signo
                btnSumar.Enabled = false;
                //No se puede cambiar la suma por la resta
                btnRestar.Enabled = false;

            }
            else if (button.Text == btnRestar.Text)
            {
                //No puede seguir un signo * o / después de -
                btnMultiplicar.Enabled = false;
                btnDividir.Enabled = false;
                //No se puede repetir el mismo signo
                btnRestar.Enabled = false;
                //No se puede cambiar la resta por la suma
                btnSumar.Enabled = false;

            }
            else if (button.Text == btnMultiplicar.Text)
            {
                //Luego de un signo multiplicar no puede haber un / o una +
                btnDividir.Enabled = false;
                btnSumar.Enabled = false;
            }
            else if (button.Text == btnDividir.Text)
            {
                //Luego de un signo dividir no puede haber una * o una +
                btnMultiplicar.Enabled = false;
                btnSumar.Enabled = false;
            }
            else if (txtbFormula.Text == "0")
            {
                //El calculo no puede iniciar con *, / o +
                btnMultiplicar.Enabled = false;
                btnDividir.Enabled = false;
                btnSumar.Enabled = false;
            }
            else if (contParentesis > 0)
            {
                //Si hay paréntesis abiertos, se habilita el boton para cerrarlo
                btnPC.Enabled = true;
            }
            else if (button.Text == btnPunto.Text)
            {
                btnPunto.Enabled = false;
            }
            else
            {
                //Si no se cumple ninguna de las condiciones anteriores se habilitan todos los botones
                btnMultiplicar.Enabled = true;
                btnDividir.Enabled = true;
                btnSumar.Enabled = true;
                btnRestar.Enabled = true;
                btnPunto.Enabled = true;
            }


            //Se carga el texto del boton tocado a los text boxes
            txtbFormula.Text += button.Text;
            txtbHistorial.Text += button.Text;

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtbFormula.Text = "0";
            txtbHistorial.Text = "";
            contParentesis = 0;
            lblContParentesis.Visible = false;
            btnMultiplicar.Enabled = true;
            btnDividir.Enabled = true;
            resultado = null;
        }

        private void BtnPA_Click(object sender, EventArgs e)
        {
            //Muestra la cantidad de parentesis abiertos
            contParentesis += 1;
            lblContParentesis.Text = contParentesis.ToString();

            if (contParentesis > 0)
            {
                lblContParentesis.Visible = true;
                btnPC.Enabled = true;
            }

            if (txtbFormula.Text == "0")
            {
                txtbFormula.Clear();
            }
            txtbFormula.Text += "(";
            txtbHistorial.Text += "(";
        
        }

        private void BtnPC_Click(object sender, EventArgs e)
        {

            //Cierra el parentesis y disminuye la cantidad de parentesis abiertos
            contParentesis -= 1;
            lblContParentesis.Text = contParentesis.ToString();

            if (contParentesis > 0)
            {
                lblContParentesis.Visible = true;
                btnPC.Enabled = true;
            }
            else if (contParentesis <= 0)
            {
                lblContParentesis.Visible = false;
                btnPC.Enabled = false;
                contParentesis = 0;
            }


            if (txtbFormula.Text == "0")
            {
                txtbFormula.Clear();
            }

            txtbFormula.Text += ")";
            txtbHistorial.Text += ")";

        }

        private void BtnAns_Click(object sender, EventArgs e)
        {
            if (resultado != null)
            {
                btnAns.Enabled = true;
                txtbFormula.Text += resultado;
                txtbHistorial.Text += resultado;
            }
            else
            {
                btnAns.Enabled = false;
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Control de paréntesis abiertos al borrarlos
                if (txtbFormula.Text.Substring(txtbFormula.Text.Length-1,1) == "(")
                {
                    contParentesis -= 1;
                    lblContParentesis.Text = contParentesis.ToString();
                    if (contParentesis <= 0)
                    {
                        lblContParentesis.Visible = false;
                    }
                } else if (txtbFormula.Text.Substring(txtbFormula.Text.Length - 1, 1) == ")")
                {
                    contParentesis += 1;
                    btnPC.Enabled = true;
                    if (contParentesis > 0)
                    {
                        lblContParentesis.Visible = true;
                    }
                }

                    //Se elimina el último caracter ingresado
                    txtbFormula.Text = txtbFormula.Text.Substring(0, txtbFormula.Text.Length - 1);
                txtbHistorial.Text = txtbHistorial.Text.Substring(0, txtbHistorial.Text.Length - 1);

                //Control de botones al borrar
                if (txtbFormula.Text.Substring(txtbFormula.Text.Length - 1, 1) == "+" || txtbFormula.Text.Substring(txtbFormula.Text.Length - 1, 1) == "-")
                {
                    //Si el último caracter es +, se deshabilita * ,/ ,- y +
                    btnMultiplicar.Enabled = false;
                    btnDividir.Enabled = false;
                    btnSumar.Enabled = false;
                    btnRestar.Enabled = false;
                }
                else if (txtbFormula.Text.Substring(txtbFormula.Text.Length - 1, 1) == "*" || txtbFormula.Text.Substring(txtbFormula.Text.Length - 1, 1) == "/")
                {
                    //Si el último caracter es *, se deshabilita * , / y +
                    btnMultiplicar.Enabled = false;
                    btnDividir.Enabled = false;
                    btnSumar.Enabled = false;
                }
                else
                {
                    btnMultiplicar.Enabled = true;
                    btnDividir.Enabled = true;
                    btnSumar.Enabled = true;
                    btnRestar.Enabled = true;
                }


                if (string.IsNullOrEmpty(txtbFormula.Text))
                {
                    txtbFormula.Text = "0";
                    txtbHistorial.Text = "";
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                txtbFormula.Text = "0";
                txtbHistorial.Text = "";
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
                resultado = new DataTable().Compute(txtbFormula.Text, null).ToString().Replace(",", ".");

                btnAns.Enabled = true;

                if (Double.IsInfinity(Convert.ToDouble(resultado)))
                {
                    throw new ArithmeticException();
                }
                else
                {
                    txtbFormula.Text = resultado;
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

        private void TxtbFormula_TextChanged(object sender, EventArgs e)
        {
            txtbFormula.SelectionStart = txtbFormula.Text.Length;
            txtbFormula.ScrollToCaret();
        }

        private void TxtbHistorial_TextChanged(object sender, EventArgs e)
        {
            txtbHistorial.SelectionStart = txtbHistorial.Text.Length;
            txtbHistorial.ScrollToCaret();
        }
    }
}