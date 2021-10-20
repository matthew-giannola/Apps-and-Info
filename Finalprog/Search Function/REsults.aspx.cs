using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows;
using System.Web.UI;
using System.Drawing;
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
            String temp;

            lstResults.Items.Clear();
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            var search = (from c in us.Classes
                          where (c.Id.ToString().StartsWith(searchText) ||
                          c.professorName.ToString().StartsWith(searchText) ||
                          c.description.ToString().StartsWith(searchText))
                          select c).ToList();

            foreach (var c in search)
            {
                temp = ("Course; Id: " + c.Id.ToString() + " Name: " + c.description.ToString() + " Professor: " + c.professorName.ToString());
                lstResults.Items.Add(temp);
            }
           
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
                lstResults.Text = "Value not Found";
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
        private void CreateTile()
        {
            int top = 50;
            int left = 100;

            /*for (int i = 0; i < lstResults.Items.Count; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                this.Controls.Add(button);
                top += button.Height + 2;
            }*/
        }
        /// <summary>
        /// 
        /// </summary>
        private void SortResults()
        {

        }
    }
}