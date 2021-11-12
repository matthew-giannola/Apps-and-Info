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
            int i = 0;

            UserDataClassesDataContext us = new UserDataClassesDataContext();
            var search = (from c in us.Classes
                          where (c.Id.ToString().Contains(searchText) ||
                          c.professorName.ToString().Contains(searchText) ||
                          c.description.ToString().Contains(searchText))
                          select c).ToList();

            foreach (var c in search)
            {
                String CourseID = c.Id.ToString();
                String CourseName = c.courseTitle.ToString();
                String Description = c.description.ToString();
                DynamicCreateTile(i + 1, CourseID, CourseName, Description);
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
        //Functions in this block:
        //  DynamicCreateTile
        //  CreateButton_CourseName     **part of problem**
        //  CreateLabel_CourseID
        //  CreateLabel_Description
        //  Button_Click                **part of problem**
        //  CourseRedirect              **part of problem**
        private void DynamicCreateTile(int i, string CourseID, string CourseName, string Description)
        {
            CreateButton_CourseName(i, CourseName, CourseID);
            CreateLabel_CourseID(i, CourseID);
            CreateLabel_Description(i, Description);
        }
        private void CreateButton_CourseName(int i, string CourseName, string CourseID)
        {
            System.Web.UI.HtmlControls.HtmlButton Course_Name = new System.Web.UI.HtmlControls.HtmlButton();
            Course_Name.ID = "btn_CourseName" + i.ToString();
            Course_Name.InnerHtml = CourseName;
            Course_Name.ServerClick += new System.EventHandler((sender, e) => Button_Click(sender, e, CourseID));
            Page.Controls.Add(Course_Name);
        }
        private void CreateLabel_CourseID(int i, string CourseID)
        {
            System.Web.UI.WebControls.Label Course_ID = new System.Web.UI.WebControls.Label();
            Course_ID.CssClass = "TopOfTile";
            Course_ID.ID = "lbl_CourseID" + i.ToString();
            Course_ID.Text = CourseID;
            Page.Controls.Add(Course_ID);
        }
        private void CreateLabel_Description(int i, string Description)
        {
            System.Web.UI.WebControls.Label description = new System.Web.UI.WebControls.Label();
            description.CssClass = "Description";
            description.ID = "lbl_Description" + i.ToString();
            description.Text = Description;
            Page.Controls.Add(description);
        }
        void Button_Click(object sender, EventArgs e, string CourseID)
        {
            int Course_ID = Int32.Parse(CourseID);
            if (Course_ID != null)
            {
                CoursePage.course = Course_ID;
                Response.Redirect("~/Course Function/CoursePage.aspx");
            }
        }
        private void CourseRedirect(int CourseID)
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
        protected void Results1_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_1.Text);
            CourseRedirect(CourseID);
        }
    }
}