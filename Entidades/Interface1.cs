using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface Interface1<T>
    {
        public List<T> Leer();

        public void Escribir(string texto);
    }
}
