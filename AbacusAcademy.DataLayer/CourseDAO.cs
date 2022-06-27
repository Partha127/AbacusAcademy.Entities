using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbacusAcademy.Entities;
using System.Data;
using System.Data.SqlClient;

namespace AbacusAcademy.DataLayer
{
    public class CourseDAO
    {
        SqlConnection con = new SqlConnection(@"Data Source=PARTHA-PC\SQLEXPRESS;Initial Catalog=SampleDb;Integrated Security=true");
        public void AddCourse(Course course)
        {
            try
            {
                string cs = "INSERT INTO COURSE VALUES (@CourseId,@CourseName,@CourseDescription,@CourseDuration,@InstituteId)";
                SqlCommand command = new SqlCommand(cs, con);
                command.Parameters.AddWithValue("@CourseId", course.CourseId);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);
                command.Parameters.AddWithValue("@CourseDescription", course.CourseDescription);
                command.Parameters.AddWithValue("@CourseDuration", course.CourseDuration);
                command.Parameters.AddWithValue("@InstituteId", course.InstituteId);

                con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void EditCourse(Course course)
        {
            try
            {
                string cs = "UPDATE COURSE SET CourseName=@CourseName,CourseDescription=@CourseDescription,CourseDuration=@CourseDuration where CourseId=@CourseId";
                SqlCommand command = new SqlCommand(cs, con);
                command.Parameters.AddWithValue("@CourseId", course.CourseId);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);
                command.Parameters.AddWithValue("@CourseDescription", course.CourseDescription);
                command.Parameters.AddWithValue("@CourseDuration", course.CourseDuration);

                con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void DeleteCourseById(int courseId)
        {
            try
            {
                string cs = "DELETE FROM COURSE where CourseId=@CourseId";
                SqlCommand command = new SqlCommand(cs, con);
                command.Parameters.AddWithValue("@CourseId", courseId);
                //connection open
                con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public Course GetCourseById(int courseId)
        {
            try
            {
                string cs = "Select * from Course = " + courseId;
                SqlDataAdapter adapter = new SqlDataAdapter(cs, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataRow row = ds.Tables[0].Rows[0];
                Course course = new Course()
                {
                    CourseId = (int)row["CourseId"],
                    CourseName = row["CourseName"].ToString(),
                    CourseDescription = row["CourseDescription"].ToString(),
                    CourseDuration = row["CourseDuration"].ToString(),
                };
                return course;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Course> GetCourses()
        {
            try
            {
                string cs = "Select * from Course";
                SqlDataAdapter adapter = new SqlDataAdapter(cs, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                List<Course> courses = new List<Course>();
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    Course course = new Course()
                    {
                        CourseId = (int)row["CourseId"],
                        CourseName = row["CourseName"].ToString(),
                        CourseDescription = row["CourseDescription"].ToString(),
                        CourseDuration = row["CourseDuration"].ToString(),
                    };
                    courses.Add(course);
                }
                return courses;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
