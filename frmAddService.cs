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
    public partial class frmAddService : Form
    {
        mnuMainMenu parent;
        public frmAddService()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAddService_Load(object sender, EventArgs e)
        {
            grpAddService.Visible = true;

            // Get next Service ID
            txtServiceID.Text = Service.GetNextServiceID().ToString("00");
            // Load equipment names into cboEquipment combo box
            Utility.LoadEquipmentNames(cboEquipment);
        }


        private void btnAddService_Click(object sender, EventArgs e)
        {
            // Validate if all fields are entered
            if (string.IsNullOrWhiteSpace(txtServiceName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtRate.Text) ||
                cboEquipment.SelectedItem == null)
            {
                MessageBox.Show("All fields must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Service Name must be entered",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceName.Focus();
                return;
            }

            if (txtServiceName.Text.Length > 25 || txtServiceName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Service Name must not be numeric and should be no more than 25 characters",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description must be entered",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            if (txtDescription.Text.Length > 50 || txtDescription.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Description must not be numeric and should be no more than 50 characters",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            decimal rate;
            if (!decimal.TryParse(txtRate.Text, out rate) || rate <= 0)
            {
                MessageBox.Show("Rate must be a numeric value greater than 0",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }

            //getting the selected equipment name and corresponding equipment ID
            string selectedEquipmentName = cboEquipment.SelectedItem.ToString();
            //int equipmentID = Equipment.GetEquipmentIDByName(selectedEquipmentName);
            // Extract ServiceID and parse it to an integer
            int equipmentID = int.Parse(selectedEquipmentName.Substring(0, 3));
            //Create an instance of Service
            Service newService = new Service(Convert.ToInt32(txtServiceID.Text), txtServiceName.Text, txtDescription.Text,
            rate, "A", equipmentID);

            // Invoke the method to add the data to the Services table
            newService.AddService();

            MessageBox.Show($"Service {txtServiceID.Text} added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI
            //grpAddService.Visible = false;
            txtServiceID.Text = Service.GetNextServiceID().ToString("00");
            txtServiceName.Clear();
            txtDescription.Clear();
            txtRate.Text = "0.00";
            cboEquipment.SelectedItem = null;
            txtServiceName.Focus();
        }

    }
}
