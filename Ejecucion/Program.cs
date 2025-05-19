using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejecucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol abb= new Arbol();

            abb.insertar(15);
            abb.insertar(9);
            abb.insertar(20);
            abb.insertar(14);
            abb.insertar(17);
            abb.insertar(64);

            abb.dibujarArbol();

            Console.ReadKey();
        }
    }
}
