namespace POS_System.Model
{
    partial class FrmUserAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtPic = new System.Windows.Forms.PictureBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(818, 100);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Size = new System.Drawing.Size(818, 100);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(165, 38);
            this.label1.Text = "User Details";
            // 
            // BtnClose
            // 
            this.BtnClose.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.TxtName.Location = new System.Drawing.Point(31, 169);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(250, 33);
            this.TxtName.TabIndex = 0;
            this.TxtName.Tag = "v";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(311, 169);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(250, 33);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.Tag = "v";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(31, 259);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(250, 33);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.Tag = "v";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(311, 259);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(250, 33);
            this.TxtPhone.TabIndex = 3;
            // 
            // TxtPic
            // 
            this.TxtPic.Image = global::POS_System.Properties.Resources.icons8_person_48;
            this.TxtPic.Location = new System.Drawing.Point(624, 134);
            this.TxtPic.Name = "TxtPic";
            this.TxtPic.Size = new System.Drawing.Size(130, 122);
            this.TxtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TxtPic.TabIndex = 4;
            this.TxtPic.TabStop = false;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.BtnBrowse.ForeColor = System.Drawing.Color.White;
            this.BtnBrowse.Location = new System.Drawing.Point(624, 271);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(130, 43);
            this.BtnBrowse.TabIndex = 4;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // FrmUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 503);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.TxtPic);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Name = "FrmUserAdd";
            this.Text = "FrmUserAdd";
            this.Load += new System.EventHandler(this.FrmUserAdd_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtPass, 0);
            this.Controls.SetChildIndex(this.TxtUser, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TxtPhone, 0);
            this.Controls.SetChildIndex(this.TxtPic, 0);
            this.Controls.SetChildIndex(this.BtnBrowse, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtUser;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtPass;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.PictureBox TxtPic;
        private System.Windows.Forms.Button BtnBrowse;
    }
}