namespace TransformerBank
{
    partial class frmISLAM_ATM
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
            this.dgwCurrentBalance = new System.Windows.Forms.DataGridView();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.ntbAmount = new Controls.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCurrentBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCurrentBalance
            // 
            this.dgwCurrentBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCurrentBalance.Location = new System.Drawing.Point(28, 12);
            this.dgwCurrentBalance.Name = "dgwCurrentBalance";
            this.dgwCurrentBalance.ReadOnly = true;
            this.dgwCurrentBalance.RowHeadersVisible = false;
            this.dgwCurrentBalance.Size = new System.Drawing.Size(232, 52);
            this.dgwCurrentBalance.TabIndex = 0;
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(28, 144);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(232, 23);
            this.btnWithdrawal.TabIndex = 2;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // ntbAmount
            // 
            this.ntbAmount.Location = new System.Drawing.Point(28, 97);
            this.ntbAmount.Name = "ntbAmount";
            this.ntbAmount.Size = new System.Drawing.Size(232, 20);
            this.ntbAmount.TabIndex = 3;
            // 
            // frmISLAM_ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 210);
            this.Controls.Add(this.ntbAmount);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.dgwCurrentBalance);
            this.Name = "frmISLAM_ATM";
            this.Text = "ISLAM_ATM";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCurrentBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCurrentBalance;
        private System.Windows.Forms.Button btnWithdrawal;
        private Controls.NumericTextBox ntbAmount;
    }
}