using System.Diagnostics.Tracing;

namespace Entidades
{
    public class Sala
    {
        private int numeroSala;
        private static List<int> dados;
        static Random rand = new Random();
        private string jugador1;
        private string jugador2;
        private string ganador = string.Empty;

        public Sala(int numeroSala, Jugador jugador1, Jugador jugador2)
        {
            this.numeroSala = numeroSala;

            dados = new List<int>();
            dados.Add(rand.Next(1, 7));
            dados.Add(rand.Next(1, 7));
            dados.Add(rand.Next(1, 7));
            dados.Add(rand.Next(1, 7));
            dados.Add(rand.Next(1, 7));

            this.jugador1 = jugador1.Nombre +" "+ jugador1.Apellido;
            this.jugador2 = jugador2.Nombre +" "+ jugador2.Apellido;

        }

        public static List<int> Dados { get => dados; set => dados = value; }
        public int NumeroSala { get => numeroSala; }
        public string Jugador1 { get => jugador1; }
        public string Jugador2 { get => jugador2; }
        public string Ganador { get => ganador; set => ganador = value; }
    }
}