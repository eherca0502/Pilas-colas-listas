using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_colas_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Nombres = new List<string>();
            Console.WriteLine("_______Lista______");
            Nombres.Add("Erick");
            Nombres.Add("Angel");
            Nombres.Add("Ernesto");
            Nombres.Add("Jose");
            Nombres.Add("Liz");
            Nombres.Add("Andrea");
            Nombres.Sort(); // ordena nuestra lista
            for (int i = 0; i < Nombres.Count; i++)
            {
                Console.WriteLine(Nombres[i]);

            }
            Queue<string> Cola = new Queue<string>();
            Console.WriteLine("_________Cola________");
            Cola.Enqueue("Primero");
            Cola.Enqueue("Segundo");
            Cola.Enqueue("Tercero");
            Cola.Enqueue("Cuarto");
            Cola.Enqueue("Quinto");
            foreach (var item in Cola)
            {
                Console.WriteLine(item);
            }
            Stack<string> Pila = new Stack<string>();
            Console.WriteLine("_____Pila_______");
            Pila.Push("Primero");
            Pila.Push("Segundo");
            Pila.Push("Tercero");
            Pila.Push("Cuarto");
            Pila.Push("Quinto");
            foreach (var item in Pila)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
