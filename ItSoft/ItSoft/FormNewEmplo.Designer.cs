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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewEmplo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmploInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewEmpGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.familyNameText = new System.Windows.Forms.TextBox();
            this.middleNameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.име = new System.Windows.Forms.Label();
            this.egnText = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.NewEmploGroupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelDateOfStart = new System.Windows.Forms.Label();
            this.paymentText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.departmentText = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.professionText = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.NewEmpGroupBox.SuspendLayout();
            this.NewEmploGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 31);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Home;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.fileToolStripMenuItem.Text = "&Начало";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmploInfoToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Notes;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.toolsToolStripMenuItem.Text = "&Редакция";
            // 
            // EmploInfoToolStripMenuItem
            // 
            this.EmploInfoToolStripMenuItem.Image = global::ItSoft.Properties.Resources.User_group;
            this.EmploInfoToolStripMenuItem.Name = "EmploInfoToolStripMenuItem";
            this.EmploInfoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.EmploInfoToolStripMenuItem.Text = "&Информация за служители";
            this.EmploInfoToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::ItSoft.Properties.Resources.User;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.optionsToolStripMenuItem.Text = "&Изтриване на служител";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.helpToolStripMenuItem.Text = "&Контакти";
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Notes;
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.authorsToolStripMenuItem.Text = "&Автори";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::ItSoft.Properties.Resources.OK;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "&За Продукта";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NewEmpGroupBox
            // 
            this.NewEmpGroupBox.Controls.Add(this.label2);
            this.NewEmpGroupBox.Controls.Add(this.label1);
            this.NewEmpGroupBox.Controls.Add(this.familyNameText);
            this.NewEmpGroupBox.Controls.Add(this.middleNameText);
            this.NewEmpGroupBox.Controls.Add(this.nameText);
            this.NewEmpGroupBox.Controls.Add(this.име);
            this.NewEmpGroupBox.Controls.Add(this.egnText);
            this.NewEmpGroupBox.Controls.Add(this.ID);
            this.NewEmpGroupBox.Location = new System.Drawing.Point(28, 44);
            this.NewEmpGroupBox.Name = "NewEmpGroupBox";
            this.NewEmpGroupBox.Size = new System.Drawing.Size(640, 160);
            this.NewEmpGroupBox.TabIndex = 37;
            this.NewEmpGroupBox.TabStop = false;
            this.NewEmpGroupBox.Text = "Данни за служителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(434, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(224, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Презиме";
            // 
            // familyNameText
            // 
            this.familyNameText.Location = new System.Drawing.Point(437, 51);
            this.familyNameText.Name = "familyNameText";
            this.familyNameText.Size = new System.Drawing.Size(188, 20);
            this.familyNameText.TabIndex = 37;
            this.familyNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.familyNameText_KeyPress);
            // 
            // middleNameText
            // 
            this.middleNameText.Location = new System.Drawing.Point(226, 51);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.Size = new System.Drawing.Size(188, 20);
            this.middleNameText.TabIndex = 36;
            this.middleNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.middleNameText_KeyPress);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(14, 51);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(188, 20);
            this.nameText.TabIndex = 35;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            this.nameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameText_KeyPress);
            this.nameText.Validated += new System.EventHandler(this.nameText_TextChanged);
            // 
            // име
            // 
            this.име.AutoSize = true;
            this.име.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.име.Location = new System.Drawing.Point(11, 28);
            this.име.Name = "име";
            this.име.Size = new System.Drawing.Size(40, 20);
            this.име.TabIndex = 34;
            this.име.Text = "Име";
            // 
            // egnText
            // 
            this.egnText.Location = new System.Drawing.Point(15, 125);
            this.egnText.Name = "egnText";
            this.egnText.Size = new System.Drawing.Size(188, 20);
            this.egnText.TabIndex = 33;
            this.egnText.Validating += new System.ComponentModel.CancelEventHandler(this.egnText_Validating);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.Location = new System.Drawing.Point(11, 102);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(41, 20);
            this.ID.TabIndex = 32;
            this.ID.Text = "ЕГН";
            // 
            // NewEmploGroupBox2
            // 
            this.NewEmploGroupBox2.Controls.Add(this.dateTimePicker1);
            this.NewEmploGroupBox2.Controls.Add(this.LabelDateOfStart);
            this.NewEmploGroupBox2.Controls.Add(this.paymentText);
            this.NewEmploGroupBox2.Controls.Add(this.label5);
            this.NewEmploGroupBox2.Controls.Add(this.departmentText);
            this.NewEmploGroupBox2.Controls.Add(this.label4);
            this.NewEmploGroupBox2.Controls.Add(this.label3);
            this.NewEmploGroupBox2.Controls.Add(this.professionText);
            this.NewEmploGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewEmploGroupBox2.Location = new System.Drawing.Point(28, 233);
            this.NewEmploGroupBox2.Name = "NewEmploGroupBox2";
            this.NewEmploGroupBox2.Size = new System.Drawing.Size(640, 172);
            this.NewEmploGroupBox2.TabIndex = 38;
            this.NewEmploGroupBox2.TabStop = false;
            this.NewEmploGroupBox2.Text = "Данни от фирмата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.Value = new System.DateTime(2015, 1, 18, 15, 38, 21, 0);
            // 
            // LabelDateOfStart
            // 
            this.LabelDateOfStart.AutoSize = true;
            this.LabelDateOfStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDateOfStart.Location = new System.Drawing.Point(245, 86);
            this.LabelDateOfStart.Name = "LabelDateOfStart";
            this.LabelDateOfStart.Size = new System.Drawing.Size(165, 20);
            this.LabelDateOfStart.TabIndex = 42;
            this.LabelDateOfStart.Text = "Дата на постъпване";
            // 
            // paymentText
            // 
            this.paymentText.Location = new System.Drawing.Point(249, 49);
            this.paymentText.Name = "paymentText";
            this.paymentText.Size = new System.Drawing.Size(188, 22);
            this.paymentText.TabIndex = 41;
            this.paymentText.TextChanged += new System.EventHandler(this.paymentText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(250, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Заплата";
            // 
            // departmentText
            // 
            this.departmentText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentText.FormattingEnabled = true;
            this.departmentText.Items.AddRange(new object[] {
            "Качество по кода",
            "Техническа поддръжка",
            "Мениджмънт",
            "IT разработка",
            "UNIT тестване"});
            this.departmentText.Location = new System.Drawing.Point(15, 120);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(188, 24);
            this.departmentText.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Отдел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Професия";
            // 
            // professionText
            // 
            this.professionText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.professionText.FormattingEnabled = true;
            this.professionText.Items.AddRange(new object[] {
            "QA Инженер",
            "Java Програмист",
            "Android Програмист",
            "Web Програмист",
            "Системен Администратор",
            "Стажант"});
            this.professionText.Location = new System.Drawing.Point(14, 49);
            this.professionText.Name = "professionText";
            this.professionText.Size = new System.Drawing.Size(188, 24);
            this.professionText.TabIndex = 36;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Image = global::ItSoft.Properties.Resources.Exit2;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.Location = new System.Drawing.Point(565, 427);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(103, 42);
            this.buttonExit.TabIndex = 34;
            this.buttonExit.Text = "Изход";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Image = global::ItSoft.Properties.Resources.Apply;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(436, 427);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 42);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Запис";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // FormNewEmplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 487);
            this.Controls.Add(this.NewEmploGroupBox2);
            this.Controls.Add(this.NewEmpGroupBox);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNewEmplo";
            this.Text = "Добавяне на нов служител";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.NewEmpGroupBox.ResumeLayout(false);
            this.NewEmpGroupBox.PerformLayout();
            this.NewEmploGroupBox2.ResumeLayout(false);
            this.NewEmploGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmploInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.GroupBox NewEmpGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox familyNameText;
        private System.Windows.Forms.TextBox middleNameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label име;
        private System.Windows.Forms.TextBox egnText;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.GroupBox NewEmploGroupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LabelDateOfStart;
        private System.Windows.Forms.TextBox paymentText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox departmentText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox professionText;
    }
}