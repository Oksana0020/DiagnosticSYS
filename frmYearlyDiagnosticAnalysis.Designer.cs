namespace DiagnosticSYS
{
    partial class frmYearlyDiagnosticAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyDiagnosticAnalysis));
            this.mnuBack = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboRevenueAnalysis = new System.Windows.Forms.ComboBox();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.mnuBack.TabIndex = 11;
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
            this.lblTitle.Location = new System.Drawing.Point(170, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 38);
            this.lblTitle.TabIndex = 163;
            this.lblTitle.Text = "Yearly DIagnostic Analysis";
            // 
            // cboRevenueAnalysis
            // 
            this.cboRevenueAnalysis.FormattingEnabled = true;
            this.cboRevenueAnalysis.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020"});
            this.cboRevenueAnalysis.Location = new System.Drawing.Point(392, 129);
            this.cboRevenueAnalysis.Name = "cboRevenueAnalysis";
            this.cboRevenueAnalysis.Size = new System.Drawing.Size(109, 24);
            this.cboRevenueAnalysis.TabIndex = 166;
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRevenue.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenue.Image")));
            this.btnRevenue.Location = new System.Drawing.Point(244, 250);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(232, 44);
            this.btnRevenue.TabIndex = 165;
            this.btnRevenue.Text = "Generate Revenue Analysis";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(173, 129);
            this.lblEquipmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(114, 20);
            this.lblEquipmentName.TabIndex = 164;
            this.lblEquipmentName.Text = "Choose year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 167;
            this.label1.Text = "Service Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MRI",
            "CT",
            "Ultrasound",
            "Doplerography"});
            this.comboBox1.Location = new System.Drawing.Point(392, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 24);
            this.comboBox1.TabIndex = 168;
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(52, 95);
            this.picMain.Margin = new System.Windows.Forms.Padding(4);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(677, 365);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 169;
            this.picMain.TabStop = false;
            this.picMain.Visible = false;
            // 
            // frmYearlyDiagnosticAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRevenueAnalysis);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuBack);
            this.Name = "frmYearlyDiagnosticAnalysis";
            this.Text = "Hope Medical Diagnostic Center - [Yearly Diagnostic Analysis]";
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
        private System.Windows.Forms.ComboBox cboRevenueAnalysis;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox picMain;
    }
}