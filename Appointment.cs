﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DiagnosticSYS
{
    class Appointment
    {
        private int appointmentID;
        private string serviceName;
        private decimal rate;
        private DateTime appointmentDate;
        private string appointmentTime;
        private string doctor;
        private string equipmentName;
        private string patientForename;
        private string patientSurname;
        private string address;
        private int phone;
        private string email;
        private string referral;
        private string appStatus;
        private int patientID;
        private int serviceID;
        private int doctorID;

        public Appointment()
        {
            this.appointmentID = 0;
            this.patientID = 0;
            this.serviceID = 0;
            this.doctorID = 0;
            this.serviceName = "";
            this.rate = 0;
            this.appointmentDate = DateTime.Now;
            this.appointmentTime = "00:00";
            this.doctor = "";
            this.equipmentName = "";
            this.patientForename = "";
            this.patientSurname = "";
            this.address = "";
            this.phone = 0;
            this.email = "";
            this.referral = "";
            this.appStatus = "A";
        }

        public Appointment(int appointmentID, string serviceName, decimal rate, DateTime appointmentDate,
        string appointmentTime, string doctor,
        string equipmentName, string patientForename, string patientSurname, string address, int phone, string email, string referral,
        string appStatus, int patientID, int serviceID, int doctorID)
        {
            this.appointmentID = appointmentID;
            this.serviceName = serviceName;
            this.rate = rate;
            this.appointmentDate = appointmentDate;
            this.appointmentTime = appointmentTime;
            this.doctor = doctor;
            this.equipmentName = equipmentName;
            this.patientForename = patientForename;
            this.patientSurname = patientSurname;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.referral = referral;
            this.appStatus = appStatus;
            this.patientID = patientID;
            this.serviceID = serviceID;
            this.doctorID = doctorID;
        }

        // Getters 
        public int GetAppointmentID() { return this.appointmentID; }
        public string GetServiceName() { return this.serviceName; }
        public decimal GetRate() { return this.rate; }
        public DateTime GetAppointmentDate() { return this.appointmentDate; }
        public string GetAppointmentTime() { return this.appointmentTime; }
        public string GetDoctor() { return this.doctor; }
        public string GetEquipmentName() { return this.equipmentName; }
        public string GetPatientForename() { return this.patientForename; }
        public string GetPatientSurname() { return this.patientSurname; }
        public string GetAddress() { return this.address; }
        public int GetPhone() { return this.phone; }
        public string GetEmail() { return this.email; }
        public string GetReferral() { return this.referral; }
        public string GetAppStatus() { return this.appStatus; }
        public int GetPatientID() { return this.patientID; }
        public int GetServiceID() { return this.serviceID; }
        public int GetDoctorID() { return this.doctorID; }

        // Setters
        public void SetAppointmentID(int appointmentID) { this.appointmentID = appointmentID; }
        public void SetServiceName(string serviceName) { this.serviceName = serviceName; }
        public void SetRate(decimal rate) { this.rate = rate; }
        public void SetAppointmentDate(DateTime appointmentDate) { this.appointmentDate = appointmentDate; }
        public void SetAppointmentTime(string appointmentTime) { this.appointmentTime = appointmentTime; }
        public void SetDoctor(string doctor) { this.doctor = doctor; }
        public void SetEquipmentName(string equipmentName) { this.equipmentName = equipmentName; }
        public void SetPatientForename(string patientForename) { this.patientForename = patientForename; }
        public void SetPatientSurname(string patientSurname) { this.patientSurname = patientSurname; }
        public void SetAddress(string address) { this.address = address; }
        public void SetPhone(int phone) { this.phone = phone; }
        public void SetEmail(string email) { this.email = email; }
        public void SetReferral(string referral) { this.referral = referral; }
        public void SetAppStatus(string appStatus) { this.appStatus = appStatus; }
        public void SetPatientID(int patientID) { this.patientID = patientID; }
        public void SetServiceID(int serviceID) { this.serviceID = serviceID; }
        public void SetDoctorID(int doctorID) { this.doctorID = doctorID; }


        public static int GetNextAppointmentID()
        {
            int nextId = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            string sqlQuery = "SELECT MAX(AppointmentID) FROM Appointments";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextId;
        }

        public static int GetNextPatientID()
        {
            int nextId = 0;
            OracleConnection conn = null;
            OracleCommand cmd = null;
            OracleDataReader dr = null;

            try
            {
                conn = new OracleConnection(DBConnect.oraDB);
                string sqlQuery = "SELECT MAX(PatientID) FROM Patients";

                cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                dr = cmd.ExecuteReader();

                if (dr.Read() && !dr.IsDBNull(0))
                {
                    nextId = dr.GetInt32(0) + 1;
                }
                else
                {
                    nextId = 1;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Oracle Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                    dr.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return nextId;
        }


        public void MakeAppointment()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            OracleCommand cmd = new OracleCommand();

            try
            {
                // Generate the next patient ID
                this.patientID = GetNextPatientID();

                conn.Open();

                // Define the SQL query to insert into Patients table
                string patientQuery = "INSERT INTO Patients (PatientID, PForename, PSurname, Address, Phone, Email) " +
                                      "VALUES (" +
                                      this.patientID + ", '" +
                                      this.patientForename + "', '" +
                                      this.patientSurname + "', '" +
                                      this.address + "', '" +
                                      this.phone + "', '" +
                                      this.email + "')";

                // Execute the patient insertion query
                cmd.CommandText = patientQuery;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                // Insert appointment details using the generated PatientID
                string appointmentQuery = "INSERT INTO Appointments (AppointmentID, AppDate, AppTime, Referral, AppStatus, PatientID, ServiceID, DoctorID) " +
                                          "VALUES (" +
                                          this.appointmentID + ", " +
                                          "TO_DATE('" + this.appointmentDate.ToString("dd-MMM-yy") + "', 'DD-MON-YY'), '" +
                                          this.appointmentTime + "', '" +
                                          this.referral + "', '" +
                                          this.appStatus + "', " +
                                          this.patientID + ", " +
                                          this.serviceID + ", " +
                                          this.doctorID + ")";

                cmd.CommandText = appointmentQuery;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close connection
                conn.Close();
            }
        }



        // Method to retrieve the service rate
        public decimal GetServiceRate(string selectedService)
        {
            decimal rate = 0;

            // Open a database connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            string sqlQuery = "SELECT Rate FROM Services WHERE ServiceName = :selectedService";

            // Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            // Open the connection
            conn.Open();

            // Add parameter to the command
            cmd.Parameters.Add("selectedService", OracleDbType.Varchar2).Value = selectedService;

            // Execute the query and get the result
            object result = cmd.ExecuteScalar();

            // Check if the result is not null and convert it to decimal
            if (result != null && result != DBNull.Value)
            {
                rate = Convert.ToDecimal(result);
            }

            cmd.ExecuteNonQuery();

            conn.Close();

            // Return the rate
            return rate;
        }

        public void CancelAppointment()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            try
            {
                conn.Open();

                string sqlQuery = "UPDATE Appointments SET AppStatus = 'C' WHERE AppointmentID = " + this.appointmentID;

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public static DataSet findAppointment(string patientSurname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            string sqlQuery = @"
        SELECT P.PForename, P.PSurname, A.AppointmentID, A.AppDate, A.AppTime, A.Referral, S.ServiceName, D.DForename, D.DSurname
        FROM Appointments A
        INNER JOIN Patients P ON A.PatientID = P.PatientID
        INNER JOIN Services S ON A.ServiceID = S.ServiceID
        INNER JOIN Doctors D ON A.DoctorID = D.DoctorID
        WHERE UPPER(P.PSurname) LIKE UPPER(:PatientSurname)
        ORDER BY A.AppDate, A.AppTime";

            Console.WriteLine($"Executing query: {sqlQuery}");

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add("PatientSurname", OracleDbType.Varchar2).Value = "%" + patientSurname + "%";

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Console.WriteLine($"Rows returned: {ds.Tables[0].Rows.Count}");

            conn.Close();

            return ds;
        }

    }
}


