using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPeople
{
    public class Lista
    {
        public Nodo Principal;
        public Nodo Ultimo;
        public Lista()
        {
            Principal = null;
            Ultimo = null;
        }
        public void InsertarPersona(Personas personas)
        {
            Nodo Nuevo = new Nodo(personas);
            if (Principal == null)
            {
                Principal = Nuevo;
                Principal.Siguiente = null;
                Ultimo = Nuevo;

            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }

        }
    public void mostrarLista()
        {
            Nodo Actual = Principal;
            if (Principal != null)
            {
                while(Actual != null)
                {
                    Console.WriteLine("El nombre de la persona es {0}, su tamaño es {1} y su edad es {2}", Actual.DatosPersonas.nombre, Actual.DatosPersonas.tamaño, Actual.DatosPersonas.edad);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }
        public void buscar(string nombre, string tamaño, int edad)
        {
            Nodo Actual = Principal;
            bool encontrado = false;
            if (Principal != null)
            {
                while (Actual != null)
                {
                    if(Actual.DatosPersonas.nombre == nombre && Actual.DatosPersonas.tamaño == tamaño && Actual.DatosPersonas.edad == edad)
                    {
                        Console.WriteLine("LA PERSONA {0} se encunetra en la lista" ,nombre);
                        encontrado = true;

                    }
                    Actual = Actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("Esta persona no esta en la lista");
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }

        public void editar(string nombre, string tamaño, int edad)
        {
            Nodo Actual = Principal;
            bool encontrado = false;
            if (Principal != null)
            {
                while(Actual != null)
                {
                    if (Actual.DatosPersonas.nombre == nombre && Actual.DatosPersonas.tamaño == tamaño
                        && Actual.DatosPersonas.edad == edad)
                    {
                        Console.WriteLine("Dato encontrado");
                        Console.WriteLine("Ingresa nombre nuevo");
                        string nuevoNombre = Console.ReadLine();
                        Console.WriteLine("Ingresa nuevo tamaño");
                        string nuevoTamaño = Console.ReadLine();
                        Console.WriteLine("Ingresa nueva edad");
                        int nuevaEdad = Convert.ToInt32(Console.ReadLine());
                        Actual.DatosPersonas.nombre = nuevoNombre;
                        Actual.DatosPersonas.tamaño = nuevoTamaño;
                        Actual.DatosPersonas.edad = nuevaEdad;
                        Console.WriteLine("cambios realizado");
                        encontrado = true;



                    }
                    Actual = Actual.Siguiente;
                }
                if (!encontrado) 
                {
                    Console.WriteLine("No existe esta persona en esta lista");
                }
                    
            }
            else
            {
                Console.WriteLine("LISTA VACIA");
            }

        }
        public void eliminar(string Nombre, string Tamaño)
        {
            Nodo Actual = Principal;
            Nodo Anterior = null;
            bool encontrado = false;
            if ( Principal != null ) 
            {
            while(Actual != null && encontrado != true)
                {
                    if (Actual.DatosPersonas.nombre == Nombre && Actual.DatosPersonas.tamaño == Tamaño)
                    {
                        if(Actual == Principal)
                        {
                            Principal = Principal.Siguiente;

                        }
                        else if(Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo.Siguiente = Actual;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Console.WriteLine("Nodo eliminado");
                        encontrado = true;
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("NO esta en la lista");
                }
            }
            else
            {
                Console.WriteLine("LITA VACIA");
            }
        }
        public void ordenar()
        {
            if(Principal == null || Principal.Siguiente == null)
            {
                return;
            }
            Nodo Actual = Principal;
            while(Actual != null)
            {
                Nodo siguiente = Actual.Siguiente;
                while(siguiente != null)
                {
                    if(siguiente.DatosPersonas.edad < siguiente.DatosPersonas.edad)
                    {
                        Personas temp = Actual.DatosPersonas;
                        Actual.DatosPersonas = siguiente.DatosPersonas;
                        siguiente.DatosPersonas = temp;
                    }
                    siguiente = siguiente.Siguiente;
                }
                Actual = Actual.Siguiente;
            }
            mostrarLista();
        }

    }

}
