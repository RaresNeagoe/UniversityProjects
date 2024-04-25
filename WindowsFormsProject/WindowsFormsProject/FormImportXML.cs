using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectNeagoeRares
{
    public partial class FormImportXML : Form
    {
        public FormImportXML()
        {
            InitializeComponent();
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            DataSet dsXML = new DataSet();
            string filePath = @"C:\INFORMATICA II\Baze de date\Neagoe Rares\2023.11.23\WindowsFormsXML\Jocuri.XML";
            dsXML.ReadXml(filePath);
            dataGridViewImport.DataSource = dsXML;
            dataGridViewImport.DataMember = "Jocuri";
        }
    }
}
