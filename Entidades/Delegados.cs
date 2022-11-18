using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Delegado
    {
        public delegate void Tirar(Jugador jugador1, Jugador jugador2);

        public delegate bool Ganador(Jugador jugador);

        public delegate void MostrarJuego(string texto, string texto2);
    }


}
