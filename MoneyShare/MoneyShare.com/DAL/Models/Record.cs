using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Core.DAL.Models
{
    [Table("records")]
    public class Record
    {
        [Column("record_id")]
        public int RecordId { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("amount")]
        public Decimal Amount { get; set; }
        [Column("date_record")]
        public DateTime Date { get; set; }
    }
}
