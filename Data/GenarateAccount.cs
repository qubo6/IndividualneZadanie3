using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GenarateAccount
    {
        public ModelAccounts GenerateAccount()
        {
            string IbanGenerator()
            {
                StringBuilder iban = new StringBuilder();
                iban.Append("SK");
                Random random = new Random();
                while (iban.Length < 24)
                {
                    iban.Append($"{random.Next(0, 9)}");
                }
                return iban.ToString();
            }
            ModelAccounts modelAccounts = new ModelAccounts()
            {
                IBAN = IbanGenerator(),
                OpenDate = DateTime.Now,

            };
            return modelAccounts;
        }
    }
}
