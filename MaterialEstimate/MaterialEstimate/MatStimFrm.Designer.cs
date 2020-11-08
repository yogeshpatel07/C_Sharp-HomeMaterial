namespace MaterialEstimate
{
    partial class MatStimFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGview = new System.Windows.Forms.DataGridView();
            this.CntrlBox = new System.Windows.Forms.GroupBox();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.lblShowBy = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.cmbCntrlName = new System.Windows.Forms.ComboBox();
            this.lblCntrlName = new System.Windows.Forms.Label();
            this.cmbCntrlType = new System.Windows.Forms.ComboBox();
            this.lblCntrlType = new System.Windows.Forms.Label();
            this.WallCmpBox = new System.Windows.Forms.GroupBox();
            this.ShowCmpBtn = new System.Windows.Forms.Button();
            this.rbBeam = new System.Windows.Forms.RadioButton();
            this.rbWindow = new System.Windows.Forms.RadioButton();
            this.rbDoor = new System.Windows.Forms.RadioButton();
            this.TotMatBox = new System.Windows.Forms.GroupBox();
            this.txtRRod = new System.Windows.Forms.TextBox();
            this.lblRRod = new System.Windows.Forms.Label();
            this.txtNRod = new System.Windows.Forms.TextBox();
            this.lblNRod = new System.Windows.Forms.Label();
            this.txtCement = new System.Windows.Forms.TextBox();
            this.lblCement = new System.Windows.Forms.Label();
            this.txtStone = new System.Windows.Forms.TextBox();
            this.lblStone = new System.Windows.Forms.Label();
            this.txtSand = new System.Windows.Forms.TextBox();
            this.lblSand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGview)).BeginInit();
            this.CntrlBox.SuspendLayout();
            this.WallCmpBox.SuspendLayout();
            this.TotMatBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGview
            // 
            this.dGview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGview.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGview.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGview.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGview.GridColor = System.Drawing.Color.Aqua;
            this.dGview.Location = new System.Drawing.Point(12, 12);
            this.dGview.Name = "dGview";
            this.dGview.Size = new System.Drawing.Size(1340, 430);
            this.dGview.TabIndex = 4;
            // 
            // CntrlBox
            // 
            this.CntrlBox.Controls.Add(this.ShowBtn);
            this.CntrlBox.Controls.Add(this.lblShowBy);
            this.CntrlBox.Controls.Add(this.rbAll);
            this.CntrlBox.Controls.Add(this.rbName);
            this.CntrlBox.Controls.Add(this.cmbCntrlName);
            this.CntrlBox.Controls.Add(this.lblCntrlName);
            this.CntrlBox.Controls.Add(this.cmbCntrlType);
            this.CntrlBox.Controls.Add(this.lblCntrlType);
            this.CntrlBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CntrlBox.Location = new System.Drawing.Point(12, 448);
            this.CntrlBox.Name = "CntrlBox";
            this.CntrlBox.Size = new System.Drawing.Size(347, 223);
            this.CntrlBox.TabIndex = 5;
            this.CntrlBox.TabStop = false;
            this.CntrlBox.Text = "Control Details";
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(11, 166);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(324, 44);
            this.ShowBtn.TabIndex = 24;
            this.ShowBtn.Text = "Show Data";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // lblShowBy
            // 
            this.lblShowBy.AutoSize = true;
            this.lblShowBy.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowBy.Location = new System.Drawing.Point(6, 119);
            this.lblShowBy.Name = "lblShowBy";
            this.lblShowBy.Size = new System.Drawing.Size(116, 28);
            this.lblShowBy.TabIndex = 23;
            this.lblShowBy.Text = "Show By :";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(279, 120);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 29);
            this.rbAll.TabIndex = 21;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Checked = true;
            this.rbName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbName.Location = new System.Drawing.Point(188, 120);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(85, 29);
            this.rbName.TabIndex = 20;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // cmbCntrlName
            // 
            this.cmbCntrlName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCntrlName.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.cmbCntrlName.FormattingEnabled = true;
            this.cmbCntrlName.Location = new System.Drawing.Point(188, 75);
            this.cmbCntrlName.Name = "cmbCntrlName";
            this.cmbCntrlName.Size = new System.Drawing.Size(147, 31);
            this.cmbCntrlName.TabIndex = 5;
            // 
            // lblCntrlName
            // 
            this.lblCntrlName.AutoSize = true;
            this.lblCntrlName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntrlName.Location = new System.Drawing.Point(6, 74);
            this.lblCntrlName.Name = "lblCntrlName";
            this.lblCntrlName.Size = new System.Drawing.Size(175, 28);
            this.lblCntrlName.TabIndex = 6;
            this.lblCntrlName.Text = "Control Name :";
            // 
            // cmbCntrlType
            // 
            this.cmbCntrlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCntrlType.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.cmbCntrlType.FormattingEnabled = true;
            this.cmbCntrlType.Items.AddRange(new object[] {
            "Column",
            "Beam",
            "Wall",
            "Window",
            "Door",
            "Roof",
            "Base"});
            this.cmbCntrlType.Location = new System.Drawing.Point(188, 29);
            this.cmbCntrlType.Name = "cmbCntrlType";
            this.cmbCntrlType.Size = new System.Drawing.Size(147, 31);
            this.cmbCntrlType.TabIndex = 3;
            this.cmbCntrlType.TextChanged += new System.EventHandler(this.cmbCntrlType_TextChanged);
            // 
            // lblCntrlType
            // 
            this.lblCntrlType.AutoSize = true;
            this.lblCntrlType.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntrlType.Location = new System.Drawing.Point(6, 28);
            this.lblCntrlType.Name = "lblCntrlType";
            this.lblCntrlType.Size = new System.Drawing.Size(176, 28);
            this.lblCntrlType.TabIndex = 4;
            this.lblCntrlType.Text = "Control Type   :";
            // 
            // WallCmpBox
            // 
            this.WallCmpBox.Controls.Add(this.ShowCmpBtn);
            this.WallCmpBox.Controls.Add(this.rbBeam);
            this.WallCmpBox.Controls.Add(this.rbWindow);
            this.WallCmpBox.Controls.Add(this.rbDoor);
            this.WallCmpBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WallCmpBox.Location = new System.Drawing.Point(718, 448);
            this.WallCmpBox.Name = "WallCmpBox";
            this.WallCmpBox.Size = new System.Drawing.Size(170, 223);
            this.WallCmpBox.TabIndex = 6;
            this.WallCmpBox.TabStop = false;
            this.WallCmpBox.Text = "Wall Comp.";
            this.WallCmpBox.Visible = false;
            // 
            // ShowCmpBtn
            // 
            this.ShowCmpBtn.Location = new System.Drawing.Point(11, 166);
            this.ShowCmpBtn.Name = "ShowCmpBtn";
            this.ShowCmpBtn.Size = new System.Drawing.Size(148, 44);
            this.ShowCmpBtn.TabIndex = 24;
            this.ShowCmpBtn.Text = "Show Comp.";
            this.ShowCmpBtn.UseVisualStyleBackColor = true;
            this.ShowCmpBtn.Click += new System.EventHandler(this.ShowCmpBtn_Click);
            // 
            // rbBeam
            // 
            this.rbBeam.AutoSize = true;
            this.rbBeam.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBeam.Location = new System.Drawing.Point(11, 118);
            this.rbBeam.Name = "rbBeam";
            this.rbBeam.Size = new System.Drawing.Size(95, 29);
            this.rbBeam.TabIndex = 21;
            this.rbBeam.Text = "Beams";
            this.rbBeam.UseVisualStyleBackColor = true;
            // 
            // rbWindow
            // 
            this.rbWindow.AutoSize = true;
            this.rbWindow.Checked = true;
            this.rbWindow.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWindow.Location = new System.Drawing.Point(11, 31);
            this.rbWindow.Name = "rbWindow";
            this.rbWindow.Size = new System.Drawing.Size(122, 29);
            this.rbWindow.TabIndex = 20;
            this.rbWindow.TabStop = true;
            this.rbWindow.Text = "Windows";
            this.rbWindow.UseVisualStyleBackColor = true;
            // 
            // rbDoor
            // 
            this.rbDoor.AutoSize = true;
            this.rbDoor.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDoor.Location = new System.Drawing.Point(11, 75);
            this.rbDoor.Name = "rbDoor";
            this.rbDoor.Size = new System.Drawing.Size(89, 29);
            this.rbDoor.TabIndex = 20;
            this.rbDoor.Text = "Doors";
            this.rbDoor.UseVisualStyleBackColor = true;
            // 
            // TotMatBox
            // 
            this.TotMatBox.Controls.Add(this.txtRRod);
            this.TotMatBox.Controls.Add(this.lblRRod);
            this.TotMatBox.Controls.Add(this.txtNRod);
            this.TotMatBox.Controls.Add(this.lblNRod);
            this.TotMatBox.Controls.Add(this.txtCement);
            this.TotMatBox.Controls.Add(this.lblCement);
            this.TotMatBox.Controls.Add(this.txtStone);
            this.TotMatBox.Controls.Add(this.lblStone);
            this.TotMatBox.Controls.Add(this.txtSand);
            this.TotMatBox.Controls.Add(this.lblSand);
            this.TotMatBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotMatBox.Location = new System.Drawing.Point(365, 448);
            this.TotMatBox.Name = "TotMatBox";
            this.TotMatBox.Size = new System.Drawing.Size(347, 223);
            this.TotMatBox.TabIndex = 7;
            this.TotMatBox.TabStop = false;
            this.TotMatBox.Text = "Total Material";
            this.TotMatBox.Visible = false;
            // 
            // txtRRod
            // 
            this.txtRRod.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRRod.Location = new System.Drawing.Point(238, 175);
            this.txtRRod.Name = "txtRRod";
            this.txtRRod.Size = new System.Drawing.Size(94, 32);
            this.txtRRod.TabIndex = 19;
            this.txtRRod.Text = "0";
            // 
            // lblRRod
            // 
            this.lblRRod.AutoSize = true;
            this.lblRRod.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRRod.Location = new System.Drawing.Point(6, 175);
            this.lblRRod.Name = "lblRRod";
            this.lblRRod.Size = new System.Drawing.Size(225, 28);
            this.lblRRod.TabIndex = 20;
            this.lblRRod.Text = "No. of Ring Rods        :";
            // 
            // txtNRod
            // 
            this.txtNRod.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRod.Location = new System.Drawing.Point(238, 137);
            this.txtNRod.Name = "txtNRod";
            this.txtNRod.Size = new System.Drawing.Size(94, 32);
            this.txtNRod.TabIndex = 17;
            this.txtNRod.Text = "0";
            // 
            // lblNRod
            // 
            this.lblNRod.AutoSize = true;
            this.lblNRod.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRod.Location = new System.Drawing.Point(6, 137);
            this.lblNRod.Name = "lblNRod";
            this.lblNRod.Size = new System.Drawing.Size(226, 28);
            this.lblNRod.TabIndex = 18;
            this.lblNRod.Text = "No. of Normal Rods  :";
            // 
            // txtCement
            // 
            this.txtCement.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCement.Location = new System.Drawing.Point(238, 99);
            this.txtCement.Name = "txtCement";
            this.txtCement.Size = new System.Drawing.Size(94, 32);
            this.txtCement.TabIndex = 15;
            this.txtCement.Text = "0";
            // 
            // lblCement
            // 
            this.lblCement.AutoSize = true;
            this.lblCement.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCement.Location = new System.Drawing.Point(6, 99);
            this.lblCement.Name = "lblCement";
            this.lblCement.Size = new System.Drawing.Size(228, 28);
            this.lblCement.TabIndex = 16;
            this.lblCement.Text = "Cement (in Sack)       :";
            // 
            // txtStone
            // 
            this.txtStone.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStone.Location = new System.Drawing.Point(238, 62);
            this.txtStone.Name = "txtStone";
            this.txtStone.Size = new System.Drawing.Size(94, 32);
            this.txtStone.TabIndex = 13;
            this.txtStone.Text = "0";
            // 
            // lblStone
            // 
            this.lblStone.AutoSize = true;
            this.lblStone.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStone.Location = new System.Drawing.Point(6, 62);
            this.lblStone.Name = "lblStone";
            this.lblStone.Size = new System.Drawing.Size(226, 28);
            this.lblStone.TabIndex = 14;
            this.lblStone.Text = "Stone (in Tractor)     :";
            // 
            // txtSand
            // 
            this.txtSand.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSand.Location = new System.Drawing.Point(238, 24);
            this.txtSand.Name = "txtSand";
            this.txtSand.Size = new System.Drawing.Size(94, 32);
            this.txtSand.TabIndex = 11;
            this.txtSand.Text = "0";
            // 
            // lblSand
            // 
            this.lblSand.AutoSize = true;
            this.lblSand.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSand.Location = new System.Drawing.Point(6, 24);
            this.lblSand.Name = "lblSand";
            this.lblSand.Size = new System.Drawing.Size(228, 28);
            this.lblSand.TabIndex = 12;
            this.lblSand.Text = "Sand (in Tractor)       :";
            // 
            // MatStimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 683);
            this.Controls.Add(this.TotMatBox);
            this.Controls.Add(this.WallCmpBox);
            this.Controls.Add(this.CntrlBox);
            this.Controls.Add(this.dGview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatStimFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Estimated Material Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MatStimFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGview)).EndInit();
            this.CntrlBox.ResumeLayout(false);
            this.CntrlBox.PerformLayout();
            this.WallCmpBox.ResumeLayout(false);
            this.WallCmpBox.PerformLayout();
            this.TotMatBox.ResumeLayout(false);
            this.TotMatBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGview;
        private System.Windows.Forms.GroupBox CntrlBox;
        private System.Windows.Forms.ComboBox cmbCntrlName;
        private System.Windows.Forms.Label lblCntrlName;
        private System.Windows.Forms.ComboBox cmbCntrlType;
        private System.Windows.Forms.Label lblCntrlType;
        private System.Windows.Forms.Label lblShowBy;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.GroupBox WallCmpBox;
        private System.Windows.Forms.Button ShowCmpBtn;
        private System.Windows.Forms.RadioButton rbBeam;
        private System.Windows.Forms.RadioButton rbWindow;
        private System.Windows.Forms.RadioButton rbDoor;
        private System.Windows.Forms.GroupBox TotMatBox;
        private System.Windows.Forms.TextBox txtStone;
        private System.Windows.Forms.Label lblStone;
        private System.Windows.Forms.TextBox txtSand;
        private System.Windows.Forms.Label lblSand;
        private System.Windows.Forms.TextBox txtRRod;
        private System.Windows.Forms.Label lblRRod;
        private System.Windows.Forms.TextBox txtNRod;
        private System.Windows.Forms.Label lblNRod;
        private System.Windows.Forms.TextBox txtCement;
        private System.Windows.Forms.Label lblCement;
    }
}