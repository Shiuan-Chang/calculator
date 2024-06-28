using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 小算盤.Operators;

namespace 小算盤
{
    internal class Plus : Operator //父類別要是有建構元，子類別也要有建構元
    {
        public Plus(double number, double number2) : base(number, number2)
        {
        }

        public override double OperProcess()
        {
            return number + number2;
        }
    }
}
