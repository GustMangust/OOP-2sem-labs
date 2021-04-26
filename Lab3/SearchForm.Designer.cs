namespace WindowsFormsApp1
{
    partial class SearchForm
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
            this.LecturerSearchButton = new System.Windows.Forms.Button();
            this.SemestrSearchButton = new System.Windows.Forms.Button();
            this.KursSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LecturerSearchButton
            // 
            this.LecturerSearchButton.Location = new System.Drawing.Point(12, 12);
            this.LecturerSearchButton.Name = "LecturerSearchButton";
            this.LecturerSearchButton.Size = new System.Drawing.Size(318, 67);
            this.LecturerSearchButton.TabIndex = 0;
            this.LecturerSearchButton.Text = "По лектору";
            this.LecturerSearchButton.UseVisualStyleBackColor = true;
            this.LecturerSearchButton.Click += new System.EventHandler(this.LecturerSearchButton_Click);
            // 
            // SemestrSearchButton
            // 
            this.SemestrSearchButton.Location = new System.Drawing.Point(12, 104);
            this.SemestrSearchButton.Name = "SemestrSearchButton";
            this.SemestrSearchButton.Size = new System.Drawing.Size(318, 67);
            this.SemestrSearchButton.TabIndex = 1;
            this.SemestrSearchButton.Text = "По семестру";
            this.SemestrSearchButton.UseVisualStyleBackColor = true;
            this.SemestrSearchButton.Click += new System.EventHandler(this.SemestrSearchButton_Click);
            // 
            // KursSearchButton
            // 
            this.KursSearchButton.Location = new System.Drawing.Point(12, 200);
            this.KursSearchButton.Name = "KursSearchButton";
            this.KursSearchButton.Size = new System.Drawing.Size(318, 67);
            this.KursSearchButton.TabIndex = 2;
            this.KursSearchButton.Text = "По курсу";
            this.KursSearchButton.UseVisualStyleBackColor = true;
            this.KursSearchButton.Click += new System.EventHandler(this.KursSearchButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 291);
            this.Controls.Add(this.KursSearchButton);
            this.Controls.Add(this.SemestrSearchButton);
            this.Controls.Add(this.LecturerSearchButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LecturerSearchButton;
        private System.Windows.Forms.Button SemestrSearchButton;
        private System.Windows.Forms.Button KursSearchButton;
    }
}