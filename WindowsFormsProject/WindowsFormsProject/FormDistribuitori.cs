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
    public partial class FormDistribuitori : Form
    {
        public FormDistribuitori()
        {
            InitializeComponent();
            Global global = new Global();
        }

        private void FormDistribuitori_Load(object sender, EventArgs e)
        {
            dataGridViewDistribuitori.DataSource = Global.ds;
            dataGridViewDistribuitori.DataMember = "Distribuitori";
            dataGridViewDistribuitori.Sort(dataGridViewDistribuitori.Columns["IDDistribuitor"], ListSortDirection.Ascending);
        }

        private void bAnulare_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["Distribuitori"].RejectChanges();
        }

        private void bSalvare_Click(object sender, EventArgs e)
        {
            Global.con.Open();

            SqlTransaction tr = Global.con.BeginTransaction();

            Global.daDistribuitori.InsertCommand.Transaction = tr;
            Global.daDistribuitori.UpdateCommand.Transaction = tr;
            Global.daDistribuitori.DeleteCommand.Transaction = tr;

            DataTable t = Global.ds.Tables["Distribuitori"].GetChanges();


            try
            {
                if (t != null)
                {
                    Global.daDistribuitori.Update(t);
                    Global.ds.Tables["Distribuitori"].AcceptChanges();
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
