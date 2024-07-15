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

        public double Valuer1 = 0;
        public double Valuer2 = 0;
        private double MultValuer = 0;
        public Control _control;
        public Control _control2;

        public Multiply(double valuer1, double valuer2, double multValuer, Control control1, Control control2)
        {
            this.Valuer1 = valuer1;
            this.Valuer2 = valuer2;
            this.MultValuer = multValuer;
            this._control = control1;
            this._control2 = control2;
            Multiplicar(Valuer1, Valuer2, MultValuer, _control, _control2);
        }

        private void Multiplicar(double x, double y, double s, Control c, Control c2)
        {
            s = 0;

            if (c.Text == "X" && y != 0)
            {
                s += x * y;
                c2.Text = s.ToString();
            }
            else
            {
                y = 0;
                s *= y;
                c2.Text = s.ToString();
            }
        }
    }
}
