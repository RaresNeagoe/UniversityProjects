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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dezvoltatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDezvoltatori form = new FormDezvoltatori();
            form.ShowDialog();
        }

        private void distribuitoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDistribuitori form = new FormDistribuitori();
            form.ShowDialog();
        }

        private void jocuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJocuri form = new FormJocuri();
            form.ShowDialog();
        }

        private void jucatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJucatori form = new FormJucatori();
            form.ShowDialog();
        }

        private void platformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlatforme form = new FormPlatforme();
            form.ShowDialog();
        }

        private void platformaJocuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlatformaJocuri form = new FormPlatformaJocuri(); 
            form.ShowDialog();
        }

        private void jocuriJucatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJocuriJucatori form = new FormJocuriJucatori();
            form.ShowDialog();
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChart form = new FormChart();
            form.ShowDialog();
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExportXML form = new FormExportXML();
            form.ShowDialog();
        }

        private void importXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImportXML form = new FormImportXML();
            form.ShowDialog();
        }

        private void vizualizareDocumenteXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVizualizareDocumenteXML form = new FormVizualizareDocumenteXML();
            form.ShowDialog();
        }
    }
}
