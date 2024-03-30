namespace DiagnosticSYS
{
    partial class frmUpdateService
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
            this.Back_click = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearchingService = new System.Windows.Forms.Button();
            this.grpUpdateService = new System.Windows.Forms.GroupBox();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.grdServices = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpUpdateService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServices)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back_click});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Back_click
            // 
            this.Back_click.Name = "Back_click";
            this.Back_click.Size = new System.Drawing.Size(60, 24);
            this.Back_click.Text = "BACK";
            this.Back_click.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateService.Location = new System.Drawing.Point(333, 264);
            this.btnUpdateService.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(123, 35);
            this.btnUpdateService.TabIndex = 32;
            this.btnUpdateService.Text = "Update Service";
            this.btnUpdateService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateServices);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(245, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 38);
            this.lblTitle.TabIndex = 80;
            this.lblTitle.Text = "Update Service";
            // 
            // btnSearchingService
            // 
            this.btnSearchingService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearchingService.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchingService.Location = new System.Drawing.Point(510, 88);
            this.btnSearchingService.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearchingService.Name = "btnSearchingService";
            this.btnSearchingService.Size = new System.Drawing.Size(133, 29);
            this.btnSearchingService.TabIndex = 101;
            this.btnSearchingService.Text = "SEARCH";
            this.btnSearchingService.UseVisualStyleBackColor = false;
            this.btnSearchingService.Click += new System.EventHandler(this.btnSearchingService_Click);
            // 
            // grpUpdateService
            // 
            this.grpUpdateService.Controls.Add(this.txtServiceID);
            this.grpUpdateService.Controls.Add(this.txtServiceName);
            this.grpUpdateService.Controls.Add(this.lblService);
            this.grpUpdateService.Controls.Add(this.lblServiceID);
            this.grpUpdateService.Controls.Add(this.txtRate);
            this.grpUpdateService.Controls.Add(this.btnUpdateService);
            this.grpUpdateService.Controls.Add(this.lblRate);
            this.grpUpdateService.Controls.Add(this.txtServiceDescription);
            this.grpUpdateService.Controls.Add(this.lblDescription);
            this.grpUpdateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateService.Location = new System.Drawing.Point(136, 312);
            this.grpUpdateService.Margin = new System.Windows.Forms.Padding(2);
            this.grpUpdateService.Name = "grpUpdateService";
            this.grpUpdateService.Padding = new System.Windows.Forms.Padding(2);
            this.grpUpdateService.Size = new System.Drawing.Size(544, 311);
            this.grpUpdateService.TabIndex = 140;
            this.grpUpdateService.TabStop = false;
            this.grpUpdateService.Text = "Update Service";
            this.grpUpdateService.Visible = false;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceID.Location = new System.Drawing.Point(168, 35);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceID.MaxLength = 25;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(119, 27);
            this.txtServiceID.TabIndex = 175;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.Location = new System.Drawing.Point(168, 74);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceName.MaxLength = 25;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(119, 27);
            this.txtServiceName.TabIndex = 170;
            this.txtServiceName.Text = "MRI";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(19, 77);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(126, 20);
            this.lblService.TabIndex = 168;
            this.lblService.Text = "Service Name";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(19, 38);
            this.lblServiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(97, 20);
            this.lblServiceID.TabIndex = 166;
            this.lblServiceID.Text = "Service ID";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(168, 187);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.MaxLength = 6;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(132, 27);
            this.txtRate.TabIndex = 165;
            this.txtRate.Text = "200.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(25, 190);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(48, 20);
            this.lblRate.TabIndex = 164;
            this.lblRate.Text = "Rate";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(168, 125);
            this.txtServiceDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceDescription.MaxLength = 50;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(276, 27);
            this.txtServiceDescription.TabIndex = 163;
            this.txtServiceDescription.Text = "Magnetic Resonance Imaging";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(19, 128);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(106, 20);
            this.lblDescription.TabIndex = 162;
            this.lblDescription.Text = "Description";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(37, 97);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(253, 20);
            this.lblServiceName.TabIndex = 162;
            this.lblServiceName.Text = "Enter Service Name (or part)";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(332, 88);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.MaxLength = 25;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(119, 27);
            this.txtSearchName.TabIndex = 172;
            // 
            // grdServices
            // 
            this.grdServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServices.Location = new System.Drawing.Point(41, 132);
            this.grdServices.Name = "grdServices";
            this.grdServices.RowHeadersWidth = 51;
            this.grdServices.RowTemplate.Height = 24;
            this.grdServices.Size = new System.Drawing.Size(715, 165);
            this.grdServices.TabIndex = 173;
            this.grdServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdServices_CellClick);
            // 
            // frmUpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.grdServices);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.btnSearchingService);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpUpdateService);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmUpdateService";
            this.Text = "Hope Medical Diagnostic Center - [Update Service]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpUpdateService.ResumeLayout(false);
            this.grpUpdateService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Back_click;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearchingService;
        private System.Windows.Forms.GroupBox grpUpdateService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.DataGridView grdServices;
    }
}