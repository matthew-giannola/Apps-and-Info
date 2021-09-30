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
                btnAdmin.Visible = true;
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

            var searchVariable = searchColumnType(drpSearchType.SelectedValue);

            if (searchVariable == 1)
            {
                var search = (from c in us.Classes
                              where (c.Id.ToString().StartsWith(searchText))
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
            else if (searchVariable == 2)
            {
                var search = (from c in us.Classes
                              where (c.description.Contains(searchText))
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
            else if (searchVariable == 3) 
            {
                var search = (from c in us.Classes
                              where (c.professorName.Contains(searchText))
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
            else if (searchVariable == 0)
            {
                lblSearch.Text = "Please select a search parameter";
                lblSearch.Visible = true;
            }

        }

        /// Function to turn the search type to a numero 
        /// 
        /// outputs 0 for course ID 1 for Course name and 3 for Professor name (ARGO)
        private int searchColumnType(String column)
        {
            if (column == "Course_ID")
            {
                return 1;
            }
            else if (column == "Course_Name")
            {
                return 2;
            }
            else if (column == "Professor_Name")
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }


        /// Logan knows what this does but im guessing it just makes sure things are supposed to be happening
        /// 
        /// output: True: ??? false: ???
        private bool validiatyCheck()
        {
            bool valid = false;
            if (drpSearchType.SelectedItem.Text != "--Select--")
            {
                valid = true;
            }
            return valid;
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