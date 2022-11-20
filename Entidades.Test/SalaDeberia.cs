using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Test
{

    [TestClass]
    public class SalaDeberia
    {

        [TestMethod]
        public void ValidarGanador()
        {
            Jugador jugador = new Jugador("Max");

            jugador.Puntaje = 100;

            Assert.AreEqual(true, Sala.HayGanador(jugador));
        }

        [TestMethod]
        public void NombrarGanador() 
        {
            Jugador jugador1 = new Jugador("Max");
            Jugador jugador2 = new Jugador("Kali");

            jugador1.Puntaje = 100;

            Assert.AreEqual("Max", Sala.JugadorGanador(jugador1, jugador2));
        }



        //[ExpectedException(typeof(Exception))]
    }
}
