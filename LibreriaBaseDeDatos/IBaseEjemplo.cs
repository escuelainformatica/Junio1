using System.Data.Entity;

namespace LibreriaBaseDeDatos
{
    public interface IBaseEjemplo
    {
        IDbSet<Usuario> Usuarios { get; set; }
    }
}