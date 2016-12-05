using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Entidades.Usuarios u = new Entidades.Usuarios();
            Assert.IsTrue(UsuariosBLL.Guardar(u));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int ID = 1;
            Assert.IsTrue(UsuariosBLL.Eliminar(ID));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            var v = new UsuariosBLL();
            Assert.IsNotNull(v);
        }

        [TestMethod()]
        public void GetListaTest()
        {    
            Assert.IsNotNull(UsuariosBLL.GetLista());
        }

        [TestMethod()]
        public void GetListaUsuarioIDTest()
        {       
            Assert.IsNotNull(UsuariosBLL.GetListaUsuarioID(3));
        }

        [TestMethod()]
        public void GetListaUsuarioTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetListaUsuario("root"));
        }

        [TestMethod()]
        public void GetListaContrasenaTest()
        {
            Assert.IsNotNull(UsuariosBLL.GetListaContrasena("123"));
        }
    }
}