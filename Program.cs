using System;

namespace Animals
{
    class Program
    {
        // En POO, las funciones y procedimientos se llaman métodos
        // En todo programa, se debe incluir un punto inicial
        // El nombre estándar para el método que inicia un programa
        // es "main": static void Main
        // 
        // void -> no devuelve ningún valor (es un procedimiento)
        // static -> entorno estático; trabajando a nivel clase en vez de objeto
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            DecirHolaMundo();
            
            // string nombre;
            // Usar clase como tipo de variable
            // new -> construir algo
            // new Mapache() -> Llamar al método constructor y crear un nuevo Mapache
            Mapache mapache1 = new Mapache(true, 40f, 3.5f, "gris", "Nala");
            Mapache mapache2 = new Mapache(false, 50f, 5.5f, "marron", "Leo");
            Mapache mapache3 = new Mapache(true, 65f, 9f, "negro", "Kira");
            Mapache mapache4 = new Mapache(true, 50f, 4.5f, "gris", null);

            //TODO: Crear 2 mapaches distintos
            // Mapache mapache2 = new Mapache();

            //TODO: Agregar propiedad nombre a cada Mapache

            Console.WriteLine("Color: " + mapache1.color);
            Console.WriteLine("Nombre: " + mapache4.nombre);

            //Acciones
            mapache1.Moverse();
            mapache4.Moverse();

            mapache2.Comer();
            mapache3.Comer();

            mapache1.Trepar();
            mapache2.Trepar();

            mapache1.Hablar();
            mapache3.Hablar();

            //Informacion general de mapaches
            Console.WriteLine("-----------------");
            Console.WriteLine("Informacion general de mapaches");
            Console.WriteLine("");
            if(Mapache.viviparo)
            {
                Console.WriteLine("Viviparo");

            }
            else
            {
                Console.WriteLine("Oviparo");
            }
            if (Mapache.tipoAlimentacion == TipoAlimentacion.CARNIVORO)
            {
                Console.WriteLine("Carnivoro");
            }
            
            else if (Mapache.tipoAlimentacion == TipoAlimentacion.HERBIVORO)
            {
                Console.WriteLine("Herbivoro");
            }

            else if (Mapache.tipoAlimentacion == TipoAlimentacion.OMNIVORO)
            {
                Console.WriteLine("Omnivoro");
            }
        }

        static string ObtenerTextoAMostrar()
        {
            return "Hello World!";
        }
        
        static void DecirHolaMundo()
        {
            string textoAMostrar = ObtenerTextoAMostrar();
            Console.WriteLine(textoAMostrar);
        }

    }
}
