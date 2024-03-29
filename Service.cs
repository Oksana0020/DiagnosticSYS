using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DiagnosticSYS
{
    class Service
    {
        private int serviceID;
        private string serviceName;
        private string description;
        private decimal rate;
        private string serviceStatus;
        private int equipmentID;

        public Service()
        {
            this.serviceID = 0;
            this.serviceName = "";
            this.description = "";
            this.rate = 0;
            this.serviceStatus = "A";
            this.equipmentID = 0;
        }

        public Service(int serviceID, string serviceName, string description, decimal rate, string serviceStatus, int equipmentID)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.description = description;
            this.rate = rate;
            this.serviceStatus = serviceStatus;
            this.equipmentID = equipmentID;
        }

        // Getters 
        public int GetServiceID() { return this.serviceID; }
        public string GetServiceName() { return this.serviceName; }
        public string GetDescription() { return this.description; }
        public decimal GetRate() { return this.rate; }
        public string GetServiceStatus() { return this.serviceStatus; }
        public int GetEquipmentID() { return this.equipmentID; }

        //Setters

        public void SetServiceID(int serviceID) { this.serviceID = serviceID; }
        public void SetServiceName(string serviceName) { this.serviceName = serviceName; }
        public void SetDescription(string description) { this.description = description; }
        public void SetRate(decimal rate) { this.rate = rate; }
        public void SetServiceStatus(string serviceStatus) { this.serviceStatus = serviceStatus; }
        public void SetEquipmentID(int equipmentID) { this.equipmentID = equipmentID; }


        public void getService(int serviceId)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            // Define the SQL query to be executed
            string sqlQuery = "SELECT * FROM Services WHERE ServiceID = " + serviceId;

            // Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            // Set instance variables with values from the data reader
            SetServiceID(dr.GetInt32(0));
            SetServiceName(dr.GetString(1));
            SetDescription(dr.GetString(2));
            SetRate(dr.GetDecimal(3));
            SetServiceStatus(dr.GetString(4));
            SetEquipmentID(dr.GetInt32(5));

            conn.Close();
        }


        // Method to add a new service
        public void AddService()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "INSERT INTO Services VALUES (" +
                this.serviceID + ",'" +
                this.serviceName + "','" +
                this.description + "'," +
                this.rate + ",'" +
                this.serviceStatus + "'," +
                this.equipmentID + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //Method to update service
        public void UpdateService()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE Services SET " +
                "ServiceName = '" + this.serviceName + "'," +
                "Description = '" + this.description + "'," +
                "Rate = " + this.rate + "," +
                "Status = '" + this.serviceStatus + "'," +
                "EquipmentID = " + this.equipmentID + " " +
                "WHERE ServiceID = " + this.serviceID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // Method to discontinue a service
        public void DiscontinueService()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "UPDATE Services SET Status = 'D' WHERE ServiceID = " + this.serviceID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //method to find service
        public static DataSet findServices(string serviceName)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            string sqlQuery = $"SELECT ServiceID, ServiceName, Description, Rate, Status, EquipmentID " +
                              $"FROM Services " +
                              $"WHERE UPPER(ServiceName) LIKE UPPER('%{serviceName}%') ORDER BY ServiceName";

            Console.WriteLine($"Executing query: {sqlQuery}");

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Services");

            Console.WriteLine($"Rows returned: {ds.Tables["Services"].Rows.Count}");

            conn.Close();

            return ds;
        }

        // Method to get the next service ID
        public static int GetNextServiceID()
        {
            int nextId = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT MAX(ServiceID) FROM Services";

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
    }
}

