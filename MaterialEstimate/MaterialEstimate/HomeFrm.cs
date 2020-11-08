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
    public partial class HomeFrm : Form
    {
        //string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\MyHomeMaterial\\HomeDB.accdb;Persist Security Info=False";
        string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\DataBase\\HomeDB.accdb;Persist Security Info=False";

        public string click_btn = "None";
        public static string TodoType = "new";
        public static string EdtCntrl = null;

        public static string WlCmp ="Win";

        Graphics g =null;
        Pen pn = null;
        public static Font fnt =null;

        public static int SX, SY, EX, EY;
        public HomeFrm()
        {
            InitializeComponent();
        }

        private void HomeFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMdiFrm.HmPage = false;
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {
            fnt = LblFont.Font;
            g = picBox.CreateGraphics();
            pn = new Pen(Color.Black);

            cmbCntrlType.Text = "Column";
            txtCntlrName.Text = "";
            click_btn = "None";
            TodoType = "new";

            g.Clear(picBox.BackColor);
            ShowBase();
            ShowColumns();
            ShowBeams();
            ShowWinAndDoors();
            ShowWalls();
            ShowRoof();
        }

        private void ColumnBtn_Click(object sender, EventArgs e)
        {
            click_btn = "Column";
            TodoType = "new";
        }

        private void NoneBtn_Click(object sender, EventArgs e)
        {
            click_btn = "None";
        }

        private void BeamBtn_Click(object sender, EventArgs e)
        {
            click_btn = "Beam";
            TodoType = "new";
        }

        private void WindowBtn_Click(object sender, EventArgs e)
        {
            click_btn = "Window";
            TodoType = "new";
            WlCmp = "Win";
        }

        private void DoorBtn_Click(object sender, EventArgs e)
        {
            click_btn = "Door";
            TodoType = "new";
            WlCmp = "DR";
        }

        private void RoofBtn_Click(object sender, EventArgs e)
        {
            click_btn = "Roof";
            TodoType = "new";
        }

        private void BaseBtn_Click(object sender, EventArgs e)
        {
            click_btn = "Base";
            TodoType = "new";
        }

        private void WallBtn_Click(object sender, EventArgs e)
        {
            click_btn = "Wall";
            TodoType = "new";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if(isControlExist())
            {
                TodoType = "edit";
                if (cmbCntrlType.Text=="Column")
                {
                    click_btn = "None";
                    ColumnFrm Clmfrm = new ColumnFrm();
                    Clmfrm.MdiParent = this.MdiParent;
                    Clmfrm.Show();
                }
                else if(cmbCntrlType.Text == "Beam")
                {
                    click_btn = "None";
                    BeamFrm Bmfrm = new BeamFrm();
                    Bmfrm.MdiParent = this.MdiParent;
                    Bmfrm.Show();
                }
                else if (cmbCntrlType.Text == "Wall")
                {
                    click_btn = "None";
                    WallFrm Wlfrm = new WallFrm();
                    Wlfrm.MdiParent = this.MdiParent;
                    Wlfrm.Show();
                }
                else if (cmbCntrlType.Text == "Window" || cmbCntrlType.Text == "Door")
                {
                   
                    click_btn = "None";
                    WinFrm Winfrm = new WinFrm();
                    Winfrm.MdiParent = this.MdiParent;
                    Winfrm.Show();
                }
                else if (cmbCntrlType.Text == "Base")
                {
                    click_btn = "None";
                    BaseFrm Bsfrm = new BaseFrm();
                    Bsfrm.MdiParent = this.MdiParent;
                    Bsfrm.Show();
                }
                else if (cmbCntrlType.Text == "Roof")
                {
                    click_btn = "None";
                    RoofFrm Rffrm = new RoofFrm();
                    Rffrm.MdiParent = this.MdiParent;
                    Rffrm.Show();
                }
                else
                {
                    ;
                }

            }

        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (click_btn == "Column")
            {
                TodoType = "new";
                SX = e.X;
                SY = e.Y;
                click_btn = "None";
                ColumnFrm Clmfrm = new ColumnFrm();
                Clmfrm.MdiParent = this.MdiParent;
                Clmfrm.Show();
            }
            else if (click_btn == "Beam")
            {
                TodoType = "new";
                EX = e.X;
                EY = e.Y;
                click_btn = "None";
                BeamFrm Bmfrm = new BeamFrm();
                Bmfrm.MdiParent = this.MdiParent;
                Bmfrm.Show();
            }
            else if (click_btn == "Wall")
            {
                TodoType = "new";
                EX = e.X;
                EY = e.Y;
                click_btn = "None";
                WallFrm Wlfrm = new WallFrm();
                Wlfrm.MdiParent = this.MdiParent;
                Wlfrm.Show();
            }
            else if (click_btn == "Window" || click_btn == "Door")
            {
                TodoType = "new";
                SX = e.X;
                SY = e.Y;
                click_btn = "None";
                WinFrm Winfrm = new WinFrm();
                Winfrm.MdiParent = this.MdiParent;
                Winfrm.Show();
            }
            else if (click_btn == "Base")
            {
                TodoType = "new";
                EX = e.X;
                EY = e.Y;
                click_btn = "None";
                BaseFrm Bsfrm = new BaseFrm();
                Bsfrm.MdiParent = this.MdiParent;
                Bsfrm.Show();
            }
            else if (click_btn == "Roof")
            {
                TodoType = "new";
                EX = e.X;
                EY = e.Y;
                click_btn = "None";
                RoofFrm Rffrm = new RoofFrm();
                Rffrm.MdiParent = this.MdiParent;
                Rffrm.Show();
            }
            else
            {
                ;
            }

        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = "Status :  X = " + e.X + " , Y = " + e.Y;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            isControlDeleted();
        }

        private void ShowContorlBtn_Click(object sender, EventArgs e)
        {
            g.Clear(picBox.BackColor);
            ShowBase();
            ShowColumns();
            ShowBeams();
            ShowWinAndDoors();
            ShowWalls();
            ShowRoof();
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            SX = e.X;
            SY = e.Y;
        }



        // my Functions 
        // for checking whether Control Exist or not
        private bool isControlExist()
        {
            bool ret = false;

            string Qry = "select * from Column_Tab where Clm_Name ='" + txtCntlrName.Text + "';";

            if (cmbCntrlType.Text == "Column")
            {
                Qry = "select * from Column_Tab where Clm_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Beam")
            {
                Qry = "select * from Beam_Tab where Bm_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Wall")
            {
                Qry = "select * from Wall_Tab where Wl_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Window" || cmbCntrlType.Text == "Door")
            {
                Qry = "select * from Window_Tab where Win_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Base")
            {
                Qry = "select * from Base_Tab where BS_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Roof")
            {
                Qry = "select * from Roof_Tab where Rf_Name ='" + txtCntlrName.Text + "';";
            }

            try
            {

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                OleDbDataReader Dr = null;
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        EdtCntrl = Dr.GetString(1);
                        ret = true;
                    }
                }
                else
                {
                    MessageBox.Show("there is no such " + cmbCntrlType.Text, "Information", MessageBoxButtons.OK);
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

            return ret;
        }

        // for checking whether Deleterd Exist or not it also delete coltrol
        private void isControlDeleted()
        {
            string Qry = "delete from Column_Tab where Clm_Name ='" + txtCntlrName.Text + "';";

            if (cmbCntrlType.Text == "Column")
            {
                Qry = "delete from Column_Tab where Clm_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Beam")
            {
                Qry = "delete from Beam_Tab where Bm_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Wall")
            {
                Qry = "delete from Wall_Tab where Wl_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Window" || cmbCntrlType.Text == "Door")
            {
                Qry = "delete from Window_Tab where Win_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Base")
            {
                Qry = "delete from Base_Tab where BS_Name ='" + txtCntlrName.Text + "';";
            }
            else if (cmbCntrlType.Text == "Roof")
            {
                Qry = "delete from Roof_Tab where Rf_Name ='" + txtCntlrName.Text + "';";
            }
            try
            {

                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                int rv = cmd.ExecuteNonQuery();
                if (rv > 0)
                {
                    MessageBox.Show(txtCntlrName.Text + " has been deleted...", "Information", MessageBoxButtons.OK);
                    if(cmbCntrlType.Text == "Beam")
                    {
                        UpdateBeamWall();
                    }
                    else if(cmbCntrlType.Text == "Window" || cmbCntrlType.Text == "Door")
                    {
                        MessageBox.Show("Please update or edit Wall which contains this "+cmbCntrlType.Text+".", "Information", MessageBoxButtons.OK);
                    }
                    else if(cmbCntrlType.Text == "Wall")
                    {
                        UpdateWinDoor();
                    }
                    else
                    {
                        ;
                    }
                }
                else
                {
                    MessageBox.Show("there is no such " + cmbCntrlType.Text + "\nDeletion can\'t complete.", "Information", MessageBoxButtons.OK);
                }

                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }

        }

        private void UpdateBeamWall()
        {
            try
            {
                string Qry = "delete from Wall_Beam where Com_Name='" + txtCntlrName.Text + "'";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                int rv = cmd.ExecuteNonQuery();
                if (rv > 0)
                {
                    MessageBox.Show("Please update or edit Wall which contains this Beam.", "Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK); ;
            }
        }

        private void UpdateWinDoor()
        {
            try
            {
                string Qry = "delete from Window_Tab where Win_WallName='" + txtCntlrName.Text + "'";
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();
                int rv = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Windows and Door which related to this wall not deleted.\n"+ex.Message, "Information", MessageBoxButtons.OK); ;
            }
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
                        g.DrawString(Clm_Nm, fnt, new SolidBrush(Color.DarkCyan), Nmx, Nmy);

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

        private void EstimateBtn_Click(object sender, EventArgs e)
        {
            click_btn = "None";
            MatStimFrm MEfrm = new MatStimFrm();
            MEfrm.MdiParent = this.MdiParent;
            MEfrm.Show();
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
                        g.DrawString(Wi_Nm, fnt, new SolidBrush(Color.Green), Nmx, Nmy);

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
                        g.DrawString(Bs_Nm, fnt, new SolidBrush(Color.Pink), Nmx, Nmy);

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
                        g.DrawString(Rf_Nm, fnt, new SolidBrush(mypn.Color), Nmx, Nmy);
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
