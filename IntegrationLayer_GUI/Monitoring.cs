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
            TabForm dailyform = new TabForm();

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

            DailyReading dailyform = new DailyReading();
            
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
            TabForm dailyform = new TabForm();

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
    }
}
