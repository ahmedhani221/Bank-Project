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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "EGP",
            "Egypt",
            "Egyptian Pound",
            "49.2"}, -1);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldateTime = new System.Windows.Forms.Label();
            this.BankPicBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpShowCurrencies = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rbDescend = new System.Windows.Forms.RadioButton();
            this.rbAscend = new System.Windows.Forms.RadioButton();
            this.lblNumOfClients = new System.Windows.Forms.Label();
            this.ListViewClients = new System.Windows.Forms.ListView();
            this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCurrencyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpUpdateRate = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numUpdateClientBalance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConversion = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpShowCurrencies.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.tpUpdateRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateClientBalance)).BeginInit();
            this.tpConversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.groupBox1.TabIndex = 4;
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
            this.tabControl1.Controls.Add(this.tpShowCurrencies);
            this.tabControl1.Controls.Add(this.tpUpdateRate);
            this.tabControl1.Controls.Add(this.tpConversion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.tabControl1.Location = new System.Drawing.Point(230, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 673);
            this.tabControl1.TabIndex = 5;
            // 
            // tpShowCurrencies
            // 
            this.tpShowCurrencies.Controls.Add(this.label16);
            this.tpShowCurrencies.Controls.Add(this.textBox1);
            this.tpShowCurrencies.Controls.Add(this.gbSort);
            this.tpShowCurrencies.Controls.Add(this.lblNumOfClients);
            this.tpShowCurrencies.Controls.Add(this.ListViewClients);
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
            this.label16.Location = new System.Drawing.Point(28, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 48);
            this.label16.TabIndex = 14;
            this.label16.Text = "Search by Currency\nCode or Country";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 28);
            this.textBox1.TabIndex = 13;
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rbDescend);
            this.gbSort.Controls.Add(this.rbAscend);
            this.gbSort.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gbSort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbSort.Location = new System.Drawing.Point(689, 35);
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
            this.lblNumOfClients.Location = new System.Drawing.Point(28, 142);
            this.lblNumOfClients.Name = "lblNumOfClients";
            this.lblNumOfClients.Size = new System.Drawing.Size(185, 24);
            this.lblNumOfClients.TabIndex = 11;
            this.lblNumOfClients.Text = "0 Currencies Found";
            // 
            // ListViewClients
            // 
            this.ListViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCode,
            this.colCountry,
            this.colCurrencyName,
            this.colRate});
            this.ListViewClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListViewClients.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F);
            this.ListViewClients.GridLines = true;
            this.ListViewClients.HideSelection = false;
            this.ListViewClients.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ListViewClients.Location = new System.Drawing.Point(3, 199);
            this.ListViewClients.Name = "ListViewClients";
            this.ListViewClients.Size = new System.Drawing.Size(938, 437);
            this.ListViewClients.TabIndex = 10;
            this.ListViewClients.UseCompatibleStateImageBehavior = false;
            this.ListViewClients.View = System.Windows.Forms.View.Details;
            // 
            // colCode
            // 
            this.colCode.Text = "Code";
            this.colCode.Width = 72;
            // 
            // colCountry
            // 
            this.colCountry.Text = "Country";
            this.colCountry.Width = 191;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.Text = "Name";
            this.colCurrencyName.Width = 202;
            // 
            // colRate
            // 
            this.colRate.Text = "Rate/($)";
            this.colRate.Width = 83;
            // 
            // tpUpdateRate
            // 
            this.tpUpdateRate.Controls.Add(this.label3);
            this.tpUpdateRate.Controls.Add(this.button1);
            this.tpUpdateRate.Controls.Add(this.numUpdateClientBalance);
            this.tpUpdateRate.Controls.Add(this.label9);
            this.tpUpdateRate.Controls.Add(this.label2);
            this.tpUpdateRate.Controls.Add(this.comboBox1);
            this.tpUpdateRate.Controls.Add(this.label1);
            this.tpUpdateRate.Location = new System.Drawing.Point(4, 30);
            this.tpUpdateRate.Name = "tpUpdateRate";
            this.tpUpdateRate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateRate.Size = new System.Drawing.Size(944, 639);
            this.tpUpdateRate.TabIndex = 1;
            this.tpUpdateRate.Text = "Update Rate";
            this.tpUpdateRate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(581, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 96);
            this.label3.TabIndex = 39;
            this.label3.Text = "Country: Egypt\nCode: EGP\nCurrency Name: Egyptian Pound\nRate(49.2/$)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(359, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 47);
            this.button1.TabIndex = 38;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // numUpdateClientBalance
            // 
            this.numUpdateClientBalance.Location = new System.Drawing.Point(89, 351);
            this.numUpdateClientBalance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numUpdateClientBalance.Name = "numUpdateClientBalance";
            this.numUpdateClientBalance.Size = new System.Drawing.Size(250, 28);
            this.numUpdateClientBalance.TabIndex = 37;
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
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Currency Code";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 29);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(340, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Update Rate";
            // 
            // tpConversion
            // 
            this.tpConversion.Controls.Add(this.label11);
            this.tpConversion.Controls.Add(this.button2);
            this.tpConversion.Controls.Add(this.label8);
            this.tpConversion.Controls.Add(this.label10);
            this.tpConversion.Controls.Add(this.comboBox3);
            this.tpConversion.Controls.Add(this.label7);
            this.tpConversion.Controls.Add(this.label4);
            this.tpConversion.Controls.Add(this.numericUpDown1);
            this.tpConversion.Controls.Add(this.label5);
            this.tpConversion.Controls.Add(this.label6);
            this.tpConversion.Controls.Add(this.comboBox2);
            this.tpConversion.Location = new System.Drawing.Point(4, 30);
            this.tpConversion.Name = "tpConversion";
            this.tpConversion.Size = new System.Drawing.Size(944, 639);
            this.tpConversion.TabIndex = 2;
            this.tpConversion.Text = "Currency Calculator";
            this.tpConversion.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 16F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(360, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 47);
            this.button2.TabIndex = 49;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(598, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 96);
            this.label8.TabIndex = 48;
            this.label8.Text = "Country: Egypt\nCode: EGP\nCurrency Name: Egyptian Pound\nRate(49.2/$)";
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(602, 211);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(250, 29);
            this.comboBox3.TabIndex = 46;
            this.comboBox3.Text = "EGP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(261, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 53);
            this.label7.TabIndex = 45;
            this.label7.Text = "Currency Calculator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(75, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 96);
            this.label4.TabIndex = 44;
            this.label4.Text = "Country: United States of America\nCode: USD\nCurrency Name: United States Dollar\nR" +
    "ate(1/$)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(79, 398);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(250, 28);
            this.numericUpDown1.TabIndex = 43;
            this.numericUpDown1.Value = new decimal(new int[] {
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(79, 211);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 29);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.Text = "USD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(597, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 29);
            this.label11.TabIndex = 50;
            this.label11.Text = "1 USD = 49.2 EGP";
            // 
            // CurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CurrencyExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrencyExchange";
            this.Load += new System.EventHandler(this.CurrencyExchange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpShowCurrencies.ResumeLayout(false);
            this.tpShowCurrencies.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.tpUpdateRate.ResumeLayout(false);
            this.tpUpdateRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateClientBalance)).EndInit();
            this.tpConversion.ResumeLayout(false);
            this.tpConversion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldateTime;
        private System.Windows.Forms.PictureBox BankPicBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpShowCurrencies;
        private System.Windows.Forms.TabPage tpUpdateRate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rbDescend;
        private System.Windows.Forms.RadioButton rbAscend;
        private System.Windows.Forms.Label lblNumOfClients;
        private System.Windows.Forms.ListView ListViewClients;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colCountry;
        private System.Windows.Forms.ColumnHeader colCurrencyName;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpdateClientBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpConversion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
    }
}