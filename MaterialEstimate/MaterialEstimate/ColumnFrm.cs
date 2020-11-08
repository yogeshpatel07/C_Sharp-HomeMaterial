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
    public partial class ColumnFrm : Form
    {
        //string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\MyHomeMaterial\\HomeDB.accdb;Persist Security Info=False";
        string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\DataBase\\HomeDB.accdb;Persist Security Info=False";

        Graphics g = null;
        Pen pn = null;
        int clmSx=0, clmSy=0, nmSx=0, nmSy=0,ClmNo=0;
        string clmName="Clm";
        float Brk_len, Brk_brd, Brk_thick,CmRdLen,CmRdThick, RgRdLen, RgRdThick,StnVl,SndVl,CmtVl;
        float Mt_Snd, Mt_Stn, Mt_Cmt, Mt_Rd, Mt_RRd;
        float lmHt, lmBd, lmLn, ptLn, ptBd, ptDp, ptMtk;

        private void ShowContorlBtn_Click(object sender, EventArgs e)
        {
            UpdateCanvas(clmName);
        }
        
        public ColumnFrm()
        {
            InitializeComponent();
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = "Status :  X = " + e.X + " , Y = " + e.Y;
        }

        private void txtClmPosTop_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtClmPosTop.Text);
                if (val < 0)
                {
                    MessageBox.Show("Column top position can\'t less than 0", "Error", MessageBoxButtons.OK);
                }
                else if (val > 655)
                {
                    MessageBox.Show("Column top position can\'t greater than 655", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    clmSy = val;
                    UpdateCanvas(clmName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Column top position can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void txtClmPosLeft_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtClmPosLeft.Text);
                if (val < 0)
                {
                    MessageBox.Show("Column left position can\'t less than 0", "Error", MessageBoxButtons.OK);
                }
                else if (val > 880)
                {
                    MessageBox.Show("Column left position can\'t greater than 880", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    clmSx = val;
                    UpdateCanvas(clmName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Column left position can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void txtNamePosTop_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtNamePosTop.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name top position can\'t less than 0", "Error", MessageBoxButtons.OK);
                }
                else if (val > 655)
                {
                    MessageBox.Show("Name top position can\'t greater than 655", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    nmSy = val;
                    UpdateCanvas(clmName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Name top position can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void txtNamePosLeft_Leave(object sender, EventArgs e)
        {

            try
            {
                int val = int.Parse(txtNamePosLeft.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name left position can\'t less than 0", "Error", MessageBoxButtons.OK);
                }
                else if (val > 880)
                {
                    MessageBox.Show("Name left position can\'t greater than 880", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    nmSx = val;
                    UpdateCanvas(clmName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Name left position can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void ColumnFrm_Load(object sender, EventArgs e)
        {
            g = picBox.CreateGraphics();
            pn = new Pen(Color.Black);
            
            if (HomeFrm.TodoType == "new")
            {
                txtClmPosLeft.Text = HomeFrm.SX.ToString();
                txtClmPosTop.Text = HomeFrm.SY.ToString();
                clmSx = HomeFrm.SX;
                clmSy = HomeFrm.SY;

                if (HomeFrm.SX<10)
                {
                    txtNamePosLeft.Text = (HomeFrm.SX + 10).ToString();
                    nmSx = HomeFrm.SX + 10;
                }
                else if(HomeFrm.SX>670)
                {
                    txtNamePosLeft.Text = (HomeFrm.SX - 10).ToString();
                    nmSx = HomeFrm.SX - 10;
                }
                else
                {
                    txtNamePosLeft.Text = (HomeFrm.SX).ToString();
                    nmSx = HomeFrm.SX;
                }

                if (HomeFrm.SY < 10)
                {
                    txtNamePosTop.Text = (HomeFrm.SY + 50).ToString();
                    nmSy = HomeFrm.SY + 50;
                }
                else
                {
                    txtNamePosTop.Text = (HomeFrm.SY - 10).ToString();
                    nmSy = HomeFrm.SY - 10;
                }

                ClmNo = getClmNo();
                clmName = "Clm" + ClmNo;
                UpdateCanvas(clmName);
                


            }

            if (HomeFrm.TodoType=="edit")
            {
                getEditClmData();

                clmSx = Convert.ToInt32(txtClmPosLeft.Text);
                clmSy = Convert.ToInt32(txtClmPosTop.Text);
                nmSx = Convert.ToInt32(txtNamePosLeft.Text);
                nmSy = Convert.ToInt32(txtNamePosTop.Text);
                

                UpdateCanvas(clmName);

            }

            ShowContorlBtn.Enabled = true;

        }

        private void rbYes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                txtBsLengthFt.Focus();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(isAllValid())
            {
                if((MessageBox.Show("Do you want to save data?", "Information", MessageBoxButtons.YesNo)==DialogResult.Yes))
                {
                    if(MaterialCount())
                    {
                        SaveData();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Can\'t save this data.\nMaterial calculation Error...", "Information", MessageBoxButtons.OK);
                    }
                }
            }
            
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNo.Checked==true)
            {
                BsPitBox.Visible = false;
            }
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked == true)
            {
                BsPitBox.Visible = true;
            }
        }


        // my Methods
        // function for check whether all data is ok or not 
        private bool isAllValid()
        {
            int val = 0;
            float val1 = 0;
            float tmp;
            // check Column Position top
            try
            {
                val = int.Parse(txtClmPosTop.Text);
                if (val < 0)
                {
                    MessageBox.Show("Column top position can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (val > 655)
                {
                    MessageBox.Show("Column top position can\'t greater than 655", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Column top position can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            // check Column Position left
            try
            {
                val = int.Parse(txtClmPosLeft.Text);
                if (val < 0)
                {
                    MessageBox.Show("Column Left position can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (val > 880)
                {
                    MessageBox.Show("Column Left position can\'t greater than 880", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Column Left position can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            // check Name Position top
            try
            {
                val = int.Parse(txtNamePosTop.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name top position can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (val > 655)
                {
                    MessageBox.Show("Name top position can\'t greater than 655", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Name top position can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            // check Column Position left
            try
            {
                val = int.Parse(txtNamePosLeft.Text);
                if (val < 0)
                {
                    MessageBox.Show("Name Left position can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (val > 880)
                {
                    MessageBox.Show("Name Left position can\'t greater than 880", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Name Left position can\'t be string  or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
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


            if (rbYes.Checked == true)
            {

                // Base Pit  Length
                try
                {

                    val = int.Parse(txtBsLengthFt.Text);
                    if (val < 0)
                    {
                        MessageBox.Show("Base pit length feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    tmp = val;

                    val = int.Parse(txtBsLengthIn.Text);
                    if (val > 11 || val < 0)
                    {
                        MessageBox.Show("Base pit length inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    ptLn = Convert.ToSingle(val) / 12 + tmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Base pit length feet  or inch value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }

                // Base Pit Breadth
                try
                {
                    val = int.Parse(txtBsBreadthFt.Text);
                    if (val < 0)
                    {
                        MessageBox.Show("Base pit width feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    tmp = val;

                    val = int.Parse(txtBsBreadthIn.Text);
                    if (val > 11 || val < 0)
                    {
                        MessageBox.Show("Base pit width inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    ptBd = Convert.ToSingle(val) / 12 + tmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Base pit width feet or inch value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }

                // Base Pit  Depth
                try
                {
                    val = int.Parse(txtBsDepthFt.Text);
                    if (val < 0)
                    {
                        MessageBox.Show("Base pit depth feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    tmp = val;

                    val = int.Parse(txtBsDepthIn.Text);
                    if (val > 11 || val < 0)
                    {
                        MessageBox.Show("Base pit depth inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    ptDp = Convert.ToSingle(val) / 12 + tmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Base pit depth feet or inch value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }

                // Base Pit Material Thickness
                try
                {
                    val = int.Parse(txtBsMatThickFt.Text);
                    if (val < 0)
                    {
                        MessageBox.Show("Base pit Material Thickness feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    tmp = val;

                    val = int.Parse(txtBsMatThickIn.Text);
                    if (val > 11 || val < 0)
                    {
                        MessageBox.Show("Base pit Material Thickness inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    ptMtk = Convert.ToSingle(val) / 12 + tmp;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Base pit Material Thickness feet or inch value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }

            }

            // Column Length
            try
            {
                val = int.Parse(txtClmLengthFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Column width feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtClmLengthIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Column width inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                lmLn = Convert.ToSingle(val) / 12 + tmp;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Column width feet or inch value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // Base Pit Breadth
            try
            {
                val = int.Parse(txtClmBreadthFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Column thickness feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtClmBreadthIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Column thickness inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                lmBd = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Column thickness feet or inch value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // Base Pit Height
            try
            {
                val = int.Parse(txtClmHeightFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Column height feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtClmHeightIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Column height inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                lmHt = Convert.ToSingle(val) / 12 + tmp;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Column height feet or inch value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;

        }

        // function for Redraw controls 
        private void UpdateCanvas(string Exp = "none")
        {
            g.Clear(picBox.BackColor);

            ShowBase(Exp);
            ShowColumns(Exp);
            ShowBeams(Exp);
            ShowWinAndDoors(Exp);
            ShowWalls(Exp);
            ShowRoof(Exp);
            
            g.FillRectangle(new SolidBrush(Color.Red),clmSx,clmSy,10,10);
            g.DrawString(clmName, HomeFrm.fnt, new SolidBrush(Color.Red), nmSx,nmSy);

        }

        // function for for get maximum column number
        private int getClmNo()
        {
            int re = 1;
            try
            {
                string Qry = "select max(Clm_No) from Column_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        re = Dr.GetInt32(0)+1;
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
                int ftv=0, incv=0;
                float FtinV=0;
                string Qry = "select * from Column_Tab where Clm_Name ='" + HomeFrm.EdtCntrl+ "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        clmName = Dr.GetString(1);
                        txtClmPosLeft.Text = Dr.GetInt16(2).ToString();
                        txtClmPosTop.Text = Dr.GetInt16(3).ToString();
                        txtNamePosLeft.Text = Dr.GetInt16(6).ToString();
                        txtNamePosTop.Text = Dr.GetInt16(7).ToString();

                        FtinV = Dr.GetFloat(8);
                        FtToIn(FtinV, out ftv, out incv);
                        txtClmHeightFt.Text = ftv.ToString();
                        txtClmHeightIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(9);
                        FtToIn(FtinV, out ftv, out incv);
                        txtClmBreadthFt.Text = ftv.ToString();
                        txtClmBreadthIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(10);
                        FtToIn(FtinV, out ftv, out incv);
                        txtClmLengthFt.Text = ftv.ToString();
                        txtClmLengthIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(11);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBsDepthFt.Text = ftv.ToString();
                        txtBsDepthIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(12);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBsBreadthFt.Text = ftv.ToString();
                        txtBsBreadthIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(13);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBsLengthFt.Text = ftv.ToString();
                        txtBsLengthIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(14);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBsMatThickFt.Text = ftv.ToString();
                        txtBsMatThickIn.Text = incv.ToString();

                        txtSand.Text = Dr.GetFloat(15).ToString();
                        txtStone.Text = Dr.GetFloat(16).ToString();
                        txtCement.Text = Dr.GetFloat(17).ToString();
                        txtRods.Text = Dr.GetInt16(18).ToString();

                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can\'t load all edit column data\n "+ex.Message,"Error",MessageBoxButtons.OK);
            }
        }

        // function for Calculate Material if any error return false
        private bool MaterialCount()
        {
            try
            {
                getCalData();
                
                // filds for get data
                float cHit, cBred, cLen;
                float sandRt, stoneRt, cmtRt,totRt;
                float bsPLen, bsPBred, bsPDep, bsPMatTk;
                float rgrdvol, clmrdvol,TtRdVl;
                float ColVol, BsVol, TotVol;
                double bsRd,clmRd=0, clmSd=0, clmCmt=0, clmStn=0,TotCmRd=0,TotRgRd=0;
                double St_trc=0, Sd_trc=0, Cmt_sk=0;
                int NoRg, NoRd;

                cHit = Convert.ToSingle(txtClmHeightFt.Text) + (Convert.ToSingle(txtClmHeightIn.Text) / 12);
                cBred = Convert.ToSingle(txtClmBreadthFt.Text) + (Convert.ToSingle(txtClmBreadthIn.Text) / 12);
                cLen = Convert.ToSingle(txtClmLengthFt.Text) + (Convert.ToSingle(txtClmLengthIn.Text) / 12);
                sandRt = Convert.ToSingle(txtSand.Text);
                stoneRt = Convert.ToSingle(txtStone.Text);
                cmtRt = Convert.ToSingle(txtCement.Text);
                NoRd = Convert.ToInt32(txtRods.Text);
                totRt = sandRt + stoneRt + cmtRt;

                if (rbYes.Checked==true)
                {
                    bsPDep = Convert.ToSingle(txtBsDepthFt.Text) + (Convert.ToSingle(txtBsDepthIn.Text) / 12);
                    bsPBred = Convert.ToSingle(txtBsBreadthFt.Text) + (Convert.ToSingle(txtBsBreadthIn.Text) / 12);
                    bsPLen = Convert.ToSingle(txtBsLengthFt.Text) + (Convert.ToSingle(txtBsLengthIn.Text) / 12);
                    bsPMatTk = Convert.ToSingle(txtBsMatThickFt.Text) + (Convert.ToSingle(txtBsMatThickIn.Text) / 12);

                    ColVol = cHit * cLen * cBred;
                    BsVol = (bsPLen * bsPBred * bsPMatTk) - (cLen * cBred * bsPMatTk);
                    TotVol = ColVol + BsVol;
                    bsRd = (bsPLen * 2 *bsPBred) + (bsPBred * 2 * bsPLen);
                    clmRd = (cHit + bsPDep + 1)*NoRd;
                    NoRg = Convert.ToInt32((cHit + bsPDep + 1) * 12 / 9);
                    TotRgRd =(2*cLen+2*cBred+0.5)*NoRg; //total ring rod
                    TotCmRd = clmRd + bsRd;             //toal Clm rod
                    clmrdvol = (float)((22*CmRdThick * CmRdThick * TotCmRd)/(7 * 12 * 12));
                    rgrdvol= (float)((22 * RgRdThick * RgRdThick * TotRgRd) / (7 * 12 * 12));
                    TtRdVl = clmrdvol + rgrdvol;
                    TotVol = TotVol - TtRdVl;

                    clmSd = (TotVol * sandRt) / totRt;  //total sand
                    clmStn = (TotVol * stoneRt) / totRt;    //total stone
                    clmCmt = (TotVol * cmtRt) / totRt;  //total cement

                    Sd_trc = clmSd / SndVl;
                    St_trc = clmStn / StnVl;
                    Cmt_sk = clmCmt / CmtVl;
                }

                if (rbNo.Checked == true)
                {
                    ColVol = cHit * cLen * cBred;
                    TotVol = ColVol;
                    clmRd = (cHit  + 1) * NoRd;
                    NoRg = Convert.ToInt32((cHit + 1) * 12 / 9);
                    TotRgRd = (2 * cLen + 2 * cBred + 0.5) * NoRg; //total ring rod
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
                }

                Mt_Snd = (float)(clmSd);
                Mt_Stn = (float)(clmStn);
                Mt_Cmt = (float)(clmCmt);
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

        // function for get data for Material calculation
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
                            Brk_thick= prp_val;
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

        // function for Saving or Updating Data
        private void SaveData()
        {
            try
            {
                
                string Clms_Val = "";
                string Clms_Name = "";
                string Qry = "";
                if (HomeFrm.TodoType == "new")
                {
                    Clms_Name = "Clm_No,Clm_Name,Clm_SX,Clm_SY,Clm_Wi,Clm_Hi,Clm_Nm_X,Clm_Nm_Y,Clm_Hight,Clm_Breadth,Clm_Length,";
                    Clms_Name = Clms_Name + "Clm_Pit_Depth,Clm_Pit_Breadth,Clm_Pit_Length,Clm_Pit_Mat_Thick,Clm_Sand_Rat,Clm_Stone_Rat,";
                    Clms_Name = Clms_Name + "Clm_Cement_Rat,Clm_NoRod,Clm_Mat_Sand,Clm_Mat_Stone,Clm_Mat_Cement,Clm_Mat_NRod,Clm_Mat_RRod ";
                    

                    if (rbYes.Checked == true)
                    {
                        Clms_Val = ClmNo + ",'" + clmName + "'," + txtClmPosLeft.Text + "," + txtClmPosTop.Text + ",10,10," + txtNamePosLeft.Text;
                        Clms_Val = Clms_Val + "," + txtNamePosTop.Text + "," + lmHt + "," + lmBd + "," + lmLn + "," + ptDp + "," + ptBd + ",";
                        Clms_Val = Clms_Val + ptLn + "," + ptMtk + "," + txtSand.Text + "," + txtStone.Text + "," + txtCement.Text + ",";
                        Clms_Val = Clms_Val + txtRods.Text + "," + Mt_Snd + "," + Mt_Stn + "," + Mt_Cmt + "," + Mt_Rd + "," + Mt_RRd;
                    }
                    else
                    {
                        Clms_Val = ClmNo + ",'" + clmName + "'," + txtClmPosLeft.Text + "," + txtClmPosTop.Text + ",10,10," + txtNamePosLeft.Text;
                        Clms_Val = Clms_Val + "," + txtNamePosTop.Text + "," + lmHt + "," + lmBd + "," + lmLn + ",0,0,0,0," + txtSand.Text + ",";
                        Clms_Val = Clms_Val + txtStone.Text + "," + txtCement.Text + "," + txtRods.Text + "," + Mt_Snd + "," + Mt_Stn + ",";
                        Clms_Val = Clms_Val + Mt_Cmt + "," + Mt_Rd + "," + Mt_RRd;
                        
                    }
                    Qry = "insert into Column_Tab(" + Clms_Name + ") values(" + Clms_Val + ");";
                }
                if (HomeFrm.TodoType == "edit")
                {
                    if (rbYes.Checked == true)
                    {
                        Clms_Name = "Clm_SX=" + txtClmPosLeft.Text + ",Clm_SY=" + txtClmPosTop.Text + ",Clm_Nm_X=" + txtNamePosLeft.Text;
                        Clms_Name = Clms_Name + " ,Clm_Nm_Y=" + txtNamePosTop.Text + ",Clm_Hight=" + lmHt + ",Clm_Breadth=" + lmBd;
                        Clms_Name = Clms_Name + ",Clm_Length=" + lmLn + ",Clm_Pit_Depth=" + ptDp + ",Clm_Pit_Breadth=" + ptBd;
                        Clms_Name = Clms_Name + ",Clm_Pit_Length=" + ptLn + ",Clm_Pit_Mat_Thick=" + ptMtk + ",Clm_Sand_Rat=";
                        Clms_Name = Clms_Name + txtSand.Text + ",Clm_Stone_Rat=" + txtStone.Text + ",Clm_Cement_Rat=" + txtCement.Text;
                        Clms_Name = Clms_Name + ",Clm_NoRod=" + txtRods.Text + ",Clm_Mat_Sand=" + Mt_Snd + ",Clm_Mat_Stone=" + Mt_Stn+ ",";
                        Clms_Name = Clms_Name + "Clm_Mat_Cement=" + Mt_Cmt + ",Clm_Mat_NRod=" + Mt_Rd + ",Clm_Mat_RRod=" + Mt_RRd;
                        
                    }
                    else
                    {
                        Clms_Name = "Clm_SX=" + txtClmPosLeft.Text + ",Clm_SY=" + txtClmPosTop.Text + ",Clm_Nm_X=" + txtNamePosLeft.Text;
                        Clms_Name = Clms_Name + " ,Clm_Nm_Y=" + txtNamePosTop.Text + ",Clm_Hight=" + lmHt + ",Clm_Breadth=" + lmBd;
                        Clms_Name = Clms_Name + ",Clm_Length=" + lmLn + ",Clm_Pit_Depth=0,Clm_Pit_Breadth=0,Clm_Pit_Length=0,Clm_Pit_Mat_Thick=0";
                        Clms_Name = Clms_Name + ",Clm_Sand_Rat="+ txtSand.Text + ",Clm_Stone_Rat=" + txtStone.Text + ",Clm_Cement_Rat=" + txtCement.Text;
                        Clms_Name = Clms_Name + ",Clm_NoRod=" + txtRods.Text + ",Clm_Mat_Sand=" + Mt_Snd + ",Clm_Mat_Stone=" + Mt_Stn + ",";
                        Clms_Name = Clms_Name + "Clm_Mat_Cement=" + Mt_Cmt + ",Clm_Mat_NRod=" + Mt_Rd + ",Clm_Mat_RRod=" + Mt_RRd;

                    }
                    Qry= "Update Column_Tab Set "+Clms_Name+ " where Clm_Name='"+clmName+"';";
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
            catch(Exception ex)
            {
                MessageBox.Show("Data Not Saved...\n"+ex.Message, "Error", MessageBoxButtons.OK);
            }
            
        }

        //function for decompose float Feet value into int feet and int Inche values
        private void FtToIn(float FtInVl,out int  FtVl,out int InVl)
        {
            float tmp;
            FtVl=Convert.ToInt32(Math.Floor(FtInVl));
            tmp = FtInVl - FtVl;
            tmp =(tmp * 12);
            InVl = Convert.ToInt32(Math.Round(tmp,0));

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
                Pen mypn = new Pen(Color.Purple,5);
                
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
