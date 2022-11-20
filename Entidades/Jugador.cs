using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private string nombre;
        private string apellido;
        private int puntaje;
        private string especie;
        private int id;
        public List<int> dadosJugador;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Especie { get => especie; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public int Id { get => id; }

        public Jugador(int id, string nombre, string apellido, string especie)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especie = especie;
            this.id = id;
            puntaje = 0;
            this.dadosJugador = new List<int>();
        }

        //CUANDO TERMINE, ARREGLAR PARA QUE MEZCLE CON LOS DADOS QUE HAYA
        public void Mezclar(List<int> dados)
        {
            dados.Clear();

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                dados.Add(rand.Next(1, 7));
            }

        }

        public List<int> Mezclar()
        {
            Random rand = new Random();

            List<int> aux = new List<int>();

            aux.Clear();

            for (int i = 0; i < 5; i++)
            {
                aux.Add(rand.Next(1, 7));
            }

            return aux;
        }

        public string TirarDados(List<int> dados)
        {
            List<int> ordenados = dados.OrderBy(dado => dado).ToList();

            StringBuilder valorDados = new StringBuilder();

            ordenados.ForEach(dado => valorDados.Append($"{dado} "));

            return valorDados.ToString();
        }

        public void SumarPuntos(List<int> dados)
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

        public string BuscarJuego(List<int> dados)
        {

            if (Reglas.EscaleraMayor(dados))
                return "Escalera Mayor +20".ToUpper();

            if (Reglas.EscaleraMenor(dados))
                return "Escalera Menor +20".ToUpper();

            if (Reglas.Full(dados))
                return "Full +30".ToUpper();

            if (Reglas.Poker(dados))
                return "Poker +40".ToUpper();

            if (Reglas.Generala(dados))
                return "Generala +50".ToUpper();


            return "No hay juego".ToUpper();


        }

        public static string MostrarDadosGuardados(List<int> lista1, List<int> lista2)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            foreach (int dado in lista1)
            {
                if (dado > 0)
                {
                    sb.Append($"{dado} ");
                }
            }

            foreach (int dado in lista2)
            {
                if (dado > 0)
                {
                    sb2.Append($"{dado} ");
                }
            }
            return $"Dados guardados: {sb} {sb2}".ToUpper();
        }

        public static string MostrarDadosGuardados(List<int> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int dado in lista)
            {
                if (dado > 0)
                {
                    sb.Append($"{dado} ");
                }
            }

            return $"Dados guardados: {sb}".ToUpper();
        }


        //SI CUANDO SE TIRAN LOS CINCO DADOS ALGUNO SE REPITE DOS O TRES VECES LO GUARDA
        //SI NO DEVUELVE LA LISTA COMO ESTÁ
        public void GuardarDadosParaFullPokerGenerala(List<int> dados)
        {

            int[] carasDelDado = new int[6];

            foreach (int dado in dados) //Veo el valor de cada dado que salio
            {
                switch (dado)
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
                if (carasDelDado[i] == 2)
                {
                    //DadosParaFullPokerGenerala.Add(i + 1);
                    //DadosParaFullPokerGenerala.Add(i + 1);

                }

                if (carasDelDado[i] == 3)
                {
                    //DadosParaFullPokerGenerala.Add(i + 1);
                    //DadosParaFullPokerGenerala.Add(i + 1);
                    //DadosParaFullPokerGenerala.Add(i + 1);
                }

            }


        }

        //TRUE SI ALGUN DADO SE REPITE DOS O TRES VECES
        public static bool PosibleFullPokerGenerala(List<int> dados)
        {
            if (!Reglas.Full(dados) && !Reglas.Generala(dados))
            {
                int[] carasDelDado = new int[6];

                foreach (int dado in dados)
                {
                    switch (dado)
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

        //TRUE SI HAY AL MENOS DOS DADOS CORRELATIVOS
        public static bool PosibleEscalera(List<int> dados)
        {
            int contadorAux = 1;
            List<int> ordenados = dados.OrderBy(dado => dado).ToList();

            for (int i = 0; i < ordenados.Count - 1; i++)
            {
                if (ordenados[i + 1] == ordenados[i])
                {
                    continue;
                }

                if (ordenados[i + 1] == ordenados[i] + 1)
                {
                    contadorAux++;
                }
                else
                    if (contadorAux < 3)
                    contadorAux = 1;
            }

            return contadorAux >= 3 ? true : false;
        }


        //1 SI b == a+1; 0 SI b == a
        internal int EsConsecutivo(int a, int b)
        {
            return b - a;
        }

        public void JugarMano()
        {
            dadosJugador = Mezclar();

            BuscarJuego(dadosJugador);

            SumarPuntos(dadosJugador);
        }

        public string MostrarJuego()
        {
            StringBuilder stringBuilder = new StringBuilder();

            this.dadosJugador.ForEach((x) => stringBuilder.AppendLine($"{x} "));

            return stringBuilder.ToString();
        }
    }
}

//HAY QUE REVISAR TODOS LOS METODOS DEL JUGADOR