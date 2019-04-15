using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ModelTransaction
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public decimal Amounth { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Variable_Symbol { get; set; }
        public string Specific_Symbol { get; set; }
        public string Constant_Symbol { get; set; }
        public string Message { get; set; }
    }
}
