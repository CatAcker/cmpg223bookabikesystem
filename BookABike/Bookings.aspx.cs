using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BookABike
{
    public partial class Bookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Label2.Text = "" + Session["username"];

                string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";
                string sql_All = "SELECT * FROM BookingsTable where username = '" + Label2.Text + "'";

                SqlConnection conn = new SqlConnection(constr);
                conn.Open();

                SqlCommand comm = new SqlCommand(sql_All, conn);

                DataSet ds = new DataSet();

                SqlDataAdapter adap = new SqlDataAdapter();

                adap.SelectCommand = comm;
                adap.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();

                conn.Close();
            }
            else
            {
                Response.Redirect("Main.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NWU\2019\Semester 1\CMPG212\Projek\BookABike\BookABike\App_Data\UsersDB.mdf;Integrated Security=True";
                string sql_All = "SELECT * FROM BookingsTable WHERE username = '" + Label2.Text + "' AND cost >= '" + TextBox1.Text + "' AND cost <= '" + TextBox2.Text + "'";

                SqlConnection conn = new SqlConnection(constr);
                conn.Open();

                SqlCommand comm = new SqlCommand(sql_All, conn);

                DataSet ds = new DataSet();

                SqlDataAdapter adap = new SqlDataAdapter();

                adap.SelectCommand = comm;
                adap.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();

                conn.Close();
            }
            catch
            {

            }
        }
    }
}