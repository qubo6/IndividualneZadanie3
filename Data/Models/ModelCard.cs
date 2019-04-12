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
        public int Pin { get; set; }
        public string CardNumber { get; set; }
        public DateTime Validity { get; set; }
        public int AccountId { get; set; }
    }
}
