namespace BankSystem
{
    partial class frmAccounts
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
            this.cmdManageAccount = new System.Windows.Forms.Button();
            this.dgwAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAll)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdManageAccount
            // 
            this.cmdManageAccount.Location = new System.Drawing.Point(341, 291);
            this.cmdManageAccount.Name = "cmdManageAccount";
            this.cmdManageAccount.Size = new System.Drawing.Size(75, 37);
            this.cmdManageAccount.TabIndex = 10;
            this.cmdManageAccount.Text = "Manage account";
            this.cmdManageAccount.UseVisualStyleBackColor = true;
            this.cmdManageAccount.Click += new System.EventHandler(this.cmdManageAccount_Click);
            // 
            // dgwAll
            // 
            this.dgwAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAll.Location = new System.Drawing.Point(12, 12);
            this.dgwAll.Name = "dgwAll";
            this.dgwAll.ReadOnly = true;
            this.dgwAll.RowHeadersVisible = false;
            this.dgwAll.Size = new System.Drawing.Size(739, 273);
            this.dgwAll.TabIndex = 12;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 352);
            this.Controls.Add(this.dgwAll);
            this.Controls.Add(this.cmdManageAccount);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdManageAccount;
        private System.Windows.Forms.DataGridView dgwAll;
    }
}