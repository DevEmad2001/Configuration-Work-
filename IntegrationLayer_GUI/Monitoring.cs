using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegrationLayer_GUI
{
    public partial class frm_Monitoring : Form
    {
        public frm_Monitoring()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Monitoring_Load(object sender, EventArgs e)
        {

            //DailyReading dailyform = new DailyReading();
            Head_End_System dailyform = new Head_End_System();

            // Set TopLevel to false so the form behaves like a control
            dailyform.TopLevel = false;

            // Add the form to the panel's controls collection
            panel4.Controls.Add(dailyform);

            // Set the form's parent to the panel
            dailyform.Parent = panel4;

            // Adjust form size to fit within the panel (optional)
            dailyform.Dock = DockStyle.Fill; // Fill the panel with the form

            // Show the embedded form
            dailyform.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Geogrphic_Information_System dailyform = new Geogrphic_Information_System();
            
            // Set TopLevel to false so the form behaves like a control
            dailyform.TopLevel = false;

            panel4.Controls.Clear();
            // Add the form to the panel's controls collection
            panel4.Controls.Add(dailyform);

            // Set the form's parent to the panel
            dailyform.Parent = panel4;

            // Adjust form size to fit within the panel (optional)
            dailyform.Dock = DockStyle.Fill; // Fill the panel with the form

            // Show the embedded form
            dailyform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Head_End_System dailyform = new Head_End_System();

            // Set TopLevel to false so the form behaves like a control
            dailyform.TopLevel = false;
            panel4.Controls.Clear();
            // Add the form to the panel's controls collection
            panel4.Controls.Add(dailyform);

            // Set the form's parent to the panel
            dailyform.Parent = panel4;

            // Adjust form size to fit within the panel (optional)
            dailyform.Dock = DockStyle.Fill; // Fill the panel with the form

            // Show the embedded form
            dailyform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DailyReadingForm3 dailyReadingForm3= new DailyReadingForm3();

            dailyReadingForm3.TopLevel = false;
            panel4.Controls.Clear();
            panel4.Controls.Add(dailyReadingForm3);
            dailyReadingForm3.Parent = panel4;

            dailyReadingForm3.Dock= DockStyle.Fill;
            dailyReadingForm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DailyReadingForm4 dailyReadingForm4 = new DailyReadingForm4();
            dailyReadingForm4.TopLevel = false;
            panel4.Controls.Clear();
            panel4.Controls.Add(dailyReadingForm4);
            dailyReadingForm4.Parent = panel4;
            dailyReadingForm4.Dock= DockStyle.Fill;
            dailyReadingForm4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


            Adtech_Core_Service adtech_core_service = new Adtech_Core_Service();
            adtech_core_service.TopLevel = false;
            panel4.Controls.Clear();
            panel4.Controls.Add(adtech_core_service);
            adtech_core_service.Parent = panel4;
            adtech_core_service.Dock = DockStyle.Fill;
            adtech_core_service.Show();
        }
    }
}
