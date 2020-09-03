using System;

namespace BankUnitTest
{
    class Cuenta
    {
        public Cuenta()
        {
        }

        public bool Depositar(double montoDepositar) => montoDepositar <= 10000 ? true : false;
    }
}