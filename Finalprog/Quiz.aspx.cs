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

    public partial class About : Page
    {
        public static Int32 course;
        private static int quizid;
        private Int32 score = 0;
        private static Int32 total = 5;
        private int[] correctanswers = new int[5];
        private int[] useranswers = new int[5];
        protected void Button1_Click(object sender, EventArgs e)
        {

            var cs = "Host=localhost;Username=postgres;Password=smokey99;Database=Apps Project";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(cs);
            var con = npgsqlConnection;
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;



           
            //Gather Correct Answers
            int count = 0;
            for (int i = 1; i < 21; i++)
            {
                Boolean result = false;
                cmd.CommandText = "SELECT correctanswer FROM quizanswers WHERE qcount = " + i + " and quizid = " + quizid + ";";



                result = (Boolean)cmd.ExecuteScalar();
                if (result == true)
                {
                    cmd.CommandText = "SELECT anum FROM quizanswers WHERE qcount = " + i + " and quizid = " + quizid + ";";
                    correctanswers[count] = (int)cmd.ExecuteScalar();
                    count++;
                }
            }

            //Gather user answers
            useranswers[0] = RadioButtonList1.SelectedIndex;
            useranswers[1] = RadioButtonList2.SelectedIndex;
            useranswers[2] = RadioButtonList3.SelectedIndex;
            useranswers[3] = RadioButtonList4.SelectedIndex;
            useranswers[4] = RadioButtonList5.SelectedIndex;

            //Compare Answers
            for (int i = 0; i < 5; i++)
            {
                if (useranswers[i] == correctanswers[i])
                {
                    score++;
                }
            }

            //Display Score
            scoreLabel.Visible = true;
            scoreLabel.Text = score + "/" + total;
            Button1.Enabled = false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                var quizID = 0;
                var cs = "Host=localhost;Username=postgres;Password=smokey99;Database=Apps Project";
                NpgsqlConnection npgsqlConnection = new NpgsqlConnection(cs);
                var con = npgsqlConnection;
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT quizid FROM quizzes WHERE courseid = ";
                cmd.CommandText += course + ";";
                cmd.CommandType = CommandType.Text;
                quizID = (int)cmd.ExecuteScalar();
                quizid = quizID;

                cmd.CommandText = "SELECT quiztitle FROM quizzes WHERE courseid = ";
                cmd.CommandText += course + ";";
                cmd.CommandType = CommandType.Text;
                quizTitle.Text = cmd.ExecuteScalar().ToString();


                //Load Questions
                cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 1;";
                Question_1.Text = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 2;";
                Question_2.Text = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 3;";
                Question_3.Text = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 4;";
                Question_4.Text = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "SELECT question FROM quizquestions WHERE quizid = " + quizID + " AND qid = 5;";
                Question_5.Text = cmd.ExecuteScalar().ToString();

                //Question 1 Load Answers
                RadioButtonList1.Items.Clear();

                UserDataClassesDataContext us = new UserDataClassesDataContext();

                var answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 1 && a.qcount == 1)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList1.Items.Add(answer);


                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 1 and qcount = 1";
                RadioButtonList1.Items.Add(cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 1 and qcount = 2";
                RadioButtonList1.Items.Add(cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 1 and qcount = 3";
                RadioButtonList1.Items.Add(cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 1 and qcount = 4";
                RadioButtonList1.Items.Add(cmd.ExecuteScalar().ToString());

                //Questions 2 Load Answers
                RadioButtonList2.Items.Clear();
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 2 and qcount = 5";
                RadioButtonList2.Items.Insert(0, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 2 and qcount = 6";
                RadioButtonList2.Items.Insert(1, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 2 and qcount = 7";
                RadioButtonList2.Items.Insert(2, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 2 and qcount = 8";
                RadioButtonList2.Items.Insert(3, cmd.ExecuteScalar().ToString());

                //Question 3 Load Answers
                RadioButtonList3.Items.Clear();
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 3 and qcount = 9";
                RadioButtonList3.Items.Insert(0, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 3 and qcount = 10";
                RadioButtonList3.Items.Insert(1, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 3 and qcount = 11";
                RadioButtonList3.Items.Insert(2, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 3 and qcount = 12";
                RadioButtonList3.Items.Insert(3, cmd.ExecuteScalar().ToString());

                //Question 4 Load Answers
                RadioButtonList4.Items.Clear();
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 4 and qcount = 13";
                RadioButtonList4.Items.Insert(0, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 4 and qcount = 14";
                RadioButtonList4.Items.Insert(1, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 4 and qcount = 15";
                RadioButtonList4.Items.Insert(2, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 4 and qcount = 16";
                RadioButtonList4.Items.Insert(3, cmd.ExecuteScalar().ToString());

                //Question 5 Load Answers
                RadioButtonList5.Items.Clear();
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 5 and qcount = 17";
                RadioButtonList5.Items.Add(cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 5 and qcount = 18";
                RadioButtonList5.Items.Insert(1, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 5 and qcount = 19";
                RadioButtonList5.Items.Insert(2, cmd.ExecuteScalar().ToString());
                cmd.CommandText = "SELECT answer FROM quizanswers WHERE quizid = " + quizID + "and qqid = 5 and qcount = 20";
                RadioButtonList5.Items.Insert(3, cmd.ExecuteScalar().ToString());
            }
            else
            {
                int index = 0;
                index = RadioButtonList1.SelectedIndex;
                RadioButtonList1.SelectedIndex = index;
                index = RadioButtonList2.SelectedIndex;
                RadioButtonList2.SelectedIndex = index;
                index = RadioButtonList3.SelectedIndex;
                RadioButtonList3.SelectedIndex = index;
                index = RadioButtonList4.SelectedIndex;
                RadioButtonList4.SelectedIndex = index;
                index = RadioButtonList5.SelectedIndex;
                RadioButtonList5.SelectedIndex = index;
            }
        }

        private void EnableViewState(bool v)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            index = RadioButtonList1.SelectedIndex;
            RadioButtonList1.SelectedIndex = index;
        }

        protected void RadioButtonList5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}