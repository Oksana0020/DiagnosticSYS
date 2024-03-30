using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticSYS
{
    public static class Utility
    {

        public static ComboBox LoadEquipmentNames(ComboBox cboName)
        {
            cboName.Items.Clear();

            string strSQL = "SELECT * FROM Equipments WHERE EqStatus = 'A'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            //reading equipment names and adding them in combo box
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetInt32(0).ToString() + " - " + dr.GetString(1));
            }

            conn.Close();
            return cboName;
        }

        public static ComboBox LoadServiceNames(ComboBox cboServices)
        {
            cboServices.Items.Clear();

            string strSQL = "SELECT * FROM Services WHERE Status = 'A'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            //reading equipment names and adding them in combo box
            while (dr.Read())
            {
                int serviceId = dr.GetInt32(0);
                string formattedServiceId = serviceId.ToString().PadLeft(3, '0');
                string serviceName = dr.GetString(1);

                cboServices.Items.Add(formattedServiceId + " - " + serviceName);
            }

            conn.Close();
            return cboServices;
        }

        public static ComboBox LoadServiceRates(ComboBox cboRates)
        {
            cboRates.Items.Clear();

            string strSQL = "SELECT Rate FROM Services WHERE Status = 'A'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            // Reading service rates and adding them to the combo box
            while (dr.Read())
            {
                cboRates.Items.Add(dr.GetDecimal(0).ToString("C"));
            }

            conn.Close();
            return cboRates;
        }



        public static ComboBox LoadRoomNumbers(ComboBox cboRoomNumber)
        {
            cboRoomNumber.Items.Clear();

            string strSQL = "SELECT RoomNo FROM Rooms WHERE RoomNo NOT IN (SELECT RoomNo FROM Equipment) ORDER BY RoomNo";
            //string strSQL = "SELECT RoomNo FROM Rooms";
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            //reading room numbers and displaying in combo box
            while (dr.Read())
            {
                cboRoomNumber.Items.Add(dr.GetDecimal(0));
            }

            conn.Close();
            return cboRoomNumber;
        }

        public static ComboBox loadDoctors(ComboBox cboDoctors)
        {
            cboDoctors.Items.Clear();
            string strSQL = "SELECT * FROM Doctors";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int doctorId = dr.GetInt32(0);
                string formattedDoctorId = doctorId.ToString().PadLeft(3, '0');
                string doctorForename = dr.GetString(1);
                string doctorSurname = dr.GetString(2);

                cboDoctors.Items.Add(formattedDoctorId + " - " + doctorForename + " " + doctorSurname);
            }

            conn.Close();
            return cboDoctors;
        }


        public static ComboBox LoadAvailableTimes(ComboBox cboTimes, DateTime selectedDate)
        {
            cboTimes.Items.Clear();
            string strSQL = "SELECT AppTime FROM AppointmentTimes WHERE AppTime NOT IN " +
                "(SELECT AppTime FROM Appointments WHERE AppDate = :selectedDate)";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.Parameters.Add("selectedDate", OracleDbType.Date).Value = selectedDate;
            OracleDataReader dr = cmd.ExecuteReader();

            //reading available time slots and displaying in combo box
            while (dr.Read())
            {
                cboTimes.Items.Add(dr.GetString(0));
            }

            conn.Close();
            return cboTimes;
        }
    }
}

