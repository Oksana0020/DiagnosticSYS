namespace DiagnosticSYS
{
    partial class frmRegisterEquipment
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.btnRegisterEquipment = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.cboRoomNumber = new System.Windows.Forms.ComboBox();
            this.mnuBack.SuspendLayout();
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
            this.mnuBack.TabIndex = 3;
            this.mnuBack.Text = "mnuBack";
            // 
            // bACKToolStripMenuItem1
            // 
            this.bACKToolStripMenuItem1.Name = "bACKToolStripMenuItem1";
            this.bACKToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.bACKToolStripMenuItem1.Text = "BACK";
            this.bACKToolStripMenuItem1.Click += new System.EventHandler(this.mnuBack_CLick);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(581, 89);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 22);
            this.txtEmail.TabIndex = 36;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(408, 94);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email";
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentID.Location = new System.Drawing.Point(43, 94);
            this.lblEquipmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(122, 20);
            this.lblEquipmentID.TabIndex = 33;
            this.lblEquipmentID.Text = "Equipment ID";
            // 
            // btnRegisterEquipment
            // 
            this.btnRegisterEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterEquipment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegisterEquipment.Location = new System.Drawing.Point(245, 364);
            this.btnRegisterEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterEquipment.Name = "btnRegisterEquipment";
            this.btnRegisterEquipment.Size = new System.Drawing.Size(264, 48);
            this.btnRegisterEquipment.TabIndex = 32;
            this.btnRegisterEquipment.Text = "Register Equipment";
            this.btnRegisterEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegisterEquipment.UseVisualStyleBackColor = true;
            this.btnRegisterEquipment.Click += new System.EventHandler(this.btnRegisterNewEquipment);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(43, 255);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 30;
            this.lblPhone.Text = "Phone";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(215, 168);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.MaxLength = 10;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(120, 22);
            this.txtModel.TabIndex = 29;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(43, 168);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 20);
            this.lblModel.TabIndex = 28;
            this.lblModel.Text = "Model";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(215, 131);
            this.txtEquipmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentName.MaxLength = 15;
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(161, 22);
            this.txtEquipmentName.TabIndex = 27;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(43, 131);
            this.lblEquipmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(151, 20);
            this.lblEquipmentName.TabIndex = 26;
            this.lblEquipmentName.Text = "Equipment Name";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(215, 209);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.txtManufacturer.MaxLength = 15;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(161, 22);
            this.txtManufacturer.TabIndex = 38;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.Location = new System.Drawing.Point(43, 213);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(120, 20);
            this.lblManufacturer.TabIndex = 37;
            this.lblManufacturer.Text = "Manufacturer";
            this.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(215, 253);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(118, 22);
            this.txtPhoneNumber.TabIndex = 39;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(408, 183);
            this.lblPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(134, 20);
            this.lblPurchaseDate.TabIndex = 43;
            this.lblPurchaseDate.Text = "Purchase Date";
            this.lblPurchaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(408, 133);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomNumber.Size = new System.Drawing.Size(128, 20);
            this.lblRoomNumber.TabIndex = 40;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 38);
            this.lblTitle.TabIndex = 80;
            this.lblTitle.Text = "Register Equipment";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(581, 178);
            this.dtpPurchaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(175, 27);
            this.dtpPurchaseDate.TabIndex = 81;
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.Location = new System.Drawing.Point(248, 94);
            this.txtEquipmentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentID.MaxLength = 2;
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.Size = new System.Drawing.Size(38, 22);
            this.txtEquipmentID.TabIndex = 82;
            // 
            // cboRoomNumber
            // 
            this.cboRoomNumber.FormattingEnabled = true;
            this.cboRoomNumber.Location = new System.Drawing.Point(646, 132);
            this.cboRoomNumber.Name = "cboRoomNumber";
            this.cboRoomNumber.Size = new System.Drawing.Size(62, 24);
            this.cboRoomNumber.TabIndex = 83;
            // 
            // frmRegisterEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboRoomNumber);
            this.Controls.Add(this.txtEquipmentID);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEquipmentID);
            this.Controls.Add(this.btnRegisterEquipment);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.mnuBack);
            this.Name = "frmRegisterEquipment";
            this.Text = "frmRegisterEquipment";
            this.Load += new System.EventHandler(this.frmRegisterEquipment_Load);
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Button btnRegisterEquipment;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.TextBox txtEquipmentID;
        private System.Windows.Forms.ComboBox cboRoomNumber;
    }
}