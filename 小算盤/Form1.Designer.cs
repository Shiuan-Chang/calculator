namespace 小算盤
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Output = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Output.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Output.Location = new System.Drawing.Point(0, 1);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(558, 88);
            this.Output.TabIndex = 0;
            this.Output.Text = "0";
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.plus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plus.Location = new System.Drawing.Point(338, 92);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(107, 98);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.minus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.minus.Location = new System.Drawing.Point(338, 196);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(107, 98);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // multiple
            // 
            this.multiple.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.multiple.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.multiple.Location = new System.Drawing.Point(338, 297);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(107, 98);
            this.multiple.TabIndex = 3;
            this.multiple.Text = "*";
            this.multiple.UseVisualStyleBackColor = false;
            this.multiple.Click += new System.EventHandler(this.OperatorClick);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.divide.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.divide.Location = new System.Drawing.Point(338, 404);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(107, 98);
            this.divide.TabIndex = 4;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.OperatorClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(-1, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 98);
            this.button1.TabIndex = 5;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NumberClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(112, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 98);
            this.button2.TabIndex = 6;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumberClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(225, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 98);
            this.button3.TabIndex = 7;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NumberClick);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.four.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.four.Location = new System.Drawing.Point(-1, 196);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(107, 98);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.NumberClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(112, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 98);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumberClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(225, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 98);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumberClick);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.three.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.three.Location = new System.Drawing.Point(225, 300);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(107, 98);
            this.three.TabIndex = 11;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.NumberClick);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.two.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.two.Location = new System.Drawing.Point(112, 297);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(107, 98);
            this.two.TabIndex = 12;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.NumberClick);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.one.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.one.Location = new System.Drawing.Point(-1, 300);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(107, 98);
            this.one.TabIndex = 13;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.NumberClick);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zero.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zero.Location = new System.Drawing.Point(-1, 404);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(107, 98);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.NumberClick);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dot.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dot.Location = new System.Drawing.Point(112, 404);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(107, 98);
            this.dot.TabIndex = 16;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.NumberClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(225, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 98);
            this.button4.TabIndex = 17;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.EqualsClick);
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Clean.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Clean.Location = new System.Drawing.Point(451, 92);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(107, 98);
            this.Clean.TabIndex = 18;
            this.Clean.Text = "CE";
            this.Clean.UseVisualStyleBackColor = false;
            this.Clean.Click += new System.EventHandler(this.CleanClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 503);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.four);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Clean;
    }
}

