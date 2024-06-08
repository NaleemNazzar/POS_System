using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Reflection;
using System.IO;

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
                USER = dt.Rows[0]["uName"].ToString();

                Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                byte[] imageByteArry = imageArray;
                IMG = Image.FromStream(new MemoryStream(imageArray));
            }
            return isValid;
        }
        public static void StopBuffering(Panel ctr, bool doubleBuffer)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctr, new object[] { doubleBuffer });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Create property for username

        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        //for user image
        public static Image img;

        public static Image IMG
        {
            get { return img; }
            private set { img = value; }
        }


        //Method for curd Operation

        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }
        //For Loading data from database
    }
}

