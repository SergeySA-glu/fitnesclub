namespace FitnesClubApplication
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClients = new System.Windows.Forms.Button();
            this.btnAbonement = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnTrainers = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(12, 12);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(126, 68);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnAbonement
            // 
            this.btnAbonement.Location = new System.Drawing.Point(144, 12);
            this.btnAbonement.Name = "btnAbonement";
            this.btnAbonement.Size = new System.Drawing.Size(135, 68);
            this.btnAbonement.TabIndex = 1;
            this.btnAbonement.Text = "Абонемент";
            this.btnAbonement.UseVisualStyleBackColor = true;
            this.btnAbonement.Click += new System.EventHandler(this.btnAbonement_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(12, 86);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(126, 69);
            this.btnService.TabIndex = 2;
            this.btnService.Text = "Услуги";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnTrainers
            // 
            this.btnTrainers.Location = new System.Drawing.Point(144, 86);
            this.btnTrainers.Name = "btnTrainers";
            this.btnTrainers.Size = new System.Drawing.Size(135, 69);
            this.btnTrainers.TabIndex = 3;
            this.btnTrainers.Text = "Тренеры";
            this.btnTrainers.UseVisualStyleBackColor = true;
            this.btnTrainers.Click += new System.EventHandler(this.btnTrainers_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(12, 162);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(266, 36);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Продажи";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 210);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnTrainers);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnAbonement);
            this.Controls.Add(this.btnClients);
            this.Name = "Form1";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAbonement;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnTrainers;
        private System.Windows.Forms.Button btnSales;
    }
}

