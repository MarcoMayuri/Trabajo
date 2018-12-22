namespace Control_de_clientes.Identity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Proyecto> Proyecto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.VNOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VAPELLIDO_PATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VAPELLIDO_MATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VDIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VDNI)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.VTELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<Proyecto>()
                .Property(e => e.VNOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<Proyecto>()
                .Property(e => e.VDESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<Proyecto>()
                .Property(e => e.TTIEMPO)
                .HasPrecision(6);
        }
    }
}
