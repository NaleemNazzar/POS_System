using POS_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.View
{
    public partial class FrmUserView : SampleView
    {
        public FrmUserView()
        {
            InitializeComponent();
        }

        private void FrmUserView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FrmUserAdd());
            LoadData(); // Refresh data after adding a new user
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid);
            lb.Items.Add(Dgvname);
            lb.Items.Add(DgvuserName);
            lb.Items.Add(Dgvpass);
            lb.Items.Add(Dgvphone);

            try
            {
                string qry = @"SELECT userID, uName, uUsername, uPass, uPhone FROM users
                               WHERE uName LIKE '%" + TxtSearch.Text + "%' ORDER BY userID DESC";
                MainClass.LoadData(qry, dataGridView1, lb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Update
            if (dataGridView1.CurrentCell.OwningColumn.Name == "DgvEdit")
            {
                FrmUserAdd frm = new FrmUserAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Dgvid"].Value);
                frm.TxtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Dgvname"].Value);
                frm.TxtUser.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["DgvuserName"].Value);
                frm.TxtPass.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Dgvpass"].Value);
                frm.TxtPhone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Dgvphone"].Value);

                MainClass.BlurBackground(frm);
                LoadData();
            }

            // Delete
            if (dataGridView1.CurrentCell.OwningColumn.Name == "Dgvdel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Dgvid"].Value);
                string qry = "DELETE FROM users WHERE userID = " + id;
                Hashtable ht = new Hashtable();
                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }
    }
}
