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
    public partial class frmDebit : Form
    {
        private int _accountId;
        private LogicDebit _logicDebit = new LogicDebit();
        public frmDebit(int accId)
        {
            InitializeComponent();
            this._accountId = accId;
        }

        private void btnSaveDebit_Click(object sender, EventArgs e)
        {
            _logicDebit.EditDebit(_accountId, decimal.Parse(ntbDebit.Text));
            Close();
        }
    }
}
