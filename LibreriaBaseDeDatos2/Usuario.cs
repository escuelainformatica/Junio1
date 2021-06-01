namespace LibreriaBaseDeDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuario
    {
        [Key]
        [StringLength(50)]
        public string NombreUsuario { get; set; }

        [StringLength(70)]
        public string Clave { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [StringLength(50)]
        public string NombreCompleto { get; set; }



        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   NombreUsuario == usuario.NombreUsuario &&
                   Clave == usuario.Clave &&
                   Correo == usuario.Correo &&
                   NombreCompleto == usuario.NombreCompleto;
        }

        public override int GetHashCode()
        {
            int hashCode = 128568392;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NombreUsuario);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Clave);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Correo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NombreCompleto);
            return hashCode;
        }
        /*public static bool operator ==(Usuario u1,Usuario U2)
{
   return true;
}
public static bool operator !=(Usuario u1,Usuario U2)
{
   return false;
}*/

    }
}
