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
    public partial class frmTransaction : Form
    {
        private LogicManagment _logicManagment = new LogicManagment();
        private LogicDeposit _logicDeposit = new LogicDeposit();
        private LogicWithdrawal _logicWithdrawal = new LogicWithdrawal();
        private LogicTransaction _logicTransaction = new LogicTransaction();
        private int accountId;
        public frmTransaction(int type, int accId)    //deposit-vklad
        {
            InitializeComponent();
            this.accountId = accId;
            if (type == 1)
            {
                btnWithdrawal.Visible = false;
                btnWithdrawal.Enabled = false;
                HideComponents();
                FillGridDeposit();
            }
            if (type==2)
            {
                btnDeposit.Visible = false;
                btnDeposit.Enabled = false;
                HideComponents();
                FillGridWithdrawal();
            }
            if (type == 3)
            {
                btnDeposit.Visible = false;
                btnDeposit.Enabled = false;
                btnWithdrawal.Visible = false;
                btnWithdrawal.Enabled = false;
                btnTransaction.Visible = false;
                btnTransaction.Enabled = false;
                FillGridSender();
                
            }
        }
        private void HideComponents()
        {
            lblCs.Visible = false;
            lblMess.Visible = false;
            lblSS.Visible = false;
            lblVs.Visible = false;
            lblSearch.Visible = false;
            txtIban.Visible = false;
            txtIban.Enabled = false;
            txtConst.Visible = false;
            txtConst.Enabled = false;
            txtMess.Visible = false;
            txtMess.Enabled = false;
            txtSpecific.Visible = false;
            txtSpecific.Enabled = false;
            txtVariable.Visible = false;
            txtVariable.Enabled = false;
            btnSearch.Visible = false;
            btnSearch.Enabled = false;
            btnTransaction.Visible = false;
            btnTransaction.Enabled = false;
        }

        public void FillGridRecepient()
        {
            dgwRecepient.DataSource = _logicTransaction.Recepient(txtIban.Text);
            dgwRecepient.DataMember = "ACCOUNT";
            if (dgwRecepient.Rows.Count==0)
            {
                MessageBox.Show("This IBAN does not exist");
            }
            else
            {
                btnTransaction.Visible = true;
                btnTransaction.Enabled = true;
            }
            dgwRecepient.Columns[0].Visible = false;
        }
        public void FillGridSender()
        {
            dgwSender.DataSource = _logicManagment.ClientAccount(accountId);
            dgwSender.DataMember = "ACCOUNT";
        }
        private void FillGridDeposit()
        {
            dgwSender.DataSource = _logicManagment.BankUser();
            dgwRecepient.DataSource = _logicManagment.ClientAccount(accountId);
            dgwRecepient.DataMember = "ACCOUNT";
            dgwSender.DataMember = "ACCOUNT";
        }
        private void FillGridWithdrawal()
        {
            dgwSender.DataSource = _logicManagment.ClientAccount(accountId);
            dgwRecepient.DataSource = _logicManagment.BankUser();
            dgwRecepient.DataMember = "ACCOUNT";
            dgwSender.DataMember = "ACCOUNT";
        }

        public frmTransaction()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            _logicDeposit.BankDeposit(int.Parse(ntbAmount.Text.ToString()));
            _logicDeposit.ClientDeposit(accountId, int.Parse(ntbAmount.Text.ToString()));
            _logicDeposit.TransactionDeposit(accountId, int.Parse(ntbAmount.Text.ToString()));
            FillGridDeposit();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            _logicWithdrawal.BankWithdrawal(int.Parse(ntbAmount.Text.ToString()));
            _logicWithdrawal.ClientWithdrawal(accountId, int.Parse(ntbAmount.Text.ToString()));
            _logicWithdrawal.TransactionWithdrawal(accountId, int.Parse(ntbAmount.Text.ToString()));
            FillGridWithdrawal();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGridRecepient();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            _logicTransaction.Transaction(accountId, int.Parse(dgwRecepient.Rows[0].Cells[0].Value.ToString()), decimal.Parse(ntbAmount.Text), txtVariable.Text, txtSpecific.Text, txtConst.Text, txtMess.Text);
            _logicTransaction.TransactionSender(accountId, decimal.Parse(ntbAmount.Text));
            _logicTransaction.TransactionRecepient(int.Parse(dgwRecepient.Rows[0].Cells[0].Value.ToString()), decimal.Parse(ntbAmount.Text));
            FillGridRecepient();
            FillGridSender();
        }
    }
}
