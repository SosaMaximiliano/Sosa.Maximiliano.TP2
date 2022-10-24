using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Test
{

    [TestClass]
    public class JugadorDeberia
    {
        [DataRow(3, 4, 1, 3, 1)]
        [DataRow(1, 3, 5, 3, 3)]
        [DataRow(1, 4, 5, 5, 3)]
        [TestMethod]
        public void ValidarPosibleJugada(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            bool flag = false;
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

            //RESULTADO ESPERADO: UNA LISTA CON VALOR DE DADOS 1 1 3 3

            List<Dado> resultadoEsperado = new List<Dado>();
            for (int i = 0; i < 4; i++)
            {
                resultadoEsperado.Add(new Dado());
            }
            resultadoEsperado[0].ValorDeCara = 1;
            resultadoEsperado[1].ValorDeCara = 1;
            resultadoEsperado[2].ValorDeCara = 3;
            resultadoEsperado[3].ValorDeCara = 3;

            //OTROS RESULTADOS ESPERADOS:
            //UNA LISTA CON DOS DADOS

            List<Dado> resultadoEsperado2 = new List<Dado>();
            for (int i = 0; i < 2; i++)
            {
                resultadoEsperado2.Add(new Dado());
            }
            resultadoEsperado2[0].ValorDeCara = 5;
            resultadoEsperado2[1].ValorDeCara = 5;

            //UNA LISTA CON TRES DADOS

            List<Dado> resultadoEsperado3 = new List<Dado>();
            for (int i = 0; i < 3; i++)
            {
                resultadoEsperado3.Add(new Dado());
            }
            resultadoEsperado3[0].ValorDeCara = 3;
            resultadoEsperado3[1].ValorDeCara = 3;
            resultadoEsperado3[1].ValorDeCara = 3;

            //W
            dados = Jugador.GuardarDadosUtiles(dados);
            //T
            for (int i = 0; i< dados.Count; i++)
            {
                if (dados[i].ValorDeCara != resultadoEsperado[i].ValorDeCara && dados[i].ValorDeCara != resultadoEsperado2[i].ValorDeCara && dados[i].ValorDeCara != resultadoEsperado3[i].ValorDeCara)
                {
                    flag = false;
                    break;
                }
                flag = true;
            }
                
            Assert.IsTrue(flag);
        }


        [DataRow(5,5,5,1,3)]
        [DataRow(4,5,5,1,3)]
        [TestMethod]
        public void ValidarPosibleFull(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
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

            Assert.AreEqual(true, Jugador.PosibleFullPokerGenerala(dados));
        }

        public void ValidarPosibleEscalera()
        {
            throw new NotImplementedException();

        }

    }
}
