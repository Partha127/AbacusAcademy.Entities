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
    public class InstituteDAO
    {
        SqlConnection con = new SqlConnection(@"Data Source=PARTHA-PC\SQLEXPRESS;Initial Catalog=SampleDb;Integrated Security=true");

        public void AddInstitute(Institute institute)
        {
            try
            {
                string cs = "INSERT INTO INSTITUTE VALUES (@InstituteId,@EmailId,@InstituteName,@InstituteDescription,@Address,@Mobile)";
                SqlCommand command = new SqlCommand(cs, con);
                command.Parameters.AddWithValue("@InstituteId", institute.InstituteId);
                command.Parameters.AddWithValue("@EmailId", institute.EmailId);
                command.Parameters.AddWithValue("@InstituteName", institute.InstituteName);
                command.Parameters.AddWithValue("@InstituteDescription", institute.InstituteDescription);
                command.Parameters.AddWithValue("@Address", institute.Address);
                command.Parameters.AddWithValue("@Mobile", institute.Mobile);

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
        public void EditInstitute(Institute institute)
        {
            try
            {
                string cs = "UPDATE INSTITUTE SET EmailId=@EmailId,InstituteName=@InstituteName,Address=@Address,Mobile=@Mobile where InstituteId=@InstituteId";
                SqlCommand command = new SqlCommand(cs, con);
                command.Parameters.AddWithValue("@InstituteId", institute.InstituteId);
                command.Parameters.AddWithValue("@EmailId", institute.EmailId);
                command.Parameters.AddWithValue("@InstituteName", institute.InstituteName);
                command.Parameters.AddWithValue("@Address", institute.Address);
                command.Parameters.AddWithValue("@Mobile", institute.Mobile);

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
        public void DeleteInstituteById(int instituteId)
        {
            try
            {
                string cs = "DELETE FROM INSTITUTE where InstituteId=@InstituteId";
                SqlCommand command = new SqlCommand(cs, con);
                command.Parameters.AddWithValue("@InstituteId", instituteId);
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
        public Institute GetInstituteById(int instituteId)
        {
            try
            {
                string cs = "Select * from Institute where Institute = " + instituteId;
                SqlDataAdapter adapter = new SqlDataAdapter(cs, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataRow row = ds.Tables[0].Rows[0];
                Institute institute = new Institute()
                {
                    InstituteId = (int)row["InstituteId"],
                    EmailId = row["EmailId"].ToString(),
                    InstituteName= row["InstituteName"].ToString(),
                    InstituteDescription = row["InstituteDescription"].ToString(),
                    Address = row["Address"].ToString(),
                    
                };
                return institute;
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
        public List<Institute> GetInstitutes()
        {
            try
            {
                string cs = "Select * from Institute";
                SqlDataAdapter adapter = new SqlDataAdapter(cs, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                List<Institute> institutes = new List<Institute>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Institute institute = new Institute()
                    {
                        InstituteId = (int)row["InstituteId"],
                        EmailId = row["EmailId"].ToString(),
                        InstituteName = row["InstituteName"].ToString(),
                        InstituteDescription = row["InstituteDescription"].ToString(),
                        Address = row["Address"].ToString(),
                    };
                    institutes.Add(institute);
                }
                return institutes;
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
