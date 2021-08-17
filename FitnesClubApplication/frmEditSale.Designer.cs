namespace FitnesClubApplication
{
    partial class frmEditSale
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
            this.nudCodeSale = new System.Windows.Forms.NumericUpDown();
            this.lblCodeSale = new System.Windows.Forms.Label();
            this.lblDateSale = new System.Windows.Forms.Label();
            this.lblIdAbonementInSales = new System.Windows.Forms.Label();
            this.lblIdClientInSales = new System.Windows.Forms.Label();
            this.nudIdAbonementInSales = new System.Windows.Forms.NumericUpDown();
            this.nudIdClientInSales = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdAbonementInSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdClientInSales)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCodeSale
            // 
            this.nudCodeSale.Location = new System.Drawing.Point(128, 20);
            this.nudCodeSale.Name = "nudCodeSale";
            this.nudCodeSale.Size = new System.Drawing.Size(131, 20);
            this.nudCodeSale.TabIndex = 0;
            // 
            // lblCodeSale
            // 
            this.lblCodeSale.AutoSize = true;
            this.lblCodeSale.Location = new System.Drawing.Point(22, 22);
            this.lblCodeSale.Name = "lblCodeSale";
            this.lblCodeSale.Size = new System.Drawing.Size(73, 13);
            this.lblCodeSale.TabIndex = 1;
            this.lblCodeSale.Text = "Код продажи";
            // 
            // lblDateSale
            // 
            this.lblDateSale.AutoSize = true;
            this.lblDateSale.Location = new System.Drawing.Point(22, 53);
            this.lblDateSale.Name = "lblDateSale";
            this.lblDateSale.Size = new System.Drawing.Size(80, 13);
            this.lblDateSale.TabIndex = 2;
            this.lblDateSale.Text = "Дата продажи";
            // 
            // lblIdAbonementInSales
            // 
            this.lblIdAbonementInSales.AutoSize = true;
            this.lblIdAbonementInSales.Location = new System.Drawing.Point(22, 74);
            this.lblIdAbonementInSales.Name = "lblIdAbonementInSales";
            this.lblIdAbonementInSales.Size = new System.Drawing.Size(63, 13);
            this.lblIdAbonementInSales.TabIndex = 3;
            this.lblIdAbonementInSales.Text = "Абонемент";
            // 
            // lblIdClientInSales
            // 
            this.lblIdClientInSales.AutoSize = true;
            this.lblIdClientInSales.Location = new System.Drawing.Point(22, 100);
            this.lblIdClientInSales.Name = "lblIdClientInSales";
            this.lblIdClientInSales.Size = new System.Drawing.Size(43, 13);
            this.lblIdClientInSales.TabIndex = 4;
            this.lblIdClientInSales.Text = "Клиент";
            // 
            // nudIdAbonementInSales
            // 
            this.nudIdAbonementInSales.Location = new System.Drawing.Point(128, 72);
            this.nudIdAbonementInSales.Name = "nudIdAbonementInSales";
            this.nudIdAbonementInSales.Size = new System.Drawing.Size(131, 20);
            this.nudIdAbonementInSales.TabIndex = 6;
            // 
            // nudIdClientInSales
            // 
            this.nudIdClientInSales.Location = new System.Drawing.Point(128, 98);
            this.nudIdClientInSales.Name = "nudIdClientInSales";
            this.nudIdClientInSales.Size = new System.Drawing.Size(131, 20);
            this.nudIdClientInSales.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(184, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(103, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Location = new System.Drawing.Point(128, 47);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(131, 20);
            this.dtpSaleDate.TabIndex = 10;
            // 
            // frmEditSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 189);
            this.Controls.Add(this.dtpSaleDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudIdClientInSales);
            this.Controls.Add(this.nudIdAbonementInSales);
            this.Controls.Add(this.lblIdClientInSales);
            this.Controls.Add(this.lblIdAbonementInSales);
            this.Controls.Add(this.lblDateSale);
            this.Controls.Add(this.lblCodeSale);
            this.Controls.Add(this.nudCodeSale);
            this.Name = "frmEditSale";
            this.Text = "Продажа";
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdAbonementInSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdClientInSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCodeSale;
        private System.Windows.Forms.Label lblDateSale;
        private System.Windows.Forms.Label lblIdAbonementInSales;
        private System.Windows.Forms.Label lblIdClientInSales;
        private System.Windows.Forms.NumericUpDown nudIdAbonementInSales;
        private System.Windows.Forms.NumericUpDown nudIdClientInSales;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Label lblCodeSale;
    }
}