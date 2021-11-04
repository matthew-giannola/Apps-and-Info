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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchText"></param>
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
                String temp = ("Course: " + c.Id.ToString() + " " + 
                    c.description.ToString() + " " + c.professorName.ToString() + " ");
                CreateTile(i, temp);
                i++;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        /// 
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnResultsSearch_Click(object sender, EventArgs e)
        {
            ClearTiles();
            string searchText = txtResultsSearch.Text;
            bool check = searchCheck(searchText);

            if (check == true)
            {
                Search(searchText);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void ClearTiles()
        {
            btnResults1.Visible = false;
            btnResults2.Visible = false;
            btnResults3.Visible = false;
            btnResults4.Visible = false;
            btnResults5.Visible = false;
            btnResults6.Visible = false;
            btnResults7.Visible = false;
            btnResults8.Visible = false;
            btnResults9.Visible = false;
            //btnResults10.Visible = false;
        }
        /// <summary>
        /// 
        /// </summary>
        private void CreateTile(int i, string temp)
        {
            switch (i)
            {
                case 0:
                    btnResults1.Visible = true;
                    btnResults1.Text = temp;
                    btnResults1.BackColor = RandomColor();
                    break;
                case 1:
                    btnResults2.Visible = true;
                    btnResults2.Text = temp;
                    btnResults2.BackColor = RandomColor();
                    break;
                case 2:
                    btnResults3.Visible = true;
                    btnResults3.Text = temp;
                    btnResults3.BackColor = RandomColor();
                    break;
                case 3:
                    btnResults4.Visible = true;
                    btnResults4.Text = temp;
                    btnResults4.BackColor = RandomColor();
                    break;
                case 4:
                    btnResults5.Visible = true;
                    btnResults5.Text = temp;
                    btnResults5.BackColor = RandomColor();
                    break;
                case 5:
                    btnResults6.Visible = true;
                    btnResults6.Text = temp;
                    btnResults6.BackColor = RandomColor();
                    break;
                case 6:
                    btnResults7.Visible = true;
                    btnResults7.Text = temp;
                    btnResults7.BackColor = RandomColor();
                    break;
                case 7:
                    btnResults8.Visible = true;
                    btnResults8.Text = temp;
                    btnResults8.BackColor = RandomColor();
                    break;
                case 8:
                    btnResults9.Visible = true;
                    btnResults9.Text = temp;
                    btnResults9.BackColor = RandomColor();
                    break;
                //case 9:
                    //btnResults10.Visible = true;
                    //btnResults10.Text = temp;
                    //btnResults10.BackColor = RandomColor();
                    //break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void CourseRedirect(int i)
        {
            String temp = "";
            switch (i)
            {
                case 0:
                    temp = btnResults1.Text;
                    break;
                case 1:
                    temp = btnResults2.Text;
                    break;
                case 2:
                    temp = btnResults3.Text;
                    break;
                case 3:
                    temp = btnResults4.Text;
                    break;
                case 4:
                    temp = btnResults5.Text;
                    break;
                case 5:
                    temp = btnResults6.Text;
                    break;
                case 6:
                    temp = btnResults7.Text;
                    break;
                case 7:
                    temp = btnResults8.Text;
                    break;
                case 8:
                    temp = btnResults9.Text;
                    break;
                //case 9:
                    //temp = btnResults10.Text;
                    //break;
            }

            if (!String.IsNullOrWhiteSpace(temp))
            {
                int course = Convert.ToInt32(temp.Substring(8, 4));

                CoursePage.course = course;
                Response.Redirect("~/Course Function/CoursePage.aspx");
            }
        }

        private Color RandomColor() {
            var rand = new Random();
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

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
        protected void btnResults1_Click(object sender, EventArgs e)
        {
            CourseRedirect(0);
        }
        protected void btnResults2_Click(object sender, EventArgs e)
        {
            CourseRedirect(1);
        }
        protected void btnResults3_Click(object sender, EventArgs e)
        {
            CourseRedirect(2);
        }
        protected void btnResults4_Click(object sender, EventArgs e)
        {
            CourseRedirect(3);
        }
        protected void btnResults5_Click(object sender, EventArgs e)
        {
            CourseRedirect(4);
        }
        protected void btnResults6_Click(object sender, EventArgs e)
        {
            CourseRedirect(5);
        }
        protected void btnResults7_Click(object sender, EventArgs e)
        {
            CourseRedirect(6);
        }
        protected void btnResults8_Click(object sender, EventArgs e)
        {
            CourseRedirect(7);
        }
        protected void btnResults9_Click(object sender, EventArgs e)
        {
            CourseRedirect(8);
        }
    }
}