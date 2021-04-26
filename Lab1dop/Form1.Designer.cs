namespace Lab1dop
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
            this.ClothesText = new System.Windows.Forms.TextBox();
            this.ShoesText = new System.Windows.Forms.TextBox();
            this.ClothesLabel = new System.Windows.Forms.Label();
            this.ShoesLabel = new System.Windows.Forms.Label();
            this.American = new System.Windows.Forms.Button();
            this.Belarussian = new System.Windows.Forms.Button();
            this.Britain = new System.Windows.Forms.Button();
            this.Europian = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClothesText
            // 
            this.ClothesText.Location = new System.Drawing.Point(15, 153);
            this.ClothesText.Name = "ClothesText";
            this.ClothesText.Size = new System.Drawing.Size(115, 20);
            this.ClothesText.TabIndex = 0;
            this.ClothesText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // ShoesText
            // 
            this.ShoesText.Location = new System.Drawing.Point(228, 153);
            this.ShoesText.Name = "ShoesText";
            this.ShoesText.Size = new System.Drawing.Size(115, 20);
            this.ShoesText.TabIndex = 1;
            this.ShoesText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // ClothesLabel
            // 
            this.ClothesLabel.AutoSize = true;
            this.ClothesLabel.Location = new System.Drawing.Point(12, 186);
            this.ClothesLabel.Name = "ClothesLabel";
            this.ClothesLabel.Size = new System.Drawing.Size(0, 13);
            this.ClothesLabel.TabIndex = 2;
            // 
            // ShoesLabel
            // 
            this.ShoesLabel.AutoSize = true;
            this.ShoesLabel.Location = new System.Drawing.Point(225, 186);
            this.ShoesLabel.Name = "ShoesLabel";
            this.ShoesLabel.Size = new System.Drawing.Size(0, 13);
            this.ShoesLabel.TabIndex = 3;
            // 
            // American
            // 
            this.American.Location = new System.Drawing.Point(15, 226);
            this.American.Name = "American";
            this.American.Size = new System.Drawing.Size(328, 51);
            this.American.TabIndex = 4;
            this.American.Text = "American";
            this.American.UseVisualStyleBackColor = true;
            this.American.Click += new System.EventHandler(this.American_Click);
            // 
            // Belarussian
            // 
            this.Belarussian.Location = new System.Drawing.Point(15, 283);
            this.Belarussian.Name = "Belarussian";
            this.Belarussian.Size = new System.Drawing.Size(328, 51);
            this.Belarussian.TabIndex = 5;
            this.Belarussian.Text = "Belarussian";
            this.Belarussian.UseVisualStyleBackColor = true;
            this.Belarussian.Click += new System.EventHandler(this.Belarussian_Click);
            // 
            // Britain
            // 
            this.Britain.Location = new System.Drawing.Point(15, 397);
            this.Britain.Name = "Britain";
            this.Britain.Size = new System.Drawing.Size(328, 51);
            this.Britain.TabIndex = 7;
            this.Britain.Text = "Britain";
            this.Britain.UseVisualStyleBackColor = true;
            this.Britain.Click += new System.EventHandler(this.Britain_Click);
            // 
            // Europian
            // 
            this.Europian.Location = new System.Drawing.Point(15, 340);
            this.Europian.Name = "Europian";
            this.Europian.Size = new System.Drawing.Size(328, 51);
            this.Europian.TabIndex = 8;
            this.Europian.Text = "Europian";
            this.Europian.UseVisualStyleBackColor = true;
            this.Europian.Click += new System.EventHandler(this.Europian_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите рост от 170см до 195см";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(223, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите размер ноги от 23см до 30см";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(116, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 81);
            this.label3.TabIndex = 11;
            this.label3.Text = "Конвертер размеров мужской одежды и обуви ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(87, 210);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 477);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Europian);
            this.Controls.Add(this.Britain);
            this.Controls.Add(this.Belarussian);
            this.Controls.Add(this.American);
            this.Controls.Add(this.ShoesLabel);
            this.Controls.Add(this.ClothesLabel);
            this.Controls.Add(this.ShoesText);
            this.Controls.Add(this.ClothesText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClothesText;
        private System.Windows.Forms.TextBox ShoesText;
        private System.Windows.Forms.Label ClothesLabel;
        private System.Windows.Forms.Label ShoesLabel;
        private System.Windows.Forms.Button American;
        private System.Windows.Forms.Button Belarussian;
        private System.Windows.Forms.Button Britain;
        private System.Windows.Forms.Button Europian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

