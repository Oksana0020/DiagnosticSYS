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
    public partial class frmQueryEquipment : Form
    {
        mnuMainMenu parent;
        public frmQueryEquipment()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }



        private void btnQueryEquipment_Click(object sender, EventArgs e)
        {

            // Find matching equipment
            grdQueryEquipment.DataSource = Equipment.findEquipment(txtEquipmentName.Text).Tables["Equipments"];

            if (grdQueryEquipment.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtEquipmentName.Clear();
                txtEquipmentName.Focus();
                return;
            }

            grdQueryEquipment.Visible = true;
        }

        private void btnQueryEquipmentOK_Click(object sender, EventArgs e)
        {
            grpEquipmentDetails.Visible = false;
            grdQueryEquipment.Visible = false;
            txtEquipmentName.Clear();
            txtEquipmentName.Focus();
        }

        private void grdQueryEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Get the EquipmentID from the clicked row
                decimal equipmentId = Convert.ToDecimal(grdQueryEquipment.Rows[e.RowIndex].Cells["EquipmentID"].Value);

                // Create an instance of the Equipment class
                Equipment selectedEquipment = new Equipment();

                // Retrieve equipment info based on the EquipmentID
                selectedEquipment.getEquipment(equipmentId);

                // Display equipment info
                lblEquipmentID.Text = "Equipment ID: " + selectedEquipment.GetEquipmentID().ToString();
                lblEqName.Text = "Equipment Name: " + selectedEquipment.GetEquipmentName();
                lblModel.Text = "Model: " + selectedEquipment.GetModel();
                lblManufacturer.Text = "Manufacturer: " + selectedEquipment.GetManufacturer();
                lblPhoneNumber.Text = "Phone Number: " + selectedEquipment.GetManPhoneNumber().ToString();
                lblEmail.Text = "Email: " + selectedEquipment.GetManEmail();
                lblRoomNumber.Text = "Room Number: " + selectedEquipment.GetRoomNo().ToString();
                lblPurchaseDate.Text = "Purchase Date: " + selectedEquipment.GetEqPurchaseDate().ToString("dd-MMM-yyyy");

                grpEquipmentDetails.Visible = true;
            }
        }
    }
}
