
using ServiceLayer.BankDataContext;
using ServiceLayer.BankDataContext.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Autenticacion
{
    
    public class LoginService
    {
        AutenticacionService _servicioAutenticacion;

        public LoginService()
        {
            _servicioAutenticacion = new AutenticacionService();
        }
        public bool Login(Usuarios usuario)
        {
            return _servicioAutenticacion.ValidarCredenciales(usuario);
        }

    }
}
