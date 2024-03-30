using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DiagnosticSYS
{
    public partial class mnuMainMenu : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oraDB);

        public mnuMainMenu()
        {
            InitializeComponent();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddService nextForm = new frmAddService();
            nextForm.Show();
        }

        private void updateService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateService nextForm = new frmUpdateService();
            nextForm.Show();
        }

        private void discontinueService_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscontinueService nextForm = new frmDiscontinueService();
            nextForm.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RegisterEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterEquipment nextForm = new frmRegisterEquipment();
            nextForm.Show();
        }

        private void DeregisterEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeregisterEquipment nextForm = new frmDeregisterEquipment();
            nextForm.Show();
        }

        private void UpdateEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateEquipment nextForm = new frmUpdateEquipment();
            nextForm.Show();
        }

        private void QueryEquipment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQueryEquipment nextForm = new frmQueryEquipment();
            nextForm.Show();
        }

        private void MakeAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeAppointment nextForm = new frmMakeAppointment();
            nextForm.Show();
        }

        private void CancelAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelAppointment nextForm = new frmCancelAppointment();
            nextForm.Show();
        }

        private void ViewDailySchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewDailySchedule nextForm = new frmViewDailySchedule();
            nextForm.Show();
        }

        private void ProcessPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProcessPayment nextForm = new frmProcessPayment();
            nextForm.Show();
        }

        private void YearlyRevenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenueAnalysis nextForm = new frmYearlyRevenueAnalysis();
            nextForm.Show();
        }

        private void YearlyDiagnostic_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyDiagnosticAnalysis nextForm = new frmYearlyDiagnosticAnalysis();
            nextForm.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                lblStatus.Text = "CLOSED";
                lblStatus.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                conn.Open();
                lblStatus.Text = "OPEN";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
