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
    public partial class UserCURD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            UserBO userBO = new UserBO();
            List<Users> user = userBO.GetUsers();
            GridView1.DataSource = user;
            GridView1.DataBind();
        }

        protected void AddUser(Object sender,EventArgs e)
        {
            try
            {
                UserBO userBO = new UserBO();
                AbacusAcademy.Entities.Users user = new Users()
                {
                    UserId = Int32.Parse(UserId.Text),
                    UserName = txtUserName.Text,
                    EmailId = txtEmailId.Text,
                    Password = txtPassword.Text,
                    Mobile = txtMobile.Text,
                    UserRole = ddlRole.Text
                };
                userBO.AddUser(user);
                LoadUsers();
            }
            catch (Exception ex)
            {

                LblErrMsg.Text = ex.Message;
            }
        }
        protected void SearchUser(Object sender, EventArgs e)
        {
            int userId = Int32.Parse(UserId.Text);
            UserBO userBO =new UserBO();
            Users users = userBO.GetUserById(userId);
            if(users != null)
            {
                txtEmailId.Text = users.EmailId;
                txtMobile.Text = users.Mobile;
                txtUserName.Text = users.UserName;
                ddlRole.Text = users.UserRole;
            }
            else
            {
                LblErrMsg.Text = "Invalid Id";
            }
            LoadUsers();

        }
        protected void EditUser(Object sender, EventArgs e)
        {
            try
            {
                UserBO userBO = new UserBO();
                AbacusAcademy.Entities.Users user = new Users()
                {
                    UserId = Int32.Parse(UserId.Text),
                    UserName = txtUserName.Text,
                    EmailId = txtEmailId.Text,
                    Password = txtPassword.Text,
                    Mobile = txtMobile.Text,
                    UserRole = ddlRole.Text
                };
                userBO.EditUser(user);
                LoadUsers();
            }
            catch (Exception ex)
            {

                LblErrMsg.Text = ex.Message;
            }
        }
        protected void DeleteUser(Object sender, EventArgs e)
        {
            int userId = Int32.Parse(UserId.Text);
            UserBO userBO = new UserBO();   
            userBO.DeleteUserById(userId);
            LoadUsers();
        }
    }
}