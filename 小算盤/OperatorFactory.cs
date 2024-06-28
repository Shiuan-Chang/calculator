using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 小算盤.Operators;

namespace 小算盤
{
    internal class OperatorFactory
    {
        public static Operator GetCalcResult(double number, double number2, string currentOperator)
        {
            //函式裏面的變數private要拿掉
            Operator operators = null;
            switch (currentOperator)
            {
                //針對每個運算符做相應的class
                case "+":
                    operators = new Plus(number, number2);
                    break;
                case "-":
                    operators = new Minus(number, number2);
                    break;
                case "*":
                    operators = new Multiple(number, number2);
                    break;
                case "/":
                    operators = new Divide(number, number2);
                    break;
                default:
                    throw new Exception("未知operator！");
            }
            return operators;
        }
    }
}
