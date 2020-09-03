namespace BankApp_0._1_Solution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agencia")]
    public partial class Agencia
    {
        public int AgenciaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }

        public int BancoId { get; set; }

        public virtual Banco Banco { get; set; }
    }
}
