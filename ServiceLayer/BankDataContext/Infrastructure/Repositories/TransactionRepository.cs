using ServiceLayer.BankDataContext.DTOs;
using ServiceLayer.BankDataContext.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLayer.BankDataContext.Infrastructure.Repositories
{
    public class TransactionRepository: GenericRepository<Transacciones>, ITransactionRepository
    {
        public TransactionRepository(IUnitOfWork<BankContext> unitOfWork) 
            : base(unitOfWork) { }
        public TransactionRepository(BankContext context)
            : base(context) { }

        public void InsertarTransaccion(Transacciones transacion)
        {
            string request = "";

            try
            {
                SqlConexion.OpenConexion();

                SqlCommand cmd = new SqlCommand("InsertarTransacion",SqlConexion.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter transacionIdParam = new SqlParameter();
                transacionIdParam.ParameterName = "@transacionId";
                transacionIdParam.SqlDbType = SqlDbType.Int;
                transacionIdParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(transacionIdParam);

                SqlParameter clienteIdParam = new SqlParameter();
                clienteIdParam.ParameterName = "@clienteId";
                clienteIdParam.SqlDbType = SqlDbType.Int;
   
                clienteIdParam.Value = transacion.ClienteId;
                cmd.Parameters.Add(clienteIdParam);

                SqlParameter fechaOperacionParam = new SqlParameter();
                fechaOperacionParam.ParameterName = "@fechaOperacion";
                fechaOperacionParam.SqlDbType = SqlDbType.DateTime;
                fechaOperacionParam.Value = transacion.Fecha_Transaccion;
                cmd.Parameters.Add(fechaOperacionParam);


                SqlParameter importeParam = new SqlParameter();
                importeParam.ParameterName = "@importe";
                importeParam.SqlDbType = SqlDbType.Decimal;
                importeParam.Precision = 10;
                importeParam.Value = transacion.Importe;
                cmd.Parameters.Add(importeParam);


                SqlParameter tipoOperacionParam = new SqlParameter();
                tipoOperacionParam.ParameterName = "@tipoOperacionId";
                tipoOperacionParam.SqlDbType = SqlDbType.Int;
                tipoOperacionParam.Value = transacion.EmpleadoId;
                cmd.Parameters.Add(tipoOperacionParam);

                SqlParameter empleadoIdParam = new SqlParameter();
                empleadoIdParam.ParameterName = "@empleadoId";
                empleadoIdParam.SqlDbType = SqlDbType.Int;
                empleadoIdParam.Value = transacion.EmpleadoId;
                cmd.Parameters.Add(empleadoIdParam);

                request = cmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso";

            }
            catch (Exception e)
            {
                request = e.Message;
            }
            if(request.Equals("OK"))
            {
                MessageBox.Show("Se inserto correctamente");
            }


        }

        public List<Transacciones> GetTransacciones()
        {
           
            SqlConexion.OpenConexion();

            SqlCommand command = new SqlCommand("MostrarTablaTransaciones", SqlConexion.GetConnection());

            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader read = command.ExecuteReader();
            List<Transacciones> transacciones = new List<Transacciones>();
            while (read.Read())
            {
                Transacciones tran = new Transacciones()
                {
                    TransaccionId = read.GetInt32(0),
                    ClienteId = read.GetInt32(1),
                    Saldo_Anterior = read.GetDecimal(2),
                    Importe = read.GetDecimal(3),
                    Saldo_Nuevo = read.GetDecimal(4),
                    TipoOperacionId = read.GetInt32(5),
                    EmpleadoId = read.GetInt32(6),
                    Fecha_Transaccion = read.GetDateTime(7)
                };


                transacciones.Add(tran);
            }
            SqlConexion.CloseConexion();
            return transacciones;
        }

    }
}
