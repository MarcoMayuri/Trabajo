namespace Control_de_clientes.Identity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Proyecto = new HashSet<Proyecto>();
        }

        [Key]
        [Display(Name = "CLIENTE_ID")]
        public int ICLIENTE_ID { get; set; }

        [StringLength(50)]
        [Display(Name = "NOMBRE")]
        public string VNOMBRE { get; set; }

        [StringLength(50)]
        [Display(Name = "APELLIDO_PATERNO")]
        public string VAPELLIDO_PATERNO { get; set; }

        [StringLength(50)]
        [Display(Name = "APELLIDO_MATERNO")]
        public string VAPELLIDO_MATERNO { get; set; }

        [StringLength(50)]
        [Display(Name = "DIRECCION")]
        public string VDIRECCION { get; set; }

        [StringLength(50)]
        [Display(Name = "DNI")]
        public string VDNI { get; set; }

        [StringLength(50)]
        [Display(Name = "TELEFONO")]
        public string VTELEFONO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proyecto> Proyecto { get; set; }
    }
}
