using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace testApplication
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
    public class UserDataAccess
    {
        public static List<Users> GetUsers()
        {
            List<Users> UsersList = new List<Users>();

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from Users", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Users user = new Users();
                    user.Id = Convert.ToInt32(rdr["Id"]);
                    user.Username = rdr["Username"].ToString();
                    user.Password = rdr["Password"].ToString();
                    user.Email = rdr["Email"].ToString();
                    user.Name = rdr["Name"].ToString();

                    UsersList.Add(user);
                }
            }
            return UsersList;
        }

        public static void DeleteUser(int userId)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand
                    ("Delete from Users where Id = @Id", con);
                SqlParameter param = new SqlParameter("@EmployeeId", userId);
                cmd.Parameters.Add(param);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static int UpdateUsers(int userId, string username, string useremail, string password, string name)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string updateQuery = "Update Users SET Username = @Username,  " + 
                    "Password = @Password, Email = @Email, Name = @Name WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(updateQuery, con);

                SqlParameter paramUserId = new  SqlParameter("@Id", userId);
                cmd.Parameters.Add(paramUserId);////////////

                SqlParameter paramUsername = new SqlParameter("@Username", username);
                cmd.Parameters.Add(paramUsername);////////////

                SqlParameter paramPassword = new SqlParameter("@Password", password);
                cmd.Parameters.Add(paramPassword);////////////

                SqlParameter paramEmail = new SqlParameter("@Email", useremail);
                cmd.Parameters.Add(paramEmail);/////////////

                SqlParameter paramName = new SqlParameter("@Name", name);
                cmd.Parameters.Add(paramName);

                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}