using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;

namespace DiagnosticSYS
{
    
    public partial class frmUpdateService : Form
    {
        mnuMainMenu parent;
        Service updatedService;
        public frmUpdateService()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
            this.updatedService = new Service();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSearchingService_Click(object sender, EventArgs e)
        {
            // Find matching services
            grdServices.DataSource = Service.findServices(txtSearchName.Text).Tables["Services"];
            if (grdServices.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtSearchName.Clear();
                txtSearchName.Focus();
                return;
            }

            grdServices.Visible = true;
        }

        private void grdServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // extracting the ServiceID from column zero on the selected row in grid
            int serviceId = Convert.ToInt32(grdServices.Rows[grdServices.CurrentCell.RowIndex].Cells[0].Value.ToString());

            updatedService.getService(serviceId);

            // moving the instance variable values to the form controls
            txtServiceID.Text = updatedService.GetServiceID().ToString();
            txtServiceName.Text = updatedService.GetServiceName();
            txtServiceDescription.Text = updatedService.GetDescription();
            txtRate.Text = updatedService.GetRate().ToString();

            grpUpdateService.Visible = true;
        }

        private void btnUpdateServices(object sender, EventArgs e)
        {
            // Get data from UI
            int serviceId = Convert.ToInt32(txtServiceID.Text);
            string serviceName = txtServiceName.Text;
            string description = txtServiceDescription.Text;
            decimal rate;

            // Validate service name
            if (string.IsNullOrWhiteSpace(serviceName))
            {
                MessageBox.Show("Service Name must be entered",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceName.Focus();
                return;
            }

            if (serviceName.Length > 25 || serviceName.Any(char.IsDigit))
            {
                MessageBox.Show("Service Name must not be numeric and should be no more than 25 characters",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceName.Focus();
                return;
            }

            // Validate description
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Description must be entered",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceDescription.Focus();
                return;
            }

            if (description.Length > 50 || description.Any(char.IsDigit))
            {
                MessageBox.Show("Description must not be numeric and should be no more than 50 characters",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceDescription.Focus();
                return;
            }

            // Validate rate
            if (!decimal.TryParse(txtRate.Text, out rate) || rate <= 0)
            {
                MessageBox.Show("Rate must be a numeric value greater than 0",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }

            // Update the data in the database
            updatedService.SetServiceName(serviceName);
            updatedService.SetDescription(description);
            updatedService.SetRate(rate);

            updatedService.UpdateService();

            MessageBox.Show("Service Updated in Database",
                "Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Reset UI
            grpUpdateService.Visible = false;
            grdServices.Visible = false;
            txtSearchName.Clear();
            txtSearchName.Focus();
        }
    }
}
