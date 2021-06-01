using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBaseDeDatos.repo
{
    public class UsuarioRepo
    {
        public IBaseEjemplo contexto {set; get; } // podria ser una constante

        public UsuarioRepo(IBaseEjemplo contexto)
        {
            this.contexto = contexto;
        }

        public UsuarioRepo()
        {
        }

        public Usuario ObtenerUsuario(string nombre)
        {
            return contexto.Usuarios.Find(nombre);
        }

        public static Usuario ObtenerUsuarioStatic(string nombre)
        {
            var usr=new Usuario();
            using(var contexto=new BaseEjemplo())
            {
                usr=contexto.Usuarios.Find(nombre);
            }
            return usr;
        }
    }
}
