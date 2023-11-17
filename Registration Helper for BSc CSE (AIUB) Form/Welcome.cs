using System;
using System.Windows.Forms;

namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            Selection selaction = new Selection();
            selaction.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void developerInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeveloperInformation developerInformation = new DeveloperInformation();
            developerInformation.Show();
            this.Hide();
        }
    }
}
