namespace practice_github_with_CSharp.UserControls
{
    partial class UC_ABOUT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabDP = new System.Windows.Forms.Button();
            this.tabCT = new System.Windows.Forms.Button();
            this.tabTD = new System.Windows.Forms.Button();
            this.tabVP = new System.Windows.Forms.Button();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.tabVP);
            this.panel1.Controls.Add(this.tabTD);
            this.panel1.Controls.Add(this.tabCT);
            this.panel1.Controls.Add(this.tabDP);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 480);
            this.panel1.TabIndex = 0;
            // 
            // tabDP
            // 
            this.tabDP.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDP.Location = new System.Drawing.Point(-1, -1);
            this.tabDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDP.Name = "tabDP";
            this.tabDP.Size = new System.Drawing.Size(205, 66);
            this.tabDP.TabIndex = 6;
            this.tabDP.Text = "Duy Phương";
            this.tabDP.UseVisualStyleBackColor = true;
            this.tabDP.Click += new System.EventHandler(this.tabDP_Click);
            // 
            // tabCT
            // 
            this.tabCT.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCT.Location = new System.Drawing.Point(-1, 209);
            this.tabCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCT.Name = "tabCT";
            this.tabCT.Size = new System.Drawing.Size(205, 66);
            this.tabCT.TabIndex = 7;
            this.tabCT.Text = "Chí Thanh";
            this.tabCT.UseVisualStyleBackColor = true;
            this.tabCT.Click += new System.EventHandler(this.tabCT_Click);
            // 
            // tabTD
            // 
            this.tabTD.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTD.Location = new System.Drawing.Point(-1, 139);
            this.tabTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTD.Name = "tabTD";
            this.tabTD.Size = new System.Drawing.Size(205, 66);
            this.tabTD.TabIndex = 8;
            this.tabTD.Text = "Thanh Duy";
            this.tabTD.UseVisualStyleBackColor = true;
            this.tabTD.Click += new System.EventHandler(this.tabTD_Click);
            // 
            // tabVP
            // 
            this.tabVP.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVP.Location = new System.Drawing.Point(-1, 69);
            this.tabVP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVP.Name = "tabVP";
            this.tabVP.Size = new System.Drawing.Size(205, 66);
            this.tabVP.TabIndex = 9;
            this.tabVP.Text = "Văn Phát";
            this.tabVP.UseVisualStyleBackColor = true;
            this.tabVP.Click += new System.EventHandler(this.tabVP_Click);
            // 
            // pnlAbout
            // 
            this.pnlAbout.Location = new System.Drawing.Point(209, 0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(819, 480);
            this.pnlAbout.TabIndex = 1;
            // 
            // UC_ABOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_ABOUT";
            this.Size = new System.Drawing.Size(1031, 480);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tabDP;
        private System.Windows.Forms.Button tabVP;
        private System.Windows.Forms.Button tabTD;
        private System.Windows.Forms.Button tabCT;
        private System.Windows.Forms.Panel pnlAbout;
    }
}
