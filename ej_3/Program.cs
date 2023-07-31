using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no

{
    class password
    {
        int longitud = 8;
        string contraseña;



    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De cual numero desea saber su tabla?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Entendido...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Aguarde unos segundos, problemas tecnicos");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Lamentamos la espera");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("¿Hasta que numero le gustaria que se multiplique su numero?");
            int max = int.Parse(Console.ReadLine());


            for (int i = 0; i < max+1; i++)
            {
                
                
                Console.WriteLine(num + "X" + i + "=" + i * num);
                
                
            }
            Console.ReadLine();
            

        }

    }
}













