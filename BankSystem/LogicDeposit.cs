using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class LogicDeposit
    {
        public bool ClientDeposit(int accId, decimal amount)
        {
            return new RepositoryAccount().ClientDeposit(accId, amount);
        }
        public bool BankDeposit(decimal amount)
        {
            return new RepositoryAccount().BankDeposit(amount);
        }
        public bool TransactionDeposit(int accId, decimal amount)
        {
            return new RepositoryTransaction().TransactionDeposit(accId,amount);
        }
    }
}
