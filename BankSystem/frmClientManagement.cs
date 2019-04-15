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
        private Logic _logic = new Logic();
        private RepositoryClient _repositoryClient = new RepositoryClient();
        private LogicManagment _logicManagment = new LogicManagment();
        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        public frmClientManagement(Logic logic)
        {
            _logic = logic;
            InitializeComponent();
            FillGrid();            
        }
        public frmClientManagement(string iban)
        {
            _logic.FilterTxt = iban;
            InitializeComponent();            
            FillGrid();
        }

        private void FillGrid()
        {                        
            dgwClientInfo.DataSource = _repositoryClient.ClientBasicInfo(_logic.FilterTxt);
            dgwClientInfo.DataMember = "Client";
            dgwCardInfo.DataSource = _repositoryClient.ClientCard(_logic.FilterTxt);
            dgwCardInfo.DataMember = "Client";
            dgwClientInfo.Columns[0].Visible = false;   //accId
            dgwClientInfo.Columns[1].Visible = false;   //clientId
            dgwCardInfo.Columns[0].Visible = false;
            if (dgwClientInfo.Rows.Count == 0)
            {
                MessageBox.Show("Incorrect IBAN or Identity Card");
                DialogResult= DialogResult.Abort;
            }
        }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>


        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(int.Parse(dgwClientInfo.Rows[0].Cells[1].Value.ToString())))
            {
                newForm.ShowDialog();
            }
            FillGrid();
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(1,int.Parse(dgwClientInfo.Rows[0].Cells[0].Value.ToString())))
            {
                newForm.ShowDialog();
            }
            FillGrid();
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(2,int.Parse(dgwClientInfo.Rows[0].Cells[0].Value.ToString())))
            {
                newForm.ShowDialog();
            }
            FillGrid();
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(int.Parse(dgwClientInfo.Rows[0].Cells[0].Value.ToString())))
            {
                newForm.ShowDialog();
            }
            FillGrid();
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(3, int.Parse(dgwClientInfo.Rows[0].Cells[0].Value.ToString())))
            {
                newForm.ShowDialog();
            }
            FillGrid();
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            _logicManagment.CloseAcc(int.Parse(dgwClientInfo.Rows[0].Cells[0].Value.ToString()));
            _logicManagment.BlockCard(int.Parse(dgwCardInfo.Rows[0].Cells[0].Value.ToString()));
            FillGrid();
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            using (frmNew_Card newForm = new frmNew_Card(int.Parse(dgwClientInfo.Rows[0].Cells[0].Value.ToString())))
            {
                newForm.ShowDialog();
            }
            FillGrid();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            _logicManagment.BlockCard(int.Parse(dgwCardInfo.CurrentRow.Cells[0].Value.ToString()));
            FillGrid();
        }

        private void btnUnblock_Click(object sender, EventArgs e)
        {
            _logicManagment.Unblock(int.Parse(dgwCardInfo.CurrentRow.Cells[0].Value.ToString()));
            FillGrid();
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            using (frmDebit newForm = new frmDebit(int.Parse(dgwClientInfo.Rows[0].Cells[0].Value.ToString())))
            {
                newForm.ShowDialog();
            }
            FillGrid();
        }
    }
}
