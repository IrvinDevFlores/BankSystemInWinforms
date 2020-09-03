using ServiceLayer.BankDataContext.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BankDataContext.Infrastructure.Interfaces
{
    public interface IUserRepository : IGenericRepository<Usuarios>
    {
        IEnumerable<Usuarios> GetUsuarioByUsername(string username);
    }
}
