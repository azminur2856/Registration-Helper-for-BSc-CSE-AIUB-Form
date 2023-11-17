using Registration_Helper_for_BSc_CSE_AIUB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    public partial class Check_available_courses_based_on_completed_courses : Form
    {
        private readonly CourseManager courseManager;
        public Check_available_courses_based_on_completed_courses()
        {
            InitializeComponent();
            courseManager = new CourseManager();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Selection selection = new Selection();
            selection.Show();
            this.Hide();
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            string input = textBox.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("No completed courses entered. Exiting...", "No Courses Entered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] completedCourseCodes = input.Split(',');

            List<BSc_in_CSE_Curriculum> availableCourses = courseManager.GetAvailableCourses(completedCourseCodes);

            DisplayAvailableCoursesInGrid(availableCourses);
        }

        private void DisplayAvailableCoursesInGrid(List<BSc_in_CSE_Curriculum> courses)
        {
            dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.Rows.Clear();

            if (courses.Count > 0)
            {
                foreach (var course in courses)
                {
                    dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.Rows.Add(course.Code, course.CourseDescription, course.PreRequisite, course.Credit);
                }
            }
            else
            {
                MessageBox.Show("No available courses based on the completed course(s).", "No Available Courses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}