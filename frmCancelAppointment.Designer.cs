namespace DiagnosticSYS
{
    partial class frmCancelAppointment
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
            this.mnuBack = new System.Windows.Forms.MenuStrip();
            this.bACKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.grpAppointmentInfo = new System.Windows.Forms.GroupBox();
            this.lblEquipmentInfo = new System.Windows.Forms.Label();
            this.lblServiceInfo = new System.Windows.Forms.Label();
            this.btnDiscontinueService = new System.Windows.Forms.Button();
            this.lblAppointmentDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuBack.SuspendLayout();
            this.grpAppointmentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBack
            // 
            this.mnuBack.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem1});
            this.mnuBack.Location = new System.Drawing.Point(0, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(800, 30);
            this.mnuBack.TabIndex = 8;
            this.mnuBack.Text = "mnuBack";
            // 
            // bACKToolStripMenuItem1
            // 
            this.bACKToolStripMenuItem1.Name = "bACKToolStripMenuItem1";
            this.bACKToolStripMenuItem1.Size = new System.Drawing.Size(60, 26);
            this.bACKToolStripMenuItem1.Text = "BACK";
            this.bACKToolStripMenuItem1.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(162, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 38);
            this.lblTitle.TabIndex = 161;
            this.lblTitle.Text = "Cancel Appointment";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(502, 91);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 29);
            this.btnSearch.TabIndex = 164;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.CancelAppointmentSerach_click);
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.Location = new System.Drawing.Point(303, 98);
            this.txtPatientSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientSurname.MaxLength = 25;
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(119, 22);
            this.txtPatientSurname.TabIndex = 163;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(100, 100);
            this.lblEquipmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(148, 20);
            this.lblEquipmentName.TabIndex = 162;
            this.lblEquipmentName.Text = "Patient Surname";
            // 
            // grpAppointmentInfo
            // 
            this.grpAppointmentInfo.Controls.Add(this.label1);
            this.grpAppointmentInfo.Controls.Add(this.lblAppointmentDetails);
            this.grpAppointmentInfo.Controls.Add(this.lblEquipmentInfo);
            this.grpAppointmentInfo.Controls.Add(this.lblServiceInfo);
            this.grpAppointmentInfo.Controls.Add(this.btnDiscontinueService);
            this.grpAppointmentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAppointmentInfo.Location = new System.Drawing.Point(104, 152);
            this.grpAppointmentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpAppointmentInfo.Name = "grpAppointmentInfo";
            this.grpAppointmentInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpAppointmentInfo.Size = new System.Drawing.Size(544, 287);
            this.grpAppointmentInfo.TabIndex = 165;
            this.grpAppointmentInfo.TabStop = false;
            this.grpAppointmentInfo.Text = "Cancel Appointment";
            this.grpAppointmentInfo.Visible = false;
            // 
            // lblEquipmentInfo
            // 
            this.lblEquipmentInfo.AutoSize = true;
            this.lblEquipmentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentInfo.Location = new System.Drawing.Point(6, 38);
            this.lblEquipmentInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentInfo.Name = "lblEquipmentInfo";
            this.lblEquipmentInfo.Size = new System.Drawing.Size(0, 20);
            this.lblEquipmentInfo.TabIndex = 167;
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
            this.btnDiscontinueService.Location = new System.Drawing.Point(398, 232);
            this.btnDiscontinueService.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscontinueService.Name = "btnDiscontinueService";
            this.btnDiscontinueService.Size = new System.Drawing.Size(123, 35);
            this.btnDiscontinueService.TabIndex = 32;
            this.btnDiscontinueService.Text = "Confirm";
            this.btnDiscontinueService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDiscontinueService.UseVisualStyleBackColor = true;
            this.btnDiscontinueService.Click += new System.EventHandler(this.btnDiscontinueService_Click);
            // 
            // lblAppointmentDetails
            // 
            this.lblAppointmentDetails.AutoSize = true;
            this.lblAppointmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDetails.Location = new System.Drawing.Point(14, 38);
            this.lblAppointmentDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentDetails.Name = "lblAppointmentDetails";
            this.lblAppointmentDetails.Size = new System.Drawing.Size(14, 20);
            this.lblAppointmentDetails.TabIndex = 168;
            this.lblAppointmentDetails.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 20);
            this.label1.TabIndex = 169;
            this.label1.Text = "Would you like to cancel appointment?";
            // 
            // frmCancelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAppointmentInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPatientSurname);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuBack);
            this.Name = "frmCancelAppointment";
            this.Text = "Hope Medical Diagnostic Center - [Cancel Appointment]";
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.grpAppointmentInfo.ResumeLayout(false);
            this.grpAppointmentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.GroupBox grpAppointmentInfo;
        private System.Windows.Forms.Label lblEquipmentInfo;
        private System.Windows.Forms.Label lblServiceInfo;
        private System.Windows.Forms.Button btnDiscontinueService;
        private System.Windows.Forms.Label lblAppointmentDetails;
        private System.Windows.Forms.Label label1;
    }
}