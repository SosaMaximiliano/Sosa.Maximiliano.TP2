using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cubilete
    {
        private static Stack<Dado> dados;

        public Cubilete()
        {
            Dados = new Stack<Dado>();

            for (int i = 0; i < 5; i++)
            {
                Dados.Push(new Dado());
            }

            foreach (Dado dado in Dados)
            {
                if (dado is not null)
                {
                    dado.Mezclar();
                }
            }
        }

        public static Stack<Dado> Dados { get => dados; set => dados = value; }

        public string TirarDados()
        {
            StringBuilder valorDados = new StringBuilder();

            foreach (Dado dado in Dados)
            {
                valorDados.AppendLine(dado.ValorDeCara.ToString());
            }

            Dados.Pop();
            return valorDados.ToString();

        }

        public void Mezclar()
        {
            foreach (Dado dado in dados)
            {
                Random rand = new Random();
                dado.ValorDeCara = rand.Next(1, 7);

            }
        }
    }
}
