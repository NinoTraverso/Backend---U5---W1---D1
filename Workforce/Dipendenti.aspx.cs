using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Workforce
{
    public partial class Dipendenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "insert into Dipendenti values(@Nome, @Cognome, @Indirizzo, @CodiceFiscale, @Sposato, @NumeroFigli, @Lavoro)";
                cmd.Parameters.AddWithValue("Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("Cognome", txtCognome.Text);
                cmd.Parameters.AddWithValue("Indirizzo", txtIndirizzo.Text);
                cmd.Parameters.AddWithValue("CodiceFiscale", txtCodiceFiscale.Text);
                cmd.Parameters.AddWithValue("Sposato", CheckBox1.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("NumeroFigli", Convert.ToInt32(TextNumeroFigli.Text));
                cmd.Parameters.AddWithValue("Lavoro", TextLavoro.Text);


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