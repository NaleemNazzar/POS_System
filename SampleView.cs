using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_System
{
    public partial class SampleView : Sample
    {
        // Declare the isCleared variable as a member of the Form1 class
        private bool isCleared = false;



        public SampleView()
        {
            InitializeComponent();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Enter(object sender, EventArgs e)
        {

        }

        private void Search_Leave(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public virtual void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            if (!isCleared)
            {
                TxtSearch.Clear();
                PictureBox1.Hide();
                isCleared = true;
            }
        }

        public virtual void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
