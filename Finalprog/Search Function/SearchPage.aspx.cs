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
        protected void Page_Load(object sender, EventArgs e)
        {

<<<<<<< Updated upstream
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Session["searchTerm"] = txtSearch.Text;
                Response.Redirect("REsults.aspx");
            }
            catch { }
        }
=======

<<<<<<< Updated upstream
=======

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        //this is what is called when you click the search button
        //this only runs the search function
        protected void BtnSearch(object sender, EventArgs e)
        {
            try
            {
                //this should be a redirect to the results page. 
                //we need to pass through the data from txtSearch.txt to the results page.
                Search();
            }
            catch { }
        }


        //makes you go to the course page when clicked.
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        protected void ButtonNav_Click(object sender, EventArgs e)
        {
            Response.Redirect("CoursePage.aspx");
        }
<<<<<<< Updated upstream
=======


        //this function is what creates the data to send over to the results page.
        public string DataCollection()
        {
            string searchText = txtSearch.Text;
            return searchText;
        }


<<<<<<< Updated upstream
=======
        //this function is what creates the data to send over to the results page.
        public string DataCollection()
        {
            string searchText = txtSearch.Text;
            return searchText;
        }


>>>>>>> Stashed changes
        //this searches the database tabe that is labeled "Courses" for data. 
        //Returns the data directly into the lblResults
        //data type needs to be changed to an array of strings, so that we can display more than one.
        private void Search()
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            string searchText = txtSearch.Text;
            var search = (from c in us.Classes where (c.Id.ToString().StartsWith(searchText) || 
                c.professorName.ToString().StartsWith(searchText) || c.description.ToString().StartsWith(searchText)) select c).FirstOrDefault();

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
>>>>>>> Stashed changes
    }
    public class Search
    {

    }
    public class Search
    {

    }
    public class Search
    {

    }
}