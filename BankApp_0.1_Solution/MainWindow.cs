using ServiceLayer.BankDataContext.DTOs;
using ServiceLayer.BankDataContext.Infrastructure;
using ServiceLayer.BankDataContext.Infrastructure.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;
namespace BankApp_0._1_Solution
{
    public partial class MainWindow : Form
    {
        UnitOfWork<BankContext> unitOfWork = new UnitOfWork<BankContext>();
        public MainWindow()
        {
            InitializeComponent();
            InitTransaccionId();
            
        }

        public void InitTransaccionId()
        {
            TransactionRepository trassactions = new TransactionRepository(unitOfWork);
            Transacciones transac = trassactions.GetTransacciones().LastOrDefault();
            
            if(transac == null)
            {
                transac = new Transacciones();
                transac.TransaccionId = 1;
                return;
            }
            TransaccionIdTextbox.Text = $"{transac.TransaccionId}";
        }

        private void BuscarCliente(object sender, EventArgs e)
        {
           

            ClienteRepository repositorio = new ClienteRepository();
            string cuentaAfectada = CuentaAfectadaTextbox.Text;

            Clientes cuenta =  repositorio.SearchClient(cuentaAfectada);

            NombreClienteTextbox.Text = cuenta.NoCedula;
            NombreClienteTextbox.Text =  $"{cuenta.Nombres} {cuenta.Apellidos}";

            if (CuentaAfectadaTextbox.Text.Equals(""))
            {
                NombreClienteTextbox.Text = "";
            }
        }

    }
}
