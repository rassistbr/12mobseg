using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _12mob
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttonlogin_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["azuresqldb"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);

            SqlCommand com = new SqlCommand("SELECT * FROM registrationtab WHERE username = '"
                                            + TextBoxusername.Text
                                            + "' AND password = '"
                                            + TextBoxpassword.Text + "'", con);

            //SqlCommand com = new SqlCommand("SELECT * FROM registrationtab WHERE username = @user AND password = @password", con);
            //com.Parameters.AddWithValue("@user", TextBoxusername.Text);
            //com.Parameters.AddWithValue("@password", TextBoxpassword.Text);

            con.Open();
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                Labelinfo.Text = "Login successful.";
            }

            else
            {
                Labelinfo.Text = "Invalid username or password.";

            }
        }
    }
}