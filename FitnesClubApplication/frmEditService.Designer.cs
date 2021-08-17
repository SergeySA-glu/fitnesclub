namespace FitnesClubApplication
{
    partial class frmEditService
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
            this.lblCodeService = new System.Windows.Forms.Label();
            this.lblNameService = new System.Windows.Forms.Label();
            this.lblIdTrainerInService = new System.Windows.Forms.Label();
            this.nudCodeService = new System.Windows.Forms.NumericUpDown();
            this.nudCodeTranerInService = new System.Windows.Forms.NumericUpDown();
            this.txtNameService = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeTranerInService)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeService
            // 
            this.lblCodeService.AutoSize = true;
            this.lblCodeService.Location = new System.Drawing.Point(22, 22);
            this.lblCodeService.Name = "lblCodeService";
            this.lblCodeService.Size = new System.Drawing.Size(62, 13);
            this.lblCodeService.TabIndex = 0;
            this.lblCodeService.Text = "Код услуги";
            // 
            // lblNameService
            // 
            this.lblNameService.AutoSize = true;
            this.lblNameService.Location = new System.Drawing.Point(22, 49);
            this.lblNameService.Name = "lblNameService";
            this.lblNameService.Size = new System.Drawing.Size(83, 13);
            this.lblNameService.TabIndex = 1;
            this.lblNameService.Text = "Наименование";
            // 
            // lblIdTrainerInService
            // 
            this.lblIdTrainerInService.AutoSize = true;
            this.lblIdTrainerInService.Location = new System.Drawing.Point(22, 95);
            this.lblIdTrainerInService.Name = "lblIdTrainerInService";
            this.lblIdTrainerInService.Size = new System.Drawing.Size(70, 13);
            this.lblIdTrainerInService.TabIndex = 2;
            this.lblIdTrainerInService.Text = "Код тренера";
            // 
            // nudCodeService
            // 
            this.nudCodeService.Location = new System.Drawing.Point(128, 20);
            this.nudCodeService.Name = "nudCodeService";
            this.nudCodeService.Size = new System.Drawing.Size(280, 20);
            this.nudCodeService.TabIndex = 3;
            // 
            // nudCodeTranerInService
            // 
            this.nudCodeTranerInService.Location = new System.Drawing.Point(128, 93);
            this.nudCodeTranerInService.Name = "nudCodeTranerInService";
            this.nudCodeTranerInService.Size = new System.Drawing.Size(280, 20);
            this.nudCodeTranerInService.TabIndex = 4;
            // 
            // txtNameService
            // 
            this.txtNameService.Location = new System.Drawing.Point(128, 46);
            this.txtNameService.Multiline = true;
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Size = new System.Drawing.Size(280, 41);
            this.txtNameService.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(333, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmEditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNameService);
            this.Controls.Add(this.nudCodeTranerInService);
            this.Controls.Add(this.nudCodeService);
            this.Controls.Add(this.lblIdTrainerInService);
            this.Controls.Add(this.lblNameService);
            this.Controls.Add(this.lblCodeService);
            this.Name = "frmEditService";
            this.Text = "Услуга";
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeTranerInService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeService;
        private System.Windows.Forms.Label lblNameService;
        private System.Windows.Forms.Label lblIdTrainerInService;
        private System.Windows.Forms.NumericUpDown nudCodeService;
        private System.Windows.Forms.NumericUpDown nudCodeTranerInService;
        private System.Windows.Forms.TextBox txtNameService;
        private System.Windows.Forms.Button btnCancel;
    }
}