using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectNeagoeRares
{
    public partial class FormDezvoltatori : Form
    {
        public FormDezvoltatori()
        {
            InitializeComponent();
            Global global = new Global();
        }

        private void FormDezvoltatori_Load(object sender, EventArgs e)
        {
            dataGridViewDezvoltatori.DataSource = Global.ds;
            dataGridViewDezvoltatori.DataMember = "Dezvoltatori";
            dataGridViewDezvoltatori.Sort(dataGridViewDezvoltatori.Columns["IDDezvoltator"], ListSortDirection.Ascending);
        }

        private void bAnulare_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["Dezvoltatori"].RejectChanges();
        }

        private void bSalvare_Click(object sender, EventArgs e)
        {
            Global.con.Open();

            SqlTransaction tr = Global.con.BeginTransaction();

            Global.daDezvoltatori.InsertCommand.Transaction = tr;
            Global.daDezvoltatori.UpdateCommand.Transaction = tr;
            Global.daDezvoltatori.DeleteCommand.Transaction = tr;

            

            DataTable t = Global.ds.Tables["Dezvoltatori"].GetChanges();
            

            try
            {
                if (t != null)
                {
                    Global.daDezvoltatori.Update(t);
                    Global.ds.Tables["Dezvoltatori"].AcceptChanges();
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
