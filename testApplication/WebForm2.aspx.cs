using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace testApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if(username.Text != "" && name.Text != "" && password.Text != "" &&email.Text != "")
            {
                if (password.Text == confirm.Text)
                {
                    string DCS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                    using (SqlConnection conn = new SqlConnection(DCS))
                    {
                        SqlCommand command = new SqlCommand("insert into Users values('" + username.Text + "','" + password.Text + "','" + email.Text + "','" + name.Text + "')", conn);

                        conn.Open();
                        command.ExecuteNonQuery();

                        lblMessage.Text = "Successfull";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        Response.Redirect("~/WebForm1.aspx");

                    }
                }
                else
                {
                    lblMessage.Text = "Password do not match";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblMessage.Text = "information is required in all fields";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }




        }
    }
}