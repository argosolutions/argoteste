using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    [TestClass]
    public class teste1test
    {
        teste1 classeTeste = new teste1();

        [TestMethod]
        public void teste1_ListarFilmes()
        {
            var resultado = classeTeste.ListarFilmes("batman");

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Count > 0);
        }


        [TestMethod]
        public void teste1_ListarPorId()
        {
            var resultado = classeTeste.ListarPorId("tt0372784");

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Titulo.ToLower().Contains("batman"));
        }
    }
}
