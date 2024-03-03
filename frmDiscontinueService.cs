using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnosticSYS
{
    public partial class frmDiscontinueService : Form
    {
        mnuMainMenu parent;
        Service discontinuedService;
        public frmDiscontinueService()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
            this.discontinuedService = new Service();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnServiceSearch(object sender, EventArgs e)
        {
            // Find matching services
            grdDiscontinueServices.DataSource = Service.findServices(txtServiceName.Text).Tables["Services"];

            if (grdDiscontinueServices.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtServiceName.Clear();
                txtServiceName.Focus();
                return;
            }

            grdDiscontinueServices.Visible = true;
        }

        private void grdDiscontinueServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int serviceId = Convert.ToInt32(grdDiscontinueServices.Rows[grdDiscontinueServices.CurrentCell.RowIndex].Cells[0].Value.ToString());

            discontinuedService.getService(serviceId);

            txtServiceID.Text = discontinuedService.GetServiceID().ToString();
            txtServiceName.Text = discontinuedService.GetServiceName();
            txtServiceDescription.Text = discontinuedService.GetDescription();
            txtRate.Text = discontinuedService.GetRate().ToString();

            grpServiceInfo.Visible = true;
        }


        private void btnConfirmDiscontinue_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discontinue this service?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                discontinuedService.DiscontinueService();

                MessageBox.Show("Service Discontinued in Database",
                    "Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Reset UI
                grpServiceInfo.Visible = false;
                grdDiscontinueServices.Visible = false;
                txtServiceName.Clear();
                txtServiceName.Focus();
            }
        }
    }
}

