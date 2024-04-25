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
    public partial class FormChart : Form
    {
        DataTable dt = new DataTable();
        public FormChart()
        {
            InitializeComponent();
            Global global = new Global();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Global.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ps_NrJocuriPerPlatforma";

            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            
            chart1.DataSource = dt;
            chart1.DataBind();


            Global.con.Open();
            Global.con.Close();
        }
    }
}
