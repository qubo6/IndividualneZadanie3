using BankSystem;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btnLog_Click(object sender, EventArgs e)
        {
            LogicLogin logicLogin = new LogicLogin();
            if (logicLogin.CheckinCard(int.Parse(txtCardId.Text), txtPin.Text.ToString()))
            {
                MessageBox.Show("Login is OK");
                count = 0;
                Close();
                using (frmISLAM_ATM newForm = new frmISLAM_ATM(int.Parse(txtCardId.Text)))
                {
                    newForm.ShowDialog();
                }                
            }
            else
            {
                MessageBox.Show("Bad Card Id or Pin");
                count++;
                if (count == 3)
                {
                    logicLogin.Block(int.Parse(txtCardId.Text));
                    MessageBox.Show("Card was blocked");
                    Close();
                }
            }

        }
    }
}
