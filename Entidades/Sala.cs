using System.Diagnostics.Tracing;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Entidades
{
    public class Sala
    {
        private int numeroSala;
        private List<int> dados;
        static Random rand = new Random();
        Jugador jugador1;
        Jugador jugador2;
        public bool hayGanador;
        private string ganador = string.Empty;
        private int mano;
        public delegate void delegadoPrueba(string a, string b);


        public Sala(delegadoPrueba delegado)
        {
            dados = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(rand.Next(1, 7));
            }

            this.jugador1 = Torneo.Participantes[rand.Next(0, 100)];
            this.jugador2 = Torneo.Participantes[rand.Next(0, 100)];

            Task task = Task.Run(() => { this.JugarPartida(jugador1, jugador2, delegado); });

        }

        public List<int> Dados { get => dados; set => dados = value; }
        public int NumeroSala { get => numeroSala; }
        public string NombreJugador1 { get => Jugador1.Nombre; }
        public string NombreJugador2 { get => Jugador2.Nombre; }
        public string Ganador { get => ganador; set => ganador = value; }
        public Jugador Jugador1 { get => jugador1; set => jugador1 = value; }
        public Jugador Jugador2 { get => jugador2; set => jugador2 = value; }
        public int Mano { get => mano; set => mano = value; }


        //Metodo jugar partida

        public void JugarPartida(Jugador jugador1, Jugador jugador2, delegadoPrueba delegadoMostrar)
        {
            hayGanador = (HayGanador(Jugador1) || HayGanador(Jugador2));

            while (!hayGanador)
            {

                this.Mano++;

                for (int i = 0; i < 3; i++)
                {
                    jugador1.JugarMano();
                    delegadoMostrar.Invoke(MostrarJugadas(jugador1), "");
                    Thread.Sleep(2000);
                }

                for (int i = 0; i < 3; i++)
                {
                    jugador2.JugarMano();
                    delegadoMostrar.Invoke("", MostrarJugadas(jugador2));
                    Thread.Sleep(2000);
                }

            }

        }


        //Metodo hay ganador

        public bool HayGanador(Jugador jugador)
        {
            return jugador.Puntaje >= 100 ? true : false;
        }

        //Metodo mostrar jugadas

        public string MostrarJugadas(Jugador jugador)
        {
            StringBuilder jugada = new StringBuilder();

            jugada.AppendLine(jugador.Nombre);

            jugada.AppendLine("DADOS:");

            jugador.dadosJugador.ForEach(dado => jugada.Append($"{dado} "));

            jugada.AppendLine("");

            jugada.AppendLine(jugador.BuscarJuego(jugador.dadosJugador));

            jugada.AppendLine($"PUNTAJE: {jugador.Puntaje}");

            return jugada.ToString();
        }
    }
}