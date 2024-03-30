namespace DiagnosticSYS
{
    partial class frmDeregisterEquipment
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
            this.grpEquipmentInfo = new System.Windows.Forms.GroupBox();
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
            this.txtEquipmentNames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEquipmentInfo = new System.Windows.Forms.Label();
            this.lblServiceInfo = new System.Windows.Forms.Label();
            this.btnDiscontinueEquipment = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.grdDereqisterEquipment = new System.Windows.Forms.DataGridView();
            this.mnuBack.SuspendLayout();
            this.grpEquipmentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDereqisterEquipment)).BeginInit();
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
            this.mnuBack.TabIndex = 4;
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
            this.lblTitle.Location = new System.Drawing.Point(248, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 38);
            this.lblTitle.TabIndex = 81;
            this.lblTitle.Text = "De-Register Equipment";
            // 
            // grpEquipmentInfo
            // 
            this.grpEquipmentInfo.Controls.Add(this.txtEquipmentID);
            this.grpEquipmentInfo.Controls.Add(this.dtpPurchaseDate);
            this.grpEquipmentInfo.Controls.Add(this.txtRoomNumber);
            this.grpEquipmentInfo.Controls.Add(this.lblPurchaseDate);
            this.grpEquipmentInfo.Controls.Add(this.lblRoomNumber);
            this.grpEquipmentInfo.Controls.Add(this.txtPhoneNumber);
            this.grpEquipmentInfo.Controls.Add(this.txtManufacturer);
            this.grpEquipmentInfo.Controls.Add(this.lblManufacturer);
            this.grpEquipmentInfo.Controls.Add(this.txtEmail);
            this.grpEquipmentInfo.Controls.Add(this.lblEmail);
            this.grpEquipmentInfo.Controls.Add(this.lblEquipmentID);
            this.grpEquipmentInfo.Controls.Add(this.lblPhone);
            this.grpEquipmentInfo.Controls.Add(this.txtModel);
            this.grpEquipmentInfo.Controls.Add(this.lblModel);
            this.grpEquipmentInfo.Controls.Add(this.txtEquipmentNames);
            this.grpEquipmentInfo.Controls.Add(this.label2);
            this.grpEquipmentInfo.Controls.Add(this.label1);
            this.grpEquipmentInfo.Controls.Add(this.lblEquipmentInfo);
            this.grpEquipmentInfo.Controls.Add(this.lblServiceInfo);
            this.grpEquipmentInfo.Controls.Add(this.btnDiscontinueEquipment);
            this.grpEquipmentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEquipmentInfo.Location = new System.Drawing.Point(49, 293);
            this.grpEquipmentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpEquipmentInfo.Name = "grpEquipmentInfo";
            this.grpEquipmentInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpEquipmentInfo.Size = new System.Drawing.Size(715, 335);
            this.grpEquipmentInfo.TabIndex = 145;
            this.grpEquipmentInfo.TabStop = false;
            this.grpEquipmentInfo.Text = "De-Register Equipment";
            this.grpEquipmentInfo.Visible = false;
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.Enabled = false;
            this.txtEquipmentID.Location = new System.Drawing.Point(178, 58);
            this.txtEquipmentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentID.MaxLength = 2;
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.Size = new System.Drawing.Size(38, 27);
            this.txtEquipmentID.TabIndex = 184;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Enabled = false;
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(512, 142);
            this.dtpPurchaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(175, 27);
            this.dtpPurchaseDate.TabIndex = 183;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Enabled = false;
            this.txtRoomNumber.Location = new System.Drawing.Point(512, 94);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNumber.MaxLength = 2;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(38, 27);
            this.txtRoomNumber.TabIndex = 182;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(371, 147);
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
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(178, 217);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(118, 27);
            this.txtPhoneNumber.TabIndex = 179;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Enabled = false;
            this.txtManufacturer.Location = new System.Drawing.Point(178, 173);
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
            this.lblManufacturer.Location = new System.Drawing.Point(6, 177);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(120, 20);
            this.lblManufacturer.TabIndex = 177;
            this.lblManufacturer.Text = "Manufacturer";
            this.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(512, 51);
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
            this.lblEquipmentID.Location = new System.Drawing.Point(6, 58);
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
            this.lblPhone.Location = new System.Drawing.Point(6, 219);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 173;
            this.lblPhone.Text = "Phone";
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(178, 132);
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
            this.lblModel.Location = new System.Drawing.Point(6, 132);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 20);
            this.lblModel.TabIndex = 171;
            this.lblModel.Text = "Model";
            // 
            // txtEquipmentNames
            // 
            this.txtEquipmentNames.Enabled = false;
            this.txtEquipmentNames.Location = new System.Drawing.Point(178, 95);
            this.txtEquipmentNames.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentNames.MaxLength = 15;
            this.txtEquipmentNames.Name = "txtEquipmentNames";
            this.txtEquipmentNames.Size = new System.Drawing.Size(161, 27);
            this.txtEquipmentNames.TabIndex = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 95);
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
            // btnDiscontinueEquipment
            // 
            this.btnDiscontinueEquipment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDiscontinueEquipment.Location = new System.Drawing.Point(245, 281);
            this.btnDiscontinueEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscontinueEquipment.Name = "btnDiscontinueEquipment";
            this.btnDiscontinueEquipment.Size = new System.Drawing.Size(148, 48);
            this.btnDiscontinueEquipment.TabIndex = 32;
            this.btnDiscontinueEquipment.Text = "Discontinue";
            this.btnDiscontinueEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDiscontinueEquipment.UseVisualStyleBackColor = true;
            this.btnDiscontinueEquipment.Click += new System.EventHandler(this.btnConfirmDeregisterEq_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(522, 87);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 29);
            this.btnSearch.TabIndex = 144;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnDeregEquipmentSearch);
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(323, 94);
            this.txtEquipmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentName.MaxLength = 25;
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(119, 22);
            this.txtEquipmentName.TabIndex = 143;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(120, 96);
            this.lblEquipmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(151, 20);
            this.lblEquipmentName.TabIndex = 142;
            this.lblEquipmentName.Text = "Equipment Name";
            // 
            // grdDereqisterEquipment
            // 
            this.grdDereqisterEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDereqisterEquipment.Location = new System.Drawing.Point(49, 123);
            this.grdDereqisterEquipment.Name = "grdDereqisterEquipment";
            this.grdDereqisterEquipment.RowHeadersWidth = 51;
            this.grdDereqisterEquipment.RowTemplate.Height = 24;
            this.grdDereqisterEquipment.Size = new System.Drawing.Size(715, 165);
            this.grdDereqisterEquipment.TabIndex = 175;
            this.grdDereqisterEquipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDeregisterEquipment_CellClick);
            // 
            // frmDeregisterEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.grdDereqisterEquipment);
            this.Controls.Add(this.grpEquipmentInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuBack);
            this.Name = "frmDeregisterEquipment";
            this.Text = "Hope Medical Diagnostic Center - [De-Register Equipment]";
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.grpEquipmentInfo.ResumeLayout(false);
            this.grpEquipmentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDereqisterEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpEquipmentInfo;
        private System.Windows.Forms.Label lblServiceInfo;
        private System.Windows.Forms.Button btnDiscontinueEquipment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Label lblEquipmentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDereqisterEquipment;
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
        private System.Windows.Forms.TextBox txtEquipmentNames;
        private System.Windows.Forms.Label label2;
    }
}