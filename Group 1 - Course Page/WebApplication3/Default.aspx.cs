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
    
    public partial class _Default : Page
    {
        protected void btnInsertion_Click(object sender, EventArgs e)
        {
            try
            {
                /* Insertion After Validations*/
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    var cs = "Host=localhost;Username=postgres;Password=smokey99;Database=test";
                    NpgsqlConnection npgsqlConnection = new NpgsqlConnection(cs);
                    var con = npgsqlConnection;
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into employee values(@ID,@Fname,@Lname,@Email)";
                    cmd.CommandType = CommandType.Text; 
                   /* cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(txtEmpID.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@Fname", txtEmpFname.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Lname", txtEmpLname.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Email", txtEmpEmail.Text));
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    txtEmpEmail.Text = "";
                    txtEmpFname.Text = "";
                    txtEmpID.Text = "";
                    txtEmpLname.Text = "";
                    lblmsg.Text = "Data Has been Saved";*/
                }
            }
            catch (Exception ex) {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex + "');", true);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Course.course = 1430;
            Response.Redirect("Course Page.aspx", false);
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Course.course = 2430;
            Response.Redirect("Course Page.aspx", false);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
    
}