using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AbacusAcademy.BusinessLayer;
using AbacusAcademy.Entities;

namespace AbacusAcademy.UI
{
    public partial class InstituteCURD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadInstitutes();
        }

        private void LoadInstitutes()
        {
            InstituteBO instituteBO = new InstituteBO();
            List<Institute> institutes = instituteBO.GetInstitutes();
            GridView1.DataSource = institutes;
            GridView1.DataBind();
        }

        protected void AddInstitute(object sender, EventArgs e)
        {
            try
            {
                InstituteBO instituteBO = new InstituteBO();
                AbacusAcademy.Entities.Institute institute = new Institute()
                {
                    InstituteId = Int32.Parse(InstituteId.Text),
                    EmailId = txtEmailId.Text,
                    InstituteName = txtInstituteName.Text,
                    InstituteDescription = txtInstituteDescription.Text,
                    Address = txtAddress.Text,
                    Mobile = txtMobile.Text,

                };
                instituteBO.AddInstitue(institute);
                LoadInstitutes();
            }
            catch (Exception ex)
            {

                LblErrMsg.Text = ex.Message;
            }
        }

        protected void SearchInstitute(object sender, EventArgs e)
        {
            int instituteId = Int32.Parse(InstituteId.Text);
            InstituteBO instituteBO =new InstituteBO();
            Institute institute = instituteBO.GetInstituteById(instituteId);
            if (institute != null)
            {

            }
        }

        protected void EditInstitute(object sender, EventArgs e)
        {

        }

        protected void DeleteInstitute(object sender, EventArgs e)
        {

        }
    }
}