namespace BankSystem
{
    partial class frmDebit
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
            this.ntbDebit = new Controls.NumericTextBox();
            this.btnSaveDebit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ntbDebit
            // 
            this.ntbDebit.Location = new System.Drawing.Point(33, 27);
            this.ntbDebit.Name = "ntbDebit";
            this.ntbDebit.Size = new System.Drawing.Size(100, 20);
            this.ntbDebit.TabIndex = 0;
            // 
            // btnSaveDebit
            // 
            this.btnSaveDebit.Location = new System.Drawing.Point(172, 27);
            this.btnSaveDebit.Name = "btnSaveDebit";
            this.btnSaveDebit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDebit.TabIndex = 1;
            this.btnSaveDebit.Text = "Save";
            this.btnSaveDebit.UseVisualStyleBackColor = true;
            this.btnSaveDebit.Click += new System.EventHandler(this.btnSaveDebit_Click);
            // 
            // frmDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 77);
            this.Controls.Add(this.btnSaveDebit);
            this.Controls.Add(this.ntbDebit);
            this.Name = "frmDebit";
            this.Text = "Debit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.NumericTextBox ntbDebit;
        private System.Windows.Forms.Button btnSaveDebit;
    }
}