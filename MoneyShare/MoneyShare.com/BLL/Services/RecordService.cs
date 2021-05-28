﻿using System;
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
        IUnitOfWork Database { get; set; }

        public RecordService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void CreateRecord(RecordDTO record)
        {
            Record recordDB = Database.Records.Get(record.RecordId);
            if (recordDB == null)
            {
                Database.Records.Create(new Record
                {
                    RecordId = record.RecordId,
                    CategoryId = record.CategoryId,
                    Amount = record.Amount,
                    Date = record.Date
                });
                Database.Save();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public RecordDTO GetRecord(int id)
        {
            Record record = Database.Records.Get(id);
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
            return mapper.Map<IEnumerable<Record>,IEnumerable<RecordDTO>>(Database.Records.GetAll());
        }
    }
}
