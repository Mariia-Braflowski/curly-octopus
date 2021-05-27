using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Models
{
    public class CategoryRecordViewModel
    {
        public IEnumerable<CategoryViewModel> categoryViewModel { get; set; }
        public IEnumerable<RecordViewModel> recordViewModel { get; set; }
    }
}
