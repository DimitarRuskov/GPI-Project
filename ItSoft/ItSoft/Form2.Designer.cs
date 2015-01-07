namespace ItSoft
{
    partial class FormNewEmplo
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
            this.startDateText = new System.Windows.Forms.MonthCalendar();
            this.paymentText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.departmentText = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.professionText = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.familyNameText = new System.Windows.Forms.TextBox();
            this.middleNameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.име = new System.Windows.Forms.Label();
            this.egnText = new System.Windows.Forms.TextBox();
            this.ЕГН = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.textBoxDateOfStart = new System.Windows.Forms.TextBox();
            this.LabelDateOfStart = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startDateText
            // 
            this.startDateText.Location = new System.Drawing.Point(323, 47);
            this.startDateText.Name = "startDateText";
            this.startDateText.TabIndex = 30;
            // 
            // paymentText
            // 
            this.paymentText.Location = new System.Drawing.Point(82, 387);
            this.paymentText.Name = "paymentText";
            this.paymentText.Size = new System.Drawing.Size(188, 20);
            this.paymentText.TabIndex = 29;
            this.paymentText.TextChanged += new System.EventHandler(this.paymentText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(83, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Заплата";
            // 
            // departmentText
            // 
            this.departmentText.FormattingEnabled = true;
            this.departmentText.Items.AddRange(new object[] {
            "Качество по кода",
            "Техническа поддръжка",
            "Мениджмънт",
            "IT разработка",
            "UNIT тестване"});
            this.departmentText.Location = new System.Drawing.Point(81, 328);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(188, 21);
            this.departmentText.TabIndex = 27;
            this.departmentText.SelectedIndexChanged += new System.EventHandler(this.departmentText_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Отдел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(80, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Професия";
            // 
            // professionText
            // 
            this.professionText.FormattingEnabled = true;
            this.professionText.Items.AddRange(new object[] {
            "QA инженер",
            "Java програмист",
            "Android програмист",
            "Web програмист",
            "Java програмист",
            "Системен администратор",
            "Стажант"});
            this.professionText.Location = new System.Drawing.Point(80, 269);
            this.professionText.Name = "professionText";
            this.professionText.Size = new System.Drawing.Size(188, 21);
            this.professionText.TabIndex = 24;
            this.professionText.SelectedIndexChanged += new System.EventHandler(this.professionText_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(77, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(78, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Презиме";
            // 
            // familyNameText
            // 
            this.familyNameText.Location = new System.Drawing.Point(80, 212);
            this.familyNameText.Name = "familyNameText";
            this.familyNameText.Size = new System.Drawing.Size(188, 20);
            this.familyNameText.TabIndex = 21;
            // 
            // middleNameText
            // 
            this.middleNameText.Location = new System.Drawing.Point(80, 156);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.Size = new System.Drawing.Size(188, 20);
            this.middleNameText.TabIndex = 20;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(80, 99);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(188, 20);
            this.nameText.TabIndex = 19;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            this.nameText.Validated += new System.EventHandler(this.nameText_TextChanged);
            // 
            // име
            // 
            this.име.AutoSize = true;
            this.име.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.име.Location = new System.Drawing.Point(77, 76);
            this.име.Name = "име";
            this.име.Size = new System.Drawing.Size(40, 20);
            this.име.TabIndex = 18;
            this.име.Text = "Име";
            // 
            // egnText
            // 
            this.egnText.Location = new System.Drawing.Point(80, 44);
            this.egnText.Name = "egnText";
            this.egnText.Size = new System.Drawing.Size(188, 20);
            this.egnText.TabIndex = 17;
            this.egnText.TextChanged += new System.EventHandler(this.egnText_TextChanged);
            // 
            // ЕГН
            // 
            this.ЕГН.AutoSize = true;
            this.ЕГН.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ЕГН.Location = new System.Drawing.Point(76, 21);
            this.ЕГН.Name = "ЕГН";
            this.ЕГН.Size = new System.Drawing.Size(41, 20);
            this.ЕГН.TabIndex = 16;
            this.ЕГН.Text = "ЕГН";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(364, 393);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(144, 53);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Запис";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textBoxDateOfStart
            // 
            this.textBoxDateOfStart.Location = new System.Drawing.Point(84, 449);
            this.textBoxDateOfStart.Name = "textBoxDateOfStart";
            this.textBoxDateOfStart.Size = new System.Drawing.Size(188, 20);
            this.textBoxDateOfStart.TabIndex = 33;
            this.textBoxDateOfStart.TextChanged += new System.EventHandler(this.textBoxDateOfStart_TextChanged);
            // 
            // LabelDateOfStart
            // 
            this.LabelDateOfStart.AutoSize = true;
            this.LabelDateOfStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDateOfStart.Location = new System.Drawing.Point(80, 426);
            this.LabelDateOfStart.Name = "LabelDateOfStart";
            this.LabelDateOfStart.Size = new System.Drawing.Size(165, 20);
            this.LabelDateOfStart.TabIndex = 32;
            this.LabelDateOfStart.Text = "Дата на постъпване";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(364, 479);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(144, 53);
            this.buttonExit.TabIndex = 34;
            this.buttonExit.Text = "Изход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNewEmplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 544);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxDateOfStart);
            this.Controls.Add(this.LabelDateOfStart);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startDateText);
            this.Controls.Add(this.paymentText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.departmentText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.professionText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.familyNameText);
            this.Controls.Add(this.middleNameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.име);
            this.Controls.Add(this.egnText);
            this.Controls.Add(this.ЕГН);
            this.Name = "FormNewEmplo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar startDateText;
        private System.Windows.Forms.TextBox paymentText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox departmentText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox professionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox familyNameText;
        private System.Windows.Forms.TextBox middleNameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label име;
        private System.Windows.Forms.TextBox egnText;
        private System.Windows.Forms.Label ЕГН;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textBoxDateOfStart;
        private System.Windows.Forms.Label LabelDateOfStart;
        private System.Windows.Forms.Button buttonExit;
    }
}