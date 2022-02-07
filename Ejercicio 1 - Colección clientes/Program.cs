using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Colección_clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientes = GetClients();
            Console.WriteLine("\n\nNombre Cliente");
            Console.WriteLine("===================");
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.ReadLine();
        }

        public static List<string> GetClients()
        {
            var clientes = new List<string>();
            string continuar = "S";
            do
            {
                //escribe y obtiene nombre del cliente
                Console.WriteLine("Ingrear nombre del cliente: ");
                var nombre = Console.ReadLine();
                //agregar nombre cliente a la lista
                clientes.Add(nombre);
                //preguntar si desea seguir registrando clientes
                Console.WriteLine("Desea registrar otro cliente (SI/NO):");
                var resp = Console.ReadLine().ToLower();
                //validar respuestas unicamente Si o bien No
                while(resp != "si" && resp != "no")
                {
                    Console.WriteLine("Desea registrar otro cliente (SI/NO):");
                    resp = Console.ReadLine().ToLower();
                }
                //condición para seguir escribiendo nombre de clientes.
                if(resp == "no")
                {
                    continuar = "N";
                }

            } while (continuar == "S");
            //filtrar clientes en las que su nombre contiene "RE"
            clientes = clientes.Where(x => x.ToLower().Contains("re")).ToList();
            return clientes;
        }
    }


}
