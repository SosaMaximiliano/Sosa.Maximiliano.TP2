using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public interface ISerializadora<T>
    {
        public T Leer(string nombre);

        public void Escribir(T objeto, string nombre );
    }


}
