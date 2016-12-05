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
            Assert.Fail();

        }

        [TestMethod()]
        public void BuscarTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getlistaNombreUsuarioTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getlistacontrasenaTest()
        {
            Assert.Fail();
        }
    }
}