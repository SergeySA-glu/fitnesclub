namespace FitnesClubApplication
{
    partial class frmSales
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
            this.lstSales = new System.Windows.Forms.ListBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnEditSale = new System.Windows.Forms.Button();
            this.lstSaleData = new System.Windows.Forms.ListBox();
            this.btnRemoveSale = new System.Windows.Forms.Button();
            this.btnGain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSales
            // 
            this.lstSales.FormattingEnabled = true;
            this.lstSales.Location = new System.Drawing.Point(13, 13);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(326, 251);
            this.lstSales.TabIndex = 0;
            this.lstSales.SelectedIndexChanged += new System.EventHandler(this.lstSales_SelectedIndexChanged);
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(13, 271);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(75, 23);
            this.btnAddSale.TabIndex = 1;
            this.btnAddSale.Text = "Добавить";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnEditSale
            // 
            this.btnEditSale.Location = new System.Drawing.Point(95, 271);
            this.btnEditSale.Name = "btnEditSale";
            this.btnEditSale.Size = new System.Drawing.Size(75, 23);
            this.btnEditSale.TabIndex = 2;
            this.btnEditSale.Text = "Просмотр";
            this.btnEditSale.UseVisualStyleBackColor = true;
            this.btnEditSale.Click += new System.EventHandler(this.btnEditSale_Click);
            // 
            // lstSaleData
            // 
            this.lstSaleData.FormattingEnabled = true;
            this.lstSaleData.Location = new System.Drawing.Point(346, 13);
            this.lstSaleData.Name = "lstSaleData";
            this.lstSaleData.Size = new System.Drawing.Size(336, 251);
            this.lstSaleData.TabIndex = 3;
            this.lstSaleData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSaleData_MouseDoubleClick);
            // 
            // btnRemoveSale
            // 
            this.btnRemoveSale.Location = new System.Drawing.Point(177, 271);
            this.btnRemoveSale.Name = "btnRemoveSale";
            this.btnRemoveSale.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSale.TabIndex = 4;
            this.btnRemoveSale.Text = "Удалить";
            this.btnRemoveSale.UseVisualStyleBackColor = true;
            this.btnRemoveSale.Click += new System.EventHandler(this.btnRemoveSale_Click);
            // 
            // btnGain
            // 
            this.btnGain.Location = new System.Drawing.Point(573, 270);
            this.btnGain.Name = "btnGain";
            this.btnGain.Size = new System.Drawing.Size(108, 23);
            this.btnGain.TabIndex = 5;
            this.btnGain.Text = "Выручка";
            this.btnGain.UseVisualStyleBackColor = true;
            this.btnGain.Click += new System.EventHandler(this.btnGain_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 320);
            this.Controls.Add(this.btnGain);
            this.Controls.Add(this.btnRemoveSale);
            this.Controls.Add(this.lstSaleData);
            this.Controls.Add(this.btnEditSale);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.lstSales);
            this.Name = "frmSales";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSales;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnEditSale;
        private System.Windows.Forms.ListBox lstSaleData;
        private System.Windows.Forms.Button btnRemoveSale;
        private System.Windows.Forms.Button btnGain;
    }
}