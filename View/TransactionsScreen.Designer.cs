namespace Bank_Project
{
    partial class TransactionsScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldateTime = new System.Windows.Forms.Label();
            this.BankPicBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDepositWithdraw = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.numUpdateClientBalance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUpdateClientAccNo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tpTransfer = new System.Windows.Forms.TabPage();
            this.tpBalances = new System.Windows.Forms.TabPage();
            this.tpTransferLogs = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalBalancesNumber = new System.Windows.Forms.Label();
            this.lblTotalBalancesWord = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTotalBalancesAccNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalBalancesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rbDescend = new System.Windows.Forms.RadioButton();
            this.rbAscend = new System.Windows.Forms.RadioButton();
            this.lblNumOfClients = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lstViewTransferLog = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpDepositWithdraw.SuspendLayout();
            this.gbOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateClientBalance)).BeginInit();
            this.tpTransfer.SuspendLayout();
            this.tpBalances.SuspendLayout();
            this.tpTransferLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbSort.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(230, 673);
            this.groupBox1.TabIndex = 3;
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
            this.tabControl1.Controls.Add(this.tpDepositWithdraw);
            this.tabControl1.Controls.Add(this.tpTransfer);
            this.tabControl1.Controls.Add(this.tpBalances);
            this.tabControl1.Controls.Add(this.tpTransferLogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.tabControl1.Location = new System.Drawing.Point(230, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 673);
            this.tabControl1.TabIndex = 4;
            // 
            // tpDepositWithdraw
            // 
            this.tpDepositWithdraw.Controls.Add(this.label2);
            this.tpDepositWithdraw.Controls.Add(this.btnAddNewClient);
            this.tpDepositWithdraw.Controls.Add(this.lblBalance);
            this.tpDepositWithdraw.Controls.Add(this.label1);
            this.tpDepositWithdraw.Controls.Add(this.gbOption);
            this.tpDepositWithdraw.Controls.Add(this.numUpdateClientBalance);
            this.tpDepositWithdraw.Controls.Add(this.label9);
            this.tpDepositWithdraw.Controls.Add(this.cbUpdateClientAccNo);
            this.tpDepositWithdraw.Controls.Add(this.label15);
            this.tpDepositWithdraw.Location = new System.Drawing.Point(4, 30);
            this.tpDepositWithdraw.Name = "tpDepositWithdraw";
            this.tpDepositWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tpDepositWithdraw.Size = new System.Drawing.Size(1044, 639);
            this.tpDepositWithdraw.TabIndex = 0;
            this.tpDepositWithdraw.Text = "Deposit / Withdraw";
            this.tpDepositWithdraw.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(335, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 53);
            this.label2.TabIndex = 46;
            this.label2.Text = "Transactions";
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClient.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnAddNewClient.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNewClient.Location = new System.Drawing.Point(359, 510);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(226, 47);
            this.btnAddNewClient.TabIndex = 45;
            this.btnAddNewClient.Text = "Deposit";
            this.btnAddNewClient.UseVisualStyleBackColor = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Green;
            this.lblBalance.Location = new System.Drawing.Point(354, 388);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(44, 28);
            this.lblBalance.TabIndex = 44;
            this.lblBalance.Text = "0 $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(65, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 41);
            this.label1.TabIndex = 43;
            this.label1.Text = "Current Balance: ";
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.rbWithdraw);
            this.gbOption.Controls.Add(this.rbDeposit);
            this.gbOption.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbOption.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbOption.Location = new System.Drawing.Point(643, 155);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(241, 80);
            this.gbOption.TabIndex = 42;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Option";
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbWithdraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbWithdraw.Location = new System.Drawing.Point(128, 35);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(102, 25);
            this.rbWithdraw.TabIndex = 1;
            this.rbWithdraw.Text = "Withdraw";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            this.rbWithdraw.CheckedChanged += new System.EventHandler(this.rbWithdraw_CheckedChanged);
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Checked = true;
            this.rbDeposit.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDeposit.Location = new System.Drawing.Point(6, 35);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(88, 25);
            this.rbDeposit.TabIndex = 0;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            this.rbDeposit.CheckedChanged += new System.EventHandler(this.rbDeposit_CheckedChanged);
            // 
            // numUpdateClientBalance
            // 
            this.numUpdateClientBalance.Location = new System.Drawing.Point(72, 283);
            this.numUpdateClientBalance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numUpdateClientBalance.Name = "numUpdateClientBalance";
            this.numUpdateClientBalance.Size = new System.Drawing.Size(250, 28);
            this.numUpdateClientBalance.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(68, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "Amount";
            // 
            // cbUpdateClientAccNo
            // 
            this.cbUpdateClientAccNo.FormattingEnabled = true;
            this.cbUpdateClientAccNo.Location = new System.Drawing.Point(72, 182);
            this.cbUpdateClientAccNo.Name = "cbUpdateClientAccNo";
            this.cbUpdateClientAccNo.Size = new System.Drawing.Size(250, 29);
            this.cbUpdateClientAccNo.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(68, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 24);
            this.label15.TabIndex = 38;
            this.label15.Text = "Account Number";
            // 
            // tpTransfer
            // 
            this.tpTransfer.Controls.Add(this.label10);
            this.tpTransfer.Controls.Add(this.label11);
            this.tpTransfer.Controls.Add(this.comboBox2);
            this.tpTransfer.Controls.Add(this.label8);
            this.tpTransfer.Controls.Add(this.label3);
            this.tpTransfer.Controls.Add(this.btnTransfer);
            this.tpTransfer.Controls.Add(this.label4);
            this.tpTransfer.Controls.Add(this.label5);
            this.tpTransfer.Controls.Add(this.numericUpDown1);
            this.tpTransfer.Controls.Add(this.label6);
            this.tpTransfer.Controls.Add(this.comboBox1);
            this.tpTransfer.Controls.Add(this.label7);
            this.tpTransfer.Location = new System.Drawing.Point(4, 30);
            this.tpTransfer.Name = "tpTransfer";
            this.tpTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransfer.Size = new System.Drawing.Size(1044, 639);
            this.tpTransfer.TabIndex = 1;
            this.tpTransfer.Text = "Transfer";
            this.tpTransfer.UseVisualStyleBackColor = true;
            // 
            // tpBalances
            // 
            this.tpBalances.Controls.Add(this.label16);
            this.tpBalances.Controls.Add(this.textBox1);
            this.tpBalances.Controls.Add(this.listView1);
            this.tpBalances.Controls.Add(this.gbSort);
            this.tpBalances.Controls.Add(this.panel2);
            this.tpBalances.Controls.Add(this.lblNumOfClients);
            this.tpBalances.Location = new System.Drawing.Point(4, 30);
            this.tpBalances.Name = "tpBalances";
            this.tpBalances.Size = new System.Drawing.Size(1044, 639);
            this.tpBalances.TabIndex = 2;
            this.tpBalances.Text = "Total Balances";
            this.tpBalances.UseVisualStyleBackColor = true;
            // 
            // tpTransferLogs
            // 
            this.tpTransferLogs.Controls.Add(this.lstViewTransferLog);
            this.tpTransferLogs.Controls.Add(this.label12);
            this.tpTransferLogs.Controls.Add(this.textBox2);
            this.tpTransferLogs.Controls.Add(this.groupBox2);
            this.tpTransferLogs.Controls.Add(this.label13);
            this.tpTransferLogs.Location = new System.Drawing.Point(4, 30);
            this.tpTransferLogs.Name = "tpTransferLogs";
            this.tpTransferLogs.Size = new System.Drawing.Size(1044, 639);
            this.tpTransferLogs.TabIndex = 3;
            this.tpTransferLogs.Text = "Transfer Logs";
            this.tpTransferLogs.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(335, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 53);
            this.label3.TabIndex = 54;
            this.label3.Text = "Transactions";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransfer.Location = new System.Drawing.Point(359, 523);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(226, 47);
            this.btnTransfer.TabIndex = 53;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(295, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "0 $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(66, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 33);
            this.label5.TabIndex = 51;
            this.label5.Text = "Current Balance: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(72, 378);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(250, 28);
            this.numericUpDown1.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(68, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Transfer Amount";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 29);
            this.comboBox1.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(68, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Transfer From";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(644, 195);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 29);
            this.comboBox2.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(640, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "Transfer To";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(867, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 24);
            this.label10.TabIndex = 58;
            this.label10.Text = "0 $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(638, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 33);
            this.label11.TabIndex = 57;
            this.label11.Text = "Current Balance: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblTotalBalancesNumber);
            this.panel2.Controls.Add(this.lblTotalBalancesWord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 104);
            this.panel2.TabIndex = 19;
            // 
            // lblTotalBalancesNumber
            // 
            this.lblTotalBalancesNumber.AutoSize = true;
            this.lblTotalBalancesNumber.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalancesNumber.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalancesNumber.Location = new System.Drawing.Point(13, 11);
            this.lblTotalBalancesNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBalancesNumber.Name = "lblTotalBalancesNumber";
            this.lblTotalBalancesNumber.Size = new System.Drawing.Size(261, 34);
            this.lblTotalBalancesNumber.TabIndex = 17;
            this.lblTotalBalancesNumber.Text = "Total Balances: (0$)";
            // 
            // lblTotalBalancesWord
            // 
            this.lblTotalBalancesWord.AutoSize = true;
            this.lblTotalBalancesWord.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalancesWord.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalancesWord.Location = new System.Drawing.Point(13, 52);
            this.lblTotalBalancesWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBalancesWord.Name = "lblTotalBalancesWord";
            this.lblTotalBalancesWord.Size = new System.Drawing.Size(188, 34);
            this.lblTotalBalancesWord.TabIndex = 17;
            this.lblTotalBalancesWord.Text = "(Zero) dollars";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTotalBalancesAccNo,
            this.colTotalBalancesName,
            this.colBalance});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 316);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1044, 323);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colTotalBalancesAccNo
            // 
            this.colTotalBalancesAccNo.Text = "Account Number";
            this.colTotalBalancesAccNo.Width = 150;
            // 
            // colTotalBalancesName
            // 
            this.colTotalBalancesName.Text = "Name";
            this.colTotalBalancesName.Width = 250;
            // 
            // colBalance
            // 
            this.colBalance.Text = "Balance ($)";
            this.colBalance.Width = 314;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(16, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 24);
            this.label16.TabIndex = 13;
            this.label16.Text = "Search By Acc. No.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 28);
            this.textBox1.TabIndex = 12;
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rbDescend);
            this.gbSort.Controls.Add(this.rbAscend);
            this.gbSort.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbSort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbSort.Location = new System.Drawing.Point(692, 154);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(200, 80);
            this.gbSort.TabIndex = 11;
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
            this.lblNumOfClients.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumOfClients.Location = new System.Drawing.Point(15, 237);
            this.lblNumOfClients.Name = "lblNumOfClients";
            this.lblNumOfClients.Size = new System.Drawing.Size(162, 24);
            this.lblNumOfClients.TabIndex = 10;
            this.lblNumOfClients.Text = "0 Client(s) Found";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(30, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Search By Acc. No.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 28);
            this.textBox2.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(706, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 80);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort By";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(128, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 25);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "desc";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(6, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 25);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "asc";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(29, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "0 Client(s) Found";
            // 
            // lstViewTransferLog
            // 
            this.lstViewTransferLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lstViewTransferLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstViewTransferLog.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewTransferLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lstViewTransferLog.FullRowSelect = true;
            this.lstViewTransferLog.GridLines = true;
            this.lstViewTransferLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewTransferLog.HideSelection = false;
            this.lstViewTransferLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstViewTransferLog.Location = new System.Drawing.Point(-4, 251);
            this.lstViewTransferLog.Margin = new System.Windows.Forms.Padding(4);
            this.lstViewTransferLog.MultiSelect = false;
            this.lstViewTransferLog.Name = "lstViewTransferLog";
            this.lstViewTransferLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstViewTransferLog.Size = new System.Drawing.Size(1052, 280);
            this.lstViewTransferLog.TabIndex = 19;
            this.lstViewTransferLog.UseCompatibleStateImageBehavior = false;
            this.lstViewTransferLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date";
            this.columnHeader6.Width = 162;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "s.Acct";
            this.columnHeader7.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "d.Acct";
            this.columnHeader9.Width = 86;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Amount";
            this.columnHeader10.Width = 91;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "s.Balance";
            this.columnHeader11.Width = 117;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "d.Balance";
            this.columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Username";
            this.columnHeader13.Width = 224;
            // 
            // TransactionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 673);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransactionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrasactionsScreen";
            this.Load += new System.EventHandler(this.TrasactionsScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpDepositWithdraw.ResumeLayout(false);
            this.tpDepositWithdraw.PerformLayout();
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateClientBalance)).EndInit();
            this.tpTransfer.ResumeLayout(false);
            this.tpTransfer.PerformLayout();
            this.tpBalances.ResumeLayout(false);
            this.tpBalances.PerformLayout();
            this.tpTransferLogs.ResumeLayout(false);
            this.tpTransferLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldateTime;
        private System.Windows.Forms.PictureBox BankPicBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDepositWithdraw;
        private System.Windows.Forms.TabPage tpTransfer;
        private System.Windows.Forms.TabPage tpBalances;
        private System.Windows.Forms.TabPage tpTransferLogs;
        private System.Windows.Forms.ComboBox cbUpdateClientAccNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numUpdateClientBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalBalancesNumber;
        private System.Windows.Forms.Label lblTotalBalancesWord;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colTotalBalancesAccNo;
        private System.Windows.Forms.ColumnHeader colTotalBalancesName;
        private System.Windows.Forms.ColumnHeader colBalance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rbDescend;
        private System.Windows.Forms.RadioButton rbAscend;
        private System.Windows.Forms.Label lblNumOfClients;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lstViewTransferLog;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}