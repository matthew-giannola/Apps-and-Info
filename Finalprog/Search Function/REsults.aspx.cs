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
        int count = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["searchTerm"] != null)
            {
                String searchText = Session["searchTerm"].ToString();
                Search(searchText);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchText"></param>
        private void Search(string searchText)
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            var search = (from c in us.Classes where (c.Id.ToString().StartsWith(searchText) ||
                c.professorName.ToString().StartsWith(searchText) || 
                c.description.ToString().StartsWith(searchText)) select c).FirstOrDefault();

            Courses course = new Courses
            {
                id = search.Id,
                description = search.description,
                videoURL = search.videourl,
                professorName = search.professorName,
                name = search.name,
                lectureHours = (int)search.lectureHours,
                studentNumber = (int)search.studentNumber,
                credits = (int)search.credits,
                review = (int)search.review
            };
            CourseArray(course);

            lblSearchResults.Text = course.ToString();
            /*var result = search.Id + " " + search.description;
            //btnNav.Visible = true;
            CoursePage.course = search.Id;
            lblSearchResults.Text = result;
            lblSearchResults.Visible = true;*/
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnResultsSearch_Click(object sender, EventArgs e)
        {
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
        private void MultipleDisplay()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void SortResults()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="courses"></param>
        public void CourseArray(Courses courses)
        {
            Courses[] coursearray = new Courses[count + 1];
            if(count < (coursearray.Count()-1))
            {
                coursearray[count] = courses;
            }
            count += 1;
        }
    }
}