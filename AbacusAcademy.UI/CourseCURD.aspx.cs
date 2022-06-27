using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AbacusAcademy.Entities;
using AbacusAcademy.BusinessLayer;

namespace AbacusAcademy.UI
{
    public partial class CourseCURD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCourse();
        }

        private void LoadCourse()
        {
            CourseBO courseBO = new CourseBO();
            List<Course> courses = courseBO.GetCourses();
            GridView1.DataSource = courses;
            GridView1.DataBind();
        }

        protected void AddCourse(object sender, EventArgs e)
        {
            try
            {
                CourseBO courseBO = new CourseBO();
                AbacusAcademy.Entities.Course course = new Course()
                {
                    CourseId = Int32.Parse(CourseId.Text),
                    CourseName = txtCourseName.Text,
                    CourseDescription = txtCourseDescription.Text,
                    CourseDuration = txtCourseDuration.Text,
                    InstituteId=Int32.Parse(InstituteId.Text),

                };
                courseBO.AddCourse(course);
                LoadCourse();
            }
            catch (Exception ex)
            {

                LblErrMsg.Text = ex.Message;
            }
            
        }

        protected void SearchCourse(object sender, EventArgs e)
        {

        }

        protected void EditCourse(object sender, EventArgs e)
        {

        }

        protected void DeleteCourse(object sender, EventArgs e)
        {

        }

        
    }
}