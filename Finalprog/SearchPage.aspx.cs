﻿using System;
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

            //string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);

            //string column = drpSearchType.SelectedItem.Value;
            //int columntype = searchColumnType(column);

            //string SearchQuery = "select * from CoursesTable where [Course_ID] like '%" + searchText + "%' or [Course_Name] like '%" + searchText + "%' or [Professor_Name] like '%" + searchText + "%'";

            //SqlCommand DQ = new SqlCommand(SearchQuery, con);
            //con.Open();
            //SqlDataReader drDQ = DQ.ExecuteReader();

            string searchText = txtSearch.Text;
            var search = (from c in us.Classes
                          where (c.description.StartsWith(searchText) || c.Id.ToString().StartsWith(searchText))
                          select c).FirstOrDefault();

            var result = search.Id + " " + search.description;
            btnNav.Visible = true;
            CoursePage.course = search.Id;

            lblResults.Text = result;

            //while (drDQ.Read())
            //{
            //    if (searchText == drDQ.GetValue(columntype).ToString())
            //    {

            //        lblResults.Text = drDQ.GetValue(0).ToString();
            //        for (int i = 1; i <= 6; i++)
            //        {

            //            lblResults.Text += (" " + drDQ.GetValue(i).ToString());
            //        }
            //    }
            //}

        }

        /// Function to turn the search type to a numero 
        /// 
        /// outputs 0 for course ID 1 for Course name and 3 for Professor name (ARGO)
        private int searchColumnType(String column)
        {
            if (column == "Course_ID")
            {
                return 0;
            }
            else if (column == "Course_Name")
            {
                return 1;
            }
            else
            {
                return 3;
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