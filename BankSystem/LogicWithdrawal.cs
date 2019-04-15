using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class LogicWithdrawal
    {
        public bool ClientWithdrawal(int accId, decimal amount)
        {
            return new RepositoryAccount().ClientWithdrawal(accId, amount);
        }
        public bool BankWithdrawal(decimal amount)
        {
            return new RepositoryAccount().BankWithdrawal(amount);
        }
        public bool TransactionWithdrawal(int accId, decimal amount)
        {
            return new RepositoryTransaction().TransactionWithdrawal(accId, amount);
        }
    }
}
