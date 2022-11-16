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
        //private string apellido;
        private int puntaje;
        private List<int> dadosParaEscalera;
        private List<int> dadosParaFullPokerGenerala;
        public List<int> dadosJugador;
        public bool vamosPorLaEscalera;
        public bool vamosPorPFG;

        public string Nombre { get => nombre; }
        //public string Apellido { get => apellido; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public List<int> DadosParaEscalera { get => dadosParaEscalera; set => dadosParaEscalera = value; }
        public List<int> DadosParaFullPokerGenerala { get => dadosParaFullPokerGenerala; set => dadosParaFullPokerGenerala = value; }

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            //this.apellido = apellido;
            puntaje = 0;
            dadosParaFullPokerGenerala = new List<int>();
            dadosParaEscalera = new List<int>();
            this.vamosPorLaEscalera = false;
            this.vamosPorPFG = false;
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
                    DadosParaFullPokerGenerala.Add(i + 1);
                    DadosParaFullPokerGenerala.Add(i + 1);

                }

                if (carasDelDado[i] == 3)
                {
                    DadosParaFullPokerGenerala.Add(i + 1);
                    DadosParaFullPokerGenerala.Add(i + 1);
                    DadosParaFullPokerGenerala.Add(i + 1);
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


        //SI SE JUEGAN MENOS DE CINCO DADOS (ENTRE UNO Y TRES REALMENTE. PARA QUE TENGA LOGICA DEBERIA TENER AL MENOS DOS GUARDADOS)
        public void CompletarJuego(List<int> dados)
        {
            List<int> listaAux = new List<int>();
            //SI SE JUEGA POR PFG:
            /*
             * Recorro la lista de los dados jugados.
             * Recorro la lista de los dados guardados.
             * Si un dado se repite lo guardo en la lista auxiliar.
             */
            if (vamosPorPFG)
            {
                listaAux.Clear();
                listaAux = DadosParaFullPokerGenerala.ToList();

                foreach (int dadoGuardado in DadosParaFullPokerGenerala)
                {
                    foreach (int dado in dados)
                    {
                        if (dadoGuardado == dado)
                        {
                            listaAux.Add(dado);
                            break;
                        }
                    }
                }

                DadosParaFullPokerGenerala.Clear();
                DadosParaFullPokerGenerala = listaAux.ToList();

            }

            //SI SE JUEGA POR LA ESCALERA:
            if (vamosPorLaEscalera)
            {
                listaAux = DadosParaEscalera.ToList();

                foreach (int dado in dados)
                {
                    //REVISAR ACA:
                    //SI TENGO GUARDADO 2,3,4 Y ME SALE 1 y 5 PODRIA FUNCIONAR
                    //PERO SI TENGO 2,3,4 Y ME SALE 5 Y 6 SOLO ME VA A GUARDAR EL 5
                    if (dado == dadosParaEscalera[0] - 1 || dado == dadosParaEscalera[dadosParaEscalera.Count - 1] + 1)
                    {
                        listaAux.Add(dado);
                        break;
                    }
                }

                DadosParaEscalera.Clear();
                DadosParaEscalera = listaAux.ToList();
            }

        }


        //PARA QUE FUNCIONE TIENEN QUE HABER AL MENOS DOS DADOS PARA QUE COMPARE
        public void GuardarDadosParaEscalera(List<int> dados)
        {

            List<int> aux = new List<int>();
            List<int> ordenados = dados.OrderBy(dado => dado).ToList();

            for (int i = 0; i < ordenados.Count - 1; i++)
            {
                if (EsConsecutivo(ordenados[i], ordenados[i + 1]) == 0) //SI SON IGUALES
                {
                    ordenados.RemoveAt(i);
                }

            }

            for (int i = 0; i < ordenados.Count - 1; i++)
            {
                if (EsConsecutivo(ordenados[i], ordenados[i + 1]) == 1) //SI b ES CORRELATIVO DE a
                {
                    aux.Add(ordenados[i]);
                }
            }

            //HAY UN DADO QUE NO SE GUARDA CON EL METODO PERO QUE EXISTE, ASÍ QUE LO GENERO A MANOPLA

            if (aux.Count > 0)
            {
                aux.Insert(aux.Count, aux[aux.Count - 1] + 1);
            }

            DadosParaEscalera = aux;

        }


        //1 SI b == a+1; 0 SI b == a
        internal int EsConsecutivo(int a, int b)
        {
            return b - a;
        }

        public void JugarMano()
        {
            dadosJugador = Mezclar();

            MostrarJuego();

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