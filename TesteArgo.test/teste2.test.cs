using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    [TestClass]
    public class teste2Test
    {
        teste2 classeTeste = new teste2();

        [TestMethod]
        public void teste2_ListarFilmes()
        {
            var resultado = classeTeste.ListarDestino();

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Count > 0);
        }


        [TestMethod]
        public void teste2_ListarPorId()
        {
            var resultado = classeTeste.buscarPorId(1);

            Assert.IsNotNull(resultado);
        }
    }
}
