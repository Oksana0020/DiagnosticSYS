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
    public partial class frmYearlyDiagnosticAnalysis : Form
    {
        mnuMainMenu parent;
        public frmYearlyDiagnosticAnalysis()
        {
            InitializeComponent();
            this.parent = new mnuMainMenu();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            picMain.Visible = true;
        }
    }
}
