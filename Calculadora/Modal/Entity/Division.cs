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
        
        public double Valuer1 = 0;
        public double Valuer2 = 0;
        private double DivValuer = 0;
        public Control _control;
        public Control _control2;

        public Division(double valuer1, double valuer2, double divValuer, Control control1, Control control2)
        {
            this.Valuer1 = valuer1;
            this.Valuer2 = valuer2;
            this.DivValuer = divValuer;
            this._control = control1;
            this._control2 = control2;
            Dividir(Valuer1, Valuer2, DivValuer, _control, _control2);
        }

        private void Dividir(double x, double y, double s, Control c, Control c2)
        {
            s = 0;

            if (c.Text == "÷" && y != 0)
            {
                s += x/y;
                c2.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("Não é possível dividir por zero");
            }
        }
    }
}
