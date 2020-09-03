using ServiceLayer.BankDataContext.DTOs;
using ServiceLayer.BankDataContext.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BankDataContext.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<Usuarios>, IUserRepository
    {
        public UserRepository(IUnitOfWork<BankContext> unitOfWork) : base(unitOfWork) { }


        public UserRepository(BankContext context) : base(context){}


        public IEnumerable<Usuarios> GetUsuarioByUsername(string username)
        {
            return Context.Usuarios
                .Where(usuario => usuario.Username == username).ToList();
        }

    }
}
