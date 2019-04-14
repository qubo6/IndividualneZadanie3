namespace BankSystem
{
    partial class frmNew_Card
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
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnSaveCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(110, 13);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 0;
            // 
            // btnSaveCard
            // 
            this.btnSaveCard.Location = new System.Drawing.Point(110, 40);
            this.btnSaveCard.Name = "btnSaveCard";
            this.btnSaveCard.Size = new System.Drawing.Size(100, 23);
            this.btnSaveCard.TabIndex = 1;
            this.btnSaveCard.Text = "Save";
            this.btnSaveCard.UseVisualStyleBackColor = true;
            this.btnSaveCard.Click += new System.EventHandler(this.btnSaveCard_Click);
            // 
            // frmNew_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 109);
            this.Controls.Add(this.btnSaveCard);
            this.Controls.Add(this.txtPin);
            this.Name = "frmNew_Card";
            this.Text = "New_Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnSaveCard;
    }
}