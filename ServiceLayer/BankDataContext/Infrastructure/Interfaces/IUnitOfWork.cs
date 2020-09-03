using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BankDataContext.Infrastructure.Interfaces
{
    public interface IUnitOfWork<out TContext>
        where TContext : DbContext, new()
    {
        TContext DbDataContext { get; }
        void CreateTransaction();
        void Commit();
        void RoolBack();
        void SaveChanges();
    }
}
