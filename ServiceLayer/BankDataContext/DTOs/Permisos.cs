namespace ServiceLayer.BankDataContext.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permisos
    {
        [Key]
        public int PermisoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
