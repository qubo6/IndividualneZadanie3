using Data.Repositories;
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
    public partial class frmClientManagement : Form
    {
        Logic _logic;
        RepositoryClient _repositoryClient = new RepositoryClient();
        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        public frmClientManagement(Logic logic)
        {
            _logic = logic;
            InitializeComponent();
            // lblClientInfo.Text = _repositoryClient.SelectClientInfo(_logic.FilterTxt);
            dgwClientInfo.DataSource = _repositoryClient.ClientBasicInfo(_logic.FilterTxt);
            dgwClientInfo.DataMember = "Client";
            dgwCardInfo.DataSource = _repositoryClient.ClientCard(_logic.FilterTxt);
            dgwCardInfo.DataMember = "Client";
        }

        //public frmClientManagement(Logic logic) : this(0)
        //{
        //    _logic = logic;
        //}
        //public frmClientManagement() : this(0) { }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public frmClientManagement(int clientId)
        {
            InitializeComponent();
            //lblClientInfo.Text = _repositoryClient.SelectClientInfo(_logic.FilterTxt);
        }

        //public frmClientManagement()
        //{
        //    InitializeComponent();
        //    lblClientInfo.Text = _repositoryClient.SelectClientInfo(_logic.FilterTxt);
        //}

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hodor?", "Hodor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
