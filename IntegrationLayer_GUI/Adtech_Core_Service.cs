using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace IntegrationLayer_GUI
{
    public partial class Adtech_Core_Service : Form
    {
        public Adtech_Core_Service()
        {
            InitializeComponent();
        }

        private void Adtech_Core_Service_Load(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-CE3DCC1;Initial Catalog=AdTech_Db;Integrated Security=True;";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cnn = new SqlCommand("select Parameter_Name, Parameter_Value from Config where ComponentName = '01' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            //dataGridView1.DataSource = table;

            textBox1.Text = table.Rows[0][1].ToString();
            textBox2.Text = table.Rows[1][1].ToString();
            //textBox3.Text = table.Rows[2][1].ToString();
            textBox4.Text = table.Rows[3][1].ToString();
            textBox5.Text = table.Rows[4][1].ToString();
            textBox6.Text = table.Rows[5][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string connectionString = "Data Source=DESKTOP-CE3DCC1;Initial Catalog=AdTech_Db;Integrated Security=True;";
            //"Data Source=YourDataSource;Initial Catalog=YourDatabase;User ID=YourUsername;Password=YourPassword";

            // Dictionary to hold the parameter name and the new value to update
            Dictionary<string, string> parametersToUpdate = new Dictionary<string, string>
            {
                { "ServiceURL", textBox1.Text },
                { "binding",  textBox2.Text},
               // { "authentication",  textBox3.Text },
                { "protocol",  textBox4.Text },
                { "DBlink", textBox5.Text },
                { "LogfilePath", textBox6.Text }
            };

            try
            {
                // Create and open a connection to SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Loop through the parameters to update each one
                    foreach (var param in parametersToUpdate)
                    {
                        string updateQuery = @"
                            UPDATE Config
                            SET Parameter_Value = @NewValue, Modifies_Date = @CurrentDate
                            WHERE ComponentName = '01' AND Parameter_Name = @ParameterName";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Set the new values for each parameter
                            command.Parameters.AddWithValue("@NewValue", param.Value);
                            command.Parameters.AddWithValue("@ParameterName", param.Key);
                            command.Parameters.AddWithValue("@CurrentDate", DateTime.Now); // Update the date to the current time

                            // Execute the update query
                            int rowsAffected = command.ExecuteNonQuery();
                            //Console.WriteLine($"Updated {rowsAffected} row(s) for Parameter: {param.Key}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display any errors
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            MessageBox.Show("Update process was succeded");
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
