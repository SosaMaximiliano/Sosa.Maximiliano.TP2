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
        private int salaAsignada;
        private List<Dado> dadosPrometedores;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public static int Puntaje { get => puntaje; set => puntaje = value; }
        public static int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public List<Dado> DadosPrometedores { get => dadosPrometedores; set => dadosPrometedores = value; }


        public Jugador(string nombre, string apellido, int salaAsignada)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            puntaje = 0;
            partidasGanadas = 0;
            this.salaAsignada = salaAsignada;
            dadosPrometedores = new List<Dado>();
        }

        internal void Mezclar()
        {
            foreach (Dado dado in Sala.Dados)
            {
                Random rand = new Random();
                dado.ValorDeCara = rand.Next(1, 7);
            }
        }

        internal string TirarDados()
        {
            StringBuilder valorDados = new StringBuilder();

            foreach (Dado dado in Sala.Dados)
            {
                valorDados.Append($"{dado.ValorDeCara.ToString()},");
                GuardarUnDado(dado);
            }

            return valorDados.ToString();
        }


        internal void QuitarUnDado(int posicion)
        {
            if (DadosPrometedores[posicion] is not null)
            {
                DadosPrometedores.Remove(DadosPrometedores[posicion]);
            }
        }

        internal void GuardarUnDado(Dado dado)
        {
            if (dado is not null)
            {
                this.dadosPrometedores.Add(dado);
            }
        }

        public void SumarPuntos(List<Dado> dados)
        {
            if (Reglas.EscaleraMayor(dados))
                Puntaje += 20;

            if (Reglas.EscaleraMenor(dados))
                Puntaje += 20;

            if (Reglas.Full(dados))
                Puntaje += 30;

            if (Reglas.Poker(dados))
                Puntaje += 40;

            if (Reglas.Generala(dados))
                Puntaje += 50;
        }

        public string CantarJuego(List<Dado> dados)
        {
            if (Reglas.EscaleraMayor(dados))
                return "Escalera Mayor";

            if (Reglas.EscaleraMenor(dados))
                return "Escalera Menor";

            if (Reglas.Full(dados))
                return "Full";

            if (Reglas.Poker(dados))
                return "Poker";

            if (Reglas.Generala(dados))
                return "Generala";


            return "No hay juego";
        }

        public void JugarMano()
        {
            Mezclar();
            Console.WriteLine(TirarDados());
            SumarPuntos(Sala.Dados);
            Console.WriteLine(CantarJuego(Sala.Dados));
            Console.WriteLine(Puntaje);
            //LIMPIAR LISTA DADOS SALA
            Sala.Dados.Clear();
            //AGREGAR DADOS BUENOS A LA LISTA DADOS SALA
        }

        public static bool JugadaEnPuerta(List<Dado> dados)
        {

            return false;
        }


        //EL JUGADOR DEBE TENER UNA LISTA DE DADOS
        //DONDE SE GUARDEN LOS QUE LE SIRVEN PARA
        //ARMAR JUEGO
    }
}
