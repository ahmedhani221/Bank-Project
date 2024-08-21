namespace Bank_Project
{
    partial class MainMenu
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
            this.gbLayout = new System.Windows.Forms.GroupBox();
            this.lbldateTime = new System.Windows.Forms.Label();
            this.BankPicBox = new System.Windows.Forms.PictureBox();
            this.btnManageClients = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.gbLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).BeginInit();
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
            this.gbLayout.Size = new System.Drawing.Size(230, 579);
            this.gbLayout.TabIndex = 1;
            this.gbLayout.TabStop = false;
            // 
            // lbldateTime
            // 
            this.lbldateTime.AutoSize = true;
            this.lbldateTime.Location = new System.Drawing.Point(6, 547);
            this.lbldateTime.Name = "lbldateTime";
            this.lbldateTime.Size = new System.Drawing.Size(66, 17);
            this.lbldateTime.TabIndex = 1;
            this.lbldateTime.Text = "dateTime";
            // 
            // BankPicBox
            // 
            this.BankPicBox.Image = global::Bank_Project.Properties.Resources.BankPic;
            this.BankPicBox.Location = new System.Drawing.Point(9, 45);
            this.BankPicBox.Name = "BankPicBox";
            this.BankPicBox.Size = new System.Drawing.Size(212, 177);
            this.BankPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BankPicBox.TabIndex = 0;
            this.BankPicBox.TabStop = false;
            // 
            // btnManageClients
            // 
            this.btnManageClients.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClients.Font = new System.Drawing.Font("Bahnschrift Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClients.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageClients.Location = new System.Drawing.Point(460, 137);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Size = new System.Drawing.Size(300, 70);
            this.btnManageClients.TabIndex = 2;
            this.btnManageClients.Tag = "1";
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.UseVisualStyleBackColor = false;
            this.btnManageClients.Visible = false;
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Bahnschrift Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageUsers.Location = new System.Drawing.Point(460, 248);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(300, 70);
            this.btnManageUsers.TabIndex = 3;
            this.btnManageUsers.Tag = "2";
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Visible = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Bahnschrift Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransactions.Location = new System.Drawing.Point(460, 359);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(300, 70);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Tag = "4";
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Visible = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("Bahnschrift Light", 17F);
            this.btnExchange.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExchange.Location = new System.Drawing.Point(460, 470);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(300, 70);
            this.btnExchange.TabIndex = 5;
            this.btnExchange.Tag = "8";
            this.btnExchange.Text = "Currency Exchange";
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Visible = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(355, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(224, 53);
            this.title.TabIndex = 6;
            this.title.Text = "Welcome, ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 579);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageClients);
            this.Controls.Add(this.gbLayout);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.gbLayout.ResumeLayout(false);
            this.gbLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLayout;
        private System.Windows.Forms.Label lbldateTime;
        private System.Windows.Forms.PictureBox BankPicBox;
        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label title;
    }
}