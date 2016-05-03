using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SlaktData.Models
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string levNmr { get; set; }
        public string ssrsURL { get; set; }

        public static User CheckUser(User u)
        {
            User toreturn;
            string SQL = "SELECT * FROM [dbo].[users-table] where username='" + u.userName + "';";
            string _connectionString = DataSource.GetConnectionString("slaktData");
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand(SQL, con);
            try
            {
                con.Open();
                SqlDataReader dar = cmd.ExecuteReader();
                if (dar.HasRows)
                {
                    User newUser = new User();
                    while (dar.Read())
                    {
                        newUser.userName = dar["username"].ToString();
                        newUser.password = dar["userPass"].ToString();
                        newUser.levNmr = dar["userPass"].ToString();
                        newUser.ssrsURL = dar["userPass"].ToString();
                        newUser.userId = Convert.ToInt32(dar["userId"]);
                    }
                    toreturn = newUser;
                }
                else
                    toreturn = null;
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                con.Close();
            }
            return toreturn;
        }
    }


}