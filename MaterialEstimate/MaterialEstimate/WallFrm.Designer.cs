namespace MaterialEstimate
{
    partial class WallFrm
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
            this.BmsDetBox = new System.Windows.Forms.GroupBox();
            this.RmvAllBmsBtn = new System.Windows.Forms.Button();
            this.RmvBmsBtn = new System.Windows.Forms.Button();
            this.AddBmsBtn = new System.Windows.Forms.Button();
            this.cmbBms = new System.Windows.Forms.ComboBox();
            this.lstBms = new System.Windows.Forms.ListBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ShowContorlBtn = new System.Windows.Forms.Button();
            this.NamePosBox = new System.Windows.Forms.GroupBox();
            this.txtNmY = new System.Windows.Forms.TextBox();
            this.lblNmY = new System.Windows.Forms.Label();
            this.txtNmX = new System.Windows.Forms.TextBox();
            this.lblNmX = new System.Windows.Forms.Label();
            this.WlSizeBox = new System.Windows.Forms.GroupBox();
            this.cmbBreadth = new System.Windows.Forms.ComboBox();
            this.txtWlLengthIn = new System.Windows.Forms.TextBox();
            this.txtWlLengthFt = new System.Windows.Forms.TextBox();
            this.lblWlLength = new System.Windows.Forms.Label();
            this.lblWlBreadth = new System.Windows.Forms.Label();
            this.txtWlHeightIn = new System.Windows.Forms.TextBox();
            this.txtWlHeightFt = new System.Windows.Forms.TextBox();
            this.lblWlHeight = new System.Windows.Forms.Label();
            this.MatDetBox = new System.Windows.Forms.GroupBox();
            this.PlstMatBox = new System.Windows.Forms.GroupBox();
            this.lblPlstMatRt = new System.Windows.Forms.Label();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.lblPlstSd = new System.Windows.Forms.Label();
            this.txtPlstCement = new System.Windows.Forms.TextBox();
            this.lblPlstCement = new System.Windows.Forms.Label();
            this.txtPlstSand = new System.Windows.Forms.TextBox();
            this.lblPlstSand = new System.Windows.Forms.Label();
            this.txtPlstTk = new System.Windows.Forms.TextBox();
            this.lblPlstTk = new System.Windows.Forms.Label();
            this.lblPlstHd = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.lblAddPlst = new System.Windows.Forms.Label();
            this.lblMatRatio = new System.Windows.Forms.Label();
            this.txtCement = new System.Windows.Forms.TextBox();
            this.lblCement = new System.Windows.Forms.Label();
            this.txtSand = new System.Windows.Forms.TextBox();
            this.lblSand = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.WlPosBox = new System.Windows.Forms.GroupBox();
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
            this.BmsDetBox.SuspendLayout();
            this.NamePosBox.SuspendLayout();
            this.WlSizeBox.SuspendLayout();
            this.MatDetBox.SuspendLayout();
            this.PlstMatBox.SuspendLayout();
            this.WlPosBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertiBox
            // 
            this.PropertiBox.Controls.Add(this.BmsDetBox);
            this.PropertiBox.Controls.Add(this.SaveBtn);
            this.PropertiBox.Controls.Add(this.ShowContorlBtn);
            this.PropertiBox.Controls.Add(this.NamePosBox);
            this.PropertiBox.Controls.Add(this.WlSizeBox);
            this.PropertiBox.Controls.Add(this.MatDetBox);
            this.PropertiBox.Controls.Add(this.lblStatus);
            this.PropertiBox.Controls.Add(this.WlPosBox);
            this.PropertiBox.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiBox.Location = new System.Drawing.Point(902, 12);
            this.PropertiBox.Name = "PropertiBox";
            this.PropertiBox.Size = new System.Drawing.Size(404, 659);
            this.PropertiBox.TabIndex = 7;
            this.PropertiBox.TabStop = false;
            this.PropertiBox.Text = "Wall Properties";
            // 
            // BmsDetBox
            // 
            this.BmsDetBox.Controls.Add(this.RmvAllBmsBtn);
            this.BmsDetBox.Controls.Add(this.RmvBmsBtn);
            this.BmsDetBox.Controls.Add(this.AddBmsBtn);
            this.BmsDetBox.Controls.Add(this.cmbBms);
            this.BmsDetBox.Controls.Add(this.lstBms);
            this.BmsDetBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmsDetBox.Location = new System.Drawing.Point(6, 358);
            this.BmsDetBox.Name = "BmsDetBox";
            this.BmsDetBox.Size = new System.Drawing.Size(191, 167);
            this.BmsDetBox.TabIndex = 2;
            this.BmsDetBox.TabStop = false;
            this.BmsDetBox.Text = "Beams in Wall";
            // 
            // RmvAllBmsBtn
            // 
            this.RmvAllBmsBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmvAllBmsBtn.Location = new System.Drawing.Point(83, 132);
            this.RmvAllBmsBtn.Name = "RmvAllBmsBtn";
            this.RmvAllBmsBtn.Size = new System.Drawing.Size(100, 27);
            this.RmvAllBmsBtn.TabIndex = 4;
            this.RmvAllBmsBtn.Text = "Remove All";
            this.RmvAllBmsBtn.UseVisualStyleBackColor = true;
            this.RmvAllBmsBtn.Click += new System.EventHandler(this.RmvAllBmsBtn_Click);
            // 
            // RmvBmsBtn
            // 
            this.RmvBmsBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmvBmsBtn.Location = new System.Drawing.Point(82, 99);
            this.RmvBmsBtn.Name = "RmvBmsBtn";
            this.RmvBmsBtn.Size = new System.Drawing.Size(100, 27);
            this.RmvBmsBtn.TabIndex = 3;
            this.RmvBmsBtn.Text = "Remove";
            this.RmvBmsBtn.UseVisualStyleBackColor = true;
            this.RmvBmsBtn.Click += new System.EventHandler(this.RmvBmsBtn_Click);
            // 
            // AddBmsBtn
            // 
            this.AddBmsBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBmsBtn.Location = new System.Drawing.Point(82, 66);
            this.AddBmsBtn.Name = "AddBmsBtn";
            this.AddBmsBtn.Size = new System.Drawing.Size(100, 27);
            this.AddBmsBtn.TabIndex = 2;
            this.AddBmsBtn.Text = "Add";
            this.AddBmsBtn.UseVisualStyleBackColor = true;
            this.AddBmsBtn.Click += new System.EventHandler(this.AddBmsBtn_Click);
            // 
            // cmbBms
            // 
            this.cmbBms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBms.Font = new System.Drawing.Font("Cambria", 12F);
            this.cmbBms.FormattingEnabled = true;
            this.cmbBms.Location = new System.Drawing.Point(83, 33);
            this.cmbBms.Name = "cmbBms";
            this.cmbBms.Size = new System.Drawing.Size(99, 27);
            this.cmbBms.TabIndex = 1;
            // 
            // lstBms
            // 
            this.lstBms.Font = new System.Drawing.Font("Cambria", 14F);
            this.lstBms.FormattingEnabled = true;
            this.lstBms.ItemHeight = 22;
            this.lstBms.Location = new System.Drawing.Point(9, 25);
            this.lstBms.Name = "lstBms";
            this.lstBms.Size = new System.Drawing.Size(67, 136);
            this.lstBms.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(6, 531);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(392, 44);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ShowContorlBtn
            // 
            this.ShowContorlBtn.Enabled = false;
            this.ShowContorlBtn.Location = new System.Drawing.Point(6, 609);
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
            this.NamePosBox.Location = new System.Drawing.Point(203, 428);
            this.NamePosBox.Name = "NamePosBox";
            this.NamePosBox.Size = new System.Drawing.Size(191, 97);
            this.NamePosBox.TabIndex = 4;
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
            // WlSizeBox
            // 
            this.WlSizeBox.Controls.Add(this.cmbBreadth);
            this.WlSizeBox.Controls.Add(this.txtWlLengthIn);
            this.WlSizeBox.Controls.Add(this.txtWlLengthFt);
            this.WlSizeBox.Controls.Add(this.lblWlLength);
            this.WlSizeBox.Controls.Add(this.lblWlBreadth);
            this.WlSizeBox.Controls.Add(this.txtWlHeightIn);
            this.WlSizeBox.Controls.Add(this.txtWlHeightFt);
            this.WlSizeBox.Controls.Add(this.lblWlHeight);
            this.WlSizeBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WlSizeBox.Location = new System.Drawing.Point(6, 211);
            this.WlSizeBox.Name = "WlSizeBox";
            this.WlSizeBox.Size = new System.Drawing.Size(191, 141);
            this.WlSizeBox.TabIndex = 1;
            this.WlSizeBox.TabStop = false;
            this.WlSizeBox.Text = "Wall Size";
            // 
            // cmbBreadth
            // 
            this.cmbBreadth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreadth.Font = new System.Drawing.Font("Cambria", 12F);
            this.cmbBreadth.FormattingEnabled = true;
            this.cmbBreadth.Items.AddRange(new object[] {
            "0.33",
            "0.75",
            "1.66"});
            this.cmbBreadth.Location = new System.Drawing.Point(98, 69);
            this.cmbBreadth.Name = "cmbBreadth";
            this.cmbBreadth.Size = new System.Drawing.Size(84, 27);
            this.cmbBreadth.TabIndex = 2;
            // 
            // txtWlLengthIn
            // 
            this.txtWlLengthIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWlLengthIn.Location = new System.Drawing.Point(143, 106);
            this.txtWlLengthIn.Name = "txtWlLengthIn";
            this.txtWlLengthIn.Size = new System.Drawing.Size(39, 26);
            this.txtWlLengthIn.TabIndex = 4;
            this.txtWlLengthIn.Text = "0";
            // 
            // txtWlLengthFt
            // 
            this.txtWlLengthFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWlLengthFt.Location = new System.Drawing.Point(98, 106);
            this.txtWlLengthFt.Name = "txtWlLengthFt";
            this.txtWlLengthFt.Size = new System.Drawing.Size(39, 26);
            this.txtWlLengthFt.TabIndex = 3;
            this.txtWlLengthFt.Text = "10";
            // 
            // lblWlLength
            // 
            this.lblWlLength.AutoSize = true;
            this.lblWlLength.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWlLength.Location = new System.Drawing.Point(6, 106);
            this.lblWlLength.Name = "lblWlLength";
            this.lblWlLength.Size = new System.Drawing.Size(86, 22);
            this.lblWlLength.TabIndex = 8;
            this.lblWlLength.Text = "Length    :";
            // 
            // lblWlBreadth
            // 
            this.lblWlBreadth.AutoSize = true;
            this.lblWlBreadth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWlBreadth.Location = new System.Drawing.Point(6, 72);
            this.lblWlBreadth.Name = "lblWlBreadth";
            this.lblWlBreadth.Size = new System.Drawing.Size(83, 22);
            this.lblWlBreadth.TabIndex = 5;
            this.lblWlBreadth.Text = "Thick.     :";
            // 
            // txtWlHeightIn
            // 
            this.txtWlHeightIn.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWlHeightIn.Location = new System.Drawing.Point(143, 37);
            this.txtWlHeightIn.Name = "txtWlHeightIn";
            this.txtWlHeightIn.Size = new System.Drawing.Size(39, 26);
            this.txtWlHeightIn.TabIndex = 1;
            this.txtWlHeightIn.Text = "0";
            // 
            // txtWlHeightFt
            // 
            this.txtWlHeightFt.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtWlHeightFt.Location = new System.Drawing.Point(98, 37);
            this.txtWlHeightFt.Name = "txtWlHeightFt";
            this.txtWlHeightFt.Size = new System.Drawing.Size(39, 26);
            this.txtWlHeightFt.TabIndex = 0;
            this.txtWlHeightFt.Text = "10";
            // 
            // lblWlHeight
            // 
            this.lblWlHeight.AutoSize = true;
            this.lblWlHeight.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWlHeight.Location = new System.Drawing.Point(6, 37);
            this.lblWlHeight.Name = "lblWlHeight";
            this.lblWlHeight.Size = new System.Drawing.Size(83, 22);
            this.lblWlHeight.TabIndex = 2;
            this.lblWlHeight.Text = "Height    :";
            // 
            // MatDetBox
            // 
            this.MatDetBox.Controls.Add(this.PlstMatBox);
            this.MatDetBox.Controls.Add(this.lblPlstHd);
            this.MatDetBox.Controls.Add(this.rbNo);
            this.MatDetBox.Controls.Add(this.rbYes);
            this.MatDetBox.Controls.Add(this.lblAddPlst);
            this.MatDetBox.Controls.Add(this.lblMatRatio);
            this.MatDetBox.Controls.Add(this.txtCement);
            this.MatDetBox.Controls.Add(this.lblCement);
            this.MatDetBox.Controls.Add(this.txtSand);
            this.MatDetBox.Controls.Add(this.lblSand);
            this.MatDetBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatDetBox.Location = new System.Drawing.Point(203, 38);
            this.MatDetBox.Name = "MatDetBox";
            this.MatDetBox.Size = new System.Drawing.Size(191, 391);
            this.MatDetBox.TabIndex = 3;
            this.MatDetBox.TabStop = false;
            this.MatDetBox.Text = "Material Details";
            // 
            // PlstMatBox
            // 
            this.PlstMatBox.Controls.Add(this.lblPlstMatRt);
            this.PlstMatBox.Controls.Add(this.rbOne);
            this.PlstMatBox.Controls.Add(this.rbBoth);
            this.PlstMatBox.Controls.Add(this.lblPlstSd);
            this.PlstMatBox.Controls.Add(this.txtPlstCement);
            this.PlstMatBox.Controls.Add(this.lblPlstCement);
            this.PlstMatBox.Controls.Add(this.txtPlstSand);
            this.PlstMatBox.Controls.Add(this.lblPlstSand);
            this.PlstMatBox.Controls.Add(this.txtPlstTk);
            this.PlstMatBox.Controls.Add(this.lblPlstTk);
            this.PlstMatBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlstMatBox.Location = new System.Drawing.Point(0, 186);
            this.PlstMatBox.Name = "PlstMatBox";
            this.PlstMatBox.Size = new System.Drawing.Size(191, 199);
            this.PlstMatBox.TabIndex = 4;
            this.PlstMatBox.TabStop = false;
            this.PlstMatBox.Text = "Plaster Details";
            // 
            // lblPlstMatRt
            // 
            this.lblPlstMatRt.AutoSize = true;
            this.lblPlstMatRt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlstMatRt.Location = new System.Drawing.Point(20, 57);
            this.lblPlstMatRt.Name = "lblPlstMatRt";
            this.lblPlstMatRt.Size = new System.Drawing.Size(143, 22);
            this.lblPlstMatRt.TabIndex = 20;
            this.lblPlstMatRt.Text = "Material in Ratio";
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOne.Location = new System.Drawing.Point(130, 162);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(51, 21);
            this.rbOne.TabIndex = 4;
            this.rbOne.Text = "One";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Checked = true;
            this.rbBoth.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBoth.Location = new System.Drawing.Point(72, 162);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(56, 21);
            this.rbBoth.TabIndex = 3;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "Both";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // lblPlstSd
            // 
            this.lblPlstSd.AutoSize = true;
            this.lblPlstSd.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlstSd.Location = new System.Drawing.Point(6, 161);
            this.lblPlstSd.Name = "lblPlstSd";
            this.lblPlstSd.Size = new System.Drawing.Size(60, 22);
            this.lblPlstSd.TabIndex = 19;
            this.lblPlstSd.Text = "Sides?";
            // 
            // txtPlstCement
            // 
            this.txtPlstCement.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtPlstCement.Location = new System.Drawing.Point(144, 128);
            this.txtPlstCement.Name = "txtPlstCement";
            this.txtPlstCement.Size = new System.Drawing.Size(39, 26);
            this.txtPlstCement.TabIndex = 2;
            this.txtPlstCement.Text = "1";
            // 
            // lblPlstCement
            // 
            this.lblPlstCement.AutoSize = true;
            this.lblPlstCement.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlstCement.Location = new System.Drawing.Point(7, 128);
            this.lblPlstCement.Name = "lblPlstCement";
            this.lblPlstCement.Size = new System.Drawing.Size(113, 22);
            this.lblPlstCement.TabIndex = 12;
            this.lblPlstCement.Text = "Cement         :";
            // 
            // txtPlstSand
            // 
            this.txtPlstSand.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtPlstSand.Location = new System.Drawing.Point(143, 91);
            this.txtPlstSand.Name = "txtPlstSand";
            this.txtPlstSand.Size = new System.Drawing.Size(39, 26);
            this.txtPlstSand.TabIndex = 1;
            this.txtPlstSand.Text = "15";
            // 
            // lblPlstSand
            // 
            this.lblPlstSand.AutoSize = true;
            this.lblPlstSand.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlstSand.Location = new System.Drawing.Point(6, 91);
            this.lblPlstSand.Name = "lblPlstSand";
            this.lblPlstSand.Size = new System.Drawing.Size(112, 22);
            this.lblPlstSand.TabIndex = 11;
            this.lblPlstSand.Text = "Sand(Ret)    :";
            // 
            // txtPlstTk
            // 
            this.txtPlstTk.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtPlstTk.Location = new System.Drawing.Point(143, 28);
            this.txtPlstTk.Name = "txtPlstTk";
            this.txtPlstTk.Size = new System.Drawing.Size(39, 26);
            this.txtPlstTk.TabIndex = 0;
            this.txtPlstTk.Text = "1";
            // 
            // lblPlstTk
            // 
            this.lblPlstTk.AutoSize = true;
            this.lblPlstTk.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlstTk.Location = new System.Drawing.Point(6, 28);
            this.lblPlstTk.Name = "lblPlstTk";
            this.lblPlstTk.Size = new System.Drawing.Size(139, 22);
            this.lblPlstTk.TabIndex = 2;
            this.lblPlstTk.Text = "Thickness(Inch)";
            // 
            // lblPlstHd
            // 
            this.lblPlstHd.AutoSize = true;
            this.lblPlstHd.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlstHd.Location = new System.Drawing.Point(20, 132);
            this.lblPlstHd.Name = "lblPlstHd";
            this.lblPlstHd.Size = new System.Drawing.Size(149, 22);
            this.lblPlstHd.TabIndex = 17;
            this.lblPlstHd.Text = "Plaster (Chhapai)";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(138, 165);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(44, 21);
            this.rbNo.TabIndex = 3;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(85, 165);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(47, 21);
            this.rbYes.TabIndex = 2;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // lblAddPlst
            // 
            this.lblAddPlst.AutoSize = true;
            this.lblAddPlst.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPlst.Location = new System.Drawing.Point(7, 163);
            this.lblAddPlst.Name = "lblAddPlst";
            this.lblAddPlst.Size = new System.Drawing.Size(74, 22);
            this.lblAddPlst.TabIndex = 16;
            this.lblAddPlst.Text = "Plaster?";
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
            this.txtCement.Location = new System.Drawing.Point(143, 94);
            this.txtCement.Name = "txtCement";
            this.txtCement.Size = new System.Drawing.Size(39, 26);
            this.txtCement.TabIndex = 1;
            this.txtCement.Text = "1";
            // 
            // lblCement
            // 
            this.lblCement.AutoSize = true;
            this.lblCement.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCement.Location = new System.Drawing.Point(6, 94);
            this.lblCement.Name = "lblCement";
            this.lblCement.Size = new System.Drawing.Size(113, 22);
            this.lblCement.TabIndex = 8;
            this.lblCement.Text = "Cement         :";
            // 
            // txtSand
            // 
            this.txtSand.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtSand.Location = new System.Drawing.Point(143, 62);
            this.txtSand.Name = "txtSand";
            this.txtSand.Size = new System.Drawing.Size(39, 26);
            this.txtSand.TabIndex = 0;
            this.txtSand.Text = "15";
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
            this.lblStatus.Location = new System.Drawing.Point(10, 578);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 28);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status :";
            // 
            // WlPosBox
            // 
            this.WlPosBox.Controls.Add(this.txtEndY);
            this.WlPosBox.Controls.Add(this.lblEndY);
            this.WlPosBox.Controls.Add(this.txtEndX);
            this.WlPosBox.Controls.Add(this.lblEndX);
            this.WlPosBox.Controls.Add(this.txtStartY);
            this.WlPosBox.Controls.Add(this.lblStartY);
            this.WlPosBox.Controls.Add(this.txtStartX);
            this.WlPosBox.Controls.Add(this.lblStartX);
            this.WlPosBox.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WlPosBox.Location = new System.Drawing.Point(6, 38);
            this.WlPosBox.Name = "WlPosBox";
            this.WlPosBox.Size = new System.Drawing.Size(191, 167);
            this.WlPosBox.TabIndex = 0;
            this.WlPosBox.TabStop = false;
            this.WlPosBox.Text = "Wall Position";
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
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            // 
            // WallFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 683);
            this.Controls.Add(this.PropertiBox);
            this.Controls.Add(this.picBox);
            this.Location = new System.Drawing.Point(1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WallFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Wall Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WallFrm_Load);
            this.PropertiBox.ResumeLayout(false);
            this.PropertiBox.PerformLayout();
            this.BmsDetBox.ResumeLayout(false);
            this.NamePosBox.ResumeLayout(false);
            this.NamePosBox.PerformLayout();
            this.WlSizeBox.ResumeLayout(false);
            this.WlSizeBox.PerformLayout();
            this.MatDetBox.ResumeLayout(false);
            this.MatDetBox.PerformLayout();
            this.PlstMatBox.ResumeLayout(false);
            this.PlstMatBox.PerformLayout();
            this.WlPosBox.ResumeLayout(false);
            this.WlPosBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox WlSizeBox;
        private System.Windows.Forms.TextBox txtWlLengthIn;
        private System.Windows.Forms.TextBox txtWlLengthFt;
        private System.Windows.Forms.Label lblWlLength;
        private System.Windows.Forms.Label lblWlBreadth;
        private System.Windows.Forms.TextBox txtWlHeightIn;
        private System.Windows.Forms.TextBox txtWlHeightFt;
        private System.Windows.Forms.Label lblWlHeight;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox WlPosBox;
        private System.Windows.Forms.TextBox txtEndY;
        private System.Windows.Forms.Label lblEndY;
        private System.Windows.Forms.TextBox txtEndX;
        private System.Windows.Forms.Label lblEndX;
        private System.Windows.Forms.TextBox txtStartY;
        private System.Windows.Forms.Label lblStartY;
        private System.Windows.Forms.TextBox txtStartX;
        private System.Windows.Forms.Label lblStartX;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox BmsDetBox;
        private System.Windows.Forms.ListBox lstBms;
        private System.Windows.Forms.Button AddBmsBtn;
        private System.Windows.Forms.ComboBox cmbBms;
        private System.Windows.Forms.Button RmvAllBmsBtn;
        private System.Windows.Forms.Button RmvBmsBtn;
        private System.Windows.Forms.ComboBox cmbBreadth;
        private System.Windows.Forms.GroupBox MatDetBox;
        private System.Windows.Forms.GroupBox PlstMatBox;
        private System.Windows.Forms.Label lblPlstMatRt;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.RadioButton rbBoth;
        private System.Windows.Forms.Label lblPlstSd;
        private System.Windows.Forms.TextBox txtPlstCement;
        private System.Windows.Forms.Label lblPlstCement;
        private System.Windows.Forms.TextBox txtPlstSand;
        private System.Windows.Forms.Label lblPlstSand;
        private System.Windows.Forms.TextBox txtPlstTk;
        private System.Windows.Forms.Label lblPlstTk;
        private System.Windows.Forms.Label lblPlstHd;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label lblAddPlst;
        private System.Windows.Forms.Label lblMatRatio;
        private System.Windows.Forms.TextBox txtCement;
        private System.Windows.Forms.Label lblCement;
        private System.Windows.Forms.TextBox txtSand;
        private System.Windows.Forms.Label lblSand;
    }
}