using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Reglas
    {

        public static bool EscaleraMenor(List<Dado> dados)
        {
            int contadorAux = 1;

            foreach (Dado dado in dados)
            {
                if (dado is null || dado.ValorDeCara != contadorAux)
                {
                    return false;
                }

                contadorAux++;
            }

            return true;
        }

        public static bool EscaleraMayor(List<Dado> dados)
        {
            int contadorAux = 2;

            foreach (Dado dado in dados)
            {
                if (dado is null || dado.ValorDeCara != contadorAux)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Full(List<Dado> dados)
        {
            bool flag2 = false;
            bool flag3 = false;
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
                    flag3 = true;
                }
            }

            foreach (int valor in cara)
            {
                if (valor == 2)
                {
                    flag2 = true;
                }
            }

            if (flag3 && flag2)
            {
                return true;
            }

            return false;
        }

        public static bool Poker(List<Dado> dados)
        {
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
                if (valor == 4)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Generala(List<Dado> dados)
        {
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
                if (valor == 5)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool GeneralaReal(List<Dado> dados)
        {
            int contadorAux = 0;

            foreach (Dado dado in dados)
            {
                if (dado.ValorDeCara == 1)
                {
                    contadorAux++;
                }
            }

            if (contadorAux >= 5)
            {
                return true;
            }

            return false;
        }

    }
}
