using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AbacusAcademy.Entities;
using System.Data;

namespace AbacusAcademy.DataLayer
{
    public class UserDAO
    {
        SqlConnection con = new SqlConnection(@"Data Source=PARTHA-PC\SQLEXPRESS;Initial Catalog=SampleDb;Integrated Security=true");
        public void AddUser(Users user)
        {
            try
            {
                string cs = "INSERT INTO USERS VALUES(@EmailId,@Password,@UserName,@Mobile,@UserRole,@UserId)";
                SqlCommand command = new SqlCommand(cs,con);
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@EmailId", user.EmailId);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@UserRole", user.UserRole);
                command.Parameters.AddWithValue("@Mobile", user.Mobile);
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
                //connection close
                con.Close();
            }
        }
        public void EditUser(Users user)
        {
            try
            {
                string cs = "UPDATE USERS SET UserName=@UserName,EmailId=@EmailId,Password=@Password,Mobile=@Mobile where UserId=@UserId";
                SqlCommand command = new SqlCommand(cs, con);
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@EmailId", user.EmailId);
                command.Parameters.AddWithValue("@Mobile", user.Mobile);
                command.Parameters.AddWithValue("@Password", user.Password);
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
        public void DeleteUserById(int userId)
        {
            try
            {
                string cs = "DELETE FROM USERS where UserId=@UserId";
                SqlCommand command = new SqlCommand(cs,con);
                command.Parameters.AddWithValue("@UserId", userId);
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
        public Users GetUserById(int userId)
        {
            try
            {
                string cs = "Select * from Users where UserId= " + userId;
                SqlDataAdapter adapter = new SqlDataAdapter(cs, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataRow row = ds.Tables[0].Rows[0];
                Users user = new Users()
                {
                   UserId= (int)row["UserId"],
                   UserName=row["UserName"].ToString(),
                   EmailId=row["EmailId"].ToString(),
                   Mobile=row["Mobile"].ToString(),
                };
                return user;
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
        public List<Users> GetUsers()
        {
            try
            {
                string cs = "Select * from Users";
                SqlDataAdapter adapter = new SqlDataAdapter(cs, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                List<Users> users = new List<Users>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Users user = new Users()
                    {
                        UserId = (int)row["UserId"],
                        UserName = row["UserName"].ToString(),
                        EmailId = row["EmailId"].ToString(),
                        Mobile = row["Mobile"].ToString(),
                    };
                    users.Add(user); // add user detail to list
                }
                return users;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close ();
            }
        }
    }
}
