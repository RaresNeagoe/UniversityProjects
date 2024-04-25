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
    public partial class FormPlatforme : Form
    {
        public FormPlatforme()
        {
            InitializeComponent();
            Global global = new Global();
        }

        private void FormPlatforme_Load(object sender, EventArgs e)
        {
            dataGridViewPlatforme.DataSource = Global.ds;
            dataGridViewPlatforme.DataMember = "Platforme";
            dataGridViewPlatforme.Sort(dataGridViewPlatforme.Columns["IDPlatforma"], ListSortDirection.Ascending);
        }

        private void bAnulare_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["Platforme"].RejectChanges();
        }

        private void bSalvare_Click(object sender, EventArgs e)
        {
            Global.con.Open();

            SqlTransaction tr = Global.con.BeginTransaction();

            Global.daPlatforme.InsertCommand.Transaction = tr;
            Global.daPlatforme.UpdateCommand.Transaction = tr;
            Global.daPlatforme.DeleteCommand.Transaction = tr;

            DataTable t = Global.ds.Tables["Platforme"].GetChanges();


            try
            {
                if (t != null)
                {
                    Global.daPlatforme.Update(t);
                    Global.ds.Tables["Platforme"].AcceptChanges();
                    tr.Commit();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Salvare anulata\n" + ex);
                tr.Rollback();
            }
            finally
            {
                Global.con.Close();
            }
        }
    }
}
