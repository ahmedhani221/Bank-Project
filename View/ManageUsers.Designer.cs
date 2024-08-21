namespace Bank_Project
{
    partial class ManageUsers
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
            this.tabControlUsers = new System.Windows.Forms.TabControl();
            this.tpShowUsers = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearchByUsername = new System.Windows.Forms.TextBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rbDescend = new System.Windows.Forms.RadioButton();
            this.rbAscend = new System.Windows.Forms.RadioButton();
            this.lblNumOfUsers = new System.Windows.Forms.Label();
            this.ListViewUsers = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPermission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpAddUser = new System.Windows.Forms.TabPage();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.rbNo1 = new System.Windows.Forms.RadioButton();
            this.rbYes1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkCurrency1 = new System.Windows.Forms.CheckBox();
            this.ChkManageUser1 = new System.Windows.Forms.CheckBox();
            this.ChkTransactions1 = new System.Windows.Forms.CheckBox();
            this.ChkManageClient1 = new System.Windows.Forms.CheckBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.txtAddPhone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpUpdateUser = new System.Windows.Forms.TabPage();
            this.gbPermissions2 = new System.Windows.Forms.GroupBox();
            this.rbNo2 = new System.Windows.Forms.RadioButton();
            this.rbYes2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.ChkCurrency2 = new System.Windows.Forms.CheckBox();
            this.ChkManageUser2 = new System.Windows.Forms.CheckBox();
            this.ChkTransactions2 = new System.Windows.Forms.CheckBox();
            this.ChkManageClient2 = new System.Windows.Forms.CheckBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdatePhone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUpdateUsername = new System.Windows.Forms.ComboBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProviderUsers = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).BeginInit();
            this.tabControlUsers.SuspendLayout();
            this.tpShowUsers.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.contextMenuUsers.SuspendLayout();
            this.tpAddUser.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            this.tpUpdateUser.SuspendLayout();
            this.gbPermissions2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsers)).BeginInit();
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
            this.gbLayout.Size = new System.Drawing.Size(230, 703);
            this.gbLayout.TabIndex = 2;
            this.gbLayout.TabStop = false;
            // 
            // lbldateTime
            // 
            this.lbldateTime.AutoSize = true;
            this.lbldateTime.Location = new System.Drawing.Point(9, 650);
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
            // tabControlUsers
            // 
            this.tabControlUsers.Controls.Add(this.tpShowUsers);
            this.tabControlUsers.Controls.Add(this.tpAddUser);
            this.tabControlUsers.Controls.Add(this.tpUpdateUser);
            this.tabControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUsers.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlUsers.Location = new System.Drawing.Point(230, 0);
            this.tabControlUsers.Name = "tabControlUsers";
            this.tabControlUsers.SelectedIndex = 0;
            this.tabControlUsers.Size = new System.Drawing.Size(1052, 703);
            this.tabControlUsers.TabIndex = 3;
            // 
            // tpShowUsers
            // 
            this.tpShowUsers.Controls.Add(this.label16);
            this.tpShowUsers.Controls.Add(this.txtSearchByUsername);
            this.tpShowUsers.Controls.Add(this.gbSort);
            this.tpShowUsers.Controls.Add(this.lblNumOfUsers);
            this.tpShowUsers.Controls.Add(this.ListViewUsers);
            this.tpShowUsers.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpShowUsers.Location = new System.Drawing.Point(4, 30);
            this.tpShowUsers.Name = "tpShowUsers";
            this.tpShowUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowUsers.Size = new System.Drawing.Size(1044, 669);
            this.tpShowUsers.TabIndex = 0;
            this.tpShowUsers.Text = "Show Users";
            this.tpShowUsers.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(24, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 24);
            this.label16.TabIndex = 9;
            this.label16.Text = "Search By Username";
            // 
            // txtSearchByUsername
            // 
            this.txtSearchByUsername.Location = new System.Drawing.Point(27, 96);
            this.txtSearchByUsername.Name = "txtSearchByUsername";
            this.txtSearchByUsername.Size = new System.Drawing.Size(220, 28);
            this.txtSearchByUsername.TabIndex = 3;
            this.txtSearchByUsername.TextChanged += new System.EventHandler(this.txtSearchByUsername_TextChanged);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rbDescend);
            this.gbSort.Controls.Add(this.rbAscend);
            this.gbSort.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbSort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            // lblNumOfUsers
            // 
            this.lblNumOfUsers.AutoSize = true;
            this.lblNumOfUsers.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblNumOfUsers.Location = new System.Drawing.Point(23, 152);
            this.lblNumOfUsers.Name = "lblNumOfUsers";
            this.lblNumOfUsers.Size = new System.Drawing.Size(153, 24);
            this.lblNumOfUsers.TabIndex = 1;
            this.lblNumOfUsers.Text = "0 User(s) Found";
            // 
            // ListViewUsers
            // 
            this.ListViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colPassword,
            this.colName,
            this.colEmail,
            this.colPhoneNum,
            this.colPermission});
            this.ListViewUsers.ContextMenuStrip = this.contextMenuUsers;
            this.ListViewUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListViewUsers.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.ListViewUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ListViewUsers.FullRowSelect = true;
            this.ListViewUsers.GridLines = true;
            this.ListViewUsers.HideSelection = false;
            this.ListViewUsers.Location = new System.Drawing.Point(3, 229);
            this.ListViewUsers.MultiSelect = false;
            this.ListViewUsers.Name = "ListViewUsers";
            this.ListViewUsers.Size = new System.Drawing.Size(1038, 437);
            this.ListViewUsers.TabIndex = 0;
            this.ListViewUsers.UseCompatibleStateImageBehavior = false;
            this.ListViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 118;
            // 
            // colPassword
            // 
            this.colPassword.Text = "Password";
            this.colPassword.Width = 143;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 119;
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
            // colPermission
            // 
            this.colPermission.Text = "Permission";
            this.colPermission.Width = 100;
            // 
            // contextMenuUsers
            // 
            this.contextMenuUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuUsers.Name = "contextMenuUsers";
            this.contextMenuUsers.Size = new System.Drawing.Size(128, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tpAddUser
            // 
            this.tpAddUser.Controls.Add(this.gbPermissions);
            this.tpAddUser.Controls.Add(this.btnAddNewUser);
            this.tpAddUser.Controls.Add(this.txtAddPhone);
            this.tpAddUser.Controls.Add(this.label8);
            this.tpAddUser.Controls.Add(this.txtAddEmail);
            this.tpAddUser.Controls.Add(this.txtAddName);
            this.tpAddUser.Controls.Add(this.txtAddPassword);
            this.tpAddUser.Controls.Add(this.label1);
            this.tpAddUser.Controls.Add(this.label6);
            this.tpAddUser.Controls.Add(this.label5);
            this.tpAddUser.Controls.Add(this.label4);
            this.tpAddUser.Location = new System.Drawing.Point(4, 30);
            this.tpAddUser.Name = "tpAddUser";
            this.tpAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddUser.Size = new System.Drawing.Size(1044, 669);
            this.tpAddUser.TabIndex = 1;
            this.tpAddUser.Text = "Add User";
            this.tpAddUser.UseVisualStyleBackColor = true;
            // 
            // gbPermissions
            // 
            this.gbPermissions.Controls.Add(this.rbNo1);
            this.gbPermissions.Controls.Add(this.rbYes1);
            this.gbPermissions.Controls.Add(this.label3);
            this.gbPermissions.Controls.Add(this.ChkCurrency1);
            this.gbPermissions.Controls.Add(this.ChkManageUser1);
            this.gbPermissions.Controls.Add(this.ChkTransactions1);
            this.gbPermissions.Controls.Add(this.ChkManageClient1);
            this.gbPermissions.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbPermissions.Location = new System.Drawing.Point(637, 268);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(360, 175);
            this.gbPermissions.TabIndex = 23;
            this.gbPermissions.TabStop = false;
            this.gbPermissions.Text = "Permissions";
            // 
            // rbNo1
            // 
            this.rbNo1.AutoSize = true;
            this.rbNo1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbNo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbNo1.Location = new System.Drawing.Point(245, 58);
            this.rbNo1.Name = "rbNo1";
            this.rbNo1.Size = new System.Drawing.Size(52, 25);
            this.rbNo1.TabIndex = 7;
            this.rbNo1.Text = "No";
            this.rbNo1.UseVisualStyleBackColor = true;
            this.rbNo1.CheckedChanged += new System.EventHandler(this.rbNo1_CheckedChanged);
            // 
            // rbYes1
            // 
            this.rbYes1.AutoSize = true;
            this.rbYes1.Checked = true;
            this.rbYes1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbYes1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbYes1.Location = new System.Drawing.Point(49, 58);
            this.rbYes1.Name = "rbYes1";
            this.rbYes1.Size = new System.Drawing.Size(57, 25);
            this.rbYes1.TabIndex = 6;
            this.rbYes1.TabStop = true;
            this.rbYes1.Tag = "-1";
            this.rbYes1.Text = "Yes";
            this.rbYes1.UseVisualStyleBackColor = true;
            this.rbYes1.CheckedChanged += new System.EventHandler(this.rbYes1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(45, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do you want to give full access?";
            // 
            // ChkCurrency1
            // 
            this.ChkCurrency1.AutoSize = true;
            this.ChkCurrency1.Enabled = false;
            this.ChkCurrency1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ChkCurrency1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkCurrency1.Location = new System.Drawing.Point(6, 132);
            this.ChkCurrency1.Name = "ChkCurrency1";
            this.ChkCurrency1.Size = new System.Drawing.Size(177, 25);
            this.ChkCurrency1.TabIndex = 4;
            this.ChkCurrency1.Tag = "4";
            this.ChkCurrency1.Text = "Currency Exchange";
            this.ChkCurrency1.UseVisualStyleBackColor = true;
            // 
            // ChkManageUser1
            // 
            this.ChkManageUser1.AutoSize = true;
            this.ChkManageUser1.Enabled = false;
            this.ChkManageUser1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ChkManageUser1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkManageUser1.Location = new System.Drawing.Point(210, 101);
            this.ChkManageUser1.Name = "ChkManageUser1";
            this.ChkManageUser1.Size = new System.Drawing.Size(140, 25);
            this.ChkManageUser1.TabIndex = 3;
            this.ChkManageUser1.Tag = "2";
            this.ChkManageUser1.Text = "Manage Users";
            this.ChkManageUser1.UseVisualStyleBackColor = true;
            // 
            // ChkTransactions1
            // 
            this.ChkTransactions1.AutoSize = true;
            this.ChkTransactions1.Enabled = false;
            this.ChkTransactions1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ChkTransactions1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkTransactions1.Location = new System.Drawing.Point(210, 132);
            this.ChkTransactions1.Name = "ChkTransactions1";
            this.ChkTransactions1.Size = new System.Drawing.Size(127, 25);
            this.ChkTransactions1.TabIndex = 2;
            this.ChkTransactions1.Tag = "8";
            this.ChkTransactions1.Text = "Transactions";
            this.ChkTransactions1.UseVisualStyleBackColor = true;
            // 
            // ChkManageClient1
            // 
            this.ChkManageClient1.AutoSize = true;
            this.ChkManageClient1.Enabled = false;
            this.ChkManageClient1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ChkManageClient1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkManageClient1.Location = new System.Drawing.Point(6, 101);
            this.ChkManageClient1.Name = "ChkManageClient1";
            this.ChkManageClient1.Size = new System.Drawing.Size(148, 25);
            this.ChkManageClient1.TabIndex = 1;
            this.ChkManageClient1.Tag = "1";
            this.ChkManageClient1.Text = "Manage Clients";
            this.ChkManageClient1.UseVisualStyleBackColor = true;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnAddNewUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNewUser.Location = new System.Drawing.Point(410, 543);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(226, 47);
            this.btnAddNewUser.TabIndex = 22;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Location = new System.Drawing.Point(637, 203);
            this.txtAddPhone.Mask = "+20 0000000000";
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(250, 28);
            this.txtAddPhone.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(633, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phone Number";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(108, 203);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(250, 28);
            this.txtAddEmail.TabIndex = 15;
            this.txtAddEmail.TextChanged += new System.EventHandler(this.txtAddEmail_TextChanged);
            this.txtAddEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(108, 415);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(250, 28);
            this.txtAddName.TabIndex = 12;
            this.txtAddName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(108, 309);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(250, 28);
            this.txtAddPassword.TabIndex = 10;
            this.txtAddPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(420, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(104, 176);
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
            this.label5.Location = new System.Drawing.Point(104, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(104, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // tpUpdateUser
            // 
            this.tpUpdateUser.Controls.Add(this.gbPermissions2);
            this.tpUpdateUser.Controls.Add(this.txtUpdateLastName);
            this.tpUpdateUser.Controls.Add(this.label12);
            this.tpUpdateUser.Controls.Add(this.txtUpdatePhone);
            this.tpUpdateUser.Controls.Add(this.label11);
            this.tpUpdateUser.Controls.Add(this.txtUpdateEmail);
            this.tpUpdateUser.Controls.Add(this.txtUpdateFirstName);
            this.tpUpdateUser.Controls.Add(this.txtUpdatePassword);
            this.tpUpdateUser.Controls.Add(this.label2);
            this.tpUpdateUser.Controls.Add(this.label7);
            this.tpUpdateUser.Controls.Add(this.label10);
            this.tpUpdateUser.Controls.Add(this.cbUpdateUsername);
            this.tpUpdateUser.Controls.Add(this.btnUpdateUser);
            this.tpUpdateUser.Controls.Add(this.label14);
            this.tpUpdateUser.Controls.Add(this.label15);
            this.tpUpdateUser.Location = new System.Drawing.Point(4, 30);
            this.tpUpdateUser.Name = "tpUpdateUser";
            this.tpUpdateUser.Size = new System.Drawing.Size(1044, 669);
            this.tpUpdateUser.TabIndex = 2;
            this.tpUpdateUser.Text = "Update User";
            this.tpUpdateUser.UseVisualStyleBackColor = true;
            // 
            // gbPermissions2
            // 
            this.gbPermissions2.Controls.Add(this.rbNo2);
            this.gbPermissions2.Controls.Add(this.rbYes2);
            this.gbPermissions2.Controls.Add(this.label9);
            this.gbPermissions2.Controls.Add(this.ChkCurrency2);
            this.gbPermissions2.Controls.Add(this.ChkManageUser2);
            this.gbPermissions2.Controls.Add(this.ChkTransactions2);
            this.gbPermissions2.Controls.Add(this.ChkManageClient2);
            this.gbPermissions2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissions2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbPermissions2.Location = new System.Drawing.Point(343, 249);
            this.gbPermissions2.Name = "gbPermissions2";
            this.gbPermissions2.Size = new System.Drawing.Size(360, 175);
            this.gbPermissions2.TabIndex = 49;
            this.gbPermissions2.TabStop = false;
            this.gbPermissions2.Text = "Permissions";
            // 
            // rbNo2
            // 
            this.rbNo2.AutoSize = true;
            this.rbNo2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbNo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbNo2.Location = new System.Drawing.Point(240, 58);
            this.rbNo2.Name = "rbNo2";
            this.rbNo2.Size = new System.Drawing.Size(52, 25);
            this.rbNo2.TabIndex = 7;
            this.rbNo2.Text = "No";
            this.rbNo2.UseVisualStyleBackColor = true;
            this.rbNo2.CheckedChanged += new System.EventHandler(this.rbNo2_CheckedChanged);
            // 
            // rbYes2
            // 
            this.rbYes2.AutoSize = true;
            this.rbYes2.Checked = true;
            this.rbYes2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbYes2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbYes2.Location = new System.Drawing.Point(44, 58);
            this.rbYes2.Name = "rbYes2";
            this.rbYes2.Size = new System.Drawing.Size(57, 25);
            this.rbYes2.TabIndex = 6;
            this.rbYes2.TabStop = true;
            this.rbYes2.Tag = "-1";
            this.rbYes2.Text = "Yes";
            this.rbYes2.UseVisualStyleBackColor = true;
            this.rbYes2.CheckedChanged += new System.EventHandler(this.rbYes2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(40, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Do you want to give full access?";
            // 
            // ChkCurrency2
            // 
            this.ChkCurrency2.AutoSize = true;
            this.ChkCurrency2.Enabled = false;
            this.ChkCurrency2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ChkCurrency2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkCurrency2.Location = new System.Drawing.Point(6, 132);
            this.ChkCurrency2.Name = "ChkCurrency2";
            this.ChkCurrency2.Size = new System.Drawing.Size(177, 25);
            this.ChkCurrency2.TabIndex = 4;
            this.ChkCurrency2.Tag = "4";
            this.ChkCurrency2.Text = "Currency Exchange";
            this.ChkCurrency2.UseVisualStyleBackColor = true;
            // 
            // ChkManageUser2
            // 
            this.ChkManageUser2.AutoSize = true;
            this.ChkManageUser2.Enabled = false;
            this.ChkManageUser2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ChkManageUser2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkManageUser2.Location = new System.Drawing.Point(210, 101);
            this.ChkManageUser2.Name = "ChkManageUser2";
            this.ChkManageUser2.Size = new System.Drawing.Size(140, 25);
            this.ChkManageUser2.TabIndex = 3;
            this.ChkManageUser2.Tag = "2";
            this.ChkManageUser2.Text = "Manage Users";
            this.ChkManageUser2.UseVisualStyleBackColor = true;
            // 
            // ChkTransactions2
            // 
            this.ChkTransactions2.AutoSize = true;
            this.ChkTransactions2.Enabled = false;
            this.ChkTransactions2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ChkTransactions2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkTransactions2.Location = new System.Drawing.Point(210, 132);
            this.ChkTransactions2.Name = "ChkTransactions2";
            this.ChkTransactions2.Size = new System.Drawing.Size(127, 25);
            this.ChkTransactions2.TabIndex = 2;
            this.ChkTransactions2.Tag = "8";
            this.ChkTransactions2.Text = "Transactions";
            this.ChkTransactions2.UseVisualStyleBackColor = true;
            // 
            // ChkManageClient2
            // 
            this.ChkManageClient2.AutoSize = true;
            this.ChkManageClient2.Enabled = false;
            this.ChkManageClient2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.ChkManageClient2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkManageClient2.Location = new System.Drawing.Point(6, 101);
            this.ChkManageClient2.Name = "ChkManageClient2";
            this.ChkManageClient2.Size = new System.Drawing.Size(148, 25);
            this.ChkManageClient2.TabIndex = 1;
            this.ChkManageClient2.Tag = "1";
            this.ChkManageClient2.Text = "Manage Clients";
            this.ChkManageClient2.UseVisualStyleBackColor = true;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(713, 332);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(250, 28);
            this.txtUpdateLastName.TabIndex = 48;
            this.txtUpdateLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(709, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 24);
            this.label12.TabIndex = 47;
            this.label12.Text = "Last Name";
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(713, 427);
            this.txtUpdatePhone.Mask = "+20 0000000000";
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(250, 28);
            this.txtUpdatePhone.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(709, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 24);
            this.label11.TabIndex = 44;
            this.label11.Text = "Phone Number";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(80, 332);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(250, 28);
            this.txtUpdateEmail.TabIndex = 43;
            this.txtUpdateEmail.TextChanged += new System.EventHandler(this.txtUpdateEmail_TextChanged);
            this.txtUpdateEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(713, 237);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(250, 28);
            this.txtUpdateFirstName.TabIndex = 40;
            this.txtUpdateFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(80, 427);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(250, 28);
            this.txtUpdatePassword.TabIndex = 38;
            this.txtUpdatePassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(76, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(76, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(709, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "First Name";
            // 
            // cbUpdateUsername
            // 
            this.cbUpdateUsername.FormattingEnabled = true;
            this.cbUpdateUsername.Location = new System.Drawing.Point(80, 236);
            this.cbUpdateUsername.Name = "cbUpdateUsername";
            this.cbUpdateUsername.Size = new System.Drawing.Size(250, 29);
            this.cbUpdateUsername.TabIndex = 37;
            this.cbUpdateUsername.SelectedValueChanged += new System.EventHandler(this.cbUpdateUsername_SelectedValueChanged);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateUser.Location = new System.Drawing.Point(401, 530);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(226, 47);
            this.btnUpdateUser.TabIndex = 36;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(380, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(268, 53);
            this.label14.TabIndex = 25;
            this.label14.Text = "Update User";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(76, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 24);
            this.label15.TabIndex = 24;
            this.label15.Text = "Username";
            // 
            // errorProviderUsers
            // 
            this.errorProviderUsers.ContainerControl = this;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.tabControlUsers);
            this.Controls.Add(this.gbLayout);
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.gbLayout.ResumeLayout(false);
            this.gbLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).EndInit();
            this.tabControlUsers.ResumeLayout(false);
            this.tpShowUsers.ResumeLayout(false);
            this.tpShowUsers.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.contextMenuUsers.ResumeLayout(false);
            this.tpAddUser.ResumeLayout(false);
            this.tpAddUser.PerformLayout();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.tpUpdateUser.ResumeLayout(false);
            this.tpUpdateUser.PerformLayout();
            this.gbPermissions2.ResumeLayout(false);
            this.gbPermissions2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLayout;
        private System.Windows.Forms.Label lbldateTime;
        private System.Windows.Forms.PictureBox BankPicBox;
        private System.Windows.Forms.TabControl tabControlUsers;
        private System.Windows.Forms.TabPage tpShowUsers;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearchByUsername;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rbDescend;
        private System.Windows.Forms.RadioButton rbAscend;
        private System.Windows.Forms.Label lblNumOfUsers;
        private System.Windows.Forms.ListView ListViewUsers;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colPassword;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPhoneNum;
        private System.Windows.Forms.ColumnHeader colPermission;
        private System.Windows.Forms.TabPage tpUpdateUser;
        private System.Windows.Forms.ComboBox cbUpdateUsername;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tpAddUser;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.RadioButton rbNo1;
        private System.Windows.Forms.RadioButton rbYes1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkCurrency1;
        private System.Windows.Forms.CheckBox ChkManageUser1;
        private System.Windows.Forms.CheckBox ChkTransactions1;
        private System.Windows.Forms.CheckBox ChkManageClient1;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.MaskedTextBox txtAddPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtUpdatePhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbPermissions2;
        private System.Windows.Forms.RadioButton rbNo2;
        private System.Windows.Forms.RadioButton rbYes2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ChkCurrency2;
        private System.Windows.Forms.CheckBox ChkManageUser2;
        private System.Windows.Forms.CheckBox ChkTransactions2;
        private System.Windows.Forms.CheckBox ChkManageClient2;
        private System.Windows.Forms.ErrorProvider errorProviderUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuUsers;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}