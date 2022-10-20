using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private string nombre;
        private string apellido;
        private static int puntaje;
        private static int partidasGanadas;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public static int Puntaje { get => puntaje; set => puntaje = value; }
        public static int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }

        public Jugador(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            puntaje = 0;
            partidasGanadas = 0;
        }

        private void JugarMano()
        {
            
        }
    }
}
