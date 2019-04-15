using Data;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class LogicAccount
    {
        //private ModelClient _modelClient = new ModelClient();

        public ModelClient RandomClient()
        {
            return new GeneratorClient().GenerateClient();
        }
        public ModelAddress RandomAddress()
        {
            return new GeneratorClient().GenerateAddress();
        }
        public ModelAccounts NewAccount()
        {
            return new GenarateAccount().GenerateAccount();
        }

        public bool CreateBankClient(ModelAddress modelAddress, ModelClient modelClient, ModelAccounts modelAccounts)
        {
            int addressId = new RepositoryAddress().AddAddress(modelAddress);
            if (addressId>0)
            {
                int clientId = new RepositoryClient().AddClient(modelClient, addressId);
                if (clientId>0)
                {
                    return new RepositoryAccount().AddAccount(modelAccounts, clientId);                     
                }
            }
            return false;
        }
        public ModelClient clientForUpdate(int id)
        {
            return new RepositoryClient().SetForUpdate(id);
        }
        public ModelAddress addressForUpdate(int id)
        {
            return new RepositoryAddress().SetForUpdate(clientForUpdate(id).AddressId);
        }
    }
}
