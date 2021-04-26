namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.memoryout_button = new System.Windows.Forms.Button();
            this.memoryin_button = new System.Windows.Forms.Button();
            this.clean_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.percent_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.multiply_button = new System.Windows.Forms.Button();
            this.division_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.zero_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memoryout_button
            // 
            this.memoryout_button.Location = new System.Drawing.Point(74, 134);
            this.memoryout_button.Name = "memoryout_button";
            this.memoryout_button.Size = new System.Drawing.Size(48, 41);
            this.memoryout_button.TabIndex = 1;
            this.memoryout_button.Text = "M-";
            this.memoryout_button.UseVisualStyleBackColor = true;
            this.memoryout_button.Click += new System.EventHandler(this.memoryout_button_Click);
            // 
            // memoryin_button
            // 
            this.memoryin_button.Location = new System.Drawing.Point(12, 135);
            this.memoryin_button.Name = "memoryin_button";
            this.memoryin_button.Size = new System.Drawing.Size(49, 41);
            this.memoryin_button.TabIndex = 2;
            this.memoryin_button.Text = "M+";
            this.memoryin_button.UseVisualStyleBackColor = true;
            this.memoryin_button.Click += new System.EventHandler(this.memoryin_button_Click);
            // 
            // clean_button
            // 
            this.clean_button.Location = new System.Drawing.Point(136, 134);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(48, 41);
            this.clean_button.TabIndex = 3;
            this.clean_button.Text = "СЕ";
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // minus_button
            // 
            this.minus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minus_button.Location = new System.Drawing.Point(232, 181);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(44, 41);
            this.minus_button.TabIndex = 4;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // percent_button
            // 
            this.percent_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.percent_button.Location = new System.Drawing.Point(232, 134);
            this.percent_button.Name = "percent_button";
            this.percent_button.Size = new System.Drawing.Size(44, 41);
            this.percent_button.TabIndex = 5;
            this.percent_button.Text = "%";
            this.percent_button.UseVisualStyleBackColor = true;
            this.percent_button.Click += new System.EventHandler(this.percent_button_Click);
            // 
            // plus_button
            // 
            this.plus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plus_button.Location = new System.Drawing.Point(232, 228);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(44, 41);
            this.plus_button.TabIndex = 6;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // multiply_button
            // 
            this.multiply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.multiply_button.Location = new System.Drawing.Point(232, 322);
            this.multiply_button.Name = "multiply_button";
            this.multiply_button.Size = new System.Drawing.Size(44, 41);
            this.multiply_button.TabIndex = 7;
            this.multiply_button.Text = "*";
            this.multiply_button.UseVisualStyleBackColor = true;
            this.multiply_button.Click += new System.EventHandler(this.multiply_button_Click);
            // 
            // division_button
            // 
            this.division_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.division_button.Location = new System.Drawing.Point(232, 275);
            this.division_button.Name = "division_button";
            this.division_button.Size = new System.Drawing.Size(44, 41);
            this.division_button.TabIndex = 8;
            this.division_button.Text = "/";
            this.division_button.UseVisualStyleBackColor = true;
            this.division_button.Click += new System.EventHandler(this.division_button_Click);
            // 
            // one_button
            // 
            this.one_button.Location = new System.Drawing.Point(12, 182);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(49, 40);
            this.one_button.TabIndex = 9;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // two_button
            // 
            this.two_button.Location = new System.Drawing.Point(74, 181);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(49, 41);
            this.two_button.TabIndex = 10;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.two_button_Click);
            // 
            // three_button
            // 
            this.three_button.Location = new System.Drawing.Point(136, 181);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(49, 41);
            this.three_button.TabIndex = 11;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.three_button_Click);
            // 
            // six_button
            // 
            this.six_button.Location = new System.Drawing.Point(136, 228);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(49, 41);
            this.six_button.TabIndex = 14;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.six_button_Click);
            // 
            // five_button
            // 
            this.five_button.Location = new System.Drawing.Point(74, 228);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(49, 41);
            this.five_button.TabIndex = 13;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.five_button_Click);
            // 
            // four_button
            // 
            this.four_button.Location = new System.Drawing.Point(12, 228);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(49, 41);
            this.four_button.TabIndex = 12;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.four_button_Click);
            // 
            // nine_button
            // 
            this.nine_button.Location = new System.Drawing.Point(136, 275);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(49, 41);
            this.nine_button.TabIndex = 17;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.nine_button_Click);
            // 
            // eight_button
            // 
            this.eight_button.Location = new System.Drawing.Point(74, 275);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(49, 41);
            this.eight_button.TabIndex = 16;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.eight_button_Click);
            // 
            // seven_button
            // 
            this.seven_button.Location = new System.Drawing.Point(12, 275);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(49, 41);
            this.seven_button.TabIndex = 15;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.seven_button_Click);
            // 
            // equal_button
            // 
            this.equal_button.Location = new System.Drawing.Point(74, 322);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(111, 41);
            this.equal_button.TabIndex = 20;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = true;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            // 
            // zero_button
            // 
            this.zero_button.Location = new System.Drawing.Point(12, 322);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(49, 41);
            this.zero_button.TabIndex = 18;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            this.zero_button.Click += new System.EventHandler(this.zero_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 22;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.division_button);
            this.Controls.Add(this.multiply_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.percent_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.memoryin_button);
            this.Controls.Add(this.memoryout_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button memoryout_button;
        private System.Windows.Forms.Button memoryin_button;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button percent_button;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button multiply_button;
        private System.Windows.Forms.Button division_button;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button equal_button;
        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

