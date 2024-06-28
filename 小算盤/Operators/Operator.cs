using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小算盤.Operators
{
    internal abstract class Operator
    {
        protected double number;// 給繼承用的可以設定為protected
        protected double number2;

        public Operator(double number,double number2) { //使用建構元直接把number，number2定義清楚
            this.number = number;
            this.number2 = number2;
        }
        public abstract double OperProcess();//不要在這邊定義number,number2否則會有牴觸

    }
}
