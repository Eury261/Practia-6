using System;

using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Contacto
{
    public class Contacto
    {
        public string Nombre;
        public string Apellido;
        public int Telefono;
        public string Direccion;
        public void SetContacto(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public void SetContacto1(String Apellido)
        {
            this.Apellido = Apellido;
        }
        public void SetContacto2(int Telefono)
        {
            this.Telefono = Telefono;
        }
        public void SetContacto3(string Direccion)
        {
            this.Direccion = Direccion;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola soy " + Nombre + " " + Apellido + ", y vivo en " + Direccion + ", mi telefono es " + Telefono + "");
        }
        public class ProbarContacto
        {
            public static void Main()
            {
                Contacto cont1 = new Contacto();
                Contacto cont2 = new Contacto();
                cont1.SetContacto("Carlos ");
                cont1.SetContacto1("Guzman ");
                cont1.SetContacto2(809567123);
                cont1.SetContacto3("Nuevo Mexico");
                cont2.SetContacto("Jennifer ");
                cont2.SetContacto1("Lopez");
                cont2.SetContacto2(819230193);
                cont2.SetContacto3("Polo Norte");
                cont1.Saludar();
                cont2.Saludar();
            }
        }
    }

