namespace POS_System
{
    partial class FrmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 303);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS_System.Properties.Resources.icons8_person_48;
            this.pictureBox2.Location = new System.Drawing.Point(484, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome Back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserName";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(376, 221);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(278, 33);
            this.TxtUser.TabIndex = 0;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(376, 375);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(278, 42);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(376, 298);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(278, 33);
            this.TxtPass.TabIndex = 1;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 467);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPass;
    }
}