using System;
using System.Windows.Forms;

namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();
        }

        private void clickbutton1_Click(object sender, EventArgs e)
        {
            Display_all_courses_for_BSc_CSE display = new Display_all_courses_for_BSc_CSE();
            display.Show();
            this.Hide();
        }

        private void clickbutton2_Click(object sender, EventArgs e)
        {
            Check_available_courses_based_on_completed_courses display = new Check_available_courses_based_on_completed_courses();
            display.Show();
            this.Hide();
        }

        private void clickbutton3_Click(object sender, EventArgs e)
        {
            Display_courses_with_no_prerequisites display = new Display_courses_with_no_prerequisites();
            display.Show();
            this.Hide();
        }

        private void clickbutton4_Click(object sender, EventArgs e)
        {
            Display_courses_by_credits display = new Display_courses_by_credits();
            display.Show();
            this.Hide();
        }
    }
}
