using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arbol
    {
        public Nodo raiz_principal = null;

        public void insertar(int dato)
        {
            Insertar(ref raiz_principal, dato);
        }
        private void Insertar(ref Nodo raiz,int dato)
        {
            if (raiz == null)
            {
                Nodo nuevo= new Nodo();
                nuevo.dato = dato;

                raiz = nuevo;
                //Console.WriteLine("Dato insertado");
            } else
            {
                if (dato < raiz.dato)
                {
                    Insertar(ref raiz.izq, dato);
                }
                else if (dato > raiz.dato)
                {
                    Insertar(ref raiz.der, dato);
                } else
                {
                    Console.WriteLine("Dato duplicado");
                }
            }
        }

        public void inOrden()
        {
            InOrden(raiz_principal);
        }
        private void InOrden(Nodo raiz)
        {
            if (raiz!=null)
            {
                InOrden(raiz.izq);
                Console.WriteLine(raiz.dato);
                InOrden(raiz.der);
            }
        }
        public void PreOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine(raiz.dato);
                PreOrden(raiz.izq);                
                PreOrden(raiz.der);
            }
        }
        public void PosOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                PosOrden(raiz.izq);
                PosOrden(raiz.der);
                Console.WriteLine(raiz.dato);
            }
        }

        public void dibujarArbol()
        {
            DibujarArbol(raiz_principal);
        }
        private void DibujarArbol(Nodo raiz)
        {
            if (raiz != null)
            {
                DibujarArbol(raiz.der);
                Console.WriteLine(raiz.dato);
                DibujarArbol(raiz.izq);
            }
        }
    }
}
