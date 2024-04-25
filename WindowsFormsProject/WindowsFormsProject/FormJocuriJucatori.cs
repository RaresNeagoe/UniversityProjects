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
    public partial class FormJocuriJucatori : Form
    {
        public FormJocuriJucatori()
        {
            InitializeComponent();
            Global global = new Global();
        }

        private void FormJocuriJucatori_Load(object sender, EventArgs e)
        {
            dataGridViewJocuriJucatori.DataSource = Global.ds;
            dataGridViewJocuriJucatori.DataMember = "JocuriJucatori";
            dataGridViewJocuriJucatori.Sort(dataGridViewJocuriJucatori.Columns["IDAsocJ"], ListSortDirection.Ascending);
        }

        private void bAnulare_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["JocuriJucatori"].RejectChanges();
        }

        private void bSalvare_Click(object sender, EventArgs e)
        {
            Global.con.Open();

            SqlTransaction tr = Global.con.BeginTransaction();

            Global.daJocuriJucatori.InsertCommand.Transaction = tr;
            Global.daJocuriJucatori.UpdateCommand.Transaction = tr;
            Global.daJocuriJucatori.DeleteCommand.Transaction = tr;

            DataTable t = Global.ds.Tables["JocuriJucatori"].GetChanges();


            try
            {
                if (t != null)
                {
                    Global.daJocuriJucatori.Update(t);
                    Global.ds.Tables["JocuriJucatori"].AcceptChanges();
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

        private void bNrJucatori_Click(object sender, EventArgs e)
        {
            Global.con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ps_NrJucatori";

            SqlParameter p1 = new SqlParameter();
            p1.Value = cbJocuri.Text;
            p1.ParameterName = "@DenumireJoc";
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@NrJucatori";
            p2.DbType = DbType.Int32;
            p2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p2);

            cmd.ExecuteScalar();

            tbNrJucatori.Text = p2.Value.ToString();

            Global.con.Close();
        }

        private void bCost_Click(object sender, EventArgs e)
        {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Global.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ps_Cost";


                SqlParameter p1 = new SqlParameter();
                p1.Value = cbJucator.Text; 
                p1.ParameterName = "@NumeJucator";
                cmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter();
                p2.ParameterName = "@CostTotal";
                p2.DbType = DbType.Decimal;
                p2.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(p2);

                Global.con.Open();

                cmd.ExecuteScalar();

                tbCost.Text = p2.Value.ToString();

                Global.con.Close();

        }
    }
}
