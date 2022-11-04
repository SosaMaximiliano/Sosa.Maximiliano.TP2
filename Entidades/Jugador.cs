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
        private List<Dado> dadosParaEscalera;
        private List<Dado> dadosParaFullPokerGenerala;
        public bool vamosPorLaEscalera;
        public bool vamosPorPFG;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public static int Puntaje { get => puntaje; set => puntaje = value; }
        public static int PartidasGanadas { get => partidasGanadas; set => partidasGanadas = value; }
        public List<Dado> DadosParaEscalera { get => dadosParaEscalera; set => dadosParaEscalera = value; }
        public List<Dado> DadosParaFullPokerGenerala { get => dadosParaFullPokerGenerala; set => dadosParaFullPokerGenerala = value; }

        public Jugador(string nombre, string apellido, int salaAsignada)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            puntaje = 0;
            partidasGanadas = 0;
            this.salaAsignada = salaAsignada;
            DadosParaFullPokerGenerala = new List<Dado>();
            DadosParaEscalera = new List<Dado>();
            this.vamosPorLaEscalera = false;
            this.vamosPorPFG = false;
        }

        public void Mezclar(List<Dado> dados)
        {
            Random rand = new Random();

            dados.ForEach(dado => dado.ValorDeCara = rand.Next(1, 7));

        }

        public string TirarDados(List<Dado> dados)
        {
            //List<Dado> ordenados = dados.OrderBy(dado => dado.ValorDeCara).ToList();

            StringBuilder valorDados = new StringBuilder();

            dados.ForEach(dado => valorDados.Append($"{dado.ValorDeCara} "));

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

        public static string MostrarDadosGuardados(List<Dado> lista1, List<Dado> lista2)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            foreach (Dado dado in lista1)
            {
                if (dado is not null)
                {
                    sb.Append($"{dado.ValorDeCara} ");
                }
            }

            foreach (Dado dado in lista2)
            {
                if (dado is not null)
                {
                    sb2.Append($"{dado.ValorDeCara} ");
                }
            }
            return $"Dados guardados: {sb} {sb2}".ToUpper();
        }

        public static string MostrarDadosGuardados(List<Dado> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Dado dado in lista)
            {
                if (dado is not null)
                {
                    sb.Append($"{dado.ValorDeCara} ");
                }
            }

            return $"Dados guardados: {sb}".ToUpper();
        }

        public void JugarMano() //ESTE PUEDE SER UN DELEGADO QUE LLAME A LOS METODOS
        {

            //1- MEZCLAR
            Mezclar(Sala.Dados);

            //2- TIRAR / MOSTRAR DADOS
            Console.WriteLine($"Valor del dado: {TirarDados(Sala.Dados)}".ToUpper());

            //3- REVISAR JUEGOS SERVIDOS O POSIBLES


            if (PosibleFullPokerGenerala(Sala.Dados))
            {
                Console.WriteLine("Posible Full, Poker o Generala".ToUpper());
            }
            if (PosibleEscalera(Sala.Dados))
            {
                Console.WriteLine("Posible Escalera".ToUpper());
            }

            //4- CANTAR JUEGOS
            Console.WriteLine(CantarJuego(Sala.Dados));

            //5- SUMAR PUNTOS
            SumarPuntos(Sala.Dados);
            Console.WriteLine($"PUNTAJE: {Puntaje}");

            //5- GUARDAR DADOS UTILES
            //SI HAY POSIBLE ESCALERA Y POSIBLE PFG DECIDE CON UN RANDOM

            GuardarDados(Sala.Dados);




        }


        //SI CUANDO SE TIRAN LOS CINCO DADOS ALGUNO SE REPITE DOS O TRES VECES LO GUARDA
        //SI NO DEVUELVE LA LISTA COMO ESTÁ
        public void GuardarDadosParaFullPokerGenerala(List<Dado> dados)
        {
            if (!(Reglas.Full(dados) && Reglas.Generala(dados))) //SI NO ES JUEGO SERVIDO
            {
                int[] carasDelDado = new int[6];

                foreach (Dado dado in dados) //Veo el valor de cada dado que salio
                {
                    if (dado is not null)
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
                        DadosParaFullPokerGenerala.Add(new Dado { ValorDeCara = i + 1 });
                        DadosParaFullPokerGenerala.Add(new Dado { ValorDeCara = i + 1 });

                    }

                    if (carasDelDado[i] == 3)
                    {
                        DadosParaFullPokerGenerala.Add(new Dado { ValorDeCara = i + 1 });
                        DadosParaFullPokerGenerala.Add(new Dado { ValorDeCara = i + 1 });
                        DadosParaFullPokerGenerala.Add(new Dado { ValorDeCara = i + 1 });
                    }

                }

            }

        }

        //TRUE SI ALGUN DADO SE REPITE DOS O TRES VECES
        public static bool PosibleFullPokerGenerala(List<Dado> dados)
        {
            if (!Reglas.Full(dados) && !Reglas.Generala(dados))
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

        //TRUE SI HAY AL MENOS DOS DADOS CORRELATIVOS
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




        //HACER METODO COMPLETAR UNA JUGADA
        //SI SE JUEGAN MENOS DE CINCO DADOS (ENTRE UNO Y TRES REALMENTE. PARA QUE TENGA LOGICA DEBERIA TENER AL MENOS DOS GUARDADOS)
        public void CompletarJuego(List<Dado> dados)
        {

            /*
             * Recorro la lista de los dados jugados.
             * Recorro la lista de los dados guardados.
             * Si un dado se repite lo guardo.
             */

            //SI SE JUEGA POR PFG:
            if (vamosPorPFG)
            {
                foreach (Dado dadoGuardado in DadosParaFullPokerGenerala)
                {
                    foreach (Dado dado in dados)
                    {
                        if (dadoGuardado.ValorDeCara == dado.ValorDeCara)
                        {
                            DadosParaFullPokerGenerala.Add(new Dado { ValorDeCara = dado.ValorDeCara });
                            dado.ValorDeCara = 0;
                            break;
                        }
                    }
                }

                foreach (Dado dado in dados) //ROMPE PORQUE SE MODIFICA LA LISTA EN TIEMPO DE EJECUCION. HACER UN METODO QUE LIMPIE LA LISTA
                {
                    if (dado.ValorDeCara == 0)
                    {
                        dados.Remove(dado);
                    }
                }

            }

            //SI SE JUEGA POR LA ESCALERA:
            if (vamosPorLaEscalera)
            {
                foreach (Dado dado in dados) 
                {
                    if (dado.ValorDeCara == dadosParaEscalera[0].ValorDeCara - 1 || dado.ValorDeCara == dadosParaEscalera[dadosParaEscalera.Count - 1].ValorDeCara + 1)
                    {
                        dadosParaEscalera.Add(new Dado { ValorDeCara = dado.ValorDeCara });
                        dado.ValorDeCara = 0;
                        break;
                    }
                }

                foreach (Dado dado in dados) //ROMPE PORQUE SE MODIFICA LA LISTA EN TIEMPO DE EJECUCION. HACER UN METODO QUE LIMPIE LA LISTA
                {
                    if (dado.ValorDeCara == 0)
                    {
                        dados.Remove(dado);
                    }
                }


            }

        }



        //PARA QUE FUNCIONE TIENEN QUE HABER AL MENOS DOS DADOS PARA QUE COMPARE
        public void GuardarDadosParaEscalera(List<Dado> dados)
        {

            List<Dado> aux = new List<Dado>();
            List<Dado> ordenados = dados.OrderBy(dado => dado.ValorDeCara).ToList();

            for (int i = 0; i < ordenados.Count - 1; i++)
            {
                //if (ordenados[i] is not null && ordenados[i + 1] is not null)
                if (EsConsecutivo(ordenados[i].ValorDeCara, ordenados[i + 1].ValorDeCara) == 0)
                {
                    ordenados.RemoveAt(i);
                }

            }

            for (int i = 0; i < ordenados.Count - 1; i++)
            {
                if (EsConsecutivo(ordenados[i].ValorDeCara, ordenados[i + 1].ValorDeCara) == 1)
                {
                    aux.Add(new Dado { ValorDeCara = ordenados[i].ValorDeCara });
                }
            }

            //HAY UN DADO QUE NO SE GUARDA CON EL METODO PERO QUE EXISTE, ASÍ QUE LO GENERO A MANOPLA

            if (aux.Count > 0)
            {
                aux.Insert(aux.Count, new Dado { ValorDeCara = (aux[aux.Count - 1].ValorDeCara + 1) });
            }

            DadosParaEscalera = aux;

        }



        public void GuardarDados(List<Dado> dados)
        {
            Random rand = new Random();

            if (PosibleEscalera(Sala.Dados) && PosibleFullPokerGenerala(Sala.Dados))
            {
                int aleatorio = rand.Next(1, 3);

                if (aleatorio == 1)
                {
                    vamosPorLaEscalera = true;
                    GuardarDadosParaEscalera(Sala.Dados);
                    Sala.Dados.Clear();
                    for (int i = 0; i < 5 - DadosParaEscalera.Count; i++)
                    {
                        Sala.Dados.Add(new Dado());
                    }
                }
                else
                {
                    vamosPorPFG = true;
                    GuardarDadosParaFullPokerGenerala(Sala.Dados);
                    Sala.Dados.Clear();
                    for (int i = 0; i < 5 - DadosParaFullPokerGenerala.Count; i++)
                    {
                        Sala.Dados.Add(new Dado());
                    }
                }
            }
            else
            {
                vamosPorPFG = true;
                GuardarDadosParaFullPokerGenerala(Sala.Dados);
                Sala.Dados.Clear();
                for (int i = 0; i < 5 - DadosParaFullPokerGenerala.Count; i++)
                {
                    Sala.Dados.Add(new Dado());
                }
            }

        }

        //1 SI b == a+1; 0 SI b == a
        internal int EsConsecutivo(int a, int b)
        {
            return b - a;
        }
    }
}

//HAY QUE REVISAR TODOS LOS METODOS DEL JUGADOR