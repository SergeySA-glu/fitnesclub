namespace FitnesClubApplication
{
    partial class frmServices
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
            this.lstServices = new System.Windows.Forms.ListBox();
            this.btnEditService = new System.Windows.Forms.Button();
            this.lstTrainerService = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.Location = new System.Drawing.Point(13, 13);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(326, 251);
            this.lstServices.TabIndex = 0;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged);
            // 
            // btnEditService
            // 
            this.btnEditService.Location = new System.Drawing.Point(13, 270);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(75, 23);
            this.btnEditService.TabIndex = 2;
            this.btnEditService.Text = "Просмотр";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // lstTrainerService
            // 
            this.lstTrainerService.FormattingEnabled = true;
            this.lstTrainerService.Location = new System.Drawing.Point(346, 13);
            this.lstTrainerService.Name = "lstTrainerService";
            this.lstTrainerService.Size = new System.Drawing.Size(336, 251);
            this.lstTrainerService.TabIndex = 3;
            this.lstTrainerService.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTrainerService_MouseDoubleClick);
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 320);
            this.Controls.Add(this.lstTrainerService);
            this.Controls.Add(this.btnEditService);
            this.Controls.Add(this.lstServices);
            this.Name = "frmServices";
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.frmServices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.ListBox lstTrainerService;
    }
}