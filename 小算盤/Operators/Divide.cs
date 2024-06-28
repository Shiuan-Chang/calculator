using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 小算盤.Operators;

namespace 小算盤.Operators
{
    internal class Divide : Operator
    {
        public Divide(double number, double number2) : base(number, number2)
        {
        }

        public override double OperProcess()
        {
            if (number2 != 0)
            {
                return number / number2;
            }
            else
            {
                throw new DivideByZeroException("除數不能為零");//DivideByZeroException是C#內建的異常類型，專門處理除以0的異常情況
            }
        }
    }
}
