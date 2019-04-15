using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class LogicDebit
    {
        public bool EditDebit(int id, decimal debit)
        {
            return new RepositoryAccount().DebitEdit(id, debit);
        }
    }
}
