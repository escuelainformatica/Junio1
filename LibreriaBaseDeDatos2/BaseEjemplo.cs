using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LibreriaBaseDeDatos
{
    public partial class BaseEjemplo : DbContext, IBaseEjemplo
    {
        public BaseEjemplo()
            : base("name=BaseEjemplo")
        {
        }

        public virtual IDbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(e => e.NombreUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);
        }
    }
}
