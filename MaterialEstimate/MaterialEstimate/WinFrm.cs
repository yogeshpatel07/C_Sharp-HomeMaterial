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
    public partial class WinFrm : Form
    {
        //string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\MyHomeMaterial\\HomeDB.accdb;Persist Security Info=False";
        string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\DataBase\\HomeDB.accdb;Persist Security Info=False";

        Graphics g = null;
        Pen pn = null;
        int WinSx = 0, WinSy = 0, nmSx = 0, nmSy = 0, WinNo = 0;
        string WinName = "Win";
        float WinH, WinL;
        float Brk_len, Brk_brd, Brk_thick, CmRdLen, CmRdThick, RgRdLen, RgRdThick, StnVl, SndVl, CmtVl;     //var for mat calc

        float WL_H, WL_B, WL_L, WL_SR, WL_CR, WL_PT, WL_PSR, WL_PCR;
        string WL_PSD;
        bool WL_PL;
        float Mt_Snd, Mt_Cmt;
        int Mt_Brick;    //val for mat data


        public WinFrm()
        {
            InitializeComponent();
        }

        private void WinFrm_Load(object sender, EventArgs e)
        {
            WinName = HomeFrm.WlCmp;
            g = picBox.CreateGraphics();
            pn = new Pen(Color.Black);
            getWallsList();

            if (HomeFrm.TodoType == "new")
            {
                txtWinLeft.Text = HomeFrm.SX.ToString();
                txtWinTop.Text = HomeFrm.SY.ToString();
                WinSx = HomeFrm.SX;
                WinSy = HomeFrm.SY;

                if (HomeFrm.SX < 10)
                {
                    txtNameLeft.Text = (HomeFrm.SX + 10).ToString();
                    nmSx = HomeFrm.SX + 10;
                }
                else if (HomeFrm.SX > 670)
                {
                    txtNameLeft.Text = (HomeFrm.SX - 10).ToString();
                    nmSx = HomeFrm.SX - 10;
                }
                else
                {
                    txtNameLeft.Text = (HomeFrm.SX).ToString();
                    nmSx = HomeFrm.SX;
                }

                if (HomeFrm.SY < 10)
                {
                    txtNameTop.Text = (HomeFrm.SY + 50).ToString();
                    nmSy = HomeFrm.SY + 50;
                }
                else
                {
                    txtNameTop.Text = (HomeFrm.SY - 10).ToString();
                    nmSy = HomeFrm.SY - 10;
                }

                WinNo = getWinNo();
                WinName = WinName + WinNo;
                UpdateCanvas(WinName);

            }

            if (HomeFrm.TodoType == "edit")
            {
                getEditClmData();

                WinSx = Convert.ToInt32(txtWinLeft.Text);
                WinSy = Convert.ToInt32(txtWinTop.Text);
                nmSx = Convert.ToInt32(txtNameLeft.Text);
                nmSy = Convert.ToInt32(txtNameTop.Text);
                
                UpdateCanvas(WinName);

            }

            ShowContorlBtn.Enabled = true;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = "Status :  X = " + e.X + " , Y = " + e.Y;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isAllValid())
            {
                if ((MessageBox.Show("Do you want to save data?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    if (MaterialCount())
                    {
                        UpdateWallData();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Can\'t save this data.\nMaterial calculation Error...", "Information", MessageBoxButtons.OK);
                    }   
                }
            }
            
        }

        private void txtWinTop_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtWinTop.Text);
                if (val < 0)
                {
                    MessageBox.Show("Windows top value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 655)
                {
                    MessageBox.Show("Windows top value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    WinSy = val;
                    UpdateCanvas(WinName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtWinLeft_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtWinLeft.Text);
                if (val < 0)
                {
                    MessageBox.Show("Windows left value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 880)
                {
                    MessageBox.Show("Windows left value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    WinSx = val;
                    UpdateCanvas(WinName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtNameTop_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtNameTop.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name top value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 655)
                {
                    MessageBox.Show("Name top value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    nmSy = val;
                    UpdateCanvas(WinName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtNameLeft_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtNameLeft.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name left value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 880)
                {
                    MessageBox.Show("Name left value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    nmSx = val;
                    UpdateCanvas(WinName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void ShowContorlBtn_Click(object sender, EventArgs e)
        {
            UpdateCanvas(WinName);
        }


        //my Methods
        // for checking all Inputs are valid or not 
        private bool isAllValid()
        {
            int val = 0;
            float tmp;

            // Win Top pos
            try
            {
                val = int.Parse(txtWinTop.Text);
                if (val < 0)
                {
                    MessageBox.Show("Windows top value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 655)
                {
                    MessageBox.Show("Windows top value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    WinSy = val;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
                return false;
            }

            // Win Left pos
            try
            {
                val = int.Parse(txtWinLeft.Text);
                if (val < 0)
                {
                    MessageBox.Show("Windows left value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 880)
                {
                    MessageBox.Show("Windows left value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    WinSx = val;
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
                return false;
            }

            //Name Top pos
            try
            {
                val = int.Parse(txtNameTop.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name top value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 655)
                {
                    MessageBox.Show("Name top value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    nmSy = val;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
                return false;
            }

            // Name Left pos
            try
            {
                val = int.Parse(txtNameLeft.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name left value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 880)
                {
                    MessageBox.Show("Name left value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    nmSx = val;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
                return false;
            }

            // Beam Hight 
            try
            {

                val = int.Parse(txtWinHeightFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Windows Hight  feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtWinHeightIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Windows Hight inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                WinH = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Windows Hight can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // Beam Length 
            try
            {

                val = int.Parse(txtWinLengthFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Windows Length feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtWinLengthIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Windows Length inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                WinL = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Windows Length can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            if (cmbWallName.Text.Trim() == "")
            {
                MessageBox.Show("Wall Name can\'t empty...", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;

        }
        // get walls List
        private void getWallsList()
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
                        cmbWallName.Items.Add(Dr.GetString(0));

                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }
        // for Redraw the coltrols 
        private void UpdateCanvas(string Exp = "none")
        {
            g.Clear(picBox.BackColor);

            ShowBase(Exp);
            ShowColumns(Exp);
            ShowBeams(Exp);
            ShowWinAndDoors(Exp);
            ShowWalls(Exp);
            ShowRoof(Exp);

            g.FillRectangle(new SolidBrush(Color.Red), WinSx, WinSy, 10, 10);
            g.DrawString(WinName, HomeFrm.fnt, new SolidBrush(Color.Red), nmSx, nmSy);

        }
        // function for for get maximum column number
        private int getWinNo()
        {
            int re = 1;
            try
            {
                string Qry = "select max(Win_No) from Window_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        re = Dr.GetInt32(0) + 1;
                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception)
            {
                ;
            }
            return re;
        }
        // function for load column data
        private void getEditClmData()
        {
            try
            {
                /*   TbClms = " Clm_No,Clm_Name,Clm_SX,Clm_SY,Clm_Wi,Clm_Hi,Clm_Nm_X,Clm_Nm_Y,Clm_Hight,Clm_Breadth,Clm_Length,";
                   TbClms = TbClms + "Clm_Pit_Depth,Clm_Pit_Breadth,Clm_Pit_Length,Clm_Pit_Mat_Thick,Clm_Sand_Rat,Clm_Stone_Rat,";
                   TbClms = TbClms + "Clm_Cement_Rat,Clm_NoRod ";*/

                int ftv = 0, incv = 0;
                float FtinV = 0;
                string Qry = "select * from Window_Tab where Win_Name ='" + HomeFrm.EdtCntrl + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        WinName = Dr.GetString(1);
                        txtWinLeft.Text = Dr.GetInt16(2).ToString();
                        txtWinTop.Text = Dr.GetInt16(3).ToString();
                        txtNameLeft.Text = Dr.GetInt16(6).ToString();
                        txtNameTop.Text = Dr.GetInt16(7).ToString();

                        FtinV = Dr.GetFloat(8);
                        FtToIn(FtinV, out ftv, out incv);
                        txtWinHeightFt.Text = ftv.ToString();
                        txtWinHeightIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(9);
                        FtToIn(FtinV, out ftv, out incv);
                        txtWinLengthFt.Text = ftv.ToString();
                        txtWinLengthIn.Text = incv.ToString();

                        cmbWallName.Text = Dr.GetString(10);

                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can\'t load all edit column data\n " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        //function for decompose float Feet value into int feet and int Inche values
        private void FtToIn(float FtInVl, out int FtVl, out int InVl)
        {
            float tmp;
            FtVl = Convert.ToInt32(Math.Floor(FtInVl));
            tmp = FtInVl - FtVl;
            tmp = (tmp * 12);
            InVl = Convert.ToInt32(Math.Round(tmp, 0));

        }

        // get the Material calculation essensial data
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

        // seving Window data
        private bool SaveWinData()
        {
            try
            {
                int rv;
                string Clms_Name = "";
                string Clms_Val = "";
                string Qry = "delete from Window_Tab where Win_Name='" + WinName + "' and Win_WallName='" + cmbWallName.Text + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();

                rv = cmd.ExecuteNonQuery();

                Clms_Name = " Win_No,Win_Name,Win_SX,Win_SY,Win_Wi,Win_Hi,Win_NX,Win_NY,Win_Height,Win_Length,Win_WallName ";
                Clms_Val = WinNo + ",'" + WinName + "'," + txtWinLeft.Text + "," + txtWinTop.Text + ",10,10," + txtNameLeft.Text;
                Clms_Val = Clms_Val + "," + txtNameTop.Text + "," + WinH + "," + WinL + ",'" + cmbWallName.Text+"'";

                Qry = "insert into Window_Tab(" + Clms_Name + ") values(" + Clms_Val + ");";

                cmd.CommandText = Qry;
                rv = cmd.ExecuteNonQuery();

                if (rv > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

        }
       
        // geting the Windows related wall data
        private void getWallData()
        {
            try
            {
                string Cmm = "Wl_Hight,Wl_Breadth,Wl_Length,Wl_Sand_Rat,Wl_Cement_Rat,Wl_Plstr,Wl_Pls_Length,Wl_Pls_Sand_Rat,";
                Cmm = Cmm + "Wl_Pls_Cement_Rat,Wl_Plstr_Side";

                string Qry = "select " + Cmm + " from Wall_Tab where Wl_Name ='" + cmbWallName.Text + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {

                        WL_H = Dr.GetFloat(0);
                        WL_B = Dr.GetFloat(1);
                        WL_L = Dr.GetFloat(2);
                        WL_SR = Dr.GetFloat(3);
                        WL_CR = Dr.GetFloat(4);

                        WL_PL = Dr.GetBoolean(5);
                        if (WL_PL == true)
                        {
                            WL_PT = Dr.GetFloat(6);
                            WL_PSR = Dr.GetFloat(7);
                            WL_PCR = Dr.GetFloat(8);
                            WL_PSD = Dr.GetString(9);
                        }
                        else
                        {
                            WL_PT = 0;
                            WL_PSR = 0;
                            WL_PCR = 0;
                            WL_PSD = "One";
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
                MessageBox.Show("Can\'t load all edit wall data.\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        // get the total beams thickness related to wall
        private float getWlBmThick()
        {
            float tk = 0;

            try
            {
                string Qry = "select * from Wall_Beam where WL_Name='" + cmbWallName.Text + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        tk = tk + Dr.GetFloat(2);
                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception)
            {
                return 0;
            }

            return tk;
        }
        
        // geting the total volume of Windows
        private float getWinDrVol()
        {
            float vl = 0;
            float WDH, WDL;
            try
            {
                string Qry = "select Win_Height,Win_Length from Window_Tab where Win_WallName='" + cmbWallName.Text + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        WDH = Dr.GetFloat(0);
                        WDL = Dr.GetFloat(1);
                        vl = vl + (WL_B * WDH * WDL);

                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception)
            {
                return 0;
            }
            return vl;
        }

        // deleting window if save material calculation fail
        private bool DeleteWinData()
        {
            try
            {
                int rv;

                string Qry = "delete from Window_Tab where Win_Name='" + WinName + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();

                rv = cmd.ExecuteNonQuery();
                if (rv > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        //saving data
        private void UpdateWallData()
        {
            try
            {
                int rv;
                string Clms_Name = "";
                string Qry = "seelct * from Window_Tab where Win_Name='" + WinName + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                
                Clms_Name = " Wl_Mat_Sand=" + Mt_Snd + ",Wl_Mat_Cement=" + Mt_Cmt + ",Wl_Mat_Bricks=" + Mt_Brick;
                Qry = "Update Wall_Tab Set " + Clms_Name + " where Wl_Name='" + cmbWallName.Text + "';";

                cmd.CommandText = Qry;
                rv = cmd.ExecuteNonQuery();

                if (rv > 0)
                {
                    MessageBox.Show("All data save successfully...", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Wall data not save successfully...", "Information", MessageBoxButtons.OK); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not save successfully...\n" + ex.Message, "Error", MessageBoxButtons.OK); ;
            }

        }

        // for material Calculation return false if any error
        private bool MaterialCount()
        {
            try
            {
                getCalData();   //for geting the Basic Calc Data

                if (SaveWinData()==false)
                {
                    MessageBox.Show("Windows Data Not Save or Update.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                
                getWallData();  //for geting the Wall Data

                float TotBmTk=getWlBmThick();
                float WnDrVol = getWinDrVol();

                float BmVol, TotVol, WlVol, PlVol;
                float WlSnd, WlCmt, PlSnd, PlCmt;
                
                WlVol = WL_H * WL_L * WL_B;
                BmVol = TotBmTk * WL_L * WL_B;

                if(WlVol<=(BmVol+WnDrVol))
                {
                    if (DeleteWinData() == false)
                    {
                        MessageBox.Show("Window Deleting error.", "Error", MessageBoxButtons.OK);
                    }
                    MessageBox.Show("Wall Space is less than added component.", "Error", MessageBoxButtons.OK);
                    return false;
                }

                TotVol = WlVol - (BmVol + WnDrVol);
                Mt_Brick = CountBricks(TotVol); // total bricks

                TotVol = TotVol - (Mt_Brick * ((Brk_len * Brk_brd * Brk_thick) / (12 * 12 * 12)));

                WlSnd = (TotVol * WL_SR) / (WL_SR + WL_CR);
                WlCmt = (TotVol * WL_CR) / (WL_SR + WL_CR);

                Mt_Snd = WlSnd;
                Mt_Cmt = WlCmt;

                if (WL_PL== true)
                {
                    PlVol = (TotVol * (WL_PT)/12) / WL_B;
                    if (WL_PSD == "Both")
                    {
                        PlVol = 2 * PlVol;
                    }

                    PlSnd = (PlVol * WL_PSR) / (WL_PSR + WL_PCR);
                    PlCmt = (PlVol * WL_PCR) / (WL_PSR + WL_PCR);
                    Mt_Snd = Mt_Snd + PlSnd;
                    Mt_Cmt = Mt_Cmt + PlCmt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        // Bricks Count
        private int CountBricks(float TtVol)
        {
            int res = 0;
            float brickVol;
            brickVol = (float)(((Brk_len + 0.5) * (Brk_brd + 0.5) * (Brk_thick + 0.5)) / (12 * 12 * 12));

            res = Convert.ToInt32(TtVol / brickVol);
            return res;
        }
        
        
        //shoing controls matheds
        private void ShowColumns(string Exp = "none")
        {
            try
            {
                string Clm_Nm;
                int Sx, Ex, Sy, Ey, Nmx, Nmy;
                string Qry = "select Clm_Name,Clm_SX,Clm_SY,Clm_Wi,Clm_Hi,Clm_Nm_X,Clm_Nm_Y from Column_Tab where not(Clm_Name ='" + Exp + "');";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Clm_Nm = Dr.GetString(0);
                        Sx = Dr.GetInt16(1);
                        Sy = Dr.GetInt16(2);
                        Ex = Dr.GetInt16(3);
                        Ey = Dr.GetInt16(4);
                        Nmx = Dr.GetInt16(5);
                        Nmy = Dr.GetInt16(6);

                        g = picBox.CreateGraphics();
                        g.FillRectangle(new SolidBrush(Color.DarkCyan), Sx, Sy, Ex, Ey);
                        g.DrawString(Clm_Nm, HomeFrm.fnt, new SolidBrush(Color.DarkCyan), Nmx, Nmy);

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
        private void ShowBeams(string Exp = "none")
        {
            try
            {
                Pen mypn = new Pen(Color.Purple, 5);

                string Bm_Nm;
                int Sx, Ex, Sy, Ey, Nmx, Nmy;
                string Qry = "select Bm_Name,Bm_SX,Bm_SY,Bm_EX,Bm_EY,Bm_Nm_X,Bm_Nm_Y from Beam_Tab where not(Bm_Name ='" + Exp + "');";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Bm_Nm = Dr.GetString(0);
                        Sx = Dr.GetInt16(1);
                        Sy = Dr.GetInt16(2);
                        Ex = Dr.GetInt16(3);
                        Ey = Dr.GetInt16(4);
                        Nmx = Dr.GetInt16(5);
                        Nmy = Dr.GetInt16(6);

                        g.DrawLine(mypn, Sx, Sy, Ex, Ey);
                        g.DrawString(Bm_Nm, HomeFrm.fnt, new SolidBrush(mypn.Color), Nmx, Nmy);

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
        private void ShowWalls(string Exp = "none")
        {
            try
            {
                Pen mypn = new Pen(Color.Blue, 5);

                string Wl_Nm;
                int Sx, Ex, Sy, Ey, Nmx, Nmy;
                string Qry = "select Wl_Name,Wl_SX,Wl_SY,Wl_EX,WL_EY,Wl_Nm_X,Wl_Nm_Y from Wall_Tab where not(Wl_Name ='" + Exp + "');";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Wl_Nm = Dr.GetString(0);
                        Sx = Dr.GetInt16(1);
                        Sy = Dr.GetInt16(2);
                        Ex = Dr.GetInt16(3);
                        Ey = Dr.GetInt16(4);
                        Nmx = Dr.GetInt16(5);
                        Nmy = Dr.GetInt16(6);

                        g.DrawLine(mypn, Sx, Sy, Ex, Ey);
                        g.DrawString(Wl_Nm, HomeFrm.fnt, new SolidBrush(mypn.Color), Nmx, Nmy);

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
        private void ShowWinAndDoors(string Exp = "none")
        {
            try
            {
                string Wi_Nm;
                int Sx, Ex, Sy, Ey, Nmx, Nmy;
                string Qry = "select Win_Name,Win_SX,Win_SY,Win_Wi,Win_Hi,Win_NX,Win_NY from Window_Tab where not(Win_Name ='" + Exp + "');";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Wi_Nm = Dr.GetString(0);
                        Sx = Dr.GetInt16(1);
                        Sy = Dr.GetInt16(2);
                        Ex = Dr.GetInt16(3);
                        Ey = Dr.GetInt16(4);
                        Nmx = Dr.GetInt16(5);
                        Nmy = Dr.GetInt16(6);

                        g = picBox.CreateGraphics();
                        g.FillRectangle(new SolidBrush(Color.Green), Sx, Sy, Ex, Ey);
                        g.DrawString(Wi_Nm, HomeFrm.fnt, new SolidBrush(Color.Green), Nmx, Nmy);

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
        private void ShowBase(string Exp = "none")
        {
            try
            {
                string Bs_Nm;
                int Sx, Ex, Sy, Ey, Nmx, Nmy;
                string Qry = "select BS_Name,BS_SX,BS_SY,BS_Wi,BS_Hi,BS_NX,BS_NY from Base_Tab where not(BS_Name ='" + Exp + "');";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Bs_Nm = Dr.GetString(0);
                        Sx = Dr.GetInt16(1);
                        Sy = Dr.GetInt16(2);
                        Ex = Dr.GetInt16(3);
                        Ey = Dr.GetInt16(4);
                        Nmx = Dr.GetInt16(5);
                        Nmy = Dr.GetInt16(6);

                        g = picBox.CreateGraphics();
                        g.FillRectangle(new SolidBrush(Color.Pink), Sx, Sy, Ex, Ey);
                        g.DrawString(Bs_Nm, HomeFrm.fnt, new SolidBrush(Color.Pink), Nmx, Nmy);

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
        private void ShowRoof(string Exp = "none")
        {
            try
            {
                Pen mypn = new Pen(Color.Black, 2);

                string Rf_Nm;
                int Sx, Ex, Sy, Ey, Nmx, Nmy;
                string Qry = "select Rf_Name,Rf_SX,Rf_SY,Rf_Wi,Rf_Hi,Rf_NX,Rf_NY from Roof_Tab where not(Rf_Name ='" + Exp + "');";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Rf_Nm = Dr.GetString(0);
                        Sx = Dr.GetInt16(1);
                        Sy = Dr.GetInt16(2);
                        Ex = Dr.GetInt16(3);
                        Ey = Dr.GetInt16(4);
                        Nmx = Dr.GetInt16(5);
                        Nmy = Dr.GetInt16(6);

                        g = picBox.CreateGraphics();
                        g.DrawRectangle(mypn, Sx, Sy, Ex, Ey);
                        g.DrawString(Rf_Nm, HomeFrm.fnt, new SolidBrush(mypn.Color), Nmx, Nmy);
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
