﻿using System;
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
    public partial class CustomMessageBox : Sample
    {
        public CustomMessageBox(string message, string title)
        {
            InitializeComponent();
            labelMessage.Text = message;
            this.Text = title;
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }
         
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
