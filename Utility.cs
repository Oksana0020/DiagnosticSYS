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
                cboServices.Items.Add(dr.GetInt32(0).ToString() + " - " + dr.GetString(1));
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

            string strSQL = "SELECT RoomNo FROM Rooms";

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

        public static void LoadAppointmentTimes(ComboBox cboAppointmentTime)
        {
            // Clear the ComboBox
            cboAppointmentTime.Items.Clear();
            int startHour = 9;  
            int endHour = 16;   

            for (int hour = startHour; hour <= endHour; hour++)
            {
                cboAppointmentTime.Items.Add(hour.ToString("00") + ":00");
                cboAppointmentTime.Items.Add(hour.ToString("00") + ":30");
            }
        }

        public static void loadDoctors(ComboBox cboDoctors)
        {
            cboDoctors.Items.Clear();
            cboDoctors.Items.Add("Dr.Freddie Mercury");
            cboDoctors.Items.Add("Dr.Elvis Presley");
            cboDoctors.Items.Add("Dr.Michael Jackson");
            cboDoctors.Items.Add("Dr.Whitney Houston");
            cboDoctors.Items.Add("Dr.Frank Sinatra");
            cboDoctors.Items.Add("Dr.Sting");
        }
    }
}

