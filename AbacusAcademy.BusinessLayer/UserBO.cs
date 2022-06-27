using AbacusAcademy.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbacusAcademy.Entities;

namespace AbacusAcademy.BusinessLayer
{
    public class UserBO
    {
        public UserDAO userDAO;
        public UserBO()
        {
            userDAO = new UserDAO();
        }
        public void AddUser(Users user)
        {
            userDAO.AddUser(user);
        }
        public void EditUser(Users user)
        {
            userDAO.EditUser(user);
        }
        public void DeleteUserById(int userId)
        {
            userDAO.DeleteUserById(userId);
        }
        public Users GetUserById(int userId)
        {
            return userDAO.GetUserById(userId);
        }
        public List<Users> GetUsers()
        {
            return userDAO.GetUsers();
        }
    }
}
