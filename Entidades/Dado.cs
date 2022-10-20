using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dado
    {
        private int valorDeCara;

        public Dado()
        {
            this.valorDeCara = Mezclar();        
        }

        public int ValorDeCara { get => valorDeCara; set => valorDeCara = value; }

        public int Mezclar()
        {
            Random rand = new Random();
            return rand.Next(1,6);
        }
    }
}
