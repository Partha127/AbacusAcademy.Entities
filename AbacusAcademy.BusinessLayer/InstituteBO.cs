using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbacusAcademy.DataLayer;
using AbacusAcademy.Entities;

namespace AbacusAcademy.BusinessLayer
{
    public class InstituteBO
    {
        public InstituteDAO instituteDAO;
        public InstituteBO()
        {
            instituteDAO = new InstituteDAO();
        }
        public void AddInstitue(Institute institute)
        {
            instituteDAO.AddInstitute(institute);
        }
        public void EditInstitute(Institute institute)
        {
            instituteDAO.EditInstitute(institute);
        }
        public void DeleteInstituteById(int instituteId)
        {
            instituteDAO.DeleteInstituteById(instituteId);
        }
        public Institute GetInstituteById(int instituteId)
        {
            return instituteDAO.GetInstituteById(instituteId);
        }
        public List<Institute> GetInstitutes()
        {
            return instituteDAO.GetInstitutes();
        }
    }
    
}
