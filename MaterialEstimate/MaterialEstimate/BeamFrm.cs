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
    public partial class BeamFrm : Form
    {
        //string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\MyHomeMaterial\\HomeDB.accdb;Persist Security Info=False";
        string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\DataBase\\HomeDB.accdb;Persist Security Info=False";

        Graphics g = null;
        Pen pn = null;
        int BmSx = 0, BmSy = 0, BmEx = 0, BmEy = 0, nmSx = 0, nmSy = 0, BmNo = 0;
        string BmName = "Bm";
        float BmH, BmL, BmB;
        float Brk_len, Brk_brd, Brk_thick, CmRdLen, CmRdThick, RgRdLen, RgRdThick, StnVl, SndVl, CmtVl;
        float Mt_Snd, Mt_Stn, Mt_Cmt, Mt_Rd, Mt_RRd, Mt_SndTrc, Mt_StnTrc, Mt_CmtSk;

/*        List<string> Walls = null;
        float WL_H, WL_L, WL_B, WL_SR, WL_CR, WL, WL_PT, WL_PSR, WL_PCR;
        string WL_PSD;
        bool WL_PL;
        string WalName;
*/

        public BeamFrm()
        {
            InitializeComponent();
        }

        private void BeamFrm_Load(object sender, EventArgs e)
        {
            g = picBox.CreateGraphics();
            pn = new Pen(Color.Black, 5);

            if (HomeFrm.TodoType == "new")
            {
                BmNo = getBmNo();
                BmName = BmName + BmNo;

                txtStartX.Text = HomeFrm.SX.ToString();
                txtStartY.Text = HomeFrm.SY.ToString();
                txtEndX.Text = HomeFrm.EX.ToString();
                txtEndY.Text = HomeFrm.EY.ToString();

                BmSx = HomeFrm.SX;
                BmSy = HomeFrm.SY;
                BmEx = HomeFrm.EX;
                BmEy = HomeFrm.EY;

                if (HomeFrm.SX < 10)
                {
                    txtNmX.Text = (HomeFrm.SX + 10).ToString();
                    nmSx = HomeFrm.SX + 10;
                }
                else if (HomeFrm.SX > 670)
                {
                    txtNmX.Text = (HomeFrm.SX - 10).ToString();
                    nmSx = HomeFrm.SX - 10;
                }
                else
                {
                    txtNmX.Text = (HomeFrm.SX).ToString();
                    nmSx = HomeFrm.SX;
                }

                if (HomeFrm.SY < 10)
                {
                    txtNmY.Text = (HomeFrm.SY + 50).ToString();
                    nmSy = HomeFrm.SY + 50;

                }
                else
                {
                    txtNmY.Text = (HomeFrm.SY - 10).ToString();
                    nmSy = HomeFrm.SY - 10;
                }

                UpdateCanvas(BmName);
            }

            if (HomeFrm.TodoType == "edit")
            {
                getEditBeamData();

                BmSx = Convert.ToInt32(txtStartX.Text);
                BmSy = Convert.ToInt32(txtStartY.Text);
                BmEx = Convert.ToInt32(txtEndX.Text);
                BmEy = Convert.ToInt32(txtEndY.Text);
                nmSx = Convert.ToInt32(txtNmX.Text);
                nmSy = Convert.ToInt32(txtNmY.Text);

                UpdateCanvas(BmName);
            }

            ShowContorlBtn.Enabled = true;
            

        }

        private void txtStartX_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtStartX.Text);
                if (val < 0)
                {
                    MessageBox.Show("Start X value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 880)
                {
                    MessageBox.Show("Start X value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    BmSx = val;
                    UpdateCanvas(BmName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtStartY_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtStartY.Text);
                if (val < 0)
                {
                    MessageBox.Show("Start Y value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 655)
                {
                    MessageBox.Show("Start Y value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    BmSy = val;
                    UpdateCanvas(BmName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtEndX_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtEndX.Text);
                if (val < 0)
                {
                    MessageBox.Show("End X value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 880)
                {
                    MessageBox.Show("End X value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    BmEx = val;
                    UpdateCanvas(BmName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtEndY_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtEndY.Text);
                if (val < 0)
                {
                    MessageBox.Show("End Y value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 655)
                {
                    MessageBox.Show("End Y value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    BmEy = val;
                    UpdateCanvas(BmName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtNmX_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtNmX.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name X value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 880)
                {
                    MessageBox.Show("Name X value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    nmSx = val;
                    UpdateCanvas(BmName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtNmY_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtNmY.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name Y value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 655)
                {
                    MessageBox.Show("Name Y value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    nmSy = val;
                    UpdateCanvas(BmName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void ShowContorlBtn_Click(object sender, EventArgs e)
        {
            UpdateCanvas(BmName);
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
                        if (HomeFrm.TodoType == "edit")
                        {
                            SaveData();
                            UpdateBeamWall();
                            this.Close();
                        }
                        else
                        {
                            SaveData();
                            this.Close();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Can\'t save this data.\nMaterial calculation Error...", "Information", MessageBoxButtons.OK);
                    }
                }
            }
            
        }

        

        //my Methods
        // for checking all Inputs are valid or not 
        private bool isAllValid()
        {
            int val = 0;
            float val1 = 0;
            float tmp;

            // check Column Position Start X
            try
            {
                val = int.Parse(txtStartX.Text);
                if (val < 0)
                {
                    MessageBox.Show("Start X value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 880)
                {
                    MessageBox.Show("Start X value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    BmSx = val;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Start X value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Column Position Start Y
            try
            {
                val = int.Parse(txtStartY.Text);
                if (val < 0)
                {
                    MessageBox.Show("Start Y value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 655)
                {
                    MessageBox.Show("Start Y value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    BmSy = val;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Start Y value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Column Position End X
            try
            {
                val = int.Parse(txtEndX.Text);
                if (val < 0)
                {
                    MessageBox.Show("End X value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 880)
                {
                    MessageBox.Show("End X value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    BmEx = val;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("End X value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Column Position End Y
            try
            {
                val = int.Parse(txtEndY.Text);
                if (val < 0)
                {
                    MessageBox.Show("End Y value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 655)
                {
                    MessageBox.Show("End Y value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    BmEy = val;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("End Y value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }


            // check Column Name X
            try
            {
                val = int.Parse(txtNmX.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name X value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 880)
                {
                    MessageBox.Show("Name X value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    nmSx = val;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Name X value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Column Name Y
            try
            {
                val = int.Parse(txtNmY.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name Y value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 655)
                {
                    MessageBox.Show("Name Y value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    nmSy = val;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Name Y value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }



            // Beam Hight 
            try
            {

                val = int.Parse(txtBmHeightFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Beam Thickness feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtBmHeightIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Beam Thickness inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                BmH = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beam Thickness can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // Beam Length 
            try
            {

                val = int.Parse(txtBmLengthFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Beam Length feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtBmLengthIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Beam Length inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                BmL = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beam Length can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // Beam Breadth
            try
            {

                val = int.Parse(txtBmBreadthFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Beam Width feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtBmBreadthIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Beam Width inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                BmB = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beam Width can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // Sand Ratio
            try
            {
                val1 = float.Parse(txtSand.Text);
                if (val1 < 0)
                {
                    MessageBox.Show("Sand ratio can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sand ratio can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            // Stone Ratio
            try
            {
                val1 = float.Parse(txtStone.Text);
                if (val1 < 0)
                {
                    MessageBox.Show("Stone ratio can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Stone ratio can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            // Cement Ratio
            try
            {
                val1 = float.Parse(txtCement.Text);
                if (val1 < 0)
                {
                    MessageBox.Show("Cement ratio can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cement ratio can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            // No. of Rods
            try
            {
                val = int.Parse(txtRods.Text);
                if (val < 0)
                {
                    MessageBox.Show("No. of Rods can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No. of Rods can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;

        }

        // for  get the maximun Beam Number
        private int getBmNo()
        {
            int re = 1;
            try
            {
                string Qry = "select max(Bm_No) from Beam_Tab;";
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

        // for Redraw the coltrols 
        private void UpdateCanvas(string Exp = "none")
        {
            g.Clear(picBox.BackColor);
            pn = new Pen(Color.Black, 5);

            ShowBase(Exp);
            ShowColumns(Exp);
            ShowBeams(Exp);
            ShowWinAndDoors(Exp);
            ShowWalls(Exp);
            ShowRoof(Exp);

            pn = new Pen(Color.Red, 5);
            g.DrawLine(pn, BmSx, BmSy, BmEx, BmEy);
            g.DrawString(BmName, HomeFrm.fnt, new SolidBrush(Color.Red), nmSx, nmSy);

        }
        
        // for  getting data for material Calculation 
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

        // for material Calculation return false if any error
        private bool MaterialCount()
        {
            try
            {
                getCalData();

                // filds for get data
                float bHit, bBred, bLen;
                float sandRt, stoneRt, cmtRt, totRt;
                float rgrdvol, clmrdvol, TtRdVl;
                float BmVol, TotVol;
                double clmRd = 0, clmSd = 0, clmCmt = 0, clmStn = 0, TotCmRd = 0, TotRgRd = 0;
                double St_trc = 0, Sd_trc = 0, Cmt_sk = 0;
                int NoRg, NoRd;

                bHit = Convert.ToSingle(txtBmHeightFt.Text) + (Convert.ToSingle(txtBmHeightIn.Text) / 12);
                bBred = Convert.ToSingle(txtBmBreadthFt.Text) + (Convert.ToSingle(txtBmBreadthIn.Text) / 12);
                bLen = Convert.ToSingle(txtBmLengthFt.Text) + (Convert.ToSingle(txtBmLengthIn.Text) / 12);

                BmH = bHit;
                BmL = bLen;
                BmB = bBred;

                sandRt = Convert.ToSingle(txtSand.Text);
                stoneRt = Convert.ToSingle(txtStone.Text);
                cmtRt = Convert.ToSingle(txtCement.Text);
                NoRd = Convert.ToInt32(txtRods.Text);
                totRt = sandRt + stoneRt + cmtRt;

                BmVol = bHit * bLen * bBred;
                TotVol = BmVol;
                clmRd = (BmL + 1) * NoRd;
                NoRg = Convert.ToInt32((BmL + 1) * 12 / 9);
                TotRgRd = (2 * BmH + 2 * BmB + 0.5) * NoRg; //total ring rod
                TotCmRd = clmRd;             //toal Clm rod

                clmrdvol = (float)((22 * CmRdThick * CmRdThick * TotCmRd) / (7 * 12 * 12));
                rgrdvol = (float)((22 * RgRdThick * RgRdThick * TotRgRd) / (7 * 12 * 12));
                TtRdVl = clmrdvol + rgrdvol;
                TotVol = TotVol - TtRdVl;
                clmSd = (TotVol * sandRt) / totRt;  //total sand
                clmStn = (TotVol * stoneRt) / totRt;    //total stone
                clmCmt = (TotVol * cmtRt) / totRt;  //total cement
                Sd_trc = clmSd / SndVl;
                St_trc = clmStn / StnVl;
                Cmt_sk = clmCmt / CmtVl;
                
                Mt_Snd = (float)(clmSd);
                Mt_SndTrc = (float)(Sd_trc);
                Mt_Stn = (float)(clmStn);
                Mt_StnTrc = (float)(St_trc);
                Mt_Cmt = (float)(clmCmt);
                Mt_CmtSk = (float)(Cmt_sk);
                Mt_Rd = (float)(TotCmRd);
                Mt_RRd = (float)(TotRgRd);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        //For saving and updating data
        private void SaveData()
        {
            try
            {

                string Clms_Val = "";
                string Clms_Name = "";
                string Qry = "";
                if (HomeFrm.TodoType == "new")
                {
                    Clms_Name = "Bm_No,Bm_Name,Bm_SX,Bm_SY,Bm_EX,Bm_EY,Bm_Nm_X,Bm_Nm_Y,Bm_Hight,Bm_Breadth,Bm_Length,Bm_Sand_Rat,";
                    Clms_Name = Clms_Name + "Bm_Stone_Rat,Bm_Cement_Rat,Bm_NoRod,Bm_Mat_Sand,Bm_Mat_Stone,Bm_Mat_Cement,";
                    Clms_Name = Clms_Name + "Bm_Mat_NRod,Bm_Mat_RRod";

                    Clms_Val = BmNo + ",'" + BmName + "'," + txtStartX.Text + "," + txtStartY.Text + "," + txtEndX.Text + "," + txtEndY.Text + ",";
                    Clms_Val = Clms_Val + txtNmX.Text + "," + txtNmY.Text + "," + BmH + "," + BmB + "," + BmL + "," + txtSand.Text + ",";
                    Clms_Val = Clms_Val + txtStone.Text + "," + txtCement.Text + "," + txtRods.Text + "," + Mt_Snd + "," + Mt_Stn + "," + Mt_Cmt + ",";
                    Clms_Val = Clms_Val + Mt_Rd + "," + Mt_RRd;
                    
                    Qry = "insert into Beam_Tab(" + Clms_Name + ") values(" + Clms_Val + ");";
                }
                if (HomeFrm.TodoType == "edit")
                {
                    Clms_Name = "Bm_SX=" + txtStartX.Text + ",Bm_SY=" + txtStartY.Text + ",Bm_EX=" + txtEndX.Text + ",Bm_EY=" + txtEndY.Text;
                    Clms_Name = Clms_Name + ",Bm_Nm_X=" + txtNmX.Text + " ,Bm_Nm_Y=" + txtNmY.Text + ",Bm_Hight=" + BmH + ",Bm_Breadth=" + BmB;
                    Clms_Name = Clms_Name + ",Bm_Length=" + BmL + ",Bm_Sand_Rat=" + txtSand.Text + ",Bm_Stone_Rat=";
                    Clms_Name = Clms_Name + txtStone.Text + ",Bm_Cement_Rat=" + txtCement.Text + ",Bm_NoRod=" + txtRods.Text;
                    Clms_Name = Clms_Name + ",Bm_Mat_Sand=" + Mt_Snd + ",Bm_Mat_Stone=" + Mt_Stn + ",";
                    Clms_Name = Clms_Name + "Bm_Mat_Cement=" + Mt_Cmt + ",Bm_Mat_NRod=" + Mt_Rd + ",Bm_Mat_RRod=" + Mt_RRd;

                    Qry = "Update Beam_Tab Set " + Clms_Name + " where Bm_Name='" + BmName + "';";
                }

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                int rv = cmd.ExecuteNonQuery();
                if (rv > 0)
                {
                    MessageBox.Show("Data Saved...", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Data Not Saved...", "Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Saved...\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void UpdateBeamWall()
        {
            try
            {
                string Qry = "update Wall_Beam set Bm_Thick=" + BmH + " where Com_Name='" + BmName + "'";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                int rv = cmd.ExecuteNonQuery();
                if (rv > 0)
                {
                    MessageBox.Show("Please update or edit Wall which contains this Beam.", "Information", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK); ;
            }
        }
  
        // for load data of Editing Beam
        private void getEditBeamData()
        {
            try
            {
                int ftv = 0, incv = 0;
                float FtinV = 0;
                string Qry = "select * from Beam_Tab where Bm_Name ='" + HomeFrm.EdtCntrl + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        BmName = Dr.GetString(1);
                        txtStartX.Text = Dr.GetInt16(2).ToString();
                        txtStartY.Text = Dr.GetInt16(3).ToString();
                        txtEndX.Text = Dr.GetInt16(4).ToString();
                        txtEndY.Text = Dr.GetInt16(5).ToString();
                        txtNmX.Text = Dr.GetInt16(6).ToString();
                        txtNmY.Text = Dr.GetInt16(7).ToString();

                        FtinV = Dr.GetFloat(8);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBmHeightFt.Text = ftv.ToString();
                        txtBmHeightIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(9);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBmBreadthFt.Text = ftv.ToString();
                        txtBmBreadthIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(10);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBmLengthFt.Text = ftv.ToString();
                        txtBmLengthIn.Text = incv.ToString();

                        
                        txtSand.Text = Dr.GetFloat(11).ToString();
                        txtStone.Text = Dr.GetFloat(12).ToString();
                        txtCement.Text = Dr.GetFloat(13).ToString();
                        txtRods.Text = Dr.GetInt16(14).ToString();

                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can\'t load all edit Beam Data.\n"+ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        // to Decompose float feet values into int feet and inch values
        private void FtToIn(float FtInVl, out int FtVl, out int InVl)
        {
            float tmp;
            FtVl = Convert.ToInt32(Math.Floor(FtInVl));
            tmp = FtInVl - FtVl;
            tmp = (tmp * 12);
            InVl = Convert.ToInt32(Math.Round(tmp, 0));

        }




 /*       // calulate Wall MAterial

        private bool UpdateWalls()
        {
            getWallsList();
            
            foreach(var WlN in Walls)
            {
                WalName = WlN;
                if (UpdateWallData(WalName)==false)
                {
                    return false;
                }
            }
            return true;
        }

        private void getWallsList()
        {
            try
            {
                Walls = new List<string>();

                string Qry = "select WL_Name from Wall_Beam where Com_Name='" + BmName + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Walls.Add(Dr.GetString(0));
                    }

                    if (Dr != null)
                        Dr.Close();
                    if (con != null)
                        con.Close();
                }
            }
            catch (Exception)
            {
                ;
            }
        }

        private bool UpdateWallData(string WalName)
        {
            if(WallMaterialCount(WalName)==false)
            {
                return false;
            }

            return true;
        }
        // for Wall material Calculation return false if any error
        private bool WallMaterialCount(string WalName)
        {
            try
            {
                getCalData();   //for geting the Basic Calc Data
                getWallData();  //for geting the Wall Data

                float TotBmTk = getWlBmThick();
                float WnDrVol = getWinDrVol();

                float BmVol, TotVol, WlVol, PlVol;
                float WlSnd, WlCmt, PlSnd, PlCmt;

                WlVol = WL_H * WL_L * WL_B;
                BmVol = TotBmTk * WL_L * WL_B;

                if (WlVol <= (BmVol + WnDrVol))
                {
                    MessageBox.Show("This beam size is greater than the wall size in which it added.", "Error", MessageBoxButtons.OK);
                    return false;
                }

                TotVol = WlVol - (BmVol + WnDrVol);
                Mt_Brick = CountBricks(TotVol); // total bricks

                TotVol = TotVol - (Mt_Brick * ((Brk_len * Brk_brd * Brk_thick) / (12 * 12 * 12)));

                WlSnd = (TotVol * WL_SR) / (WL_SR + WL_CR);
                WlCmt = (TotVol * WL_CR) / (WL_SR + WL_CR);

                Mt_Snd = WlSnd;
                Mt_Cmt = WlCmt;

                if (WL_PL == true)
                {
                    PlVol = WL_H * WL_B * WL_PT;
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

        // geting the Windows related wall data
        private void getWallData()
        {
            try
            {
                string Cmm = "Wl_Hight,Wl_Breadth,Wl_Length,Wl_Sand_Rat,Wl_Cement_Rat,Wl_Plstr,Wl_Pls_Length,Wl_Pls_Sand_Rat,";
                Cmm = Cmm + "Wl_Pls_Cement_Rat,Wl_Plstr_Side";

                string Qry = "select " + Cmm + " from Wall_Tab where Wl_Name ='" + WalName+ "';";
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


        // Bricks Count
        private int CountBricks(float TtVol)
        {
            int res = 0;
            float brickVol;
            brickVol = (float)(((Brk_len + 0.5) * (Brk_brd + 0.5) * (Brk_thick + 0.5)) / (12 * 12 * 12));

            res = Convert.ToInt32(TtVol / brickVol);
            return res;
        }

*/


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
