using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;


namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    public partial class DeveloperInformation : Form
    {
        private Dictionary<string, string> socialIcons = new Dictionary<string, string>();

        public DeveloperInformation()
        {
            InitializeComponent();
            DisplayDeveloperInformation();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
        private void DisplayDeveloperInformation()
        {
            string developerName = "AZMINUR RAHMAN";
            string developerRole = "Student BSc CSE (AIUB)";
            string developerStudentId = "22-46588-1";
            string developerEmail = "22-46588-1@student.aiub.edu";
            string developerLocation = "Dhaka, Bangladesh";

            nameLabel.Text = "Name: " + developerName;
            roleLabel.Text = "Role: " + developerRole;
            idTextBox.Text = "ID: " + developerStudentId;
            emailLabel.Text = developerEmail;
            locationLabel.Text = "Location: " + developerLocation;

            // Map resource names to their associated URLs
            socialIcons.Add("github_icon", "https://github.com/azminur2856");
            socialIcons.Add("linkedin_icon", "https://www.linkedin.com/in/azminur2856/");
            socialIcons.Add("facebook_icon", "https://www.facebook.com/azminur.rahman.96/");
            socialIcons.Add("twitter_icon", "https://twitter.com/azminur2856");

            // Attach click events to PictureBox controls
            pictureBoxGitHub.Click += (sender, e) => OpenLink("github_icon");
            pictureBoxLinkedIn.Click += (sender, e) => OpenLink("linkedin_icon");
            pictureBoxFacebook.Click += (sender, e) => OpenLink("facebook_icon");
            pictureBoxTwitter.Click += (sender, e) => OpenLink("twitter_icon");
        }

        private void OpenLink(string resourceName)
        {
            if (socialIcons.ContainsKey(resourceName))
            {
                string url = socialIcons[resourceName];
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open link: " + ex.Message);
                }
            }
        }

        private void emailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string emailAddress = "22-46588-1@student.aiub.edu";
            try
            {
                Process.Start("mailto:" + emailAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open email client: " + ex.Message);
            }
        }
    }
}
