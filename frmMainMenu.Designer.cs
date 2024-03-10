namespace DiagnosticSYS
{
    partial class mnuMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnuMainMenu));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.mnuRates = new System.Windows.Forms.ToolStripMenuItem();
            this.addServiceToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.updateServiceToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.discontinueServiceToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.registerEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDailyScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeYearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeYearlyDIagnosticAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 48);
            this.picMain.Margin = new System.Windows.Forms.Padding(4);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(1150, 505);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 6;
            this.picMain.TabStop = false;
            // 
            // mnuRates
            // 
            this.mnuRates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServiceToolStripMenu,
            this.updateServiceToolStripMenu,
            this.discontinueServiceToolStripMenu});
            this.mnuRates.Name = "mnuRates";
            this.mnuRates.Size = new System.Drawing.Size(76, 24);
            this.mnuRates.Text = "Services";
            // 
            // addServiceToolStripMenu
            // 
            this.addServiceToolStripMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addServiceToolStripMenu.Name = "addServiceToolStripMenu";
            this.addServiceToolStripMenu.Size = new System.Drawing.Size(221, 26);
            this.addServiceToolStripMenu.Text = "Add Service";
            this.addServiceToolStripMenu.Click += new System.EventHandler(this.addService_Click);
            // 
            // updateServiceToolStripMenu
            // 
            this.updateServiceToolStripMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.updateServiceToolStripMenu.Name = "updateServiceToolStripMenu";
            this.updateServiceToolStripMenu.Size = new System.Drawing.Size(221, 26);
            this.updateServiceToolStripMenu.Text = "Update Service";
            this.updateServiceToolStripMenu.Click += new System.EventHandler(this.updateService_Click);
            // 
            // discontinueServiceToolStripMenu
            // 
            this.discontinueServiceToolStripMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.discontinueServiceToolStripMenu.Name = "discontinueServiceToolStripMenu";
            this.discontinueServiceToolStripMenu.Size = new System.Drawing.Size(221, 26);
            this.discontinueServiceToolStripMenu.Text = "Discontinue Service";
            this.discontinueServiceToolStripMenu.Click += new System.EventHandler(this.discontinueService_Click);
            // 
            // mnuRooms
            // 
            this.mnuRooms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerEquipmentToolStripMenuItem,
            this.deRegisterEquipmentToolStripMenuItem,
            this.updateEquipmentToolStripMenuItem,
            this.queryEquipmentToolStripMenuItem});
            this.mnuRooms.Name = "mnuRooms";
            this.mnuRooms.Size = new System.Drawing.Size(95, 24);
            this.mnuRooms.Text = "Equipment";
            // 
            // registerEquipmentToolStripMenuItem
            // 
            this.registerEquipmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registerEquipmentToolStripMenuItem.Name = "registerEquipmentToolStripMenuItem";
            this.registerEquipmentToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.registerEquipmentToolStripMenuItem.Text = "Register Equipment";
            this.registerEquipmentToolStripMenuItem.Click += new System.EventHandler(this.RegisterEquipment_Click);
            // 
            // deRegisterEquipmentToolStripMenuItem
            // 
            this.deRegisterEquipmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deRegisterEquipmentToolStripMenuItem.Name = "deRegisterEquipmentToolStripMenuItem";
            this.deRegisterEquipmentToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.deRegisterEquipmentToolStripMenuItem.Text = "De-Register Equipment";
            this.deRegisterEquipmentToolStripMenuItem.Click += new System.EventHandler(this.DeregisterEquipment_Click);
            // 
            // updateEquipmentToolStripMenuItem
            // 
            this.updateEquipmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.updateEquipmentToolStripMenuItem.Name = "updateEquipmentToolStripMenuItem";
            this.updateEquipmentToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.updateEquipmentToolStripMenuItem.Text = "Update Equipment";
            this.updateEquipmentToolStripMenuItem.Click += new System.EventHandler(this.UpdateEquipment_Click);
            // 
            // queryEquipmentToolStripMenuItem
            // 
            this.queryEquipmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.queryEquipmentToolStripMenuItem.Name = "queryEquipmentToolStripMenuItem";
            this.queryEquipmentToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.queryEquipmentToolStripMenuItem.Text = "Query Equipment";
            this.queryEquipmentToolStripMenuItem.Click += new System.EventHandler(this.QueryEquipment_Click);
            // 
            // mnuBookings
            // 
            this.mnuBookings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAppointmentToolStripMenuItem,
            this.cancelAppointmentToolStripMenuItem,
            this.viewDailyScheduleToolStripMenuItem,
            this.processPaymentToolStripMenuItem});
            this.mnuBookings.Name = "mnuBookings";
            this.mnuBookings.Size = new System.Drawing.Size(117, 24);
            this.mnuBookings.Text = "Appointments";
            // 
            // makeAppointmentToolStripMenuItem
            // 
            this.makeAppointmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.makeAppointmentToolStripMenuItem.Name = "makeAppointmentToolStripMenuItem";
            this.makeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.makeAppointmentToolStripMenuItem.Text = "Make Appointment";
            this.makeAppointmentToolStripMenuItem.Click += new System.EventHandler(this.MakeAppointment_Click);
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            this.cancelAppointmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
            this.cancelAppointmentToolStripMenuItem.Click += new System.EventHandler(this.CancelAppointment_Click);
            // 
            // viewDailyScheduleToolStripMenuItem
            // 
            this.viewDailyScheduleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.viewDailyScheduleToolStripMenuItem.Name = "viewDailyScheduleToolStripMenuItem";
            this.viewDailyScheduleToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.viewDailyScheduleToolStripMenuItem.Text = "View Daily Schedule";
            this.viewDailyScheduleToolStripMenuItem.Click += new System.EventHandler(this.ViewDailySchedule_Click);
            // 
            // processPaymentToolStripMenuItem
            // 
            this.processPaymentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.processPaymentToolStripMenuItem.Name = "processPaymentToolStripMenuItem";
            this.processPaymentToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.processPaymentToolStripMenuItem.Text = "Process Payment";
            this.processPaymentToolStripMenuItem.Click += new System.EventHandler(this.ProcessPayment_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeYearlyRevenueAnalysisToolStripMenuItem,
            this.makeYearlyDIagnosticAnalysisToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // makeYearlyRevenueAnalysisToolStripMenuItem
            // 
            this.makeYearlyRevenueAnalysisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.makeYearlyRevenueAnalysisToolStripMenuItem.Name = "makeYearlyRevenueAnalysisToolStripMenuItem";
            this.makeYearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.makeYearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            this.makeYearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.YearlyRevenue_Click);
            // 
            // makeYearlyDIagnosticAnalysisToolStripMenuItem
            // 
            this.makeYearlyDIagnosticAnalysisToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.makeYearlyDIagnosticAnalysisToolStripMenuItem.Name = "makeYearlyDIagnosticAnalysisToolStripMenuItem";
            this.makeYearlyDIagnosticAnalysisToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.makeYearlyDIagnosticAnalysisToolStripMenuItem.Text = "Yearly DIagnostic Analysis";
            this.makeYearlyDIagnosticAnalysisToolStripMenuItem.Click += new System.EventHandler(this.YearlyDiagnostic_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRooms,
            this.mnuRates,
            this.mnuBookings,
            this.mnuExit,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1150, 28);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(524, 413);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(277, 36);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect/Disconnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(632, 471);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 16);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "CLOSED";
            // 
            // mnuMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1150, 589);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "mnuMainMenu";
            this.Text = "Hope Medical Diagnostic Center - [Main Menu]";
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.ToolStripMenuItem mnuRates;
        private System.Windows.Forms.ToolStripMenuItem addServiceToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem updateServiceToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem discontinueServiceToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuRooms;
        private System.Windows.Forms.ToolStripMenuItem registerEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deRegisterEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBookings;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDailyScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeYearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeYearlyDIagnosticAnalysisToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
    }
}

