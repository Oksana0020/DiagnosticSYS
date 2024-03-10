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
    public partial class frmCancelAppointment : Form
    {
        mnuMainMenu parent;
        public frmCancelAppointment()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void CancelAppointmentSerach_click(object sender, EventArgs e)
        {
            string enteredPatientSurname = txtPatientSurname.Text.Trim();

            if (string.IsNullOrWhiteSpace(enteredPatientSurname) || enteredPatientSurname.Length > 30)
            {
                MessageBox.Show("Invalid Patient Surname!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPatientSurname.Focus();
                return;
            }
            else
            {
                // Enable text boxes
                grpAppointmentInfo.Visible = true;

                switch (enteredPatientSurname.ToUpper())
                {
                    case "BAY":
                        lblAppointmentDetails.Text = "Patient Forename: John" +
                                                     "\nPatient Surname: Bay" +
                                                     "\nAddress: 272 Main St" +
                                                     "\nPhone: 527-1234" +
                                                     "\nEmail: john.bay@mail.ua" +
                                                     "\nAppointment Date: 2023-01-15" +
                                                     "\nTime: 10:00 AM" +
                                                     "\nDoctor: Dr. Smith";
                        break;
                    case "SMITH":
                        lblAppointmentDetails.Text = "Patient Forename: Lily" +
                                                     "\nPatient Surname: Smith" +
                                                     "\nAddress: 496 Oak Street" +
                                                     "\nPhone: 555-5678" +
                                                     "\nEmail: jane.smith@gmail.com" +
                                                     "\nAppointment Date: 2023-09-27" +
                                                     "\nTime: 02:30 PM" +
                                                     "\nDoctor: Dr. Johnson";
                        break;
                    case "WILLIAMS":
                        lblAppointmentDetails.Text = "Patient Forename: Michael" +
                                                     "\nPatient Surname: Williams" +
                                                     "\nAddress: 789 Elm St" +
                                                     "\nPhone: 555-9876" +
                                                     "\nEmail: michael.w@yahoo.com" +
                                                     "\nAppointment Date: 2023-11-10" +
                                                     "\nTime: 11:45 AM" +
                                                     "\nDoctor: Dr. Davis";
                        break;
                    case "BALES":
                        lblAppointmentDetails.Text = "Patient Forename: Emily" +
                                                     "\nPatient Surname: Bales" +
                                                     "\nAddress: 192 Pine St" +
                                                     "\nPhone: 555-4321" +
                                                     "\nEmail: emily.b@gmail.com" +
                                                     "\nAppointment Date: 2023-04-05" +
                                                     "\nTime: 03:15 PM" +
                                                     "\nDoctor: Dr. Miller";
                        break;
                    default:
                        MessageBox.Show("Patient Surname not found!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void btnDiscontinueService_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Appointment is Cancelled. Notification is sent to the patient.",
                    "Appointment Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            grpAppointmentInfo.Visible = false;
        }
    }
}
