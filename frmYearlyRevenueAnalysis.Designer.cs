namespace DiagnosticSYS
{
    partial class frmYearlyRevenueAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyRevenueAnalysis));
            this.mnuBack = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.cboRevenueAnalysis = new System.Windows.Forms.ComboBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.mnuBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBack
            // 
            this.mnuBack.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem1});
            this.mnuBack.Location = new System.Drawing.Point(0, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(800, 28);
            this.mnuBack.TabIndex = 10;
            this.mnuBack.Text = "mnuBack";
            // 
            // bACKToolStripMenuItem1
            // 
            this.bACKToolStripMenuItem1.Name = "bACKToolStripMenuItem1";
            this.bACKToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.bACKToolStripMenuItem1.Text = "BACK";
            this.bACKToolStripMenuItem1.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(180, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(354, 38);
            this.lblTitle.TabIndex = 158;
            this.lblTitle.Text = "Yearly Revenue Analysis";
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(114, 131);
            this.lblEquipmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(114, 20);
            this.lblEquipmentName.TabIndex = 159;
            this.lblEquipmentName.Text = "Choose year";
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRevenue.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenue.Image")));
            this.btnRevenue.Location = new System.Drawing.Point(269, 245);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(232, 44);
            this.btnRevenue.TabIndex = 160;
            this.btnRevenue.Text = "Generate Revenue Analysis";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // cboRevenueAnalysis
            // 
            this.cboRevenueAnalysis.FormattingEnabled = true;
            this.cboRevenueAnalysis.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020"});
            this.cboRevenueAnalysis.Location = new System.Drawing.Point(339, 131);
            this.cboRevenueAnalysis.Name = "cboRevenueAnalysis";
            this.cboRevenueAnalysis.Size = new System.Drawing.Size(109, 24);
            this.cboRevenueAnalysis.TabIndex = 161;
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(69, 101);
            this.picMain.Margin = new System.Windows.Forms.Padding(4);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(677, 365);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 162;
            this.picMain.TabStop = false;
            this.picMain.Visible = false;
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.cboRevenueAnalysis);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuBack);
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "Hope Medical Diagnostic Center - [Yearly Revenue Analysis]";
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.ComboBox cboRevenueAnalysis;
        private System.Windows.Forms.PictureBox picMain;
    }
}