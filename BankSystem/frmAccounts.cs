using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmAccounts : Form
    {
        private LogicAllAcounts _logicAllAcounts = new LogicAllAcounts();
        public frmAccounts()
        {
            InitializeComponent();
            dgwAll.DataSource = _logicAllAcounts.AllAccounts();
            dgwAll.DataMember = "account";
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            using (frmClientManagement newForm = new frmClientManagement(dgwAll.CurrentRow.Cells[1].Value.ToString()))
            {
                newForm.ShowDialog();
            }
        }
    }
}
