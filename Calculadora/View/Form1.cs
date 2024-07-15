using Calculadora.Modal.Entity;
using Calculadora.Modal.Enum;
using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        int ValorInicial = 0;

        double valor1 = 0;
        double valor2 = 0;
        double Resultadovalor3 = 0;
        Operators operators = new Operators();

        public FormCalculadora()
        {
            InitializeComponent();

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            lblScreen.Text = ValorInicial.ToString();
        }

        #region Configurando os Eventos dos Botões Numericos

        // Botão Numero 1
        private void btnNumber1_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber1.Text;
        }

        //Botão Numero 2
        private void btnNumber2_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber2.Text;
        }

        //Botão Numero 3
        private void btnNumber3_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber3.Text;
        }
        //Botão Numero 4
        private void btnNumber4_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber4.Text;
        }
        //Botão Numero 5
        private void btnNumber5_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber5.Text;
        }
        //Botão Numero 6
        private void btnNumber6_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber6.Text;
        }
        //Botão Numero 7
        private void btnNumber7_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber7.Text;
        }
        //Botão Numero 8
        private void btnNumber8_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber8.Text;
        }
        //Botão Numero 9
        private void btnNumber9_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber9.Text;
        }
        // Botão Numero 0
        private void btnNumber0_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            lblScreen.Text += btnNumber0.Text;
        }

        //Botão Limpar
        private void btnClearDigit_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text.Length > 0)
            {
                lblScreen.Text = lblScreen.Text.Substring(0, lblScreen.Text.Length - 1);

                if (lblScreen.Text == string.Empty)
                {
                    lblScreen.Text = ValorInicial.ToString();
                }
            }

        }

        //Limpa Tudo
        private void btnClear_Click(object sender, EventArgs e)
        {
            int Resetar = 0;

            if (lblScreen.Text.Length > 0)
            {
                lblScreen.Text = Resetar.ToString();
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(lblScreen.Text);
            lblScreen.Text = ValorInicial.ToString();
        }

        //Botão Divisão
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (sender == btnSum)
                operators = Operators.Soma;
            else if (sender == btnSubtract)
                operators = Operators.Subtrair;
            else if (sender == btnMultiply)
                operators = Operators.Multiplicar;
            else if (sender == btnDivision)
            {
                operators = Operators.Dividir;
                valor1 = double.Parse(lblScreen.Text);
                lblScreen.Text = ValorInicial.ToString();
            }
        }
        //Botão Multiplicar
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (sender == btnSum)
                operators = Operators.Soma;
            else if (sender == btnSubtract)
                operators = Operators.Subtrair;
            else if (sender == btnMultiply)
            {
                operators = Operators.Multiplicar;
                valor1 = double.Parse(lblScreen.Text);
                lblScreen.Text = ValorInicial.ToString();
            }
            else if (sender == btnDivision)
                operators = Operators.Dividir;
        }
        //Botão Subtrair
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (sender == btnSum)
                operators = Operators.Soma;
            else if (sender == btnSubtract)
            {
                operators = Operators.Subtrair;
                valor1 = double.Parse(lblScreen.Text);
                lblScreen.Text = ValorInicial.ToString();
            }
            else if (sender == btnMultiply)
                operators = Operators.Multiplicar;
            else if (sender == btnDivision)
                operators = Operators.Dividir;
        }
        //Botão Soma
        private void btnSum_Click(object sender, EventArgs e)
        {

            if (sender == btnSum)
            {
                operators = Operators.Soma;
                valor1 = double.Parse(lblScreen.Text);
                lblScreen.Text = ValorInicial.ToString();
            }
            else if (sender == btnSubtract)
                operators = Operators.Subtrair;
            else if (sender == btnMultiply)
                operators = Operators.Multiplicar;
            else if (sender == btnDivision)
                operators = Operators.Dividir;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblScreen.Text))
            {
                valor2 = double.Parse(lblScreen.Text);

                switch (operators)
                {
                    case Operators.Soma:

                        if (btnSum.Text == "+")
                        {
                            Sum sum = new Sum(valor1, valor2, Resultadovalor3, btnSum, lblScreen);
                            lblScreen.Text = sum._control2.Text;
                            if(sender == btnSum)
                            {
                                Resultadovalor3 += double.Parse(lblScreen.Text);
                                lblScreen.Text = Resultadovalor3.ToString();
                            }
                        }
                        break;

                    case Operators.Subtrair:
                        if (btnSubtract.Text == "-")
                        {
                            Subtract subtract = new Subtract(valor1, valor2, Resultadovalor3, btnSubtract, lblScreen);
                            lblScreen.Text = subtract._control2.Text;
                        }
                        break;

                    case Operators.Multiplicar:

                        if (btnMultiply.Text == "X")
                        {
                            Multiply multiply = new Multiply(valor1, valor2, Resultadovalor3, btnMultiply, lblScreen);
                            lblScreen.Text = multiply._control2.Text;
                        }
                        break;

                    case Operators.Dividir:
                        if (btnDivision.Text == "÷")
                        {
                            Division division = new Division(valor1, valor2, Resultadovalor3, btnDivision, lblScreen);
                            lblScreen.Text = division._control2.Text;
                        }
                        break;
                }
                
            }
            
        }

        #endregion


    }

}
