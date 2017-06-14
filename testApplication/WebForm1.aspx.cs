using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace testApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridViewData();
            }

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(CS);
            using (SqlCommand command = new SqlCommand("select * from Users", conn))
            {
                conn.Open();
                SqlDataReader data = command.ExecuteReader();
                GridView1.DataSource = data;
                GridView1.DataBind();
                conn.Close();
            }
                 
        }

        private void BindGridViewData()
        {
            GridView1.DataSource = UserDataAccess.GetUsers();
            GridView1.DataBind();
        }


        /* con.Open();
        SqlCommand cmd = new SqlCommand("Select Name,Salary FROM YOUR TABLE", con);
        SqlDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        con.Close();*/

      //  protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
       // {
            
           /* else if (e.CommandName == "InsertRow")
            {
                string Username = ((TextBox)GridView1.FooterRow.FindControl("txtName")).Text;
                string Password = ((TextBox)GridView1.FooterRow.FindControl("txtPassword")).Text;
                string Email = ((TextBox)GridView1.FooterRow.FindControl("txtEmail")).Text;
                string Name = ((TextBox)GridView1.FooterRow.FindControl("txtName")).Text;

                UserDataAccess.InsertUsers(Username, Password, Email, Name);

                BindGridViewData();
            }*/
      //  }

        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditRow")
            {
                int rowIndex = ((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).RowIndex;
                GridView1.EditIndex = rowIndex;
                BindGridViewData();
            }
            else if (e.CommandName == "DeleteRow")
            {
                UserDataAccess.DeleteUser(Convert.ToInt32(e.CommandArgument));
                BindGridViewData();
            }
            else if (e.CommandName == "CancelUpdate")
            {
                GridView1.EditIndex = -1;
                BindGridViewData();
            }
            else if (e.CommandName == "UpdateRow")
            {
                int rowIndex = ((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).RowIndex;

                int Id = Convert.ToInt32(e.CommandArgument);
                string Username = ((TextBox)GridView1.Rows[rowIndex].FindControl("TextBox1")).Text;
                string Password = ((TextBox)GridView1.Rows[rowIndex].FindControl("TextBox2")).Text;
                string Email = ((TextBox)GridView1.Rows[rowIndex].FindControl("TextBox3")).Text;
                string Name = ((TextBox)GridView1.Rows[rowIndex].FindControl("TextBox4")).Text;

                UserDataAccess.UpdateUsers(Id, Username, Password, Email, Name);

                GridView1.EditIndex = -1;
                BindGridViewData();
            }
        }
    }






}