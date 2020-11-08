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
    public partial class MatStimFrm : Form
    {
        //string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\MyHomeMaterial\\HomeDB.accdb;Persist Security Info=False";
        string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\DataBase\\HomeDB.accdb;Persist Security Info=False";

        float Brk_len, Brk_brd, Brk_thick, CmRdLen, CmRdThick, RgRdLen, RgRdThick, StnVl, SndVl, CmtVl;


        public MatStimFrm()
        {
            InitializeComponent();
        }

        private void MatStimFrm_Load(object sender, EventArgs e)
        {
            cmbCntrlType.Text = "Column";
        }

        private void cmbCntrlType_TextChanged(object sender, EventArgs e)
        {
            cmbCntrlName.Items.Clear();
            WallCmpBox.Visible = false;
            if(cmbCntrlType.Text == "Column")
            {
                LoadColumn();
            }
            else if (cmbCntrlType.Text == "Beam")
            {
                LoadBeam();
            }
            else if (cmbCntrlType.Text == "Wall")
            {
                LoadWall();
                WallCmpBox.Visible = true;
            }
            else if (cmbCntrlType.Text == "Window")
            {
                LoadWindow();
            }
            else if (cmbCntrlType.Text == "Door")
            {
                LoadDoor();
            }
            else if (cmbCntrlType.Text == "Base")
            {
                LoadBase();
            }
            else if (cmbCntrlType.Text == "Roof")
            {
                LoadRoof();
            }
            else
            {
                ;
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            string qry="select * from Clm_Name;";
            string qr2 = "select * form Clm_Name;";

            TotMatBox.Visible = false;
            if (cmbCntrlType.Text == "Column")
            {
                if (rbAll.Checked == true)
                {
                    qry = "select Clm_Name as [Column name],Clm_Mat_Sand as [Sand(in cb ft)], Clm_Mat_Stone  as [Stone(in cb ft)],";
                    qry = qry + "Clm_Mat_Cement as [Cement(in cb ft)],Clm_Mat_NRod as [Rods(in ft)],Clm_Mat_RRod as [Ring Rods(in ft)]";
                    qry = qry + " from Column_Tab;";

                    qr2 = "select sum(Clm_Mat_Sand),sum( Clm_Mat_Stone),sum(Clm_Mat_Cement),sum(Clm_Mat_NRod),sum(Clm_Mat_RRod) from Column_Tab;";
                    ShowTotMaterial(qr2);
                }
                else
                {
                    qry = "select Clm_Name as [Column name],Clm_Mat_Sand as [Sand(cb ft)], Clm_Mat_Stone  as [Stone(cb ft)],";
                    qry = qry + "Clm_Mat_Cement as [Cement(cb ft)],Clm_Mat_NRod as [Rods(ft)],Clm_Mat_RRod as [Ring Rods(ft)]";
                    qry = qry + " from Column_Tab where Clm_Name ='" + cmbCntrlName.Text + "';";
                }

            }
            else if (cmbCntrlType.Text == "Beam")
            {
                if (rbAll.Checked == true)
                {
                    qry = "select Bm_Name as [Beam name],Bm_Mat_Sand as [Sand(cb ft)], Bm_Mat_Stone  as [Stone(cb ft)],";
                    qry = qry + "Bm_Mat_Cement as [Cement(cb ft)],Bm_Mat_NRod as [Rods(ft)],Bm_Mat_RRod as [Ring Rods(ft)]";
                    qry = qry + "from Beam_Tab;";

                    qr2 = "select sum(Bm_Mat_Sand),sum( Bm_Mat_Stone),sum(Bm_Mat_Cement),sum(Bm_Mat_NRod),sum(Bm_Mat_RRod) from Beam_Tab;";
                    ShowTotMaterial(qr2);
                }
                else
                {
                    qry = "select Bm_Name as [Beam name],Bm_Mat_Sand as [Sand(cb ft)], Bm_Mat_Stone  as [Stone(cb ft)],";
                    qry = qry + "Bm_Mat_Cement as [Cement(cb ft)],Bm_Mat_NRod as [Rods(ft)],Bm_Mat_RRod as [Ring Rods(ft)]";
                    qry = qry + "from Beam_Tab where Bm_Name ='" + cmbCntrlName.Text + "';";
                }

            }
            else if (cmbCntrlType.Text == "Wall")
            {
                if (rbAll.Checked == true)
                {
                    qry = "select Wl_Name as [Wall name],Wl_Mat_Sand as [Sand(cb ft)], Wl_Mat_Cement as [Cement(cb ft)],";
                    qry = qry + "Wl_Mat_Bricks as [Total Bricks] from Wall_Tab;";

                    qr2 = "select sum(Wl_Mat_Sand),sum(Wl_Mat_Cement) from Wall_Tab;";
                    ShowTotMaterial(qr2);
                }
                else
                {
                    qry = "select Wl_Name as [Wall name],Wl_Mat_Sand as [Sand(cb ft)], Wl_Mat_Cement as [Cement(cb ft)],";
                    qry = qry + "Wl_Mat_Bricks as [Total Bricks] from Wall_Tab where Wl_Name ='" + cmbCntrlName.Text + "';";
                }

            }
            else if (cmbCntrlType.Text == "Window")
            {
                if (rbAll.Checked == true)
                {
                    qry = "select Win_Name as [Window name],Win_Height as [Window Height(ft)], Win_Length as [Window Length(ft)],";
                    qry = qry + "Win_WallName as [Window in wall ] from Window_Tab where Win_Name like 'W%' ;";
                }
                else
                {
                    qry = "select Win_Name as [Window name],Win_Height as [Window Height(ft)], Win_Length as [Window Length(ft)],";
                    qry = qry + "Win_WallName as [Window in wall ] from Window_Tab where Win_Name ='" + cmbCntrlName.Text + "';";
                }
            }
            else if (cmbCntrlType.Text == "Door")
            {
                if (rbAll.Checked == true)
                {
                    qry = "select Win_Name as [Door name],Win_Height as [Door Height(ft)], Win_Length as [Door Length(ft)],";
                    qry = qry + "Win_WallName as [Door in wall ] from Window_Tab where Win_Name like 'D%';";
                }
                else
                {
                    qry = "select Win_Name as [Door name],Win_Height as [Door Height(ft)], Win_Length as [Door Length(ft)],";
                    qry = qry + "Win_WallName as [Door in wall ] from Window_Tab where Win_Name ='" + cmbCntrlName.Text + "';";
                }
            }
            else if (cmbCntrlType.Text == "Base")
            {
                if (rbAll.Checked == true)
                {
                    qry = "select BS_Name as [Base name],BS_Mat_Sand as [Sand(cb ft)], BS_Mat_Stone  as [Stone(cb ft)],";
                    qry = qry + "BS_Mat_Cement as [Cement(cb ft)] from Base_Tab;";

                    qr2 = "select sum(BS_Mat_Sand),sum( BS_Mat_Stone),sum(BS_Mat_Cement) from Base_Tab;";
                    ShowTotMaterial(qr2);
                }
                else
                {
                    qry = "select BS_Name as [Base name],BS_Mat_Sand as [Sand(cb ft)], BS_Mat_Stone  as [Stone(cb ft)],";
                    qry = qry + "BS_Mat_Cement as [Cement(cb ft)] from Base_Tab where BS_Name ='" + cmbCntrlName.Text + "';";
                }
            }
            else if (cmbCntrlType.Text == "Roof")
            {
                if (rbAll.Checked == true)
                {
                    qry = "select Rf_Name as [Roof name],Rf_Mat_Sand as [Sand(cb ft)], Rf_Mat_Stone  as [Stone(cb ft)],";
                    qry = qry + "Rf_Mat_Cement as [Cement(cb ft)],Rf_Mat_Rod as [Rods(ft)] from Roof_Tab;";

                    qr2 = "select sum(Rf_Mat_Sand),sum(Rf_Mat_Stone),sum(Rf_Mat_Cement),sum(Rf_Mat_Rod) from Roof_Tab;";
                    ShowTotMaterial(qr2);
                }
                else
                {
                    qry = "select Rf_Name as [Roof name],Rf_Mat_Sand as [Sand(cb ft)], Rf_Mat_Stone  as [Stone(cb ft)],";
                    qry = qry + "Rf_Mat_Cement as [Cement(cb ft)],Rf_Mat_Rod as [Rods(ft)] from Roof_Tab where Rf_Name ='" + cmbCntrlName.Text + "';";
                }
            }
            else
            {
                ;
            }

            ShowData(qry);
            
        }
        
        private void ShowCmpBtn_Click(object sender, EventArgs e)
        {

            string qry = "select * from Clm_Name;";
            if(cmbCntrlName.Text.Trim()!="")
            {
                if (rbWindow.Checked == true)
                {
                    qry = "select Win_WallName as [Wall Name], Win_Name as [Window Name] from Window_Tab where Win_Name like 'W%' and Win_WallName='" + cmbCntrlName.Text + "';";
                }
                else if (rbDoor.Checked == true)
                {
                    qry = "select Win_WallName as [Wall Name], Win_Name as [Door Name] from Window_Tab where Win_Name like 'D%' and Win_WallName='" + cmbCntrlName.Text + "';";
                }
                else if (rbBeam.Checked == true)
                {
                    qry = "select WL_Name as [Wall Name], Com_Name as [Beam Name] from Wall_Beam where WL_Name='" + cmbCntrlName.Text + "';";
                }
                ShowData(qry);
            }
            else
            {
                MessageBox.Show("Please select wall name.", "Information", MessageBoxButtons.OK);
            }
        }


        // Load Columns data
        public void LoadColumn()
        {
            try
            {

                string Qry = "select Clm_Name from Column_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        cmbCntrlName.Items.Add(Dr.GetString(0));
                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
        // Load Beam data
        public void LoadBeam()
        {
            try
            {

                string Qry = "select Bm_Name from Beam_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        cmbCntrlName.Items.Add(Dr.GetString(0));
                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
        // Load Wall data
        public void LoadWall()
        {
            try
            {

                string Qry = "select Wl_Name from Wall_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        cmbCntrlName.Items.Add(Dr.GetString(0));
                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
        // Load Window data
        public void LoadWindow()
        {
            try
            {

                string Qry = "select Win_Name from Window_Tab where Win_Name like 'W%';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        cmbCntrlName.Items.Add(Dr.GetString(0));
                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
        // Load Door data
        public void LoadDoor()
        {
            try
            {

                string Qry = "select Win_Name from Window_Tab where Win_Name like 'D%';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        cmbCntrlName.Items.Add(Dr.GetString(0));
                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
        // Load Base data
        public void LoadBase()
        {
            try
            {

                string Qry = "select BS_Name from Base_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        cmbCntrlName.Items.Add(Dr.GetString(0));
                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
        // Load Roof data
        public void LoadRoof()
        {
            try
            {

                string Qry = "select Rf_Name from Roof_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        cmbCntrlName.Items.Add(Dr.GetString(0));
                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
        //showing data
        private void ShowData(string Qry)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable Enq = new DataTable();
                da.Fill(Enq);

                dGview.DataSource = Enq;

                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK);
            }

        }
        //show total material
        private void ShowTotMaterial(string Qry)
        {
            try
            {
                getCalData();
                TotMatBox.Visible = true;

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();

                OleDbDataReader Dr = cmd.ExecuteReader();

                if(cmbCntrlType.Text == "Column")
                {
                    if(Dr.HasRows)
                    {
                        while(Dr.Read())
                        {
                            txtSand.Text = (Dr.GetDouble(0) / SndVl).ToString();
                            txtStone.Text = (Dr.GetDouble(1)/StnVl).ToString();
                            txtCement.Text = (Dr.GetDouble(2) / CmtVl).ToString();
                            txtNRod.Text = (Dr.GetDouble(3) / CmRdLen).ToString();
                            txtRRod.Text = (Dr.GetDouble(4) / RgRdLen).ToString();
                        }
                    }
                }
                else if (cmbCntrlType.Text == "Beam")
                {
                    if (Dr.HasRows)
                    {
                        while (Dr.Read())
                        {
                            txtSand.Text = (Dr.GetDouble(0) / SndVl).ToString();
                            txtStone.Text = (Dr.GetDouble(1) / StnVl).ToString();
                            txtCement.Text = (Dr.GetDouble(2) / CmtVl).ToString();
                            txtNRod.Text = (Dr.GetDouble(3) / CmRdLen).ToString();
                            txtRRod.Text = (Dr.GetDouble(4) / RgRdLen).ToString();
                        }
                    }
                }
                else if (cmbCntrlType.Text == "Wall")
                {
                    if (Dr.HasRows)
                    {
                        while (Dr.Read())
                        {
                            txtSand.Text = (Dr.GetDouble(0) / SndVl).ToString();
                            txtCement.Text = (Dr.GetDouble(1) / CmtVl).ToString();

                        }
                    }
                }
                else if (cmbCntrlType.Text == "Base")
                {
                    if (Dr.HasRows)
                    {
                        while (Dr.Read())
                        {
                            txtSand.Text = (Dr.GetDouble(0) / SndVl).ToString();
                            txtStone.Text = (Dr.GetDouble(1) / StnVl).ToString();
                            txtCement.Text = (Dr.GetDouble(2) / CmtVl).ToString();
                            
                        }
                    }
                }
                else if (cmbCntrlType.Text == "Roof")
                {
                    if (Dr.HasRows)
                    {
                        while (Dr.Read())
                        {
                            txtSand.Text = (Dr.GetDouble(0) / SndVl).ToString();
                            txtStone.Text = (Dr.GetDouble(1) / StnVl).ToString();
                            txtCement.Text = (Dr.GetDouble(2) / CmtVl).ToString();
                            txtNRod.Text = (Dr.GetDouble(3) / CmRdLen).ToString();
                            
                        }
                    }
                }
                else
                {
                    ;
                }

                if (Dr != null)
                    Dr.Close();

                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK);
            }

        }

        private void getCalData()
        {
            string prop_name;
            float prp_val;
            try
            {
                string Qry = "select * from WorkMat;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        prop_name = Dr.GetString(0);
                        prp_val = Dr.GetFloat(1);

                        if (prop_name == "Brick_Brd")
                        {
                            Brk_brd = prp_val;
                        }
                        else if (prop_name == "Brick_Hi")
                        {
                            Brk_thick = prp_val;
                        }
                        else if (prop_name == "Brick_Len")
                        {
                            Brk_len = prp_val;
                        }
                        else if (prop_name == "Cement")
                        {
                            CmtVl = prp_val;
                        }
                        else if (prop_name == "Clm_Rod_Len")
                        {
                            CmRdLen = prp_val;
                        }
                        else if (prop_name == "Clm_Rod_Thick")
                        {
                            CmRdThick = prp_val;
                        }
                        else if (prop_name == "Ring_Rod_Len")
                        {
                            RgRdLen = prp_val;
                        }
                        else if (prop_name == "Ring_Rod_Thick")
                        {
                            RgRdThick = prp_val;
                        }
                        else if (prop_name == "Sand")
                        {
                            SndVl = prp_val;
                        }
                        else if (prop_name == "Stone")
                        {
                            StnVl = prp_val;
                        }
                        else
                        {
                            MessageBox.Show("No proper field to save...", "Information", MessageBoxButtons.OK);
                        }


                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

        }
    }
}
