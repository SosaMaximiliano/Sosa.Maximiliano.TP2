namespace Entidades.Test
{
    [TestClass]
    public class ReglasDeberia
    {

        [DataRow(1, 2, 3, 4, 5)]
        [TestMethod]
        public void ValidarEscaleraMenor(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            //G
            List<Dado> dados = new List<Dado>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(new Dado());
            }
            dados[0].ValorDeCara = dado1;
            dados[1].ValorDeCara = dado2;
            dados[2].ValorDeCara = dado3;
            dados[3].ValorDeCara = dado4;
            dados[4].ValorDeCara = dado5;
            bool resultadoEsperado = true;
            //W
            bool resultado = Reglas.EscaleraMenor(dados);
            //T
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataRow(2, 3, 4, 5, 6)]
        [TestMethod]
        public void ValidarEscaleraMayor(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            //G
            List<Dado> dados = new List<Dado>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(new Dado());
            }
            dados[0].ValorDeCara = dado1;
            dados[1].ValorDeCara = dado2;
            dados[2].ValorDeCara = dado3;
            dados[3].ValorDeCara = dado4;
            dados[4].ValorDeCara = dado5;
            bool resultadoEsperado = true;
            //W
            bool resultado = Reglas.EscaleraMayor(dados);
            //T
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataRow(1, 1, 6, 6, 6)]
        [DataRow(2, 5, 2, 2, 5)]
        [DataRow(3, 3, 3, 5, 5)]
        [TestMethod]
        public void ValidarFull(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            //G
            List<Dado> dados = new List<Dado>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(new Dado());
            }
            dados[0].ValorDeCara = dado1;
            dados[1].ValorDeCara = dado2;
            dados[2].ValorDeCara = dado3;
            dados[3].ValorDeCara = dado4;
            dados[4].ValorDeCara = dado5;
            bool resultadoEsperado = true;
            //W
            bool resultado = Reglas.Full(dados);
            //T
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataRow(1, 6, 6, 6, 6)]
        [DataRow(2, 5, 2, 2, 2)]
        [TestMethod]
        public void ValidarPoker(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            //G
            List<Dado> dados = new List<Dado>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(new Dado());
            }
            dados[0].ValorDeCara = dado1;
            dados[1].ValorDeCara = dado2;
            dados[2].ValorDeCara = dado3;
            dados[3].ValorDeCara = dado4;
            dados[4].ValorDeCara = dado5;
            bool resultadoEsperado = true;
            //W
            bool resultado = Reglas.Poker(dados);
            //T
            Assert.AreEqual(resultadoEsperado, resultado);
        }



        [DataRow(6, 6, 6, 6, 6)]
        [DataRow(2, 2, 2, 2, 2)]
        [TestMethod]
        public void ValidarGenerala(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            //G
            List<Dado> dados = new List<Dado>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(new Dado());
            }
            dados[0].ValorDeCara = dado1;
            dados[1].ValorDeCara = dado2;
            dados[2].ValorDeCara = dado3;
            dados[3].ValorDeCara = dado4;
            dados[4].ValorDeCara = dado5;
            bool resultadoEsperado = true;
            //W
            bool resultado = Reglas.Generala(dados);
            //T
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        
        [DataRow(1, 1, 1, 1, 1)]
        [TestMethod]
        public void ValidarGeneralaReal(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            //G
            List<Dado> dados = new List<Dado>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(new Dado());
            }
            dados[0].ValorDeCara = dado1;
            dados[1].ValorDeCara = dado2;
            dados[2].ValorDeCara = dado3;
            dados[3].ValorDeCara = dado4;
            dados[4].ValorDeCara = dado5;
            bool resultadoEsperado = true;
            //W
            bool resultado = Reglas.GeneralaReal(dados);
            //T
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}