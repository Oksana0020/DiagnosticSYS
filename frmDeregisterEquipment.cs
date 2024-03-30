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
    public partial class frmDeregisterEquipment : Form
    {
        mnuMainMenu parent;
        Equipment deregisteredEquipment;
        public frmDeregisterEquipment()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
            this.deregisteredEquipment = new Equipment();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnDeregEquipmentSearch(object sender, EventArgs e)
        {
            // Find matching equipment
            grdDereqisterEquipment.DataSource = Equipment.findEquipment(txtEquipmentName.Text).Tables["Equipments"];

            if (grdDereqisterEquipment.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtEquipmentName.Clear();
                txtEquipmentName.Focus();
                return;
            }

            grdDereqisterEquipment.Visible = true;
        }



        private void btnConfirmDeregisterEq_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to de-register this Equipment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                deregisteredEquipment.DeregisterEquipment();

                MessageBox.Show("Medical Equipment has been de-registered in Database",
                    "Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                // Reset UI
                grpEquipmentInfo.Visible = false;
                grdDereqisterEquipment.Visible = false;
                txtEquipmentName.Clear();
                txtEquipmentName.Focus();
            }
        }

        private void grdDeregisterEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                // Get the EquipmentID from the clicked row
                decimal equipmentId = Convert.ToDecimal(grdDereqisterEquipment.Rows[e.RowIndex].Cells["EquipmentID"].Value);

                // Retrieve equipment info
                deregisteredEquipment.getEquipment(equipmentId);

                // Display equipment info in form controls
                txtEquipmentID.Text = deregisteredEquipment.GetEquipmentID().ToString();
                txtEquipmentNames.Text = deregisteredEquipment.GetEquipmentName();
                txtModel.Text = deregisteredEquipment.GetModel();
                txtManufacturer.Text = deregisteredEquipment.GetManufacturer();
                txtPhoneNumber.Text = deregisteredEquipment.GetManPhoneNumber().ToString();
                txtEmail.Text = deregisteredEquipment.GetManEmail();
                txtRoomNumber.Text = deregisteredEquipment.GetRoomNo().ToString();
                dtpPurchaseDate.Value = deregisteredEquipment.GetEqPurchaseDate();

                grpEquipmentInfo.Visible = true;
            }
        }
    }

