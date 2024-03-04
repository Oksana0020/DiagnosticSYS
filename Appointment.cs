using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DiagnosticSYS
{
    class Appointment
    {
        private int appointmentID;
        private string serviceName;
        private decimal rate;
        private DateTime appointmentDateTime;
        private string doctor;
        private string equipmentName;
        private string patientForename;
        private string patientSurname;
        private string address;
        private int phone;
        private string email;
        private string referral;

        public Appointment()
        {
            this.appointmentID = 0;
            this.serviceName = "";
            this.rate = 0;
            this.appointmentDateTime = DateTime.Now;
            this.doctor = "";
            this.equipmentName = "";
            this.patientForename = "";
            this.patientSurname = "";
            this.address = "";
            this.phone = 0;
            this.email = "";
            this.referral = "";
        }

        public Appointment(int appointmentID, string serviceName, decimal rate, DateTime appointmentDateTime, string doctor,
        string equipmentName, string patientForename, string patientSurname, string address, int phone, string email, string referral)
        {
            this.appointmentID = appointmentID;
            this.serviceName = serviceName;
            this.rate = rate;
            this.appointmentDateTime = appointmentDateTime;
            this.doctor = doctor;
            this.equipmentName = equipmentName;
            this.patientForename = patientForename;
            this.patientSurname = patientSurname;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.referral = referral;
        }

        // Getters 
        public int GetAppointmentID() { return this.appointmentID; }
        public string GetServiceName() { return this.serviceName; }
        public decimal GetRate() { return this.rate; }
        public DateTime GetAppointmentDateTime() { return this.appointmentDateTime; }
        public string GetDoctor() { return this.doctor; }
        public string GetEquipmentName() { return this.equipmentName; }
        public string GetPatientForename() { return this.patientForename; }
        public string GetPatientSurname() { return this.patientSurname; }
        public string GetAddress() { return this.address; }
        public int GetPhone() { return this.phone; }
        public string GetEmail() { return this.email; }
        public string GetReferral() { return this.referral; }

        // Setters
        public void SetAppointmentID(int appointmentID) { this.appointmentID = appointmentID; }
        public void SetServiceName(string serviceName) { this.serviceName = serviceName; }
        public void SetRate(decimal rate) { this.rate = rate; }
        public void SetAppointmentDateTime(DateTime appointmentDateTime) { this.appointmentDateTime = appointmentDateTime; }
        public void SetDoctor(string doctor) { this.doctor = doctor; }
        public void SetEquipmentName(string equipmentName) { this.equipmentName = equipmentName; }
        public void SetPatientForename(string patientForename) { this.patientForename = patientForename; }
        public void SetPatientSurname(string patientSurname) { this.patientSurname = patientSurname; }
        public void SetAddress(string address) { this.address = address; }
        public void SetPhone(int phone) { this.phone = phone; }
        public void SetEmail(string email) { this.email = email; }
        public void SetReferral(string referral) { this.referral = referral; }

        public static int GetNextAppointmentID()
        {
            // Open a database connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                // Define the SQL query to be executed
                string sqlQuery = "SELECT MAX(AppointmentID) FROM Appointments";

                // Execute the SQL query
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    conn.Open();

                    // Execute the query and get the result
                    object result = cmd.ExecuteScalar();

                    // Check if the result is DBNull or not
                    if (result == DBNull.Value)
                        return 1;
                    else
                        return Convert.ToInt32(result) + 1;
                }
            }
        }

        // Method to get all appoinments
        public static DataSet GetAllAppointments()
        {
            // Open a database connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                // Define the SQL query to be executed
                string sqlQuery = "SELECT * FROM Appointments";

                // Execute the SQL query
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    try
                    {
                        conn.Open();
                        da.Fill(ds, "appointments");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching appointments: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    return ds;
                }
            }
        }
        public void MakeAppointment()
        {
            OracleConnection conn = null;
            OracleCommand cmd = null;

            try
            {
                // Open a database connection
                conn = new OracleConnection(DBConnect.oraDB);
                conn.Open();

                // Define the SQL query to be executed
                string sqlQuery = "INSERT INTO Appointments (AppointmentID, ServiceName, Rate, AppointmentDateTime, Doctor, EquipmentName, PatientForename, PatientSurname, Address, Phone, Email, Referral) " +
                                  "VALUES (:appointmentID, :serviceName, :rate, :appointmentDateTime, :doctor, :equipmentName, :patientForename, :patientSurname, :address, :phone, :email, :referral)";

                // Execute the SQL query
                cmd = new OracleCommand(sqlQuery, conn);
                cmd.Parameters.Add(new OracleParameter("appointmentID", GetAppointmentID()));
                cmd.Parameters.Add(new OracleParameter("serviceName", GetServiceName()));
                cmd.Parameters.Add(new OracleParameter("rate", GetRate()));
                cmd.Parameters.Add(new OracleParameter("appointmentDateTime", GetAppointmentDateTime()));
                cmd.Parameters.Add(new OracleParameter("doctor", GetDoctor()));
                cmd.Parameters.Add(new OracleParameter("equipmentName", GetEquipmentName()));
                cmd.Parameters.Add(new OracleParameter("patientForename", GetPatientForename()));
                cmd.Parameters.Add(new OracleParameter("patientSurname", GetPatientSurname()));
                cmd.Parameters.Add(new OracleParameter("address", GetAddress()));
                cmd.Parameters.Add(new OracleParameter("phone", GetPhone()));
                cmd.Parameters.Add(new OracleParameter("email", GetEmail()));
                cmd.Parameters.Add(new OracleParameter("referral", GetReferral()));

                cmd.ExecuteNonQuery();
                Console.WriteLine("Appointment added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding appointment: " + ex.Message);
            }
            finally
            {
                // Close command
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                // Close connection
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void CancelAppointment(int appointmentID)
        {
            OracleConnection conn = null;
            OracleCommand cmd = null;

            try
            {
                // Open a database connection
                conn = new OracleConnection(DBConnect.oraDB);
                conn.Open();

                // Define the SQL query to update the appointment status
                string sqlQuery = "UPDATE Appointments SET Status = 'C' WHERE AppointmentID = :appointmentID";

                // Execute the SQL query
                cmd = new OracleCommand(sqlQuery, conn);
                cmd.Parameters.Add(new OracleParameter("appointmentID", appointmentID));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Appointment with ID " + appointmentID + " has been successfully canceled.");
                }
                else
                {
                    Console.WriteLine("No appointment found with ID " + appointmentID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error canceling appointment: " + ex.Message);
            }
            finally
            {
                // Close command
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                // Close connection
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void GetAppointment(int Id)
        {
            OracleConnection conn = null;
            OracleCommand cmd = null;
            OracleDataReader dr = null;

            try
            {
                // Open a database connection
                conn = new OracleConnection(DBConnect.oraDB);
                conn.Open();

                // Define the SQL query to be executed
                string sqlQuery = "SELECT * FROM Appointments WHERE AppointmentID = " + Id;

                // Execute the SQL query
                cmd = new OracleCommand(sqlQuery, conn);
                dr = cmd.ExecuteReader();

                // Check if appointment with the specified ID exists
                if (dr.Read())
                {
                    // Set the instance variables with values from the data reader
                    SetAppointmentID(dr.GetInt32(0));
                    SetServiceName(dr.GetString(1));
                    SetRate(dr.GetDecimal(2));
                    SetAppointmentDateTime(dr.GetDateTime(3));
                    SetDoctor(dr.GetString(4));
                    SetEquipmentName(dr.GetString(5));
                    SetPatientForename(dr.GetString(6));
                    SetPatientSurname(dr.GetString(7));
                    SetAddress(dr.GetString(8));
                    SetPhone(dr.GetInt32(9));
                    SetEmail(dr.GetString(10));
                    SetReferral(dr.GetString(11));
                }
                else
                {
                    Console.WriteLine("Appointment with ID " + Id + " not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching appointment: " + ex.Message);
            }
            finally
            {
                // Close data reader
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }

                // Close command
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                // Close connection
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}


