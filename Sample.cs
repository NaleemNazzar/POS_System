using System;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void Sample_Load(object sender, EventArgs e)
        {
            // This method is executed when the form loads.
        }

        // Method to show the custom message box
        private void ShowCustomMessageBox()
        {
            // Simplify object initialization using an object initializer
            var msgBox = new CustomMessageBox("This is a custom message box", "Custom Title")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            var result = msgBox.ShowDialog(this); // 'this' refers to the current form (Sample)

            if (result == DialogResult.OK)
            {
                // OK button was clicked
                MessageBox.Show("OK button clicked.");
            }
            else if (result == DialogResult.Cancel)
            {
                // Cancel button was clicked
                MessageBox.Show("Cancel button clicked.");
            }
        }

        // Example event to trigger the custom message box
        private void ButtonShowMessageBox_Click(object sender, EventArgs e)
        {
            ShowCustomMessageBox();
        }
    }
}
