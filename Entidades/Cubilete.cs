using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cubilete
    {
        public Cubilete(List<Dado> dados)
        {
            for (int i = 0; i < 5; i++)
            {
                dados.Add(new Dado());
            }
        }


        
    }
}
