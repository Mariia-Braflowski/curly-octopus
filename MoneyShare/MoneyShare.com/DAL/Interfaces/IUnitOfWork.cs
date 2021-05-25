using MoneyShare.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyShare.Core.DAL.Interfaces
{
    interface IUnitOfWork
    {
        IRepository<Category> Categories { get; }
        IRepository<Record> Records { get; }
        void Save();
    }
}
