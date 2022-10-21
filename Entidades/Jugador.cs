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
        private List<Dado> dados;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public static int Puntaje { get => puntaje; set => puntaje = value; }
        public static int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public List<Dado> Dados { get => dados; set => dados = value; }


        public Jugador(string nombre, string apellido, int salaAsignada)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            puntaje = 0;
            partidasGanadas = 0;
            this.salaAsignada = salaAsignada;
            dados = new List<Dado>();
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
            if (Dados[posicion] is not null)
            {
                Dados.Remove(dados[posicion]);
            }
        }

        internal void GuardarUnDado(Dado dado)
        {
            if (dado is not null)
            {
                this.dados.Add(dado);
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

        public void CantarJuego(List<Dado> dados)
        {
            if (Reglas.EscaleraMayor(dados))
                Console.WriteLine("Escalera Mayor");

            if (Reglas.EscaleraMenor(dados))
                Console.WriteLine("Escalera Menor");

            if (Reglas.Full(dados))
                Console.WriteLine("Full");

            if (Reglas.Poker(dados))
                Console.WriteLine("Poker");

            if (Reglas.Generala(dados))
                Console.WriteLine("Generala");
        }

        public void JugarMano()
        {
            Mezclar();
            Console.WriteLine(TirarDados());
            SumarPuntos(Dados);
            CantarJuego(Dados);
            Console.WriteLine(Puntaje);
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
