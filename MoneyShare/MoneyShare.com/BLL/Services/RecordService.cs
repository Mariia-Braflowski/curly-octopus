using System;
using System.Collections.Generic;
using MoneyShare.Core.BLL.Inrefaces;
using MoneyShare.Core.DAL.Interfaces;
using MoneyShare.Core.BLL.DTO;
using MoneyShare.Core.DAL.Models;
using MoneyShare.Core.BLL.Infrastructure;
using AutoMapper;

namespace MoneyShare.Core.BLL.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRepository<Record> repository;

        public RecordService(IRepository<Record> repository)
        {
            this.repository = repository;
        }
        public void CreateRecord(RecordDTO record)
        {
            Record recordDB = repository.Get(record.RecordId);
            if (recordDB == null)
            {
                repository.Create(new Record
                {
                    RecordId = record.RecordId,
                    CategoryId = record.CategoryId,
                    Amount = record.Amount,
                    Date = record.Date
                });
            }
        }

        public RecordDTO GetRecord(int id)
        {
            Record record = repository.Get(id);
            if (record == null)
                throw new ValidationException("Record", "Record not found");
            return new RecordDTO {
                RecordId = record.RecordId,
                CategoryId = record.CategoryId,
                Amount = record.Amount,
                Date = record.Date
            };
        }
        public IEnumerable<RecordDTO> GetRecords()
        {
            var config = new MapperConfiguration(con => con.CreateMap<Record, RecordDTO>());
            var mapper = new Mapper(config);
            return mapper.Map<IEnumerable<Record>, IEnumerable<RecordDTO>>(new List<Record> { });//return mapper.Map<IEnumerable<Record>,IEnumerable<RecordDTO>>(Database.Records.GetAll());
        }
        public void DeleteRecord(int id)
        {
            repository.Delete(id);
        }

    }
}
