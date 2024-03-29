using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DiagnosticSYS
{
    public partial class frmUpdateEquipment : Form
    {
        mnuMainMenu parent;
        Equipment updatedEquipment;
        public frmUpdateEquipment()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
            this.updatedEquipment = new Equipment();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSearchingEquipment_Click(object sender, EventArgs e)
        {
            // Find matching equipment
            grdUpdateEquipment.DataSource = Equipment.findEquipment(txtSearchName.Text).Tables["Equipments"];

            if (grdUpdateEquipment.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtSearchName.Clear();
                txtSearchName.Focus();
                return;
            }

            grdUpdateEquipment.Visible = true;
        }

        // validation for model
        private bool IsValidModel(string model)
        {
            return !string.IsNullOrWhiteSpace(model) &&
                   model.Length <= 10 &&
                   model.All(char.IsLetterOrDigit) &&
                   model.IndexOf('-') != 0 ;
        }

        // validation for phonenumber
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.StartsWith("0");
        }

        // validation for email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email && email.Length >= 7 && email.Length <= 30;
            }
            catch
            {
                return false;
            }
        }

        private void grdEquipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the EquipmentID from the clicked row
            decimal equipmentId = Convert.ToDecimal(grdUpdateEquipment.Rows[e.RowIndex].Cells["EquipmentID"].Value);

            // Retrieve equipment information based on the EquipmentID
            updatedEquipment.getEquipment(equipmentId);

            // Display equipment information
            txtEquipmentID.Text = updatedEquipment.GetEquipmentID().ToString();
            txtEquipmentName.Text = updatedEquipment.GetEquipmentName();
            txtModel.Text = updatedEquipment.GetModel();
            txtManufacturer.Text = updatedEquipment.GetManufacturer();
            txtPhoneNumber.Text = updatedEquipment.GetManPhoneNumber().ToString();
            txtEmail.Text = updatedEquipment.GetManEmail();
            txtRoomNumber.Text = updatedEquipment.GetRoomNo().ToString();
            dtpPurchaseDate.Value = updatedEquipment.GetEqPurchaseDate();
            grpEquipmentUpdate.Visible = true;
        }

        private void btnUpdEquipment_click(object sender, EventArgs e)
        {
            // Getting data from UI
            string equipmentName = txtEquipmentName.Text;
            string model = txtModel.Text;
            string manufacturer = txtManufacturer.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            decimal roomNo = decimal.Parse(txtRoomNumber.Text);
            DateTime purchaseDate = dtpPurchaseDate.Value;

            // Validate model
            if (string.IsNullOrWhiteSpace(model) || !IsValidModel(model))
            {
                MessageBox.Show("Model must be alphanumeric and should be no more than 10 characters",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModel.Focus();
                return;
            }

            // Validate manufacturer
            if (string.IsNullOrWhiteSpace(manufacturer) || manufacturer.Any(char.IsDigit) || manufacturer.Length > 15)
            {
                MessageBox.Show("Manufacturer must not be numeric and should be no more than 15 characters",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManufacturer.Focus();
                return;
            }

            // Validate purchasedate
            if (purchaseDate == DateTime.MinValue)
            {
                MessageBox.Show("Please choose a valid Purchase Date",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpPurchaseDate.Focus();
                return;
            }

            // Validate phone number
            if (string.IsNullOrWhiteSpace(phoneNumber) || !IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Phone number must be exactly 10 characters long and start with '0'",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }

            // Validate email
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Email must be a valid format between 7 and 30 characters, including '@'",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // Update the data in the database
            updatedEquipment.SetEquipmentName(txtEquipmentName.Text);
            updatedEquipment.SetModel(txtModel.Text);
            updatedEquipment.SetManufacturer(txtManufacturer.Text);
            updatedEquipment.SetManPhoneNumber(decimal.Parse(txtPhoneNumber.Text));
            updatedEquipment.SetManEmail(txtEmail.Text);
            updatedEquipment.SetRoomNo(decimal.Parse(txtRoomNumber.Text));
            updatedEquipment.SetEqPurchaseDate(dtpPurchaseDate.Value);


            updatedEquipment.UpdateEquipment();

            MessageBox.Show("Equipment Updated in Database",
                "Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Reset UI 
            grpEquipmentUpdate.Visible = false;
            grdUpdateEquipment.Visible = false;
            txtSearchName.Clear();
            txtSearchName.Focus();

        }
    }
}
