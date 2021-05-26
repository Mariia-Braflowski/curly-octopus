using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyShare.Core.BLL.DTO
{
    class CategoryDTO
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public int CategoryType { get; set; }
    }
}
