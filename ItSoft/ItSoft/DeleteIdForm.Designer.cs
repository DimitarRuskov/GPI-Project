namespace ItSoft
{
    partial class IDDeleteForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDDeleteForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelDeletedForm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.labelDeleteForm = new System.Windows.Forms.Label();
            this.idToDelete = new System.Windows.Forms.TextBox();
            this.IDDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formNewEmploBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formNewEmploBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // labelDeletedForm
            // 
            this.labelDeletedForm.AutoSize = true;
            this.labelDeletedForm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeletedForm.Location = new System.Drawing.Point(57, 34);
            this.labelDeletedForm.Name = "labelDeletedForm";
            this.labelDeletedForm.Size = new System.Drawing.Size(285, 23);
            this.labelDeletedForm.TabIndex = 6;
            this.labelDeletedForm.Text = "Изтриване на служител по ЕГН";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.labelDeleteForm);
            this.groupBox1.Controls.Add(this.idToDelete);
            this.groupBox1.Controls.Add(this.IDDelete);
            this.groupBox1.Location = new System.Drawing.Point(21, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Секция за изтриване";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Image = global::ItSoft.Properties.Resources.Exit2;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(212, 94);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(98, 39);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Изход";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // labelDeleteForm
            // 
            this.labelDeleteForm.AutoSize = true;
            this.labelDeleteForm.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeleteForm.Location = new System.Drawing.Point(20, 46);
            this.labelDeleteForm.Name = "labelDeleteForm";
            this.labelDeleteForm.Size = new System.Drawing.Size(90, 16);
            this.labelDeleteForm.TabIndex = 8;
            this.labelDeleteForm.Text = "Въведи ЕГН:";
            // 
            // idToDelete
            // 
            this.idToDelete.Location = new System.Drawing.Point(23, 65);
            this.idToDelete.Multiline = true;
            this.idToDelete.Name = "idToDelete";
            this.idToDelete.Size = new System.Drawing.Size(143, 23);
            this.idToDelete.TabIndex = 7;
            this.idToDelete.TextChanged += new System.EventHandler(this.idToDelete_TextChanged);
            // 
            // IDDelete
            // 
            this.IDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDDelete.Image = global::ItSoft.Properties.Resources.Erase;
            this.IDDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IDDelete.Location = new System.Drawing.Point(212, 46);
            this.IDDelete.Name = "IDDelete";
            this.IDDelete.Size = new System.Drawing.Size(125, 42);
            this.IDDelete.TabIndex = 6;
            this.IDDelete.Text = "Изтриване";
            this.IDDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IDDelete.UseVisualStyleBackColor = true;
            this.IDDelete.Click += new System.EventHandler(this.IDDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.authorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Home;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.fileToolStripMenuItem.Text = "&Начало";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Erase;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.saveToolStripMenuItem.Text = "&Изтриване";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Exit2;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.authorsToolStripMenuItem.Image = global::ItSoft.Properties.Resources.Help;
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.authorsToolStripMenuItem.Text = "&Контакти";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::ItSoft.Properties.Resources.User_group;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.aboutToolStripMenuItem.Text = "&Автори";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // formNewEmploBindingSource
            // 
            this.formNewEmploBindingSource.DataSource = typeof(ItSoft.FormNewEmplo);
            // 
            // IDDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDeletedForm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IDDeleteForm";
            this.Text = "Изтриване на служител";
            this.Load += new System.EventHandler(this.IDDeleteForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formNewEmploBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource formNewEmploBindingSource;
        private System.Windows.Forms.Label labelDeletedForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idToDelete;
        private System.Windows.Forms.Button IDDelete;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label labelDeleteForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}