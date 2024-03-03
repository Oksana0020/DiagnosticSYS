namespace DiagnosticSYS
{
    partial class frmMakeAppointment
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
            this.grpPatientDetails = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.lblPatientSurname = new System.Windows.Forms.Label();
            this.txtPatientForename = new System.Windows.Forms.TextBox();
            this.lblPatientForename = new System.Windows.Forms.Label();
            this.btnMakeAppointment = new System.Windows.Forms.Button();
            this.lblReferral = new System.Windows.Forms.Label();
            this.txtReferral = new System.Windows.Forms.TextBox();
            this.grpAppDetails = new System.Windows.Forms.GroupBox();
            this.lblAppoinmentID = new System.Windows.Forms.Label();
            this.txtAppointmentID = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.txtApptID = new System.Windows.Forms.TextBox();
            this.grpMakingAppointment = new System.Windows.Forms.GroupBox();
            this.cboEquipmentName = new System.Windows.Forms.ComboBox();
            this.cboDoctors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceRate = new System.Windows.Forms.TextBox();
            this.cboAppointmentTime = new System.Windows.Forms.ComboBox();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.mnuBack.SuspendLayout();
            this.grpPatientDetails.SuspendLayout();
            this.grpAppDetails.SuspendLayout();
            this.grpMakingAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBack
            // 
            this.mnuBack.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKToolStripMenuItem1});
            this.mnuBack.Location = new System.Drawing.Point(0, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuBack.Size = new System.Drawing.Size(652, 24);
            this.mnuBack.TabIndex = 7;
            this.mnuBack.Text = "mnuBack";
            // 
            // bACKToolStripMenuItem1
            // 
            this.bACKToolStripMenuItem1.Name = "bACKToolStripMenuItem1";
            this.bACKToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.bACKToolStripMenuItem1.Text = "BACK";
            this.bACKToolStripMenuItem1.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpPatientDetails
            // 
            this.grpPatientDetails.Controls.Add(this.txtAddress);
            this.grpPatientDetails.Controls.Add(this.lblAddress);
            this.grpPatientDetails.Controls.Add(this.txtPhone);
            this.grpPatientDetails.Controls.Add(this.txtEmail);
            this.grpPatientDetails.Controls.Add(this.lblEmail);
            this.grpPatientDetails.Controls.Add(this.lblPhone);
            this.grpPatientDetails.Controls.Add(this.txtPatientSurname);
            this.grpPatientDetails.Controls.Add(this.lblPatientSurname);
            this.grpPatientDetails.Controls.Add(this.txtPatientForename);
            this.grpPatientDetails.Controls.Add(this.lblPatientForename);
            this.grpPatientDetails.Controls.Add(this.btnMakeAppointment);
            this.grpPatientDetails.Controls.Add(this.lblReferral);
            this.grpPatientDetails.Controls.Add(this.txtReferral);
            this.grpPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientDetails.Location = new System.Drawing.Point(332, 38);
            this.grpPatientDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatientDetails.Name = "grpPatientDetails";
            this.grpPatientDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpPatientDetails.Size = new System.Drawing.Size(309, 318);
            this.grpPatientDetails.TabIndex = 136;
            this.grpPatientDetails.TabStop = false;
            this.grpPatientDetails.Text = "Patient Details";
            this.grpPatientDetails.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(107, 95);
            this.txtAddress.MaxLength = 30;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(161, 23);
            this.txtAddress.TabIndex = 139;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(9, 98);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 17);
            this.lblAddress.TabIndex = 138;
            this.lblAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(146, 121);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(122, 23);
            this.txtPhone.TabIndex = 137;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 155);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 23);
            this.txtEmail.TabIndex = 136;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 135;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(9, 121);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhone.Size = new System.Drawing.Size(54, 17);
            this.lblPhone.TabIndex = 134;
            this.lblPhone.Text = "Phone";
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.Location = new System.Drawing.Point(146, 65);
            this.txtPatientSurname.MaxLength = 15;
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(122, 23);
            this.txtPatientSurname.TabIndex = 133;
            // 
            // lblPatientSurname
            // 
            this.lblPatientSurname.AutoSize = true;
            this.lblPatientSurname.Location = new System.Drawing.Point(8, 71);
            this.lblPatientSurname.Name = "lblPatientSurname";
            this.lblPatientSurname.Size = new System.Drawing.Size(128, 17);
            this.lblPatientSurname.TabIndex = 132;
            this.lblPatientSurname.Text = "Patient Surname";
            // 
            // txtPatientForename
            // 
            this.txtPatientForename.Location = new System.Drawing.Point(146, 35);
            this.txtPatientForename.MaxLength = 15;
            this.txtPatientForename.Name = "txtPatientForename";
            this.txtPatientForename.Size = new System.Drawing.Size(122, 23);
            this.txtPatientForename.TabIndex = 131;
            // 
            // lblPatientForename
            // 
            this.lblPatientForename.AutoSize = true;
            this.lblPatientForename.Location = new System.Drawing.Point(4, 38);
            this.lblPatientForename.Name = "lblPatientForename";
            this.lblPatientForename.Size = new System.Drawing.Size(136, 17);
            this.lblPatientForename.TabIndex = 130;
            this.lblPatientForename.Text = "Patient Forename";
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.Location = new System.Drawing.Point(61, 246);
            this.btnMakeAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(164, 26);
            this.btnMakeAppointment.TabIndex = 4;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = true;
            this.btnMakeAppointment.Click += new System.EventHandler(this.MakeAppointment_click);
            // 
            // lblReferral
            // 
            this.lblReferral.AutoSize = true;
            this.lblReferral.Location = new System.Drawing.Point(9, 196);
            this.lblReferral.Name = "lblReferral";
            this.lblReferral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReferral.Size = new System.Drawing.Size(67, 17);
            this.lblReferral.TabIndex = 148;
            this.lblReferral.Text = "Referral";
            // 
            // txtReferral
            // 
            this.txtReferral.Location = new System.Drawing.Point(146, 193);
            this.txtReferral.MaxLength = 15;
            this.txtReferral.Name = "txtReferral";
            this.txtReferral.Size = new System.Drawing.Size(122, 23);
            this.txtReferral.TabIndex = 152;
            // 
            // grpAppDetails
            // 
            this.grpAppDetails.Controls.Add(this.cboEquipmentName);
            this.grpAppDetails.Controls.Add(this.cboDoctors);
            this.grpAppDetails.Controls.Add(this.label1);
            this.grpAppDetails.Controls.Add(this.txtServiceRate);
            this.grpAppDetails.Controls.Add(this.cboAppointmentTime);
            this.grpAppDetails.Controls.Add(this.dtmDate);
            this.grpAppDetails.Controls.Add(this.lblEquipmentName);
            this.grpAppDetails.Controls.Add(this.lblAppointmentTime);
            this.grpAppDetails.Controls.Add(this.lblDoctor);
            this.grpAppDetails.Controls.Add(this.lblAppointmentDate);
            this.grpAppDetails.Location = new System.Drawing.Point(20, 171);
            this.grpAppDetails.Name = "grpAppDetails";
            this.grpAppDetails.Size = new System.Drawing.Size(298, 299);
            this.grpAppDetails.TabIndex = 139;
            this.grpAppDetails.TabStop = false;
            this.grpAppDetails.Text = "groupBox1";
            // 
            // lblAppoinmentID
            // 
            this.lblAppoinmentID.AutoSize = true;
            this.lblAppoinmentID.Location = new System.Drawing.Point(4, 18);
            this.lblAppoinmentID.Name = "lblAppoinmentID";
            this.lblAppoinmentID.Size = new System.Drawing.Size(118, 17);
            this.lblAppoinmentID.TabIndex = 140;
            this.lblAppoinmentID.Text = "Appointment ID";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.AutoSize = true;
            this.txtAppointmentID.Location = new System.Drawing.Point(132, 18);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(26, 17);
            this.txtAppointmentID.TabIndex = 141;
            this.txtAppointmentID.Text = "01";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(4, 50);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(108, 17);
            this.lblServiceName.TabIndex = 142;
            this.lblServiceName.Text = "Service Name";
            // 
            // cboServices
            // 
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(142, 48);
            this.cboServices.Margin = new System.Windows.Forms.Padding(2);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(111, 24);
            this.cboServices.TabIndex = 159;
            this.cboServices.SelectedIndexChanged += new System.EventHandler(this.cboServices_SelectedIndexChanged);
            // 
            // txtApptID
            // 
            this.txtApptID.Location = new System.Drawing.Point(178, 18);
            this.txtApptID.MaxLength = 2;
            this.txtApptID.Name = "txtApptID";
            this.txtApptID.Size = new System.Drawing.Size(66, 23);
            this.txtApptID.TabIndex = 166;
            // 
            // grpMakingAppointment
            // 
            this.grpMakingAppointment.Controls.Add(this.txtApptID);
            this.grpMakingAppointment.Controls.Add(this.cboServices);
            this.grpMakingAppointment.Controls.Add(this.lblServiceName);
            this.grpMakingAppointment.Controls.Add(this.txtAppointmentID);
            this.grpMakingAppointment.Controls.Add(this.lblAppoinmentID);
            this.grpMakingAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMakingAppointment.Location = new System.Drawing.Point(20, 38);
            this.grpMakingAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.grpMakingAppointment.Name = "grpMakingAppointment";
            this.grpMakingAppointment.Padding = new System.Windows.Forms.Padding(2);
            this.grpMakingAppointment.Size = new System.Drawing.Size(298, 128);
            this.grpMakingAppointment.TabIndex = 138;
            this.grpMakingAppointment.TabStop = false;
            this.grpMakingAppointment.Text = "Making New Appointment";
            // 
            // cboEquipmentName
            // 
            this.cboEquipmentName.Enabled = false;
            this.cboEquipmentName.FormattingEnabled = true;
            this.cboEquipmentName.Items.AddRange(new object[] {
            "MRI Scanner MR01",
            "X-Ray Machine XR02",
            "CT Scanner CT03",
            "Ultrasound Machine UL04",
            "Fluoroscopy Machine FL05"});
            this.cboEquipmentName.Location = new System.Drawing.Point(170, 263);
            this.cboEquipmentName.Margin = new System.Windows.Forms.Padding(2);
            this.cboEquipmentName.Name = "cboEquipmentName";
            this.cboEquipmentName.Size = new System.Drawing.Size(85, 21);
            this.cboEquipmentName.TabIndex = 177;
            // 
            // cboDoctors
            // 
            this.cboDoctors.Enabled = false;
            this.cboDoctors.FormattingEnabled = true;
            this.cboDoctors.Items.AddRange(new object[] {
            "Dr. Smith",
            "Dr. Brown",
            "Dr. Wilson",
            "Dr. Anderson",
            "Dr. White"});
            this.cboDoctors.Location = new System.Drawing.Point(170, 223);
            this.cboDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.cboDoctors.Name = "cboDoctors";
            this.cboDoctors.Size = new System.Drawing.Size(102, 21);
            this.cboDoctors.TabIndex = 174;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 173;
            this.label1.Text = "Rate";
            // 
            // txtServiceRate
            // 
            this.txtServiceRate.Location = new System.Drawing.Point(170, 79);
            this.txtServiceRate.MaxLength = 2;
            this.txtServiceRate.Name = "txtServiceRate";
            this.txtServiceRate.Size = new System.Drawing.Size(66, 20);
            this.txtServiceRate.TabIndex = 172;
            // 
            // cboAppointmentTime
            // 
            this.cboAppointmentTime.Enabled = false;
            this.cboAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAppointmentTime.FormattingEnabled = true;
            this.cboAppointmentTime.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30"});
            this.cboAppointmentTime.Location = new System.Drawing.Point(170, 181);
            this.cboAppointmentTime.Margin = new System.Windows.Forms.Padding(2);
            this.cboAppointmentTime.Name = "cboAppointmentTime";
            this.cboAppointmentTime.Size = new System.Drawing.Size(92, 21);
            this.cboAppointmentTime.TabIndex = 171;
            // 
            // dtmDate
            // 
            this.dtmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDate.Location = new System.Drawing.Point(170, 153);
            this.dtmDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(102, 19);
            this.dtmDate.TabIndex = 170;
            this.dtmDate.Value = new System.DateTime(2023, 11, 28, 0, 0, 0, 0);
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Location = new System.Drawing.Point(32, 270);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(88, 13);
            this.lblEquipmentName.TabIndex = 169;
            this.lblEquipmentName.Text = "Equipment Name";
            this.lblEquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Location = new System.Drawing.Point(32, 184);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(92, 13);
            this.lblAppointmentTime.TabIndex = 168;
            this.lblAppointmentTime.Text = "Appointment Time";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(32, 229);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 167;
            this.lblDoctor.Text = "Doctor";
            this.lblDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(26, 153);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(92, 13);
            this.lblAppointmentDate.TabIndex = 166;
            this.lblAppointmentDate.Text = "Appointment Date";
            // 
            // frmMakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 558);
            this.Controls.Add(this.grpAppDetails);
            this.Controls.Add(this.grpMakingAppointment);
            this.Controls.Add(this.grpPatientDetails);
            this.Controls.Add(this.mnuBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMakeAppointment";
            this.Text = "Hope Medical Diagnostic Center - [Make Appointment]";
            this.Load += new System.EventHandler(this.frmMakeAppointment_Load_1);
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.grpPatientDetails.ResumeLayout(false);
            this.grpPatientDetails.PerformLayout();
            this.grpAppDetails.ResumeLayout(false);
            this.grpAppDetails.PerformLayout();
            this.grpMakingAppointment.ResumeLayout(false);
            this.grpMakingAppointment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpPatientDetails;
        private System.Windows.Forms.Button btnMakeAppointment;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.Label lblPatientSurname;
        private System.Windows.Forms.TextBox txtPatientForename;
        private System.Windows.Forms.Label lblPatientForename;
        private System.Windows.Forms.TextBox txtReferral;
        private System.Windows.Forms.Label lblReferral;
        private System.Windows.Forms.GroupBox grpAppDetails;
        private System.Windows.Forms.ComboBox cboEquipmentName;
        private System.Windows.Forms.ComboBox cboDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceRate;
        private System.Windows.Forms.ComboBox cboAppointmentTime;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblAppoinmentID;
        private System.Windows.Forms.Label txtAppointmentID;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.TextBox txtApptID;
        private System.Windows.Forms.GroupBox grpMakingAppointment;
    }
}