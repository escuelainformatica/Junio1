using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBaseDeDatos
{
    public class BaseEjemploMockup : IBaseEjemplo
    {
        public virtual IDbSet<Usuario> Usuarios { get; set; } = new FakeDbSet<Usuario>();
        
    }
}
