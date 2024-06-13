namespace POS_System.View
{
    partial class FrmUserView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DgvSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvuserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Size = new System.Drawing.Size(940, 133);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 9);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(88, 57);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(507, 45);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(512, 76);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(65)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvSr,
            this.Dgvid,
            this.Dgvname,
            this.DgvuserName,
            this.Dgvpass,
            this.Dgvphone,
            this.DgvEdit,
            this.DgvDel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(51, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 259);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // DgvSr
            // 
            this.DgvSr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvSr.FillWeight = 70F;
            this.DgvSr.HeaderText = "Sr #";
            this.DgvSr.MinimumWidth = 70;
            this.DgvSr.Name = "DgvSr";
            this.DgvSr.ReadOnly = true;
            this.DgvSr.Width = 70;
            // 
            // Dgvid
            // 
            this.Dgvid.HeaderText = "id";
            this.Dgvid.MinimumWidth = 8;
            this.Dgvid.Name = "Dgvid";
            this.Dgvid.ReadOnly = true;
            this.Dgvid.Visible = false;
            // 
            // Dgvname
            // 
            this.Dgvname.HeaderText = "Name";
            this.Dgvname.MinimumWidth = 8;
            this.Dgvname.Name = "Dgvname";
            this.Dgvname.ReadOnly = true;
            // 
            // DgvuserName
            // 
            this.DgvuserName.HeaderText = "Username";
            this.DgvuserName.MinimumWidth = 8;
            this.DgvuserName.Name = "DgvuserName";
            this.DgvuserName.ReadOnly = true;
            // 
            // Dgvpass
            // 
            this.Dgvpass.HeaderText = "Pass";
            this.Dgvpass.MinimumWidth = 8;
            this.Dgvpass.Name = "Dgvpass";
            this.Dgvpass.ReadOnly = true;
            // 
            // Dgvphone
            // 
            this.Dgvphone.HeaderText = "Phone";
            this.Dgvphone.MinimumWidth = 8;
            this.Dgvphone.Name = "Dgvphone";
            this.Dgvphone.ReadOnly = true;
            // 
            // DgvEdit
            // 
            this.DgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvEdit.FillWeight = 50F;
            this.DgvEdit.HeaderText = "";
            this.DgvEdit.Image = global::POS_System.Properties.Resources.add2;
            this.DgvEdit.MinimumWidth = 50;
            this.DgvEdit.Name = "DgvEdit";
            this.DgvEdit.ReadOnly = true;
            this.DgvEdit.Width = 50;
            // 
            // DgvDel
            // 
            this.DgvDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvDel.FillWeight = 50F;
            this.DgvDel.HeaderText = "";
            this.DgvDel.Image = global::POS_System.Properties.Resources.Delete;
            this.DgvDel.MinimumWidth = 50;
            this.DgvDel.Name = "DgvDel";
            this.DgvDel.ReadOnly = true;
            this.DgvDel.Width = 50;
            // 
            // FrmUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmUserView";
            this.Text = "FrmUserView";
            this.Load += new System.EventHandler(this.FrmUserView_Load);
            this.Controls.SetChildIndex(this.Panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvuserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvpass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvphone;
        private System.Windows.Forms.DataGridViewImageColumn DgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn DgvDel;
    }
}