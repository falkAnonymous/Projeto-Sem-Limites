using System;
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
    public partial class FormCalculadora : Form
    {

        float numberDefault = 0.0f;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            lblScreen.Text = numberDefault.ToString();
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

        //Botão Limpar
        private void btnClearDigit_Click(object sender, EventArgs e)
        {
            if (lblScreen.Text.Length > 0)
            {
                lblScreen.Text = lblScreen.Text.Substring(0, lblScreen.Text.Length - 1);

                if (lblScreen.Text == string.Empty)
                {
                    lblScreen.Text = 0.0f.ToString();
                }
            }

        }

        #endregion


    }
}
