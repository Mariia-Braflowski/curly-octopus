using MoneyShare.Core.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyShare.Core.BLL.Inrefaces
{
    public interface IRecordService
    {
        public void CreateRecord(Record recod);
        public IEnumerable<Record> GetRecords();
        public Record GetRecord(int id);
        void Dispose();
    }
}
