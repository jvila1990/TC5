using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            arbol.InsertarNodo(5, "Claudia", "Vivas Paucar");
            arbol.InsertarNodo(2, "Ernesto", "Salvatierra Rosas");
            arbol.InsertarNodo(10, "Pamela", "Valdez Perez");
            arbol.InsertarNodo(100, "Hilda", "Palacios Sanchez");
            arbol.InsertarNodo(1, "Francisco", "Ortiz Garfias");
            arbol.InsertarNodo(3, "Jose", "Rojas Arias");


            //INORDEN - PREORDEN - POSTORDEN
          
            Console.WriteLine("--------------------------");
            Console.WriteLine("Preorden:");
            arbol.Preorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Postorden:");
            arbol.Postorden(arbol.GetRaiz());
            Console.WriteLine("");


            //ELIMINAR UN DATO

            arbol.Eliminar(arbol.GetRaiz(), 100);
            Console.WriteLine("");

            arbol.Eliminar(arbol.GetRaiz(), 1);
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("SE HA ELIMINADO EL REGISTRO 100");
            Console.WriteLine("SE HA ELIMINADO EL REGISTRO 1");
            Console.WriteLine("------------------------");


            //INORDEN - PREORDEN - POSTORDEN
            Console.WriteLine("--------------------------");
            Console.WriteLine("Preorden:");
            arbol.Preorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Postorden:");
            arbol.Postorden(arbol.GetRaiz());
            Console.WriteLine("");





            Console.Read();


        }
    }
}
