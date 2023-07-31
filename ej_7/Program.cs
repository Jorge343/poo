using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_7
{
    class Raices
    {
        private double a;
        private double b;
        private double c;

        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
            
        }
        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return b;
        }
        public double getC()
        {
            return c;
        }
        public void setA(int a)
        {
            this.a = a;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public void setC(int c)
        {
            this.c = c;
        }
        
        private void obtenerRaices()
        {
            double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a)); ;
            double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a));
            Console.WriteLine("Solución 1");
            Console.WriteLine(x1);
            Console.WriteLine("Solución 2");
            Console.WriteLine(x2);
            


        }
        private void obtenerRaiz()
        {
            double x = (-b / (2 * a));
            Console.WriteLine("Unica solución");
            Console.WriteLine(x);
        }

        private double getDiscriminante()
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }
        private bool tieneRaices()
        {
            return getDiscriminante() >= 0;
        }
        private bool tieneRaiz()
        {
            return getDiscriminante() == 0;
        }
        public void calcular()
        {
            if (tieneRaiz())
                obtenerRaiz();
            else if (tieneRaices())
                obtenerRaices();
            else Console.WriteLine("No tiene solución :(");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Función:-");
            Console.WriteLine("Ingrese el coeficiente a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el coeficiente b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el coeficiente c");
            double c = double.Parse(Console.ReadLine());
            Raices ecuacion = new Raices(a, b, c);
            ecuacion.calcular();
            Console.ReadLine();
            

        }

    }
}
