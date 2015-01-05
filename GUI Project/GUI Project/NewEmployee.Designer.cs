namespace GUI_Project
{
    partial class NewEmployee
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
            this.ЕГН = new System.Windows.Forms.Label();
            this.egnText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.име = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.middleNameText = new System.Windows.Forms.TextBox();
            this.familyNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.professionText = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentText = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentText = new System.Windows.Forms.TextBox();
            this.startDateText = new System.Windows.Forms.MonthCalendar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ЕГН
            // 
            this.ЕГН.AutoSize = true;
            this.ЕГН.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ЕГН.Location = new System.Drawing.Point(170, 39);
            this.ЕГН.Name = "ЕГН";
            this.ЕГН.Size = new System.Drawing.Size(41, 20);
            this.ЕГН.TabIndex = 0;
            this.ЕГН.Text = "ЕГН";
            this.ЕГН.Click += new System.EventHandler(this.label1_Click);
            // 
            // egnText
            // 
            this.egnText.Location = new System.Drawing.Point(304, 39);
            this.egnText.Name = "egnText";
            this.egnText.Size = new System.Drawing.Size(188, 20);
            this.egnText.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(544, 603);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(144, 53);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // име
            // 
            this.име.AutoSize = true;
            this.име.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.име.Location = new System.Drawing.Point(170, 80);
            this.име.Name = "име";
            this.име.Size = new System.Drawing.Size(40, 20);
            this.име.TabIndex = 3;
            this.име.Text = "Име";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(304, 79);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(188, 20);
            this.nameText.TabIndex = 4;
            // 
            // middleNameText
            // 
            this.middleNameText.Location = new System.Drawing.Point(304, 120);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.Size = new System.Drawing.Size(188, 20);
            this.middleNameText.TabIndex = 5;
            // 
            // familyNameText
            // 
            this.familyNameText.Location = new System.Drawing.Point(304, 159);
            this.familyNameText.Name = "familyNameText";
            this.familyNameText.Size = new System.Drawing.Size(188, 20);
            this.familyNameText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Презиме";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(171, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // professionText
            // 
            this.professionText.FormattingEnabled = true;
            this.professionText.Location = new System.Drawing.Point(304, 201);
            this.professionText.Name = "professionText";
            this.professionText.Size = new System.Drawing.Size(188, 21);
            this.professionText.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(171, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Професия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(171, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Отдел";
            // 
            // departmentText
            // 
            this.departmentText.FormattingEnabled = true;
            this.departmentText.Location = new System.Drawing.Point(304, 243);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(188, 21);
            this.departmentText.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(171, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Заплата";
            // 
            // paymentText
            // 
            this.paymentText.Location = new System.Drawing.Point(304, 282);
            this.paymentText.Name = "paymentText";
            this.paymentText.Size = new System.Drawing.Size(188, 20);
            this.paymentText.TabIndex = 14;
            // 
            // startDateText
            // 
            this.startDateText.Location = new System.Drawing.Point(304, 329);
            this.startDateText.Name = "startDateText";
            this.startDateText.TabIndex = 15;
            this.startDateText.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.startDateText_DateChanged);
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 719);
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
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.egnText);
            this.Controls.Add(this.ЕГН);
            this.Name = "NewEmployee";
            this.Text = "New Employee";
            this.Load += new System.EventHandler(this.NewEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ЕГН;
        private System.Windows.Forms.TextBox egnText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label име;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox middleNameText;
        private System.Windows.Forms.TextBox familyNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox professionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox departmentText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paymentText;
        private System.Windows.Forms.MonthCalendar startDateText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

