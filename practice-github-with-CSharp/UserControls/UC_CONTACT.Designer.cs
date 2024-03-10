namespace practice_github_with_CSharp.UserControls
{
    partial class UC_CONTACT
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbDes = new System.Windows.Forms.TextBox();
            this.tabHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTACT";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Google Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(129, 95);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(332, 36);
            this.txbName.TabIndex = 1;
            // 
            // txbDes
            // 
            this.txbDes.Font = new System.Drawing.Font("Google Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDes.Location = new System.Drawing.Point(129, 145);
            this.txbDes.Multiline = true;
            this.txbDes.Name = "txbDes";
            this.txbDes.Size = new System.Drawing.Size(826, 211);
            this.txbDes.TabIndex = 2;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabHome.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHome.Location = new System.Drawing.Point(413, 378);
            this.tabHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(205, 66);
            this.tabHome.TabIndex = 6;
            this.tabHome.Text = "SEND";
            this.tabHome.UseVisualStyleBackColor = false;
            this.tabHome.Click += new System.EventHandler(this.tabHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Detail:";
            // 
            // UC_CONTACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabHome);
            this.Controls.Add(this.txbDes);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_CONTACT";
            this.Size = new System.Drawing.Size(1031, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbDes;
        private System.Windows.Forms.Button tabHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
