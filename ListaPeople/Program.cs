using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListaPeople
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Lista lista = new Lista();
            int menu = 0;
            do
            {
                Console.WriteLine("1.Ingresar persona");
                Console.WriteLine("2.Mostar lista de personas");
                Console.WriteLine("3.buscar");
                Console.WriteLine("4. modificar");
                Console.WriteLine("SELECCIONA UNA");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Ingresa nombre");
                        string Nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa tamaño");
                        string Tamaño = Console.ReadLine();
                        Console.WriteLine("Ingresa edad");
                        int Edad = int.Parse(Console.ReadLine());
                        Personas personas = new Personas { nombre = Nombre, tamaño = Tamaño, edad = Edad };
                        lista.InsertarPersona(personas);
                        break;
                    case 2:
                        Console.WriteLine("La lista de personas es");
                        lista.mostrarLista();
                        break;
                    case 3:
                        Console.WriteLine("Ingresa Nombre pa buscar");
                        string Nombre1 = Console.ReadLine();
                        Console.WriteLine("TAMAÑO");
                        string tamaño1 = Console.ReadLine();
                        Console.WriteLine("EDAD");
                        int edad1 = int.Parse(Console.ReadLine());
                        lista.buscar(Nombre1, tamaño1, edad1);

                        break;
                    case 4:
                        Console.WriteLine("Ingresa Nombre pa buscar");
                        string Nombre11 = Console.ReadLine();
                        Console.WriteLine("TAMAÑO");
                        string tamaño11 = Console.ReadLine();
                        Console.WriteLine("EDAD");
                        int edad11 = int.Parse(Console.ReadLine());
                        lista.editar(Nombre11, tamaño11, edad11);
                        break;
                    case 5:
                        Console.WriteLine("Ingresa Nombre para eliminar");
                        string Nombre111 = Console.ReadLine(); 
                        Console.WriteLine("Ingresa Tamaño para eliminar");
                        string Tamaño111 = Console.ReadLine();
                        lista.eliminar(Nombre111,Tamaño111);
                        break;
                    case 6:
                        lista.ordenar();
                        break;

                }
            }
            while (menu != 7);
        }
    }
}
