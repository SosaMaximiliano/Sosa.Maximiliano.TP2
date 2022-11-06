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

        static Torneo()
        {
            salas = new List<Sala>();
        }

        public static List<Sala> Salas { get => salas; }
    }
}
