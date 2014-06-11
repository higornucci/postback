using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Postback.Dominio;

namespace Postback.Testes
{
    [TestFixture]
    public class TagTest
    {
        [Test]
        public void deveRetirarHashTagsAdicionaisNoComeco()
        {
            var assuntoDigitado = "##tecnologia";
            var assuntoEsperado = "#tecnologia";
            var tag = new Tag(assuntoDigitado);
            Assert.AreEqual(assuntoEsperado, tag.ToString());
        }
    }
}
