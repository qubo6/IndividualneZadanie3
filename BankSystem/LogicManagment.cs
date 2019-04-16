using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class LogicManagment
    {
        public bool BlockCard(int idCard)
        {
            return new RepositoryCard().BlockCard(idCard);
        }
        public bool Unblock(int idCard)
        {
            return new RepositoryCard().UnblockCard(idCard);
        }
        public DataSet BankUser()
        {
            return new RepositoryAccount().BankAccount();
        }
        public DataSet ClientAccount(int accId)
        {
            return new RepositoryAccount().ClientAccount(accId);
        }
        //public DataSet ClientInfo2(string iban)
        //{
        //    return new RepositoryClient().ClientBasicInfo2(iban);
        //}
        //public DataSet CardInfo2(int id)
        //{
        //    return new RepositoryClient().ClientCard2(id);
        //}
        public bool CloseAcc(int id)
        {
            return new RepositoryAccount().CloseAccount(id);
        }
        public decimal MaxAmounth(int id)
        {
            return new RepositoryAccount().MaxWithdrawal(id);
        }
        
    }
}
