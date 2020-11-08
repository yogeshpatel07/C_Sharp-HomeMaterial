namespace MaterialEstimate
{
    partial class WinFrm
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
            this.PropertiBox = new System.Windows.Forms.GroupBox();
            this.ShowContorlBtn = new System.Windows.Forms.Button();
            this.NamePosBox = new System.Windows.Forms.GroupBox();
            this.txtNameLeft = new System.Windows.Forms.TextBox();
            this.lblNameLeft = new System.Windows.Forms.Label();
            this.txtNameTop = new System.Windows.Forms.TextBox();
            this.lblNameTop = new System.Windows.Forms.Label();
            this.WinSizeBox = new System.Windows.Forms.GroupBox();
            this.txtWinLengthIn = new System.Windows.Forms.TextBox();
            this.txtWinLengthFt = new System.Windows.Forms.TextBox();
            this.lblWinLength = new System.Windows.Forms.Label();
            this.cmbWallName = new System.Windows.Forms.ComboBox();
            this.lblWallName = new System.Windows.Forms.Label();
            this.txtWinHeightIn = new System.Windows.Forms.TextBox();
            this.txtWinHeightFt = new System.Windows.Forms.TextBox();
            this.lblWinHeight = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.WinPosBox = new System.Windows.Forms.GroupBox();
            this.txtWinLeft = new System.Windows.Forms.TextBox();
            this.lblWinLeft = new System.Windows.Forms.Label();
            this.txtWinTop = new System.Windows.Forms.TextBox();
            this.lblWinTop = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.PropertiBox.SuspendLayout();
            this.NamePosBox.SuspendLayout();
            this.WinSizeBox.SuspendLayout();
            this.WinPosBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertiBox
            // 
            this.PropertiBox.Controls.Add(this.ShowContorlBtn);
            this.PropertiBox.Controls.Add(this.NamePosBox);
            this.PropertiBox.Controls.Add(this.WinSizeBox);
            this.PropertiBox.Controls.Add(this.lblStatus);
            this.PropertiBox.Controls.Add(this.SaveBtn);
            this.PropertiBox.Controls.Add(this.WinPosBox);
            this.PropertiBox.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiBox.Location = new System.Drawing.Point(902, 12);
            this.PropertiBox.Name = "PropertiBox";
            this.PropertiBox.Size = new System.Drawing.Size(404, 659);
            this.PropertiBox.TabIndex = 5;
            this.PropertiBox.TabStop = false;
            this.PropertiBox.Text = "Window or Door Properties";
            // 
            // ShowContorlBtn
            // 
            this.ShowContorlBtn.Enabled = false;
            this.ShowContorlBtn.Location = new System.Drawing.Point(6, 272);
            this.ShowContorlBtn.Name = "ShowContorlBtn";
            this.ShowContorlBtn.Size = new System.Drawing.Size(392, 44);
            this.ShowContorlBtn.TabIndex = 4;
            this.ShowContorlBtn.Text = "Show Controls";
            this.ShowContorlBtn.UseVisualStyleBackColor = true;
            this.ShowContorlBtn.Click += new System.EventHandler(this.ShowContorlBtn_Click);
            // 
            // NamePosBox
            // 
            this.NamePosBox.Controls.Add(this.txtNameLeft);
            this.NamePosBox.Controls.Add(this.lblNameLeft);
            this.NamePosBox.Controls.Add(this.txtNameTop);
            this.NamePosBox.Controls.Add(this.lblNameTop);
            this.NamePosBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePosBox.Location = new System.Drawing.Point(6, 141);
            this.NamePosBox.Name = "NamePosBox";
            this.NamePosBox.Size = new System.Drawing.Size(191, 97);
            this.NamePosBox.TabIndex = 1;
            this.NamePosBox.TabStop = false;
            this.NamePosBox.Text = "Name Position";
            // 
            // txtNameLeft
            // 
            this.txtNameLeft.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtNameLeft.Location = new System.Drawing.Point(98, 61);
            this.txtNameLeft.Name = "txtNameLeft";
            this.txtNameLeft.Size = new System.Drawing.Size(84, 26);
            this.txtNameLeft.TabIndex = 1;
            this.txtNameLeft.Text = "0";
            this.txtNameLeft.Leave += new System.EventHandler(this.txtNameLeft_Leave);
            // 
            // lblNameLeft
            // 
            this.lblNameLeft.AutoSize = true;
            this.lblNameLeft.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLeft.Location = new System.Drawing.Point(6, 61);
            this.lblNameLeft.Name = "lblNameLeft";
            this.lblNameLeft.Size = new System.Drawing.Size(50, 22);
            this.lblNameLeft.TabIndex = 5;
            this.lblNameLeft.Text = "Left :";
            // 
            // txtNameTop
            // 
            this.txtNameTop.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtNameTop.Location = new System.Drawing.Point(98, 28);
            this.txtNameTop.Name = "txtNameTop";
            this.txtNameTop.Size = new System.Drawing.Size(84, 26);
            this.txtNameTop.TabIndex = 0;
            this.txtNameTop.Text = "0";
            this.txtNameTop.Leave += new System.EventHandler(this.txtNameTop_Leave);
            // 
            // lblNameTop
            // 
            this.lblNameTop.AutoSize = true;
            this.lblNameTop.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTop.Location = new System.Drawing.Point(6, 28);
            this.lblNameTop.Name = "lblNameTop";
            this.lblNameTop.Size = new System.Drawing.Size(49, 22);
            this.lblNameTop.TabIndex = 2;
            this.lblNameTop.Text = "Top :";
            // 
            // WinSizeBox
            // 
            this.WinSizeBox.Controls.Add(this.txtWinLengthIn);
            this.WinSizeBox.Controls.Add(this.txtWinLengthFt);
            this.WinSizeBox.Controls.Add(this.lblWinLength);
            this.WinSizeBox.Controls.Add(this.cmbWallName);
            this.WinSizeBox.Controls.Add(this.lblWallName);
            this.WinSizeBox.Controls.Add(this.txtWinHeightIn);
            this.WinSizeBox.Controls.Add(this.txtWinHeightFt);
            this.WinSizeBox.Controls.Add(this.lblWinHeight);
            this.WinSizeBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinSizeBox.Location = new System.Drawing.Point(203, 38);
            this.WinSizeBox.Name = "WinSizeBox";
            this.WinSizeBox.Size = new System.Drawing.Size(191, 133);
            this.WinSizeBox.TabIndex = 2;
            this.WinSizeBox.TabStop = false;
            this.WinSizeBox.Text = "Size";
            // 
            // txtWinLengthIn
            // 
            this.txtWinLengthIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWinLengthIn.Location = new System.Drawing.Point(143, 61);
            this.txtWinLengthIn.Name = "txtWinLengthIn";
            this.txtWinLengthIn.Size = new System.Drawing.Size(39, 26);
            this.txtWinLengthIn.TabIndex = 3;
            this.txtWinLengthIn.Text = "0";
            // 
            // txtWinLengthFt
            // 
            this.txtWinLengthFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWinLengthFt.Location = new System.Drawing.Point(98, 61);
            this.txtWinLengthFt.Name = "txtWinLengthFt";
            this.txtWinLengthFt.Size = new System.Drawing.Size(39, 26);
            this.txtWinLengthFt.TabIndex = 2;
            this.txtWinLengthFt.Text = "3";
            // 
            // lblWinLength
            // 
            this.lblWinLength.AutoSize = true;
            this.lblWinLength.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLength.Location = new System.Drawing.Point(6, 61);
            this.lblWinLength.Name = "lblWinLength";
            this.lblWinLength.Size = new System.Drawing.Size(86, 22);
            this.lblWinLength.TabIndex = 13;
            this.lblWinLength.Text = "Length    :";
            // 
            // cmbWallName
            // 
            this.cmbWallName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWallName.Font = new System.Drawing.Font("Cambria", 12F);
            this.cmbWallName.FormattingEnabled = true;
            this.cmbWallName.Location = new System.Drawing.Point(98, 95);
            this.cmbWallName.Name = "cmbWallName";
            this.cmbWallName.Size = new System.Drawing.Size(84, 27);
            this.cmbWallName.TabIndex = 4;
            // 
            // lblWallName
            // 
            this.lblWallName.AutoSize = true;
            this.lblWallName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallName.Location = new System.Drawing.Point(6, 95);
            this.lblWallName.Name = "lblWallName";
            this.lblWallName.Size = new System.Drawing.Size(84, 22);
            this.lblWallName.TabIndex = 8;
            this.lblWallName.Text = "In Wall   :";
            // 
            // txtWinHeightIn
            // 
            this.txtWinHeightIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWinHeightIn.Location = new System.Drawing.Point(143, 28);
            this.txtWinHeightIn.Name = "txtWinHeightIn";
            this.txtWinHeightIn.Size = new System.Drawing.Size(39, 26);
            this.txtWinHeightIn.TabIndex = 1;
            this.txtWinHeightIn.Text = "0";
            // 
            // txtWinHeightFt
            // 
            this.txtWinHeightFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWinHeightFt.Location = new System.Drawing.Point(98, 28);
            this.txtWinHeightFt.Name = "txtWinHeightFt";
            this.txtWinHeightFt.Size = new System.Drawing.Size(39, 26);
            this.txtWinHeightFt.TabIndex = 0;
            this.txtWinHeightFt.Text = "3";
            // 
            // lblWinHeight
            // 
            this.lblWinHeight.AutoSize = true;
            this.lblWinHeight.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinHeight.Location = new System.Drawing.Point(6, 28);
            this.lblWinHeight.Name = "lblWinHeight";
            this.lblWinHeight.Size = new System.Drawing.Size(83, 22);
            this.lblWinHeight.TabIndex = 2;
            this.lblWinHeight.Text = "Height    :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(11, 241);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 28);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status :";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(203, 178);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(191, 60);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // WinPosBox
            // 
            this.WinPosBox.Controls.Add(this.txtWinLeft);
            this.WinPosBox.Controls.Add(this.lblWinLeft);
            this.WinPosBox.Controls.Add(this.txtWinTop);
            this.WinPosBox.Controls.Add(this.lblWinTop);
            this.WinPosBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinPosBox.Location = new System.Drawing.Point(6, 38);
            this.WinPosBox.Name = "WinPosBox";
            this.WinPosBox.Size = new System.Drawing.Size(191, 97);
            this.WinPosBox.TabIndex = 0;
            this.WinPosBox.TabStop = false;
            this.WinPosBox.Text = "Position";
            // 
            // txtWinLeft
            // 
            this.txtWinLeft.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWinLeft.Location = new System.Drawing.Point(98, 61);
            this.txtWinLeft.Name = "txtWinLeft";
            this.txtWinLeft.Size = new System.Drawing.Size(84, 26);
            this.txtWinLeft.TabIndex = 1;
            this.txtWinLeft.Text = "0";
            this.txtWinLeft.Leave += new System.EventHandler(this.txtWinLeft_Leave);
            // 
            // lblWinLeft
            // 
            this.lblWinLeft.AutoSize = true;
            this.lblWinLeft.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLeft.Location = new System.Drawing.Point(6, 61);
            this.lblWinLeft.Name = "lblWinLeft";
            this.lblWinLeft.Size = new System.Drawing.Size(50, 22);
            this.lblWinLeft.TabIndex = 5;
            this.lblWinLeft.Text = "Left :";
            // 
            // txtWinTop
            // 
            this.txtWinTop.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWinTop.Location = new System.Drawing.Point(98, 28);
            this.txtWinTop.Name = "txtWinTop";
            this.txtWinTop.Size = new System.Drawing.Size(84, 26);
            this.txtWinTop.TabIndex = 0;
            this.txtWinTop.Text = "0";
            this.txtWinTop.Leave += new System.EventHandler(this.txtWinTop_Leave);
            // 
            // lblWinTop
            // 
            this.lblWinTop.AutoSize = true;
            this.lblWinTop.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinTop.Location = new System.Drawing.Point(6, 28);
            this.lblWinTop.Name = "lblWinTop";
            this.lblWinTop.Size = new System.Drawing.Size(49, 22);
            this.lblWinTop.TabIndex = 2;
            this.lblWinTop.Text = "Top :";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(884, 659);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            // 
            // WinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 683);
            this.Controls.Add(this.PropertiBox);
            this.Controls.Add(this.picBox);
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "WinFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Windows or Door Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WinFrm_Load);
            this.PropertiBox.ResumeLayout(false);
            this.PropertiBox.PerformLayout();
            this.NamePosBox.ResumeLayout(false);
            this.NamePosBox.PerformLayout();
            this.WinSizeBox.ResumeLayout(false);
            this.WinSizeBox.PerformLayout();
            this.WinPosBox.ResumeLayout(false);
            this.WinPosBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PropertiBox;
        private System.Windows.Forms.Button ShowContorlBtn;
        private System.Windows.Forms.GroupBox NamePosBox;
        private System.Windows.Forms.TextBox txtNameLeft;
        private System.Windows.Forms.Label lblNameLeft;
        private System.Windows.Forms.TextBox txtNameTop;
        private System.Windows.Forms.Label lblNameTop;
        private System.Windows.Forms.GroupBox WinSizeBox;
        private System.Windows.Forms.Label lblWallName;
        private System.Windows.Forms.TextBox txtWinHeightIn;
        private System.Windows.Forms.TextBox txtWinHeightFt;
        private System.Windows.Forms.Label lblWinHeight;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.GroupBox WinPosBox;
        private System.Windows.Forms.TextBox txtWinLeft;
        private System.Windows.Forms.Label lblWinLeft;
        private System.Windows.Forms.TextBox txtWinTop;
        private System.Windows.Forms.Label lblWinTop;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ComboBox cmbWallName;
        private System.Windows.Forms.TextBox txtWinLengthIn;
        private System.Windows.Forms.TextBox txtWinLengthFt;
        private System.Windows.Forms.Label lblWinLength;
    }
}