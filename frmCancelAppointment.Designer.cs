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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppointmentDetails = new System.Windows.Forms.Label();
            this.lblEquipmentInfo = new System.Windows.Forms.Label();
            this.lblServiceInfo = new System.Windows.Forms.Label();
            this.btnCancelAppt = new System.Windows.Forms.Button();
            this.grdCancelAppointment = new System.Windows.Forms.DataGridView();
            this.txtPForename = new System.Windows.Forms.TextBox();
            this.txtPSurname = new System.Windows.Forms.TextBox();
            this.txtAppDate = new System.Windows.Forms.TextBox();
            this.txtAppTime = new System.Windows.Forms.TextBox();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.txtReferral = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mnuBack.SuspendLayout();
            this.grpAppointmentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelAppointment)).BeginInit();
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
            this.mnuBack.TabIndex = 8;
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
            this.grpAppointmentInfo.Controls.Add(this.label9);
            this.grpAppointmentInfo.Controls.Add(this.label8);
            this.grpAppointmentInfo.Controls.Add(this.label7);
            this.grpAppointmentInfo.Controls.Add(this.label6);
            this.grpAppointmentInfo.Controls.Add(this.label5);
            this.grpAppointmentInfo.Controls.Add(this.label4);
            this.grpAppointmentInfo.Controls.Add(this.label3);
            this.grpAppointmentInfo.Controls.Add(this.label2);
            this.grpAppointmentInfo.Controls.Add(this.txtDoctorName);
            this.grpAppointmentInfo.Controls.Add(this.txtServiceName);
            this.grpAppointmentInfo.Controls.Add(this.txtReferral);
            this.grpAppointmentInfo.Controls.Add(this.txtAppointmentID);
            this.grpAppointmentInfo.Controls.Add(this.txtAppTime);
            this.grpAppointmentInfo.Controls.Add(this.txtAppDate);
            this.grpAppointmentInfo.Controls.Add(this.txtPSurname);
            this.grpAppointmentInfo.Controls.Add(this.txtPForename);
            this.grpAppointmentInfo.Controls.Add(this.label1);
            this.grpAppointmentInfo.Controls.Add(this.lblAppointmentDetails);
            this.grpAppointmentInfo.Controls.Add(this.lblEquipmentInfo);
            this.grpAppointmentInfo.Controls.Add(this.lblServiceInfo);
            this.grpAppointmentInfo.Controls.Add(this.btnCancelAppt);
            this.grpAppointmentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAppointmentInfo.Location = new System.Drawing.Point(35, 321);
            this.grpAppointmentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpAppointmentInfo.Name = "grpAppointmentInfo";
            this.grpAppointmentInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpAppointmentInfo.Size = new System.Drawing.Size(728, 447);
            this.grpAppointmentInfo.TabIndex = 165;
            this.grpAppointmentInfo.TabStop = false;
            this.grpAppointmentInfo.Text = "Cancel Appointment";
            this.grpAppointmentInfo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 20);
            this.label1.TabIndex = 169;
            this.label1.Text = "Would you like to cancel appointment?";
            // 
            // lblAppointmentDetails
            // 
            this.lblAppointmentDetails.AutoSize = true;
            this.lblAppointmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDetails.Location = new System.Drawing.Point(14, 38);
            this.lblAppointmentDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentDetails.Name = "lblAppointmentDetails";
            this.lblAppointmentDetails.Size = new System.Drawing.Size(0, 20);
            this.lblAppointmentDetails.TabIndex = 168;
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
            // btnCancelAppt
            // 
            this.btnCancelAppt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelAppt.Location = new System.Drawing.Point(416, 406);
            this.btnCancelAppt.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAppt.Name = "btnCancelAppt";
            this.btnCancelAppt.Size = new System.Drawing.Size(123, 35);
            this.btnCancelAppt.TabIndex = 32;
            this.btnCancelAppt.Text = "Confirm";
            this.btnCancelAppt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelAppt.UseVisualStyleBackColor = true;
            this.btnCancelAppt.Click += new System.EventHandler(this.btnCancelAppt_Click);
            // 
            // grdCancelAppointment
            // 
            this.grdCancelAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCancelAppointment.Location = new System.Drawing.Point(35, 135);
            this.grdCancelAppointment.Name = "grdCancelAppointment";
            this.grdCancelAppointment.RowHeadersWidth = 51;
            this.grdCancelAppointment.RowTemplate.Height = 24;
            this.grdCancelAppointment.Size = new System.Drawing.Size(715, 165);
            this.grdCancelAppointment.TabIndex = 176;
            this.grdCancelAppointment.Visible = false;
            this.grdCancelAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CancelAppointment_CellClick);
            // 
            // txtPForename
            // 
            this.txtPForename.Location = new System.Drawing.Point(219, 78);
            this.txtPForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtPForename.MaxLength = 25;
            this.txtPForename.Name = "txtPForename";
            this.txtPForename.Size = new System.Drawing.Size(168, 27);
            this.txtPForename.TabIndex = 170;
            // 
            // txtPSurname
            // 
            this.txtPSurname.Location = new System.Drawing.Point(219, 118);
            this.txtPSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtPSurname.MaxLength = 25;
            this.txtPSurname.Name = "txtPSurname";
            this.txtPSurname.Size = new System.Drawing.Size(168, 27);
            this.txtPSurname.TabIndex = 171;
            // 
            // txtAppDate
            // 
            this.txtAppDate.Location = new System.Drawing.Point(219, 170);
            this.txtAppDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppDate.MaxLength = 25;
            this.txtAppDate.Name = "txtAppDate";
            this.txtAppDate.Size = new System.Drawing.Size(168, 27);
            this.txtAppDate.TabIndex = 172;
            // 
            // txtAppTime
            // 
            this.txtAppTime.Location = new System.Drawing.Point(219, 225);
            this.txtAppTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppTime.MaxLength = 25;
            this.txtAppTime.Name = "txtAppTime";
            this.txtAppTime.Size = new System.Drawing.Size(119, 27);
            this.txtAppTime.TabIndex = 173;
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Location = new System.Drawing.Point(219, 35);
            this.txtAppointmentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppointmentID.MaxLength = 25;
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(119, 27);
            this.txtAppointmentID.TabIndex = 174;
            // 
            // txtReferral
            // 
            this.txtReferral.Location = new System.Drawing.Point(219, 270);
            this.txtReferral.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferral.MaxLength = 25;
            this.txtReferral.Name = "txtReferral";
            this.txtReferral.Size = new System.Drawing.Size(168, 27);
            this.txtReferral.TabIndex = 175;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(219, 317);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceName.MaxLength = 25;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(217, 27);
            this.txtServiceName.TabIndex = 176;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(219, 361);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorName.MaxLength = 25;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(217, 27);
            this.txtDoctorName.TabIndex = 177;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 178;
            this.label2.Text = "Patient Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 179;
            this.label3.Text = "Patient Forename";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 180;
            this.label4.Text = "Appointment Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 181;
            this.label5.Text = "Appointment Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 182;
            this.label6.Text = "Appointment ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 183;
            this.label7.Text = "Referral";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 184;
            this.label8.Text = "Service";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 364);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 185;
            this.label9.Text = "Doctor";
            // 
            // frmCancelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 779);
            this.Controls.Add(this.grdCancelAppointment);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelAppointment)).EndInit();
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
        private System.Windows.Forms.Button btnCancelAppt;
        private System.Windows.Forms.Label lblAppointmentDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdCancelAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtReferral;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.TextBox txtAppTime;
        private System.Windows.Forms.TextBox txtAppDate;
        private System.Windows.Forms.TextBox txtPSurname;
        private System.Windows.Forms.TextBox txtPForename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}