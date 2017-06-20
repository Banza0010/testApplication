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
                string Username = ((TextBox)GridView1.Rows[rowIndex].FindControl("Username")).Text;
                string Password = ((TextBox)GridView1.Rows[rowIndex].FindControl("TextBox2")).Text;
                string Email = ((TextBox)GridView1.Rows[rowIndex].FindControl("TextBox3")).Text;
                string Name = ((TextBox)GridView1.Rows[rowIndex].FindControl("TextBox4")).Text;

                UserDataAccess.UpdateUsers(Id, Username, Password, Email, Name);

                GridView1.EditIndex = -1;
                BindGridViewData();

                /*
                 
                cmd = new SqlCommand("update tbl_Record set Name=@name,State=@state where ID=@id", con);  
                con.Open();  
                cmd.Parameters.AddWithValue("@id", ID);  
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);  
                cmd.Parameters.AddWithValue("@state", txt_State.Text);  
                cmd.ExecuteNonQuery();  
                MessageBox.Show("Record Updated Successfully");  
                con.Close();  
                DisplayData();              */
            }
        }
              //  int rowIndex = ((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).RowIndex;
               


            //dont mind
          /*    int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());  
          GridViewRow row = (GridViewRow) GridView1.Rows[e.RowIndex];  
          Label lblID = (Label) row.FindControl("lblID");  
          //TextBox txtname=(TextBox)gr.cell[].control[];  
          TextBox textName = (TextBox) row.Cells[0].Controls[0];  
          TextBox textadd = (TextBox) row.Cells[1].Controls[0];  
          TextBox textc = (TextBox) row.Cells[2].Controls[0];  
          //TextBox textadd = (TextBox)row.FindControl("txtadd");  
          //TextBox textc = (TextBox)row.FindControl("txtc");  
          GridView1.EditIndex = -1;  
          conn.Open();  
          //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
          SqlCommand cmd = new SqlCommand("update detail set name='" + textName.Text + "',address='" + textadd.Text + "',country='" + textc.Text + "'where id='" + userid + "'", conn);  
          cmd.ExecuteNonQuery();  
          conn.Close();  
          gvbind();  */
            //  }
        

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(CS);

            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblId = (Label)row.FindControl("lblId");
            TextBox textUserName = (TextBox)row.Cells[0].Controls[0];
            TextBox textPassword = (TextBox)row.Cells[1].Controls[0];
            TextBox textEmail = (TextBox) row.Cells[2].Controls[0];
            TextBox textName = (TextBox)row.Cells[3].Controls[0];

            GridView1.EditIndex = -1;
            conn.Open();

            SqlCommand cmd = new SqlCommand("update Users set Username='" + textUserName.Text + "',Password='" + textPassword.Text + "',Email='" + textEmail.Text +"',Name='"+ "'where id='" + Id + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }






}