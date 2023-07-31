using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1_P
{
    class Cuenta
    {
        double cantidad;
        string titular;
        public Cuenta(double j, string si)
        {
            cantidad = j;
            titular = si;
        }
       
        public double get_cantidad()
        {
            return cantidad;
        }
        public string get_titular()
        {
            return titular;
        }
        void set_cantidad(double j)
        {
            cantidad = j;
        }
        void set_titular(string si)
        {
            titular = si;
        }
        public void ingresar(double j)
        {
            if(j < 0)
            {
                Console.WriteLine("XD");
            }
            else
            {
                cantidad += j;
            }
        }
        public void retirar(double j)
        {
            cantidad = cantidad - j;
            if(cantidad <= 0)
            {
                cantidad = 0;
                Console.WriteLine(cantidad + "Te quedaste pobre");
            }
            else
            {
                Console.WriteLine(cantidad);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar Titular de la cuenta y la cantidad total");
            
            string titular = Console.ReadLine();

            double cantidad = int.Parse(Console.ReadLine());
            
            Cuenta ejecutar = new Cuenta(cantidad, titular);
            Console.WriteLine(ejecutar.get_titular());
            Console.WriteLine(ejecutar.get_cantidad());
            Console.WriteLine("Cantidad a ingresar a la cuenta");
            ejecutar.ingresar(int.Parse(Console.ReadLine()));
            Console.WriteLine(ejecutar.get_cantidad());
            Console.WriteLine("Cantidad a retirar de la cuenta");
            ejecutar.retirar(int.Parse(Console.ReadLine()));
            


        }
    }
}
