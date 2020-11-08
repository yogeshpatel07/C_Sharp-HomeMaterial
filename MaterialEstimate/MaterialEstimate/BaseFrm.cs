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
    public partial class BaseFrm : Form
    {
        //string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\MyHomeMaterial\\HomeDB.accdb;Persist Security Info=False";
        string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\DataBase\\HomeDB.accdb;Persist Security Info=False";

        Graphics g = null;
        Pen pn = null;
        int BsSx = 0, BsSy = 0, BsEx = 0, BsEy = 0, nmSx = 0, nmSy = 0, BsNo = 0;
        string BsName = "BS";
        float BsW, BsL, BsT,BsSdR,BsStR,BsCmtR;
        float Mt_Snd, Mt_Stn, Mt_Cmt;

        public BaseFrm()
        {
            InitializeComponent();
        }

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

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = "Status :  X = " + e.X + " , Y = " + e.Y;
        }

        private void ShowContorlBtn_Click(object sender, EventArgs e)
        {
            UpdateCanvas(BsName);
        }

        private void BaseFrm_Load(object sender, EventArgs e)
        {
            g = picBox.CreateGraphics();
            pn = new Pen(Color.Black, 5);

            if (HomeFrm.TodoType == "new")
            {
                BsNo = getBaseNo();
                BsName = BsName + BsNo;

                txtStartX.Text = HomeFrm.SX.ToString();
                txtStartY.Text = HomeFrm.SY.ToString();
                txtWidth.Text = Math.Abs(HomeFrm.EX - HomeFrm.SX).ToString();
                txtHeight.Text = Math.Abs(HomeFrm.EY - HomeFrm.SY).ToString();

                BsSx = HomeFrm.SX;
                BsSy = HomeFrm.SY;
                BsEx = Math.Abs(HomeFrm.EX - HomeFrm.SX);
                BsEy = Math.Abs(HomeFrm.EY - HomeFrm.SY);

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

                UpdateCanvas(BsName);
            }

            if (HomeFrm.TodoType == "edit")
            {
                getEditBaseData();

                BsSx=Convert.ToInt32(txtStartX.Text);
                BsSy = Convert.ToInt32(txtStartY.Text);
                BsEx = Convert.ToInt32(txtWidth.Text);
                BsEy = Convert.ToInt32(txtHeight.Text);
                nmSx = Convert.ToInt32(txtNmX.Text);
                nmSy = Convert.ToInt32(txtNmY.Text);
                

                UpdateCanvas(BsName);
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
                    BsSx = val;
                    UpdateCanvas(BsName);
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
                    BsSy = val;
                    UpdateCanvas(BsName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtWidth_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtWidth.Text);
                if (val < 0)
                {
                    MessageBox.Show("Position Width value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 880)
                {
                    MessageBox.Show("Position Width value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    BsEx = val;
                    UpdateCanvas(BsName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(txtHeight.Text);
                if (val < 0)
                {
                    MessageBox.Show("Position Height value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                }
                else if (val > 655)
                {
                    MessageBox.Show("Position Height can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    BsEy = val;
                    UpdateCanvas(BsName);
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
                    UpdateCanvas(BsName);
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
                    UpdateCanvas(BsName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("this value is not valid", "Error", MessageBoxButtons.OK);
            }
        }


        //my Methods
        // for checking all Inputs are valid or not 
        private bool isAllValid()
        {
            int val = 0;
            float val1 = 0;
            float tmp;

            // check Position Start X
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
                    BsSx = val;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Start X value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Position Start Y
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
                    BsSy = val;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Start Y value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Position End X
            try
            {
                val = int.Parse(txtWidth.Text);
                if (val < 0)
                {
                    MessageBox.Show("Position Width value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 880)
                {
                    MessageBox.Show("Position Width value can\'t be can\'t greater than 880", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    BsEx = val;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Position Width value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Position End Y
            try
            {
                val = int.Parse(txtHeight.Text);
                if (val < 0)
                {
                    MessageBox.Show("Position Height value can\'t be less than 0", "Information", MessageBoxButtons.OK);
                    return false;
                }
                else if (val > 655)
                {
                    MessageBox.Show("Position Height value can\'t be can\'t greater than 655", "Error", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    BsEy = val;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Position Height value can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }


            // check Name X
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

            // check Name Y
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



            // Beam thickness 
            try
            {

                val = int.Parse(txtBSThickFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Base Thickness feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtBSThickIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Base Thickness inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                BsT = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base Thickness can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // Beam Length 
            try
            {

                val = int.Parse(txtBSLengthFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Base Length feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtBSLengthIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Base Length inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                BsL = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base Length can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // Beam Breadth
            try
            {

                val = int.Parse(txtBSWidthFt.Text);
                if (val < 0)
                {
                    MessageBox.Show("Base Width feet value can\'t be less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
                tmp = val;

                val = int.Parse(txtBSWidthIn.Text);
                if (val > 11 || val < 0)
                {
                    MessageBox.Show("Base Width inch value can\'t be less than 0\nor greater than 11", "Error", MessageBoxButtons.OK);
                    return false;
                }
                BsW = Convert.ToSingle(val) / 12 + tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base Width can\'t be string or float type\n" + ex.Message, "Error", MessageBoxButtons.OK);
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
                BsSdR = val1;
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
                BsStR = val1;
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
                BsCmtR = val1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cement ratio can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
            

            return true;

        }

        // for  get the maximun Beam Number
        private int getBaseNo()
        {
            int re = 1;
            try
            {
                string Qry = "select max(BS_No) from Base_Tab;";
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
            
            g.DrawRectangle(pn, BsSx, BsSy,BsEx, BsEy);
            g.DrawString(BsName, HomeFrm.fnt, new SolidBrush(Color.Red), nmSx, nmSy);

        }

        // for material Calculation return false if any error
        private bool MaterialCount()
        {
            try
            {
                float BSVol;
                BSVol = BsL * BsW * BsT;
                Mt_Snd = (BSVol * BsSdR) / (BsStR + BsSdR + BsCmtR);
                Mt_Stn = (BSVol * BsStR) / (BsStR + BsSdR + BsCmtR);
                Mt_Cmt = (BSVol * BsCmtR) / (BsStR + BsSdR + BsCmtR);

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
                    Clms_Name = "BS_No,BS_Name,BS_SX,BS_SY,BS_Wi,BS_Hi,BS_NX,BS_NY,BS_Length,BS_Width,BS_Thick,BS_Sand_Rat,";
                    Clms_Name = Clms_Name + "BS_Stone_Rat,BS_Cement_Rat,BS_Mat_Sand,BS_Mat_Stone,BS_Mat_Cement";
                    
                    Clms_Val = BsNo + ",'" + BsName + "'," + txtStartX.Text + "," + txtStartY.Text + "," + txtWidth.Text + "," + txtHeight.Text + ",";
                    Clms_Val = Clms_Val + txtNmX.Text + "," + txtNmY.Text + "," + BsL + "," + BsW + "," + BsT + "," + txtSand.Text + ",";
                    Clms_Val = Clms_Val + txtStone.Text + "," + txtCement.Text + "," + Mt_Snd + "," + Mt_Stn + "," + Mt_Cmt;
                   
                    Qry = "insert into Base_Tab(" + Clms_Name + ") values(" + Clms_Val + ");";
                }
                if (HomeFrm.TodoType == "edit")
                {
                    Clms_Name = "BS_SX=" + txtStartX.Text + ",BS_SY=" + txtStartY.Text + ",BS_Wi=" + txtWidth.Text + ",BS_Hi=" + txtHeight.Text;
                    Clms_Name = Clms_Name + ",BS_NX=" + txtNmX.Text + " ,BS_NY=" + txtNmY.Text + ",BS_Length=" + BsL + ",BS_Width=" + BsW;
                    Clms_Name = Clms_Name + ",BS_Thick=" + BsT + ",BS_Sand_Rat=" + txtSand.Text + ",BS_Stone_Rat=" + txtStone.Text;
                    Clms_Name = Clms_Name + ",BS_Cement_Rat=" + txtCement.Text + ",BS_Mat_Sand=" + Mt_Snd + ",BS_Mat_Stone=" + Mt_Stn;
                    Clms_Name = Clms_Name + ",BS_Mat_Cement=" + Mt_Cmt;

                    Qry = "Update Base_Tab Set " + Clms_Name + " where BS_Name='" + BsName + "';";
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

        // for load data of Editing Beam
        private void getEditBaseData()
        {
            try
            {
                int ftv = 0, incv = 0;
                float FtinV = 0;
                string Qry = "select * from Base_Tab where BS_Name ='" + HomeFrm.EdtCntrl + "';";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        BsName = Dr.GetString(1);
                        txtStartX.Text = Dr.GetInt16(2).ToString();

                        txtStartY.Text = Dr.GetInt16(3).ToString();
                        txtWidth.Text = Dr.GetInt16(4).ToString();
                        txtHeight.Text = Dr.GetInt16(5).ToString();
                        txtNmX.Text = Dr.GetInt16(6).ToString();
                        txtNmY.Text = Dr.GetInt16(7).ToString();


                        FtinV = Dr.GetFloat(8);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBSLengthFt.Text = ftv.ToString();
                        txtBSLengthIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(9);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBSWidthFt.Text = ftv.ToString();
                        txtBSWidthIn.Text = incv.ToString();

                        FtinV = Dr.GetFloat(10);
                        FtToIn(FtinV, out ftv, out incv);
                        txtBSThickFt.Text = ftv.ToString();
                        txtBSThickIn.Text = incv.ToString();


                        txtSand.Text = Dr.GetFloat(11).ToString();
                        txtStone.Text = Dr.GetFloat(12).ToString();
                        txtCement.Text = Dr.GetFloat(13).ToString();
                        

                    }
                }
                if (Dr != null)
                    Dr.Close();
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can\'t load all edit Base Data.\n" + ex.Message, "Error", MessageBoxButtons.OK);
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
