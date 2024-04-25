using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;

namespace ProiectNeagoeRares
{
    public class Global
    {
        public static string strConectare = ConfigurationManager.AppSettings["stringConectare"];
        public static SqlConnection con;
        public static SqlDataAdapter daDezvoltatori;
        public static SqlDataAdapter daDistribuitori;
        public static SqlDataAdapter daJocuri;
        public static SqlDataAdapter daJucatori;
        public static SqlDataAdapter daJocuriJucatori;
        public static SqlDataAdapter daPlatforme;
        public static SqlDataAdapter daPlatformaJocuri;
        public static DataSet ds;
        public Global()
        {
            con = new SqlConnection(strConectare);
            ds = new DataSet();

            daDezvoltatori = new SqlDataAdapter("select * from tDezvoltatori", con);
            daDezvoltatori.Fill(ds, "Dezvoltatori");

            SqlCommandBuilder cb = new SqlCommandBuilder(daDezvoltatori);

            daDezvoltatori.InsertCommand = cb.GetInsertCommand();
            daDezvoltatori.DeleteCommand = cb.GetDeleteCommand();
            daDezvoltatori.UpdateCommand = cb.GetUpdateCommand();


            daDistribuitori = new SqlDataAdapter("select * from tDistribuitori", con);
            daDistribuitori.Fill(ds, "Distribuitori");

            SqlCommandBuilder cb1 = new SqlCommandBuilder(daDistribuitori);

            daDistribuitori.InsertCommand = cb1.GetInsertCommand();
            daDistribuitori.DeleteCommand = cb1.GetDeleteCommand();
            daDistribuitori.UpdateCommand = cb1.GetUpdateCommand();


            daJocuri = new SqlDataAdapter("select * from tJocuri", con);
            daJocuri.Fill(ds, "Jocuri");

            SqlCommandBuilder cb2 = new SqlCommandBuilder(daJocuri);

            daJocuri.InsertCommand = cb2.GetInsertCommand();
            daJocuri.DeleteCommand = cb2.GetDeleteCommand();
            daJocuri.UpdateCommand = cb2.GetUpdateCommand();


            daJucatori = new SqlDataAdapter("select * from tJucatori", con);
            daJucatori.Fill(ds, "Jucatori");

            SqlCommandBuilder cb3 = new SqlCommandBuilder(daJucatori);

            daJucatori.InsertCommand = cb3.GetInsertCommand();
            daJucatori.DeleteCommand = cb3.GetDeleteCommand();
            daJucatori.UpdateCommand = cb3.GetUpdateCommand();

            daPlatforme = new SqlDataAdapter("select * from tPlatforme", con);
            daPlatforme.Fill(ds, "Platforme");

            SqlCommandBuilder cb4 = new SqlCommandBuilder(daPlatforme);

            daPlatforme.InsertCommand = cb4.GetInsertCommand();
            daPlatforme.DeleteCommand = cb4.GetDeleteCommand();
            daPlatforme.UpdateCommand = cb4.GetUpdateCommand();

            daJocuriJucatori = new SqlDataAdapter("select * from tJocuriJucatori", con);
            daJocuriJucatori.Fill(ds, "JocuriJucatori");

            SqlCommandBuilder cb5 = new SqlCommandBuilder(daJocuriJucatori);

            daJocuriJucatori.InsertCommand = cb5.GetInsertCommand();
            daJocuriJucatori.DeleteCommand = cb5.GetDeleteCommand();
            daJocuriJucatori.UpdateCommand = cb5.GetUpdateCommand();

            daPlatformaJocuri = new SqlDataAdapter("select * from tPlatformaJocuri", con);
            daPlatformaJocuri.Fill(ds, "PlatformaJocuri");

            SqlCommandBuilder cb6 = new SqlCommandBuilder(daPlatformaJocuri);

            daPlatformaJocuri.InsertCommand = cb6.GetInsertCommand();
            daPlatformaJocuri.DeleteCommand = cb6.GetDeleteCommand();
            daPlatformaJocuri.UpdateCommand = cb6.GetUpdateCommand();
        }
    }
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
