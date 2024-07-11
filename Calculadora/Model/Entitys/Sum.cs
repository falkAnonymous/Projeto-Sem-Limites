using Calculadora.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Entitys
{
    internal class Sum : ISum
    {
        public double Result {  get; private set; }
        void ISum.Sum(params int[] Valuer)
        {
            Result = 0.0;
            for (int i = 0; i < Valuer.Length; i++)
            {
                Result += Valuer[i];
            }
        }
    }
}
