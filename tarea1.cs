using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Principal
    {
        public string nombre;
        public string telefono;
        public string email;
        public string domicilio;
        public string facebook;
        public Principal(){




    }

        public void imprimenombre()
        {
            Console.WriteLine("ingresa tu Nombre");

        }
        public void imprimetelefono()
        {
            Console.WriteLine("ingresa tu Telefono");

        }
        public void imprimeemail()
        {
            Console.WriteLine("ingresa tu Email");

        }
        public void imprimedomicilio()
        {
            Console.WriteLine("ingresa tu Domicilio");

        }
        public void imprimefacebook()
        {
            Console.WriteLine("ingresa tu Facebook");

        }
        static void Main(string[] args)
        {
            Principal persona = new Principal();

            persona.imprimenombre();
            persona.nombre = Console.ReadLine();
           
            persona.imprimetelefono();
            persona.telefono = Console.ReadLine();
            
            persona.imprimeemail();
            persona.email = Console.ReadLine();
            
            persona.imprimedomicilio();
            persona.domicilio = Console.ReadLine();
           
            persona.imprimefacebook();
            persona.facebook = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("FACEBOOK: " + persona.facebook);
            Console.WriteLine("NOMBRE: " + persona.nombre);
            Console.WriteLine("TELEFONO: " + persona.telefono);
            Console.WriteLine("EMAIL: " + persona.email);
            Console.WriteLine("DOMICILIO: " + persona.domicilio);
            
            
            Console.ReadLine();






        }
    }
}
