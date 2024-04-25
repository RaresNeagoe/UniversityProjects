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

namespace ProiectNeagoeRares
{
    public partial class FormVizualizareDocumenteXML : Form
    {
        static string strCon = "Data source= virtualdb1; Initial Catalog = dbDocumenteXML231; user id = student; password=Student_2023";
        SqlConnection con2 = null;

        DataSet ds2;
        SqlDataAdapter daXML = null;

        DataView dv;
        DataView dv2;
        public FormVizualizareDocumenteXML()
        {
            InitializeComponent();
        }

        private void FormVizualizareDocumenteXML_Load(object sender, EventArgs e)
        {
            con2 = new SqlConnection(strCon);
            ds2 = new DataSet();
            daXML = new SqlDataAdapter("select * from tDocumenteXML", con2);
            daXML.Fill(ds2, "DocumenteXML");

            dv = new DataView(ds2.Tables["DocumenteXML"]);
            dv2 = new DataView(ds2.Tables["DocumenteXML"]);

            dv.Sort = "Cale_Document";
            cbXML.DataSource = dv;

            cbXML.DisplayMember = "Cale_Document";
            cbXML.ValueMember = "Id_Document";
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            string idDocument = cbXML.SelectedValue.ToString();
            string filePath;
            DataSet dsw = new DataSet();
            dv2.RowFilter = "Id_Document='" + idDocument + "'";

            DataRowView r = dv2[0];
            filePath = r["Cale_Document"].ToString();
            dsw.ReadXml(filePath);

            dataGridViewVizualizare.DataSource = dsw.Tables[0];

            MessageBox.Show(dsw.Tables[0].TableName);
        }
    }
}
