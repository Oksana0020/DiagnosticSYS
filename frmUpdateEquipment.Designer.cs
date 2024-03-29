namespace DiagnosticSYS
{
    partial class frmUpdateEquipment
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
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.btnSearchingEquipment = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdUpdateEquipment = new System.Windows.Forms.DataGridView();
            this.grpEquipmentUpdate = new System.Windows.Forms.GroupBox();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEquipmentInfo = new System.Windows.Forms.Label();
            this.lblServiceInfo = new System.Windows.Forms.Label();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.mnuBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateEquipment)).BeginInit();
            this.grpEquipmentUpdate.SuspendLayout();
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
            this.mnuBack.Size = new System.Drawing.Size(800, 28);
            this.mnuBack.TabIndex = 5;
            this.mnuBack.Text = "mnuBack";
            // 
            // bACKToolStripMenuItem1
            // 
            this.bACKToolStripMenuItem1.Name = "bACKToolStripMenuItem1";
            this.bACKToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.bACKToolStripMenuItem1.Text = "BACK";
            this.bACKToolStripMenuItem1.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(261, 90);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.MaxLength = 25;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(119, 27);
            this.txtSearchName.TabIndex = 176;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(35, 94);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(151, 20);
            this.lblServiceName.TabIndex = 175;
            this.lblServiceName.Text = "Equipment Name";
            // 
            // btnSearchingEquipment
            // 
            this.btnSearchingEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearchingEquipment.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchingEquipment.Location = new System.Drawing.Point(461, 89);
            this.btnSearchingEquipment.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearchingEquipment.Name = "btnSearchingEquipment";
            this.btnSearchingEquipment.Size = new System.Drawing.Size(133, 30);
            this.btnSearchingEquipment.TabIndex = 174;
            this.btnSearchingEquipment.Text = "SEARCH";
            this.btnSearchingEquipment.UseVisualStyleBackColor = false;
            this.btnSearchingEquipment.Click += new System.EventHandler(this.btnSearchingEquipment_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(167, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 38);
            this.lblTitle.TabIndex = 173;
            this.lblTitle.Text = "Update Equipment";
            // 
            // grdUpdateEquipment
            // 
            this.grdUpdateEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateEquipment.Location = new System.Drawing.Point(27, 132);
            this.grdUpdateEquipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdUpdateEquipment.Name = "grdUpdateEquipment";
            this.grdUpdateEquipment.RowHeadersWidth = 51;
            this.grdUpdateEquipment.RowTemplate.Height = 24;
            this.grdUpdateEquipment.Size = new System.Drawing.Size(715, 165);
            this.grdUpdateEquipment.TabIndex = 177;
            this.grdUpdateEquipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEquipments_CellClick);
            // 
            // grpEquipmentUpdate
            // 
            this.grpEquipmentUpdate.Controls.Add(this.txtEquipmentID);
            this.grpEquipmentUpdate.Controls.Add(this.dtpPurchaseDate);
            this.grpEquipmentUpdate.Controls.Add(this.txtRoomNumber);
            this.grpEquipmentUpdate.Controls.Add(this.lblPurchaseDate);
            this.grpEquipmentUpdate.Controls.Add(this.lblRoomNumber);
            this.grpEquipmentUpdate.Controls.Add(this.txtPhoneNumber);
            this.grpEquipmentUpdate.Controls.Add(this.txtManufacturer);
            this.grpEquipmentUpdate.Controls.Add(this.lblManufacturer);
            this.grpEquipmentUpdate.Controls.Add(this.txtEmail);
            this.grpEquipmentUpdate.Controls.Add(this.lblEmail);
            this.grpEquipmentUpdate.Controls.Add(this.lblEquipmentID);
            this.grpEquipmentUpdate.Controls.Add(this.lblPhone);
            this.grpEquipmentUpdate.Controls.Add(this.txtModel);
            this.grpEquipmentUpdate.Controls.Add(this.lblModel);
            this.grpEquipmentUpdate.Controls.Add(this.txtEquipmentName);
            this.grpEquipmentUpdate.Controls.Add(this.label2);
            this.grpEquipmentUpdate.Controls.Add(this.label1);
            this.grpEquipmentUpdate.Controls.Add(this.lblEquipmentInfo);
            this.grpEquipmentUpdate.Controls.Add(this.lblServiceInfo);
            this.grpEquipmentUpdate.Controls.Add(this.btnUpdateEquipment);
            this.grpEquipmentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEquipmentUpdate.Location = new System.Drawing.Point(27, 318);
            this.grpEquipmentUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEquipmentUpdate.Name = "grpEquipmentUpdate";
            this.grpEquipmentUpdate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEquipmentUpdate.Size = new System.Drawing.Size(715, 335);
            this.grpEquipmentUpdate.TabIndex = 178;
            this.grpEquipmentUpdate.TabStop = false;
            this.grpEquipmentUpdate.Text = "Update Equipment";
            this.grpEquipmentUpdate.Visible = false;
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.Location = new System.Drawing.Point(179, 58);
            this.txtEquipmentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentID.MaxLength = 2;
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.Size = new System.Drawing.Size(39, 27);
            this.txtEquipmentID.TabIndex = 184;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(512, 142);
            this.dtpPurchaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(175, 27);
            this.dtpPurchaseDate.TabIndex = 183;
            this.dtpPurchaseDate.Value = new System.DateTime(2024, 2, 22, 0, 0, 0, 0);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(512, 94);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNumber.MaxLength = 2;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(39, 27);
            this.txtRoomNumber.TabIndex = 182;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(371, 146);
            this.lblPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(134, 20);
            this.lblPurchaseDate.TabIndex = 181;
            this.lblPurchaseDate.Text = "Purchase Date";
            this.lblPurchaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(371, 97);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomNumber.Size = new System.Drawing.Size(128, 20);
            this.lblRoomNumber.TabIndex = 180;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(179, 217);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(119, 27);
            this.txtPhoneNumber.TabIndex = 179;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(179, 174);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.txtManufacturer.MaxLength = 15;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(161, 27);
            this.txtManufacturer.TabIndex = 178;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.Location = new System.Drawing.Point(5, 177);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(120, 20);
            this.lblManufacturer.TabIndex = 177;
            this.lblManufacturer.Text = "Manufacturer";
            this.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(512, 50);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 27);
            this.txtEmail.TabIndex = 176;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(371, 58);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 175;
            this.lblEmail.Text = "Email";
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentID.Location = new System.Drawing.Point(5, 58);
            this.lblEquipmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(122, 20);
            this.lblEquipmentID.TabIndex = 174;
            this.lblEquipmentID.Text = "Equipment ID";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(5, 219);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 173;
            this.lblPhone.Text = "Phone";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(179, 132);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.MaxLength = 10;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(120, 27);
            this.txtModel.TabIndex = 172;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(5, 132);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 20);
            this.lblModel.TabIndex = 171;
            this.lblModel.Text = "Model";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(179, 95);
            this.txtEquipmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentName.MaxLength = 15;
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(161, 27);
            this.txtEquipmentName.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 169;
            this.label2.Text = "Equipment Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 168;
            // 
            // lblEquipmentInfo
            // 
            this.lblEquipmentInfo.AutoSize = true;
            this.lblEquipmentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentInfo.Location = new System.Drawing.Point(5, 38);
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
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateEquipment.Location = new System.Drawing.Point(245, 281);
            this.btnUpdateEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(148, 48);
            this.btnUpdateEquipment.TabIndex = 32;
            this.btnUpdateEquipment.Text = "Confirm";
            this.btnUpdateEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdEquipment_click);
            // 
            // frmUpdateEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.grpEquipmentUpdate);
            this.Controls.Add(this.grdUpdateEquipment);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.btnSearchingEquipment);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuBack);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUpdateEquipment";
            this.Text = "Hope Medical Diagnostic Center - [Update Equipment]";
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateEquipment)).EndInit();
            this.grpEquipmentUpdate.ResumeLayout(false);
            this.grpEquipmentUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Button btnSearchingEquipment;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdUpdateEquipment;
        private System.Windows.Forms.GroupBox grpEquipmentUpdate;
        private System.Windows.Forms.TextBox txtEquipmentID;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEquipmentInfo;
        private System.Windows.Forms.Label lblServiceInfo;
        private System.Windows.Forms.Button btnUpdateEquipment;
    }
}