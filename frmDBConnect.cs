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

namespace DiagnosticSYS
{
    public partial class frmDBConnect : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oraDB);
        public frmDBConnect()
        {
            InitializeComponent();
        }

        private void lblEquipmentName_Click(object sender, EventArgs e)
        {
            
        }

        private void clickConnect(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                lblStatus.Text = "CLOSED";
                lblStatus.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                conn.Open();
                lblStatus.Text = "OPEN";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
