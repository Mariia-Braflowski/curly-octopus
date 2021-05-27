using MoneyShare.Core.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyShare.Core.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Category> Categories { get; }
        IRepository<Record> Records { get; }
        void Save();
    }
}
