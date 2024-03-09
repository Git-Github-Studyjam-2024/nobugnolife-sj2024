namespace practice_github_with_CSharp.UserControls
{
    partial class UC_ABOUT_TD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nameTD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.facebook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::practice_github_with_CSharp.Properties.Resources.Duy_About1;
            this.pictureBox3.Location = new System.Drawing.Point(433, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(335, 299);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // nameTD
            // 
            this.nameTD.AutoSize = true;
            this.nameTD.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTD.Location = new System.Drawing.Point(121, 86);
            this.nameTD.Name = "nameTD";
            this.nameTD.Size = new System.Drawing.Size(269, 39);
            this.nameTD.TabIndex = 9;
            this.nameTD.Text = "Huỳnh Thanh Duy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sophomore";
            // 
            // facebook
            // 
            this.facebook.AutoSize = true;
            this.facebook.BackColor = System.Drawing.SystemColors.Control;
            this.facebook.Font = new System.Drawing.Font("Google Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebook.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.facebook.Location = new System.Drawing.Point(268, 189);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(122, 30);
            this.facebook.TabIndex = 11;
            this.facebook.Text = "Facebook";
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "I love Java ❤️";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "I\'ve been inspired by Mr. Dao 💕💕💕";
            // 
            // UC_ABOUT_TD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTD);
            this.Controls.Add(this.pictureBox3);
            this.Name = "UC_ABOUT_TD";
            this.Size = new System.Drawing.Size(819, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label nameTD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label facebook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
