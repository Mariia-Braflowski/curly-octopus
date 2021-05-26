using System;
using System.Collections.Generic;
using MoneyShare.Core.BLL.Inrefaces;
using MoneyShare.Core.DAL.Interfaces;
using MoneyShare.Core.DAL.Models;

namespace MoneyShare.Core.BLL.Services
{
    class RecordService : IRecordService
    {
        IUnitOfWork Database { get; set; }

        public RecordService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void CreateRecord(Record record)
        {
            Database.Records.Create(record);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Record GetRecord(int id)
        {
            return Database.Records.Get(id);
        }

        public IEnumerable<Record> GetRecords()
        {
            return Database.Records.GetAll();
        }
    }
}
