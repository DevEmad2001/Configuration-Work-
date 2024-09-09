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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialMessageTreeView();



        }


        private void InitialMessageTreeView()
        {

            TreeNode rootNode = new TreeNode("Tasks");

            // Create and add child nodes
            TreeNode startNode = new TreeNode("Get Start");
            TreeNode publisherNode = new TreeNode("Publisher & Subscriber");
            TreeNode pubNode = new TreeNode("Topics");
            TreeNode subNode = new TreeNode("Publisher");
            TreeNode topicsNode = new TreeNode("Subscriber");

            // Add child nodes to their respective parent nodes
            rootNode.Nodes.AddRange(new[] { startNode });
            publisherNode.Nodes.AddRange(new[] { pubNode, subNode, topicsNode });

            // Add the root node to the TreeView
            treeView1.Nodes.Add(rootNode);
            treeView1.Nodes.Add(publisherNode);

            // Expand all nodes
            treeView1.ExpandAll();

        }
        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();

            label1.Text = "Messaging";
            button6.BackColor = Color.Blue;

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;


            InitialMessageTreeView();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();

            label1.Text = "Adaptors";
            button5.BackColor = Color.Blue;

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            label1.Text = "Management";

            button4.BackColor = Color.Blue;

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();

            label1.Text = "Monitoring";

            button3.BackColor = Color.Blue;

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();

            label1.Text = "Deployment";

            button2.BackColor = Color.Blue;

            button1.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            label1.Text = "Settings";
            button1.BackColor = Color.Blue;

            button6.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;

         
        }
    }
}
