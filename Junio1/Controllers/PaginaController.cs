using LibreriaBaseDeDatos;
using LibreriaBaseDeDatos.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Junio1.Controllers
{
    public class PaginaController : Controller
    {
        public BaseEjemplo contexto;

        public PaginaController()
        {
            contexto=new BaseEjemplo();
        }



        // GET: Pagina
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            Usuario modelo=new Usuario();
            ViewBag.error="";
            return View(modelo);
        }
        [HttpPost]
        public ActionResult Login(Usuario modelo)
        {
            var repo=new UsuarioRepo(contexto);
            var usuarioValido=repo.ValidarUsuario(modelo);
            if(usuarioValido==null)
            {
                ViewBag.error="usuario no encontrado";
            } else
            {
                Session.Add("usuario",usuarioValido);
                Response.Redirect("/Pagina/PaginaNormal");
                return null;                
            }


            return View(modelo);
        }
        public ActionResult PaginaNormal()
        {
            Usuario usr=(Usuario)Session["usuario"];
            if(usr==null)
            {
                Response.Redirect("/Pagina/Login");
                return null;                
            }

            return View(usr);
        }

    }
}