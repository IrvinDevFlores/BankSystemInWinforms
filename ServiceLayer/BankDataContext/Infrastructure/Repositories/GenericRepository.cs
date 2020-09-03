using ServiceLayer.BankDataContext.DTOs;
using ServiceLayer.BankDataContext.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BankDataContext.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>,
        IDisposable where T : class
    {

        public IDbSet<T> _entities;
        public string _errorMessage = string.Empty;
        private bool _isDisposed;

        public GenericRepository(IUnitOfWork<BankContext> unitOfWork)
            :this(unitOfWork.DbDataContext)
        {

        }

        public BankContext Context;
        public GenericRepository(BankContext context)
        {
            _isDisposed = false;
            Context = context;
        }

        public virtual IQueryable<T> Table => EntitiesDbSet;


        public virtual IDbSet<T> EntitiesDbSet => _entities ??
                                                  (_entities = Context.Set<T>());

        public void Delete(T data)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if(Context != null)
            {
                Context.Dispose();
                _isDisposed = true;
            }
        }

        public IEnumerable<T> GetAll() => EntitiesDbSet.ToList();


        public T GetById(object id) => EntitiesDbSet.Find(id);

        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentException("entity");
                }
                EntitiesDbSet.Add(entity);
                    if (Context == null || _isDisposed)
                    {
                        Context = new BankContext();
                    }
              
            } catch (Exception e) { }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentException("entity");
                }
                EntitiesDbSet.Add(entity);
                if (Context == null || _isDisposed)
                {
                    Context = new BankContext();
                    SetEntryModified(entity);    
                }

            }
            catch (Exception e) { }
        }

        public virtual void SetEntryModified(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
    }
}
