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
        Appointment cancelledAppointment;
        public frmCancelAppointment()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
            this.cancelledAppointment = new Appointment();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void CancelAppointmentSerach_click(object sender, EventArgs e)
        {
            // Find matching patient
            DataSet ds = Appointment.findAppointment(txtPatientSurname.Text);

            // Check if the returned dataset contains any rows
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                txtPatientSurname.Clear();
                txtPatientSurname.Focus();
                return;
            }

            // Bind the DataGridView to the returned DataSet
            grdCancelAppointment.DataSource = ds.Tables[0];

            // Make the DataGridView visible
            grdCancelAppointment.Visible = true;
        }

        private void CancelAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header cell and if it belongs to the data rows
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = grdCancelAppointment.Rows[e.RowIndex];

                // Extract the data from the selected row
                string patientForename = selectedRow.Cells["PForename"].Value.ToString();
                string patientSurname = selectedRow.Cells["PSurname"].Value.ToString();
                DateTime appDate = Convert.ToDateTime(selectedRow.Cells["AppDate"].Value);
                string formattedAppDate = appDate.ToString("dd/MM/yyyy");  // Format the date
                string appTime = selectedRow.Cells["AppTime"].Value.ToString();
                string referral = selectedRow.Cells["Referral"].Value.ToString();
                string appointmentID = selectedRow.Cells["AppointmentID"].Value.ToString();
                string serviceName = selectedRow.Cells["ServiceName"].Value.ToString();
                string doctorForename = selectedRow.Cells["DForename"].Value.ToString();
                string doctorSurname = selectedRow.Cells["DSurname"].Value.ToString();
                string doctorName = $"{doctorForename} {doctorSurname}";

                // Display the data in grpAppointmentInfo
                txtPForename.Text = patientForename;
                txtPSurname.Text = patientSurname;
                txtAppDate.Text = formattedAppDate;
                txtAppTime.Text = appTime;
                txtReferral.Text = referral;
                txtAppointmentID.Text = appointmentID;
                txtServiceName.Text = serviceName;
                txtDoctorName.Text = doctorName;

                // Setting the appointmentID property of the cancelledAppointment object
                cancelledAppointment.SetAppointmentID(int.Parse(appointmentID));

                // Show the group box containing appointment info
                grpAppointmentInfo.Visible = true;
            }
        }


        private void btnCancelAppt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel this Appointmet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cancelledAppointment.CancelAppointment();

                MessageBox.Show("Appointment has been Cancelled in Database",
                    "Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                // Reset UI
                grdCancelAppointment.Visible = false;
                grpAppointmentInfo.Visible = false;
                txtPatientSurname.Clear();
                txtPatientSurname.Focus();
            }
        }
    }
}
