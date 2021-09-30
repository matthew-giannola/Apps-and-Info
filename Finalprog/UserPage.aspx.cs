using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalprog
{
    public partial class UserPage : System.Web.UI.Page
    {

        public static UserDataClassesDataContext us = new UserDataClassesDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {

            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();

            if (!String.IsNullOrWhiteSpace(eo.status))
            {
                StatusText.Text = eo.status;
                eo.status = "";
            }
            if (!String.IsNullOrWhiteSpace(eo.color))
            {
                formBack.Attributes["style"] = "background-color:" + eo.color;
            }

            Label1.Visible = true;
            Label1.Text = "Welcome " + eo.first_name;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {


            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();


            eo.status = StatusText.Text;
            us.SubmitChanges();
            Login.currentUser = "";
            Response.Redirect("Login.aspx");
        }

        protected void btnRed_Click(object sender, EventArgs e)
        {
 

            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();

            formBack.Attributes["style"] = "background-color:#990000;";
            eo.color = "#990000";
        }

        protected void btnGreen_Click(object sender, EventArgs e)
        {


            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();
            formBack.Attributes["style"] = "background-color:#006600;";
            eo.color = "#006600";
        }

        protected void btnBlue_Click(object sender, EventArgs e)
        {
            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();
            formBack.Attributes["style"] = "background-color:#000066;";
            eo.color = "#000066";
        }

        protected void btnWhite_Click(object sender, EventArgs e)
        {
            
            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();
            formBack.Attributes["style"] = "background-color:White;";
            eo.color = "#White";
        }

        protected void StatusText_TextChanged(object sender, EventArgs e)
        {
           
            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();
            eo.status = StatusText.Text;
        }

        protected void btnCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchPage.aspx");
        }
    }
}