using Domain.Autenticacion;
using ServiceLayer.BankDataContext;
using ServiceLayer.BankDataContext.DTOs;
using ServiceLayer.BankDataContext.Infrastructure;
using ServiceLayer.BankDataContext.Infrastructure.Interfaces;
using ServiceLayer.BankDataContext.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp_0._1_Solution
{
    public partial class LoginForm : Form
    {

        UnitOfWork<BankContext> unitOfWork = new UnitOfWork<BankContext>();

        public LoginForm()
        {
            InitializeComponent();
            InitComboBox();

        }

       
        public void InitComboBox()
        {

            GenericRepository<Agencia> genericRepository = new GenericRepository<Agencia>(unitOfWork);
            IAgenciaRepository agenciaRepository = new AgenciaRepository(unitOfWork);

            AgenciasComboBox.ValueMember = "AgenciaId";
            AgenciasComboBox.DisplayMember = "Nombre";

            AgenciasComboBox.DataSource = agenciaRepository.GetAgencias();
        }

        public void SetValue(object sender, EventArgs e)
        {
            //UsuarioTextBox.Text = $"{AgenciasComboBox.SelectedValue}";
        }


        private void Login(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            Usuarios usuario = new Usuarios()
            {
                Username = UsuarioTextBox.Text,
                Password = PasswordTextBox.Text
            };
            loginService.Login(usuario);
        }
    }
}
