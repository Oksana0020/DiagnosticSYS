using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiagnosticSYS
{
    public partial class frmViewDailySchedule : Form
    {
        mnuMainMenu parent;
        public frmViewDailySchedule()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            HideAllControls();

            // Check the selected item in check box
            string selectedFilter = cboFilter.SelectedItem?.ToString();

            if (selectedFilter == "Date")
            {
                
                dtmDate.Visible = true;
                lblScheduleDate.Visible = true;
            }
            else if (selectedFilter == "Service Name")
            {
                lblServiceName.Visible = true;
                cboServiceName.Visible = true;
            }
        }

        private void HideAllControls()
        {
            dtmDate.Visible = false;
            lblScheduleDate.Visible = false;
            lblServiceName.Visible = false;
            cboServiceName.Visible = false;
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            groDailySchedule.Visible = true;
            grdSchedule.Columns.Clear();

            string selectedFilter = cboFilter.SelectedItem?.ToString();

            if (selectedFilter == "Date")
            {
                grdSchedule.Columns.Add("AppointmentID", "Appointment ID");
                grdSchedule.Columns.Add("PatientForename", "Patient Forename");
                grdSchedule.Columns.Add("PatientSurname", "Patient Surname");
                grdSchedule.Columns.Add("ServiceName", "Service Name");
                grdSchedule.Columns.Add("AppDate", "Appointment Date");
                grdSchedule.Columns.Add("AppTime", "Appointment Time");
                grdSchedule.Columns.Add("EquipmentName", "Equipment Name");
            }
            else if (selectedFilter == "Service Name")
            {
                grdSchedule.Columns.Add("ServiceName", "Service Name");
                grdSchedule.Columns.Add("AppointmentID", "Appointment ID");
                grdSchedule.Columns.Add("PatientForename", "Patient Forename");
                grdSchedule.Columns.Add("PatientSurname", "Patient Surname");
                grdSchedule.Columns.Add("AppDate", "Appointment Date");
                grdSchedule.Columns.Add("AppTime", "Appointment Time");
            }

            List<Appointment> appointmentsList = GetAppointments();

            // Clear existing rows
            //grdSchedule.Rows.Clear();

            //populating my data in grid
            foreach (var appointment in appointmentsList)
            {
                if (selectedFilter == "Date")
                {
                    grdSchedule.Rows.Add(
                        appointment.AppointmentID,
                        appointment.PatientForename,
                        appointment.PatientSurname,
                        appointment.ServiceName,
                        appointment.AppDate.ToString("MMMM d, yyyy"),
                        appointment.AppTime.ToString("h:mm tt"),
                        appointment.EquipmentName
                    );
                }
                else if (selectedFilter == "Service Name")
                {
                    grdSchedule.Rows.Add(
                        appointment.ServiceName,
                        appointment.AppointmentID,
                        appointment.PatientForename,
                        appointment.PatientSurname,
                        appointment.AppDate.ToString("MMMM d, yyyy"),
                        appointment.AppTime.ToString("h:mm tt"),
                        appointment.EquipmentName
                        );
                }
            }
        }

        public class Appointment
        {
            public string AppointmentID { get; set; }
            public string PatientForename { get; set; }
            public string PatientSurname { get; set; }
            public string ServiceName { get; set; }
            public DateTime AppDate { get; set; }
            public DateTime AppTime { get; set; }
            public string EquipmentName { get; set; }
        }

        private List<Appointment> GetAppointments()
        {
            List<Appointment> hardcodedAppointments = new List<Appointment>();

            switch (cboServiceName.Text)
            {
                case "MRI":
                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "MRI001",
                        PatientForename = "John",
                        PatientSurname = "Brenson",
                        ServiceName = "MRI",
                        AppDate = new DateTime(2023, 9, 15),
                        AppTime = new DateTime(2023, 9, 15, 10, 30, 0),
                        EquipmentName = "MRI Machine A123"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "MRI002",
                        PatientForename = "Jane",
                        PatientSurname = "Milton",
                        ServiceName = "MRI",
                        AppDate = new DateTime(2023, 9, 16),
                        AppTime = new DateTime(2023, 9, 16, 11, 15, 0),
                        EquipmentName = "MRI Machine B456"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "MRI003",
                        PatientForename = "Mike",
                        PatientSurname = "Donton",
                        ServiceName = "MRI",
                        AppDate = new DateTime(2023, 9, 17),
                        AppTime = new DateTime(2023, 9, 17, 14, 0, 0),
                        EquipmentName = "MRI Machine C789"
                    });
                    break;

                case "CT":
                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "CT001",
                        PatientForename = "Emily",
                        PatientSurname = "Brens",
                        ServiceName = "CT",
                        AppDate = new DateTime(2023, 9, 15),
                        AppTime = new DateTime(2023, 9, 15, 9, 45, 0),
                        EquipmentName = "CT Scanner X234"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "CT002",
                        PatientForename = "Mark",
                        PatientSurname = "Fleming",
                        ServiceName = "CT",
                        AppDate = new DateTime(2023, 9, 16),
                        AppTime = new DateTime(2023, 9, 16, 13, 30, 0),
                        EquipmentName = "CT Scanner Y567"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "CT003",
                        PatientForename = "Sophia",
                        PatientSurname = "Mars",
                        ServiceName = "CT",
                        AppDate = new DateTime(2023, 9, 17),
                        AppTime = new DateTime(2023, 9, 17, 16, 15, 0),
                        EquipmentName = "CT Scanner Z890"
                    });
                    break;

                case "XRay":
                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "XRAY001",
                        PatientForename = "Sarah",
                        PatientSurname = "Anders",
                        ServiceName = "X-Ray",
                        AppDate = new DateTime(2023, 9, 15),
                        AppTime = new DateTime(2023, 9, 15, 12, 0, 0),
                        EquipmentName = "X-Ray Machine XR123"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "XRAY002",
                        PatientForename = "Robert",
                        PatientSurname = "Williams",
                        ServiceName = "X-Ray",
                        AppDate = new DateTime(2023, 9, 16),
                        AppTime = new DateTime(2023, 9, 16, 14, 45, 0),
                        EquipmentName = "X-Ray Machine XR456"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "XRAY003",
                        PatientForename = "Laura",
                        PatientSurname = "Times",
                        ServiceName = "X-Ray",
                        AppDate = new DateTime(2023, 9, 17),
                        AppTime = new DateTime(2023, 9, 17, 17, 30, 0),
                        EquipmentName = "X-Ray Machine XR789"
                    });
                    break;

                case "Doplerography":
                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "Doppler001",
                        PatientForename = "Olivia",
                        PatientSurname = "Brown",
                        ServiceName = "Dopplerography",
                        AppDate = new DateTime(2023, 9, 15),
                        AppTime = new DateTime(2023, 9, 15, 11, 0, 0),
                        EquipmentName = "Dopplerography Machine G890"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "Doppler002",
                        PatientForename = "Liam",
                        PatientSurname = "Clark",
                        ServiceName = "Dopplerography",
                        AppDate = new DateTime(2023, 9, 16),
                        AppTime = new DateTime(2023, 9, 16, 16, 0, 0),
                        EquipmentName = "Dopplerography Machine H123"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "Doppler003",
                        PatientForename = "Ava",
                        PatientSurname = "Williams",
                        ServiceName = "Dopplerography",
                        AppDate = new DateTime(2023, 9, 17),
                        AppTime = new DateTime(2023, 9, 17, 13, 15, 0),
                        EquipmentName = "Dopplerography Machine I234"
                    });
                    break;

                case "Ultrasound":
                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "Ultrasound001",
                        PatientForename = "Noah",
                        PatientSurname = "Davis",
                        ServiceName = "Ultrasound",
                        AppDate = new DateTime(2023, 9, 15),
                        AppTime = new DateTime(2023, 9, 15, 13, 30, 0),
                        EquipmentName = "Ultrasound Machine J345"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "Ultrasound002",
                        PatientForename = "Mia",
                        PatientSurname = "Taylor",
                        ServiceName = "Ultrasound",
                        AppDate = new DateTime(2023, 9, 16),
                        AppTime = new DateTime(2023, 9, 16, 12, 15, 0),
                        EquipmentName = "Ultrasound Machine K456"
                    });

                    hardcodedAppointments.Add(new Appointment
                    {
                        AppointmentID = "Ultrasound003",
                        PatientForename = "James",
                        PatientSurname = "Anderson",
                        ServiceName = "Ultrasound",
                        AppDate = new DateTime(2023, 9, 17),
                        AppTime = new DateTime(2023, 9, 17, 10, 45, 0),
                        EquipmentName = "Ultrasound Machine L567"
                    });
                    break;

                default:
                    break;
            }

            return hardcodedAppointments;
        }
    }
}
