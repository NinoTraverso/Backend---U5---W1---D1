using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Workforce
{
    public partial class Pagamenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "insert into Pagamenti values(@DataPagamento, @Stipendio, @Anticipo, @DipendenteID)";
                cmd.Parameters.AddWithValue("DataPagamento", txtDataPagamento.Text);
                /*https://stackoverflow.com/questions/55260242/how-to-insert-decimal-value-from-textbox-into-database-with-c-sharp */
                cmd.Parameters.AddWithValue("Stipendio", SqlDbType.Decimal).Value = Convert.ToDecimal(txtStipendio.Text, CultureInfo.CurrentCulture);
                cmd.Parameters.AddWithValue("Anticipo", SqlDbType.Decimal).Value = Convert.ToDecimal(txtAnticipo.Text, CultureInfo.CurrentCulture);
                cmd.Parameters.AddWithValue("DipendenteID", Convert.ToInt32(txtDipendenteID.Text));



                int insertedSuccessfully = cmd.ExecuteNonQuery();

                if (insertedSuccessfully > 0)
                {
                    Response.Write("You've inserted the data successfully");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }

            finally { conn.Close(); }

        }
    }
}