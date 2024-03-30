namespace DiagnosticSYS
{
    partial class frmViewDailySchedule
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
            this.groupBoxDailySchedule = new System.Windows.Forms.GroupBox();
            this.cboServiceName = new System.Windows.Forms.ComboBox();
            this.groDailySchedule = new System.Windows.Forms.GroupBox();
            this.grdSchedule = new System.Windows.Forms.DataGridView();
            this.lblNotificationSent = new System.Windows.Forms.Label();
            this.txtDailySchedule = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.lblScheduleDate = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.mnuBack.SuspendLayout();
            this.groupBoxDailySchedule.SuspendLayout();
            this.groDailySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSchedule)).BeginInit();
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
            // groupBoxDailySchedule
            // 
            this.groupBoxDailySchedule.Controls.Add(this.cboServiceName);
            this.groupBoxDailySchedule.Controls.Add(this.groDailySchedule);
            this.groupBoxDailySchedule.Controls.Add(this.cboFilter);
            this.groupBoxDailySchedule.Controls.Add(this.label1);
            this.groupBoxDailySchedule.Controls.Add(this.btnViewSchedule);
            this.groupBoxDailySchedule.Controls.Add(this.dtmDate);
            this.groupBoxDailySchedule.Controls.Add(this.lblScheduleDate);
            this.groupBoxDailySchedule.Controls.Add(this.lblServiceName);
            this.groupBoxDailySchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDailySchedule.Location = new System.Drawing.Point(111, 47);
            this.groupBoxDailySchedule.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDailySchedule.Name = "groupBoxDailySchedule";
            this.groupBoxDailySchedule.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDailySchedule.Size = new System.Drawing.Size(616, 392);
            this.groupBoxDailySchedule.TabIndex = 140;
            this.groupBoxDailySchedule.TabStop = false;
            this.groupBoxDailySchedule.Text = "View Daily Schedule";
            // 
            // cboServiceName
            // 
            this.cboServiceName.FormattingEnabled = true;
            this.cboServiceName.Items.AddRange(new object[] {
            "MRI",
            "CT",
            "XRay",
            "Doplerography",
            "Ultrasound"});
            this.cboServiceName.Location = new System.Drawing.Point(328, 88);
            this.cboServiceName.Name = "cboServiceName";
            this.cboServiceName.Size = new System.Drawing.Size(141, 28);
            this.cboServiceName.TabIndex = 164;
            this.cboServiceName.Visible = false;
            // 
            // groDailySchedule
            // 
            this.groDailySchedule.Controls.Add(this.grdSchedule);
            this.groDailySchedule.Controls.Add(this.lblNotificationSent);
            this.groDailySchedule.Controls.Add(this.txtDailySchedule);
            this.groDailySchedule.Location = new System.Drawing.Point(0, 163);
            this.groDailySchedule.Name = "groDailySchedule";
            this.groDailySchedule.Size = new System.Drawing.Size(664, 264);
            this.groDailySchedule.TabIndex = 163;
            this.groDailySchedule.TabStop = false;
            this.groDailySchedule.Text = "Daily Schedule";
            this.groDailySchedule.Visible = false;
            // 
            // grdSchedule
            // 
            this.grdSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSchedule.Location = new System.Drawing.Point(6, 23);
            this.grdSchedule.Name = "grdSchedule";
            this.grdSchedule.RowHeadersWidth = 51;
            this.grdSchedule.RowTemplate.Height = 24;
            this.grdSchedule.Size = new System.Drawing.Size(582, 216);
            this.grdSchedule.TabIndex = 160;
            // 
            // lblNotificationSent
            // 
            this.lblNotificationSent.AutoSize = true;
            this.lblNotificationSent.Location = new System.Drawing.Point(34, 227);
            this.lblNotificationSent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationSent.Name = "lblNotificationSent";
            this.lblNotificationSent.Size = new System.Drawing.Size(285, 20);
            this.lblNotificationSent.TabIndex = 159;
            this.lblNotificationSent.Text = "Notification is sent to the patient";
            this.lblNotificationSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDailySchedule
            // 
            this.txtDailySchedule.AutoSize = true;
            this.txtDailySchedule.Location = new System.Drawing.Point(7, 23);
            this.txtDailySchedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDailySchedule.Name = "txtDailySchedule";
            this.txtDailySchedule.Size = new System.Drawing.Size(14, 20);
            this.txtDailySchedule.TabIndex = 141;
            this.txtDailySchedule.Text = ".";
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "Service Name",
            "Date"});
            this.cboFilter.Location = new System.Drawing.Point(328, 19);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(160, 28);
            this.cboFilter.TabIndex = 162;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 161;
            this.label1.Text = "Please choose filter";
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(151, 126);
            this.btnViewSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(218, 32);
            this.btnViewSchedule.TabIndex = 160;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // dtmDate
            // 
            this.dtmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDate.Location = new System.Drawing.Point(328, 64);
            this.dtmDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(135, 22);
            this.dtmDate.TabIndex = 154;
            this.dtmDate.Value = new System.DateTime(2023, 11, 28, 0, 0, 0, 0);
            this.dtmDate.Visible = false;
            // 
            // lblScheduleDate
            // 
            this.lblScheduleDate.AutoSize = true;
            this.lblScheduleDate.Location = new System.Drawing.Point(23, 66);
            this.lblScheduleDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScheduleDate.Name = "lblScheduleDate";
            this.lblScheduleDate.Size = new System.Drawing.Size(276, 20);
            this.lblScheduleDate.TabIndex = 144;
            this.lblScheduleDate.Text = "Choose Date to check schedule";
            this.lblScheduleDate.Visible = false;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(23, 96);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(195, 20);
            this.lblServiceName.TabIndex = 142;
            this.lblServiceName.Text = "Choose Service Name";
            this.lblServiceName.Visible = false;
            // 
            // frmViewDailySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDailySchedule);
            this.Controls.Add(this.mnuBack);
            this.Name = "frmViewDailySchedule";
            this.Text = "Hope Medical Diagnostic Center - [View Daily Schedule]";
            this.mnuBack.ResumeLayout(false);
            this.mnuBack.PerformLayout();
            this.groupBoxDailySchedule.ResumeLayout(false);
            this.groupBoxDailySchedule.PerformLayout();
            this.groDailySchedule.ResumeLayout(false);
            this.groDailySchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBack;
        private System.Windows.Forms.ToolStripMenuItem bACKToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBoxDailySchedule;
        private System.Windows.Forms.Label lblNotificationSent;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.Label lblScheduleDate;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label txtDailySchedule;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groDailySchedule;
        private System.Windows.Forms.DataGridView grdSchedule;
        private System.Windows.Forms.ComboBox cboServiceName;
    }
}