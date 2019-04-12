using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ModelAccounts
    {
        public int Id { get; set; }
        public string IBAN { get; set; }
        public decimal Balance { get; set; }
        public decimal Debit { get; set; }
        public int ClientId { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
    }
}
