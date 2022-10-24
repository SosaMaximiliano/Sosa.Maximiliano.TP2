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
                DadosPrometedores.Add(dado);
            }

            return valorDados.ToString();
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
            Sala.mano++;

            Mezclar();
            Console.WriteLine(TirarDados());
            SumarPuntos(Sala.Dados);
            Console.WriteLine($"{CantarJuego(Sala.Dados)}: {Puntaje} puntos.");

            if (PosibleFull(Sala.Dados))
            {
                DadosPrometedores = ListarDadosUtiles(Sala.Dados);
                Sala.Dados.Clear();
                for (int i = 0; i < 5 - DadosPrometedores.Count; i++)
                {
                    Sala.Dados.Add(new Dado());
                }
            }

            

        }

        public static List<Dado> ListarDadosUtiles(List<Dado> dados)
        {
            if (!Reglas.Full(dados))
            {
                Dado dadoAux;
                List<Dado> listaAux = new List<Dado>();
                int[] carasDelDado = new int[6];

                foreach (Dado dado in dados)
                {
                    switch (dado.ValorDeCara)
                    {
                        case 1:
                            carasDelDado[0]++;
                            break;
                        case 2:
                            carasDelDado[1]++;
                            break;
                        case 3:
                            carasDelDado[2]++;
                            break;
                        case 4:
                            carasDelDado[3]++;
                            break;
                        case 5:
                            carasDelDado[4]++;
                            break;
                        case 6:
                            carasDelDado[5]++;
                            break;
                        default:
                            break;
                    }
                }

                //RECORRER EL ARRAY

                for (int i = 0; i < carasDelDado.Length; i++)
                {
                    if (carasDelDado[i] == 2)
                    {
                        dadoAux = new Dado();
                        dadoAux.ValorDeCara = i + 1;
                        listaAux.Add(dadoAux);
                        listaAux.Add(dadoAux);
                    }

                    if (carasDelDado[i] == 3)
                    {
                        dadoAux = new Dado();
                        dadoAux.ValorDeCara = i + 1;
                        listaAux.Add(dadoAux);
                        listaAux.Add(dadoAux);
                        listaAux.Add(dadoAux);
                    }

                }
                return listaAux;
            }

            return dados;
        }

        public static bool PosibleFull(List<Dado> dados)
        {
            if (!Reglas.Full(dados))
            {
                int[] carasDelDado = new int[6];

                foreach (Dado dado in dados)
                {
                    switch (dado.ValorDeCara)
                    {
                        case 1:
                            carasDelDado[0]++;
                            break;
                        case 2:
                            carasDelDado[1]++;
                            break;
                        case 3:
                            carasDelDado[2]++;
                            break;
                        case 4:
                            carasDelDado[3]++;
                            break;
                        case 5:
                            carasDelDado[4]++;
                            break;
                        case 6:
                            carasDelDado[5]++;
                            break;
                        default:
                            break;
                    }
                }


                for (int i = 0; i < carasDelDado.Length; i++)
                {
                    if (carasDelDado[i] == 2 || carasDelDado[i] == 3)
                    {
                        return true;
                    }
                }


            }

            return false;
        }

        //REVISAR
        //SE ROMPE PORQUE MODIFICA LA LISTA EN TIEMPO DE EJECUCION
        /*public void AgregarDadoUtil(List<Dado> dados)
        {
            foreach (Dado dado in dados)
            {
                foreach (Dado dadoJugador in this.DadosPrometedores)
                {
                    if (dado.ValorDeCara == dadoJugador.ValorDeCara)
                    {
                        DadosPrometedores.Add(dado);
                    }
                }
            }
        }*/

    }
}
