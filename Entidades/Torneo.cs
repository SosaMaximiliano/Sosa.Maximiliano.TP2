using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Torneo
    {
        static List<Sala> salas;
        static List<Jugador> participantes;
        static List<Jugador> contrincantes;


        static Torneo()
        {
            salas = new List<Sala>();
            participantes = new List<Jugador>();
            contrincantes = new List<Jugador>();
        }

        public static List<Sala> Salas { get => salas; }
        public static List<Jugador> Participantes { get => participantes; }
        public static List<Jugador> Contrincantes { get => contrincantes; set => contrincantes = value; }
    }
}
