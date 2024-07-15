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
        double ResultadoValor = 0;
        double UltimoDigito = 0;
        Operators operators = new Operators();

        public FormCalculadora()
        {
            InitializeComponent();

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            lblScreen.Focus();
            lblScreen.Text = ValorInicial.ToString();

        }

        #region Configurando os Eventos dos Botões Numericos

        // Botão Numero 1
        private void btnNumber1_Click(object sender, EventArgs e)
        {
            //Está verificando se o texto inicial
            //se encontra em 0 se for verdade ele
            //ele vai apagar e encrementar numeros atras de numeros
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }

            lblScreen.Text += btnNumber1.Text;
            UltimoDigito = double.Parse(btnNumber1.Text);
        }

        //Botão Numero 2
        private void btnNumber2_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            UltimoDigito = double.Parse(btnNumber2.Text);
            lblScreen.Text += btnNumber2.Text;
        }

        //Botão Numero 3
        private void btnNumber3_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            UltimoDigito = double.Parse(btnNumber3.Text);
            lblScreen.Text += btnNumber3.Text;
        }
        //Botão Numero 4
        private void btnNumber4_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            UltimoDigito = double.Parse(btnNumber4.Text);
            lblScreen.Text += btnNumber4.Text;
        }
        //Botão Numero 5
        private void btnNumber5_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            UltimoDigito = double.Parse(btnNumber5.Text);
            lblScreen.Text += btnNumber5.Text;
        }
        //Botão Numero 6
        private void btnNumber6_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            UltimoDigito = double.Parse(btnNumber6.Text);
            lblScreen.Text += btnNumber6.Text;
        }
        //Botão Numero 7
        private void btnNumber7_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            UltimoDigito = double.Parse(btnNumber7.Text);
            lblScreen.Text += btnNumber7.Text;
        }
        //Botão Numero 8
        private void btnNumber8_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            UltimoDigito = double.Parse(btnNumber8.Text);
            lblScreen.Text += btnNumber8.Text;
        }
        //Botão Numero 9
        private void btnNumber9_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            UltimoDigito = double.Parse(btnNumber9.Text);
            lblScreen.Text += btnNumber9.Text;
        }
        // Botão Numero 0
        private void btnNumber0_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            UltimoDigito = double.Parse(btnNumber0.Text);
            lblScreen.Text += btnNumber0.Text;
        }

        #endregion

        #region Configurando os Eventos dos Botões Operadores
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

                            Sum sum = new Sum(valor1, valor2, ResultadoValor, btnSum, lblScreen);
                            lblScreen.Text = sum._control2.Text;
                        }
                        break;

                    case Operators.Subtrair:
                        if (btnSubtract.Text == "-")
                        {
                            Subtract subtract = new Subtract(valor1, valor2, ResultadoValor, btnSubtract, lblScreen);
                            lblScreen.Text = subtract._control2.Text;
                        }
                        break;

                    case Operators.Multiplicar:

                        if (btnMultiply.Text == "X")
                        {
                            Multiply multiply = new Multiply(valor1, valor2, ResultadoValor, btnMultiply, lblScreen);
                            lblScreen.Text = multiply._control2.Text;
                        }
                        break;

                    case Operators.Dividir:
                        if (btnDivision.Text == "÷")
                        {
                            Division division = new Division(valor1, valor2, ResultadoValor, btnDivision, lblScreen);
                            lblScreen.Text = division._control2.Text;
                        }
                        break;
                    case Operators.LimparCe:
                        if (btnCE.Text == "CE")
                        {
                            valor1 = UltimoDigito;
                            lblScreen.Text = valor1.ToString();
                        }
                        break;
                }

            }

        }
        #endregion

        #region Configurando os Eventos dos Botões Limpar
        //Botão Limpar
        private void btnClearDigit_Click(object sender, EventArgs e)
        {
            _comma = 0;
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
                UltimoDigito = 0;
                valor1 = 0;
                valor2 = 0;
                _comma = 0;
                lblScreen.Text = Resetar.ToString();

            }
        }
        // Botão CE
        private void btnCE_Click(object sender, EventArgs e)
        {
            _comma = 0;
            if (sender == btnSum)
                operators = Operators.Soma;
            else if (sender == btnSubtract)
                operators = Operators.Subtrair;
            else if (sender == btnMultiply)
                operators = Operators.Multiplicar;
            else if (sender == btnDivision)
                operators = Operators.Dividir;
            else if (sender == btnCE)
            {
                operators = Operators.LimparCe;
                lblScreen.Text = ValorInicial.ToString();
            }
        }
        #endregion

        int _comma = 0;

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (_comma < 1)
            {
                lblScreen.Text += btnComma.Text;
                _comma++;
            }

        }


        bool _sinalNegativo = false;
        private void btnNegative_Click(object sender, EventArgs e)
        {
            if(!_sinalNegativo)
            {
                lblScreen.Text = "-" + lblScreen.Text;
                _sinalNegativo = true;
            }
            else
            {
                lblScreen.Text = lblScreen.Text.TrimStart('-');
                _sinalNegativo = false;
            }
        }
    }

}
