using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialEstimate
{
    public partial class MainMdiFrm : Form
    {
        //public static string DataPathF = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\MyHomeMaterial\\HomeDB.accdb;Persist Security Info=False";

        public static string DataPathF = Environment.CurrentDirectory;
        string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\DataBase\\HomeDB.accdb;Persist Security Info=False";


        public static bool HmPage,MatPage;
        public static HomeFrm Hmfrm = null;
        public static MatDetlFrm matFrm = null;
        
        private void HomePage_Click(object sender, EventArgs e)
        {
            if (HmPage == false)
            {
                Hmfrm = new HomeFrm();
                Hmfrm.MdiParent = this;
                Hmfrm.Show();
                HmPage = true;
            }
        }

        public MainMdiFrm()
        {
            InitializeComponent();
        }

        private void MainMdiFrm_Load(object sender, EventArgs e)
        {
            HmPage = false;
            MatPage = false;
            if (HmPage == false)
            {
                Hmfrm = new HomeFrm();
                Hmfrm.MdiParent = this;
                Hmfrm.Show();
                HmPage = true;
            }

        }

        private void NewMenu_Click(object sender, EventArgs e)
        {
            try
            {
                int rv;
                string Tab_Name = "";
                string Qry = "Select *form  Column_Tab";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();

                for (int i = 0; i < 7; i++)
                {
                    if (i == 0)
                        Tab_Name = "Column_Tab";
                    else if (i == 1)
                        Tab_Name = "Beam_Tab";
                    else if (i == 2)
                        Tab_Name = "Wall_Tab";
                    else if (i == 3)
                        Tab_Name = "Wall_Beam";
                    else if (i == 4)
                        Tab_Name = "Window_Tab";
                    else if (i == 5)
                        Tab_Name = "Base_Tab";
                    else if (i == 6)
                        Tab_Name = "Roof_Tab";
                    else
                        Tab_Name = "Column_Tab";

                    Qry = "delete from " + Tab_Name;
                    cmd.CommandText = Qry;
                    rv = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can\'t clean for new data...\n"+ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void MainMdiFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Information", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MatDetMenu_Click(object sender, EventArgs e)
        {
            if (MatPage == false)
            {
                matFrm = new MatDetlFrm();
                matFrm.MdiParent = this;
                matFrm.Show();
                MatPage = true;
            }
        }
    }
}
