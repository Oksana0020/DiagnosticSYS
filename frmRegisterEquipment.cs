using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace DiagnosticSYS
{
    public partial class frmRegisterEquipment : Form
    {
        mnuMainMenu parent;
        public frmRegisterEquipment()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
        }

        private void mnuBack_CLick(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRegisterEquipment_Load(object sender, EventArgs e)
        {

            // Get next Service ID
            txtEquipmentID.Text = Equipment.getNextEquipmentID().ToString("000");
            // Load room numbers into cboRoomNumber combo box
            Utility.LoadRoomNumbers(cboRoomNumber);
        }


        private void btnRegisterNewEquipment(object sender, EventArgs e)
        {
            // Validate if all fields are entered
            if (string.IsNullOrWhiteSpace(txtEquipmentName.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtManufacturer.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cboRoomNumber.SelectedItem == null)
            {
                MessageBox.Show("All fields must be entered!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validate if fields are not numeric
            if (txtEquipmentName.Text.Length > 15 || txtEquipmentName.Text.All(IsNumeric))
            {
                MessageBox.Show("Equipment Name cannot be numeric and should be no more than 15 characters",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEquipmentName.Focus();
                return;
            }

            if (txtManufacturer.Text.Length > 15 || txtManufacturer.Text.All(IsNumeric))
            {
                MessageBox.Show("Manufacturer must not be numeric and no more than 15 characters long!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtManufacturer.Focus();
                return;
            }

            // Validate Model
            string model = txtModel.Text;
            string modelPattern = @"^[a-zA-Z0-9]+(-[a-zA-Z0-9]+)?$";

            if (!Regex.IsMatch(model, modelPattern) || model.Length > 10)
            {
                MessageBox.Show("Model must be alphanumeric. The length has to be no more than 10 characters", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtModel.Focus();
                return;
            }

            // Validate Phone number
            string phoneNumber = txtPhoneNumber.Text;

            if (phoneNumber.Length != 10 || !phoneNumber.StartsWith("0") || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be valid format: be exactly 10 characters long, begin with 0",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }

            // Validate Email
            string email = txtEmail.Text;
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,10}$";

            if (!Regex.IsMatch(email, emailPattern) || email.Length < 7 || email.Length > 30)
            {
                MessageBox.Show("Email must be valid format between 7 and 30 characters, must contain @ symbol!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // Create an instance of Equipment
            Equipment equipment = new Equipment(Convert.ToDecimal(txtEquipmentID.Text),txtEquipmentName.Text,txtModel.Text,txtManufacturer.Text,Convert.ToDecimal(txtPhoneNumber.Text), 
            txtEmail.Text,Convert.ToDecimal(cboRoomNumber.SelectedItem.ToString()), dtpPurchaseDate.Value,"A");

            equipment.RegisterEquipment();

            MessageBox.Show("New Equipment has been registered in Database",
                            "Success!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Reset UI
            txtEquipmentID.Text = Equipment.getNextEquipmentID().ToString("000");
            txtEquipmentName.Clear();
            txtModel.Clear();
            txtManufacturer.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            cboRoomNumber.SelectedItem = null;
            dtpPurchaseDate.Value = DateTime.Now;
            txtEquipmentName.Focus();
        }

            private bool IsNumeric(char c)
        {
            return char.IsDigit(c);
        }
    }
}
