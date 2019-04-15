namespace TransformerBank
{
    partial class frmLogin
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
            this.txtCardId = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCardId
            // 
            this.txtCardId.Location = new System.Drawing.Point(88, 49);
            this.txtCardId.Name = "txtCardId";
            this.txtCardId.Size = new System.Drawing.Size(100, 20);
            this.txtCardId.TabIndex = 0;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(88, 95);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 1;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(218, 49);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 169);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtCardId);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardId;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnLog;
    }
}