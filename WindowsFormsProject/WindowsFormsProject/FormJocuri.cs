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
    public partial class FormJocuri : Form
    {
        public FormJocuri()
        {
            InitializeComponent();
            Global global = new Global();
        }

        private void FormJocuri_Load(object sender, EventArgs e)
        {
            dataGridViewJocuri.DataSource = Global.ds;
            dataGridViewJocuri.DataMember = "Jocuri";
            dataGridViewJocuri.Sort(dataGridViewJocuri.Columns["IDJoc"], ListSortDirection.Ascending);
        }

        private void bAnulare_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["Jocuri"].RejectChanges();
        }

        private void bSalvare_Click(object sender, EventArgs e)
        {
            Global.con.Open();

            SqlTransaction tr = Global.con.BeginTransaction();

            Global.daJocuri.InsertCommand.Transaction = tr;
            Global.daJocuri.UpdateCommand.Transaction = tr;
            Global.daJocuri.DeleteCommand.Transaction = tr;

            DataTable t = Global.ds.Tables["Jocuri"].GetChanges();


            try
            {
                if (t != null)
                {
                    Global.daJocuri.Update(t);
                    Global.ds.Tables["Jocuri"].AcceptChanges();
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

        private void bFiltrare_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(Global.ds.Tables["Jocuri"], $"{cbCategorie.Text} {cbOperator.Text} '{tbValoare.Text}'", null, DataViewRowState.CurrentRows);

            dataGridViewJocuri.DataSource = dv;
        }

        private void bMedie_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Global.con;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "ps_Medie";

            SqlParameter p = new SqlParameter();
            p.ParameterName = "@Medie";
            p.DbType = DbType.Int32;
            p.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p);

            Global.con.Open();
            cmd.ExecuteScalar();

            tbMedie.Text = p.Value.ToString();

            Global.con.Close();
        }
    }
}
