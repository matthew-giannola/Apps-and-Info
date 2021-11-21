using System;
using System.Windows;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Finalprog.WebForm1;
using System.Drawing;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;


namespace Finalprog
{
    public partial class REsults : System.Web.UI.Page
    {
        public static UserDataClassesDataContext us = new UserDataClassesDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Login.currentUser))
            {
                Response.Redirect("Login.aspx");
            }

            user eo = (from f in us.users 
                       where f.username == Login.currentUser 
                       select f).SingleOrDefault();
            var role = us.Roles.Where(a => a.Id == eo.RoleID).Select(a => a.Description).FirstOrDefault();

            if (Session["searchTerm"] != null)
            {
                String searchText = Session["searchTerm"].ToString();
                Search(searchText);
            }

            if (eo != null)
            {
                if (role == "Admin")
                {
                    btnAdmin.Visible = true;
                }
            }
        }
        private void Search(string searchText)
        {
            //declaration of the amount (set to 0 initally) for the amount of classes.
            int i = 0;

            //finds the data set that matches the search requirements.
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            var search = (from c in us.Classes
                          where (c.Id.ToString().Contains(searchText) ||
                          c.professorName.ToString().Contains(searchText) ||
                          c.description.ToString().Contains(searchText))
                          select c).ToList();

            //creating of the tiles.
            foreach (var c in search)
            {
                String CourseID = c.Id.ToString();
                String CourseName = c.courseTitle.ToString();
                String Description = c.description.ToString();
                CreateButton_CourseName(i, CourseName, CourseID);
                CreateLabel_CourseID(i, CourseID);
                CreateLabel_Description(i, Description, CourseID);
                i++;
            }
        }
        private bool searchCheck(string search)
        {
            if (search != null && !String.IsNullOrWhiteSpace(txtResultsSearch.Text))
            {
                return true;
            }
            else
            {
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
        //Code block for the dynmaic adding of the tiles.
        private void CreateButton_CourseName(int i, string CourseName, string CourseID)
        {
            LinkButton Course_Name = new LinkButton
            {
                ID = "hl_CourseName" + i.ToString(),
                Text = CourseName,
                CssClass = "TopOfTile",
                CausesValidation = false
            };
            Course_Name.Click += new EventHandler((sender, e) => Button_Click(sender, e, Int32.Parse(CourseID)));
            Page.Controls.Add(Course_Name);
        }
        private void CreateLabel_CourseID(int i, string CourseID)
        {
            System.Web.UI.WebControls.Label Course_ID = new System.Web.UI.WebControls.Label
            {
                ID = "lbl_CourseID" + CourseID,
                Text = CourseID,
                CssClass = "TopOfTile"
            };
            Page.Controls.Add(Course_ID);
        }
        private void CreateLabel_Description(int i, string Description, string CourseID)
        {
            System.Web.UI.WebControls.Label description = new System.Web.UI.WebControls.Label
            {
                ID = "lbl_Description" + CourseID,
                Text = Description,
                CssClass = "Description"
            };
            Page.Controls.Add(description);
        }


        //Button clicking Functions
        private void Button_Click(object sender, EventArgs e, int CourseID)
        {
            if (CourseID != null)
            {
                CoursePage.course = CourseID;
                Response.Redirect("~/Course Function/CoursePage.aspx");
            }
        }


        //Normal Button Click Events
        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User Function/Admin.aspx");
        }
        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User Function/UserPage.aspx");
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            user eo = (from f in us.users 
                       where f.username == Login.currentUser 
                       select f).SingleOrDefault();
            us.SubmitChanges();
            Login.currentUser = "";
            Response.Redirect("~/User Function/Login.aspx");
        }
        public override void VerifyRenderingInServerForm(System.Web.UI.Control control){/*there should be nothing in this*/}
    }
}