using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Registration_Helper_for_BSc_CSE_AIUB
{
    internal class CourseManager
    {
        private readonly BSc_in_CSE_Course_Data courseData;

        public CourseManager()
        {
            courseData = new BSc_in_CSE_Course_Data();
        }

        public List<BSc_in_CSE_Curriculum> GetAllCourses()
        {
            return courseData.Course; // Assuming courseData contains the list of courses
        }

        public List<BSc_in_CSE_Curriculum> GetAvailableCourses(string[] completedCourseCodes)
        {
            // Inside the GetAvailableCourses method
            List<BSc_in_CSE_Curriculum> availableCourses = new List<BSc_in_CSE_Curriculum>();

            foreach (string completedCourseCode in completedCourseCodes)
            {
                availableCourses.AddRange(courseData.Course
                    .Where(course => ArePrerequisitesMet(course, completedCourseCode) && !availableCourses.Contains(course))
                    .ToList());
            }

            return availableCourses;

        }

        public bool ArePrerequisitesMet(BSc_in_CSE_Curriculum course, string completedCourseCode)
        {
            if (string.IsNullOrEmpty(course.PreRequisite) || course.PreRequisite.Equals(BSc_in_CSE_Curriculum.Nil))
            {
                return false;
            }

            string[] prerequisites = course.PreRequisite.Split('&');

            return prerequisites.Any(prerequisite => prerequisite.Trim() == completedCourseCode);
        }
   
        public List<BSc_in_CSE_Curriculum> GetCoursesWithNoPrerequisites()
        {
            return courseData.Course.Where(c => string.IsNullOrEmpty(c.PreRequisite) || c.PreRequisite.Equals(BSc_in_CSE_Curriculum.Nil)).ToList();
        }

        public void DisplayCoursesByCredits(int credits, DataGridView dataGridView)
        {
            var coursesWithSpecificCredits = courseData.Course.Where(c => c.Credit == credits).ToList();

            // Clear existing rows in the DataGridView
            dataGridView.Rows.Clear();

            if (coursesWithSpecificCredits.Any())
            {
                foreach (var course in coursesWithSpecificCredits)
                {
                    dataGridView.Rows.Add(course.Code, course.CourseDescription, course.PreRequisite, course.Credit);
                }
            }
            else
            {
                MessageBox.Show($"No courses found with {credits} credits.", "No Courses Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
