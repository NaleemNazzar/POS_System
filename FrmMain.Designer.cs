namespace POS_System
{
    partial class FrmMain
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.BtnMax = new System.Windows.Forms.ToolStripButton();
            this.BtnMin = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClose,
            this.BtnMax,
            this.BtnMin});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(900, 33);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // BtnClose
            // 
            this.BtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnClose.Image = global::POS_System.Properties.Resources.close_64;
            this.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(34, 28);
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMax.Image = global::POS_System.Properties.Resources.maximize_64;
            this.BtnMax.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(34, 28);
            this.BtnMax.Text = "toolStripButton2";
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMin.Image = global::POS_System.Properties.Resources.minimize_64;
            this.BtnMin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(34, 28);
            this.BtnMin.Text = "toolStripButton3";
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.BtnUsers);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.LblUser);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 467);
            this.panel2.TabIndex = 2;
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnUsers.ForeColor = System.Drawing.Color.White;
            this.BtnUsers.Image = global::POS_System.Properties.Resources.Sales;
            this.BtnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsers.Location = new System.Drawing.Point(58, 402);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(110, 35);
            this.BtnUsers.TabIndex = 2;
            this.BtnUsers.Text = "   Users";
            this.BtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::POS_System.Properties.Resources.Sales;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(58, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 35);
            this.button6.TabIndex = 2;
            this.button6.Text = "   Sales";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::POS_System.Properties.Resources.Customers;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(58, 320);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 35);
            this.button5.TabIndex = 2;
            this.button5.Text = "   Customers";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::POS_System.Properties.Resources.Purchase;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(58, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 35);
            this.button4.TabIndex = 2;
            this.button4.Text = "   Purchase";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::POS_System.Properties.Resources.Product;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(58, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "   Product";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::POS_System.Properties.Resources.Categary;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(58, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "   Category";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::POS_System.Properties.Resources.home;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(58, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "   Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LblUser
            // 
            this.LblUser.BackColor = System.Drawing.Color.Transparent;
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(75, 115);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(99, 28);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "Username";
            this.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_System.Properties.Resources.icons8_person_48;
            this.pictureBox1.Location = new System.Drawing.Point(82, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterPanel.Location = new System.Drawing.Point(255, 38);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(641, 440);
            this.CenterPanel.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip);
            this.Name = "FrmMain";
            this.Text = "  FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.ToolStripButton BtnMax;
        private System.Windows.Forms.ToolStripButton BtnMin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BtnUsers;
    }
}