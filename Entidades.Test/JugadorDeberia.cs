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
        
        [DataRow(5, 5, 5, 1, 3)]
        [DataRow(4, 5, 5, 1, 3)]
        [DataRow(4, 5, 6, 1, 5)]
        [TestMethod]
        public void ValidarPosibleFullPokerGenerala(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            List<int> dados = new List<int>();

            dados.Add(dado1);
            dados.Add(dado2);
            dados.Add(dado3);
            dados.Add(dado4);
            dados.Add(dado5);

            Assert.AreEqual(true, Jugador.PosibleFullPokerGenerala(dados));
        }

        [DataRow(1, 2, 3, 6, 6)]
        [DataRow(1, 6, 3, 6, 2)]
        [DataRow(4, 5, 6, 1, 1)]
        [DataRow(4, 3, 2, 1, 1)]
        [TestMethod]
        public void ValidarPosibleEscalera(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            List<int> dados = new List<int>();

            dados.Add(dado1);
            dados.Add(dado2);
            dados.Add(dado3);
            dados.Add(dado4);
            dados.Add(dado5);

            Assert.AreEqual(true, Jugador.PosibleEscalera(dados));
        }

       





    }
}
