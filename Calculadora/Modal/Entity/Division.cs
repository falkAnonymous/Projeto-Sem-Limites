using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Modal.Entity
{
    internal class Division
    {

        public void _Division(double x, double y, Control c, Control c2)
        {

            if (c.Text == "÷" && y != 0)
            {
                x /= y;
                c2.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("Não é possível dividir por zero");
            }
        }
    }
}
