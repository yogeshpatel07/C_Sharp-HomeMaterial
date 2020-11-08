namespace MaterialEstimate
{
    partial class BeamFrm
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
            this.BmSizeBox = new System.Windows.Forms.GroupBox();
            this.txtBmLengthIn = new System.Windows.Forms.TextBox();
            this.txtBmLengthFt = new System.Windows.Forms.TextBox();
            this.lblBmLength = new System.Windows.Forms.Label();
            this.txtBmBreadthIn = new System.Windows.Forms.TextBox();
            this.txtBmBreadthFt = new System.Windows.Forms.TextBox();
            this.lblBmBreadth = new System.Windows.Forms.Label();
            this.txtBmHeightIn = new System.Windows.Forms.TextBox();
            this.txtBmHeightFt = new System.Windows.Forms.TextBox();
            this.lblBmHeight = new System.Windows.Forms.Label();
            this.MatDetBox = new System.Windows.Forms.GroupBox();
            this.lblMatRatio = new System.Windows.Forms.Label();
            this.txtRods = new System.Windows.Forms.TextBox();
            this.lblRods = new System.Windows.Forms.Label();
            this.txtCement = new System.Windows.Forms.TextBox();
            this.lblCement = new System.Windows.Forms.Label();
            this.txtStone = new System.Windows.Forms.TextBox();
            this.lblStone = new System.Windows.Forms.Label();
            this.txtSand = new System.Windows.Forms.TextBox();
            this.lblSand = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.BmPosBox = new System.Windows.Forms.GroupBox();
            this.txtEndY = new System.Windows.Forms.TextBox();
            this.lblEndY = new System.Windows.Forms.Label();
            this.txtEndX = new System.Windows.Forms.TextBox();
            this.lblEndX = new System.Windows.Forms.Label();
            this.txtStartY = new System.Windows.Forms.TextBox();
            this.lblStartY = new System.Windows.Forms.Label();
            this.txtStartX = new System.Windows.Forms.TextBox();
            this.lblStartX = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.PropertiBox.SuspendLayout();
            this.NamePosBox.SuspendLayout();
            this.BmSizeBox.SuspendLayout();
            this.MatDetBox.SuspendLayout();
            this.BmPosBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertiBox
            // 
            this.PropertiBox.Controls.Add(this.SaveBtn);
            this.PropertiBox.Controls.Add(this.ShowContorlBtn);
            this.PropertiBox.Controls.Add(this.NamePosBox);
            this.PropertiBox.Controls.Add(this.BmSizeBox);
            this.PropertiBox.Controls.Add(this.MatDetBox);
            this.PropertiBox.Controls.Add(this.lblStatus);
            this.PropertiBox.Controls.Add(this.BmPosBox);
            this.PropertiBox.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiBox.Location = new System.Drawing.Point(902, 12);
            this.PropertiBox.Name = "PropertiBox";
            this.PropertiBox.Size = new System.Drawing.Size(404, 659);
            this.PropertiBox.TabIndex = 5;
            this.PropertiBox.TabStop = false;
            this.PropertiBox.Text = "Beam Properties";
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
            // BmSizeBox
            // 
            this.BmSizeBox.Controls.Add(this.txtBmLengthIn);
            this.BmSizeBox.Controls.Add(this.txtBmLengthFt);
            this.BmSizeBox.Controls.Add(this.lblBmLength);
            this.BmSizeBox.Controls.Add(this.txtBmBreadthIn);
            this.BmSizeBox.Controls.Add(this.txtBmBreadthFt);
            this.BmSizeBox.Controls.Add(this.lblBmBreadth);
            this.BmSizeBox.Controls.Add(this.txtBmHeightIn);
            this.BmSizeBox.Controls.Add(this.txtBmHeightFt);
            this.BmSizeBox.Controls.Add(this.lblBmHeight);
            this.BmSizeBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmSizeBox.Location = new System.Drawing.Point(6, 211);
            this.BmSizeBox.Name = "BmSizeBox";
            this.BmSizeBox.Size = new System.Drawing.Size(191, 141);
            this.BmSizeBox.TabIndex = 1;
            this.BmSizeBox.TabStop = false;
            this.BmSizeBox.Text = "Beam Size";
            // 
            // txtBmLengthIn
            // 
            this.txtBmLengthIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtBmLengthIn.Location = new System.Drawing.Point(143, 29);
            this.txtBmLengthIn.Name = "txtBmLengthIn";
            this.txtBmLengthIn.Size = new System.Drawing.Size(39, 26);
            this.txtBmLengthIn.TabIndex = 1;
            this.txtBmLengthIn.Text = "0";
            // 
            // txtBmLengthFt
            // 
            this.txtBmLengthFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtBmLengthFt.Location = new System.Drawing.Point(98, 29);
            this.txtBmLengthFt.Name = "txtBmLengthFt";
            this.txtBmLengthFt.Size = new System.Drawing.Size(39, 26);
            this.txtBmLengthFt.TabIndex = 0;
            this.txtBmLengthFt.Text = "10";
            // 
            // lblBmLength
            // 
            this.lblBmLength.AutoSize = true;
            this.lblBmLength.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmLength.Location = new System.Drawing.Point(6, 29);
            this.lblBmLength.Name = "lblBmLength";
            this.lblBmLength.Size = new System.Drawing.Size(86, 22);
            this.lblBmLength.TabIndex = 8;
            this.lblBmLength.Text = "Length    :";
            // 
            // txtBmBreadthIn
            // 
            this.txtBmBreadthIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtBmBreadthIn.Location = new System.Drawing.Point(145, 100);
            this.txtBmBreadthIn.Name = "txtBmBreadthIn";
            this.txtBmBreadthIn.Size = new System.Drawing.Size(39, 26);
            this.txtBmBreadthIn.TabIndex = 5;
            this.txtBmBreadthIn.Text = "9";
            // 
            // txtBmBreadthFt
            // 
            this.txtBmBreadthFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtBmBreadthFt.Location = new System.Drawing.Point(100, 100);
            this.txtBmBreadthFt.Name = "txtBmBreadthFt";
            this.txtBmBreadthFt.Size = new System.Drawing.Size(39, 26);
            this.txtBmBreadthFt.TabIndex = 4;
            this.txtBmBreadthFt.Text = "0";
            // 
            // lblBmBreadth
            // 
            this.lblBmBreadth.AutoSize = true;
            this.lblBmBreadth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmBreadth.Location = new System.Drawing.Point(8, 100);
            this.lblBmBreadth.Name = "lblBmBreadth";
            this.lblBmBreadth.Size = new System.Drawing.Size(85, 22);
            this.lblBmBreadth.TabIndex = 5;
            this.lblBmBreadth.Text = "Width     :";
            // 
            // txtBmHeightIn
            // 
            this.txtBmHeightIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtBmHeightIn.Location = new System.Drawing.Point(145, 65);
            this.txtBmHeightIn.Name = "txtBmHeightIn";
            this.txtBmHeightIn.Size = new System.Drawing.Size(39, 26);
            this.txtBmHeightIn.TabIndex = 3;
            this.txtBmHeightIn.Text = "9";
            // 
            // txtBmHeightFt
            // 
            this.txtBmHeightFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtBmHeightFt.Location = new System.Drawing.Point(100, 65);
            this.txtBmHeightFt.Name = "txtBmHeightFt";
            this.txtBmHeightFt.Size = new System.Drawing.Size(39, 26);
            this.txtBmHeightFt.TabIndex = 2;
            this.txtBmHeightFt.Text = "0";
            // 
            // lblBmHeight
            // 
            this.lblBmHeight.AutoSize = true;
            this.lblBmHeight.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmHeight.Location = new System.Drawing.Point(8, 65);
            this.lblBmHeight.Name = "lblBmHeight";
            this.lblBmHeight.Size = new System.Drawing.Size(83, 22);
            this.lblBmHeight.TabIndex = 2;
            this.lblBmHeight.Text = "Thick.     :";
            // 
            // MatDetBox
            // 
            this.MatDetBox.Controls.Add(this.lblMatRatio);
            this.MatDetBox.Controls.Add(this.txtRods);
            this.MatDetBox.Controls.Add(this.lblRods);
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
            // txtRods
            // 
            this.txtRods.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtRods.Location = new System.Drawing.Point(142, 170);
            this.txtRods.Name = "txtRods";
            this.txtRods.Size = new System.Drawing.Size(39, 26);
            this.txtRods.TabIndex = 3;
            this.txtRods.Text = "4";
            // 
            // lblRods
            // 
            this.lblRods.AutoSize = true;
            this.lblRods.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRods.Location = new System.Drawing.Point(5, 170);
            this.lblRods.Name = "lblRods";
            this.lblRods.Size = new System.Drawing.Size(115, 22);
            this.lblRods.TabIndex = 11;
            this.lblRods.Text = "No. of Rods  :";
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
            // BmPosBox
            // 
            this.BmPosBox.Controls.Add(this.txtEndY);
            this.BmPosBox.Controls.Add(this.lblEndY);
            this.BmPosBox.Controls.Add(this.txtEndX);
            this.BmPosBox.Controls.Add(this.lblEndX);
            this.BmPosBox.Controls.Add(this.txtStartY);
            this.BmPosBox.Controls.Add(this.lblStartY);
            this.BmPosBox.Controls.Add(this.txtStartX);
            this.BmPosBox.Controls.Add(this.lblStartX);
            this.BmPosBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmPosBox.Location = new System.Drawing.Point(6, 38);
            this.BmPosBox.Name = "BmPosBox";
            this.BmPosBox.Size = new System.Drawing.Size(191, 167);
            this.BmPosBox.TabIndex = 0;
            this.BmPosBox.TabStop = false;
            this.BmPosBox.Text = "Beam Position";
            // 
            // txtEndY
            // 
            this.txtEndY.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtEndY.Location = new System.Drawing.Point(98, 128);
            this.txtEndY.Name = "txtEndY";
            this.txtEndY.Size = new System.Drawing.Size(84, 26);
            this.txtEndY.TabIndex = 3;
            this.txtEndY.Text = "0";
            this.txtEndY.Leave += new System.EventHandler(this.txtEndY_Leave);
            // 
            // lblEndY
            // 
            this.lblEndY.AutoSize = true;
            this.lblEndY.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndY.Location = new System.Drawing.Point(5, 128);
            this.lblEndY.Name = "lblEndY";
            this.lblEndY.Size = new System.Drawing.Size(75, 22);
            this.lblEndY.TabIndex = 9;
            this.lblEndY.Text = "End Y   :";
            // 
            // txtEndX
            // 
            this.txtEndX.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtEndX.Location = new System.Drawing.Point(98, 95);
            this.txtEndX.Name = "txtEndX";
            this.txtEndX.Size = new System.Drawing.Size(84, 26);
            this.txtEndX.TabIndex = 2;
            this.txtEndX.Text = "0";
            this.txtEndX.Leave += new System.EventHandler(this.txtEndX_Leave);
            // 
            // lblEndX
            // 
            this.lblEndX.AutoSize = true;
            this.lblEndX.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndX.Location = new System.Drawing.Point(6, 95);
            this.lblEndX.Name = "lblEndX";
            this.lblEndX.Size = new System.Drawing.Size(75, 22);
            this.lblEndX.TabIndex = 8;
            this.lblEndX.Text = "End X   :";
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
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            // 
            // BeamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 683);
            this.Controls.Add(this.PropertiBox);
            this.Controls.Add(this.picBox);
            this.Location = new System.Drawing.Point(1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BeamFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Beam Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BeamFrm_Load);
            this.PropertiBox.ResumeLayout(false);
            this.PropertiBox.PerformLayout();
            this.NamePosBox.ResumeLayout(false);
            this.NamePosBox.PerformLayout();
            this.BmSizeBox.ResumeLayout(false);
            this.BmSizeBox.PerformLayout();
            this.MatDetBox.ResumeLayout(false);
            this.MatDetBox.PerformLayout();
            this.BmPosBox.ResumeLayout(false);
            this.BmPosBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PropertiBox;
        private System.Windows.Forms.Button ShowContorlBtn;
        private System.Windows.Forms.GroupBox NamePosBox;
        private System.Windows.Forms.TextBox txtNmY;
        private System.Windows.Forms.Label lblNmY;
        private System.Windows.Forms.TextBox txtNmX;
        private System.Windows.Forms.Label lblNmX;
        private System.Windows.Forms.GroupBox BmSizeBox;
        private System.Windows.Forms.TextBox txtBmLengthIn;
        private System.Windows.Forms.TextBox txtBmLengthFt;
        private System.Windows.Forms.Label lblBmLength;
        private System.Windows.Forms.TextBox txtBmBreadthIn;
        private System.Windows.Forms.TextBox txtBmBreadthFt;
        private System.Windows.Forms.Label lblBmBreadth;
        private System.Windows.Forms.TextBox txtBmHeightIn;
        private System.Windows.Forms.TextBox txtBmHeightFt;
        private System.Windows.Forms.Label lblBmHeight;
        private System.Windows.Forms.GroupBox MatDetBox;
        private System.Windows.Forms.Label lblMatRatio;
        private System.Windows.Forms.TextBox txtRods;
        private System.Windows.Forms.Label lblRods;
        private System.Windows.Forms.TextBox txtCement;
        private System.Windows.Forms.Label lblCement;
        private System.Windows.Forms.TextBox txtStone;
        private System.Windows.Forms.Label lblStone;
        private System.Windows.Forms.TextBox txtSand;
        private System.Windows.Forms.Label lblSand;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox BmPosBox;
        private System.Windows.Forms.TextBox txtStartY;
        private System.Windows.Forms.Label lblStartY;
        private System.Windows.Forms.TextBox txtStartX;
        private System.Windows.Forms.Label lblStartX;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox txtEndY;
        private System.Windows.Forms.Label lblEndY;
        private System.Windows.Forms.TextBox txtEndX;
        private System.Windows.Forms.Label lblEndX;
        private System.Windows.Forms.Button SaveBtn;
    }
}