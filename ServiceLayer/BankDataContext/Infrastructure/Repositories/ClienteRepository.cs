using ServiceLayer.BankDataContext.DTOs;
using ServiceLayer.BankDataContext.Infrastructure.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ServiceLayer.BankDataContext.Infrastructure.Repositories
{
    public class ClienteRepository
    {
        public Clientes SearchClient(string noCuenta)
        {
            SqlConexion.OpenConexion();

            SqlCommand command = new SqlCommand("MostrarClientes", SqlConexion.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader data = command.ExecuteReader();

            if (data.HasRows)
            {
                Clientes cuentaBuscada  = null;
                while (data.Read())
                {
                    cuentaBuscada = new Clientes()
                    {
                        ClienteId = data.GetInt32(0),
                         NoCedula = data.GetString(1),
                        FechaNacimiento = data.GetDateTime(2),
                        Nombres = data.GetString(3),
                        Apellidos = data.GetString(4)
                    };

                }

                SqlConexion.CloseConexion();
                return cuentaBuscada;
            }

            return null;

        }


    }
}
