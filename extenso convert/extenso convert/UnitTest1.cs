using extenso;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace extenso_convert
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void test_unidade()
        {
            Extenso extenso = new Extenso();
            Assert.AreEqual("um", extenso.convert(1));
            Assert.AreEqual("dois", extenso.convert(2));
            Assert.AreEqual("três", extenso.convert(3));
            Assert.AreEqual("quatro", extenso.convert(4));
            Assert.AreEqual("cinco", extenso.convert(5));
            Assert.AreEqual("seis", extenso.convert(6));
            Assert.AreEqual("sete", extenso.convert(7));
            Assert.AreEqual("oito", extenso.convert(8));
            Assert.AreEqual("nove", extenso.convert(9));
        }

        [TestMethod]
        public void test_dezenas()
        {
            Extenso extenso = new Extenso();
            Assert.AreEqual("dez", extenso.convert(10));
            Assert.AreEqual("onze", extenso.convert(11));
            Assert.AreEqual("quatorze ", extenso.convert(14));
            Assert.AreEqual("dezenove", extenso.convert(19));
            Assert.AreEqual("quarenta e dois", extenso.convert(42));
        }

        [TestMethod]
        public void test_100()
        {
            Extenso extenso = new Extenso();
            String valor = extenso.convert(100);
            Assert.AreEqual("cem", valor);
        }

        [TestMethod]
        public void test_790()
        {
            Extenso extenso = new Extenso();
            String valor = extenso.convert(790);
            Assert.AreEqual("setecentos e noventa", valor);
        }

        [TestMethod]
        public void test_ValorInvalido()
        {
            Extenso extenso = new Extenso();
            Assert.AreEqual("", extenso.convert(9090));
            //            Assert.AreEqual("Valor inválido", extenso.convert(0));
            //            Assert.AreEqual("Valor inválido", extenso.convert(-90));
        }

        [TestMethod]
        public void test_negativo()
        {
            Extenso extenso = new Extenso();
            Assert.AreEqual("Menos dez", extenso.convert(-10));
            Assert.AreEqual("Menos onze", extenso.convert(-11));
            Assert.AreEqual("Menos quatorze ", extenso.convert(-14));
            Assert.AreEqual("Menos dezenove", extenso.convert(-19));
            Assert.AreEqual("Menos quarenta e dois", extenso.convert(-42));
        }
        [TestMethod]
        public void test_fracao()
        {
            Extenso extenso = new Extenso();
            Assert.AreEqual("Menos dez ponto um", extenso.convert(-10.1));
            Assert.AreEqual("sete ponto quatorze", extenso.convert(7.14));
        }

    }
}
