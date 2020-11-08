namespace MaterialEstimate
{
    partial class RoofFrm
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ShowContorlBtn = new System.Windows.Forms.Button();
            this.NamePosBox = new System.Windows.Forms.GroupBox();
            this.txtNmY = new System.Windows.Forms.TextBox();
            this.lblNmY = new System.Windows.Forms.Label();
            this.txtNmX = new System.Windows.Forms.TextBox();
            this.lblNmX = new System.Windows.Forms.Label();
            this.BSSizeBox = new System.Windows.Forms.GroupBox();
            this.txtRfLengthIn = new System.Windows.Forms.TextBox();
            this.txtRfLengthFt = new System.Windows.Forms.TextBox();
            this.lblBSLength = new System.Windows.Forms.Label();
            this.txtRfThickIn = new System.Windows.Forms.TextBox();
            this.txtRfThickFt = new System.Windows.Forms.TextBox();
            this.lblBSThick = new System.Windows.Forms.Label();
            this.txtRfWidthIn = new System.Windows.Forms.TextBox();
            this.txtRfWidthFt = new System.Windows.Forms.TextBox();
            this.lblBSWidth = new System.Windows.Forms.Label();
            this.MatDetBox = new System.Windows.Forms.GroupBox();
            this.lblMatRatio = new System.Windows.Forms.Label();
            this.txtCement = new System.Windows.Forms.TextBox();
            this.lblCement = new System.Windows.Forms.Label();
            this.txtStone = new System.Windows.Forms.TextBox();
            this.lblStone = new System.Windows.Forms.Label();
            this.txtSand = new System.Windows.Forms.TextBox();
            this.lblSand = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.BSPosBox = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblEndY = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblEndX = new System.Windows.Forms.Label();
            this.txtStartY = new System.Windows.Forms.TextBox();
            this.lblStartY = new System.Windows.Forms.Label();
            this.txtStartX = new System.Windows.Forms.TextBox();
            this.lblStartX = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.PropertiBox.SuspendLayout();
            this.NamePosBox.SuspendLayout();
            this.BSSizeBox.SuspendLayout();
            this.MatDetBox.SuspendLayout();
            this.BSPosBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertiBox
            // 
            this.PropertiBox.Controls.Add(this.SaveBtn);
            this.PropertiBox.Controls.Add(this.ShowContorlBtn);
            this.PropertiBox.Controls.Add(this.NamePosBox);
            this.PropertiBox.Controls.Add(this.BSSizeBox);
            this.PropertiBox.Controls.Add(this.MatDetBox);
            this.PropertiBox.Controls.Add(this.lblStatus);
            this.PropertiBox.Controls.Add(this.BSPosBox);
            this.PropertiBox.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiBox.Location = new System.Drawing.Point(902, 12);
            this.PropertiBox.Name = "PropertiBox";
            this.PropertiBox.Size = new System.Drawing.Size(404, 659);
            this.PropertiBox.TabIndex = 9;
            this.PropertiBox.TabStop = false;
            this.PropertiBox.Text = "Roof Properties";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(6, 368);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(392, 44);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ShowContorlBtn
            // 
            this.ShowContorlBtn.Enabled = false;
            this.ShowContorlBtn.Location = new System.Drawing.Point(6, 483);
            this.ShowContorlBtn.Name = "ShowContorlBtn";
            this.ShowContorlBtn.Size = new System.Drawing.Size(392, 44);
            this.ShowContorlBtn.TabIndex = 5;
            this.ShowContorlBtn.Text = "Show Controls";
            this.ShowContorlBtn.UseVisualStyleBackColor = true;
            this.ShowContorlBtn.Click += new System.EventHandler(this.ShowContorlBtn_Click);
            // 
            // NamePosBox
            // 
            this.NamePosBox.Controls.Add(this.txtNmY);
            this.NamePosBox.Controls.Add(this.lblNmY);
            this.NamePosBox.Controls.Add(this.txtNmX);
            this.NamePosBox.Controls.Add(this.lblNmX);
            this.NamePosBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePosBox.Location = new System.Drawing.Point(203, 38);
            this.NamePosBox.Name = "NamePosBox";
            this.NamePosBox.Size = new System.Drawing.Size(191, 97);
            this.NamePosBox.TabIndex = 2;
            this.NamePosBox.TabStop = false;
            this.NamePosBox.Text = "Name Position";
            // 
            // txtNmY
            // 
            this.txtNmY.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtNmY.Location = new System.Drawing.Point(98, 61);
            this.txtNmY.Name = "txtNmY";
            this.txtNmY.Size = new System.Drawing.Size(84, 26);
            this.txtNmY.TabIndex = 1;
            this.txtNmY.Text = "0";
            this.txtNmY.Leave += new System.EventHandler(this.txtNmY_Leave);
            // 
            // lblNmY
            // 
            this.lblNmY.AutoSize = true;
            this.lblNmY.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmY.Location = new System.Drawing.Point(20, 61);
            this.lblNmY.Name = "lblNmY";
            this.lblNmY.Size = new System.Drawing.Size(30, 22);
            this.lblNmY.TabIndex = 5;
            this.lblNmY.Text = "Y :";
            // 
            // txtNmX
            // 
            this.txtNmX.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtNmX.Location = new System.Drawing.Point(98, 28);
            this.txtNmX.Name = "txtNmX";
            this.txtNmX.Size = new System.Drawing.Size(84, 26);
            this.txtNmX.TabIndex = 0;
            this.txtNmX.Text = "0";
            this.txtNmX.Leave += new System.EventHandler(this.txtNmX_Leave);
            // 
            // lblNmX
            // 
            this.lblNmX.AutoSize = true;
            this.lblNmX.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmX.Location = new System.Drawing.Point(20, 28);
            this.lblNmX.Name = "lblNmX";
            this.lblNmX.Size = new System.Drawing.Size(30, 22);
            this.lblNmX.TabIndex = 2;
            this.lblNmX.Text = "X :";
            // 
            // BSSizeBox
            // 
            this.BSSizeBox.Controls.Add(this.txtRfLengthIn);
            this.BSSizeBox.Controls.Add(this.txtRfLengthFt);
            this.BSSizeBox.Controls.Add(this.lblBSLength);
            this.BSSizeBox.Controls.Add(this.txtRfThickIn);
            this.BSSizeBox.Controls.Add(this.txtRfThickFt);
            this.BSSizeBox.Controls.Add(this.lblBSThick);
            this.BSSizeBox.Controls.Add(this.txtRfWidthIn);
            this.BSSizeBox.Controls.Add(this.txtRfWidthFt);
            this.BSSizeBox.Controls.Add(this.lblBSWidth);
            this.BSSizeBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSSizeBox.Location = new System.Drawing.Point(6, 211);
            this.BSSizeBox.Name = "BSSizeBox";
            this.BSSizeBox.Size = new System.Drawing.Size(191, 141);
            this.BSSizeBox.TabIndex = 1;
            this.BSSizeBox.TabStop = false;
            this.BSSizeBox.Text = "Roof Size";
            // 
            // txtRfLengthIn
            // 
            this.txtRfLengthIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtRfLengthIn.Location = new System.Drawing.Point(145, 29);
            this.txtRfLengthIn.Name = "txtRfLengthIn";
            this.txtRfLengthIn.Size = new System.Drawing.Size(39, 26);
            this.txtRfLengthIn.TabIndex = 1;
            this.txtRfLengthIn.Text = "0";
            // 
            // txtRfLengthFt
            // 
            this.txtRfLengthFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtRfLengthFt.Location = new System.Drawing.Point(100, 29);
            this.txtRfLengthFt.Name = "txtRfLengthFt";
            this.txtRfLengthFt.Size = new System.Drawing.Size(39, 26);
            this.txtRfLengthFt.TabIndex = 0;
            this.txtRfLengthFt.Text = "10";
            // 
            // lblBSLength
            // 
            this.lblBSLength.AutoSize = true;
            this.lblBSLength.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSLength.Location = new System.Drawing.Point(6, 29);
            this.lblBSLength.Name = "lblBSLength";
            this.lblBSLength.Size = new System.Drawing.Size(86, 22);
            this.lblBSLength.TabIndex = 8;
            this.lblBSLength.Text = "Length    :";
            // 
            // txtRfThickIn
            // 
            this.txtRfThickIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtRfThickIn.Location = new System.Drawing.Point(145, 100);
            this.txtRfThickIn.Name = "txtRfThickIn";
            this.txtRfThickIn.Size = new System.Drawing.Size(39, 26);
            this.txtRfThickIn.TabIndex = 5;
            this.txtRfThickIn.Text = "6";
            // 
            // txtRfThickFt
            // 
            this.txtRfThickFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtRfThickFt.Location = new System.Drawing.Point(100, 100);
            this.txtRfThickFt.Name = "txtRfThickFt";
            this.txtRfThickFt.Size = new System.Drawing.Size(39, 26);
            this.txtRfThickFt.TabIndex = 4;
            this.txtRfThickFt.Text = "0";
            // 
            // lblBSThick
            // 
            this.lblBSThick.AutoSize = true;
            this.lblBSThick.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSThick.Location = new System.Drawing.Point(8, 100);
            this.lblBSThick.Name = "lblBSThick";
            this.lblBSThick.Size = new System.Drawing.Size(87, 22);
            this.lblBSThick.TabIndex = 5;
            this.lblBSThick.Text = "Thick.      :";
            // 
            // txtRfWidthIn
            // 
            this.txtRfWidthIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtRfWidthIn.Location = new System.Drawing.Point(145, 65);
            this.txtRfWidthIn.Name = "txtRfWidthIn";
            this.txtRfWidthIn.Size = new System.Drawing.Size(39, 26);
            this.txtRfWidthIn.TabIndex = 3;
            this.txtRfWidthIn.Text = "0";
            // 
            // txtRfWidthFt
            // 
            this.txtRfWidthFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtRfWidthFt.Location = new System.Drawing.Point(100, 65);
            this.txtRfWidthFt.Name = "txtRfWidthFt";
            this.txtRfWidthFt.Size = new System.Drawing.Size(39, 26);
            this.txtRfWidthFt.TabIndex = 2;
            this.txtRfWidthFt.Text = "10";
            // 
            // lblBSWidth
            // 
            this.lblBSWidth.AutoSize = true;
            this.lblBSWidth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSWidth.Location = new System.Drawing.Point(8, 65);
            this.lblBSWidth.Name = "lblBSWidth";
            this.lblBSWidth.Size = new System.Drawing.Size(85, 22);
            this.lblBSWidth.TabIndex = 2;
            this.lblBSWidth.Text = "Width     :";
            // 
            // MatDetBox
            // 
            this.MatDetBox.Controls.Add(this.lblMatRatio);
            this.MatDetBox.Controls.Add(this.txtCement);
            this.MatDetBox.Controls.Add(this.lblCement);
            this.MatDetBox.Controls.Add(this.txtStone);
            this.MatDetBox.Controls.Add(this.lblStone);
            this.MatDetBox.Controls.Add(this.txtSand);
            this.MatDetBox.Controls.Add(this.lblSand);
            this.MatDetBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDetBox.Location = new System.Drawing.Point(203, 141);
            this.MatDetBox.Name = "MatDetBox";
            this.MatDetBox.Size = new System.Drawing.Size(191, 211);
            this.MatDetBox.TabIndex = 3;
            this.MatDetBox.TabStop = false;
            this.MatDetBox.Text = "Material Details";
            // 
            // lblMatRatio
            // 
            this.lblMatRatio.AutoSize = true;
            this.lblMatRatio.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatRatio.Location = new System.Drawing.Point(20, 28);
            this.lblMatRatio.Name = "lblMatRatio";
            this.lblMatRatio.Size = new System.Drawing.Size(143, 22);
            this.lblMatRatio.TabIndex = 13;
            this.lblMatRatio.Text = "Material in Ratio";
            // 
            // txtCement
            // 
            this.txtCement.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtCement.Location = new System.Drawing.Point(143, 129);
            this.txtCement.Name = "txtCement";
            this.txtCement.Size = new System.Drawing.Size(39, 26);
            this.txtCement.TabIndex = 2;
            this.txtCement.Text = "1";
            // 
            // lblCement
            // 
            this.lblCement.AutoSize = true;
            this.lblCement.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCement.Location = new System.Drawing.Point(6, 129);
            this.lblCement.Name = "lblCement";
            this.lblCement.Size = new System.Drawing.Size(113, 22);
            this.lblCement.TabIndex = 8;
            this.lblCement.Text = "Cement         :";
            // 
            // txtStone
            // 
            this.txtStone.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtStone.Location = new System.Drawing.Point(143, 95);
            this.txtStone.Name = "txtStone";
            this.txtStone.Size = new System.Drawing.Size(39, 26);
            this.txtStone.TabIndex = 1;
            this.txtStone.Text = "20";
            // 
            // lblStone
            // 
            this.lblStone.AutoSize = true;
            this.lblStone.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStone.Location = new System.Drawing.Point(6, 95);
            this.lblStone.Name = "lblStone";
            this.lblStone.Size = new System.Drawing.Size(112, 22);
            this.lblStone.TabIndex = 5;
            this.lblStone.Text = "Stone(Gitti) :";
            // 
            // txtSand
            // 
            this.txtSand.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtSand.Location = new System.Drawing.Point(143, 62);
            this.txtSand.Name = "txtSand";
            this.txtSand.Size = new System.Drawing.Size(39, 26);
            this.txtSand.TabIndex = 0;
            this.txtSand.Text = "20";
            // 
            // lblSand
            // 
            this.lblSand.AutoSize = true;
            this.lblSand.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSand.Location = new System.Drawing.Point(6, 62);
            this.lblSand.Name = "lblSand";
            this.lblSand.Size = new System.Drawing.Size(112, 22);
            this.lblSand.TabIndex = 2;
            this.lblSand.Text = "Sand(Ret)    :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 436);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 28);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status :";
            // 
            // BSPosBox
            // 
            this.BSPosBox.Controls.Add(this.txtHeight);
            this.BSPosBox.Controls.Add(this.lblEndY);
            this.BSPosBox.Controls.Add(this.txtWidth);
            this.BSPosBox.Controls.Add(this.lblEndX);
            this.BSPosBox.Controls.Add(this.txtStartY);
            this.BSPosBox.Controls.Add(this.lblStartY);
            this.BSPosBox.Controls.Add(this.txtStartX);
            this.BSPosBox.Controls.Add(this.lblStartX);
            this.BSPosBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSPosBox.Location = new System.Drawing.Point(6, 38);
            this.BSPosBox.Name = "BSPosBox";
            this.BSPosBox.Size = new System.Drawing.Size(191, 167);
            this.BSPosBox.TabIndex = 0;
            this.BSPosBox.TabStop = false;
            this.BSPosBox.Text = "Roof Position";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtHeight.Location = new System.Drawing.Point(98, 128);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(84, 26);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Text = "0";
            this.txtHeight.Leave += new System.EventHandler(this.txtHeight_Leave);
            // 
            // lblEndY
            // 
            this.lblEndY.AutoSize = true;
            this.lblEndY.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndY.Location = new System.Drawing.Point(5, 128);
            this.lblEndY.Name = "lblEndY";
            this.lblEndY.Size = new System.Drawing.Size(75, 22);
            this.lblEndY.TabIndex = 9;
            this.lblEndY.Text = "Height  :";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWidth.Location = new System.Drawing.Point(98, 95);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(84, 26);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.Text = "0";
            this.txtWidth.Leave += new System.EventHandler(this.txtWidth_Leave);
            // 
            // lblEndX
            // 
            this.lblEndX.AutoSize = true;
            this.lblEndX.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndX.Location = new System.Drawing.Point(6, 95);
            this.lblEndX.Name = "lblEndX";
            this.lblEndX.Size = new System.Drawing.Size(73, 22);
            this.lblEndX.TabIndex = 8;
            this.lblEndX.Text = "Width  :";
            // 
            // txtStartY
            // 
            this.txtStartY.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtStartY.Location = new System.Drawing.Point(98, 62);
            this.txtStartY.Name = "txtStartY";
            this.txtStartY.Size = new System.Drawing.Size(84, 26);
            this.txtStartY.TabIndex = 1;
            this.txtStartY.Text = "0";
            this.txtStartY.Leave += new System.EventHandler(this.txtStartY_Leave);
            // 
            // lblStartY
            // 
            this.lblStartY.AutoSize = true;
            this.lblStartY.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartY.Location = new System.Drawing.Point(6, 62);
            this.lblStartY.Name = "lblStartY";
            this.lblStartY.Size = new System.Drawing.Size(72, 22);
            this.lblStartY.TabIndex = 5;
            this.lblStartY.Text = "Start Y :";
            // 
            // txtStartX
            // 
            this.txtStartX.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtStartX.Location = new System.Drawing.Point(98, 28);
            this.txtStartX.Name = "txtStartX";
            this.txtStartX.Size = new System.Drawing.Size(84, 26);
            this.txtStartX.TabIndex = 0;
            this.txtStartX.Text = "0";
            this.txtStartX.Leave += new System.EventHandler(this.txtStartX_Leave);
            // 
            // lblStartX
            // 
            this.lblStartX.AutoSize = true;
            this.lblStartX.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartX.Location = new System.Drawing.Point(6, 28);
            this.lblStartX.Name = "lblStartX";
            this.lblStartX.Size = new System.Drawing.Size(72, 22);
            this.lblStartX.TabIndex = 2;
            this.lblStartX.Text = "Start X :";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(884, 659);
            this.picBox.TabIndex = 8;
            this.picBox.TabStop = false;
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            // 
            // RoofFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 683);
            this.Controls.Add(this.PropertiBox);
            this.Controls.Add(this.picBox);
            this.Location = new System.Drawing.Point(1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoofFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Roof Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RoofFrm_Load);
            this.PropertiBox.ResumeLayout(false);
            this.PropertiBox.PerformLayout();
            this.NamePosBox.ResumeLayout(false);
            this.NamePosBox.PerformLayout();
            this.BSSizeBox.ResumeLayout(false);
            this.BSSizeBox.PerformLayout();
            this.MatDetBox.ResumeLayout(false);
            this.MatDetBox.PerformLayout();
            this.BSPosBox.ResumeLayout(false);
            this.BSPosBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PropertiBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ShowContorlBtn;
        private System.Windows.Forms.GroupBox NamePosBox;
        private System.Windows.Forms.TextBox txtNmY;
        private System.Windows.Forms.Label lblNmY;
        private System.Windows.Forms.TextBox txtNmX;
        private System.Windows.Forms.Label lblNmX;
        private System.Windows.Forms.GroupBox BSSizeBox;
        private System.Windows.Forms.TextBox txtRfLengthIn;
        private System.Windows.Forms.TextBox txtRfLengthFt;
        private System.Windows.Forms.Label lblBSLength;
        private System.Windows.Forms.TextBox txtRfThickIn;
        private System.Windows.Forms.TextBox txtRfThickFt;
        private System.Windows.Forms.Label lblBSThick;
        private System.Windows.Forms.TextBox txtRfWidthIn;
        private System.Windows.Forms.TextBox txtRfWidthFt;
        private System.Windows.Forms.Label lblBSWidth;
        private System.Windows.Forms.GroupBox MatDetBox;
        private System.Windows.Forms.Label lblMatRatio;
        private System.Windows.Forms.TextBox txtCement;
        private System.Windows.Forms.Label lblCement;
        private System.Windows.Forms.TextBox txtStone;
        private System.Windows.Forms.Label lblStone;
        private System.Windows.Forms.TextBox txtSand;
        private System.Windows.Forms.Label lblSand;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox BSPosBox;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblEndY;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblEndX;
        private System.Windows.Forms.TextBox txtStartY;
        private System.Windows.Forms.Label lblStartY;
        private System.Windows.Forms.TextBox txtStartX;
        private System.Windows.Forms.Label lblStartX;
        private System.Windows.Forms.PictureBox picBox;
    }
}