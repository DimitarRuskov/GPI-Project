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
            this.formNewEmploBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDeletedForm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.labelDeleteForm = new System.Windows.Forms.Label();
            this.idToDelete = new System.Windows.Forms.TextBox();
            this.IDDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formNewEmploBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // formNewEmploBindingSource
            // 
            this.formNewEmploBindingSource.DataSource = typeof(ItSoft.FormNewEmplo);
            // 
            // labelDeletedForm
            // 
            this.labelDeletedForm.AutoSize = true;
            this.labelDeletedForm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeletedForm.Location = new System.Drawing.Point(68, 19);
            this.labelDeletedForm.Name = "labelDeletedForm";
            this.labelDeletedForm.Size = new System.Drawing.Size(218, 23);
            this.labelDeletedForm.TabIndex = 6;
            this.labelDeletedForm.Text = "Изтриване на служител ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.labelDeleteForm);
            this.groupBox1.Controls.Add(this.idToDelete);
            this.groupBox1.Controls.Add(this.IDDelete);
            this.groupBox1.Location = new System.Drawing.Point(21, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Секция за изтриване";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(201, 105);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Изход";
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
            this.idToDelete.Size = new System.Drawing.Size(135, 32);
            this.idToDelete.TabIndex = 7;
            this.idToDelete.TextChanged += new System.EventHandler(this.idToDelete_TextChanged);
            // 
            // IDDelete
            // 
            this.IDDelete.Location = new System.Drawing.Point(201, 65);
            this.IDDelete.Name = "IDDelete";
            this.IDDelete.Size = new System.Drawing.Size(75, 23);
            this.IDDelete.TabIndex = 6;
            this.IDDelete.Text = "Изтриване";
            this.IDDelete.UseVisualStyleBackColor = true;
            this.IDDelete.Click += new System.EventHandler(this.IDDelete_Click);
            // 
            // IDDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDeletedForm);
            this.Name = "IDDeleteForm";
            this.Text = "DeleteIdForm";
            this.Load += new System.EventHandler(this.IDDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formNewEmploBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

    }
}