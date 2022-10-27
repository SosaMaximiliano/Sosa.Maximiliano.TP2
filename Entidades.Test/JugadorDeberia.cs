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

        [DataRow(1, 5, 5, 1, 1)] //RECIBE 3 y 2
        [DataRow(1, 5, 5, 4, 1)] //RECIBE 2 y 2
        [DataRow(1, 3, 5, 1, 1)] //RECIBE 3
        [DataRow(1, 3, 5, 2, 1)] //RECIBE 2
        [DataRow(1, 5, 5)]
        [DataRow(4, 4, 4)]
        [DataRow(3, 3)]
        [TestMethod]
        public void PoderGuardarDadosParaFullPokerGenerala(int dado1, int dado2, int dado3, int dado4, int dado5)
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

            Jugador jugador = new Jugador("Max", "Payne", 1);

            //W
            jugador.GuardarDadosParaFullPokerGenerala(dados);

            //T

            Assert.AreEqual(dados.Count, jugador.DadosParaFullPokerGenerala.Count);
        }


        [DataRow(5, 5, 5, 1, 3)]
        [DataRow(4, 5, 5, 1, 3)]
        [DataRow(4, 5, 6, 1, 5)]
        [TestMethod]
        public void ValidarPosibleFullPokerGenerala(int dado1, int dado2, int dado3, int dado4, int dado5)
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

        [DataRow(1, 2, 3, 6, 6)]
        [DataRow(1, 6, 3, 6, 2)]
        [DataRow(4, 5, 6, 1, 1)]
        [DataRow(4, 3, 2, 1, 1)]
        [TestMethod]
        public void ValidarPosibleEscalera(int dado1, int dado2, int dado3, int dado4, int dado5)
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

            Assert.AreEqual(true, Jugador.PosibleEscalera(dados));
        }

    }
}
