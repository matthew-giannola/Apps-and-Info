using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Finalprog;

namespace Finalprog
{

    public partial class CoursePage : Page
    {
        public static Int32 course;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();

            var video_id = us.Classes.Where(a => a.Id == course).Select(a => a.videourl).FirstOrDefault();

            // Gets the video url from the database
            var videoframe = new Literal();
            video_id = video_id.Split('=')[1];
            video_id = "https://www.youtube.com/embed/" + video_id;
            videoframe.Text = String.Format(@"<iframe width=""628"" height=""374"" src=""{0}"" frameborder=""0"" allowfullscreen></iframe>", video_id);
            test.Controls.Add(videoframe);


            var currentclass = us.Classes.Where(a => a.Id == course).FirstOrDefault();

            lblCourse.Text = currentclass.Id + " " + currentclass.courseTitle;

            var zoom = us.Classes.Where(a => a.Id == course).Select(a => a.zoomLink).FirstOrDefault();
            var descrip = us.Classes.Where(a => a.Id == course).Select(a => a.description).FirstOrDefault();
            var announcemessage = us.Classes.Where(a => a.Id == course).Select(a => a.announcementMessage).FirstOrDefault();
            var teacher = us.Classes.Where(a => a.Id == course).Select(a => a.professorName).FirstOrDefault();

            announceLabel.Text = announcemessage;
            descriptionLabel.Text = descrip;
            if(zoom == null)
            {
                zoomLabel.Text = "This course does not have a Zoom meeting scheduled. Check back later";
            }
            else
            {
                zoomLabel.Text = zoom;
            }
            teachLabel.Text = "Teacher: " + teacher;

        }
        public void updateCourse(Int32 courseId)
        {

        }

        protected void testButton_Click(object sender, EventArgs e)
        {
            Quiz_Page.course = course;
            Response.Redirect("Quiz_Page.aspx", false);
        }

    }
}