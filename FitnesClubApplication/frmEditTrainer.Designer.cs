namespace FitnesClubApplication
{
    partial class frmEditTrainer
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
            this.lblCodeTrainer = new System.Windows.Forms.Label();
            this.lblNameTrainer = new System.Windows.Forms.Label();
            this.lblPhoneTrainer = new System.Windows.Forms.Label();
            this.lblAddressTrainer = new System.Windows.Forms.Label();
            this.lblSalaryTrainer = new System.Windows.Forms.Label();
            this.nudCodeTrainer = new System.Windows.Forms.NumericUpDown();
            this.txtNameTrainer = new System.Windows.Forms.TextBox();
            this.txtPhoneTrainer = new System.Windows.Forms.TextBox();
            this.txtAddressTrainer = new System.Windows.Forms.TextBox();
            this.txtSalaryTrainer = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeTrainer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeTrainer
            // 
            this.lblCodeTrainer.AutoSize = true;
            this.lblCodeTrainer.Location = new System.Drawing.Point(22, 22);
            this.lblCodeTrainer.Name = "lblCodeTrainer";
            this.lblCodeTrainer.Size = new System.Drawing.Size(70, 13);
            this.lblCodeTrainer.TabIndex = 0;
            this.lblCodeTrainer.Text = "Код тренера";
            // 
            // lblNameTrainer
            // 
            this.lblNameTrainer.AutoSize = true;
            this.lblNameTrainer.Location = new System.Drawing.Point(22, 48);
            this.lblNameTrainer.Name = "lblNameTrainer";
            this.lblNameTrainer.Size = new System.Drawing.Size(34, 13);
            this.lblNameTrainer.TabIndex = 1;
            this.lblNameTrainer.Text = "ФИО";
            // 
            // lblPhoneTrainer
            // 
            this.lblPhoneTrainer.AutoSize = true;
            this.lblPhoneTrainer.Location = new System.Drawing.Point(22, 94);
            this.lblPhoneTrainer.Name = "lblPhoneTrainer";
            this.lblPhoneTrainer.Size = new System.Drawing.Size(52, 13);
            this.lblPhoneTrainer.TabIndex = 2;
            this.lblPhoneTrainer.Text = "Телефон";
            // 
            // lblAddressTrainer
            // 
            this.lblAddressTrainer.AutoSize = true;
            this.lblAddressTrainer.Location = new System.Drawing.Point(22, 120);
            this.lblAddressTrainer.Name = "lblAddressTrainer";
            this.lblAddressTrainer.Size = new System.Drawing.Size(38, 13);
            this.lblAddressTrainer.TabIndex = 3;
            this.lblAddressTrainer.Text = "Адрес";
            // 
            // lblSalaryTrainer
            // 
            this.lblSalaryTrainer.AutoSize = true;
            this.lblSalaryTrainer.Location = new System.Drawing.Point(22, 165);
            this.lblSalaryTrainer.Name = "lblSalaryTrainer";
            this.lblSalaryTrainer.Size = new System.Drawing.Size(55, 13);
            this.lblSalaryTrainer.TabIndex = 4;
            this.lblSalaryTrainer.Text = "Зарплата";
            // 
            // nudCodeTrainer
            // 
            this.nudCodeTrainer.Location = new System.Drawing.Point(128, 20);
            this.nudCodeTrainer.Name = "nudCodeTrainer";
            this.nudCodeTrainer.Size = new System.Drawing.Size(280, 20);
            this.nudCodeTrainer.TabIndex = 5;
            // 
            // txtNameTrainer
            // 
            this.txtNameTrainer.Location = new System.Drawing.Point(128, 45);
            this.txtNameTrainer.Multiline = true;
            this.txtNameTrainer.Name = "txtNameTrainer";
            this.txtNameTrainer.Size = new System.Drawing.Size(280, 40);
            this.txtNameTrainer.TabIndex = 6;
            // 
            // txtPhoneTrainer
            // 
            this.txtPhoneTrainer.Location = new System.Drawing.Point(128, 91);
            this.txtPhoneTrainer.Name = "txtPhoneTrainer";
            this.txtPhoneTrainer.Size = new System.Drawing.Size(280, 20);
            this.txtPhoneTrainer.TabIndex = 7;
            // 
            // txtAddressTrainer
            // 
            this.txtAddressTrainer.Location = new System.Drawing.Point(128, 117);
            this.txtAddressTrainer.Multiline = true;
            this.txtAddressTrainer.Name = "txtAddressTrainer";
            this.txtAddressTrainer.Size = new System.Drawing.Size(280, 39);
            this.txtAddressTrainer.TabIndex = 8;
            // 
            // txtSalaryTrainer
            // 
            this.txtSalaryTrainer.Location = new System.Drawing.Point(128, 162);
            this.txtSalaryTrainer.Name = "txtSalaryTrainer";
            this.txtSalaryTrainer.Size = new System.Drawing.Size(280, 20);
            this.txtSalaryTrainer.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(332, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmEditTraner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSalaryTrainer);
            this.Controls.Add(this.txtAddressTrainer);
            this.Controls.Add(this.txtPhoneTrainer);
            this.Controls.Add(this.txtNameTrainer);
            this.Controls.Add(this.nudCodeTrainer);
            this.Controls.Add(this.lblSalaryTrainer);
            this.Controls.Add(this.lblAddressTrainer);
            this.Controls.Add(this.lblPhoneTrainer);
            this.Controls.Add(this.lblNameTrainer);
            this.Controls.Add(this.lblCodeTrainer);
            this.Name = "frmEditTraner";
            this.Text = "Тренер";
            ((System.ComponentModel.ISupportInitialize)(this.nudCodeTrainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeTrainer;
        private System.Windows.Forms.Label lblNameTrainer;
        private System.Windows.Forms.Label lblPhoneTrainer;
        private System.Windows.Forms.Label lblAddressTrainer;
        private System.Windows.Forms.Label lblSalaryTrainer;
        private System.Windows.Forms.NumericUpDown nudCodeTrainer;
        private System.Windows.Forms.TextBox txtNameTrainer;
        private System.Windows.Forms.TextBox txtPhoneTrainer;
        private System.Windows.Forms.TextBox txtAddressTrainer;
        private System.Windows.Forms.TextBox txtSalaryTrainer;
        private System.Windows.Forms.Button btnCancel;
    }
}