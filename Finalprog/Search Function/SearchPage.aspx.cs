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
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            user eo = (from f in us.users where f.username == Login.currentUser select f).SingleOrDefault();
            /*if (eo.role == "Admin")
            {
                btnAdmins.Visible = true;
            }*/
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


        protected void ButtonNav_Click(object sender, EventArgs e)
        {
            Response.Redirect("CoursePage.aspx");
        }


        
    }
}