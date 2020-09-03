namespace BankApp_0._1_Solution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banco")]
    public partial class Banco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banco()
        {
            Agencia = new HashSet<Agencia>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BancoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agencia> Agencia { get; set; }
    }
}
