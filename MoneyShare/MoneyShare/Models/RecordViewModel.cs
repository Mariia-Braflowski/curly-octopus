using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Models
{
    public class RecordViewModel
    {
        public int RecordId { get; set; }
        public int CategoryId { get; set; }
        public Decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
