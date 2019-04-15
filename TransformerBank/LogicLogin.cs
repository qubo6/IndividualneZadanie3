using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class LogicLogin
    {
        public bool CheckinCard(int log, string pin)
        {
            return new RepositoryCard().CheckCard(log, pin);
        }
        public bool Block(int log)
        {
            return new RepositoryCard().BlockCard(log);
        }

    }
}
