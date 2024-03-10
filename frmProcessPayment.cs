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
    public partial class frmProcessPayment : Form
    {
        mnuMainMenu parent;
        public frmProcessPayment()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            groPaymentDetails.Visible = true;
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            {
                if (ValidatePaymentData())
                {
                    // If validation successful, show popup confirmation
                    MessageBox.Show("Payment confirmed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If validation fails, show error message
                    MessageBox.Show("Invalid payment data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bool ValidatePaymentData()
            {
                
                // Check if all fields are entered
                if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtCardholderForename.Text) ||
                    string.IsNullOrWhiteSpace(txtCardholderSurname.Text) ||
                    string.IsNullOrWhiteSpace(txtCCV.Text))
                {
                    return false; // Some fields are empty
                }

                // Check numeric and length criteria for CCV and CardNumber
                if (!IsNumeric(txtCCV.Text) || txtCCV.Text.Length != 3 ||
                    !IsNumeric(txtCardNumber.Text) || txtCardNumber.Text.Length != 16)
                {
                    return false; 
                }

                // Check non-numeric and length criteria for CardholderForename and CardholderSurname
                if (IsNumeric(txtCardholderForename.Text) || txtCardholderForename.Text.Length > 20 ||
                    IsNumeric(txtCardholderSurname.Text) || txtCardholderSurname.Text.Length > 30)
                {
                    return false; 
                }

                return true; 
            }

            bool IsNumeric(string input)
            {
                return int.TryParse(input, out _);
            }
        }

        private bool isAgeConfirmed = false;
        private void chkConfirmAge_CheckedChanged(object sender, EventArgs e)
        {
            isAgeConfirmed = chkConfirmAge.Checked;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            // Reset the text
            txtServiceName.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtRate.Text = string.Empty;
        }
    }
}
