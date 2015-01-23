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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Authors = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.началоToolStripMenuItem,
            this.EditMenu,
            this.ExportMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(528, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // началоToolStripMenuItem
            // 
            this.началоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изходToolStripMenuItem});
            this.началоToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Brick_house;
            this.началоToolStripMenuItem.Name = "началоToolStripMenuItem";
            this.началоToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.началоToolStripMenuItem.Text = "Начало";
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Exit;
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.изходToolStripMenuItem.Text = "Изход";
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEmployee,
            this.RemoveEmployee,
            this.ChangeSalary});
            this.EditMenu.Image = global::ItSoft.Properties.Resources.Edit;
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(93, 29);
            this.EditMenu.Text = "Редакция";
            this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // NewEmployee
            // 
            this.NewEmployee.Image = global::ItSoft.Properties.Resources.Users;
            this.NewEmployee.Name = "NewEmployee";
            this.NewEmployee.Size = new System.Drawing.Size(228, 22);
            this.NewEmployee.Text = "Нов Служител";
            this.NewEmployee.Click += new System.EventHandler(this.NewEmployee_Click);
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Image = global::ItSoft.Properties.Resources.User;
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(228, 22);
            this.RemoveEmployee.Text = "Премахване на служител";
            this.RemoveEmployee.Click += new System.EventHandler(this.RemoveEmployee_Click);
            // 
            // ChangeSalary
            // 
            this.ChangeSalary.Image = global::ItSoft.Properties.Resources.OK;
            this.ChangeSalary.Name = "ChangeSalary";
            this.ChangeSalary.Size = new System.Drawing.Size(228, 22);
            this.ChangeSalary.Text = "Промяна на заплата";
            this.ChangeSalary.Click += new System.EventHandler(this.ChangeSalary_Click);
            // 
            // ExportMenu
            // 
            this.ExportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeInfo});
            this.ExportMenu.Image = global::ItSoft.Properties.Resources.Properties;
            this.ExportMenu.Name = "ExportMenu";
            this.ExportMenu.Size = new System.Drawing.Size(86, 29);
            this.ExportMenu.Text = "Справки";
            this.ExportMenu.Click += new System.EventHandler(this.ExportMenu_Click);
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.Image = global::ItSoft.Properties.Resources.Diagram;
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Size = new System.Drawing.Size(236, 22);
            this.EmployeeInfo.Text = "Информация за служители";
            this.EmployeeInfo.Click += new System.EventHandler(this.EmployeeInfo_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Authors,
            this.ProductInfo});
            this.HelpMenu.Image = global::ItSoft.Properties.Resources.Help;
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(80, 29);
            this.HelpMenu.Text = "Помощ";
            // 
            // Authors
            // 
            this.Authors.Image = global::ItSoft.Properties.Resources.User_group;
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(152, 22);
            this.Authors.Text = "За Авторите";
            this.Authors.Click += new System.EventHandler(this.Authors_Click);
            // 
            // ProductInfo
            // 
            this.ProductInfo.Image = global::ItSoft.Properties.Resources.Application_form;
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.Size = new System.Drawing.Size(152, 22);
            this.ProductInfo.Text = "За Продукта";
            this.ProductInfo.Click += new System.EventHandler(this.ProductInfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(528, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 406);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Информационна Система на ИТСофт 2015";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem NewEmployee;
        private System.Windows.Forms.ToolStripMenuItem RemoveEmployee;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem Authors;
        private System.Windows.Forms.ToolStripMenuItem ChangeSalary;
        private System.Windows.Forms.ToolStripMenuItem ExportMenu;
        private System.Windows.Forms.ToolStripMenuItem EmployeeInfo;
        private System.Windows.Forms.ToolStripMenuItem ProductInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
    }
}

