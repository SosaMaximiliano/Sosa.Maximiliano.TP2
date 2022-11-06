using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Reglas
    {

        public static bool EscaleraMenor(List<int> dados)
        {
            int contadorAux = 0;

            for (int i = 1; i < 6; i++)
            {
                foreach (int dado in dados)
                {
                    if (dado == i)
                    {
                        contadorAux++;
                        break;
                    }

                }
            }

            return contadorAux == 5 ? true : false;

        }

        public static bool EscaleraMayor(List<int> dados)
        {
            int contadorAux = 0;

            for (int i = 2; i <= 6; i++)
            {
                foreach (int dado in dados)
                {
                    if (dado == i)
                    {
                        contadorAux++;
                        break;
                    }

                }
            }

            return contadorAux == 5 ? true : false;
        }

        public static bool Full(List<int> dados)
        {
            bool flag2 = false;
            bool flag3 = false;
            int[] cara = new int[6];

            foreach (int dado in dados)
            {
                switch (dado)
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

        public static bool Poker(List<int> dados)
        {
            int[] cara = new int[6];

            foreach (int dado in dados)
            {
                switch (dado)
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

        public static bool Generala(List<int> dados)
        {
            int[] cara = new int[6];

            foreach (int dado in dados)
            {
                switch (dado)
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

        public static bool GeneralaServida(List<int> dados)
        {
            if (dados.Count == 5)

                if (Generala(dados))
                {
                    return true;
                }

            return false;
        }

    }
}
