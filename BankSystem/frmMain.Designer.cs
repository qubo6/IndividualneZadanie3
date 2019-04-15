namespace BankSystem
{
    partial class frmMain
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
            this.cmdFindClient = new System.Windows.Forms.Button();
            this.cmdNewAccount = new System.Windows.Forms.Button();
            this.cmdAllAccounts = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgwOverView = new System.Windows.Forms.DataGridView();
            this.btnBankAss = new System.Windows.Forms.Button();
            this.btnDemography = new System.Windows.Forms.Button();
            this.btnActiveAcc = new System.Windows.Forms.Button();
            this.btnNewest = new System.Windows.Forms.Button();
            this.btnTop10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOverView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdFindClient
            // 
            this.cmdFindClient.Location = new System.Drawing.Point(495, 11);
            this.cmdFindClient.Name = "cmdFindClient";
            this.cmdFindClient.Size = new System.Drawing.Size(112, 21);
            this.cmdFindClient.TabIndex = 2;
            this.cmdFindClient.Text = "Find client";
            this.cmdFindClient.UseVisualStyleBackColor = true;
            this.cmdFindClient.Click += new System.EventHandler(this.cmdFindClient_Click);
            // 
            // cmdNewAccount
            // 
            this.cmdNewAccount.Location = new System.Drawing.Point(495, 48);
            this.cmdNewAccount.Name = "cmdNewAccount";
            this.cmdNewAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdNewAccount.TabIndex = 3;
            this.cmdNewAccount.Text = "New account";
            this.cmdNewAccount.UseVisualStyleBackColor = true;
            this.cmdNewAccount.Click += new System.EventHandler(this.cmdNewAccount_Click);
            // 
            // cmdAllAccounts
            // 
            this.cmdAllAccounts.Location = new System.Drawing.Point(495, 77);
            this.cmdAllAccounts.Name = "cmdAllAccounts";
            this.cmdAllAccounts.Size = new System.Drawing.Size(112, 23);
            this.cmdAllAccounts.TabIndex = 4;
            this.cmdAllAccounts.Text = "All accounts";
            this.cmdAllAccounts.UseVisualStyleBackColor = true;
            this.cmdAllAccounts.Click += new System.EventHandler(this.cmdAllAccounts_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(495, 106);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 5;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(234, 11);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(217, 20);
            this.txtFilter.TabIndex = 10;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgwOverView
            // 
            this.dgwOverView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOverView.Location = new System.Drawing.Point(13, 48);
            this.dgwOverView.Name = "dgwOverView";
            this.dgwOverView.ReadOnly = true;
            this.dgwOverView.RowHeadersVisible = false;
            this.dgwOverView.Size = new System.Drawing.Size(438, 196);
            this.dgwOverView.TabIndex = 11;
            // 
            // btnBankAss
            // 
            this.btnBankAss.Location = new System.Drawing.Point(13, 266);
            this.btnBankAss.Name = "btnBankAss";
            this.btnBankAss.Size = new System.Drawing.Size(100, 25);
            this.btnBankAss.TabIndex = 12;
            this.btnBankAss.Text = "Bank Assets";
            this.btnBankAss.UseVisualStyleBackColor = true;
            this.btnBankAss.Click += new System.EventHandler(this.btnBankAss_Click);
            // 
            // btnDemography
            // 
            this.btnDemography.Location = new System.Drawing.Point(119, 266);
            this.btnDemography.Name = "btnDemography";
            this.btnDemography.Size = new System.Drawing.Size(100, 25);
            this.btnDemography.TabIndex = 13;
            this.btnDemography.Text = "Demography";
            this.btnDemography.UseVisualStyleBackColor = true;
            this.btnDemography.Click += new System.EventHandler(this.btnDemography_Click);
            // 
            // btnActiveAcc
            // 
            this.btnActiveAcc.Location = new System.Drawing.Point(225, 266);
            this.btnActiveAcc.Name = "btnActiveAcc";
            this.btnActiveAcc.Size = new System.Drawing.Size(100, 25);
            this.btnActiveAcc.TabIndex = 14;
            this.btnActiveAcc.Text = "Active Accounts";
            this.btnActiveAcc.UseVisualStyleBackColor = true;
            this.btnActiveAcc.Click += new System.EventHandler(this.btnActiveAcc_Click);
            // 
            // btnNewest
            // 
            this.btnNewest.Location = new System.Drawing.Point(13, 297);
            this.btnNewest.Name = "btnNewest";
            this.btnNewest.Size = new System.Drawing.Size(100, 25);
            this.btnNewest.TabIndex = 15;
            this.btnNewest.Text = "The Newest Accounts";
            this.btnNewest.UseVisualStyleBackColor = true;
            this.btnNewest.Click += new System.EventHandler(this.btnNewest_Click);
            // 
            // btnTop10
            // 
            this.btnTop10.Location = new System.Drawing.Point(119, 297);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(100, 25);
            this.btnTop10.TabIndex = 16;
            this.btnTop10.Text = "Top 10 Accounts";
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search by Identity Card or IBAN";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.btnNewest);
            this.Controls.Add(this.btnActiveAcc);
            this.Controls.Add(this.btnDemography);
            this.Controls.Add(this.btnBankAss);
            this.Controls.Add(this.dgwOverView);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdAllAccounts);
            this.Controls.Add(this.cmdNewAccount);
            this.Controls.Add(this.cmdFindClient);
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bank System";
            ((System.ComponentModel.ISupportInitialize)(this.dgwOverView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdFindClient;
        private System.Windows.Forms.Button cmdNewAccount;
        private System.Windows.Forms.Button cmdAllAccounts;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView dgwOverView;
        private System.Windows.Forms.Button btnBankAss;
        private System.Windows.Forms.Button btnDemography;
        private System.Windows.Forms.Button btnActiveAcc;
        private System.Windows.Forms.Button btnNewest;
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Label label1;
    }
}

