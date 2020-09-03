using ServiceLayer.BankDataContext.DTOs;
using ServiceLayer.BankDataContext.Infrastructure.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace ServiceLayer.BankDataContext.Infrastructure.Repositories
{
    public class AgenciaRepository : GenericRepository<Agencia>, IAgenciaRepository
    {

        public AgenciaRepository(IUnitOfWork<BankContext> unitOfWork) : base(unitOfWork) { }


        public DataTable GetAgencias()
        {
            SqlConexion.OpenConexion();

            SqlCommand command = new SqlCommand("MostrarAgencias",
                SqlConexion.GetConnection());

            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            SqlConexion.CloseConexion();
            return table;
        }
    }
}
