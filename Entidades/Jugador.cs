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
        private static int puntaje;
        private static int partidasGanadas;
        private int salaAsignada;
        private List<Dado> dadosPrometedores;
        private List<Dado> dadosParaEscalera;
        private List<Dado> dadosParaFullPokerGenerala;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public static int Puntaje { get => puntaje; set => puntaje = value; }
        public static int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public List<Dado> DadosPrometedores { get => dadosPrometedores; set => dadosPrometedores = value; }
        public List<Dado> DadosParaEscalera { get => dadosParaEscalera; set => dadosParaEscalera = value; }
        public List<Dado> DadosParaFullPokerGenerala { get => dadosParaFullPokerGenerala; set => dadosParaFullPokerGenerala = value; }

        public Jugador(string nombre, string apellido, int salaAsignada)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            puntaje = 0;
            partidasGanadas = 0;
            this.salaAsignada = salaAsignada;
            DadosPrometedores = new List<Dado>();
            DadosParaFullPokerGenerala = new List<Dado>();
            DadosParaEscalera = new List<Dado>();
        }

        internal void Mezclar(List<Dado> dados)
        {
            foreach (Dado dado in dados)
            {
                Random rand = new Random();
                dado.ValorDeCara = rand.Next(1, 7);
            }
        }

        internal string TirarDados(List<Dado> dados)
        {
            List<Dado> ordenados = dados.OrderBy(dado => dado.ValorDeCara).ToList();

            StringBuilder valorDados = new StringBuilder();

            foreach (Dado dado in ordenados)
            {
                valorDados.Append($"{dado.ValorDeCara.ToString()} ");
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

        public string MostrarDadosGuardados(List<Dado> dadosJugador)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Dado dado in dadosJugador)
            {
                if (dado is not null)
                {
                    sb.Append($"{dado.ValorDeCara} ");
                }
            }
            return $"Dados guardados: {sb.ToString()}".ToUpper();
        }

        public void JugarMano() //ESTE PUEDE SER UN DELEGADO QUE LLAME A LOS METODOS
        {
            Sala.mano++;


            //1- MEZCLAR
            Mezclar(Sala.Dados);

            //2- TIRAR / MOSTRAR DADOS
            Console.WriteLine($"DADOS JUGADOS: {TirarDados(Sala.Dados)}");

            //3- REVISAR JUEGOS SERVIDOS O POSIBLES
            //SI HAY POSIBLE ESCALERA Y POSIBLE OTROS PRIORIZAR LOS OTROS Y VOLVER A JUGAR LA ESCALERA


            if (PosibleFullPokerGenerala(Sala.Dados))
            {
                Console.WriteLine("Posible Full, Poker o Generala");
            }
            if (PosibleEscalera(Sala.Dados))
            {
                Console.WriteLine("Posible Escalera");
            }

            //4- CANTAR JUEGOS
            Console.WriteLine(CantarJuego(Sala.Dados));

            //5- SUMAR PUNTOS
            SumarPuntos(Sala.Dados);
            Console.WriteLine($"PUNTAJE: {Puntaje}");

            //5- GUARDAR DADOS UTILES






        }


        //SI CUANDO SE TIRAN LOS CINCO DADOS ALGUNO SE REPITE DOS O TRES VECES LO GUARDA
        //SI NO DEVUELVE LA LISTA COMO ESTÁ
        public void GuardarDadosParaFullPokerGenerala(List<Dado> dados)
        {
            if (!(Reglas.Full(dados) && Reglas.Poker(dados) && Reglas.Generala(dados)))
            {
                Dado dadoAux;
                int[] carasDelDado = new int[6];

                foreach (Dado dado in dados)
                {
                    if (dado is not null && dado.ValorDeCara > 0)
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
                }

                for (int i = 0; i < carasDelDado.Length; i++)
                {
                    if (carasDelDado[i] == 2)
                    {
                        dadoAux = new Dado();
                        dadoAux.ValorDeCara = i + 1;
                        DadosParaFullPokerGenerala.Add(dadoAux);
                        DadosParaFullPokerGenerala.Add(dadoAux);
                    }

                    if (carasDelDado[i] == 3)
                    {
                        dadoAux = new Dado();
                        dadoAux.ValorDeCara = i + 1;
                        DadosParaFullPokerGenerala.Add(dadoAux);
                        DadosParaFullPokerGenerala.Add(dadoAux);
                        DadosParaFullPokerGenerala.Add(dadoAux);
                    }

                }

                //SI ES UN SOLO DADO QUE SIRVE GUARDARLO
            }

        }

        //BOOL SI ALGUN DADO SE REPITE DOS O TRES VECES
        public static bool PosibleFullPokerGenerala(List<Dado> dados)
        {
            if (!(Reglas.Full(dados) && Reglas.Poker(dados) && Reglas.Generala(dados)))
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

        public static bool PosibleEscalera(List<Dado> dados)
        {
            int contadorAux = 1;
            List<Dado> ordenados = dados.OrderBy(dado => dado.ValorDeCara).ToList();

            for (int i = 0; i < ordenados.Count - 1; i++)
            {
                if (ordenados[i + 1].ValorDeCara == ordenados[i].ValorDeCara)
                {
                    continue;
                }

                if (ordenados[i + 1].ValorDeCara == ordenados[i].ValorDeCara + 1)
                {
                    contadorAux++;
                }
                else
                    if (contadorAux < 3)
                    contadorAux = 1;
            }

            return contadorAux >= 3 ? true : false;
        }

        //HACER METODO GUARDAR UN DADO UTIL
        public static bool EsUnDadoUtil(List<Dado> dados)
        {
            /*
             * Recorro la lista de los dados jugados.
             * Tengo un array con los valores que se repiten dos o tres veces.
             * Si un dado jugado completa un juego lo guardo
             */

            throw new NotImplementedException();
        }

        /* public void GuardarPosiblePokerFullGenerala(List<Dado> dados)
         {


             throw new NotImplementedException();
         }
 */
        public void GuardarPosibleEscalera(List<Dado> dados)
        {
            throw new NotImplementedException();
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

//HAY QUE REVISAR TODOS LOS METODOS DEL JUGADOR