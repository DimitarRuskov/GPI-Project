namespace ItSoft
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Authors = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.License = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenu,
            this.EditMenu,
            this.ExportMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(659, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeMenu
            // 
            this.HomeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenu});
            this.HomeMenu.Name = "HomeMenu";
            this.HomeMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.HomeMenu.Size = new System.Drawing.Size(73, 25);
            this.HomeMenu.Text = "&Начало";
            this.HomeMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HomeMenu.Click += new System.EventHandler(this.HomeMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(120, 24);
            this.ExitMenu.Text = "Изход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEmployee,
            this.RemoveEmployee,
            this.ChangeSalary});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(86, 25);
            this.EditMenu.Text = "Редакция";
            this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // NewEmployee
            // 
            this.NewEmployee.Name = "NewEmployee";
            this.NewEmployee.Size = new System.Drawing.Size(254, 24);
            this.NewEmployee.Text = "Нов Служител";
            this.NewEmployee.Click += new System.EventHandler(this.NewEmployee_Click);
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(254, 24);
            this.RemoveEmployee.Text = "Премахване на служител";
            this.RemoveEmployee.Click += new System.EventHandler(this.RemoveEmployee_Click);
            // 
            // ChangeSalary
            // 
            this.ChangeSalary.Name = "ChangeSalary";
            this.ChangeSalary.Size = new System.Drawing.Size(254, 24);
            this.ChangeSalary.Text = "Промяна на заплата";
            this.ChangeSalary.Click += new System.EventHandler(this.ChangeSalary_Click);
            // 
            // ExportMenu
            // 
            this.ExportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeInfo});
            this.ExportMenu.Name = "ExportMenu";
            this.ExportMenu.Size = new System.Drawing.Size(80, 25);
            this.ExportMenu.Text = "Справки";
            this.ExportMenu.Click += new System.EventHandler(this.ExportMenu_Click);
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Size = new System.Drawing.Size(267, 24);
            this.EmployeeInfo.Text = "Информация за служители";
            this.EmployeeInfo.Click += new System.EventHandler(this.EmployeeInfo_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Authors,
            this.ProductInfo,
            this.License});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(73, 25);
            this.HelpMenu.Text = "Помощ";
            // 
            // Authors
            // 
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(163, 24);
            this.Authors.Text = "За Авторите";
            this.Authors.Click += new System.EventHandler(this.Authors_Click);
            // 
            // ProductInfo
            // 
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.Size = new System.Drawing.Size(163, 24);
            this.ProductInfo.Text = "За Продукта";
            this.ProductInfo.Click += new System.EventHandler(this.ProductInfo_Click);
            // 
            // License
            // 
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(163, 24);
            this.License.Text = "Лиценз";
            this.License.Click += new System.EventHandler(this.License_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(659, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem NewEmployee;
        private System.Windows.Forms.ToolStripMenuItem RemoveEmployee;
        private System.Windows.Forms.ToolStripMenuItem HomeMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem Authors;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeSalary;
        private System.Windows.Forms.ToolStripMenuItem ExportMenu;
        private System.Windows.Forms.ToolStripMenuItem EmployeeInfo;
        private System.Windows.Forms.ToolStripMenuItem ProductInfo;
        private System.Windows.Forms.ToolStripMenuItem License;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

