namespace BankSystem
{
    partial class frmTransaction
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
            this.dgwSender = new System.Windows.Forms.DataGridView();
            this.dgwRecepient = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.txtVariable = new System.Windows.Forms.TextBox();
            this.txtSpecific = new System.Windows.Forms.TextBox();
            this.txtConst = new System.Windows.Forms.TextBox();
            this.lblVs = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            this.lblCs = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.lblMess = new System.Windows.Forms.Label();
            this.ntbAmount = new Controls.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecepient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSender
            // 
            this.dgwSender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSender.Location = new System.Drawing.Point(94, 12);
            this.dgwSender.Name = "dgwSender";
            this.dgwSender.Size = new System.Drawing.Size(833, 49);
            this.dgwSender.TabIndex = 8;
            // 
            // dgwRecepient
            // 
            this.dgwRecepient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRecepient.Location = new System.Drawing.Point(94, 67);
            this.dgwRecepient.Name = "dgwRecepient";
            this.dgwRecepient.Size = new System.Drawing.Size(833, 50);
            this.dgwRecepient.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Recepient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(96, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Amount";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(232, 231);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 23);
            this.btnDeposit.TabIndex = 14;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(232, 231);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(100, 23);
            this.btnWithdrawal.TabIndex = 15;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // txtVariable
            // 
            this.txtVariable.Location = new System.Drawing.Point(523, 154);
            this.txtVariable.Name = "txtVariable";
            this.txtVariable.Size = new System.Drawing.Size(116, 20);
            this.txtVariable.TabIndex = 16;
            // 
            // txtSpecific
            // 
            this.txtSpecific.Location = new System.Drawing.Point(666, 154);
            this.txtSpecific.Name = "txtSpecific";
            this.txtSpecific.Size = new System.Drawing.Size(114, 20);
            this.txtSpecific.TabIndex = 17;
            // 
            // txtConst
            // 
            this.txtConst.Location = new System.Drawing.Point(805, 154);
            this.txtConst.Name = "txtConst";
            this.txtConst.Size = new System.Drawing.Size(123, 20);
            this.txtConst.TabIndex = 18;
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVs.Location = new System.Drawing.Point(519, 131);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(120, 20);
            this.lblVs.TabIndex = 21;
            this.lblVs.Text = "Variable symbol";
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSS.Location = new System.Drawing.Point(662, 131);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(118, 20);
            this.lblSS.TabIndex = 22;
            this.lblSS.Text = "Specific symbol";
            // 
            // lblCs
            // 
            this.lblCs.AutoSize = true;
            this.lblCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCs.Location = new System.Drawing.Point(801, 131);
            this.lblCs.Name = "lblCs";
            this.lblCs.Size = new System.Drawing.Size(127, 20);
            this.lblCs.TabIndex = 23;
            this.lblCs.Text = "Constant symbol";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(94, 154);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(193, 20);
            this.txtIban.TabIndex = 24;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearch.Location = new System.Drawing.Point(90, 131);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(122, 20);
            this.lblSearch.TabIndex = 25;
            this.lblSearch.Text = "Search by IBAN";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(310, 154);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(232, 231);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(100, 23);
            this.btnTransaction.TabIndex = 27;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(523, 211);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(404, 44);
            this.txtMess.TabIndex = 28;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMess.Location = new System.Drawing.Point(519, 188);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(74, 20);
            this.lblMess.TabIndex = 29;
            this.lblMess.Text = "Message";
            // 
            // ntbAmount
            // 
            this.ntbAmount.Location = new System.Drawing.Point(94, 231);
            this.ntbAmount.Name = "ntbAmount";
            this.ntbAmount.Size = new System.Drawing.Size(100, 20);
            this.ntbAmount.TabIndex = 30;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 267);
            this.Controls.Add(this.ntbAmount);
            this.Controls.Add(this.lblMess);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.lblCs);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.txtConst);
            this.Controls.Add(this.txtSpecific);
            this.Controls.Add(this.txtVariable);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgwRecepient);
            this.Controls.Add(this.dgwSender);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.dgwSender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecepient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwSender;
        private System.Windows.Forms.DataGridView dgwRecepient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.TextBox txtVariable;
        private System.Windows.Forms.TextBox txtSpecific;
        private System.Windows.Forms.TextBox txtConst;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label lblCs;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Label lblMess;
        private Controls.NumericTextBox ntbAmount;
    }
}