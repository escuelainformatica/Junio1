using LibreriaBaseDeDatos;
using LibreriaBaseDeDatos.repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // unidad de prueba:
            BaseEjemploMockup contexto = new BaseEjemploMockup();
            var repo = new UsuarioRepo(contexto);
            Assert.AreEqual(null, repo.ObtenerUsuario("john"));


            // prueba de integracion:

            BaseEjemplo contextoReal = new BaseEjemplo();
            var repo2 = new UsuarioRepo(contextoReal);
            Assert.AreNotEqual(null, repo2.ObtenerUsuario("john"));

            var usuarioAComparar = new Usuario {
                NombreUsuario = "john"
                , Clave = "john"
                , Correo = "john@john.com"
                , NombreCompleto = "john doe" };
            var usuarioLeido=repo2.ObtenerUsuario("john");
            Assert.AreEqual(usuarioAComparar, usuarioLeido);
        }
        [TestMethod]
        public void TestMethodEncriptacion()
        {

            var txt=Encriptacion.ComputeSha256Hash("john");
            Assert.AreEqual("b7111564537b1adbf5406a1fd902e75c2ca0ad87c2f637f68b7de7952e57459a",txt);
        }


    }
}
