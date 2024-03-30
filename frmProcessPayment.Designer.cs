namespace DiagnosticSYS
{
    partial class frmProcessPayment
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
            this.groProcessPayment = new System.Windows.Forms.GroupBox();
            this.cboAppointmentID = new System.Windows.Forms.ComboBox();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.cboServiceName = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblAnotherService = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblPatientSur = new System.Windows.Forms.Label();
            this.txtTransactionID = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.groPaymentDetails = new System.Windows.Forms.GroupBox();
            this.chkConfirmAge = new System.Windows.Forms.CheckBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCCV = new System.Windows.Forms.TextBox();
            this.lblCcv = new System.Windows.Forms.Label();
            this.txtCardholderSurname = new System.Windows.Forms.TextBox();
            this.lblCardholderSurname = new System.Windows.Forms.Label();
            this.txtCardholderForename = new System.Windows.Forms.TextBox();
            this.lblCardholderForename = new System.Windows.Forms.Label();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.mnuBack.SuspendLayout();
            this.groProcessPayment.SuspendLayout();
            this.groPaymentDetails.SuspendLayout();
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
            this.mnuBack.TabIndex = 9;
            this.mnuBack.Text = "mnuBack";
            // 
            // bACKToolStripMenuItem1
            // 
            this.bACKToolStripMenuItem1.Name = "bACKToolStripMenuItem1";
            this.bACKToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.bACKToolStripMenuItem1.Text = "BACK";
            this.bACKToolStripMenuItem1.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // groProcessPayment
            // 
            this.groProcessPayment.Controls.Add(this.cboAppointmentID);
            this.groProcessPayment.Controls.Add(this.lblAppointmentID);
            this.groProcessPayment.Controls.Add(this.btnNo);
            this.groProcessPayment.Controls.Add(this.cboServiceName);
            this.groProcessPayment.Controls.Add(this.txtTotal);
            this.groProcessPayment.Controls.Add(this.lblServiceName);
            this.groProcessPayment.Controls.Add(this.lblAnotherService);
            this.groProcessPayment.Controls.Add(this.lblTotal);
            this.groProcessPayment.Controls.Add(this.txtRate);
            this.groProcessPayment.Controls.Add(this.lblRate);
            this.groProcessPayment.Controls.Add(this.btnYes);
            this.groProcessPayment.Controls.Add(this.txtServiceName);
            this.groProcessPayment.Controls.Add(this.lblPatientSur);
            this.groProcessPayment.Controls.Add(this.txtTransactionID);
            this.groProcessPayment.Controls.Add(this.lblTransactionID);
            this.groProcessPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groProcessPayment.Location = new System.Drawing.Point(26, 29);
            this.groProcessPayment.Margin = new System.Windows.Forms.Padding(2);
            this.groProcessPayment.Name = "groProcessPayment";
            this.groProcessPayment.Padding = new System.Windows.Forms.Padding(2);
            this.groProcessPayment.Size = new System.Drawing.Size(397, 392);
            this.groProcessPayment.TabIndex = 140;
            this.groProcessPayment.TabStop = false;
            this.groProcessPayment.Text = "ProcessPayment";
            // 
            // cboAppointmentID
            // 
            this.cboAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAppointmentID.FormattingEnabled = true;
            this.cboAppointmentID.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.cboAppointmentID.Location = new System.Drawing.Point(178, 97);
            this.cboAppointmentID.Margin = new System.Windows.Forms.Padding(2);
            this.cboAppointmentID.Name = "cboAppointmentID";
            this.cboAppointmentID.Size = new System.Drawing.Size(121, 24);
            this.cboAppointmentID.TabIndex = 160;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(6, 96);
            this.lblAppointmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(138, 20);
            this.lblAppointmentID.TabIndex = 159;
            this.lblAppointmentID.Text = "Appointment ID";
            // 
            // btnNo
            // 
            this.btnNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNo.Location = new System.Drawing.Point(192, 334);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(73, 28);
            this.btnNo.TabIndex = 156;
            this.btnNo.Text = "No";
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // cboServiceName
            // 
            this.cboServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServiceName.FormattingEnabled = true;
            this.cboServiceName.Items.AddRange(new object[] {
            "MRI",
            "CT"});
            this.cboServiceName.Location = new System.Drawing.Point(180, 125);
            this.cboServiceName.Margin = new System.Windows.Forms.Padding(2);
            this.cboServiceName.Name = "cboServiceName";
            this.cboServiceName.Size = new System.Drawing.Size(121, 24);
            this.cboServiceName.TabIndex = 155;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(178, 201);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.MaxLength = 30;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(213, 27);
            this.txtTotal.TabIndex = 153;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(6, 125);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(126, 20);
            this.lblServiceName.TabIndex = 150;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblAnotherService
            // 
            this.lblAnotherService.AutoSize = true;
            this.lblAnotherService.Location = new System.Drawing.Point(38, 303);
            this.lblAnotherService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnotherService.Name = "lblAnotherService";
            this.lblAnotherService.Size = new System.Drawing.Size(339, 20);
            this.lblAnotherService.TabIndex = 149;
            this.lblAnotherService.Text = "Would you like to proceed to checkout?";
            this.lblAnotherService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 208);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 148;
            this.lblTotal.Text = "Total";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(179, 156);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.MaxLength = 15;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(161, 27);
            this.txtRate.TabIndex = 147;
            this.txtRate.Text = "200.00";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(6, 155);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(48, 20);
            this.lblRate.TabIndex = 146;
            this.lblRate.Text = "Rate";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnYes.Location = new System.Drawing.Point(84, 334);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(73, 28);
            this.btnYes.TabIndex = 145;
            this.btnYes.Text = "Yes";
            this.btnYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(180, 61);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceName.MaxLength = 15;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(161, 27);
            this.txtServiceName.TabIndex = 143;
            // 
            // lblPatientSur
            // 
            this.lblPatientSur.AutoSize = true;
            this.lblPatientSur.Location = new System.Drawing.Point(6, 64);
            this.lblPatientSur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientSur.Name = "lblPatientSur";
            this.lblPatientSur.Size = new System.Drawing.Size(148, 20);
            this.lblPatientSur.TabIndex = 142;
            this.lblPatientSur.Text = "Patient Surname";
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.AutoSize = true;
            this.txtTransactionID.Location = new System.Drawing.Point(176, 33);
            this.txtTransactionID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(29, 20);
            this.txtTransactionID.TabIndex = 141;
            this.txtTransactionID.Text = "01";
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Location = new System.Drawing.Point(6, 33);
            this.lblTransactionID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(133, 20);
            this.lblTransactionID.TabIndex = 140;
            this.lblTransactionID.Text = "Transaction ID";
            // 
            // dtmDate
            // 
            this.dtmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDate.Location = new System.Drawing.Point(166, 182);
            this.dtmDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(135, 22);
            this.dtmDate.TabIndex = 154;
            this.dtmDate.Value = new System.DateTime(2023, 11, 28, 0, 0, 0, 0);
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(12, 180);
            this.lblExpDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(139, 20);
            this.lblExpDate.TabIndex = 144;
            this.lblExpDate.Text = "Expiration Date";
            // 
            // groPaymentDetails
            // 
            this.groPaymentDetails.Controls.Add(this.chkConfirmAge);
            this.groPaymentDetails.Controls.Add(this.txtCardNumber);
            this.groPaymentDetails.Controls.Add(this.lblCardNumber);
            this.groPaymentDetails.Controls.Add(this.txtCCV);
            this.groPaymentDetails.Controls.Add(this.dtmDate);
            this.groPaymentDetails.Controls.Add(this.lblCcv);
            this.groPaymentDetails.Controls.Add(this.txtCardholderSurname);
            this.groPaymentDetails.Controls.Add(this.lblCardholderSurname);
            this.groPaymentDetails.Controls.Add(this.txtCardholderForename);
            this.groPaymentDetails.Controls.Add(this.lblCardholderForename);
            this.groPaymentDetails.Controls.Add(this.btnProcessPayment);
            this.groPaymentDetails.Controls.Add(this.lblExpDate);
            this.groPaymentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groPaymentDetails.Location = new System.Drawing.Point(442, 29);
            this.groPaymentDetails.Margin = new System.Windows.Forms.Padding(2);
            this.groPaymentDetails.Name = "groPaymentDetails";
            this.groPaymentDetails.Padding = new System.Windows.Forms.Padding(2);
            this.groPaymentDetails.Size = new System.Drawing.Size(333, 392);
            this.groPaymentDetails.TabIndex = 139;
            this.groPaymentDetails.TabStop = false;
            this.groPaymentDetails.Text = "Payment Details";
            this.groPaymentDetails.Visible = false;
            // 
            // chkConfirmAge
            // 
            this.chkConfirmAge.AutoSize = true;
            this.chkConfirmAge.Location = new System.Drawing.Point(16, 218);
            this.chkConfirmAge.Name = "chkConfirmAge";
            this.chkConfirmAge.Size = new System.Drawing.Size(260, 24);
            this.chkConfirmAge.TabIndex = 155;
            this.chkConfirmAge.Text = "Confirm you are 18 years +";
            this.chkConfirmAge.UseVisualStyleBackColor = true;
            this.chkConfirmAge.CheckedChanged += new System.EventHandler(this.chkConfirmAge_CheckedChanged);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(204, 117);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNumber.MaxLength = 30;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(123, 27);
            this.txtCardNumber.TabIndex = 139;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(12, 120);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(117, 20);
            this.lblCardNumber.TabIndex = 138;
            this.lblCardNumber.Text = "Card number";
            // 
            // txtCCV
            // 
            this.txtCCV.Location = new System.Drawing.Point(166, 149);
            this.txtCCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCV.MaxLength = 10;
            this.txtCCV.Name = "txtCCV";
            this.txtCCV.Size = new System.Drawing.Size(161, 27);
            this.txtCCV.TabIndex = 137;
            // 
            // lblCcv
            // 
            this.lblCcv.AutoSize = true;
            this.lblCcv.Location = new System.Drawing.Point(12, 149);
            this.lblCcv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCcv.Name = "lblCcv";
            this.lblCcv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCcv.Size = new System.Drawing.Size(47, 20);
            this.lblCcv.TabIndex = 134;
            this.lblCcv.Text = "CCV";
            // 
            // txtCardholderSurname
            // 
            this.txtCardholderSurname.Location = new System.Drawing.Point(204, 80);
            this.txtCardholderSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardholderSurname.MaxLength = 15;
            this.txtCardholderSurname.Name = "txtCardholderSurname";
            this.txtCardholderSurname.Size = new System.Drawing.Size(123, 27);
            this.txtCardholderSurname.TabIndex = 133;
            // 
            // lblCardholderSurname
            // 
            this.lblCardholderSurname.AutoSize = true;
            this.lblCardholderSurname.Location = new System.Drawing.Point(10, 87);
            this.lblCardholderSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardholderSurname.Name = "lblCardholderSurname";
            this.lblCardholderSurname.Size = new System.Drawing.Size(181, 20);
            this.lblCardholderSurname.TabIndex = 132;
            this.lblCardholderSurname.Text = "Cardholder Surname";
            // 
            // txtCardholderForename
            // 
            this.txtCardholderForename.Location = new System.Drawing.Point(204, 39);
            this.txtCardholderForename.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardholderForename.MaxLength = 15;
            this.txtCardholderForename.Name = "txtCardholderForename";
            this.txtCardholderForename.Size = new System.Drawing.Size(123, 27);
            this.txtCardholderForename.TabIndex = 131;
            // 
            // lblCardholderForename
            // 
            this.lblCardholderForename.AutoSize = true;
            this.lblCardholderForename.Location = new System.Drawing.Point(6, 47);
            this.lblCardholderForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardholderForename.Name = "lblCardholderForename";
            this.lblCardholderForename.Size = new System.Drawing.Size(190, 20);
            this.lblCardholderForename.TabIndex = 130;
            this.lblCardholderForename.Text = "Cardholder Forename";
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.Location = new System.Drawing.Point(58, 297);
            this.btnProcessPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(218, 32);
            this.btnProcessPayment.TabIndex = 4;
            this.btnProcessPayment.Text = "Process Payment";
            this.btnProcessPayment.UseVisualStyleBackColor = true;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click);
            // 
            // frmProcessPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groProcessPayment);
            this.Controls.Add(this.groPaymentDetails);
            this.Controls.Add(this.mnuBack);
            this.Name = "frmProcessPayment";
            this.Text = "Hope Medical Diagnostic Center - [Process Payment]";
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.groProcessPayment.ResumeLayout(false);
            this.groProcessPayment.PerformLayout();
            this.groPaymentDetails.ResumeLayout(false);
            this.groPaymentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groProcessPayment;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.ComboBox cboServiceName;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblAnotherService;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblPatientSur;
        private System.Windows.Forms.Label txtTransactionID;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.GroupBox groPaymentDetails;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCCV;
        private System.Windows.Forms.Label lblCcv;
        private System.Windows.Forms.TextBox txtCardholderSurname;
        private System.Windows.Forms.Label lblCardholderSurname;
        private System.Windows.Forms.TextBox txtCardholderForename;
        private System.Windows.Forms.Label lblCardholderForename;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.ComboBox cboAppointmentID;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.CheckBox chkConfirmAge;
    }
}