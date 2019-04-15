namespace BankSystem
{
    partial class frmClientManagement
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
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdNewTransaction = new System.Windows.Forms.Button();
            this.cmdCloseAccount = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.cmdWithdrawal = new System.Windows.Forms.Button();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.dgwClientInfo = new System.Windows.Forms.DataGridView();
            this.dgwCardInfo = new System.Windows.Forms.DataGridView();
            this.btnNewCard = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnUnblock = new System.Windows.Forms.Button();
            this.btnDebit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCardInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(12, 129);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(112, 23);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Update info";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdNewTransaction
            // 
            this.cmdNewTransaction.Location = new System.Drawing.Point(170, 189);
            this.cmdNewTransaction.Name = "cmdNewTransaction";
            this.cmdNewTransaction.Size = new System.Drawing.Size(112, 23);
            this.cmdNewTransaction.TabIndex = 5;
            this.cmdNewTransaction.Text = "New transaction";
            this.cmdNewTransaction.UseVisualStyleBackColor = true;
            this.cmdNewTransaction.Click += new System.EventHandler(this.cmdNewTransaction_Click);
            // 
            // cmdCloseAccount
            // 
            this.cmdCloseAccount.Location = new System.Drawing.Point(170, 256);
            this.cmdCloseAccount.Name = "cmdCloseAccount";
            this.cmdCloseAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdCloseAccount.TabIndex = 6;
            this.cmdCloseAccount.Text = "Close account";
            this.cmdCloseAccount.UseVisualStyleBackColor = true;
            this.cmdCloseAccount.Click += new System.EventHandler(this.cmdCloseAccount_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(170, 129);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 8;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // cmdWithdrawal
            // 
            this.cmdWithdrawal.Location = new System.Drawing.Point(12, 256);
            this.cmdWithdrawal.Name = "cmdWithdrawal";
            this.cmdWithdrawal.Size = new System.Drawing.Size(112, 23);
            this.cmdWithdrawal.TabIndex = 9;
            this.cmdWithdrawal.Text = "Withdrawal";
            this.cmdWithdrawal.UseVisualStyleBackColor = true;
            this.cmdWithdrawal.Click += new System.EventHandler(this.cmdWithdrawal_Click);
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.Location = new System.Drawing.Point(12, 189);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(112, 23);
            this.cmdDeposit.TabIndex = 10;
            this.cmdDeposit.Text = "Deposit";
            this.cmdDeposit.UseVisualStyleBackColor = true;
            this.cmdDeposit.Click += new System.EventHandler(this.cmdDeposit_Click);
            // 
            // dgwClientInfo
            // 
            this.dgwClientInfo.AllowUserToAddRows = false;
            this.dgwClientInfo.AllowUserToDeleteRows = false;
            this.dgwClientInfo.AllowUserToResizeColumns = false;
            this.dgwClientInfo.AllowUserToResizeRows = false;
            this.dgwClientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClientInfo.Enabled = false;
            this.dgwClientInfo.Location = new System.Drawing.Point(12, 12);
            this.dgwClientInfo.Name = "dgwClientInfo";
            this.dgwClientInfo.RowHeadersVisible = false;
            this.dgwClientInfo.Size = new System.Drawing.Size(610, 68);
            this.dgwClientInfo.TabIndex = 19;
            // 
            // dgwCardInfo
            // 
            this.dgwCardInfo.AllowUserToAddRows = false;
            this.dgwCardInfo.AllowUserToDeleteRows = false;
            this.dgwCardInfo.AllowUserToResizeColumns = false;
            this.dgwCardInfo.AllowUserToResizeRows = false;
            this.dgwCardInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwCardInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCardInfo.Location = new System.Drawing.Point(370, 129);
            this.dgwCardInfo.MultiSelect = false;
            this.dgwCardInfo.Name = "dgwCardInfo";
            this.dgwCardInfo.ReadOnly = true;
            this.dgwCardInfo.RowHeadersVisible = false;
            this.dgwCardInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCardInfo.Size = new System.Drawing.Size(252, 150);
            this.dgwCardInfo.TabIndex = 20;
            // 
            // btnNewCard
            // 
            this.btnNewCard.Location = new System.Drawing.Point(370, 311);
            this.btnNewCard.Name = "btnNewCard";
            this.btnNewCard.Size = new System.Drawing.Size(75, 23);
            this.btnNewCard.TabIndex = 21;
            this.btnNewCard.Text = "New Card";
            this.btnNewCard.UseVisualStyleBackColor = true;
            this.btnNewCard.Click += new System.EventHandler(this.btnNewCard_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(468, 311);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(72, 23);
            this.btnBlock.TabIndex = 22;
            this.btnBlock.Text = "Block ";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnUnblock
            // 
            this.btnUnblock.Location = new System.Drawing.Point(546, 311);
            this.btnUnblock.Name = "btnUnblock";
            this.btnUnblock.Size = new System.Drawing.Size(76, 23);
            this.btnUnblock.TabIndex = 23;
            this.btnUnblock.Text = "Unblock ";
            this.btnUnblock.UseVisualStyleBackColor = true;
            this.btnUnblock.Click += new System.EventHandler(this.btnUnblock_Click);
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(12, 311);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(112, 23);
            this.btnDebit.TabIndex = 24;
            this.btnDebit.Text = "Edit Debit";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // frmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 410);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.btnUnblock);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnNewCard);
            this.Controls.Add(this.dgwCardInfo);
            this.Controls.Add(this.dgwClientInfo);
            this.Controls.Add(this.cmdDeposit);
            this.Controls.Add(this.cmdWithdrawal);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdCloseAccount);
            this.Controls.Add(this.cmdNewTransaction);
            this.Controls.Add(this.cmdUpdate);
            this.Name = "frmClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmClientManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCardInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdNewTransaction;
        private System.Windows.Forms.Button cmdCloseAccount;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.Button cmdWithdrawal;
        private System.Windows.Forms.Button cmdDeposit;
        private System.Windows.Forms.DataGridView dgwClientInfo;
        private System.Windows.Forms.DataGridView dgwCardInfo;
        private System.Windows.Forms.Button btnNewCard;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnUnblock;
        private System.Windows.Forms.Button btnDebit;
    }
}