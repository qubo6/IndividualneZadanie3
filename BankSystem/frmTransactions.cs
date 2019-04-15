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
    public partial class frmTransactions : Form
    {

        private RepositoryTransaction _repositoryTransaction = new RepositoryTransaction();
        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public frmTransactions()
        {
            InitializeComponent();
            dgwAllTransaction.DataSource = _repositoryTransaction.AllTransaction();
            dgwAllTransaction.DataMember = "[TRANSACTION]";
        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="clientId"></param>
        public frmTransactions(int clientId)
        {
            InitializeComponent();
            dgwAllTransaction.DataSource = _repositoryTransaction.TransactionOfClient(clientId);
            dgwAllTransaction.DataMember = "[TRANSACTION]";

        }
    }
}
