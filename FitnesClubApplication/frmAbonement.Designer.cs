namespace FitnesClubApplication
{
    partial class frmAbonement
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
            this.lstAbonement = new System.Windows.Forms.ListBox();
            this.btnEditAbonement = new System.Windows.Forms.Button();
            this.lstAbonementService = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstAbonement
            // 
            this.lstAbonement.FormattingEnabled = true;
            this.lstAbonement.Location = new System.Drawing.Point(13, 13);
            this.lstAbonement.Name = "lstAbonement";
            this.lstAbonement.Size = new System.Drawing.Size(326, 251);
            this.lstAbonement.TabIndex = 0;
            this.lstAbonement.SelectedIndexChanged += new System.EventHandler(this.lstAbonement_SelectedIndexChanged);
            // 
            // btnEditAbonement
            // 
            this.btnEditAbonement.Location = new System.Drawing.Point(13, 270);
            this.btnEditAbonement.Name = "btnEditAbonement";
            this.btnEditAbonement.Size = new System.Drawing.Size(75, 23);
            this.btnEditAbonement.TabIndex = 2;
            this.btnEditAbonement.Text = "Просмотр";
            this.btnEditAbonement.UseVisualStyleBackColor = true;
            this.btnEditAbonement.Click += new System.EventHandler(this.btnEditAbonement_Click);
            // 
            // lstAbonementService
            // 
            this.lstAbonementService.FormattingEnabled = true;
            this.lstAbonementService.Location = new System.Drawing.Point(346, 13);
            this.lstAbonementService.Name = "lstAbonementService";
            this.lstAbonementService.Size = new System.Drawing.Size(312, 251);
            this.lstAbonementService.TabIndex = 3;
            this.lstAbonementService.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAbonementService_MouseDoubleClick);
            // 
            // frmAbonement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 320);
            this.Controls.Add(this.lstAbonementService);
            this.Controls.Add(this.btnEditAbonement);
            this.Controls.Add(this.lstAbonement);
            this.Name = "frmAbonement";
            this.Text = "Абонемент";
            this.Load += new System.EventHandler(this.frmAbonement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAbonement;
        private System.Windows.Forms.Button btnEditAbonement;
        private System.Windows.Forms.ListBox lstAbonementService;
    }
}