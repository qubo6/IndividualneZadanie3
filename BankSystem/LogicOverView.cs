using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class LogicOverView
    {
        public DataSet BankAssets()
        {
            return new RepositoryAccount().OverViewBankAssets();
        }
        public DataSet Demography()
        {
            return new RepositoryAddress().OverViewDemography();
        }
        public DataSet Top10Client()
        {
            return new RepositoryAccount().OverViewTop10Acc();
        }
        public DataSet ActiveAccount()
        {
            return new RepositoryAccount().OverViewActiveAcc();
        }
        public DataSet NewestAccount()
        {
            return new RepositoryAccount().OverViewLast6months();
        }
    }
}
