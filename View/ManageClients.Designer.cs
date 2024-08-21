namespace Bank_Project
{
    partial class ManageClients
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
            this.components = new System.ComponentModel.Container();
            this.gbLayout = new System.Windows.Forms.GroupBox();
            this.lbldateTime = new System.Windows.Forms.Label();
            this.BankPicBox = new System.Windows.Forms.PictureBox();
            this.tabControlClients = new System.Windows.Forms.TabControl();
            this.tpShowClients = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxClientSearch = new System.Windows.Forms.TextBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rbDescend = new System.Windows.Forms.RadioButton();
            this.rbAscend = new System.Windows.Forms.RadioButton();
            this.lblNumOfClients = new System.Windows.Forms.Label();
            this.ListViewClients = new System.Windows.Forms.ListView();
            this.colAccNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPinCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMSClients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpAddClient = new System.Windows.Forms.TabPage();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.numAddClientBalance = new System.Windows.Forms.NumericUpDown();
            this.txtAddClientPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddClientEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddClientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddClientPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddClientAccNo = new System.Windows.Forms.TextBox();
            this.tpUpdateClient = new System.Windows.Forms.TabPage();
            this.cbUpdateClientAccNo = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numUpdateClientBalance = new System.Windows.Forms.NumericUpDown();
            this.maskedTxtUpdateClientPhone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateClientEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateClientName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdateClientPin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ClientInfoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).BeginInit();
            this.tabControlClients.SuspendLayout();
            this.tpShowClients.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.CMSClients.SuspendLayout();
            this.tpAddClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddClientBalance)).BeginInit();
            this.tpUpdateClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateClientBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientInfoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLayout
            // 
            this.gbLayout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbLayout.Controls.Add(this.lbldateTime);
            this.gbLayout.Controls.Add(this.BankPicBox);
            this.gbLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbLayout.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.gbLayout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbLayout.Location = new System.Drawing.Point(0, 0);
            this.gbLayout.Name = "gbLayout";
            this.gbLayout.Size = new System.Drawing.Size(230, 688);
            this.gbLayout.TabIndex = 1;
            this.gbLayout.TabStop = false;
            // 
            // lbldateTime
            // 
            this.lbldateTime.AutoSize = true;
            this.lbldateTime.Location = new System.Drawing.Point(9, 639);
            this.lbldateTime.Name = "lbldateTime";
            this.lbldateTime.Size = new System.Drawing.Size(66, 17);
            this.lbldateTime.TabIndex = 1;
            this.lbldateTime.Text = "dateTime";
            // 
            // BankPicBox
            // 
            this.BankPicBox.Image = global::Bank_Project.Properties.Resources.BankPic;
            this.BankPicBox.Location = new System.Drawing.Point(10, 45);
            this.BankPicBox.Name = "BankPicBox";
            this.BankPicBox.Size = new System.Drawing.Size(212, 177);
            this.BankPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BankPicBox.TabIndex = 0;
            this.BankPicBox.TabStop = false;
            // 
            // tabControlClients
            // 
            this.tabControlClients.Controls.Add(this.tpShowClients);
            this.tabControlClients.Controls.Add(this.tpAddClient);
            this.tabControlClients.Controls.Add(this.tpUpdateClient);
            this.tabControlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlClients.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlClients.Location = new System.Drawing.Point(230, 0);
            this.tabControlClients.Name = "tabControlClients";
            this.tabControlClients.SelectedIndex = 0;
            this.tabControlClients.Size = new System.Drawing.Size(1052, 688);
            this.tabControlClients.TabIndex = 2;
            // 
            // tpShowClients
            // 
            this.tpShowClients.Controls.Add(this.label16);
            this.tpShowClients.Controls.Add(this.txtBoxClientSearch);
            this.tpShowClients.Controls.Add(this.gbSort);
            this.tpShowClients.Controls.Add(this.lblNumOfClients);
            this.tpShowClients.Controls.Add(this.ListViewClients);
            this.tpShowClients.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpShowClients.Location = new System.Drawing.Point(4, 30);
            this.tpShowClients.Name = "tpShowClients";
            this.tpShowClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowClients.Size = new System.Drawing.Size(1044, 654);
            this.tpShowClients.TabIndex = 0;
            this.tpShowClients.Text = "Show Clients";
            this.tpShowClients.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(24, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 24);
            this.label16.TabIndex = 9;
            this.label16.Text = "Search By Acc. No.";
            // 
            // txtBoxClientSearch
            // 
            this.txtBoxClientSearch.Location = new System.Drawing.Point(27, 96);
            this.txtBoxClientSearch.Name = "txtBoxClientSearch";
            this.txtBoxClientSearch.Size = new System.Drawing.Size(220, 28);
            this.txtBoxClientSearch.TabIndex = 3;
            this.txtBoxClientSearch.TextChanged += new System.EventHandler(this.txtBoxClientSearch_TextChanged);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rbDescend);
            this.gbSort.Controls.Add(this.rbAscend);
            this.gbSort.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbSort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientInfoErrorProvider.SetIconAlignment(this.gbSort, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.gbSort.Location = new System.Drawing.Point(812, 96);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(200, 80);
            this.gbSort.TabIndex = 2;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Sort By";
            // 
            // rbDescend
            // 
            this.rbDescend.AutoSize = true;
            this.rbDescend.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbDescend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDescend.Location = new System.Drawing.Point(128, 35);
            this.rbDescend.Name = "rbDescend";
            this.rbDescend.Size = new System.Drawing.Size(66, 25);
            this.rbDescend.TabIndex = 1;
            this.rbDescend.Text = "desc";
            this.rbDescend.UseVisualStyleBackColor = true;
            this.rbDescend.CheckedChanged += new System.EventHandler(this.rbDescend_CheckedChanged);
            // 
            // rbAscend
            // 
            this.rbAscend.AutoSize = true;
            this.rbAscend.Checked = true;
            this.rbAscend.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbAscend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbAscend.Location = new System.Drawing.Point(6, 35);
            this.rbAscend.Name = "rbAscend";
            this.rbAscend.Size = new System.Drawing.Size(57, 25);
            this.rbAscend.TabIndex = 0;
            this.rbAscend.TabStop = true;
            this.rbAscend.Text = "asc";
            this.rbAscend.UseVisualStyleBackColor = true;
            this.rbAscend.CheckedChanged += new System.EventHandler(this.rbAscend_CheckedChanged);
            // 
            // lblNumOfClients
            // 
            this.lblNumOfClients.AutoSize = true;
            this.lblNumOfClients.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblNumOfClients.Location = new System.Drawing.Point(23, 152);
            this.lblNumOfClients.Name = "lblNumOfClients";
            this.lblNumOfClients.Size = new System.Drawing.Size(162, 24);
            this.lblNumOfClients.TabIndex = 1;
            this.lblNumOfClients.Text = "0 Client(s) Found";
            // 
            // ListViewClients
            // 
            this.ListViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAccNum,
            this.colPinCode,
            this.colName,
            this.colEmail,
            this.colPhoneNum,
            this.colBalance});
            this.ListViewClients.ContextMenuStrip = this.CMSClients;
            this.ListViewClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListViewClients.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.ListViewClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ListViewClients.FullRowSelect = true;
            this.ListViewClients.GridLines = true;
            this.ListViewClients.HideSelection = false;
            this.ListViewClients.Location = new System.Drawing.Point(3, 214);
            this.ListViewClients.MultiSelect = false;
            this.ListViewClients.Name = "ListViewClients";
            this.ListViewClients.Size = new System.Drawing.Size(1038, 437);
            this.ListViewClients.TabIndex = 0;
            this.ListViewClients.UseCompatibleStateImageBehavior = false;
            this.ListViewClients.View = System.Windows.Forms.View.Details;
            // 
            // colAccNum
            // 
            this.colAccNum.Text = "Account Num";
            this.colAccNum.Width = 136;
            // 
            // colPinCode
            // 
            this.colPinCode.Text = "Pin Code";
            this.colPinCode.Width = 95;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 140;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 214;
            // 
            // colPhoneNum
            // 
            this.colPhoneNum.Text = "Phone";
            this.colPhoneNum.Width = 130;
            // 
            // colBalance
            // 
            this.colBalance.Text = "Balance(EGP)";
            this.colBalance.Width = 140;
            // 
            // CMSClients
            // 
            this.CMSClients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CMSClients.Name = "contextMenuStrip1";
            this.CMSClients.Size = new System.Drawing.Size(143, 124);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tpAddClient
            // 
            this.tpAddClient.Controls.Add(this.btnAddNewClient);
            this.tpAddClient.Controls.Add(this.numAddClientBalance);
            this.tpAddClient.Controls.Add(this.txtAddClientPhone);
            this.tpAddClient.Controls.Add(this.label7);
            this.tpAddClient.Controls.Add(this.label8);
            this.tpAddClient.Controls.Add(this.txtAddClientEmail);
            this.tpAddClient.Controls.Add(this.label6);
            this.tpAddClient.Controls.Add(this.label5);
            this.tpAddClient.Controls.Add(this.txtAddClientName);
            this.tpAddClient.Controls.Add(this.label4);
            this.tpAddClient.Controls.Add(this.txtAddClientPin);
            this.tpAddClient.Controls.Add(this.label1);
            this.tpAddClient.Controls.Add(this.label2);
            this.tpAddClient.Controls.Add(this.txtAddClientAccNo);
            this.tpAddClient.Location = new System.Drawing.Point(4, 30);
            this.tpAddClient.Name = "tpAddClient";
            this.tpAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddClient.Size = new System.Drawing.Size(1044, 654);
            this.tpAddClient.TabIndex = 1;
            this.tpAddClient.Text = "Add Client";
            this.tpAddClient.UseVisualStyleBackColor = true;
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClient.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnAddNewClient.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNewClient.Location = new System.Drawing.Point(409, 529);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(226, 47);
            this.btnAddNewClient.TabIndex = 22;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseVisualStyleBackColor = false;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // numAddClientBalance
            // 
            this.numAddClientBalance.DecimalPlaces = 4;
            this.numAddClientBalance.Location = new System.Drawing.Point(650, 435);
            this.numAddClientBalance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numAddClientBalance.Name = "numAddClientBalance";
            this.numAddClientBalance.Size = new System.Drawing.Size(250, 28);
            this.numAddClientBalance.TabIndex = 21;
            this.numAddClientBalance.ValueChanged += new System.EventHandler(this.numAddClientBalance_ValueChanged);
            // 
            // txtAddClientPhone
            // 
            this.txtAddClientPhone.Location = new System.Drawing.Point(146, 434);
            this.txtAddClientPhone.Mask = "+20 0000000000";
            this.txtAddClientPhone.Name = "txtAddClientPhone";
            this.txtAddClientPhone.Size = new System.Drawing.Size(250, 28);
            this.txtAddClientPhone.TabIndex = 20;
            this.txtAddClientPhone.TextChanged += new System.EventHandler(this.txtAddClientPhone_TextChanged);
            this.txtAddClientPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ClientMaskedTxtBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(646, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(142, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phone Number";
            // 
            // txtAddClientEmail
            // 
            this.txtAddClientEmail.Location = new System.Drawing.Point(650, 330);
            this.txtAddClientEmail.Name = "txtAddClientEmail";
            this.txtAddClientEmail.Size = new System.Drawing.Size(250, 28);
            this.txtAddClientEmail.TabIndex = 15;
            this.txtAddClientEmail.TextChanged += new System.EventHandler(this.txtAddClientEmail_TextChanged);
            this.txtAddClientEmail.Validating += new System.ComponentModel.CancelEventHandler(this.ClientTxtBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(646, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(646, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pin Code";
            // 
            // txtAddClientName
            // 
            this.txtAddClientName.Location = new System.Drawing.Point(146, 330);
            this.txtAddClientName.Name = "txtAddClientName";
            this.txtAddClientName.Size = new System.Drawing.Size(250, 28);
            this.txtAddClientName.TabIndex = 12;
            this.txtAddClientName.TextChanged += new System.EventHandler(this.txtAddClientName_TextChanged);
            this.txtAddClientName.Validating += new System.ComponentModel.CancelEventHandler(this.ClientTxtBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(142, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // txtAddClientPin
            // 
            this.txtAddClientPin.Location = new System.Drawing.Point(650, 236);
            this.txtAddClientPin.Name = "txtAddClientPin";
            this.txtAddClientPin.Size = new System.Drawing.Size(250, 28);
            this.txtAddClientPin.TabIndex = 10;
            this.txtAddClientPin.TextChanged += new System.EventHandler(this.txtAddClientPin_TextChanged);
            this.txtAddClientPin.Validating += new System.ComponentModel.CancelEventHandler(this.ClientTxtBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(410, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(142, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account Number";
            // 
            // txtAddClientAccNo
            // 
            this.txtAddClientAccNo.Location = new System.Drawing.Point(146, 236);
            this.txtAddClientAccNo.Name = "txtAddClientAccNo";
            this.txtAddClientAccNo.Size = new System.Drawing.Size(250, 28);
            this.txtAddClientAccNo.TabIndex = 7;
            this.txtAddClientAccNo.TextChanged += new System.EventHandler(this.txtAddClientAccNo_TextChanged);
            this.txtAddClientAccNo.Validating += new System.ComponentModel.CancelEventHandler(this.ClientTxtBox_Validating);
            // 
            // tpUpdateClient
            // 
            this.tpUpdateClient.Controls.Add(this.cbUpdateClientAccNo);
            this.tpUpdateClient.Controls.Add(this.btnUpdate);
            this.tpUpdateClient.Controls.Add(this.numUpdateClientBalance);
            this.tpUpdateClient.Controls.Add(this.maskedTxtUpdateClientPhone);
            this.tpUpdateClient.Controls.Add(this.label9);
            this.tpUpdateClient.Controls.Add(this.label10);
            this.tpUpdateClient.Controls.Add(this.txtUpdateClientEmail);
            this.tpUpdateClient.Controls.Add(this.label11);
            this.tpUpdateClient.Controls.Add(this.label12);
            this.tpUpdateClient.Controls.Add(this.txtUpdateClientName);
            this.tpUpdateClient.Controls.Add(this.label13);
            this.tpUpdateClient.Controls.Add(this.txtUpdateClientPin);
            this.tpUpdateClient.Controls.Add(this.label14);
            this.tpUpdateClient.Controls.Add(this.label15);
            this.tpUpdateClient.Location = new System.Drawing.Point(4, 30);
            this.tpUpdateClient.Name = "tpUpdateClient";
            this.tpUpdateClient.Size = new System.Drawing.Size(1044, 654);
            this.tpUpdateClient.TabIndex = 2;
            this.tpUpdateClient.Text = "Update Client";
            this.tpUpdateClient.UseVisualStyleBackColor = true;
            // 
            // cbUpdateClientAccNo
            // 
            this.cbUpdateClientAccNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateClientAccNo.FormattingEnabled = true;
            this.cbUpdateClientAccNo.Location = new System.Drawing.Point(147, 238);
            this.cbUpdateClientAccNo.Name = "cbUpdateClientAccNo";
            this.cbUpdateClientAccNo.Size = new System.Drawing.Size(250, 29);
            this.cbUpdateClientAccNo.TabIndex = 37;
            this.cbUpdateClientAccNo.SelectedValueChanged += new System.EventHandler(this.cbUpdateClientAccNo_SelectedValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(410, 531);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(226, 47);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update Client";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numUpdateClientBalance
            // 
            this.numUpdateClientBalance.DecimalPlaces = 4;
            this.numUpdateClientBalance.Enabled = false;
            this.numUpdateClientBalance.Location = new System.Drawing.Point(651, 437);
            this.numUpdateClientBalance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numUpdateClientBalance.Name = "numUpdateClientBalance";
            this.numUpdateClientBalance.Size = new System.Drawing.Size(250, 28);
            this.numUpdateClientBalance.TabIndex = 35;
            // 
            // maskedTxtUpdateClientPhone
            // 
            this.maskedTxtUpdateClientPhone.Enabled = false;
            this.maskedTxtUpdateClientPhone.Location = new System.Drawing.Point(147, 436);
            this.maskedTxtUpdateClientPhone.Mask = "+20 0000000000";
            this.maskedTxtUpdateClientPhone.Name = "maskedTxtUpdateClientPhone";
            this.maskedTxtUpdateClientPhone.Size = new System.Drawing.Size(250, 28);
            this.maskedTxtUpdateClientPhone.TabIndex = 34;
            this.maskedTxtUpdateClientPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ClientMaskedTxtBox_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(647, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(143, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "Phone Number";
            // 
            // txtUpdateClientEmail
            // 
            this.txtUpdateClientEmail.Enabled = false;
            this.txtUpdateClientEmail.Location = new System.Drawing.Point(651, 332);
            this.txtUpdateClientEmail.Name = "txtUpdateClientEmail";
            this.txtUpdateClientEmail.Size = new System.Drawing.Size(250, 28);
            this.txtUpdateClientEmail.TabIndex = 31;
            this.txtUpdateClientEmail.TextChanged += new System.EventHandler(this.txtUpdateClientEmail_TextChanged);
            this.txtUpdateClientEmail.Validating += new System.ComponentModel.CancelEventHandler(this.ClientTxtBox_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(647, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(647, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 24);
            this.label12.TabIndex = 29;
            this.label12.Text = "Pin Code";
            // 
            // txtUpdateClientName
            // 
            this.txtUpdateClientName.Enabled = false;
            this.txtUpdateClientName.Location = new System.Drawing.Point(147, 332);
            this.txtUpdateClientName.Name = "txtUpdateClientName";
            this.txtUpdateClientName.Size = new System.Drawing.Size(250, 28);
            this.txtUpdateClientName.TabIndex = 28;
            this.txtUpdateClientName.Validating += new System.ComponentModel.CancelEventHandler(this.ClientTxtBox_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(143, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "Name";
            // 
            // txtUpdateClientPin
            // 
            this.txtUpdateClientPin.Enabled = false;
            this.txtUpdateClientPin.Location = new System.Drawing.Point(651, 238);
            this.txtUpdateClientPin.Name = "txtUpdateClientPin";
            this.txtUpdateClientPin.Size = new System.Drawing.Size(250, 28);
            this.txtUpdateClientPin.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(380, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(287, 53);
            this.label14.TabIndex = 25;
            this.label14.Text = "Update Client";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(143, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 24);
            this.label15.TabIndex = 24;
            this.label15.Text = "Account Number";
            // 
            // ClientInfoErrorProvider
            // 
            this.ClientInfoErrorProvider.ContainerControl = this;
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // ManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 688);
            this.Controls.Add(this.tabControlClients);
            this.Controls.Add(this.gbLayout);
            this.Name = "ManageClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClients";
            this.Load += new System.EventHandler(this.ManageClients_Load);
            this.gbLayout.ResumeLayout(false);
            this.gbLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).EndInit();
            this.tabControlClients.ResumeLayout(false);
            this.tpShowClients.ResumeLayout(false);
            this.tpShowClients.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.CMSClients.ResumeLayout(false);
            this.tpAddClient.ResumeLayout(false);
            this.tpAddClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddClientBalance)).EndInit();
            this.tpUpdateClient.ResumeLayout(false);
            this.tpUpdateClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateClientBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientInfoErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLayout;
        private System.Windows.Forms.Label lbldateTime;
        private System.Windows.Forms.PictureBox BankPicBox;
        private System.Windows.Forms.TabControl tabControlClients;
        private System.Windows.Forms.TabPage tpShowClients;
        private System.Windows.Forms.TabPage tpAddClient;
        private System.Windows.Forms.TabPage tpUpdateClient;
        private System.Windows.Forms.ListView ListViewClients;
        private System.Windows.Forms.ColumnHeader colAccNum;
        private System.Windows.Forms.ColumnHeader colPinCode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPhoneNum;
        private System.Windows.Forms.ColumnHeader colBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddClientAccNo;
        private System.Windows.Forms.Label lblNumOfClients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddClientPin;
        private System.Windows.Forms.TextBox txtAddClientEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtAddClientPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider ClientInfoErrorProvider;
        private System.Windows.Forms.NumericUpDown numAddClientBalance;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numUpdateClientBalance;
        private System.Windows.Forms.MaskedTextBox maskedTxtUpdateClientPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateClientEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdateClientName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdateClientPin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbUpdateClientAccNo;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rbAscend;
        private System.Windows.Forms.RadioButton rbDescend;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxClientSearch;
        private System.Windows.Forms.ContextMenuStrip CMSClients;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}