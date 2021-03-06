﻿using System;
using System.Collections.Generic;
using MoneyShare.Core.DAL.Interfaces;
using MoneyShare.Core.DAL.Models;
using MoneyShare.Core.DAL.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MoneyShare.Core.DAL.Repositories
{
    public class RecordRepository : IRepository<Record>
    {
        private ApplicationContext db;
        public RecordRepository(ApplicationContext db)
        {
            this.db = db;
        }
        public void Create(Record item)
        {
            db.Records.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Record record = db.Records.Find(id);
            if (record != null)
            {
                db.Records.Remove(record);
                db.SaveChanges();
            }
        }

        public IEnumerable<Record> Find(Func<Record, bool> predicate)
        {
            return db.Records.Include(o => o.RecordId).Where(predicate).ToList();
        }

        public Record Get(int id)
        {
            return db.Records.Find(id);
        }

        public IEnumerable<Record> GetAll()
        {
            return db.Records;
        }

        public void Update(Record item)
        {
            db.Entry(item).State = EntityState.Modified; //ToDo: ?
        }
    }
}
