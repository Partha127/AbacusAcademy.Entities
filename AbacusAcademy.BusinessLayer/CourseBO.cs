using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbacusAcademy.DataLayer;
using AbacusAcademy.Entities;

namespace AbacusAcademy.BusinessLayer
{
    public class CourseBO
    {
        public CourseDAO courseDAO;
        public CourseBO()
        {
            courseDAO = new CourseDAO();
        }
        public void AddCourse(Course course)
        {
            courseDAO.AddCourse(course);
        }
        public void EditCourse(Course course) 
        { 
            courseDAO.EditCourse(course);
        }
        public void DeleteCourseById(int courseId)
        {
            courseDAO.DeleteCourseById(courseId);
        }
        public Course GetCourseById(int courseId)
        {
            return courseDAO.GetCourseById(courseId);
        }
        public List<Course> GetCourses()
        {
            return courseDAO.GetCourses();
        }
    }
}
