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
            this.lblAppoinmentID = new System.Windows.Forms.Label();
            this.txtAppointmentID = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.txtApptID = new System.Windows.Forms.TextBox();
            this.grpMakingAppointment = new System.Windows.Forms.GroupBox();
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
            this.mnuBack.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuBack.Size = new System.Drawing.Size(869, 28);
            this.mnuBack.TabIndex = 7;
            this.mnuBack.Text = "mnuBack";
            // 
            // bACKToolStripMenuItem1
            // 
            this.bACKToolStripMenuItem1.Name = "bACKToolStripMenuItem1";
            this.bACKToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
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
            this.grpPatientDetails.Location = new System.Drawing.Point(443, 47);
            this.grpPatientDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPatientDetails.Name = "grpPatientDetails";
            this.grpPatientDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPatientDetails.Size = new System.Drawing.Size(412, 391);
            this.grpPatientDetails.TabIndex = 136;
            this.grpPatientDetails.TabStop = false;
            this.grpPatientDetails.Text = "Patient Details";
            this.grpPatientDetails.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(143, 117);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.MaxLength = 30;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(213, 27);
            this.txtAddress.TabIndex = 139;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 121);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 20);
            this.lblAddress.TabIndex = 138;
            this.lblAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(195, 149);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(161, 27);
            this.txtPhone.TabIndex = 137;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 191);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 27);
            this.txtEmail.TabIndex = 136;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 194);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 135;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 149);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 134;
            this.lblPhone.Text = "Phone";
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.Location = new System.Drawing.Point(195, 80);
            this.txtPatientSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientSurname.MaxLength = 15;
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(161, 27);
            this.txtPatientSurname.TabIndex = 133;
            // 
            // lblPatientSurname
            // 
            this.lblPatientSurname.AutoSize = true;
            this.lblPatientSurname.Location = new System.Drawing.Point(11, 87);
            this.lblPatientSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientSurname.Name = "lblPatientSurname";
            this.lblPatientSurname.Size = new System.Drawing.Size(148, 20);
            this.lblPatientSurname.TabIndex = 132;
            this.lblPatientSurname.Text = "Patient Surname";
            // 
            // txtPatientForename
            // 
            this.txtPatientForename.Location = new System.Drawing.Point(195, 43);
            this.txtPatientForename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientForename.MaxLength = 15;
            this.txtPatientForename.Name = "txtPatientForename";
            this.txtPatientForename.Size = new System.Drawing.Size(161, 27);
            this.txtPatientForename.TabIndex = 131;
            // 
            // lblPatientForename
            // 
            this.lblPatientForename.AutoSize = true;
            this.lblPatientForename.Location = new System.Drawing.Point(5, 47);
            this.lblPatientForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientForename.Name = "lblPatientForename";
            this.lblPatientForename.Size = new System.Drawing.Size(157, 20);
            this.lblPatientForename.TabIndex = 130;
            this.lblPatientForename.Text = "Patient Forename";
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.Location = new System.Drawing.Point(81, 303);
            this.btnMakeAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(219, 32);
            this.btnMakeAppointment.TabIndex = 4;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = true;
            this.btnMakeAppointment.Click += new System.EventHandler(this.MakeAppointment_click);
            // 
            // lblReferral
            // 
            this.lblReferral.AutoSize = true;
            this.lblReferral.Location = new System.Drawing.Point(12, 241);
            this.lblReferral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferral.Name = "lblReferral";
            this.lblReferral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReferral.Size = new System.Drawing.Size(77, 20);
            this.lblReferral.TabIndex = 148;
            this.lblReferral.Text = "Referral";
            // 
            // txtReferral
            // 
            this.txtReferral.Location = new System.Drawing.Point(195, 238);
            this.txtReferral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReferral.MaxLength = 15;
            this.txtReferral.Name = "txtReferral";
            this.txtReferral.Size = new System.Drawing.Size(161, 27);
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
            this.grpAppDetails.Location = new System.Drawing.Point(27, 210);
            this.grpAppDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAppDetails.Name = "grpAppDetails";
            this.grpAppDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAppDetails.Size = new System.Drawing.Size(397, 368);
            this.grpAppDetails.TabIndex = 139;
            this.grpAppDetails.TabStop = false;
            this.grpAppDetails.Text = "groupBox1";
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
            this.cboEquipmentName.Location = new System.Drawing.Point(227, 324);
            this.cboEquipmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEquipmentName.Name = "cboEquipmentName";
            this.cboEquipmentName.Size = new System.Drawing.Size(112, 24);
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
            this.cboDoctors.Location = new System.Drawing.Point(227, 274);
            this.cboDoctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDoctors.Name = "cboDoctors";
            this.cboDoctors.Size = new System.Drawing.Size(135, 24);
            this.cboDoctors.TabIndex = 174;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 173;
            this.label1.Text = "Rate";
            // 
            // txtServiceRate
            // 
            this.txtServiceRate.Location = new System.Drawing.Point(227, 97);
            this.txtServiceRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServiceRate.MaxLength = 2;
            this.txtServiceRate.Name = "txtServiceRate";
            this.txtServiceRate.Size = new System.Drawing.Size(87, 22);
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
            this.cboAppointmentTime.Location = new System.Drawing.Point(227, 223);
            this.cboAppointmentTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAppointmentTime.Name = "cboAppointmentTime";
            this.cboAppointmentTime.Size = new System.Drawing.Size(121, 24);
            this.cboAppointmentTime.TabIndex = 171;
            // 
            // dtmDate
            // 
            this.dtmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDate.Location = new System.Drawing.Point(227, 188);
            this.dtmDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(135, 22);
            this.dtmDate.TabIndex = 170;
            this.dtmDate.Value = new System.DateTime(2023, 11, 28, 0, 0, 0, 0);
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Location = new System.Drawing.Point(43, 332);
            this.lblEquipmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(111, 16);
            this.lblEquipmentName.TabIndex = 169;
            this.lblEquipmentName.Text = "Equipment Name";
            this.lblEquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Location = new System.Drawing.Point(43, 226);
            this.lblAppointmentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(116, 16);
            this.lblAppointmentTime.TabIndex = 168;
            this.lblAppointmentTime.Text = "Appointment Time";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(43, 282);
            this.lblDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(47, 16);
            this.lblDoctor.TabIndex = 167;
            this.lblDoctor.Text = "Doctor";
            this.lblDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(35, 188);
            this.lblAppointmentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(114, 16);
            this.lblAppointmentDate.TabIndex = 166;
            this.lblAppointmentDate.Text = "Appointment Date";
            // 
            // lblAppoinmentID
            // 
            this.lblAppoinmentID.AutoSize = true;
            this.lblAppoinmentID.Location = new System.Drawing.Point(5, 22);
            this.lblAppoinmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppoinmentID.Name = "lblAppoinmentID";
            this.lblAppoinmentID.Size = new System.Drawing.Size(138, 20);
            this.lblAppoinmentID.TabIndex = 140;
            this.lblAppoinmentID.Text = "Appointment ID";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.AutoSize = true;
            this.txtAppointmentID.Location = new System.Drawing.Point(176, 22);
            this.txtAppointmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(29, 20);
            this.txtAppointmentID.TabIndex = 141;
            this.txtAppointmentID.Text = "01";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(5, 62);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(126, 20);
            this.lblServiceName.TabIndex = 142;
            this.lblServiceName.Text = "Service Name";
            // 
            // cboServices
            // 
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(189, 59);
            this.cboServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(147, 28);
            this.cboServices.TabIndex = 159;
            this.cboServices.SelectedIndexChanged += new System.EventHandler(this.cboServices_SelectedIndexChanged);
            // 
            // txtApptID
            // 
            this.txtApptID.Location = new System.Drawing.Point(237, 22);
            this.txtApptID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApptID.MaxLength = 2;
            this.txtApptID.Name = "txtApptID";
            this.txtApptID.Size = new System.Drawing.Size(87, 27);
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
            this.grpMakingAppointment.Location = new System.Drawing.Point(27, 47);
            this.grpMakingAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMakingAppointment.Name = "grpMakingAppointment";
            this.grpMakingAppointment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMakingAppointment.Size = new System.Drawing.Size(397, 158);
            this.grpMakingAppointment.TabIndex = 138;
            this.grpMakingAppointment.TabStop = false;
            this.grpMakingAppointment.Text = "Making New Appointment";
            // 
            // frmMakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 687);
            this.Controls.Add(this.grpAppDetails);
            this.Controls.Add(this.grpMakingAppointment);
            this.Controls.Add(this.grpPatientDetails);
            this.Controls.Add(this.mnuBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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