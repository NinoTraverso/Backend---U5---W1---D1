using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Workforce
{
    public partial class ViewDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (!IsPostBack)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();


                    SqlCommand cmd = new SqlCommand("Select * from Dipendenti;", connection);


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                    DataTable DB = new DataTable();


                    adapter.Fill(DB);


                    GridView1.DataSource = DB;
                    GridView1.DataBind();


                    connection.Close();
                }

                if (!IsPostBack)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();

                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();


                    SqlCommand cmd = new SqlCommand("Select * from Pagamenti;", connection);


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                    DataTable DB = new DataTable();


                    adapter.Fill(DB);


                    GridView2.DataSource = DB;
                    GridView2.DataBind();


                    connection.Close();
                }

              
            }

        }
    }
}