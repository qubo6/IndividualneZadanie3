using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class LogicAllAcounts
    {
        public DataSet AllAccounts()
        {
            return new RepositoryAccount().AllAccounts();
        }
    }
}
