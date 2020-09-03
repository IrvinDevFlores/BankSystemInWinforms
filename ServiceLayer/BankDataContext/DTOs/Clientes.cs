namespace ServiceLayer.BankDataContext.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            Cuentas = new HashSet<Cuentas>();
            Transacciones = new HashSet<Transacciones>();
        }

        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(13)]
        public string NoCedula { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(50)]
        public string Genero { get; set; }

        [Required]
        [StringLength(50)]
        public string EstadoCivil { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(13)]
        public string Celular { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuentas> Cuentas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transacciones> Transacciones { get; set; }
    }
}
