using Registration_Helper_for_BSc_CSE_AIUB;
using System;
using System.Windows.Forms;

namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    public partial class Display_courses_with_no_prerequisites : Form
    {
        private readonly CourseManager courseManager;
        public Display_courses_with_no_prerequisites()
        {
            InitializeComponent();
            courseManager = new CourseManager();
            DisplayCoursesWithNoPrerequisitesInDataGridView();
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            Selection selaction = new Selection();
            selaction.Show();
            this.Hide();
        }
        private void DisplayCoursesWithNoPrerequisitesInDataGridView()
        {
            var coursesWithNoPrerequisites = courseManager.GetCoursesWithNoPrerequisites();

            if (coursesWithNoPrerequisites != null && coursesWithNoPrerequisites.Count > 0)
            {
                foreach (var course in coursesWithNoPrerequisites)
                {
                    dataGridViewForNoPrerequisites.Rows.Add(course.Code, course.CourseDescription, course.PreRequisite, course.Credit);
                }
            }
        }
    }
}
