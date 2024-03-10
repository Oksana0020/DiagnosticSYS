namespace DiagnosticSYS
{
    partial class frmDiscontinueService
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpServiceInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServiceInfo = new System.Windows.Forms.Label();
            this.btnDiscontinueService = new System.Windows.Forms.Button();
            this.grdDiscontinueServices = new System.Windows.Forms.DataGridView();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.textServiceName = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpServiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDiscontinueServices)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bACKToolStripMenuItem1
            // 
            this.bACKToolStripMenuItem1.Name = "bACKToolStripMenuItem1";
            this.bACKToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.bACKToolStripMenuItem1.Text = "BACK";
            this.bACKToolStripMenuItem1.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(342, 116);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceName.MaxLength = 25;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(119, 22);
            this.txtServiceName.TabIndex = 36;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(139, 118);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(126, 20);
            this.lblServiceName.TabIndex = 35;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(238, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 38);
            this.lblTitle.TabIndex = 80;
            this.lblTitle.Text = "Discontinue Service";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(541, 109);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 29);
            this.btnSearch.TabIndex = 102;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnServiceSearch);
            // 
            // grpServiceInfo
            // 
            this.grpServiceInfo.Controls.Add(this.txtServiceID);
            this.grpServiceInfo.Controls.Add(this.textServiceName);
            this.grpServiceInfo.Controls.Add(this.lblService);
            this.grpServiceInfo.Controls.Add(this.lblServiceID);
            this.grpServiceInfo.Controls.Add(this.txtRate);
            this.grpServiceInfo.Controls.Add(this.lblRate);
            this.grpServiceInfo.Controls.Add(this.txtServiceDescription);
            this.grpServiceInfo.Controls.Add(this.lblDescription);
            this.grpServiceInfo.Controls.Add(this.label1);
            this.grpServiceInfo.Controls.Add(this.lblServiceInfo);
            this.grpServiceInfo.Controls.Add(this.btnDiscontinueService);
            this.grpServiceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServiceInfo.Location = new System.Drawing.Point(143, 330);
            this.grpServiceInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpServiceInfo.Name = "grpServiceInfo";
            this.grpServiceInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpServiceInfo.Size = new System.Drawing.Size(544, 287);
            this.grpServiceInfo.TabIndex = 141;
            this.grpServiceInfo.TabStop = false;
            this.grpServiceInfo.Text = "Discontinue Service";
            this.grpServiceInfo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 167;
            // 
            // lblServiceInfo
            // 
            this.lblServiceInfo.AutoSize = true;
            this.lblServiceInfo.Location = new System.Drawing.Point(19, 38);
            this.lblServiceInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceInfo.Name = "lblServiceInfo";
            this.lblServiceInfo.Size = new System.Drawing.Size(0, 20);
            this.lblServiceInfo.TabIndex = 166;
            // 
            // btnDiscontinueService
            // 
            this.btnDiscontinueService.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDiscontinueService.Location = new System.Drawing.Point(347, 232);
            this.btnDiscontinueService.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscontinueService.Name = "btnDiscontinueService";
            this.btnDiscontinueService.Size = new System.Drawing.Size(174, 35);
            this.btnDiscontinueService.TabIndex = 32;
            this.btnDiscontinueService.Text = "Discontinue";
            this.btnDiscontinueService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDiscontinueService.UseVisualStyleBackColor = true;
            this.btnDiscontinueService.Click += new System.EventHandler(this.btnConfirmDiscontinue_click);
            // 
            // grdDiscontinueServices
            // 
            this.grdDiscontinueServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDiscontinueServices.Location = new System.Drawing.Point(59, 153);
            this.grdDiscontinueServices.Name = "grdDiscontinueServices";
            this.grdDiscontinueServices.RowHeadersWidth = 51;
            this.grdDiscontinueServices.RowTemplate.Height = 24;
            this.grdDiscontinueServices.Size = new System.Drawing.Size(715, 165);
            this.grdDiscontinueServices.TabIndex = 174;
            this.grdDiscontinueServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDiscontinueServices_CellClick);
            // 
            // txtServiceID
            // 
            this.txtServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceID.Location = new System.Drawing.Point(199, 35);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceID.MaxLength = 25;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(119, 27);
            this.txtServiceID.TabIndex = 183;
            // 
            // textServiceName
            // 
            this.textServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textServiceName.Location = new System.Drawing.Point(199, 74);
            this.textServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.textServiceName.MaxLength = 25;
            this.textServiceName.Name = "textServiceName";
            this.textServiceName.Size = new System.Drawing.Size(119, 27);
            this.textServiceName.TabIndex = 182;
            this.textServiceName.Text = "MRI";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(50, 77);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(126, 20);
            this.lblService.TabIndex = 181;
            this.lblService.Text = "Service Name";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(50, 38);
            this.lblServiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(97, 20);
            this.lblServiceID.TabIndex = 180;
            this.lblServiceID.Text = "Service ID";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(199, 187);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.MaxLength = 6;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(132, 27);
            this.txtRate.TabIndex = 179;
            this.txtRate.Text = "200.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(56, 190);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(48, 20);
            this.lblRate.TabIndex = 178;
            this.lblRate.Text = "Rate";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(199, 125);
            this.txtServiceDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceDescription.MaxLength = 50;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(276, 27);
            this.txtServiceDescription.TabIndex = 177;
            this.txtServiceDescription.Text = "Magnetic Resonance Imaging";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(50, 128);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(106, 20);
            this.lblDescription.TabIndex = 176;
            this.lblDescription.Text = "Description";
            // 
            // frmDiscontinueService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.grdDiscontinueServices);
            this.Controls.Add(this.grpServiceInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmDiscontinueService";
            this.Text = "Hope Medical Diagnostic Center - [Discontinue Service]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpServiceInfo.ResumeLayout(false);
            this.grpServiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDiscontinueServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpServiceInfo;
        private System.Windows.Forms.Label lblServiceInfo;
        private System.Windows.Forms.Button btnDiscontinueService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDiscontinueServices;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox textServiceName;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}