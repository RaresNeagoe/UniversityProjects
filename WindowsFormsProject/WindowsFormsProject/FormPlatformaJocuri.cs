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
    public partial class FormPlatformaJocuri : Form
    {
        public FormPlatformaJocuri()
        {
            InitializeComponent();
            Global global = new Global();
        }

        private void FormPlatformaJocuri_Load(object sender, EventArgs e)
        {
            dataGridViewPlatformaJocuri.DataSource = Global.ds;
            dataGridViewPlatformaJocuri.DataMember = "PlatformaJocuri";
            dataGridViewPlatformaJocuri.Sort(dataGridViewPlatformaJocuri.Columns["IDAsocP"], ListSortDirection.Ascending);
        }

        private void bAnulare_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["PlatformaJocuri"].RejectChanges();
        }

        private void bSalvare_Click(object sender, EventArgs e)
        {
            Global.con.Open();

            SqlTransaction tr = Global.con.BeginTransaction();

            Global.daPlatformaJocuri.InsertCommand.Transaction = tr;
            Global.daPlatformaJocuri.UpdateCommand.Transaction = tr;
            Global.daPlatformaJocuri.DeleteCommand.Transaction = tr;

            DataTable t = Global.ds.Tables["PlatformaJocuri"].GetChanges();


            try
            {
                if (t != null)
                {
                    Global.daPlatformaJocuri.Update(t);
                    Global.ds.Tables["PlatformaJocuri"].AcceptChanges();
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

        private void bNrJocuri_Click(object sender, EventArgs e)
        {
                Global.con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Global.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ps_NrJocuri";

                SqlParameter p1 = new SqlParameter();
                p1.Value = cbPlatforme.Text;
                p1.ParameterName = "@DenumirePlatforma";
                cmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter();
                p2.ParameterName = "@NrJocuri";
                p2.DbType = DbType.Int32;
                p2.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(p2);
                
                cmd.ExecuteScalar();

                tbNrJocuri.Text = p2.Value.ToString();

                Global.con.Close();

        }
    }
}
