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
                Dados.Add(dado);
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

        public void JugarMano()
        {
            Mezclar();
            Console.WriteLine(TirarDados());

        }

        public static bool JugadaEnPuerta(List<Dado> dados)
        {
            bool dosDados = false;
            bool tresDados = false;
            int[] cara = new int[6];

            foreach (Dado dado in dados)
            {
                switch (dado.ValorDeCara)
                {
                    case 1:
                        cara[0]++;
                        break;
                    case 2:
                        cara[1]++;
                        break;
                    case 3:
                        cara[2]++;
                        break;
                    case 4:
                        cara[3]++;
                        break;
                    case 5:
                        cara[4]++;
                        break;
                    case 6:
                        cara[5]++;
                        break;
                    default:
                        break;
                }
            }

            foreach (int valor in cara)
            {
                if (valor == 3)
                {
                    tresDados = true;
                }
                else if (valor == 2)
                {
                    dosDados = true;
                }
            }

            return false;
        }


        //EL JUGADOR DEBE TENER UNA LISTA DE DADOS
        //DONDE SE GUARDEN LOS QUE LE SIRVEN PARA
        //ARMAR JUEGO
    }
}
