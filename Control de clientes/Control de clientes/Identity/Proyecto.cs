namespace Control_de_clientes.Identity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proyecto")]
    public partial class Proyecto
    {
        [Key]
        [Display(Name ="PROYECTO_ID")]
        public int IPROYECTO_ID { get; set; }

        public int? ICLIENTE_ID { get; set; }

        [StringLength(50)]
        [Display(Name = "PROYECTO")]
        public string VNOMBRE { get; set; }

        [StringLength(50)]
        [Display(Name = "DESCRIPCION")]
        public string VDESCRIPCION { get; set; }

        [Display(Name = "TIEMPO")]
        public TimeSpan? TTIEMPO { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
