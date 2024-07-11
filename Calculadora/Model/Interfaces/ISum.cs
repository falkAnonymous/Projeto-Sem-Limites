using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Interfaces
{
    internal interface ISum
    {
        double Result { get; }
        void Sum(params int[] Valuer);
    }
}
