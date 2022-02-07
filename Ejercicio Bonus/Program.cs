using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = GetMaxNumber();

            Console.WriteLine("El número mayor es: " + Convert.ToString(max));
            Console.ReadLine();
        }

        public static int GetMaxNumber()
        {
            var liste = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese número");
                var nn = Convert.ToInt32(Console.ReadLine());
                if (liste.Contains(nn))
                {
                    Console.WriteLine("Número " + Convert.ToString(nn) + " ya existe en la lista, debe ser diferente");
                    i--;
                }
                liste.Add(nn);
            }

            return liste.Max();
        }
    }
}
