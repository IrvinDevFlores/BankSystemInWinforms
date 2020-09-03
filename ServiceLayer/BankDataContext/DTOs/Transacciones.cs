namespace ServiceLayer.BankDataContext.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transacciones
    {
        [Key]
        public int TransaccionId { get; set; }

        public int ClienteId { get; set; }

        [Column("Saldo Anterior")]
        public decimal Saldo_Anterior { get; set; }

        public decimal Importe { get; set; }

        [Column("Saldo Nuevo")]
        public decimal Saldo_Nuevo { get; set; }

        public int TipoOperacionId { get; set; }

        public int EmpleadoId { get; set; }

        [Column("Fecha Transaccion", TypeName = "date")]
        public DateTime Fecha_Transaccion { get; set; }

        public virtual Clientes Clientes { get; set; }

        public virtual Empleados Empleados { get; set; }

        public virtual TipoOperacion TipoOperacion { get; set; }
    }
}
