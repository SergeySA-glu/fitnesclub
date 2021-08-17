namespace FitnesClubApplication
{
    partial class frmTrainers
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
            this.lstTrainers = new System.Windows.Forms.ListBox();
            this.btnEditTrainer = new System.Windows.Forms.Button();
            this.lstTrainers2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTrainers
            // 
            this.lstTrainers.FormattingEnabled = true;
            this.lstTrainers.Location = new System.Drawing.Point(13, 13);
            this.lstTrainers.Name = "lstTrainers";
            this.lstTrainers.Size = new System.Drawing.Size(326, 251);
            this.lstTrainers.TabIndex = 0;
            this.lstTrainers.SelectedIndexChanged += new System.EventHandler(this.lstTrainers_SelectedIndexChanged);
            // 
            // btnEditTrainer
            // 
            this.btnEditTrainer.Location = new System.Drawing.Point(13, 270);
            this.btnEditTrainer.Name = "btnEditTrainer";
            this.btnEditTrainer.Size = new System.Drawing.Size(75, 23);
            this.btnEditTrainer.TabIndex = 2;
            this.btnEditTrainer.Text = "Просмотр";
            this.btnEditTrainer.UseVisualStyleBackColor = true;
            this.btnEditTrainer.Click += new System.EventHandler(this.btnEditTrainer_Click);
            // 
            // lstTrainers2
            // 
            this.lstTrainers2.FormattingEnabled = true;
            this.lstTrainers2.Location = new System.Drawing.Point(346, 13);
            this.lstTrainers2.Name = "lstTrainers2";
            this.lstTrainers2.Size = new System.Drawing.Size(336, 251);
            this.lstTrainers2.TabIndex = 3;
            this.lstTrainers2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTrainers2_MouseDoubleClick);
            // 
            // frmTrainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 320);
            this.Controls.Add(this.lstTrainers2);
            this.Controls.Add(this.btnEditTrainer);
            this.Controls.Add(this.lstTrainers);
            this.Name = "frmTrainers";
            this.Text = "Тренеры";
            this.Load += new System.EventHandler(this.frmTrainers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTrainers;
        private System.Windows.Forms.Button btnEditTrainer;
        private System.Windows.Forms.ListBox lstTrainers2;
    }
}