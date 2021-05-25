using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Models
{
    [Table("categories")]
    public class Category
    {
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("color")]
        public string Color { get; set; }
        [Column("icon")]
        public string Icon { get; set; }
        [Column("category_type")]
        public int CategoryType { get; set; }
    }
}
