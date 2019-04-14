using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GenerateCard
    {
        public ModelCard GenerateNewCard()
        {
            string CardNumberCreate()
            {
                StringBuilder number = new StringBuilder();
                Random r = new Random();
                number.Append($"{r.Next(1, 9)}");
                while (number.Length<16)
                {
                    number.Append($"{r.Next(0, 9)}");
                }
                return number.ToString();
            }
            ModelCard newCard = new ModelCard()
            {
                CardNumber = CardNumberCreate(),
                Validity_from = DateTime.Now,
                Validity_until = DateTime.Now.AddYears(4)
            };
            return newCard;
        }

    }
}
