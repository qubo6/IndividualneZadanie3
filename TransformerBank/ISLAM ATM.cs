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

namespace TransformerBank
{
    public partial class frmISLAM_ATM : Form
    {
        private int cardId;
        private RepositoryAccount _repositoryAccount = new RepositoryAccount();
        private LogicAtm _logicAtm = new LogicAtm();
        public frmISLAM_ATM(int id)
        {
            InitializeComponent();
            this.cardId = id;
            FillGrid();
        }

        private void FillGrid()
        {
            dgwCurrentBalance.DataSource = _repositoryAccount.CurrentBalnce(cardId);
            dgwCurrentBalance.DataMember = "ACCOUNT";
            dgwCurrentBalance.Columns[0].Visible = false;
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            if (_logicAtm.MaxMoney((int.Parse(dgwCurrentBalance.Rows[0].Cells[0].Value.ToString()))) >= decimal.Parse(ntbAmount.Text))
            {
                _logicAtm.NewTransaction((int.Parse(dgwCurrentBalance.Rows[0].Cells[0].Value.ToString())), decimal.Parse(ntbAmount.Text));
                _logicAtm.MoneyOutAtm((int.Parse(dgwCurrentBalance.Rows[0].Cells[0].Value.ToString())), decimal.Parse(ntbAmount.Text));
                _logicAtm.MoneyInAtm(decimal.Parse(ntbAmount.Text));
                FillGrid();
                MessageBox.Show("Have a nice day");
                Close();
            }
            else
            {
                MessageBox.Show("Not enough money in your account");
                Close();
            }
           
            
        }
    }
}
