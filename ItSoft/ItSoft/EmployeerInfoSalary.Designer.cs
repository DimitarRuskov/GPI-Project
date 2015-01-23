namespace ItSoft
{
    partial class EmployeerInfoSalary
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
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.buttonSalaryChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(31, 67);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 0;
            // 
            // buttonSalaryChange
            // 
            this.buttonSalaryChange.Location = new System.Drawing.Point(50, 155);
            this.buttonSalaryChange.Name = "buttonSalaryChange";
            this.buttonSalaryChange.Size = new System.Drawing.Size(75, 23);
            this.buttonSalaryChange.TabIndex = 1;
            this.buttonSalaryChange.Text = "Change";
            this.buttonSalaryChange.UseVisualStyleBackColor = true;
            this.buttonSalaryChange.Click += new System.EventHandler(this.buttonSalaryChange_Click);
            // 
            // EmployeerInfoSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSalaryChange);
            this.Controls.Add(this.textBoxSalary);
            this.Name = "EmployeerInfoSalary";
            this.Text = "EmployeerInfoSalary";
            this.Load += new System.EventHandler(this.EmployeerInfoSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Button buttonSalaryChange;
    }
}