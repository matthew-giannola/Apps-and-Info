using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalprog
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        string userType;

        protected void Page_Load(object sender, EventArgs e)
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();

            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();
            if (eo.role == "Admin")
            {
                btnAdmins.Visible = true;
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                search();
            }
            catch { }
        }


        protected void ButtonNav_Click(object sender, EventArgs e)
        {
            Response.Redirect("CoursePage.aspx");
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            //gridviewCourses.Visible = true;
        }

        protected void btnAdmins_Click(object sender, EventArgs e)
        {
            setUser("Admin");
        }


        private void search()
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();

            string searchText = txtSearch.Text;

            var search = (from c in us.Classes
                          where (c.Id.ToString().StartsWith(searchText) || c.professorName.ToString().StartsWith(searchText) || c.description.ToString().StartsWith(searchText))
                          select c).FirstOrDefault();

            if (search != null && !String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var result = search.Id + " " + search.description;
                btnNav.Visible = true;
                CoursePage.course = search.Id;
                lblResults.Text = result;
                lblSearch.Visible = false;
            }
            else
            {
                lblSearch.Visible = true;
                lblSearch.Text = "Value not Found";
            }
        }



        public void setUser(string usertype)
        {
            userType = usertype;
            if (userType == "Admin")
            {
                btnAdmin.Visible = true;
            }
        }
    }
}