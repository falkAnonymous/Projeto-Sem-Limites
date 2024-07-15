using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Modal.Entity
{
    internal class Sum
    {
        #region Variaveis 
        public double Valuer1 = 0;
        public double Valuer2 = 0;
        private double SumValuer = 0;
        public Control _control;
        public Control _control2;
        #endregion

        #region Construtor

        public Sum(double valuer1, double valuer2, double sumValuer, Control control1, Control control2)
        {
            this.Valuer1 = valuer1;
            this.Valuer2 = valuer2;
            this.SumValuer = sumValuer;
            this._control = control1;
            this._control2 = control2;
            Somar(Valuer1, Valuer2, SumValuer, _control, _control2);
        }
        #endregion

        #region Metodos
        private void Somar(double x, double y, double s, Control c, Control c2)
        {
            s = x;
            if (c.Text == "+")
            {
                s += y;
                c2.Text = s.ToString();
            }
            else
            {
                x = 0;
                s += y;
                c2.Text = s.ToString();
            }
        }
        #endregion


    }
}