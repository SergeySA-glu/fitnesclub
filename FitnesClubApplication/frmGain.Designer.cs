namespace FitnesClubApplication
{
    partial class frmGain
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
            this.dtpMinSaleDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMaxSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lblMinSaleDate = new System.Windows.Forms.Label();
            this.lblMaxSaleDate = new System.Windows.Forms.Label();
            this.txtSumGain = new System.Windows.Forms.TextBox();
            this.btnSumGain = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpMinSaleDate
            // 
            this.dtpMinSaleDate.Location = new System.Drawing.Point(128, 20);
            this.dtpMinSaleDate.Name = "dtpMinSaleDate";
            this.dtpMinSaleDate.Size = new System.Drawing.Size(131, 20);
            this.dtpMinSaleDate.TabIndex = 0;
            this.dtpMinSaleDate.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dtpMaxSaleDate
            // 
            this.dtpMaxSaleDate.Location = new System.Drawing.Point(128, 66);
            this.dtpMaxSaleDate.Name = "dtpMaxSaleDate";
            this.dtpMaxSaleDate.Size = new System.Drawing.Size(131, 20);
            this.dtpMaxSaleDate.TabIndex = 1;
            // 
            // lblMinSaleDate
            // 
            this.lblMinSaleDate.AutoSize = true;
            this.lblMinSaleDate.Location = new System.Drawing.Point(97, 20);
            this.lblMinSaleDate.Name = "lblMinSaleDate";
            this.lblMinSaleDate.Size = new System.Drawing.Size(23, 13);
            this.lblMinSaleDate.TabIndex = 2;
            this.lblMinSaleDate.Text = "От:";
            // 
            // lblMaxSaleDate
            // 
            this.lblMaxSaleDate.AutoSize = true;
            this.lblMaxSaleDate.Location = new System.Drawing.Point(97, 66);
            this.lblMaxSaleDate.Name = "lblMaxSaleDate";
            this.lblMaxSaleDate.Size = new System.Drawing.Size(25, 13);
            this.lblMaxSaleDate.TabIndex = 3;
            this.lblMaxSaleDate.Text = "До:";
            // 
            // txtSumGain
            // 
            this.txtSumGain.Location = new System.Drawing.Point(12, 105);
            this.txtSumGain.Name = "txtSumGain";
            this.txtSumGain.Size = new System.Drawing.Size(247, 20);
            this.txtSumGain.TabIndex = 4;
            // 
            // btnSumGain
            // 
            this.btnSumGain.Location = new System.Drawing.Point(12, 143);
            this.btnSumGain.Name = "btnSumGain";
            this.btnSumGain.Size = new System.Drawing.Size(247, 34);
            this.btnSumGain.TabIndex = 5;
            this.btnSumGain.Text = "Рассчитать";
            this.btnSumGain.UseVisualStyleBackColor = true;
            this.btnSumGain.Click += new System.EventHandler(this.btnSumGain_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(13, 20);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(78, 66);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Создать файл на диске C";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmGain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 189);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSumGain);
            this.Controls.Add(this.txtSumGain);
            this.Controls.Add(this.lblMaxSaleDate);
            this.Controls.Add(this.lblMinSaleDate);
            this.Controls.Add(this.dtpMaxSaleDate);
            this.Controls.Add(this.dtpMinSaleDate);
            this.Name = "frmGain";
            this.Text = "Выручка";
            this.Load += new System.EventHandler(this.frmGain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMinSaleDate;
        private System.Windows.Forms.DateTimePicker dtpMaxSaleDate;
        private System.Windows.Forms.Label lblMinSaleDate;
        private System.Windows.Forms.Label lblMaxSaleDate;
        private System.Windows.Forms.TextBox txtSumGain;
        private System.Windows.Forms.Button btnSumGain;
        private System.Windows.Forms.Button btnReport;
    }
}