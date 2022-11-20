using ClassLibrary1;
using System.Diagnostics.Tracing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static Entidades.Delegado;

namespace Entidades
{
    public class Sala
    {
        private int idSala;
        private List<int> dados;
        static Random rand = new Random();
        Jugador jugador1;
        Jugador jugador2;
        public bool hayGanador;
        private string ganador = string.Empty;
        private int mano;

        public event Action<string> partidaTerminada;

        //Delegado.MostrarJuego DMostrar;

        public CancellationTokenSource cts;
        public CancellationToken ct;

        public Sala(MostrarJuego DMostrar)
        {
            dados = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(rand.Next(1, 7));
            }

            cts = new CancellationTokenSource();
            ct = cts.Token;

            this.jugador1 = Torneo.Participantes[rand.Next(0, 100)];
            this.jugador2 = Torneo.Participantes[rand.Next(0, 100)];

            Task task = Task.Run(() => { this.JugarPartida(DMostrar, ct); });

        }

        public List<int> Dados { get => dados; set => dados = value; }
        public int IdSala { get => idSala; set => idSala = value; }
        public string NombreJugador1 { get => Jugador1.Nombre; }
        public string NombreJugador2 { get => Jugador2.Nombre; }
        public string Ganador { get => ganador; set => ganador = value; }
        public Jugador Jugador1 { get => jugador1; set => jugador1 = value; }
        public Jugador Jugador2 { get => jugador2; set => jugador2 = value; }
        public int Mano { get => mano; set => mano = value; }


        //Metodo jugar partida

        public void JugarPartida(MostrarJuego DMostrar, CancellationToken ct)
        {

            do
            {
                this.Mano++;

                for (int i = 0; i < 3; i++)
                {
                    jugador1.JugarMano();
                    DMostrar.Invoke(MostrarJugadas(jugador1), "");
                    Thread.Sleep(1000);

                }

                for (int i = 0; i < 3; i++)
                {
                    jugador2.JugarMano();
                    DMostrar.Invoke("", MostrarJugadas(jugador2));
                    Thread.Sleep(1000);
                }

                hayGanador = (HayGanador(Jugador1) || HayGanador(Jugador2));
            } while (!hayGanador && !ct.IsCancellationRequested);

            if (ct.IsCancellationRequested)
            {
                partidaTerminada?.Invoke("PARTIDA CANCELADA");
            }

            else if (hayGanador)
            {
                Ganador = JugadorGanador(jugador1,jugador2);


                /*//Guardo en BD
                ParticipantesDB pDB = new ParticipantesDB();
                pDB.GuardarDatos(Ganador);

                //Guardo en archivo
                Archivo.Escribir(Ganador,"Listado de ganadores");*/

                SerializadoraJSON<Jugador> json = new SerializadoraJSON<Jugador>();
                json.Escribir(RetornarJugadorGanador(jugador1, jugador2), "Ganadores");

            }

        }


        //Metodo hay ganador

        public static bool HayGanador(Jugador jugador)
        {
            return jugador.Puntaje >= 300 ? true : false;
        }

        public static string JugadorGanador(Jugador jugador1, Jugador jugador2)
        {
            if (HayGanador(jugador1))
            {
                return jugador1.Nombre;
            }

            if (HayGanador(jugador2))
            {
                return jugador2.Nombre;
            }

            return string.Empty;
        }

        public static Jugador RetornarJugadorGanador(Jugador jugador1, Jugador jugador2)
        {
            if (HayGanador(jugador1))
            {
                return jugador1;
            }

            if (HayGanador(jugador2))
            {
                return jugador2;
            }

            return null;
        }

        //Metodo mostrar jugadas

        public static string MostrarJugadas(Jugador jugador)
        {
            StringBuilder jugada = new StringBuilder();

            jugada.AppendLine("DADOS:");

            jugador.dadosJugador.ForEach(dado => jugada.Append($"{dado} "));

            jugada.AppendLine($"\n{jugador.BuscarJuego(jugador.dadosJugador)}");

            jugada.AppendLine($"PUNTAJE: {jugador.Puntaje}");

            jugada.AppendLine();

            return jugada.ToString();
        }
    }
}