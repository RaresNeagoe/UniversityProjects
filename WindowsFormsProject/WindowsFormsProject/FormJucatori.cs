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
    public partial class FormJucatori : Form
    {
        public FormJucatori()
        {
            InitializeComponent();
            Global global = new Global();
        }

        private void FormJucatori_Load(object sender, EventArgs e)
        {
            dataGridViewJucatori.DataSource = Global.ds;
            dataGridViewJucatori.DataMember = "Jucatori";
            dataGridViewJucatori.Sort(dataGridViewJucatori.Columns["IDJucator"], ListSortDirection.Ascending);
        }

        private void bAnulare_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["Jucatori"].RejectChanges();
        }

        private void bSalvare_Click(object sender, EventArgs e)
        {
            Global.con.Open();

            SqlTransaction tr = Global.con.BeginTransaction();

            Global.daJucatori.InsertCommand.Transaction = tr;
            Global.daJucatori.UpdateCommand.Transaction = tr;
            Global.daJucatori.DeleteCommand.Transaction = tr;

            DataTable t = Global.ds.Tables["Jucatori"].GetChanges();


            try
            {
                if (t != null)
                {
                    Global.daJucatori.Update(t);
                    Global.ds.Tables["Jucatori"].AcceptChanges();
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
