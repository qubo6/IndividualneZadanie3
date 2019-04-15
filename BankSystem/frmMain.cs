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

        private Logic _logic = new Logic();
        private LogicOverView _logicOverView = new LogicOverView();
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

        private void btnBankAss_Click(object sender, EventArgs e)
        {
            dgwOverView.DataSource = _logicOverView.BankAssets();
            dgwOverView.DataMember = "ACCOUNT";
        }

        private void btnDemography_Click(object sender, EventArgs e)
        {
            dgwOverView.DataSource = _logicOverView.Demography();
            dgwOverView.DataMember = "[address]";
        }

        private void btnActiveAcc_Click(object sender, EventArgs e)
        {
            dgwOverView.DataSource = _logicOverView.ActiveAccount();
            dgwOverView.DataMember = "ACCOUNT";
        }

        private void btnNewest_Click(object sender, EventArgs e)
        {
            dgwOverView.DataSource = _logicOverView.NewestAccount();
            dgwOverView.DataMember = "ACCOUNT";
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            dgwOverView.DataSource = _logicOverView.Top10Client();
            dgwOverView.DataMember = "ACCOUNT";
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
