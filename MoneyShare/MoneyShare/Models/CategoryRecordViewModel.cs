using MoneyShare.Core.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Models
{
    public class CategoryRecordViewModel
    {
        public IEnumerable<CategoryDTO> categoryViewModel;
        public IEnumerable<RecordDTO> recordViewModel;
    }
}
