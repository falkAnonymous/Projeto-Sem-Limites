using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Modal.Entity
{
    internal class Multiply
    {

        public void _Multiply(double x, double y, Control c, Control c2)
        {
            if (c.Text == "X")
            {
                x *= y;
                c2.Text = x.ToString();
            }
        }
    }
}
