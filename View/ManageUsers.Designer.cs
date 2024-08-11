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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Admin",
            "ahmedHani221",
            "Ahmed Hani",
            "ahmedhani205@gmail.com",
            "+20 1276698108",
            "-1"}, -1);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldateTime = new System.Windows.Forms.Label();
            this.BankPicBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpShowUsers = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rbDescend = new System.Windows.Forms.RadioButton();
            this.rbAscend = new System.Windows.Forms.RadioButton();
            this.lblNumOfClients = new System.Windows.Forms.Label();
            this.ListViewClients = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPermission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpAddUser = new System.Windows.Forms.TabPage();
            this.gpPermissions = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.txtAddUserPhone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddUserEmail = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpUpdateUser = new System.Windows.Forms.TabPage();
            this.cbUpdateClientAccNo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpShowUsers.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.tpAddUser.SuspendLayout();
            this.gpPermissions.SuspendLayout();
            this.tpUpdateUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbldateTime);
            this.groupBox1.Controls.Add(this.BankPicBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 703);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpShowUsers);
            this.tabControl1.Controls.Add(this.tpAddUser);
            this.tabControl1.Controls.Add(this.tpUpdateUser);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(230, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 703);
            this.tabControl1.TabIndex = 3;
            // 
            // tpShowUsers
            // 
            this.tpShowUsers.Controls.Add(this.label16);
            this.tpShowUsers.Controls.Add(this.textBox1);
            this.tpShowUsers.Controls.Add(this.gbSort);
            this.tpShowUsers.Controls.Add(this.lblNumOfClients);
            this.tpShowUsers.Controls.Add(this.ListViewClients);
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
            this.label16.Size = new System.Drawing.Size(180, 24);
            this.label16.TabIndex = 9;
            this.label16.Text = "Search By Acc. No.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 28);
            this.textBox1.TabIndex = 3;
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
            // 
            // lblNumOfClients
            // 
            this.lblNumOfClients.AutoSize = true;
            this.lblNumOfClients.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblNumOfClients.Location = new System.Drawing.Point(23, 152);
            this.lblNumOfClients.Name = "lblNumOfClients";
            this.lblNumOfClients.Size = new System.Drawing.Size(153, 24);
            this.lblNumOfClients.TabIndex = 1;
            this.lblNumOfClients.Text = "0 User(s) Found";
            // 
            // ListViewClients
            // 
            this.ListViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colPassword,
            this.colName,
            this.colEmail,
            this.colPhoneNum,
            this.colPermission});
            this.ListViewClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListViewClients.GridLines = true;
            this.ListViewClients.HideSelection = false;
            this.ListViewClients.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6});
            this.ListViewClients.Location = new System.Drawing.Point(3, 229);
            this.ListViewClients.Name = "ListViewClients";
            this.ListViewClients.Size = new System.Drawing.Size(1038, 437);
            this.ListViewClients.TabIndex = 0;
            this.ListViewClients.UseCompatibleStateImageBehavior = false;
            this.ListViewClients.View = System.Windows.Forms.View.Details;
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
            // tpAddUser
            // 
            this.tpAddUser.Controls.Add(this.gpPermissions);
            this.tpAddUser.Controls.Add(this.btnAddNewUser);
            this.tpAddUser.Controls.Add(this.txtAddUserPhone);
            this.tpAddUser.Controls.Add(this.label8);
            this.tpAddUser.Controls.Add(this.txtAddUserEmail);
            this.tpAddUser.Controls.Add(this.txtAddName);
            this.tpAddUser.Controls.Add(this.txtAddUserPassword);
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
            // gpPermissions
            // 
            this.gpPermissions.Controls.Add(this.radioButton2);
            this.gpPermissions.Controls.Add(this.radioButton1);
            this.gpPermissions.Controls.Add(this.label3);
            this.gpPermissions.Controls.Add(this.checkBox4);
            this.gpPermissions.Controls.Add(this.checkBox3);
            this.gpPermissions.Controls.Add(this.checkBox2);
            this.gpPermissions.Controls.Add(this.checkBox1);
            this.gpPermissions.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPermissions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpPermissions.Location = new System.Drawing.Point(637, 268);
            this.gpPermissions.Name = "gpPermissions";
            this.gpPermissions.Size = new System.Drawing.Size(333, 176);
            this.gpPermissions.TabIndex = 23;
            this.gpPermissions.TabStop = false;
            this.gpPermissions.Text = "Permissions";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(240, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 25);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(44, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 25);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(40, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do you want to give full access?";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox4.Location = new System.Drawing.Point(6, 132);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(177, 25);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Currency Exchange";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox3.Location = new System.Drawing.Point(187, 101);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(140, 25);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Manage Users";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox2.Location = new System.Drawing.Point(187, 132);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(127, 25);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Transactions";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Location = new System.Drawing.Point(6, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 25);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Manage Clients";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // 
            // txtAddUserPhone
            // 
            this.txtAddUserPhone.Location = new System.Drawing.Point(637, 203);
            this.txtAddUserPhone.Mask = "+20 0000000000";
            this.txtAddUserPhone.Name = "txtAddUserPhone";
            this.txtAddUserPhone.Size = new System.Drawing.Size(250, 28);
            this.txtAddUserPhone.TabIndex = 20;
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
            // txtAddUserEmail
            // 
            this.txtAddUserEmail.Location = new System.Drawing.Point(108, 203);
            this.txtAddUserEmail.Name = "txtAddUserEmail";
            this.txtAddUserEmail.Size = new System.Drawing.Size(250, 28);
            this.txtAddUserEmail.TabIndex = 15;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(108, 415);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(250, 28);
            this.txtAddName.TabIndex = 12;
            // 
            // txtAddUserPassword
            // 
            this.txtAddUserPassword.Location = new System.Drawing.Point(108, 309);
            this.txtAddUserPassword.Name = "txtAddUserPassword";
            this.txtAddUserPassword.Size = new System.Drawing.Size(250, 28);
            this.txtAddUserPassword.TabIndex = 10;
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
            this.tpUpdateUser.Controls.Add(this.textBox5);
            this.tpUpdateUser.Controls.Add(this.label12);
            this.tpUpdateUser.Controls.Add(this.groupBox2);
            this.tpUpdateUser.Controls.Add(this.maskedTextBox1);
            this.tpUpdateUser.Controls.Add(this.label11);
            this.tpUpdateUser.Controls.Add(this.textBox2);
            this.tpUpdateUser.Controls.Add(this.textBox3);
            this.tpUpdateUser.Controls.Add(this.textBox4);
            this.tpUpdateUser.Controls.Add(this.label2);
            this.tpUpdateUser.Controls.Add(this.label7);
            this.tpUpdateUser.Controls.Add(this.label10);
            this.tpUpdateUser.Controls.Add(this.cbUpdateClientAccNo);
            this.tpUpdateUser.Controls.Add(this.button1);
            this.tpUpdateUser.Controls.Add(this.label14);
            this.tpUpdateUser.Controls.Add(this.label15);
            this.tpUpdateUser.Location = new System.Drawing.Point(4, 30);
            this.tpUpdateUser.Name = "tpUpdateUser";
            this.tpUpdateUser.Size = new System.Drawing.Size(1044, 669);
            this.tpUpdateUser.TabIndex = 2;
            this.tpUpdateUser.Text = "Update User";
            this.tpUpdateUser.UseVisualStyleBackColor = true;
            // 
            // cbUpdateClientAccNo
            // 
            this.cbUpdateClientAccNo.FormattingEnabled = true;
            this.cbUpdateClientAccNo.Location = new System.Drawing.Point(80, 236);
            this.cbUpdateClientAccNo.Name = "cbUpdateClientAccNo";
            this.cbUpdateClientAccNo.Size = new System.Drawing.Size(250, 29);
            this.cbUpdateClientAccNo.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(401, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 47);
            this.button1.TabIndex = 36;
            this.button1.Text = "Update User";
            this.button1.UseVisualStyleBackColor = false;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 28);
            this.textBox2.TabIndex = 43;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(713, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 28);
            this.textBox3.TabIndex = 40;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 427);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 28);
            this.textBox4.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(76, 294);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(355, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 176);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissions";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton3.Location = new System.Drawing.Point(240, 58);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 25);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "No";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton4.Location = new System.Drawing.Point(44, 58);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 25);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Yes";
            this.radioButton4.UseVisualStyleBackColor = true;
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
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox5.Location = new System.Drawing.Point(6, 132);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(177, 25);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Currency Exchange";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.checkBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox6.Location = new System.Drawing.Point(187, 101);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(140, 25);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "Manage Users";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox7.Location = new System.Drawing.Point(187, 132);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(127, 25);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "Transactions";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.checkBox8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox8.Location = new System.Drawing.Point(6, 101);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(148, 25);
            this.checkBox8.TabIndex = 1;
            this.checkBox8.Text = "Manage Clients";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(713, 427);
            this.maskedTextBox1.Mask = "+20 0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(250, 28);
            this.maskedTextBox1.TabIndex = 45;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(713, 332);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 28);
            this.textBox5.TabIndex = 48;
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
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpShowUsers.ResumeLayout(false);
            this.tpShowUsers.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.tpAddUser.ResumeLayout(false);
            this.tpAddUser.PerformLayout();
            this.gpPermissions.ResumeLayout(false);
            this.gpPermissions.PerformLayout();
            this.tpUpdateUser.ResumeLayout(false);
            this.tpUpdateUser.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldateTime;
        private System.Windows.Forms.PictureBox BankPicBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpShowUsers;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rbDescend;
        private System.Windows.Forms.RadioButton rbAscend;
        private System.Windows.Forms.Label lblNumOfClients;
        private System.Windows.Forms.ListView ListViewClients;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colPassword;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPhoneNum;
        private System.Windows.Forms.ColumnHeader colPermission;
        private System.Windows.Forms.TabPage tpUpdateUser;
        private System.Windows.Forms.ComboBox cbUpdateClientAccNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tpAddUser;
        private System.Windows.Forms.GroupBox gpPermissions;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.MaskedTextBox txtAddUserPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddUserEmail;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label11;
    }
}