namespace MaterialEstimate
{
    partial class HomeFrm
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.MyControlBox = new System.Windows.Forms.GroupBox();
            this.LblFont = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.EstimateBtn = new System.Windows.Forms.Button();
            this.ShowContorlBtn = new System.Windows.Forms.Button();
            this.EditBox = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.cmbCntrlType = new System.Windows.Forms.ComboBox();
            this.lblCntrlType = new System.Windows.Forms.Label();
            this.txtCntlrName = new System.Windows.Forms.TextBox();
            this.lblCntrlName = new System.Windows.Forms.Label();
            this.AddNewBox = new System.Windows.Forms.GroupBox();
            this.BaseBtn = new System.Windows.Forms.Button();
            this.RoofBtn = new System.Windows.Forms.Button();
            this.DoorBtn = new System.Windows.Forms.Button();
            this.WindowBtn = new System.Windows.Forms.Button();
            this.BeamBtn = new System.Windows.Forms.Button();
            this.ColumnBtn = new System.Windows.Forms.Button();
            this.WallBtn = new System.Windows.Forms.Button();
            this.NoneBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.MyControlBox.SuspendLayout();
            this.EditBox.SuspendLayout();
            this.AddNewBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(884, 659);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // MyControlBox
            // 
            this.MyControlBox.Controls.Add(this.LblFont);
            this.MyControlBox.Controls.Add(this.lblStatus);
            this.MyControlBox.Controls.Add(this.EstimateBtn);
            this.MyControlBox.Controls.Add(this.ShowContorlBtn);
            this.MyControlBox.Controls.Add(this.EditBox);
            this.MyControlBox.Controls.Add(this.AddNewBox);
            this.MyControlBox.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyControlBox.Location = new System.Drawing.Point(902, 12);
            this.MyControlBox.Name = "MyControlBox";
            this.MyControlBox.Size = new System.Drawing.Size(404, 659);
            this.MyControlBox.TabIndex = 1;
            this.MyControlBox.TabStop = false;
            this.MyControlBox.Text = "Controls";
            // 
            // LblFont
            // 
            this.LblFont.AutoSize = true;
            this.LblFont.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFont.Location = new System.Drawing.Point(329, -3);
            this.LblFont.Name = "LblFont";
            this.LblFont.Size = new System.Drawing.Size(34, 16);
            this.LblFont.TabIndex = 4;
            this.LblFont.Text = "Font";
            this.LblFont.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(6, 626);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 28);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status :";
            // 
            // EstimateBtn
            // 
            this.EstimateBtn.Location = new System.Drawing.Point(6, 562);
            this.EstimateBtn.Name = "EstimateBtn";
            this.EstimateBtn.Size = new System.Drawing.Size(392, 44);
            this.EstimateBtn.TabIndex = 1;
            this.EstimateBtn.Text = "Estimated Materials";
            this.EstimateBtn.UseVisualStyleBackColor = true;
            this.EstimateBtn.Click += new System.EventHandler(this.EstimateBtn_Click);
            // 
            // ShowContorlBtn
            // 
            this.ShowContorlBtn.Location = new System.Drawing.Point(6, 512);
            this.ShowContorlBtn.Name = "ShowContorlBtn";
            this.ShowContorlBtn.Size = new System.Drawing.Size(392, 44);
            this.ShowContorlBtn.TabIndex = 0;
            this.ShowContorlBtn.Text = "Show Controls";
            this.ShowContorlBtn.UseVisualStyleBackColor = true;
            this.ShowContorlBtn.Click += new System.EventHandler(this.ShowContorlBtn_Click);
            // 
            // EditBox
            // 
            this.EditBox.Controls.Add(this.DeleteBtn);
            this.EditBox.Controls.Add(this.EditBtn);
            this.EditBox.Controls.Add(this.cmbCntrlType);
            this.EditBox.Controls.Add(this.lblCntrlType);
            this.EditBox.Controls.Add(this.txtCntlrName);
            this.EditBox.Controls.Add(this.lblCntrlName);
            this.EditBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBox.Location = new System.Drawing.Point(6, 322);
            this.EditBox.Name = "EditBox";
            this.EditBox.Size = new System.Drawing.Size(392, 184);
            this.EditBox.TabIndex = 3;
            this.EditBox.TabStop = false;
            this.EditBox.Text = "Edit";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(207, 121);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(179, 44);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(6, 121);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(179, 44);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            this.cmbCntrlType.Location = new System.Drawing.Point(255, 75);
            this.cmbCntrlType.Name = "cmbCntrlType";
            this.cmbCntrlType.Size = new System.Drawing.Size(131, 31);
            this.cmbCntrlType.TabIndex = 1;
            // 
            // lblCntrlType
            // 
            this.lblCntrlType.AutoSize = true;
            this.lblCntrlType.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntrlType.Location = new System.Drawing.Point(6, 75);
            this.lblCntrlType.Name = "lblCntrlType";
            this.lblCntrlType.Size = new System.Drawing.Size(241, 28);
            this.lblCntrlType.TabIndex = 2;
            this.lblCntrlType.Text = "Select Control Type  :";
            // 
            // txtCntlrName
            // 
            this.txtCntlrName.Location = new System.Drawing.Point(255, 28);
            this.txtCntlrName.Name = "txtCntlrName";
            this.txtCntlrName.Size = new System.Drawing.Size(131, 32);
            this.txtCntlrName.TabIndex = 0;
            // 
            // lblCntrlName
            // 
            this.lblCntrlName.AutoSize = true;
            this.lblCntrlName.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntrlName.Location = new System.Drawing.Point(6, 28);
            this.lblCntrlName.Name = "lblCntrlName";
            this.lblCntrlName.Size = new System.Drawing.Size(241, 28);
            this.lblCntrlName.TabIndex = 0;
            this.lblCntrlName.Text = "Enter Control Name :";
            // 
            // AddNewBox
            // 
            this.AddNewBox.Controls.Add(this.BaseBtn);
            this.AddNewBox.Controls.Add(this.RoofBtn);
            this.AddNewBox.Controls.Add(this.DoorBtn);
            this.AddNewBox.Controls.Add(this.WindowBtn);
            this.AddNewBox.Controls.Add(this.BeamBtn);
            this.AddNewBox.Controls.Add(this.ColumnBtn);
            this.AddNewBox.Controls.Add(this.WallBtn);
            this.AddNewBox.Controls.Add(this.NoneBtn);
            this.AddNewBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBox.Location = new System.Drawing.Point(6, 38);
            this.AddNewBox.Name = "AddNewBox";
            this.AddNewBox.Size = new System.Drawing.Size(392, 278);
            this.AddNewBox.TabIndex = 2;
            this.AddNewBox.TabStop = false;
            this.AddNewBox.Text = "Add New";
            // 
            // BaseBtn
            // 
            this.BaseBtn.Location = new System.Drawing.Point(207, 217);
            this.BaseBtn.Name = "BaseBtn";
            this.BaseBtn.Size = new System.Drawing.Size(179, 44);
            this.BaseBtn.TabIndex = 7;
            this.BaseBtn.Text = "Base";
            this.BaseBtn.UseVisualStyleBackColor = true;
            this.BaseBtn.Click += new System.EventHandler(this.BaseBtn_Click);
            // 
            // RoofBtn
            // 
            this.RoofBtn.Location = new System.Drawing.Point(6, 217);
            this.RoofBtn.Name = "RoofBtn";
            this.RoofBtn.Size = new System.Drawing.Size(179, 44);
            this.RoofBtn.TabIndex = 6;
            this.RoofBtn.Text = "Roof";
            this.RoofBtn.UseVisualStyleBackColor = true;
            this.RoofBtn.Click += new System.EventHandler(this.RoofBtn_Click);
            // 
            // DoorBtn
            // 
            this.DoorBtn.Location = new System.Drawing.Point(207, 155);
            this.DoorBtn.Name = "DoorBtn";
            this.DoorBtn.Size = new System.Drawing.Size(179, 44);
            this.DoorBtn.TabIndex = 5;
            this.DoorBtn.Text = "Door";
            this.DoorBtn.UseVisualStyleBackColor = true;
            this.DoorBtn.Click += new System.EventHandler(this.DoorBtn_Click);
            // 
            // WindowBtn
            // 
            this.WindowBtn.Location = new System.Drawing.Point(6, 155);
            this.WindowBtn.Name = "WindowBtn";
            this.WindowBtn.Size = new System.Drawing.Size(179, 44);
            this.WindowBtn.TabIndex = 4;
            this.WindowBtn.Text = "Window";
            this.WindowBtn.UseVisualStyleBackColor = true;
            this.WindowBtn.Click += new System.EventHandler(this.WindowBtn_Click);
            // 
            // BeamBtn
            // 
            this.BeamBtn.Location = new System.Drawing.Point(207, 94);
            this.BeamBtn.Name = "BeamBtn";
            this.BeamBtn.Size = new System.Drawing.Size(179, 44);
            this.BeamBtn.TabIndex = 3;
            this.BeamBtn.Text = "Beam";
            this.BeamBtn.UseVisualStyleBackColor = true;
            this.BeamBtn.Click += new System.EventHandler(this.BeamBtn_Click);
            // 
            // ColumnBtn
            // 
            this.ColumnBtn.Location = new System.Drawing.Point(6, 94);
            this.ColumnBtn.Name = "ColumnBtn";
            this.ColumnBtn.Size = new System.Drawing.Size(179, 44);
            this.ColumnBtn.TabIndex = 2;
            this.ColumnBtn.Text = "Column";
            this.ColumnBtn.UseVisualStyleBackColor = true;
            this.ColumnBtn.Click += new System.EventHandler(this.ColumnBtn_Click);
            // 
            // WallBtn
            // 
            this.WallBtn.Location = new System.Drawing.Point(207, 31);
            this.WallBtn.Name = "WallBtn";
            this.WallBtn.Size = new System.Drawing.Size(179, 44);
            this.WallBtn.TabIndex = 1;
            this.WallBtn.Text = "Wall";
            this.WallBtn.UseVisualStyleBackColor = true;
            this.WallBtn.Click += new System.EventHandler(this.WallBtn_Click);
            // 
            // NoneBtn
            // 
            this.NoneBtn.Location = new System.Drawing.Point(6, 31);
            this.NoneBtn.Name = "NoneBtn";
            this.NoneBtn.Size = new System.Drawing.Size(179, 44);
            this.NoneBtn.TabIndex = 0;
            this.NoneBtn.Text = "None";
            this.NoneBtn.UseVisualStyleBackColor = true;
            this.NoneBtn.Click += new System.EventHandler(this.NoneBtn_Click);
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 683);
            this.Controls.Add(this.MyControlBox);
            this.Controls.Add(this.picBox);
            this.MinimizeBox = false;
            this.Name = "HomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeFrm_FormClosed);
            this.Load += new System.EventHandler(this.HomeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.MyControlBox.ResumeLayout(false);
            this.MyControlBox.PerformLayout();
            this.EditBox.ResumeLayout(false);
            this.EditBox.PerformLayout();
            this.AddNewBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox MyControlBox;
        private System.Windows.Forms.GroupBox AddNewBox;
        private System.Windows.Forms.GroupBox EditBox;
        private System.Windows.Forms.Button BaseBtn;
        private System.Windows.Forms.Button RoofBtn;
        private System.Windows.Forms.Button DoorBtn;
        private System.Windows.Forms.Button WindowBtn;
        private System.Windows.Forms.Button BeamBtn;
        private System.Windows.Forms.Button ColumnBtn;
        private System.Windows.Forms.Button WallBtn;
        private System.Windows.Forms.Button NoneBtn;
        private System.Windows.Forms.ComboBox cmbCntrlType;
        private System.Windows.Forms.Label lblCntrlType;
        private System.Windows.Forms.TextBox txtCntlrName;
        private System.Windows.Forms.Label lblCntrlName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button EstimateBtn;
        private System.Windows.Forms.Button ShowContorlBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label LblFont;
    }
}