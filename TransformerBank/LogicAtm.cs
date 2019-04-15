using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerBank
{
    public class LogicAtm
    {
        public bool NewTransaction(int id, decimal amount)
        {
            return new RepositoryTransaction().TransactionFromAtm(id, amount);
        }
        public bool MoneyOutAtm(int id, decimal amount)
        {
            return new RepositoryAccount().AtmFromClient(id, amount);
        }
        public bool MoneyInAtm(decimal amount)
        {
            return new RepositoryAccount().AtmToBank(amount);
        }
        public decimal MaxMoney(int id)
        {
            return new RepositoryAccount().MaxWithdrawal(id);
        }

    }
}
