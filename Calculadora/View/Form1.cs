using Calculadora.Modal.Entity;
using Calculadora.Modal.Enum;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        #region Variaveis

        int InitValue = 0;
        double Value1 = 0;
        double Value2 = 0;
        double ResultValue = 0;
        double LastDigit = 0;
        Operators operators = new Operators();

        // Variaveis da Janela
        Point point;
        int XMouse, YMouse;
        bool Mover = false;

        #endregion


        public FormCalculadora()
        {
            InitializeComponent();

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            lblScreen.Focus();
            lblScreen.Text = InitValue.ToString();

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
            LastDigit = double.Parse(btnNumber1.Text);
        }

        //Botão Numero 2
        private void btnNumber2_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            LastDigit = double.Parse(btnNumber2.Text);
            lblScreen.Text += btnNumber2.Text;
        }

        //Botão Numero 3
        private void btnNumber3_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            LastDigit = double.Parse(btnNumber3.Text);
            lblScreen.Text += btnNumber3.Text;
        }
        //Botão Numero 4
        private void btnNumber4_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            LastDigit = double.Parse(btnNumber4.Text);
            lblScreen.Text += btnNumber4.Text;
        }
        //Botão Numero 5
        private void btnNumber5_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            LastDigit = double.Parse(btnNumber5.Text);
            lblScreen.Text += btnNumber5.Text;
        }
        //Botão Numero 6
        private void btnNumber6_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            LastDigit = double.Parse(btnNumber6.Text);
            lblScreen.Text += btnNumber6.Text;
        }
        //Botão Numero 7
        private void btnNumber7_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            LastDigit = double.Parse(btnNumber7.Text);
            lblScreen.Text += btnNumber7.Text;
        }
        //Botão Numero 8
        private void btnNumber8_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            LastDigit = double.Parse(btnNumber8.Text);
            lblScreen.Text += btnNumber8.Text;
        }
        //Botão Numero 9
        private void btnNumber9_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            LastDigit = double.Parse(btnNumber9.Text);
            lblScreen.Text += btnNumber9.Text;
        }
        // Botão Numero 0
        private void btnNumber0_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text == 0.0f.ToString())
            {
                lblScreen.Text = string.Empty;
            }
            LastDigit = double.Parse(btnNumber0.Text);
            lblScreen.Text += btnNumber0.Text;
        }

        #endregion

        #region Configurando os Eventos dos Botões Operadores
        //Botão Soma
        private void btnSum_Click(object sender, EventArgs e)
        {

            if (sender == btnSum)
            {
                operators = Operators.Soma;
                Value1 = double.Parse(lblScreen.Text);
                lblScreen.Text = InitValue.ToString();
            }
        }
        //Botão Subtrair
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (sender == btnSubtract)
            {
                operators = Operators.Subtrair;
                Value1 = double.Parse(lblScreen.Text);
                lblScreen.Text = InitValue.ToString();
            }

        }

        //Botão Multiplicar
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (sender == btnMultiply)
            {
                operators = Operators.Multiplicar;
                Value1 = double.Parse(lblScreen.Text);
                lblScreen.Text = InitValue.ToString();
            }
        }

        //Botão Divisão
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (sender == btnDivision)
            {
                operators = Operators.Dividir;
                Value1 = double.Parse(lblScreen.Text);
                lblScreen.Text = InitValue.ToString();
            }
        }
        
        

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblScreen.Text))
            {
                Value2 = double.Parse(lblScreen.Text);

                switch (operators)
                {
                    case Operators.Soma:

                        if (btnSum.Text == "+")
                        {
                            Sum sum = new Sum();
                            sum._Sum(Value1, Value2, btnSum, lblScreen);
                        }
                        break;

                    case Operators.Subtrair:
                        if (btnSubtract.Text == "-")
                        {
                            Subtract subtract = new Subtract();
                            subtract._Subtract(Value1, Value2, btnSubtract, lblScreen);
                        }
                        break;

                    case Operators.Multiplicar:

                        if (btnMultiply.Text == "X")
                        {
                            Multiply multiply = new Multiply();
                            multiply._Multiply(Value1, Value2, btnMultiply, lblScreen);
                        }
                        break;

                    case Operators.Dividir:
                        if (btnDivision.Text == "÷")
                        {
                            Division division = new Division();
                            division._Division(Value1, Value2, btnDivision, lblScreen);
                        }
                        break;
                    case Operators.LimparCe:
                        if (btnCE.Text == "CE")
                        {
                            Value1 = LastDigit;
                            lblScreen.Text = Value1.ToString();
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
                    lblScreen.Text = InitValue.ToString();
                }
            }

        }

        //Limpa Tudo
        private void btnClear_Click(object sender, EventArgs e)
        {
            int Resetar = 0;

            if (lblScreen.Text.Length > 0)
            {
                LastDigit = 0;
                Value1 = 0;
                Value2 = 0;
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
                lblScreen.Text = InitValue.ToString();
            }
        }
        #endregion

        #region Configurando Botões a parte
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
            if (!_sinalNegativo)
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
        #endregion

        #region Configurando os Botões de Mover a janela
        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            Mover = true;
            XMouse = e.X;
            YMouse = e.Y;
        }

        private void panelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mover)
            {
                int Xpoint, Ypoint;
                Xpoint = e.X - XMouse;
                Ypoint = e.Y - YMouse;
                this.Location = point = new Point(this.Location.X + Xpoint, this.Location.Y + Ypoint);
            }
        }

        private void panelHead_MouseUp(object sender, MouseEventArgs e)
        {
            Mover = false;
        }


        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureExit_MouseLeave(object sender, EventArgs e)
        {
            pictureExit.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureExit.BackColor = Color.FromArgb(100, 255, 255, 255);
        }
    }



}
