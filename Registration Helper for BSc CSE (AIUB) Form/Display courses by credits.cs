using Registration_Helper_for_BSc_CSE_AIUB;
using System;
using System.Windows.Forms;

namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    public partial class Display_courses_by_credits : Form
    {
        private readonly CourseManager courseManager;

        public Display_courses_by_credits()
        {
            InitializeComponent();
            courseManager = new CourseManager();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int credits))
            {
                courseManager.DisplayCoursesByCredits(credits, dataGridViewForDisplaycoursesbycredits);
            }
            else
            {
                MessageBox.Show("Please enter a valid number for credits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Selection selection = new Selection();
            selection.Show();
            this.Hide();
        }
    }
}
