namespace DiagnosticSYS
{
    partial class frmAddService
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
            this.Back_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.lblbStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpAddService = new System.Windows.Forms.GroupBox();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_backclick = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpAddService.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_backclick});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Back_Click
            // 
            this.Back_Click.Name = "Back_Click";
            this.Back_Click.Size = new System.Drawing.Size(49, 20);
            this.Back_Click.Text = "BACK";
            this.Back_Click.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblbStatus
            // 
            this.lblbStatus.AutoSize = true;
            this.lblbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbStatus.Location = new System.Drawing.Point(187, 254);
            this.lblbStatus.Name = "lblbStatus";
            this.lblbStatus.Size = new System.Drawing.Size(0, 17);
            this.lblbStatus.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(180, 36);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 29);
            this.lblTitle.TabIndex = 79;
            this.lblTitle.Text = "Add New Service";
            // 
            // grpAddService
            // 
            this.grpAddService.Controls.Add(this.cboEquipment);
            this.grpAddService.Controls.Add(this.lblEquipmentName);
            this.grpAddService.Controls.Add(this.btnAddService);
            this.grpAddService.Controls.Add(this.txtRate);
            this.grpAddService.Controls.Add(this.txtDescription);
            this.grpAddService.Controls.Add(this.txtServiceName);
            this.grpAddService.Controls.Add(this.txtServiceID);
            this.grpAddService.Controls.Add(this.lblService);
            this.grpAddService.Controls.Add(this.label1);
            this.grpAddService.Controls.Add(this.label2);
            this.grpAddService.Controls.Add(this.label3);
            this.grpAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddService.Location = new System.Drawing.Point(98, 78);
            this.grpAddService.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddService.Name = "grpAddService";
            this.grpAddService.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddService.Size = new System.Drawing.Size(435, 286);
            this.grpAddService.TabIndex = 141;
            this.grpAddService.TabStop = false;
            this.grpAddService.Text = "Add Service";
            this.grpAddService.Visible = false;
            // 
            // cboEquipment
            // 
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Location = new System.Drawing.Point(147, 196);
            this.cboEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(144, 24);
            this.cboEquipment.TabIndex = 177;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(19, 196);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(130, 17);
            this.lblEquipmentName.TabIndex = 176;
            this.lblEquipmentName.Text = "Equipment Name";
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddService.Location = new System.Drawing.Point(309, 238);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(105, 32);
            this.btnAddService.TabIndex = 175;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(126, 149);
            this.txtRate.MaxLength = 6;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 23);
            this.txtRate.TabIndex = 174;
            this.txtRate.Text = "0.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(126, 102);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(146, 23);
            this.txtDescription.TabIndex = 173;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(126, 62);
            this.txtServiceName.MaxLength = 25;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(90, 23);
            this.txtServiceName.TabIndex = 172;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(126, 28);
            this.txtServiceID.MaxLength = 25;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(90, 23);
            this.txtServiceID.TabIndex = 171;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(14, 63);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(108, 17);
            this.lblService.TabIndex = 168;
            this.lblService.Text = "Service Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 166;
            this.label1.Text = "Service ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 164;
            this.label2.Text = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 162;
            this.label3.Text = "Description";
            // 
            // btn_backclick
            // 
            this.btn_backclick.Name = "btn_backclick";
            this.btn_backclick.Size = new System.Drawing.Size(49, 20);
            this.btn_backclick.Text = "BACK";
            this.btn_backclick.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // frmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 416);
            this.Controls.Add(this.grpAddService);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblbStatus);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddService";
            this.Text = "Hope Medical Diagnostic Center - [Add Service]";
            this.Load += new System.EventHandler(this.frmAddService_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpAddService.ResumeLayout(false);
            this.grpAddService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Back_Click;
        private System.Windows.Forms.Label lblbStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpAddService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.ToolStripMenuItem btn_backclick;
    }
}