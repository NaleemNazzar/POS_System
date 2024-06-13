using POS_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class FrmMain : Sample
    {
       static FrmMain _obj;
        public static FrmMain Instance
        {
            get { if (_obj == null) { _obj = new FrmMain(); } return _obj; }
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
            BtnMax.PerformClick();

            LblUser.Text = MainClass.USER;
            pictureBox1.Image = MainClass.IMG;
        }

        public void AddControls(Form F)
        {
            this.CenterPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            CenterPanel.Controls.Add(F);
            F.Show();
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            AddControls(new FrmUserView());
        }
    }
}
