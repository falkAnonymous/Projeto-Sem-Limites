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
        
        #region Metodos
        public void Somar(ref double x, double y, Control c, Control c2)
        {
            
            if (c.Text == "+")
            {
                x += y;
                c2.Text = x.ToString();
            }

        }
        #endregion


    }
}