namespace Bank_Project
{
    partial class CurrencyExchange
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
            this.tbCurrency = new System.Windows.Forms.TabControl();
            this.tpShowCurrencies = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rbDescend = new System.Windows.Forms.RadioButton();
            this.rbAscend = new System.Windows.Forms.RadioButton();
            this.lblNumOfCurrencies = new System.Windows.Forms.Label();
            this.ListViewCurrencies = new System.Windows.Forms.ListView();
            this.colCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCurrencyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuCurrencies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpUpdateRate = new System.Windows.Forms.TabPage();
            this.lblCurrencyData = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numUpdateRate = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCountryName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConversion = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblConversion = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblConvertToData = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbConvertTo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblConvertFromData = new System.Windows.Forms.Label();
            this.numExchangeAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbConvertFrom = new System.Windows.Forms.ComboBox();
            this.gbLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).BeginInit();
            this.tbCurrency.SuspendLayout();
            this.tpShowCurrencies.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.contextMenuCurrencies.SuspendLayout();
            this.tpUpdateRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).BeginInit();
            this.tpConversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExchangeAmount)).BeginInit();
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
            this.gbLayout.TabIndex = 4;
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
            // tbCurrency
            // 
            this.tbCurrency.Controls.Add(this.tpShowCurrencies);
            this.tbCurrency.Controls.Add(this.tpUpdateRate);
            this.tbCurrency.Controls.Add(this.tpConversion);
            this.tbCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrency.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.tbCurrency.Location = new System.Drawing.Point(230, 0);
            this.tbCurrency.Name = "tbCurrency";
            this.tbCurrency.SelectedIndex = 0;
            this.tbCurrency.Size = new System.Drawing.Size(952, 673);
            this.tbCurrency.TabIndex = 5;
            // 
            // tpShowCurrencies
            // 
            this.tpShowCurrencies.Controls.Add(this.label16);
            this.tpShowCurrencies.Controls.Add(this.txtSearch);
            this.tpShowCurrencies.Controls.Add(this.gbSort);
            this.tpShowCurrencies.Controls.Add(this.lblNumOfCurrencies);
            this.tpShowCurrencies.Controls.Add(this.ListViewCurrencies);
            this.tpShowCurrencies.Location = new System.Drawing.Point(4, 30);
            this.tpShowCurrencies.Name = "tpShowCurrencies";
            this.tpShowCurrencies.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowCurrencies.Size = new System.Drawing.Size(944, 639);
            this.tpShowCurrencies.TabIndex = 0;
            this.tpShowCurrencies.Text = "Show Currencies";
            this.tpShowCurrencies.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(45, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 48);
            this.label16.TabIndex = 14;
            this.label16.Text = "Search by Currency\nCode or Country";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(45, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 28);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rbDescend);
            this.gbSort.Controls.Add(this.rbAscend);
            this.gbSort.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbSort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbSort.Location = new System.Drawing.Point(696, 35);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(200, 80);
            this.gbSort.TabIndex = 12;
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
            // lblNumOfCurrencies
            // 
            this.lblNumOfCurrencies.AutoSize = true;
            this.lblNumOfCurrencies.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblNumOfCurrencies.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumOfCurrencies.Location = new System.Drawing.Point(45, 142);
            this.lblNumOfCurrencies.Name = "lblNumOfCurrencies";
            this.lblNumOfCurrencies.Size = new System.Drawing.Size(185, 24);
            this.lblNumOfCurrencies.TabIndex = 11;
            this.lblNumOfCurrencies.Text = "0 Currencies Found";
            // 
            // ListViewCurrencies
            // 
            this.ListViewCurrencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCountry,
            this.colCode,
            this.colCurrencyName,
            this.colRate});
            this.ListViewCurrencies.ContextMenuStrip = this.contextMenuCurrencies;
            this.ListViewCurrencies.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.ListViewCurrencies.FullRowSelect = true;
            this.ListViewCurrencies.GridLines = true;
            this.ListViewCurrencies.HideSelection = false;
            this.ListViewCurrencies.Location = new System.Drawing.Point(45, 245);
            this.ListViewCurrencies.Name = "ListViewCurrencies";
            this.ListViewCurrencies.Size = new System.Drawing.Size(851, 355);
            this.ListViewCurrencies.TabIndex = 10;
            this.ListViewCurrencies.UseCompatibleStateImageBehavior = false;
            this.ListViewCurrencies.View = System.Windows.Forms.View.Details;
            // 
            // colCountry
            // 
            this.colCountry.Text = "Country";
            this.colCountry.Width = 191;
            // 
            // colCode
            // 
            this.colCode.Text = "Code";
            this.colCode.Width = 72;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.Text = "Name";
            this.colCurrencyName.Width = 252;
            // 
            // colRate
            // 
            this.colRate.Text = "Rate/($)";
            this.colRate.Width = 98;
            // 
            // contextMenuCurrencies
            // 
            this.contextMenuCurrencies.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuCurrencies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRateToolStripMenuItem,
            this.currencyCalculatorToolStripMenuItem});
            this.contextMenuCurrencies.Name = "contextMenuCurrencies";
            this.contextMenuCurrencies.Size = new System.Drawing.Size(207, 52);
            // 
            // updateRateToolStripMenuItem
            // 
            this.updateRateToolStripMenuItem.Name = "updateRateToolStripMenuItem";
            this.updateRateToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.updateRateToolStripMenuItem.Text = "Update Rate";
            this.updateRateToolStripMenuItem.Click += new System.EventHandler(this.updateRateToolStripMenuItem_Click);
            // 
            // currencyCalculatorToolStripMenuItem
            // 
            this.currencyCalculatorToolStripMenuItem.Name = "currencyCalculatorToolStripMenuItem";
            this.currencyCalculatorToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.currencyCalculatorToolStripMenuItem.Text = "Currency Calculator";
            this.currencyCalculatorToolStripMenuItem.Click += new System.EventHandler(this.currencyCalculatorToolStripMenuItem_Click);
            // 
            // tpUpdateRate
            // 
            this.tpUpdateRate.Controls.Add(this.lblCurrencyData);
            this.tpUpdateRate.Controls.Add(this.btnUpdate);
            this.tpUpdateRate.Controls.Add(this.numUpdateRate);
            this.tpUpdateRate.Controls.Add(this.label9);
            this.tpUpdateRate.Controls.Add(this.label2);
            this.tpUpdateRate.Controls.Add(this.cbCountryName);
            this.tpUpdateRate.Controls.Add(this.label1);
            this.tpUpdateRate.Location = new System.Drawing.Point(4, 30);
            this.tpUpdateRate.Name = "tpUpdateRate";
            this.tpUpdateRate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateRate.Size = new System.Drawing.Size(944, 639);
            this.tpUpdateRate.TabIndex = 1;
            this.tpUpdateRate.Text = "Update Rate";
            this.tpUpdateRate.UseVisualStyleBackColor = true;
            // 
            // lblCurrencyData
            // 
            this.lblCurrencyData.AutoSize = true;
            this.lblCurrencyData.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblCurrencyData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCurrencyData.Location = new System.Drawing.Point(575, 227);
            this.lblCurrencyData.Name = "lblCurrencyData";
            this.lblCurrencyData.Size = new System.Drawing.Size(0, 24);
            this.lblCurrencyData.TabIndex = 39;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(348, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(226, 47);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numUpdateRate
            // 
            this.numUpdateRate.DecimalPlaces = 4;
            this.numUpdateRate.Location = new System.Drawing.Point(89, 351);
            this.numUpdateRate.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numUpdateRate.Name = "numUpdateRate";
            this.numUpdateRate.Size = new System.Drawing.Size(250, 28);
            this.numUpdateRate.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(85, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "New Rate ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(85, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Country";
            // 
            // cbCountryName
            // 
            this.cbCountryName.FormattingEnabled = true;
            this.cbCountryName.Location = new System.Drawing.Point(89, 222);
            this.cbCountryName.Name = "cbCountryName";
            this.cbCountryName.Size = new System.Drawing.Size(250, 29);
            this.cbCountryName.TabIndex = 11;
            this.cbCountryName.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(330, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Update Rate";
            // 
            // tpConversion
            // 
            this.tpConversion.Controls.Add(this.btnReset);
            this.tpConversion.Controls.Add(this.lblConversion);
            this.tpConversion.Controls.Add(this.btnCalc);
            this.tpConversion.Controls.Add(this.lblConvertToData);
            this.tpConversion.Controls.Add(this.label10);
            this.tpConversion.Controls.Add(this.cbConvertTo);
            this.tpConversion.Controls.Add(this.label7);
            this.tpConversion.Controls.Add(this.lblConvertFromData);
            this.tpConversion.Controls.Add(this.numExchangeAmount);
            this.tpConversion.Controls.Add(this.label5);
            this.tpConversion.Controls.Add(this.label6);
            this.tpConversion.Controls.Add(this.cbConvertFrom);
            this.tpConversion.Location = new System.Drawing.Point(4, 30);
            this.tpConversion.Name = "tpConversion";
            this.tpConversion.Size = new System.Drawing.Size(944, 639);
            this.tpConversion.TabIndex = 2;
            this.tpConversion.Text = "Currency Calculator";
            this.tpConversion.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Location = new System.Drawing.Point(349, 569);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(226, 47);
            this.btnReset.TabIndex = 51;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.lblConversion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConversion.Location = new System.Drawing.Point(597, 394);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(0, 29);
            this.lblConversion.TabIndex = 50;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalc.Location = new System.Drawing.Point(349, 495);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(226, 47);
            this.btnCalc.TabIndex = 49;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblConvertToData
            // 
            this.lblConvertToData.AutoSize = true;
            this.lblConvertToData.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblConvertToData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConvertToData.Location = new System.Drawing.Point(598, 243);
            this.lblConvertToData.Name = "lblConvertToData";
            this.lblConvertToData.Size = new System.Drawing.Size(0, 24);
            this.lblConvertToData.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(598, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 47;
            this.label10.Text = "Convert To";
            // 
            // cbConvertTo
            // 
            this.cbConvertTo.FormattingEnabled = true;
            this.cbConvertTo.Location = new System.Drawing.Point(602, 211);
            this.cbConvertTo.Name = "cbConvertTo";
            this.cbConvertTo.Size = new System.Drawing.Size(250, 29);
            this.cbConvertTo.TabIndex = 46;
            this.cbConvertTo.SelectedIndexChanged += new System.EventHandler(this.cbConvertTo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(250, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 53);
            this.label7.TabIndex = 45;
            this.label7.Text = "Currency Calculator";
            // 
            // lblConvertFromData
            // 
            this.lblConvertFromData.AutoSize = true;
            this.lblConvertFromData.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.lblConvertFromData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConvertFromData.Location = new System.Drawing.Point(75, 243);
            this.lblConvertFromData.Name = "lblConvertFromData";
            this.lblConvertFromData.Size = new System.Drawing.Size(0, 24);
            this.lblConvertFromData.TabIndex = 44;
            // 
            // numExchangeAmount
            // 
            this.numExchangeAmount.DecimalPlaces = 4;
            this.numExchangeAmount.Location = new System.Drawing.Point(79, 398);
            this.numExchangeAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numExchangeAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExchangeAmount.Name = "numExchangeAmount";
            this.numExchangeAmount.Size = new System.Drawing.Size(250, 28);
            this.numExchangeAmount.TabIndex = 43;
            this.numExchangeAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(75, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Amount To Exchange";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(75, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Convert From";
            // 
            // cbConvertFrom
            // 
            this.cbConvertFrom.FormattingEnabled = true;
            this.cbConvertFrom.Location = new System.Drawing.Point(79, 211);
            this.cbConvertFrom.Name = "cbConvertFrom";
            this.cbConvertFrom.Size = new System.Drawing.Size(250, 29);
            this.cbConvertFrom.TabIndex = 40;
            this.cbConvertFrom.SelectedIndexChanged += new System.EventHandler(this.cbConvertFrom_SelectedIndexChanged);
            // 
            // CurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.tbCurrency);
            this.Controls.Add(this.gbLayout);
            this.Name = "CurrencyExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrencyExchange";
            this.Load += new System.EventHandler(this.CurrencyExchange_Load);
            this.gbLayout.ResumeLayout(false);
            this.gbLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).EndInit();
            this.tbCurrency.ResumeLayout(false);
            this.tpShowCurrencies.ResumeLayout(false);
            this.tpShowCurrencies.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.contextMenuCurrencies.ResumeLayout(false);
            this.tpUpdateRate.ResumeLayout(false);
            this.tpUpdateRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).EndInit();
            this.tpConversion.ResumeLayout(false);
            this.tpConversion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExchangeAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLayout;
        private System.Windows.Forms.Label lbldateTime;
        private System.Windows.Forms.PictureBox BankPicBox;
        private System.Windows.Forms.TabControl tbCurrency;
        private System.Windows.Forms.TabPage tpShowCurrencies;
        private System.Windows.Forms.TabPage tpUpdateRate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rbDescend;
        private System.Windows.Forms.RadioButton rbAscend;
        private System.Windows.Forms.Label lblNumOfCurrencies;
        private System.Windows.Forms.ListView ListViewCurrencies;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colCountry;
        private System.Windows.Forms.ColumnHeader colCurrencyName;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ComboBox cbCountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpdateRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCurrencyData;
        private System.Windows.Forms.TabPage tpConversion;
        private System.Windows.Forms.Label lblConvertFromData;
        private System.Windows.Forms.NumericUpDown numExchangeAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbConvertFrom;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblConvertToData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbConvertTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.ContextMenuStrip contextMenuCurrencies;
        private System.Windows.Forms.ToolStripMenuItem updateRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyCalculatorToolStripMenuItem;
        private System.Windows.Forms.Button btnReset;
    }
}