using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Models
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public int CategoryType { get; set; }
    }
}
