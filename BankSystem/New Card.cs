using Data.Models;
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
    public partial class frmNew_Card : Form
    {
        private int accountId;
        public frmNew_Card(int acc_Id)
        {
            InitializeComponent();
            this.accountId = acc_Id;           
        }
        
        LogicCard logicCard = new LogicCard();
        ModelCard newCard = new ModelCard();
        
        private void btnSaveCard_Click(object sender, EventArgs e)
        {
            newCard = new LogicCard().NewCard();
            //MessageBox.Show(newCard.Validity_from.ToString() + ' '+ newCard.Validity_until.ToString() + ' '+ newCard.CardNumber.ToString());
            newCard.Pin = (txtPin.Text).ToCharArray();
            logicCard.CreateCard(newCard, accountId);
        }
    }
}
