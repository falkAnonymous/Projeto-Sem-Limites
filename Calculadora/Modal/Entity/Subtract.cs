using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Modal.Entity
{
    internal class Subtract
    {
        public double Valuer1 = 0;
        public double Valuer2 = 0;
        private double SubValuer = 0;
        public Control _control;
        public Control _control2;

        public Subtract(double valuer1, double valuer2, double subValuer, Control control1, Control control2)
        {
            this.Valuer1 = valuer1;
            this.Valuer2 = valuer2;
            this.SubValuer = subValuer;
            this._control = control1;
            this._control2 = control2;
            Subtrair(Valuer1, Valuer2, SubValuer, _control, _control2);
        }

        private void Subtrair(double x, double y, double s, Control c, Control c2)
        {
            if (c.Text == "-" && y != 0)
            {
                s = x-y;
                c2.Text = s.ToString();
            }
            else
            {
                y = 0;
                s -= y;
                c2.Text = s.ToString();
            }
        }
    }
}
