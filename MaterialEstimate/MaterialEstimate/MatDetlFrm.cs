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
    public partial class MatDetlFrm : Form
    {
        //string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\MyHomeMaterial\\HomeDB.accdb;Persist Security Info=False";
        string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + MainMdiFrm.DataPathF + "\\DataBase\\HomeDB.accdb;Persist Security Info=False";

        public MatDetlFrm()
        {
            InitializeComponent();
        }

        private void MatDetlFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMdiFrm.MatPage = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(isAllValid())
            {
                if(SaveData())
                {
                    MessageBox.Show("Data save successfull..", "Information", MessageBoxButtons.OK);
                }
                
            }
            
        }


        private bool isAllValid()
        {
            float val = 0;

            // check Sand value
            try
            {
                val = float.Parse(txtSand.Text);
                if (val < 0)
                {
                    MessageBox.Show("Sand volume can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sand volume can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Stone value
            try
            {
                val = float.Parse(txtStone.Text);
                if (val < 0)
                {
                    MessageBox.Show("Stone volume can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stone volume can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Cement value
            try
            {
                val = float.Parse(txtCement.Text);
                if (val < 0)
                {
                    MessageBox.Show("Cement volume can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cement volume can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Column Rod length value
            try
            {
                val = float.Parse(txtClmRdLen.Text);
                if (val < 0)
                {
                    MessageBox.Show("Column Rod length can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Column Rod length can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Column Rod Thick value
            try
            {
                val = float.Parse(txtClmRdThick.Text);
                if (val < 0)
                {
                    MessageBox.Show("Column Rod Thick can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Column Rod Thick can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Ring Rod length value
            try
            {
                val = float.Parse(txtRingRdLen.Text);
                if (val < 0)
                {
                    MessageBox.Show("Ring Rod length can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ring Rod length can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Ring Rod Thick value
            try
            {
                val = float.Parse(txtRingRdThick.Text);
                if (val < 0)
                {
                    MessageBox.Show("Ring Rod Thick can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ring Rod Thick can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Bricks Length value
            try
            {
                val = float.Parse(txtBrLen.Text);
                if (val < 0)
                {
                    MessageBox.Show("Bricks length can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bricks length can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Bricks Breadth value
            try
            {
                val = float.Parse(txtBrBrd.Text);
                if (val < 0)
                {
                    MessageBox.Show("Bricks Width can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bricks Width can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            // check Bricks Thick value
            try
            {
                val = float.Parse(txtBrThick.Text);
                if (val < 0)
                {
                    MessageBox.Show("Bricks Thick can\'t less than 0", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bricks Thick can\'t be string type\n" + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            string prop_name;
            string prp_val;
            try
            {
                string Qry = "select * from StdMat;";
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
                        prp_val = Dr.GetValue(1).ToString();

                        if(prop_name== "Brick_Brd")
                        {
                            txtBrBrd.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Brick_Hi")
                        {
                            txtBrThick.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Brick_Len")
                        {
                            txtBrLen.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Cement")
                        {
                            txtCement.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Clm_Rod_Len")
                        {
                            txtClmRdLen.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Clm_Rod_Thick")
                        {
                            txtClmRdThick.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Ring_Rod_Len")
                        {
                            txtRingRdLen.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Ring_Rod_Thick")
                        {
                            txtRingRdThick.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Sand")
                        {
                            txtSand.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Stone")
                        {
                            txtStone.Text = prp_val.ToString();
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

        private bool SaveData()
        {
            bool ret = true;
            try
            {
                string Qry = "delete from WorkMat;";
                int res = 0;
                OleDbConnection con = new OleDbConnection(ConStr);
                OleDbCommand cmd = new OleDbCommand(Qry, con);
                con.Open();

                res =cmd.ExecuteNonQuery();
                if(res>0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (i == 0)
                            Qry = "insert into WorkMat values('Brick_Brd'," + txtBrBrd.Text + ");";
                        else if (i == 1)
                            Qry = "insert into WorkMat values('Brick_Hi'," + txtBrThick.Text + ");";
                        else if (i == 2)
                            Qry = "insert into WorkMat values('Brick_Len'," + txtBrLen.Text + ");";
                        else if (i == 3)
                            Qry = "insert into WorkMat values('Cement'," + txtCement.Text + ");";
                        else if (i == 4)
                            Qry = "insert into WorkMat values('Clm_Rod_Len'," + txtClmRdLen.Text + ");";
                        else if (i == 5)
                            Qry = "insert into WorkMat values('Clm_Rod_Thick'," + txtClmRdThick.Text + ");";
                        else if (i == 6)
                            Qry = "insert into WorkMat values('Ring_Rod_Len'," + txtRingRdLen.Text + ");";
                        else if (i == 7)
                            Qry = "insert into WorkMat values('Ring_Rod_Thick'," + txtRingRdThick.Text + ");";
                        else if (i == 8)
                            Qry = "insert into WorkMat values('Sand'," + txtSand.Text + ");";
                        else if (i == 9)
                            Qry = "insert into WorkMat values('Stone'," + txtStone.Text + ");";
                        
                        cmd.CommandText = Qry;

                        res = cmd.ExecuteNonQuery();
                        if(res>0)
                        {
                            ret = true;
                        }
                        else
                        {
                            MessageBox.Show("Some error at during data saving...", "Infornation", MessageBoxButtons.OK);
                            ret = false;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Data can not save\nTable already have data...", "Information", MessageBoxButtons.OK);
                    ret = false;
                }
                if (con != null)
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                ret = false;
            }

            return ret;

        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            string prop_name;
            string prp_val;
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
                        prp_val = Dr.GetValue(1).ToString();

                        if (prop_name == "Brick_Brd")
                        {
                            txtBrBrd.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Brick_Hi")
                        {
                            txtBrThick.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Brick_Len")
                        {
                            txtBrLen.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Cement")
                        {
                            txtCement.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Clm_Rod_Len")
                        {
                            txtClmRdLen.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Clm_Rod_Thick")
                        {
                            txtClmRdThick.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Ring_Rod_Len")
                        {
                            txtRingRdLen.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Ring_Rod_Thick")
                        {
                            txtRingRdThick.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Sand")
                        {
                            txtSand.Text = prp_val.ToString();
                        }
                        else if (prop_name == "Stone")
                        {
                            txtStone.Text = prp_val.ToString();
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
