using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IntegrationLayer_GUI
{
    public partial class MappingForm : Form
    {


        private XmlSchemaSet schemaSet1;
        private XmlSchemaSet schemaSet2;
        private XmlDocument xmlDocument1;
        private XmlDocument xmlDocument2;
        private Dictionary<TreeNode, XmlElement> mappingDictionary;

        public MappingForm()
        {
            InitializeComponent();
            InitializeComponents();
        }
        private void MappingForm_Load(object sender, EventArgs e)
        {

        }


        private void InitializeComponents()
        {

            schemaSet1 = new XmlSchemaSet();
            schemaSet2 = new XmlSchemaSet();

            // Load XSD files
            LoadXsd(@"C:\Adtech\Schema\MeterReadingResultDocument.xsd", schemaSet1);
            LoadXsd(@"C:\Adtech\Schema\MeterReadingResultDocument.xsd", schemaSet2);

            // Populate DataGridViews based on XSD
            PopulateDataGridView(dataGridView1, schemaSet1);
            PopulateDataGridView(dataGridView2, schemaSet2);

        }
        private void LoadXsd(string filePath, XmlSchemaSet schemaSet)
        {
            try
            {
                var schema = XmlSchema.Read(new System.IO.StreamReader(filePath), null);
                schemaSet.Add(schema);
            }
            catch (XmlSchemaException ex)
            {
                MessageBox.Show($"Error loading XSD file '{filePath}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDataGridView(DataGridView dataGridView, XmlSchemaSet schemaSet)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("Element", typeof(string));
            dataTable.Columns.Add("Attribute", typeof(string));

            foreach (XmlSchemaElement element in schemaSet.GlobalElements.Values)
            {
                if (element.ElementSchemaType is XmlSchemaComplexType complexType)
                {
                    foreach (var attribute in GetAttributes(complexType))
                    {
                        dataTable.Rows.Add(element.Name, attribute);
                    }
                }
            }

            dataGridView.DataSource = dataTable;
        }

        private IEnumerable<string> GetAttributes(XmlSchemaType schemaType)
        {
            //return schemaType.UnhandledAttributes.OfType<XmlSchemaAttribute>().Select(attr => attr.Name);
            return schemaType.UnhandledAttributes
                .OfType<XmlSchemaAttribute>()
                .Select(attr => attr.Name)
                .ToArray();
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            // Implement mapping logic based on DataGridViews
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Attribute"].Value != null)
                {
                    string sourceAttribute = row.Cells["Attribute"].Value.ToString();
                    string sourceElement = row.Cells["Element"].Value.ToString();

                    // Assuming a similar structure in dataGridView2
                    var matchingRow = dataGridView2.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(r => r.Cells["Element"].Value.ToString() == sourceElement);

                    if (matchingRow != null)
                    {
                        matchingRow.Cells["Attribute"].Value = sourceAttribute;
                    }
                }
            }
        }



    }
}
