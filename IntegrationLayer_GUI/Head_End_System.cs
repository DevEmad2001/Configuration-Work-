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

namespace IntegrationLayer_GUI
{
    public partial class Head_End_System : Form
    {
        public Head_End_System()
        {
            InitializeComponent();
        }

        private void Head_End_System_Load(object sender, EventArgs e) 
        {
            string connectionString = "Data Source=DESKTOP-CE3DCC1;Initial Catalog=AdTech_Db;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Parameter_Name, Parameter_Value FROM Config WHERE ComponentName = '01' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);


            textBox1.Text = table.Rows[0]["Parameter_Value"].ToString();
            textBox2.Text = table.Rows[1]["Parameter_Value"].ToString();
            textBox3.Text = table.Rows[2]["Parameter_Value"].ToString();
            textBox4.Text = table.Rows[3]["Parameter_Value"].ToString();
            textBox5.Text = table.Rows[4]["Parameter_Value"].ToString();
            textBox6.Text = table.Rows[5]["Parameter_Value"].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }
    }
}
