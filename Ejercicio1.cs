using System;

namespace Ejercicio1
{
    class Program
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string apellido { get; set; }

        public void mostrar(string cedula, string nombre, string apellido, int edad)
        {
            mostrar(cedula, nombre, apellido, edad);
        }
    }
    class profesor : persona
    {
        public int sueldo { get; set; }
        public String mostrar(string player)
        {
            return player;
        }

    }
    static void Main(string[] args)
    {
        persona p1 = new persona();
        profesor chuty = new profesor();
        p1.cedula = "0016854723 ";
        p1.nombre = " jose";
        p1.edad = 20;
        p1.apellido = " perez";

        chuty.sueldo = 50000;

        //Console.WriteLine(p1.mostrar(p1.cedula,p1.nombre,p1.edad,p1.edad));
        Console.WriteLine("hola soy {0} {1} tengo {2} años y mi cedula es {3} ", p1.nombre, p1.apellido, p1.edad, p1.cedula);

        chuty.cedula = "0014578273";
        chuty.nombre = " enrriquez";
        chuty.edad = 39;
        chuty.apellido = " rodriguez";
        chuty.sueldo = 50000;

        Console.WriteLine("hola soy{0} {1} tengo {2} años y mi cedula es {3} y tengo un sueldo de {4} pesos", chuty.nombre, chuty.apellido, chuty.edad, chuty.cedula, chuty.sueldo);


        Console.ReadKey();
    }
    }
}
