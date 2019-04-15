namespace BankSystem
{
    partial class frmTransactions
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
            this.dgwAllTransaction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAllTransaction
            // 
            this.dgwAllTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAllTransaction.Location = new System.Drawing.Point(13, 13);
            this.dgwAllTransaction.Name = "dgwAllTransaction";
            this.dgwAllTransaction.ReadOnly = true;
            this.dgwAllTransaction.RowHeadersVisible = false;
            this.dgwAllTransaction.Size = new System.Drawing.Size(559, 265);
            this.dgwAllTransaction.TabIndex = 4;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dgwAllTransaction);
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransactions";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwAllTransaction;
    }
}