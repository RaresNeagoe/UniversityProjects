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
    public partial class FormExportXML : Form
    {
        public FormExportXML()
        {
            InitializeComponent();
        }

        private void FormExportXML_Load(object sender, EventArgs e)
        {
            dataGridViewExport.DataSource = Global.ds;
            dataGridViewExport.DataMember = "Jocuri";
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["Jocuri"].WriteXml(@"C:\INFORMATICA II\Baze de date\Neagoe Rares\2023.11.23\WindowsFormsXML\Jocuri.XML");
        }
    }
}
