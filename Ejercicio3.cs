using System;

namespace Ejercicio3
{
    class Program
    {
        public A(int a)
        {
            Console.WriteLine("Constructor de la clase A");
            Console.WriteLine(a);
        }
    }

    public class B : A
    {
        public B(int b) : base(b / 2)
        {
            Console.WriteLine("Constructor de la clase B");
            Console.WriteLine(b);
        }
    }

    public class C : B
    {
        public C(int c) : base(c / 2)
        {
            Console.WriteLine("Constructor de la clase C");
            Console.WriteLine(c);
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            C obj1 = new C(20);
            Console.ReadKey();
        }
    }
}
