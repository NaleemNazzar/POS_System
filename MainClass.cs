using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    class MainClass
    {
        public static readonly string con_string = "Data Source=DESKTOP-F0KSCG6\\SQLEXPRESS; Initial Catalog=RM;Integrated Security=True;";
        public static SqlConnection con = new SqlConnection(con_string);


        //Method to check user validation
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;
            string qry = @"Select * From users where username = '" + user + "' and upass ='" + pass + "' ";

            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                    //user = dt.Rows[0]["uName"].ToString();
                }
                return isValid;
            }

            
        }
    }

