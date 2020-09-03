
using ServiceLayer;
using ServiceLayer.BankDataContext.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain.Autenticacion
{
    public class AutenticacionService
    {
        public bool ValidarCredenciales(Usuarios usuario)
        {
            List<Usuarios> usuarios = StartupDatabase.userRepository.GetAll().ToList();

            Usuarios usuarioBuscado = usuarios.FirstOrDefault(us => us.Password.Equals(usuario.Password)
                                                    && us.Username.Equals(usuario.Username));
            if(usuarioBuscado == null)
            {
                MessageBox.Show("Credenciales incorrectas");
                return false;   
            }
            bool estaDeshabilitado = usuarioBuscado.Estado == 0 ? true : false;
            if (estaDeshabilitado)
            {
                MessageBox.Show("Usted ha sido deshabilitado");
                return false;
            }
            MessageBox.Show("Bienvenido");
            return true;

        }
    }
}
