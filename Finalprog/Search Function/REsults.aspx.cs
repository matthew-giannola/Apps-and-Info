using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Finalprog.WebForm1;

namespace Finalprog
{
    public partial class REsults : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["searchTerm"] != null)
            {
                String searchText = Session["searchTerm"].ToString();
                Search(searchText);
            }
        }


      private void Search(string searchText)
      {
         UserDataClassesDataContext us = new UserDataClassesDataContext();
         var search = (from c in us.Classes
                       where (c.Id.ToString().StartsWith(searchText) ||
                       c.professorName.ToString().StartsWith(searchText) || c.description.ToString().StartsWith(searchText))
                       select c).FirstOrDefault();

            var result = search.Id + " " + search.description;
            //btnNav.Visible = true;
            CoursePage.course = search.Id;
            lblSearchResults.Text = result;
            lblSearchResults.Visible = true;
      }


      private bool searchCheck(string search)
      {
         if (search != null && !String.IsNullOrWhiteSpace(txtResultsSearch.Text))
         {
            return true;
         }
         else
         {
            lblSearchResults.Visible = true;
            lblSearchResults.Text = "Value not Found";
            return false;
         }
      }


      protected void btnResultsSearch_Click(object sender, EventArgs e)
      {
            string searchText = txtResultsSearch.Text;
            bool check = searchCheck(searchText);

            if (check == true) 
            {
               Search(searchText);
            }
      }


   }
}