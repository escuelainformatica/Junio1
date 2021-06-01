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

        /// <summary>
        /// Validar el usuario, en caso de que el usuario no sea el correcto, devolver un null
        /// </summary>
        /// <param name="usuarioAValidar"></param>
        /// <returns></returns>
        public Usuario ValidarUsuario(Usuario usuarioAValidar)
        {
            var usuarioDesdeBD=ObtenerUsuario(usuarioAValidar.NombreUsuario);
            if(usuarioDesdeBD==null)
            {
                return null;
            }
            if(usuarioAValidar.NombreUsuario==usuarioDesdeBD.NombreUsuario &&
                Encriptacion.ComputeSha256Hash(usuarioAValidar.Clave)==usuarioDesdeBD.Clave)
            {
                return usuarioDesdeBD;
            }
            return null; // usuario no esta o clave incorrecta.
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
