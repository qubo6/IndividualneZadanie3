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
    public class LogicCard
    {
        public ModelCard NewCard()
        {
            return new GenerateCard().GenerateNewCard();
        }
        public bool CreateCard(ModelCard modelCard, int acc_id)
        {
            return new RepositoryCard().AddCard(modelCard, acc_id);
        }
    }
}
