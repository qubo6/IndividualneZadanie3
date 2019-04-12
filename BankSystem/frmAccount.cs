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
    public partial class frmAccount : Form
    {
        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();
        }
        LogicAccount logicAccount = new LogicAccount();


        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {
            InitializeComponent();
        }
        ModelClient randomClient = new ModelClient();
        ModelAddress randomAddress = new ModelAddress();
        ModelAccounts newAccount = new ModelAccounts();

        private void button1_Click(object sender, EventArgs e)
        {
            randomClient = new LogicAccount().RandomClient();
            randomAddress = new LogicAccount().RandomAddress();
            txtName.Text = randomClient.FirstName;
            txtSurname.Text = randomClient.LastName;
            txtIdentityCard.Text = randomClient.IdentityCard;
            txtPhone.Text = randomClient.PhoneNumber;
            txtMail.Text = randomClient.Email;
            txtStreet.Text = randomAddress.Street;
            txtCity.Text = randomAddress.City;
            txtPostCode.Text = randomAddress.PostalCode;
            
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            newAccount = new LogicAccount().NewAccount();
            randomAddress.Street = txtStreet.Text;
            randomAddress.City = txtCity.Text;
            randomAddress.PostalCode = txtPostCode.Text;
            randomClient.FirstName = txtName.Text;
            randomClient.LastName = txtSurname.Text;
            randomClient.IdentityCard = txtIdentityCard.Text;
            randomClient.PhoneNumber = txtPhone.Text;
            randomClient.Email = txtMail.Text;


            logicAccount.CreateBankClient(randomAddress, randomClient, newAccount);
        }
    }
}
