namespace ItSoft
{
    partial class AuthorForm
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
            this.AuthorDimityr = new System.Windows.Forms.GroupBox();
            this.pictureBoxDimityr = new System.Windows.Forms.PictureBox();
            this.AuthorGeorge = new System.Windows.Forms.GroupBox();
            this.pictureBoxGeorge = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorDimityr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDimityr)).BeginInit();
            this.AuthorGeorge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeorge)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorDimityr
            // 
            this.AuthorDimityr.Controls.Add(this.label4);
            this.AuthorDimityr.Controls.Add(this.label2);
            this.AuthorDimityr.Controls.Add(this.pictureBoxDimityr);
            this.AuthorDimityr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorDimityr.Location = new System.Drawing.Point(23, 205);
            this.AuthorDimityr.Name = "AuthorDimityr";
            this.AuthorDimityr.Size = new System.Drawing.Size(392, 160);
            this.AuthorDimityr.TabIndex = 0;
            this.AuthorDimityr.TabStop = false;
            this.AuthorDimityr.Text = "Димитър Русков";
            // 
            // pictureBoxDimityr
            // 
            this.pictureBoxDimityr.Image = global::ItSoft.Properties.Resources.d;
            this.pictureBoxDimityr.Location = new System.Drawing.Point(17, 41);
            this.pictureBoxDimityr.Name = "pictureBoxDimityr";
            this.pictureBoxDimityr.Size = new System.Drawing.Size(83, 84);
            this.pictureBoxDimityr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDimityr.TabIndex = 0;
            this.pictureBoxDimityr.TabStop = false;
            // 
            // AuthorGeorge
            // 
            this.AuthorGeorge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AuthorGeorge.Controls.Add(this.label3);
            this.AuthorGeorge.Controls.Add(this.label1);
            this.AuthorGeorge.Controls.Add(this.pictureBoxGeorge);
            this.AuthorGeorge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorGeorge.Location = new System.Drawing.Point(23, 23);
            this.AuthorGeorge.Name = "AuthorGeorge";
            this.AuthorGeorge.Size = new System.Drawing.Size(392, 161);
            this.AuthorGeorge.TabIndex = 1;
            this.AuthorGeorge.TabStop = false;
            this.AuthorGeorge.Text = "Георги Марушков";
            // 
            // pictureBoxGeorge
            // 
            this.pictureBoxGeorge.Image = global::ItSoft.Properties.Resources.g;
            this.pictureBoxGeorge.Location = new System.Drawing.Point(17, 40);
            this.pictureBoxGeorge.Name = "pictureBoxGeorge";
            this.pictureBoxGeorge.Size = new System.Drawing.Size(83, 83);
            this.pictureBoxGeorge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGeorge.TabIndex = 1;
            this.pictureBoxGeorge.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Факултетен номер";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Факултетен номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "1401682019";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "1401682003";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 377);
            this.Controls.Add(this.AuthorGeorge);
            this.Controls.Add(this.AuthorDimityr);
            this.Name = "AuthorForm";
            this.Text = "Автори";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            this.AuthorDimityr.ResumeLayout(false);
            this.AuthorDimityr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDimityr)).EndInit();
            this.AuthorGeorge.ResumeLayout(false);
            this.AuthorGeorge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeorge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AuthorDimityr;
        private System.Windows.Forms.PictureBox pictureBoxDimityr;
        private System.Windows.Forms.GroupBox AuthorGeorge;
        private System.Windows.Forms.PictureBox pictureBoxGeorge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


    }
}