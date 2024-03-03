namespace DiagnosticSYS
{
    partial class frmQueryEquipment
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
            this.grpEquipmentDetails = new System.Windows.Forms.GroupBox();
            this.btnQueryEquipmentOK = new System.Windows.Forms.Button();
            this.lblEquipmentInfo = new System.Windows.Forms.Label();
            this.btnQueryEquipment = new System.Windows.Forms.Button();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdQueryEquipment = new System.Windows.Forms.DataGridView();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.lblEqName = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.mnuBack.SuspendLayout();
            this.grpEquipmentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryEquipment)).BeginInit();
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
            this.mnuBack.TabIndex = 6;
            this.mnuBack.Text = "mnuBack";
            // 
            // bACKToolStripMenuItem1
            // 
            this.bACKToolStripMenuItem1.Name = "bACKToolStripMenuItem1";
            this.bACKToolStripMenuItem1.Size = new System.Drawing.Size(60, 26);
            this.bACKToolStripMenuItem1.Text = "BACK";
            this.bACKToolStripMenuItem1.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpEquipmentDetails
            // 
            this.grpEquipmentDetails.Controls.Add(this.lblPurchaseDate);
            this.grpEquipmentDetails.Controls.Add(this.lblRoomNumber);
            this.grpEquipmentDetails.Controls.Add(this.lblEmail);
            this.grpEquipmentDetails.Controls.Add(this.lblPhoneNumber);
            this.grpEquipmentDetails.Controls.Add(this.lblManufacturer);
            this.grpEquipmentDetails.Controls.Add(this.lblModel);
            this.grpEquipmentDetails.Controls.Add(this.lblEqName);
            this.grpEquipmentDetails.Controls.Add(this.lblEquipmentID);
            this.grpEquipmentDetails.Controls.Add(this.btnQueryEquipmentOK);
            this.grpEquipmentDetails.Controls.Add(this.lblEquipmentInfo);
            this.grpEquipmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEquipmentDetails.Location = new System.Drawing.Point(104, 313);
            this.grpEquipmentDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpEquipmentDetails.Name = "grpEquipmentDetails";
            this.grpEquipmentDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpEquipmentDetails.Size = new System.Drawing.Size(590, 353);
            this.grpEquipmentDetails.TabIndex = 137;
            this.grpEquipmentDetails.TabStop = false;
            this.grpEquipmentDetails.Text = "Equipment Details";
            this.grpEquipmentDetails.Visible = false;
            // 
            // btnQueryEquipmentOK
            // 
            this.btnQueryEquipmentOK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnQueryEquipmentOK.Location = new System.Drawing.Point(419, 286);
            this.btnQueryEquipmentOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryEquipmentOK.Name = "btnQueryEquipmentOK";
            this.btnQueryEquipmentOK.Size = new System.Drawing.Size(123, 35);
            this.btnQueryEquipmentOK.TabIndex = 144;
            this.btnQueryEquipmentOK.Text = "OK";
            this.btnQueryEquipmentOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQueryEquipmentOK.UseVisualStyleBackColor = true;
            this.btnQueryEquipmentOK.Click += new System.EventHandler(this.btnQueryEquipmentOK_Click);
            // 
            // lblEquipmentInfo
            // 
            this.lblEquipmentInfo.AutoSize = true;
            this.lblEquipmentInfo.Location = new System.Drawing.Point(17, 32);
            this.lblEquipmentInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentInfo.Name = "lblEquipmentInfo";
            this.lblEquipmentInfo.Size = new System.Drawing.Size(0, 20);
            this.lblEquipmentInfo.TabIndex = 143;
            // 
            // btnQueryEquipment
            // 
            this.btnQueryEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQueryEquipment.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueryEquipment.Location = new System.Drawing.Point(547, 73);
            this.btnQueryEquipment.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnQueryEquipment.Name = "btnQueryEquipment";
            this.btnQueryEquipment.Size = new System.Drawing.Size(133, 29);
            this.btnQueryEquipment.TabIndex = 148;
            this.btnQueryEquipment.Text = "SEARCH";
            this.btnQueryEquipment.UseVisualStyleBackColor = false;
            this.btnQueryEquipment.Click += new System.EventHandler(this.btnQueryEquipment_Click);
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(348, 80);
            this.txtEquipmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentName.MaxLength = 25;
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(119, 22);
            this.txtEquipmentName.TabIndex = 147;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(145, 82);
            this.lblEquipmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(151, 20);
            this.lblEquipmentName.TabIndex = 146;
            this.lblEquipmentName.Text = "Equipment Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(273, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 38);
            this.lblTitle.TabIndex = 145;
            this.lblTitle.Text = "Query Equipment";
            // 
            // grdQueryEquipment
            // 
            this.grdQueryEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQueryEquipment.Location = new System.Drawing.Point(42, 128);
            this.grdQueryEquipment.Name = "grdQueryEquipment";
            this.grdQueryEquipment.RowHeadersWidth = 51;
            this.grdQueryEquipment.RowTemplate.Height = 24;
            this.grdQueryEquipment.Size = new System.Drawing.Size(715, 165);
            this.grdQueryEquipment.TabIndex = 178;
            this.grdQueryEquipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdQueryEquipment_CellClick);
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Location = new System.Drawing.Point(24, 32);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(116, 20);
            this.lblEquipmentID.TabIndex = 145;
            this.lblEquipmentID.Text = "EquipmentID";
            // 
            // lblEqName
            // 
            this.lblEqName.AutoSize = true;
            this.lblEqName.Location = new System.Drawing.Point(24, 67);
            this.lblEqName.Name = "lblEqName";
            this.lblEqName.Size = new System.Drawing.Size(145, 20);
            this.lblEqName.TabIndex = 146;
            this.lblEqName.Text = "EquipmentName";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(24, 100);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 20);
            this.lblModel.TabIndex = 147;
            this.lblModel.Text = "Model";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(24, 137);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(120, 20);
            this.lblManufacturer.TabIndex = 148;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(24, 168);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(126, 20);
            this.lblPhoneNumber.TabIndex = 149;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 199);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 150;
            this.lblEmail.Text = "Email";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(24, 229);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(128, 20);
            this.lblRoomNumber.TabIndex = 151;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(24, 262);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(128, 20);
            this.lblPurchaseDate.TabIndex = 152;
            this.lblPurchaseDate.Text = "PurchaseDate";
            // 
            // frmQueryEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.grdQueryEquipment);
            this.Controls.Add(this.btnQueryEquipment);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpEquipmentDetails);
            this.Controls.Add(this.mnuBack);
            this.Name = "frmQueryEquipment";
            this.Text = "Hope Medical Diagnostic Center - [Query Equipment]";
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.grpEquipmentDetails.ResumeLayout(false);
            this.grpEquipmentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpEquipmentDetails;
        private System.Windows.Forms.Label lblEquipmentInfo;
        private System.Windows.Forms.Button btnQueryEquipment;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQueryEquipmentOK;
        private System.Windows.Forms.DataGridView grdQueryEquipment;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblEqName;
    }
}