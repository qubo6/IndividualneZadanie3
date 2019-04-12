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
    public partial class frmMain : Form
    {

        Logic _logic = new Logic();
        public frmMain()
        {
            InitializeComponent();
        }


        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            _logic.FilterTxt = txtFilter.Text;
            using (frmClientManagement newForm = new frmClientManagement(_logic))
            {
                
                newForm.ShowDialog();
                
            }
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount())
            {
                newForm.ShowDialog();
                
            }
        }

        private void cmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (frmAccounts newForm = new frmAccounts())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions())
            {
                newForm.ShowDialog();
            }
        }
    }
}
