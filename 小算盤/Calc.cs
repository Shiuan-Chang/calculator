using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 小算盤.Operators;

namespace 小算盤
{
    public class Calc
    {
        public string currentOperator = "";//都沒有設定public或private，預設會是private
        private double _num1;
        private double _num2;
        private double result = 0.0;

        // Num1 和 Num2保護上方private _num1 和 _num2不隨意做更動
        public string Num1
        {
            get
            {
                return _num1.ToString();//欄位和屬性可以是不同變數型態，因此這邊_num1轉成字串時，不會影響到上面_num1變數的型別，且可以將值轉到_num1
            }
            set
            {
                _num1 = double.Parse(value);
            }
        }

        public string Num2
        {
            get
            { return _num2.ToString(); }
            set
            { _num2 = double.Parse(value); }
        }

        public string Calculator()
        {
            Operator operators = OperatorFactory.GetCalcResult(_num1, _num2, currentOperator);
            result = operators.OperProcess();

            string finalResult = result.ToString();
            return finalResult;
        }
        public string this[int i]
        {
            get
            {
                return "";
            }
            set
            {

            }
        }
    }
}


