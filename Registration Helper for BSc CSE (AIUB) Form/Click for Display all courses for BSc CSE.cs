using Registration_Helper_for_BSc_CSE_AIUB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    public partial class Display_all_courses_for_BSc_CSE : Form
    {
        private readonly CourseManager courseManager;
        public Display_all_courses_for_BSc_CSE()
        {
            InitializeComponent();
            courseManager = new CourseManager();
            DisplayAllCoursesInDataGridView();
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            Selection selaction = new Selection();
            selaction.Show();
            this.Hide();
        }
        private void DisplayAllCoursesInDataGridView()
        {
            List<BSc_in_CSE_Curriculum> allCourses = courseManager.GetAllCourses();
            if (allCourses != null && allCourses.Count > 0)
            {
                foreach (var course in allCourses)
                {
                    dataGridViewForNoPrerequisites.Rows.Add(course.Code, course.CourseDescription, course.PreRequisite, course.Credit);
                }
            }
        }
    }
}
