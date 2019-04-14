using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ModelCard
    {
        public int Id { get; set; }
        public char[] Pin { get; set; }
        public string CardNumber { get; set; }
        public DateTime Validity_from { get; set; }
        public DateTime Validity_until { get; set; }
        public bool Blocked { get; set; }
        public int AccountId { get; set; }
    }
}
