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
    public partial class WallFrm : Form
    {
        //string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\MyHomeMaterial\\HomeDB.accdb;Persist Security Info=False";
        string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\DataBase\\HomeDB.accdb;Persist Security Info=False";


        Graphics g = null;
        Pen pn = null;
        
        Dictionary<string,float> BmsHit = null;

        int WlSx = 0, WlSy = 0, WlEx = 0, WlEy = 0, nmSx = 0, nmSy = 0, WlNo = 0;
        float WlH = 0, WlL = 0, WlB = 0;
        float MtSndRt = 0, MtCmtRt = 0, MtPlTk = 0, MtPlSndRt = 0, MtPlCmtRt = 0;

        float TotSlBmHt = 0;

        string WlName = "Wal";
        float Mt_Snd, Mt_Cmt, Mt_SndTrc, Mt_CmtSk;
        int Mt_Brick;    //val for mat data
        float Brk_len, Brk_brd, Brk_thick, CmRdLen, CmRdThick, RgRdLen, RgRdThick, StnVl, SndVl, CmtVl;     //var for mat calc

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isAllValid())
            {
                if ((MessageBox.Show("Do you want to save data?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    if (MaterialCount())
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
            if (rbNo.Checked == true)
                PlstMatBox.Visible = false;
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked == true)
                PlstMatBox.Visible = true;
        }

        private void RmvAllBmsBtn_Click(object sender, EventArgs e)
        {
            lstBms.Items.Clear();
            TotSlBmHt = 0;
        }

        private void RmvBmsBtn_Click(object sender, EventArgs e)
        {
            if (cmbBms.Text.Trim() != "")
            {
                lstBms.Items.Remove(cmbBms.Text);
                float bmht = 0;
                if (BmsHit.TryGetValue(cmbBms.Text, out bmht))
                {
                    TotSlBmHt = TotSlBmHt - bmht;
                }
            }


        }

        private void AddBmsBtn_Click(object sender, EventArgs e)
        {
            if(cmbBms.Text.Trim()!="")
            {
                if(lstBms.Items.Contains(cmbBms.Text)==false)
                {
                    lstBms.Items.Add(cmbBms.Text);
                    float bmht = 0;
                    if(BmsHit.TryGetValue(cmbBms.Text,out bmht))
                    {
                        TotSlBmHt = TotSlBmHt + bmht;
                    }
                    
                }
            }
                
        }
        
        private void ShowContorlBtn_Click(object sender, EventArgs e)
        {
            UpdateCanvas(WlName);
        }
        
        private void WallFrm_Load(object sender, EventArgs e)
        {
            g = picBox.CreateGraphics();
            pn = new Pen(Color.Black, 5);
            cmbBreadth.Text = "0.33";
            getBeamsList();

            if (HomeFrm.TodoType == "new")
            {
                WlNo = getWallNo();
                WlName = WlName + WlNo;

                txtStartX.Text = HomeFrm.SX.ToString();
                txtStartY.Text = HomeFrm.SY.ToString();
                txtEndX.Text = HomeFrm.EX.ToString();
                txtEndY.Text = HomeFrm.EY.ToString();

                WlSx = HomeFrm.SX;
                WlSy = HomeFrm.SY;
                WlEx = HomeFrm.EX;
                WlEy = HomeFrm.EY;

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
                    nmSy = HomeFrm.SX + 50;

                }
                else
                {
                    txtNmY.Text = (HomeFrm.SY - 10).ToString();
                    nmSy = HomeFrm.SY - 10;
                }

                UpdateCanvas(WlName);
            }

            if (HomeFrm.TodoType == "edit")
            {
                getEditWallData();
                getEditWallBeamDate();

                WlSx = Convert.ToInt32(txtStartX.Text);
                WlSy = Convert.ToInt32(txtStartY.Text);
                WlEx = Convert.ToInt32(txtEndX.Text);
                WlEy = Convert.ToInt32(txtEndY.Text);
                nmSx = Convert.ToInt32(txtNmX.Text);
                nmSy = Convert.ToInt32(txtNmY.Text);


                UpdateCanvas(WlName);
            }

            ShowContorlBtn.Enabled = true;
        }

        public WallFrm()
        {
            InitializeComponent();
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = "Status :  X = " + e.X + " , Y = " + e.Y;
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
                    WlSx = val;
                    UpdateCanvas(WlName);
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
                    WlSy = val;
                    UpdateCanvas(WlName);
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
                    WlEx = val;
                    UpdateCanvas(WlName);
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
                    WlEy = val;
                    UpdateCanvas(WlName);
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
                    UpdateCanvas(WlName);
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
                    UpdateCanvas(WlName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        

        // my functions
        private bool isAllValid()
        {
            int val = 0;
            float val1 = 0;
            float tmp;

            WlB = Convert.ToSingle(cmbBreadth.Text);
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
                    WlSx = val;

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
                    WlSy = val;
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
                    WlEx = val;

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
                    WlEy = val;
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

                val = int.Parse(txtWlHeightFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Wall Hight feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtWlHeightIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Wall Hight inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                WlH = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wall Hight can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // Beam Length 
            try
            {

                val = int.Parse(txtWlLengthFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Wall Length feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtWlLengthIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Wall Length inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                WlL = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wall Length can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
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
                else
                {
                    MtSndRt = val1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sand ratio can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
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
                else
                {
                    MtCmtRt = val1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cement ratio can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            
            if(rbYes.Checked==true)
            {
                // Plaster Sand Ratio
                try
                {
                    val1 = float.Parse(txtPlstSand.Text);
                    if (val1 < 0)
                    {
                        MessageBox.Show("Plaster Sand ratio can\'t less than 0", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    else
                    {
                        MtPlSndRt = val1;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Plaster Sand ratio can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }

                // Cement Ratio
                try
                {
                    val1 = float.Parse(txtPlstCement.Text);
                    if (val1 < 0)
                    {
                        MessageBox.Show("Plaster Cement ratio can\'t less than 0", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    else
                    {
                        MtPlCmtRt = val1;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Plaster Cement ratio can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }

                // Cement Ratio
                try
                {
                    val1 = float.Parse(txtPlstTk.Text);
                    if (val1 < 0)
                    {
                        MessageBox.Show("Plaster Thickness can\'t less than 0", "Error", MessageBoxButtons.OK);
                        return false;
                    }
                    else
                    {
                        MtPlTk = val1;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Plaster thickness ratio can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }
            }


            return true;

        }
        // for  get the maximun Wall Number
        private int getWallNo()
        {
            int re = 1;
            try
            {
                string Qry = "select max(Wl_No) from Wall_Tab;";
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
        private void getBeamsList()
        {
            try
            {
                BmsHit = new Dictionary<string, float>();

                string Qry = "select Bm_Name,Bm_Hight from Beam_Tab;";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        cmbBms.Items.Add(Dr.GetString(0));
                        BmsHit.Add(Dr.GetString(0), Dr.GetFloat(1));

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

                // feilds for get data
                float BmVol, TotVol,WlVol,PlVol;
                float WlSnd, WlCmt, PlSnd, PlCmt;
                
                float WnDrVol = getWinDrVol();

                WlVol = WlH * WlL * WlB;
                BmVol = TotSlBmHt * WlL * WlB;

                if (WlVol <= (BmVol + WnDrVol))
                {
                    MessageBox.Show("Can\'t save this data\n This wall\'s component data is bigger than this data.", "Error", MessageBoxButtons.OK);
                    return false;
                }

                TotVol = WlVol - (BmVol + WnDrVol);

                Mt_Brick = CountBricks(TotVol); // total bricks

                TotVol = TotVol -(Mt_Brick*((Brk_len*Brk_brd*Brk_thick) / (12 * 12 * 12)));

                WlSnd = (TotVol * MtSndRt) / (MtSndRt+ MtCmtRt);
                WlCmt = (TotVol * MtCmtRt) / (MtSndRt + MtCmtRt);

                Mt_Snd = WlSnd;
                Mt_Cmt = WlCmt;

                if(rbYes.Checked==true)
                {
                    PlVol = (TotVol * (MtPlTk / 12)) / WlB;

                    if (rbBoth.Checked == true)
                    {
                        PlVol = 2 * PlVol;
                    }

                    PlSnd = (PlVol * MtPlSndRt) / (MtPlSndRt + MtPlCmtRt);
                    PlCmt = (PlVol * MtPlCmtRt) / (MtPlSndRt + MtPlCmtRt);
                    Mt_Snd = Mt_Snd + PlSnd;
                    Mt_Cmt = Mt_Cmt + PlCmt;
                }
                Mt_SndTrc = Mt_Snd / SndVl;
                Mt_CmtSk = Mt_Cmt / CmtVl;

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
            brickVol = (float)(((Brk_len+0.5)*(Brk_brd+0.5)*(Brk_thick+0.5))/(12*12*12));

            res =Convert.ToInt32(TtVol / brickVol);
            return res;
        }

        // geting the total volume of Windows
        private float getWinDrVol()
        {
            float vl = 0;
            float WiDH, WiDL;
            try
            {
                string Qry = "select Win_Height,Win_Length from Window_Tab where Win_WallName='" + WlName + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        WiDH = Dr.GetFloat(0);
                        WiDL = Dr.GetFloat(1);
                        vl = vl + (WlB * WiDH * WiDL);

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


        //For saving and updating data
        private void SaveData()
        {
            try
            {

                string Clms_Val = "";
                string Clms_Name = "";
                string PlSid = "One";
                int rv = 0;
                float bmTk = 0;
                string Qry = "delete from Wall_Beam where WL_Name='"+WlName+"';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();

                rv = cmd.ExecuteNonQuery();

                // for saving beam_wall relation

                var keys = BmsHit.Keys.ToList();
                foreach(var key in keys)
                {
                    if(lstBms.Items.Contains(key))
                    {
                        if(BmsHit.TryGetValue(key, out bmTk) == true)
                        {
                            Qry = "insert into Wall_Beam(Com_Name, WL_Name,Bm_Thick) values('" + key.ToString() + "','" + WlName + "'," + bmTk + ");";
                            cmd.CommandText = Qry;
                            rv = cmd.ExecuteNonQuery();
                        }
                    }
                        
                }

                Qry = "delete from Wall_Tab where Wl_Name='" + WlName + "';";
                cmd.CommandText = Qry;
                rv = cmd.ExecuteNonQuery();

                if (rbBoth.Checked==true)
                {
                    PlSid = "Both";
                }

                
                if (rbYes.Checked == true)
                {
                    Clms_Name = "Wl_No,Wl_Name,Wl_SX,Wl_SY,Wl_EX,Wl_EY,Wl_Nm_X,Wl_Nm_Y,Wl_Hight,Wl_Breadth,Wl_Length,Wl_Sand_Rat,";
                    Clms_Name = Clms_Name + "Wl_Cement_Rat,Wl_Plstr,Wl_Pls_Length,Wl_Pls_Sand_Rat,Wl_Pls_Cement_Rat,Wl_Plstr_Side,";
                    Clms_Name = Clms_Name + "Wl_Mat_Sand,Wl_Mat_Cement,Wl_Mat_Bricks";

                    Clms_Val = WlNo + ",'" + WlName + "'," + txtStartX.Text + "," + txtStartY.Text + "," + txtEndX.Text + "," + txtEndY.Text + ",";
                    Clms_Val = Clms_Val + txtNmX.Text + "," + txtNmY.Text + "," + WlH + "," + WlB + "," + WlL + "," + txtSand.Text + ",";
                    Clms_Val = Clms_Val +  txtCement.Text + "," + true + "," + MtPlTk + "," + MtPlSndRt + "," + MtPlCmtRt + ",'";
                    Clms_Val = Clms_Val + PlSid + "'," + Mt_Snd + "," + Mt_Cmt + "," + Mt_Brick;
                }
                else
                {
                    Clms_Name = "Wl_No,Wl_Name,Wl_SX,Wl_SY,Wl_EX,Wl_EY,Wl_Nm_X,Wl_Nm_Y,Wl_Hight,Wl_Breadth,Wl_Length,Wl_Sand_Rat,";
                    Clms_Name = Clms_Name + "Wl_Cement_Rat,Wl_Mat_Sand,Wl_Mat_Cement,Wl_Mat_Bricks";

                    Clms_Val = WlNo + ",'" + WlName + "'," + txtStartX.Text + "," + txtStartY.Text + "," + txtEndX.Text + "," + txtEndY.Text + ",";
                    Clms_Val = Clms_Val + txtNmX.Text + "," + txtNmY.Text + "," + WlH + "," + WlB + "," + WlL + "," + txtSand.Text + ",";
                    Clms_Val = Clms_Val  + txtCement.Text + "," + Mt_Snd + "," + Mt_Cmt + "," + Mt_Brick;
                }

                Qry = "insert into Wall_Tab(" + Clms_Name + ") values(" + Clms_Val + ");";

                cmd.CommandText = Qry;
                rv = cmd.ExecuteNonQuery();
                
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

        private void getEditWallBeamDate()
        {
            try
            {
                string LBmN;
                float bmwid;
                string Qry = "select * from Wall_Beam where WL_Name ='" + HomeFrm.EdtCntrl + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        LBmN = Dr.GetString(0);
                        bmwid = Dr.GetFloat(2);

                       if(cmbBms.Items.Contains(LBmN))
                       {
                            lstBms.Items.Add(LBmN);
                            TotSlBmHt =TotSlBmHt + bmwid;
                       }

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
        }

        private void getEditWallData()
        {
            try
            {
                int ftv = 0, incv = 0;
                float FtinV = 0;
                string Qry = "select * from Wall_Tab where Wl_Name ='" + HomeFrm.EdtCntrl + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        WlNo = Dr.GetInt32(0);
                        WlName = Dr.GetString(1);
                        txtStartX.Text = Dr.GetInt16(2).ToString();
                        txtStartY.Text = Dr.GetInt16(3).ToString();
                        txtEndX.Text = Dr.GetInt16(4).ToString();
                        txtEndY.Text = Dr.GetInt16(5).ToString();
                        txtNmX.Text = Dr.GetInt16(6).ToString();
                        txtNmY.Text = Dr.GetInt16(7).ToString();

                        FtinV = Dr.GetFloat(8);
                        FtToIn(FtinV, out ftv, out incv);
                        txtWlHeightFt.Text = ftv.ToString();
                        txtWlHeightIn.Text = incv.ToString();

                        cmbBreadth.Text = Dr.GetFloat(9).ToString();
                        
                        FtinV = Dr.GetFloat(10);
                        FtToIn(FtinV, out ftv, out incv);
                        txtWlLengthFt.Text = ftv.ToString();
                        txtWlLengthIn.Text = incv.ToString();


                        txtSand.Text = Dr.GetFloat(11).ToString();
                        txtCement.Text = Dr.GetFloat(12).ToString();
                        bool Pls = Dr.GetBoolean(13);
                        if(Pls==true)
                        {
                            txtPlstTk.Text = Dr.GetFloat(14).ToString();
                            txtPlstSand.Text = Dr.GetFloat(15).ToString();
                            txtPlstCement.Text = Dr.GetFloat(16).ToString();
                            string Sides = Dr.GetString(17);
                            if(Sides=="One")
                            {
                                rbOne.Checked = true;
                            }
                            else
                            {
                                rbBoth.Checked = true;
                            }
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
                MessageBox.Show("Can\'t load all edit wall data.\n"+ex.Message, "Error", MessageBoxButtons.OK);
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

            pn = new Pen(Color.Red, 5);
            g.DrawLine(pn, WlSx, WlSy, WlEx, WlEy);
            g.DrawString(WlName, HomeFrm.fnt, new SolidBrush(Color.Red), nmSx, nmSy);

        }

        private void FtToIn(float FtInVl, out int FtVl, out int InVl)
        {
            float tmp;
            FtVl = Convert.ToInt32(Math.Floor(FtInVl));
            tmp = FtInVl - FtVl;
            tmp = (tmp * 12);
            InVl = Convert.ToInt32(Math.Round(tmp, 0));

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
