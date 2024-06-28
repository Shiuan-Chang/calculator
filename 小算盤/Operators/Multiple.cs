using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 小算盤.Operators;

namespace 小算盤.Operators
{
    internal class Multiple : Operator
    {
        public Multiple(double number, double number2) : base(number, number2)
        {
        }

        public override double OperProcess() 
        {
            return number * number2;
        }
    }
}
