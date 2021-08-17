namespace FitnesClubApplication
{
    partial class frmEditAbonement
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
            this.lblCodeAbonement = new System.Windows.Forms.Label();
            this.lblNameAbonement = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblIdServiceInAbonement = new System.Windows.Forms.Label();
            this.nudCodeAbonement = new System.Windows.Forms.NumericUpDown();
            this.txtNameAbonement = new System.Windows.Forms.TextBox();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.nudIdServiceInAbonement = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeAbonement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdServiceInAbonement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeAbonement
            // 
            this.lblCodeAbonement.AutoSize = true;
            this.lblCodeAbonement.Location = new System.Drawing.Point(22, 22);
            this.lblCodeAbonement.Name = "lblCodeAbonement";
            this.lblCodeAbonement.Size = new System.Drawing.Size(90, 13);
            this.lblCodeAbonement.TabIndex = 0;
            this.lblCodeAbonement.Text = "Код абонемента";
            // 
            // lblNameAbonement
            // 
            this.lblNameAbonement.AutoSize = true;
            this.lblNameAbonement.Location = new System.Drawing.Point(22, 49);
            this.lblNameAbonement.Name = "lblNameAbonement";
            this.lblNameAbonement.Size = new System.Drawing.Size(83, 13);
            this.lblNameAbonement.TabIndex = 1;
            this.lblNameAbonement.Text = "Наименование";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(22, 98);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(80, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Длительность";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(22, 125);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Цена";
            // 
            // lblIdServiceInAbonement
            // 
            this.lblIdServiceInAbonement.AutoSize = true;
            this.lblIdServiceInAbonement.Location = new System.Drawing.Point(22, 150);
            this.lblIdServiceInAbonement.Name = "lblIdServiceInAbonement";
            this.lblIdServiceInAbonement.Size = new System.Drawing.Size(62, 13);
            this.lblIdServiceInAbonement.TabIndex = 4;
            this.lblIdServiceInAbonement.Text = "Код услуги";
            // 
            // nudCodeAbonement
            // 
            this.nudCodeAbonement.Location = new System.Drawing.Point(128, 20);
            this.nudCodeAbonement.Name = "nudCodeAbonement";
            this.nudCodeAbonement.Size = new System.Drawing.Size(120, 20);
            this.nudCodeAbonement.TabIndex = 5;
            // 
            // txtNameAbonement
            // 
            this.txtNameAbonement.Location = new System.Drawing.Point(128, 46);
            this.txtNameAbonement.Multiline = true;
            this.txtNameAbonement.Name = "txtNameAbonement";
            this.txtNameAbonement.Size = new System.Drawing.Size(227, 44);
            this.txtNameAbonement.TabIndex = 6;
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(128, 96);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(120, 20);
            this.nudDuration.TabIndex = 7;
            // 
            // nudIdServiceInAbonement
            // 
            this.nudIdServiceInAbonement.Location = new System.Drawing.Point(128, 148);
            this.nudIdServiceInAbonement.Name = "nudIdServiceInAbonement";
            this.nudIdServiceInAbonement.Size = new System.Drawing.Size(120, 20);
            this.nudIdServiceInAbonement.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 122);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(333, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmEditAbonement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.nudIdServiceInAbonement);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.txtNameAbonement);
            this.Controls.Add(this.nudCodeAbonement);
            this.Controls.Add(this.lblIdServiceInAbonement);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblNameAbonement);
            this.Controls.Add(this.lblCodeAbonement);
            this.Name = "frmEditAbonement";
            this.Text = "frmEditAbonement";
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeAbonement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdServiceInAbonement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeAbonement;
        private System.Windows.Forms.Label lblNameAbonement;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblIdServiceInAbonement;
        private System.Windows.Forms.NumericUpDown nudCodeAbonement;
        private System.Windows.Forms.TextBox txtNameAbonement;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.NumericUpDown nudIdServiceInAbonement;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCancel;
    }
}