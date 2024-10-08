﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static DiagnosticSYS.frmViewDailySchedule;

namespace DiagnosticSYS
{
    public partial class frmMakeAppointment : Form
    {
        mnuMainMenu parent;
        public frmMakeAppointment()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmMakeAppointment_Load_1(object sender, EventArgs e)
        {
            grpMakingAppointment.Visible = true;
            grpPatientDetails.Visible = false;
            cboEquipmentName = Utility.LoadEquipmentNames(cboEquipmentName);


            // Get next Appointment ID
            txtApptID.Text = Appointment.GetNextAppointmentID().ToString("00");

            // Load data into combo boxes
            Utility.LoadServiceNames(cboServices);
            Utility.loadDoctors(cboDoctors);

            // Disable all ComboBoxes
            //cboAppointmentTime.Enabled = false;
            cboDoctors.Enabled = false;
            cboEquipmentName.Enabled = false;

        }



        private void cboServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboServices.SelectedItem != null)
            {
                string selectedItem = cboServices.SelectedItem.ToString();

                // extracting service ID and name from the selected item
                int indexOfDash = selectedItem.IndexOf('-');
                int serviceId = int.Parse(selectedItem.Substring(0, indexOfDash).Trim());
                string serviceName = selectedItem.Substring(indexOfDash + 1).Trim();

                // Create an instance of the Appointment
                Appointment appointment = new Appointment();

                // retrieve rate of the selected service
                decimal rate = appointment.GetServiceRate(serviceName);

                // Display the rate
                txtServiceRate.Text = rate.ToString("0.00");

                grpAppDetails.Visible = true;

                LoadAvailableTimes();
            }
        }

        private void dtmDate_ValueChanged(object sender, EventArgs e)
        {
            cboAppointmentTime.Enabled = true;

        }

        private void LoadAvailableTimes()
        {
            cboAppointmentTime.Items.Clear();
            DateTime selectedDate = dtmDate.Value;
            Utility.LoadAvailableTimes(cboAppointmentTime, selectedDate);
        }

        private void cboAppointmentTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDoctors.Enabled = true;
        }

        private void cboDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEquipmentName.Enabled = true;
        }

        private void cboEquipmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpPatientDetails.Visible = true;
            txtPatientID.Text = Appointment.GetNextPatientID().ToString("00");
        }


        private void MakeAppointment_click(object sender, EventArgs e)
        {
            // Checking if all fields are entered
            if (string.IsNullOrWhiteSpace(txtPatientForename.Text) ||
                string.IsNullOrWhiteSpace(txtPatientSurname.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtReferral.Text))
            {
                MessageBox.Show("All fields must be entered.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validating PatientForename
            if (!IsAlphaOnly(txtPatientForename.Text) || txtPatientForename.Text.Length > 25)
            {
                MessageBox.Show("Patient Forename must not be numeric and should be no more than 25 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validating PatientSurname
            if (!IsAlphaOnly(txtPatientSurname.Text) || txtPatientSurname.Text.Length > 30)
            {
                MessageBox.Show("Patient Surname must not be numeric and should be no more than 30 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validating Address
            if (!IsAlphaNumeric(txtAddress.Text) || txtAddress.Text.Length > 50)
            {
                MessageBox.Show("Address can be alphanumeric, no special characters allowed, and should be no more than 50 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Phone Number validation
            if (!IsValidPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("Phone number must be a valid format (exactly 10 characters long, beginning with '0').", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validating Email
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email must be a valid format (between 7 and 30 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Referral validation
            if (IsNumeric(txtReferral.Text) || txtReferral.Text.Length > 30)
            {
                MessageBox.Show("Referral must not be numeric and should be no more than 30 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new instance of Appointment
            Appointment newAppointment = new Appointment();

            // Get the selected service name
            string selectedServiceName = cboServices.SelectedItem.ToString();

            // Extract ServiceID and parse it to an integer
            int serviceId = int.Parse(selectedServiceName.Substring(0, 3));

            // Get the selected doctor name and corresponding doctor ID
            string selectedDoctorName = cboDoctors.SelectedItem.ToString();
            int doctorID = int.Parse(selectedDoctorName.Substring(0, 3));

            // get the generated patient ID
            //int patientId = Convert.ToInt32(txtPatientID.Text);
            int patientId = Appointment.GetNextPatientID();

            // Create a new instance of Appointment
            Appointment appointment = new Appointment(
                Convert.ToInt32(txtApptID.Text),
                cboServices.Text,
                Convert.ToDecimal(txtServiceRate.Text),
                dtmDate.Value.Date,
                cboAppointmentTime.Text,
                cboDoctors.Text,
                cboEquipmentName.Text,
                txtPatientForename.Text,
                txtPatientSurname.Text,
                txtAddress.Text,
                Convert.ToInt32(txtPhone.Text),
                txtEmail.Text,
                txtReferral.Text,
                "M",
                patientId,
                serviceId,
                doctorID
            );

            // Invoke the method to add the data to the Appointment table
            appointment.MakeAppointment();


            MessageBox.Show("New appointment added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Reset UI
            grpPatientDetails.Visible = false;
            grpAppDetails.Visible = false;
            txtPatientForename.Clear();
            txtPatientSurname.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtReferral.Clear();
            txtServiceRate.Clear();
            cboServices.SelectedItem = null;
            txtApptID.Text = Appointment.GetNextAppointmentID().ToString("00");

        }

        // checking if a string contains only alphabetic characters
        private bool IsAlphaOnly(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter);
        }

        // checking if a string contains only alphanumeric characters
        private bool IsAlphaNumeric(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && input.All(char.IsLetterOrDigit);
        }

        // if a string is numeric
        private bool IsNumeric(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && input.All(char.IsDigit);
        }

        //checking if a phone number is in a valid format
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length == 10 && phoneNumber.StartsWith("0");
        }

        // if email is in a valid format
        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && email.Length >= 7 && email.Length <= 30;
        }

    }
}

