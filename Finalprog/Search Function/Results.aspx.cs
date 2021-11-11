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
            clearnewTiles();
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
                //for the new tiles
                String courseID = c.Id.ToString();
                String CourseName = c.courseTitle.ToString();
                String Professor = c.professorName.ToString();
                String Description = c.description.ToString();
                CreateNewTile(i, courseID, CourseName, Professor, Description);
                
                //button tiles
                //String temp = ("Course: " + c.Id.ToString() + " " + 
                    //c.description.ToString() + " " + c.professorName.ToString() + " ");
                //CreateTile(i, temp);
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
            clearnewTiles();
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
        private void clearnewTiles()
        {
            Tile1.Visible = false;
            Tile2.Visible = false;
            Tile3.Visible = false;
            Tile4.Visible = false;
            Tile5.Visible = false;
            Tile6.Visible = false;
            Tile7.Visible = false;
            Tile8.Visible = false;
            Tile9.Visible = false;
            Tile10.Visible = false;
        }
        private void CreateNewTile(int i, string CourseID, string CourseName, string Professor, string Description)
        {
            switch(i)
            {
                case 0:
                    Tile1.Visible = true;
                    lbl_CourseID_1.Text = CourseID;
                    btn_CourseName_1.Text = CourseName;
                    lbl_Description_1.Text = Description;
                    break;
                case 1:
                    Tile2.Visible = true;
                    lbl_CourseID_2.Text = CourseID;
                    btn_CourseName_2.Text = CourseName;
                    lbl_Description_2.Text = Description;
                    break;
                case 2:
                    Tile3.Visible = true;
                    lbl_CourseID_3.Text = CourseID;
                    btn_CourseName_3.Text = CourseName;
                    lbl_Description_3.Text = Description;
                    break;
                case 3:
                    Tile4.Visible = true;
                    lbl_CourseID_4.Text = CourseID;
                    btn_CourseName_4.Text = CourseName;
                    lbl_Description_4.Text = Description;
                    break;
                case 4:
                    Tile5.Visible = true;
                    lbl_CourseID_5.Text = CourseID;
                    btn_CourseName_5.Text = CourseName;
                    lbl_Description_5.Text = Description;
                    break;
                case 5:
                    Tile6.Visible = true;
                    lbl_CourseID_6.Text = CourseID;
                    btn_CourseName_6.Text = CourseName;
                    lbl_Description_6.Text = Description;
                    break;
                case 6:
                    Tile7.Visible = true;
                    lbl_CourseID_7.Text = CourseID;
                    btn_CourseName_7.Text = CourseName;
                    lbl_Description_7.Text = Description;
                    break;
                case 7:
                    Tile8.Visible = true;
                    lbl_CourseID_8.Text = CourseID;
                    btn_CourseName_8.Text = CourseName;
                    lbl_Description_8.Text = Description;
                    break;
                case 8:
                    Tile9.Visible = true;
                    lbl_CourseID_9.Text = CourseID;
                    btn_CourseName_9.Text = CourseName;
                    lbl_Description_9.Text = Description;
                    break;
                case 9:
                    Tile10.Visible = true;
                    lbl_CourseID_10.Text = CourseID;
                    btn_CourseName_10.Text = CourseName;
                    lbl_Description_10.Text = Description;
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <summary>
        /// 
        /// </summary>
        private void CourseRedirect(int CourseID)
        {
            if (CourseID != null)
            {
                CoursePage.course = CourseID;
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

        //results clicking
        protected void btnResults1_Click(object sender, EventArgs e)
        {
            //CourseRedirect(0);
        }
        protected void btnResults2_Click(object sender, EventArgs e)
        {
            //CourseRedirect(1);
        }
        protected void btnResults3_Click(object sender, EventArgs e)
        {
            //CourseRedirect(2);
        }
        protected void btnResults4_Click(object sender, EventArgs e)
        {
            //CourseRedirect(3);
        }
        protected void btnResults5_Click(object sender, EventArgs e)
        {
            //CourseRedirect(4);
        }
        protected void btnResults6_Click(object sender, EventArgs e)
        {
            //CourseRedirect(5);
        }
        protected void btnResults7_Click(object sender, EventArgs e)
        {
            //CourseRedirect(6);
        }
        protected void btnResults8_Click(object sender, EventArgs e)
        {
            //CourseRedirect(7);
        }
        protected void btnResults9_Click(object sender, EventArgs e)
        {
            //CourseRedirect(8);
        }
        
        //for the new tiles
        //this is only here for testing right now.
        //please do not touch this.
        protected void Results1_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_1.Text);
            CourseRedirect(CourseID);
        }
        protected void Results2_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_2.Text);
            CourseRedirect(CourseID);
        }
        protected void Results3_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_3.Text);
            CourseRedirect(CourseID);
        }
        protected void Results4_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_4.Text);
            CourseRedirect(CourseID);
        }
        protected void Results5_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_5.Text);
            CourseRedirect(CourseID);
        }
        protected void Results6_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_6.Text);
            CourseRedirect(CourseID);
        }
        protected void Results7_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_7.Text);
            CourseRedirect(CourseID);
        }
        protected void Results8_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_8.Text);
            CourseRedirect(CourseID);
        }
        protected void Results9_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_9.Text);
            CourseRedirect(CourseID);
        }
        protected void Results10_Click(object sender, EventArgs e)
        {
            int CourseID = Int32.Parse(lbl_CourseID_10.Text);
            CourseRedirect(CourseID);
        }
    }
}