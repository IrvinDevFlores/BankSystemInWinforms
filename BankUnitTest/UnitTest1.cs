using BankUnitTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Monto_no_debe_sobrepasar_el_saldo_actual()
        {
            var cuenta = new Cuenta();
            double montoDeposito = 5000;
            var respuestaOp = cuenta.Depositar(montoDeposito);
            Assert.AreEqual(true,respuestaOp);
        }

        [Test]
        public void Monto_a_retirar_fuera_de_rango()
        {
            var cuenta = new Cuenta();
            double montoDepositar = 50;
            var respuestaOperacion = cuenta.Depositar(montoDepositar);

            Assert.AreEqual(false, respuestaOperacion);
        }
    }
}