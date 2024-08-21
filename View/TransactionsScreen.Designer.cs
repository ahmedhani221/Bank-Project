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
            this.components = new System.ComponentModel.Container();
            this.gbLayout = new System.Windows.Forms.GroupBox();
            this.lbldateTime = new System.Windows.Forms.Label();
            this.BankPicBox = new System.Windows.Forms.PictureBox();
            this.tabControlTransaction = new System.Windows.Forms.TabControl();
            this.tpDepositWithdraw = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblTransactionCurrentBalance = new System.Windows.Forms.Label();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.numTransaction = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTransactionAccNo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tpTransfer = new System.Windows.Forms.TabPage();
            this.lblTransferToBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTransferToAccNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblTransferFromBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numTransfer = new System.Windows.Forms.NumericUpDown();
            this.lblTransferAmount = new System.Windows.Forms.Label();
            this.cbTransferFromAccNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpBalances = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearchBalances = new System.Windows.Forms.TextBox();
            this.ListViewBalances = new System.Windows.Forms.ListView();
            this.colTotalBalancesAccNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalBalancesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rbDescend = new System.Windows.Forms.RadioButton();
            this.rbAscend = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalBalancesNumber = new System.Windows.Forms.Label();
            this.lblTotalBalancesWord = new System.Windows.Forms.Label();
            this.lblNumOfClientBalances = new System.Windows.Forms.Label();
            this.tpTransferLogs = new System.Windows.Forms.TabPage();
            this.listViewTransferLog = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchLogs = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDescendLogs = new System.Windows.Forms.RadioButton();
            this.rbAscendLogs = new System.Windows.Forms.RadioButton();
            this.lblTransferLogs = new System.Windows.Forms.Label();
            this.errorProviderTransaction = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).BeginInit();
            this.tabControlTransaction.SuspendLayout();
            this.tpDepositWithdraw.SuspendLayout();
            this.gbOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransaction)).BeginInit();
            this.tpTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransfer)).BeginInit();
            this.tpBalances.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpTransferLogs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaction)).BeginInit();
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
            this.gbLayout.Size = new System.Drawing.Size(230, 673);
            this.gbLayout.TabIndex = 3;
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
            // tabControlTransaction
            // 
            this.tabControlTransaction.Controls.Add(this.tpDepositWithdraw);
            this.tabControlTransaction.Controls.Add(this.tpTransfer);
            this.tabControlTransaction.Controls.Add(this.tpBalances);
            this.tabControlTransaction.Controls.Add(this.tpTransferLogs);
            this.tabControlTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTransaction.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.tabControlTransaction.Location = new System.Drawing.Point(230, 0);
            this.tabControlTransaction.Name = "tabControlTransaction";
            this.tabControlTransaction.SelectedIndex = 0;
            this.tabControlTransaction.Size = new System.Drawing.Size(1052, 673);
            this.tabControlTransaction.TabIndex = 4;
            // 
            // tpDepositWithdraw
            // 
            this.tpDepositWithdraw.Controls.Add(this.label2);
            this.tpDepositWithdraw.Controls.Add(this.btnTransaction);
            this.tpDepositWithdraw.Controls.Add(this.lblBalance);
            this.tpDepositWithdraw.Controls.Add(this.lblTransactionCurrentBalance);
            this.tpDepositWithdraw.Controls.Add(this.gbOption);
            this.tpDepositWithdraw.Controls.Add(this.numTransaction);
            this.tpDepositWithdraw.Controls.Add(this.label9);
            this.tpDepositWithdraw.Controls.Add(this.cbTransactionAccNo);
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
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransaction.Location = new System.Drawing.Point(359, 510);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(226, 47);
            this.btnTransaction.TabIndex = 45;
            this.btnTransaction.Text = "Deposit";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Green;
            this.lblBalance.Location = new System.Drawing.Point(354, 388);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(74, 28);
            this.lblBalance.TabIndex = 44;
            this.lblBalance.Text = "0 EGP";
            // 
            // lblTransactionCurrentBalance
            // 
            this.lblTransactionCurrentBalance.AutoSize = true;
            this.lblTransactionCurrentBalance.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.lblTransactionCurrentBalance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTransactionCurrentBalance.Location = new System.Drawing.Point(65, 378);
            this.lblTransactionCurrentBalance.Name = "lblTransactionCurrentBalance";
            this.lblTransactionCurrentBalance.Size = new System.Drawing.Size(283, 41);
            this.lblTransactionCurrentBalance.TabIndex = 43;
            this.lblTransactionCurrentBalance.Text = "Current Balance: ";
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
            // numTransaction
            // 
            this.numTransaction.Location = new System.Drawing.Point(72, 283);
            this.numTransaction.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numTransaction.Name = "numTransaction";
            this.numTransaction.Size = new System.Drawing.Size(250, 28);
            this.numTransaction.TabIndex = 41;
            this.numTransaction.Validating += new System.ComponentModel.CancelEventHandler(this.numAmount_Validating);
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
            // cbTransactionAccNo
            // 
            this.cbTransactionAccNo.FormattingEnabled = true;
            this.cbTransactionAccNo.Location = new System.Drawing.Point(72, 182);
            this.cbTransactionAccNo.Name = "cbTransactionAccNo";
            this.cbTransactionAccNo.Size = new System.Drawing.Size(250, 29);
            this.cbTransactionAccNo.TabIndex = 39;
            this.cbTransactionAccNo.SelectedIndexChanged += new System.EventHandler(this.cbTransactionAccNo_SelectedIndexChanged);
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
            this.tpTransfer.Controls.Add(this.lblTransferToBalance);
            this.tpTransfer.Controls.Add(this.label6);
            this.tpTransfer.Controls.Add(this.cbTransferToAccNo);
            this.tpTransfer.Controls.Add(this.label8);
            this.tpTransfer.Controls.Add(this.label3);
            this.tpTransfer.Controls.Add(this.btnTransfer);
            this.tpTransfer.Controls.Add(this.lblTransferFromBalance);
            this.tpTransfer.Controls.Add(this.label5);
            this.tpTransfer.Controls.Add(this.numTransfer);
            this.tpTransfer.Controls.Add(this.lblTransferAmount);
            this.tpTransfer.Controls.Add(this.cbTransferFromAccNo);
            this.tpTransfer.Controls.Add(this.label7);
            this.tpTransfer.Location = new System.Drawing.Point(4, 30);
            this.tpTransfer.Name = "tpTransfer";
            this.tpTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransfer.Size = new System.Drawing.Size(1044, 639);
            this.tpTransfer.TabIndex = 1;
            this.tpTransfer.Text = "Transfer";
            this.tpTransfer.UseVisualStyleBackColor = true;
            // 
            // lblTransferToBalance
            // 
            this.lblTransferToBalance.AutoSize = true;
            this.lblTransferToBalance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransferToBalance.ForeColor = System.Drawing.Color.Green;
            this.lblTransferToBalance.Location = new System.Drawing.Point(867, 253);
            this.lblTransferToBalance.Name = "lblTransferToBalance";
            this.lblTransferToBalance.Size = new System.Drawing.Size(63, 24);
            this.lblTransferToBalance.TabIndex = 58;
            this.lblTransferToBalance.Text = "0 EGP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(638, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 33);
            this.label6.TabIndex = 57;
            this.label6.Text = "Current Balance: ";
            // 
            // cbTransferToAccNo
            // 
            this.cbTransferToAccNo.FormattingEnabled = true;
            this.cbTransferToAccNo.Location = new System.Drawing.Point(644, 195);
            this.cbTransferToAccNo.Name = "cbTransferToAccNo";
            this.cbTransferToAccNo.Size = new System.Drawing.Size(250, 29);
            this.cbTransferToAccNo.TabIndex = 56;
            this.cbTransferToAccNo.SelectedIndexChanged += new System.EventHandler(this.cbTransferToAccNo_SelectedIndexChanged);
            this.cbTransferToAccNo.Validating += new System.ComponentModel.CancelEventHandler(this.cbTransferToAccNo_Validating);
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
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblTransferFromBalance
            // 
            this.lblTransferFromBalance.AutoSize = true;
            this.lblTransferFromBalance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransferFromBalance.ForeColor = System.Drawing.Color.Green;
            this.lblTransferFromBalance.Location = new System.Drawing.Point(295, 255);
            this.lblTransferFromBalance.Name = "lblTransferFromBalance";
            this.lblTransferFromBalance.Size = new System.Drawing.Size(63, 24);
            this.lblTransferFromBalance.TabIndex = 52;
            this.lblTransferFromBalance.Text = "0 EGP";
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
            // numTransfer
            // 
            this.numTransfer.Location = new System.Drawing.Point(72, 378);
            this.numTransfer.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numTransfer.Name = "numTransfer";
            this.numTransfer.Size = new System.Drawing.Size(250, 28);
            this.numTransfer.TabIndex = 50;
            this.numTransfer.Validating += new System.ComponentModel.CancelEventHandler(this.numAmount_Validating);
            // 
            // lblTransferAmount
            // 
            this.lblTransferAmount.AutoSize = true;
            this.lblTransferAmount.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblTransferAmount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTransferAmount.Location = new System.Drawing.Point(68, 351);
            this.lblTransferAmount.Name = "lblTransferAmount";
            this.lblTransferAmount.Size = new System.Drawing.Size(161, 24);
            this.lblTransferAmount.TabIndex = 49;
            this.lblTransferAmount.Text = "Transfer Amount";
            // 
            // cbTransferFromAccNo
            // 
            this.cbTransferFromAccNo.FormattingEnabled = true;
            this.cbTransferFromAccNo.Location = new System.Drawing.Point(72, 195);
            this.cbTransferFromAccNo.Name = "cbTransferFromAccNo";
            this.cbTransferFromAccNo.Size = new System.Drawing.Size(250, 29);
            this.cbTransferFromAccNo.TabIndex = 48;
            this.cbTransferFromAccNo.SelectedIndexChanged += new System.EventHandler(this.cbTransferFromAccNo_SelectedIndexChanged);
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
            // tpBalances
            // 
            this.tpBalances.Controls.Add(this.label16);
            this.tpBalances.Controls.Add(this.txtSearchBalances);
            this.tpBalances.Controls.Add(this.ListViewBalances);
            this.tpBalances.Controls.Add(this.gbSort);
            this.tpBalances.Controls.Add(this.panel2);
            this.tpBalances.Controls.Add(this.lblNumOfClientBalances);
            this.tpBalances.Location = new System.Drawing.Point(4, 30);
            this.tpBalances.Name = "tpBalances";
            this.tpBalances.Size = new System.Drawing.Size(1044, 639);
            this.tpBalances.TabIndex = 2;
            this.tpBalances.Text = "Total Balances";
            this.tpBalances.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(60, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 24);
            this.label16.TabIndex = 13;
            this.label16.Text = "Search By Acc. No.";
            // 
            // txtSearchBalances
            // 
            this.txtSearchBalances.Location = new System.Drawing.Point(63, 181);
            this.txtSearchBalances.Name = "txtSearchBalances";
            this.txtSearchBalances.Size = new System.Drawing.Size(220, 28);
            this.txtSearchBalances.TabIndex = 12;
            this.txtSearchBalances.TextChanged += new System.EventHandler(this.txtSearchBalances_TextChanged);
            // 
            // ListViewBalances
            // 
            this.ListViewBalances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTotalBalancesAccNo,
            this.colTotalBalancesName,
            this.colBalance});
            this.ListViewBalances.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.ListViewBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ListViewBalances.FullRowSelect = true;
            this.ListViewBalances.GridLines = true;
            this.ListViewBalances.HideSelection = false;
            this.ListViewBalances.Location = new System.Drawing.Point(200, 285);
            this.ListViewBalances.MultiSelect = false;
            this.ListViewBalances.Name = "ListViewBalances";
            this.ListViewBalances.Size = new System.Drawing.Size(670, 325);
            this.ListViewBalances.TabIndex = 1;
            this.ListViewBalances.UseCompatibleStateImageBehavior = false;
            this.ListViewBalances.View = System.Windows.Forms.View.Details;
            // 
            // colTotalBalancesAccNo
            // 
            this.colTotalBalancesAccNo.Text = "Account Number";
            this.colTotalBalancesAccNo.Width = 163;
            // 
            // colTotalBalancesName
            // 
            this.colTotalBalancesName.Text = "Name";
            this.colTotalBalancesName.Width = 163;
            // 
            // colBalance
            // 
            this.colBalance.Text = "Balance (EGP)";
            this.colBalance.Width = 163;
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rbDescend);
            this.gbSort.Controls.Add(this.rbAscend);
            this.gbSort.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbSort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbSort.Location = new System.Drawing.Point(774, 154);
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
            this.lblTotalBalancesNumber.Size = new System.Drawing.Size(306, 34);
            this.lblTotalBalancesNumber.TabIndex = 17;
            this.lblTotalBalancesNumber.Text = "Total Balances: (0 EGP)";
            // 
            // lblTotalBalancesWord
            // 
            this.lblTotalBalancesWord.AutoSize = true;
            this.lblTotalBalancesWord.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalancesWord.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalancesWord.Location = new System.Drawing.Point(13, 52);
            this.lblTotalBalancesWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBalancesWord.Name = "lblTotalBalancesWord";
            this.lblTotalBalancesWord.Size = new System.Drawing.Size(294, 34);
            this.lblTotalBalancesWord.TabIndex = 17;
            this.lblTotalBalancesWord.Text = "(Zero) Egyptian Pound";
            // 
            // lblNumOfClientBalances
            // 
            this.lblNumOfClientBalances.AutoSize = true;
            this.lblNumOfClientBalances.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblNumOfClientBalances.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumOfClientBalances.Location = new System.Drawing.Point(59, 237);
            this.lblNumOfClientBalances.Name = "lblNumOfClientBalances";
            this.lblNumOfClientBalances.Size = new System.Drawing.Size(162, 24);
            this.lblNumOfClientBalances.TabIndex = 10;
            this.lblNumOfClientBalances.Text = "0 Client(s) Found";
            // 
            // tpTransferLogs
            // 
            this.tpTransferLogs.Controls.Add(this.listViewTransferLog);
            this.tpTransferLogs.Controls.Add(this.label12);
            this.tpTransferLogs.Controls.Add(this.txtSearchLogs);
            this.tpTransferLogs.Controls.Add(this.groupBox2);
            this.tpTransferLogs.Controls.Add(this.lblTransferLogs);
            this.tpTransferLogs.Location = new System.Drawing.Point(4, 30);
            this.tpTransferLogs.Name = "tpTransferLogs";
            this.tpTransferLogs.Size = new System.Drawing.Size(1044, 639);
            this.tpTransferLogs.TabIndex = 3;
            this.tpTransferLogs.Text = "Transfer Logs";
            this.tpTransferLogs.UseVisualStyleBackColor = true;
            // 
            // listViewTransferLog
            // 
            this.listViewTransferLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewTransferLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewTransferLog.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTransferLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.listViewTransferLog.FullRowSelect = true;
            this.listViewTransferLog.GridLines = true;
            this.listViewTransferLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTransferLog.HideSelection = false;
            this.listViewTransferLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewTransferLog.Location = new System.Drawing.Point(-4, 251);
            this.listViewTransferLog.Margin = new System.Windows.Forms.Padding(4);
            this.listViewTransferLog.MultiSelect = false;
            this.listViewTransferLog.Name = "listViewTransferLog";
            this.listViewTransferLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewTransferLog.Size = new System.Drawing.Size(1052, 280);
            this.listViewTransferLog.TabIndex = 19;
            this.listViewTransferLog.UseCompatibleStateImageBehavior = false;
            this.listViewTransferLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date";
            this.columnHeader6.Width = 162;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Account From";
            this.columnHeader7.Width = 141;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Account To";
            this.columnHeader9.Width = 114;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Amount";
            this.columnHeader10.Width = 91;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "BalanceFrom";
            this.columnHeader11.Width = 138;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "BalanceTo";
            this.columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Username";
            this.columnHeader13.Width = 108;
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
            // txtSearchLogs
            // 
            this.txtSearchLogs.Location = new System.Drawing.Point(33, 127);
            this.txtSearchLogs.Name = "txtSearchLogs";
            this.txtSearchLogs.Size = new System.Drawing.Size(220, 28);
            this.txtSearchLogs.TabIndex = 16;
            this.txtSearchLogs.TextChanged += new System.EventHandler(this.txtSearchLogs_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDescendLogs);
            this.groupBox2.Controls.Add(this.rbAscendLogs);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(706, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 80);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort By";
            // 
            // rbDescendLogs
            // 
            this.rbDescendLogs.AutoSize = true;
            this.rbDescendLogs.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbDescendLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDescendLogs.Location = new System.Drawing.Point(128, 35);
            this.rbDescendLogs.Name = "rbDescendLogs";
            this.rbDescendLogs.Size = new System.Drawing.Size(66, 25);
            this.rbDescendLogs.TabIndex = 1;
            this.rbDescendLogs.Text = "desc";
            this.rbDescendLogs.UseVisualStyleBackColor = true;
            this.rbDescendLogs.CheckedChanged += new System.EventHandler(this.rbDescendLogs_CheckedChanged);
            // 
            // rbAscendLogs
            // 
            this.rbAscendLogs.AutoSize = true;
            this.rbAscendLogs.Checked = true;
            this.rbAscendLogs.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.rbAscendLogs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbAscendLogs.Location = new System.Drawing.Point(6, 35);
            this.rbAscendLogs.Name = "rbAscendLogs";
            this.rbAscendLogs.Size = new System.Drawing.Size(57, 25);
            this.rbAscendLogs.TabIndex = 0;
            this.rbAscendLogs.TabStop = true;
            this.rbAscendLogs.Text = "asc";
            this.rbAscendLogs.UseVisualStyleBackColor = true;
            this.rbAscendLogs.CheckedChanged += new System.EventHandler(this.rbAscendLogs_CheckedChanged);
            // 
            // lblTransferLogs
            // 
            this.lblTransferLogs.AutoSize = true;
            this.lblTransferLogs.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblTransferLogs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTransferLogs.Location = new System.Drawing.Point(29, 183);
            this.lblTransferLogs.Name = "lblTransferLogs";
            this.lblTransferLogs.Size = new System.Drawing.Size(186, 24);
            this.lblTransferLogs.TabIndex = 14;
            this.lblTransferLogs.Text = "0 Transfer(s) Found";
            // 
            // errorProviderTransaction
            // 
            this.errorProviderTransaction.ContainerControl = this;
            // 
            // TransactionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 673);
            this.Controls.Add(this.tabControlTransaction);
            this.Controls.Add(this.gbLayout);
            this.Name = "TransactionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrasactionsScreen";
            this.Load += new System.EventHandler(this.TrasactionsScreen_Load);
            this.gbLayout.ResumeLayout(false);
            this.gbLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).EndInit();
            this.tabControlTransaction.ResumeLayout(false);
            this.tpDepositWithdraw.ResumeLayout(false);
            this.tpDepositWithdraw.PerformLayout();
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransaction)).EndInit();
            this.tpTransfer.ResumeLayout(false);
            this.tpTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransfer)).EndInit();
            this.tpBalances.ResumeLayout(false);
            this.tpBalances.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpTransferLogs.ResumeLayout(false);
            this.tpTransferLogs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLayout;
        private System.Windows.Forms.Label lbldateTime;
        private System.Windows.Forms.PictureBox BankPicBox;
        public System.Windows.Forms.TabControl tabControlTransaction;
        private System.Windows.Forms.TabPage tpDepositWithdraw;
        private System.Windows.Forms.TabPage tpTransfer;
        private System.Windows.Forms.TabPage tpBalances;
        private System.Windows.Forms.TabPage tpTransferLogs;
        public System.Windows.Forms.ComboBox cbTransactionAccNo;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.NumericUpDown numTransaction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbOption;
        public System.Windows.Forms.RadioButton rbWithdraw;
        public System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblTransactionCurrentBalance;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblTransferFromBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTransfer;
        private System.Windows.Forms.Label lblTransferAmount;
        private System.Windows.Forms.ComboBox cbTransferFromAccNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTransferToAccNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTransferToBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalBalancesNumber;
        private System.Windows.Forms.Label lblTotalBalancesWord;
        private System.Windows.Forms.ListView ListViewBalances;
        private System.Windows.Forms.ColumnHeader colTotalBalancesAccNo;
        private System.Windows.Forms.ColumnHeader colTotalBalancesName;
        private System.Windows.Forms.ColumnHeader colBalance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearchBalances;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rbDescend;
        private System.Windows.Forms.RadioButton rbAscend;
        private System.Windows.Forms.Label lblNumOfClientBalances;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchLogs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDescendLogs;
        private System.Windows.Forms.RadioButton rbAscendLogs;
        private System.Windows.Forms.Label lblTransferLogs;
        private System.Windows.Forms.ListView listViewTransferLog;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ErrorProvider errorProviderTransaction;
    }
}