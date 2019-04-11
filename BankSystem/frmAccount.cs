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
    public partial class frmAccount : Form
    {
        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (frmClient newForm = new frmClient())
            {
                newForm.ShowDialog();
            }
        }
    }
}
