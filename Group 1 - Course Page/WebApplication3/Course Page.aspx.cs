using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Npgsql;
namespace WebApplication3
{

    public partial class Course : Page
    {
        public static Int32 course;
        protected void Page_Load(object sender, EventArgs e)
        {

            var cs = "Host=localhost;Username=postgres;Password=smokey99;Database=Apps Project";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(cs);
            var con = npgsqlConnection;
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT videourl FROM classes WHERE id =";
            cmd.CommandText += course + ";";
            cmd.CommandType = CommandType.Text;

            // Gets the video url from the database
            string video_id = cmd.ExecuteScalar().ToString();
            var videoframe = new Literal();
            video_id = video_id.Split('=')[1];
            video_id = "https://www.youtube.com/embed/" + video_id;
            videoframe.Text = String.Format(@"<iframe width=""628"" height=""374"" src=""{0}"" frameborder=""0"" allowfullscreen></iframe>", video_id);
            test.Controls.Add(videoframe);

            // Grabs the description from the database
            cmd.CommandText = "SELECT description FROM classes WHERE id = " + course + ";";
            courseDescription.Text = cmd.ExecuteScalar().ToString(); 
        }
        public void updateCourse(Int32 courseId)
        {
            
        }

        protected void testButton_Click(object sender, EventArgs e)
        {
            About.course = course;
            Response.Redirect("Quiz.aspx", false);
        }
    }
}