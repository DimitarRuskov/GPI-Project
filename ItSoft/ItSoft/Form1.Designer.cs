namespace ItSoft
{
    partial class StartForm
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
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новСлужителToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авториToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.промянаНаЗаплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияЗаСлужителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкиToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.справкиToolStripMenuItem1,
            this.помощToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новСлужителToolStripMenuItem,
            this.изходToolStripMenuItem,
            this.промянаНаЗаплатаToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.справкаToolStripMenuItem.Text = "Редакция";
            // 
            // новСлужителToolStripMenuItem
            // 
            this.новСлужителToolStripMenuItem.Name = "новСлужителToolStripMenuItem";
            this.новСлужителToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.новСлужителToolStripMenuItem.Text = "Нов Служител";
            this.новСлужителToolStripMenuItem.Click += new System.EventHandler(this.новСлужителToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изходToolStripMenuItem1});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.справкиToolStripMenuItem.Text = "Начало";
            // 
            // помощToolStripMenuItem
            // 
            this.помощToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авториToolStripMenuItem});
            this.помощToolStripMenuItem.Name = "помощToolStripMenuItem";
            this.помощToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.помощToolStripMenuItem.Text = "За Продукта";
            // 
            // авториToolStripMenuItem
            // 
            this.авториToolStripMenuItem.Name = "авториToolStripMenuItem";
            this.авториToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.авториToolStripMenuItem.Text = "Автори";
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.изходToolStripMenuItem.Text = "Премахване на служител";
            // 
            // промянаНаЗаплатаToolStripMenuItem
            // 
            this.промянаНаЗаплатаToolStripMenuItem.Name = "промянаНаЗаплатаToolStripMenuItem";
            this.промянаНаЗаплатаToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.промянаНаЗаплатаToolStripMenuItem.Text = "Промяна на заплата";
            // 
            // справкиToolStripMenuItem1
            // 
            this.справкиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияЗаСлужителиToolStripMenuItem});
            this.справкиToolStripMenuItem1.Name = "справкиToolStripMenuItem1";
            this.справкиToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem1.Text = "Справки";
            // 
            // информацияЗаСлужителиToolStripMenuItem
            // 
            this.информацияЗаСлужителиToolStripMenuItem.Name = "информацияЗаСлужителиToolStripMenuItem";
            this.информацияЗаСлужителиToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.информацияЗаСлужителиToolStripMenuItem.Text = "Информация за служители";
            // 
            // изходToolStripMenuItem1
            // 
            this.изходToolStripMenuItem1.Name = "изходToolStripMenuItem1";
            this.изходToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.изходToolStripMenuItem1.Text = "Изход";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 301);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новСлужителToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авториToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem промянаНаЗаплатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem информацияЗаСлужителиToolStripMenuItem;
    }
}

