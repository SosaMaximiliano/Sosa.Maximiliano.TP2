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
        //[DataRow(1,2,3,4,5)]
        //[DataRow(6,5,4,3,2)]
        //[DataRow(2,4,6,3,5)]
        [DataRow(2, 4, 6, 1, 3)]
        //[DataRow(4, 4, 5, 6, 6)]
        [TestMethod]
        public void PoderGuardarDadosParaEscalera(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            //G
            List<int> dados = new List<int>();

            dados.Add(dado1);
            dados.Add(dado2);
            dados.Add(dado3);
            dados.Add(dado4);
            dados.Add(dado5);

            Jugador jugador = new Jugador("Max", "Payne", 1);

            //W
            jugador.GuardarDadosParaEscalera(dados);

            //T

            Assert.AreEqual(4, jugador.DadosParaEscalera.Count);
        }


        //[DataRow(1, 5, 5, 1, 1)] //RECIBE 3 y 2
        //[DataRow(1, 5, 5, 4, 1)] //RECIBE 2 y 2
        //[DataRow(1, 3, 5, 1, 1)] //RECIBE 3
        [DataRow(1, 3, 5, 2, 1)] //RECIBE 2
        //[DataRow(1, 5, 5)]
        //[DataRow(4, 4, 4)]
        //[DataRow(3, 3)]
        [TestMethod]
        public void PoderGuardarDadosParaFullPokerGenerala(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            //G
            List<int> dados = new List<int>();

            dados.Add(dado1);
            dados.Add(dado2);
            dados.Add(dado3);
            dados.Add(dado4);
            dados.Add(dado5);


            Jugador jugador = new Jugador("Max", "Payne", 1);

            //W
            jugador.GuardarDadosParaFullPokerGenerala(dados);

            //T

            Assert.AreEqual(2, jugador.DadosParaFullPokerGenerala.Count);
        }


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

        [DataRow(6, 4, 6, 6, 2)]
        //[DataRow(3, 2, 6, 1, 5)]
        [TestMethod]
        public void PoderGuardarDados(int dado1, int dado2, int dado3, int dado4, int dado5)
        {
            List<int> dados = new List<int>();

            dados.Add(dado1);
            dados.Add(dado2);
            dados.Add(dado3);
            dados.Add(dado4);
            dados.Add(dado5);

            Jugador jugador = new Jugador("M", "P", 1);
            jugador.DadosParaFullPokerGenerala.Clear();

            jugador.GuardarDados(dados);
            int aux = jugador.DadosParaFullPokerGenerala.Count;

            Assert.AreEqual(3, jugador.DadosParaFullPokerGenerala.Count);
        }

    }
}
