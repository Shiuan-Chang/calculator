using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小算盤
{
    public partial class Form1 : Form
    {
        private string num1;
        private string num2;
        private string currentOperator="";
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberClick(object sender, EventArgs e)//object可以包含所有值的類型、所有引用的類型，
        {
            Button numbutton = (Button)sender;//試圖將sender轉為button類型
            Output.Text += numbutton.Text;//將數字一一列入，output是計算機上方顯示輸出的部分

            char trimOper = currentOperator.Length > 0 ? currentOperator[0] : ' ';
            Output.Text = Output.Text.TrimStart('0', trimOper);

            //if(currentOperator != null && currentOperator != "")//空字串不是null
            //{
            //    Output.Text = Output.Text.TrimStart(currentOperator[0]);
            //}
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;            
            num1 = Output.Text;
            Output.Text = operatorButton.Text;
            currentOperator = operatorButton.Text;
        }

        private void EqualsClick(object sender, EventArgs e)
        {
            num2 = Output.Text;
            Calc calc = new Calc();
            calc.currentOperator = currentOperator; 
            // 型別轉不要在這邊處理，Num1在這邊應該就要是文字格式
            calc.Num1 = num1;
            calc.Num2 = num2; // set,右邊職賦予給左邊變量
           /* string number1 = calc.Num1;*/ // get;這行沒作用，只是舉例
            Output.Text = calc.Calculator();

        }
        private void CleanClick(object sender, EventArgs e)
        {
            currentOperator = "";
            num1 = "";
            num2 = "";
            Output.Text = "";
        }
    }
}
