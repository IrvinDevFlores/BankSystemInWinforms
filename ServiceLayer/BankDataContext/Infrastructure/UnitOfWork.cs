using ServiceLayer.BankDataContext.Infrastructure.Interfaces;
using ServiceLayer.BankDataContext.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BankDataContext.Infrastructure
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>,
        IDisposable where TContext : DbContext, new()
    {
        private readonly TContext _context;
        private TContext DataContext => _context;
        private bool _isDisposed;
        private string _errorMessage = string.Empty;



        public DbContextTransaction _objTransac { get; set; }

        public TContext DbDataContext => _context;

        private Dictionary<string, object> _repositories;

        public UnitOfWork()
        {
            _context = new TContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                if (disposing) { _context.Dispose(); _isDisposed = true; }
            }
        }

        public void CreateTransaction()
        {
            _objTransac = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _objTransac.Commit();
        }

        public void RoolBack()
        {
            _objTransac.Rollback();
            _objTransac.Dispose();
        }

        public async void SaveChanges()
        {
            try
            {
                await _context.SaveChangesAsync();
            }catch(Exception e) {}
        }

        public GenericRepository<T> GenericRepository<T>()
            where T : class
        {
            if(_repositories == null)
            
                _repositories = new Dictionary<string, object>();
                var type = typeof(T).Name;

                bool isRepositoryDosntContainKey = !_repositories
                                                     .ContainsKey(type);
                if (isRepositoryDosntContainKey)
                {
                    var repositoryType = typeof(GenericRepository<T>);

                    var repositoryInstance = Activator
                        .CreateInstance(repositoryType.MakeGenericType(typeof(T)) ,_context);

                    _repositories.Add(type, repositoryInstance);
                }
            
            return (GenericRepository<T>)_repositories[type];
        }
    }
}
