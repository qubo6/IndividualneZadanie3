using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class LogicTransaction
    {
        public DataSet Recepient(string iban)
        {
            return new RepositoryAccount().TransactionToClient(iban);
        }
        //public DataSet Sender(int accId)
        //{
        //    return new RepositoryAccount().ClientAccount(accId);
        //}
        public bool Transaction(int idsender, int idrecipient, decimal amount, string vs, string ss, string ks, string mess)
        {
            return new RepositoryTransaction().Transaction(idsender, idrecipient, amount, vs, ss, ks, mess);
        }
        public bool TransactionSender(int id, decimal amount)
        {
            return new RepositoryAccount().TransactionSender(id, amount);
        }
        public bool TransactionRecepient(int id, decimal amount)
        {
            return new RepositoryAccount().TransactionRecepient(id, amount);
        }
    }
}
