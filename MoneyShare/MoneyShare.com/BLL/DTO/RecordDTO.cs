﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyShare.Core.BLL.DTO
{
    public class RecordDTO
    {
        public int RecordId { get; set; }
        public int CategoryId { get; set; }
        public Decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
