namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.RadioSem1 = new System.Windows.Forms.RadioButton();
            this.RadioSem2 = new System.Windows.Forms.RadioButton();
            this.KursList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpecList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountOfLectures = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountOfLabs = new System.Windows.Forms.TextBox();
            this.RadioOffset = new System.Windows.Forms.RadioButton();
            this.RadioExam = new System.Windows.Forms.RadioButton();
            this.FullnameOfLecturer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.TextBox();
            this.Cabinet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ToXml = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.NameOfDisc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.FileWrite = new System.Windows.Forms.TextBox();
            this.FromXml = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.toXMLtext = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплина";
            // 
            // RadioSem1
            // 
            this.RadioSem1.AutoSize = true;
            this.RadioSem1.Checked = true;
            this.RadioSem1.Location = new System.Drawing.Point(6, 0);
            this.RadioSem1.Name = "RadioSem1";
            this.RadioSem1.Size = new System.Drawing.Size(77, 17);
            this.RadioSem1.TabIndex = 1;
            this.RadioSem1.TabStop = true;
            this.RadioSem1.Text = "1 семестр";
            this.RadioSem1.UseVisualStyleBackColor = true;
            // 
            // RadioSem2
            // 
            this.RadioSem2.AutoSize = true;
            this.RadioSem2.Location = new System.Drawing.Point(6, 23);
            this.RadioSem2.Name = "RadioSem2";
            this.RadioSem2.Size = new System.Drawing.Size(77, 17);
            this.RadioSem2.TabIndex = 2;
            this.RadioSem2.Text = "2 семестр";
            this.RadioSem2.UseVisualStyleBackColor = true;
            // 
            // KursList
            // 
            this.KursList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KursList.FormattingEnabled = true;
            this.KursList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.KursList.Location = new System.Drawing.Point(290, 167);
            this.KursList.Name = "KursList";
            this.KursList.Size = new System.Drawing.Size(121, 21);
            this.KursList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Курс";
            // 
            // SpecList
            // 
            this.SpecList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecList.FormattingEnabled = true;
            this.SpecList.Items.AddRange(new object[] {
            "ПОИТ",
            "ДЭИВИ",
            "ИСИТ",
            "ПОИБМС"});
            this.SpecList.Location = new System.Drawing.Point(290, 207);
            this.SpecList.Name = "SpecList";
            this.SpecList.Size = new System.Drawing.Size(121, 21);
            this.SpecList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Специальность";
            // 
            // AmountOfLectures
            // 
            this.AmountOfLectures.Location = new System.Drawing.Point(290, 248);
            this.AmountOfLectures.Name = "AmountOfLectures";
            this.AmountOfLectures.Size = new System.Drawing.Size(100, 20);
            this.AmountOfLectures.TabIndex = 7;
            this.AmountOfLectures.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountOfKeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество лекций в семестре";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество лаб в семестре";
            // 
            // AmountOfLabs
            // 
            this.AmountOfLabs.Location = new System.Drawing.Point(290, 296);
            this.AmountOfLabs.Name = "AmountOfLabs";
            this.AmountOfLabs.Size = new System.Drawing.Size(100, 20);
            this.AmountOfLabs.TabIndex = 9;
            this.AmountOfLabs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountOfKeyPress);
            // 
            // RadioOffset
            // 
            this.RadioOffset.AutoSize = true;
            this.RadioOffset.Location = new System.Drawing.Point(4, 26);
            this.RadioOffset.Name = "RadioOffset";
            this.RadioOffset.Size = new System.Drawing.Size(54, 17);
            this.RadioOffset.TabIndex = 12;
            this.RadioOffset.Text = "Зачёт";
            this.RadioOffset.UseVisualStyleBackColor = true;
            // 
            // RadioExam
            // 
            this.RadioExam.AutoSize = true;
            this.RadioExam.Checked = true;
            this.RadioExam.Location = new System.Drawing.Point(4, 3);
            this.RadioExam.Name = "RadioExam";
            this.RadioExam.Size = new System.Drawing.Size(70, 17);
            this.RadioExam.TabIndex = 11;
            this.RadioExam.TabStop = true;
            this.RadioExam.Text = "Экзамен";
            this.RadioExam.UseVisualStyleBackColor = true;
            // 
            // FullnameOfLecturer
            // 
            this.FullnameOfLecturer.Location = new System.Drawing.Point(290, 458);
            this.FullnameOfLecturer.Name = "FullnameOfLecturer";
            this.FullnameOfLecturer.Size = new System.Drawing.Size(100, 20);
            this.FullnameOfLecturer.TabIndex = 13;
            this.FullnameOfLecturer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringOfKeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Лектор";
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(290, 418);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(100, 20);
            this.Department.TabIndex = 16;
            this.Department.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringOfKeyPress);
            // 
            // Cabinet
            // 
            this.Cabinet.Location = new System.Drawing.Point(287, 520);
            this.Cabinet.Name = "Cabinet";
            this.Cabinet.Size = new System.Drawing.Size(100, 20);
            this.Cabinet.TabIndex = 17;
            this.Cabinet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CabinetOfKeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Кафедра";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "ФИО";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Аудитория";
            // 
            // ToXml
            // 
            this.ToXml.Location = new System.Drawing.Point(55, 19);
            this.ToXml.Name = "ToXml";
            this.ToXml.Size = new System.Drawing.Size(75, 23);
            this.ToXml.TabIndex = 26;
            this.ToXml.Text = "ToXml";
            this.ToXml.UseVisualStyleBackColor = true;
            this.ToXml.Click += new System.EventHandler(this.ToXml_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.RadioSem2);
            this.groupBox1.Controls.Add(this.RadioSem1);
            this.groupBox1.Location = new System.Drawing.Point(290, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 40);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioExam);
            this.panel1.Controls.Add(this.RadioOffset);
            this.panel1.Location = new System.Drawing.Point(290, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 59);
            this.panel1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Пример: 415-4";
            // 
            // NameOfDisc
            // 
            this.NameOfDisc.Location = new System.Drawing.Point(290, 77);
            this.NameOfDisc.Name = "NameOfDisc";
            this.NameOfDisc.Size = new System.Drawing.Size(100, 20);
            this.NameOfDisc.TabIndex = 30;
            this.NameOfDisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringOfKeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Название";
            // 
            // FileWrite
            // 
            this.FileWrite.Location = new System.Drawing.Point(90, 49);
            this.FileWrite.Name = "FileWrite";
            this.FileWrite.Size = new System.Drawing.Size(126, 20);
            this.FileWrite.TabIndex = 33;
            this.FileWrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringOfKeyPress);
            // 
            // FromXml
            // 
            this.FromXml.Location = new System.Drawing.Point(55, 78);
            this.FromXml.Name = "FromXml";
            this.FromXml.Size = new System.Drawing.Size(75, 23);
            this.FromXml.TabIndex = 34;
            this.FromXml.Text = "FromXml";
            this.FromXml.UseVisualStyleBackColor = true;
            this.FromXml.Click += new System.EventHandler(this.FromXml_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Имя файла";
            // 
            // toXMLtext
            // 
            this.toXMLtext.Location = new System.Drawing.Point(15, 108);
            this.toXMLtext.Multiline = true;
            this.toXMLtext.Name = "toXMLtext";
            this.toXMLtext.ReadOnly = true;
            this.toXMLtext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.toXMLtext.Size = new System.Drawing.Size(238, 432);
            this.toXMLtext.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 634);
            this.Controls.Add(this.toXMLtext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FromXml);
            this.Controls.Add(this.FileWrite);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NameOfDisc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ToXml);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cabinet);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FullnameOfLecturer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountOfLabs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountOfLectures);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpecList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KursList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioSem1;
        private System.Windows.Forms.RadioButton RadioSem2;
        private System.Windows.Forms.ComboBox KursList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SpecList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmountOfLectures;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmountOfLabs;
        private System.Windows.Forms.RadioButton RadioOffset;
        private System.Windows.Forms.RadioButton RadioExam;
        private System.Windows.Forms.TextBox FullnameOfLecturer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.TextBox Cabinet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ToXml;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameOfDisc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox FileWrite;
        private System.Windows.Forms.Button FromXml;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox toXMLtext;
    }
}

