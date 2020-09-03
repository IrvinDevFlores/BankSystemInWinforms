
using ServiceLayer.BankDataContext.DTOs;
using ServiceLayer.BankDataContext.Infrastructure;
using ServiceLayer.BankDataContext.Infrastructure.Interfaces;
using ServiceLayer.BankDataContext.Infrastructure.Repositories;
using System;

namespace ServiceLayer
{
    public  class StartupDatabase
    {  
        public static UnitOfWork<BankContext> unitOfWork = new UnitOfWork<BankContext>();
        public static GenericRepository<Usuarios> repository = new GenericRepository<Usuarios>(unitOfWork);
        public static IUserRepository userRepository = new UserRepository(unitOfWork);

    }
}
