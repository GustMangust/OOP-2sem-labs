namespace WindowsFormsApp1
{
    partial class LecturerSearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LecturerSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LecturerFormSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LecturerSearchTextBox
            // 
            this.LecturerSearchTextBox.Location = new System.Drawing.Point(42, 99);
            this.LecturerSearchTextBox.Name = "LecturerSearchTextBox";
            this.LecturerSearchTextBox.Size = new System.Drawing.Size(151, 20);
            this.LecturerSearchTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ФИО лектора";
            // 
            // LecturerFormSearchButton
            // 
            this.LecturerFormSearchButton.Location = new System.Drawing.Point(61, 138);
            this.LecturerFormSearchButton.Name = "LecturerFormSearchButton";
            this.LecturerFormSearchButton.Size = new System.Drawing.Size(120, 28);
            this.LecturerFormSearchButton.TabIndex = 2;
            this.LecturerFormSearchButton.Text = "Найти";
            this.LecturerFormSearchButton.UseVisualStyleBackColor = true;
            this.LecturerFormSearchButton.Click += new System.EventHandler(this.LecturerFormSearchButton_Click);
            // 
            // LecturerSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 190);
            this.Controls.Add(this.LecturerFormSearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LecturerSearchTextBox);
            this.Name = "LecturerSearchForm";
            this.Text = "LecturerSearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LecturerSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LecturerFormSearchButton;
    }
}