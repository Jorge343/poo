using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_6
{
    class libro
    {
        private int ISBN;
        private string titulo;
        private string autor;
        private int paginas;
        private int precio;

        public libro(int ISBN, string titulo, string autor, int paginas, int precio)
        {
            this.ISBN = ISBN;
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
            this.precio = precio;

            
        }
        
        public int getISBN()
        {
            return ISBN;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public string getAutor()
        {
            return autor;
        }
        public int getPaginas()
        {
            return paginas;
        }
        public int getPrecio()
        {
            return precio;
        }
        public void setISBN(int ISBN)
        {
            this.ISBN = ISBN;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void setAutor(string autor)
        {
            this.autor = autor;
        }
        public void setPaginas(int paginas)
        {
            this.paginas = paginas;
        }
        public void setPrecio(int precio)
        {
            this.precio = precio;
        }
        public override string ToString()
        {
            return "El libro " + ISBN + " creado por " + autor + " tiene " + paginas + " paginas en total";
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            libro libroA = new libro(2222222, "Frio", "Sergio", 142, 3500);
            libro libroB = new libro(4444444, "Calor", "Paula", 187, 4000);
            
            Console.WriteLine(libroA.ToString());
            Console.WriteLine("-----------------");
            Console.WriteLine(libroB.ToString());
            Console.WriteLine("-----------------");

            if (libroA.getPaginas() > libroB.getPaginas())
            Console.WriteLine("El libro:" +libroA.getTitulo()+ " Tiene más paginas" );


            else
            Console.WriteLine("El libro:" + libroB.getTitulo() + " Tiene más paginas");

            Console.WriteLine("");
            Console.WriteLine("¿Cual libro quiere comprar?");
            Console.WriteLine(" Frio(0)    -     Calor(1)");
            int precio = int.Parse(Console.ReadLine());

            if (precio == 0)
                Console.WriteLine("Total a pagar: " + libroA.getPrecio());
            else
                Console.WriteLine("Total a pagar: " + libroB.getPrecio());

 

        }

    }
}
