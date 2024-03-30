using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DiagnosticSYS
{
    class Equipment
    {
        private decimal equipmentID;
        private string equipmentName;
        private string model;
        private string manufacturer;
        private decimal manPhoneNumber;
        private string manEmail;
        private decimal roomNo;
        private DateTime eqPurchaseDate;
        private string eqStatus;

        public Equipment()
        {
            this.equipmentID = 0;
            this.equipmentName = "";
            this.model = "";
            this.manufacturer = "";
            this.manPhoneNumber = 0;
            this.manEmail = "";
            this.roomNo = 0;
            this.eqPurchaseDate = DateTime.Now;
            this.eqStatus = "A";
        }

        public Equipment(decimal equipmentID, string equipmentName, string model, string manufacturer, decimal manPhoneNumber, string manEmail, decimal roomNo, DateTime eqPurchaseDate, string eqStatus)
        {
            this.equipmentID = equipmentID;
            this.equipmentName = equipmentName;
            this.model = model;
            this.manufacturer = manufacturer;
            this.manPhoneNumber = manPhoneNumber;
            this.manEmail = manEmail;
            this.roomNo = roomNo;
            this.eqPurchaseDate = eqPurchaseDate;
            this.eqStatus = eqStatus;
        }

        // Getters
        public decimal GetEquipmentID() { return equipmentID; }
        public string GetEquipmentName() { return equipmentName; }
        public string GetModel() { return model; }
        public string GetManufacturer() { return manufacturer; }
        public decimal GetManPhoneNumber() { return manPhoneNumber; }
        public string GetManEmail() { return manEmail; }
        public decimal GetRoomNo() { return roomNo; }
        public DateTime GetEqPurchaseDate() { return eqPurchaseDate; }
        public string GetEqStatus() { return eqStatus; }

        // Setters
        public void SetEquipmentID(decimal equipmentID) { this.equipmentID = equipmentID; }
        public void SetEquipmentName(string equipmentName) { this.equipmentName = equipmentName; }
        public void SetModel(string model) { this.model = model; }
        public void SetManufacturer(string manufacturer) { this.manufacturer = manufacturer; }
        public void SetManPhoneNumber(decimal manPhoneNumber) { this.manPhoneNumber = manPhoneNumber; }
        public void SetManEmail(string manEmail) { this.manEmail = manEmail; }
        public void SetRoomNo(decimal roomNo) { this.roomNo = roomNo; }
        public void SetEqPurchaseDate(DateTime eqPurchaseDate) { this.eqPurchaseDate = eqPurchaseDate; }
        public void SetEqStatus(string eqStatus) { this.eqStatus = eqStatus; }


        public void getEquipment(decimal Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "SELECT * FROM Equipments WHERE EquipmentID = :Id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter("Id", Id));

            try
            {
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // Set the instance variables with values from data reader
                    SetEquipmentID(dr.GetDecimal(0));
                    SetEquipmentName(dr.GetString(1));
                    SetModel(dr.GetString(2));
                    SetManufacturer(dr.GetString(3));
                    SetManPhoneNumber(dr.GetDecimal(4));
                    SetManEmail(dr.GetString(5));
                    SetRoomNo(dr.GetDecimal(6));
                    SetEqPurchaseDate(dr.GetDateTime(7));
                    SetEqStatus(dr.GetString(8));
                }
                else
                {
                    Console.WriteLine("No equipment found with the given ID.");
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine($"Oracle Error getting equipment: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting equipment: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // Register Equipment method
        public void RegisterEquipment()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            string formattedDate = this.eqPurchaseDate.ToString("dd-MMM-yy").ToUpper();
            string sqlQuery = "INSERT INTO Equipments VALUES (" +
                              this.equipmentID + ", '" +
                              this.equipmentName + "', '" +
                              this.model + "', '" +
                              this.manufacturer + "', " +
                              this.manPhoneNumber + ", '" +
                              this.manEmail + "', " +
                              this.roomNo + ", '" +
                              formattedDate + "', '" +
                              'A' + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // Deregister Equipment method
        public void DeregisterEquipment()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = "UPDATE Equipments SET EqStatus = 'D' WHERE EquipmentID = " + this.equipmentID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // Update Equipment method
        public void UpdateEquipment()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string formattedDate = this.eqPurchaseDate.ToString("dd-MMM-yyyy");

            string sqlQuery = "UPDATE Equipments SET " +
                "EquipmentName = '" + this.equipmentName + "', " +
                "Model = '" + this.model + "', " +
                "Manufacturer = '" + this.manufacturer + "', " +
                "ManPhoneNumber = " + this.manPhoneNumber + ", " +
                "ManEmail = '" + this.manEmail + "', " +
                "RoomNo = " + this.roomNo + ", " +
                "EqPurchaseDate = '" + formattedDate + "', " +
                "EqStatus = '" + this.eqStatus + "' " +
                "WHERE EquipmentID = " + this.equipmentID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // Method to get the next equipment ID
        public static int getNextEquipmentID()
        {

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query
            String sqlQuery = "SELECT MAX(EquipmentId) FROM Equipments";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
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

        // Method to find Equipment
        public static DataSet findEquipment(string equipmentName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            string sqlQuery = $"SELECT EquipmentID, EquipmentName, Model, Manufacturer, ManPhoneNumber, ManEmail, RoomNo, EqPurchaseDate, EqStatus " +
                              $"FROM Equipments " +
                              $"WHERE UPPER(EquipmentName) LIKE UPPER('%{equipmentName}%') ORDER BY EquipmentName";

            Console.WriteLine($"Executing query: {sqlQuery}");

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Equipments");

            Console.WriteLine($"Rows returned: {ds.Tables["Equipments"].Rows.Count}");

            conn.Close();

            return ds;
        }

        public static int GetEquipmentIDByName(string equipmentName)
        {
            int equipmentID = 0;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            OracleCommand cmd = new OracleCommand();

            try
            {
                string sqlQuery = "SELECT EquipmentID FROM Equipments WHERE EquipmentName = :EquipmentName";
                cmd.CommandText = sqlQuery;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("EquipmentName", equipmentName));

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    equipmentID = Convert.ToInt32(result);
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
                // Close connection and dispose command
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                cmd.Dispose();
            }

            return equipmentID;
        }
    }
}


