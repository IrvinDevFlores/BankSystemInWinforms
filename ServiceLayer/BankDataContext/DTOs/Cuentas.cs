namespace ServiceLayer.BankDataContext.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas
    {
        [Key]
        public int CuentaId { get; set; }

        [StringLength(9)]
        public string NoCuenta { get; set; }

        public decimal? SaldoApertura { get; set; }

        public decimal? Saldo { get; set; }

        [StringLength(50)]
        public string TipoCuenta { get; set; }

        public int? ClienteId { get; set; }

        public virtual Clientes Clientes { get; set; }
    }
}
