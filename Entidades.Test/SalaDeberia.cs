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
            Jugador jugador = new Jugador(515,"Max", "Payne","Churrasco");

            jugador.Puntaje = 100;

            Assert.AreEqual(true, Sala.HayGanador(jugador));
        }

        [TestMethod]
        public void NombrarGanador() 
        {
            Jugador jugador1 = new Jugador(515,"Max", "Payne","Churrasco");
            Jugador jugador2 = new Jugador(666,"Kali","Kat","Pantera");

            jugador1.Puntaje = 100;

            Assert.AreEqual("Max", Sala.JugadorGanador(jugador1, jugador2));
        }



        //[ExpectedException(typeof(Exception))]
    }
}
