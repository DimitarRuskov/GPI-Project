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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.IDDelete = new System.Windows.Forms.Button();
            this.formNewEmploBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.idToDelete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.formNewEmploBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // IDDelete
            // 
            this.IDDelete.Location = new System.Drawing.Point(227, 74);
            this.IDDelete.Name = "IDDelete";
            this.IDDelete.Size = new System.Drawing.Size(75, 23);
            this.IDDelete.TabIndex = 2;
            this.IDDelete.Text = "Изтриване";
            this.IDDelete.UseVisualStyleBackColor = true;
            this.IDDelete.Click += new System.EventHandler(this.IDDelete_Click);
            // 
            // formNewEmploBindingSource
            // 
            this.formNewEmploBindingSource.DataSource = typeof(ItSoft.FormNewEmplo);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(227, 36);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Търсене";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // idToDelete
            // 
            this.idToDelete.Location = new System.Drawing.Point(22, 36);
            this.idToDelete.Name = "idToDelete";
            this.idToDelete.Size = new System.Drawing.Size(135, 20);
            this.idToDelete.TabIndex = 5;
            this.idToDelete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IDDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 375);
            this.Controls.Add(this.idToDelete);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IDDelete);
            this.Name = "IDDeleteForm";
            this.Text = "DeleteIdForm";
            this.Load += new System.EventHandler(this.IDDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formNewEmploBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource formNewEmploBindingSource;
        private System.Windows.Forms.Button IDDelete;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox idToDelete;

    }
}