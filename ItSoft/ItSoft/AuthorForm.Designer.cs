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
            this.AuthorGeorge = new System.Windows.Forms.GroupBox();
            this.pictureBoxDimityr = new System.Windows.Forms.PictureBox();
            this.pictureBoxGeorge = new System.Windows.Forms.PictureBox();
            this.AuthorDimityr.SuspendLayout();
            this.AuthorGeorge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDimityr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeorge)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorDimityr
            // 
            this.AuthorDimityr.Controls.Add(this.pictureBoxDimityr);
            this.AuthorDimityr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorDimityr.Location = new System.Drawing.Point(23, 14);
            this.AuthorDimityr.Name = "AuthorDimityr";
            this.AuthorDimityr.Size = new System.Drawing.Size(392, 160);
            this.AuthorDimityr.TabIndex = 0;
            this.AuthorDimityr.TabStop = false;
            this.AuthorDimityr.Text = "Димитър Русков";
            // 
            // AuthorGeorge
            // 
            this.AuthorGeorge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AuthorGeorge.Controls.Add(this.pictureBoxGeorge);
            this.AuthorGeorge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorGeorge.Location = new System.Drawing.Point(23, 192);
            this.AuthorGeorge.Name = "AuthorGeorge";
            this.AuthorGeorge.Size = new System.Drawing.Size(392, 161);
            this.AuthorGeorge.TabIndex = 1;
            this.AuthorGeorge.TabStop = false;
            this.AuthorGeorge.Text = "Георги Марушков";
            // 
            // pictureBoxDimityr
            // 
            this.pictureBoxDimityr.Location = new System.Drawing.Point(17, 41);
            this.pictureBoxDimityr.Name = "pictureBoxDimityr";
            this.pictureBoxDimityr.Size = new System.Drawing.Size(83, 88);
            this.pictureBoxDimityr.TabIndex = 0;
            this.pictureBoxDimityr.TabStop = false;
            // 
            // pictureBoxGeorge
            // 
            this.pictureBoxGeorge.Location = new System.Drawing.Point(17, 40);
            this.pictureBoxGeorge.Name = "pictureBoxGeorge";
            this.pictureBoxGeorge.Size = new System.Drawing.Size(83, 88);
            this.pictureBoxGeorge.TabIndex = 1;
            this.pictureBoxGeorge.TabStop = false;
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
            this.AuthorGeorge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDimityr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeorge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AuthorDimityr;
        private System.Windows.Forms.PictureBox pictureBoxDimityr;
        private System.Windows.Forms.GroupBox AuthorGeorge;
        private System.Windows.Forms.PictureBox pictureBoxGeorge;


    }
}