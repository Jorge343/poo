using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2
{
    class Persona
    {
        private string nombre = "";
        private int edad = 0;
        private int DNI;
        private string sexo = "H";
        private double peso = 0;
        private double altura = 0;

        public Persona()
        {
            DNI = generaDNI();
        }
        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            DNI = generaDNI();
        }
        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            DNI = generaDNI();
            this.peso = peso;
            this.altura = altura;
        }
        public int generaDNI()
        {
            Random randomnum = new Random();
            int ran = randomnum.Next(1, 9);
            return ran;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public string getSexo()
        {
            return sexo;
        }
        public void setDNI()
        {
            DNI = generaDNI();
        }
        public int getDNI()
        {
            return DNI;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public double getPeso()
        {
            return peso;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getAltura()
        {
            return altura;
        }
       
        public void comprobarSexo(string sexo)
        {
            if(sexo != "H" && sexo != "M")
            {
                this.sexo = "H";
            }

        }
        public bool esMayorDeEdad()
        {
            if (edad > 18)
                return true;
            else
                return false;
        }
        public int calcularIMC()
        {
            if ((this.peso / Math.Pow(this.altura, 2) ) < 20)
                return -1;
            if ((this.peso / Math.Pow(this.altura, 2)) >= 20)
                return 0;
            if ((this.peso / Math.Pow(this.altura, 2)) <= 25)
                return 0;
            else
                return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Persona 1");
            Console.WriteLine("Ingrese el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sexo  ");
            Console.WriteLine("   H   -   M     ");
            Console.WriteLine("(hombre - mujer) ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Ingrese el peso expresado en Kg");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura expresada en metros");
            double altura = double.Parse(Console.ReadLine());

            List<Persona> personas = new List<Persona>();
            Persona perso1 = new Persona(nombre, edad, sexo, peso, altura);
            Console.WriteLine(perso1.getNombre()+ "{0}" + perso1.getEdad() + "{0}" + perso1.getSexo() + "{0}" + perso1.getPeso() + "{0}" + perso1.getAltura(), Environment.NewLine);

            Console.WriteLine("Persona 2");
            Console.WriteLine("Ingrese el nombre");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            int edad2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sexo  ");
            Console.WriteLine("   H   -   M     ");
            Console.WriteLine("(hombre - mujer) ");
            string sexo2 = Console.ReadLine();
      
            Persona perso2 = new Persona(nombre2, edad2, sexo2);
            Console.WriteLine(perso2.getNombre() + " " + perso2.getEdad() + " " + perso2.getSexo());
            
            Persona perso3 = new Persona();
            Console.WriteLine("Persona 3");
            Console.WriteLine(perso3.getNombre() + " " + perso3.getEdad() + " " + perso3.getSexo() + " " + perso3.getPeso() + " " + perso3.getAltura());
            perso3.setNombre("Matias");
            perso3.setEdad(13);
            perso3.setSexo("H");
            perso3.setPeso(57.8);
            perso3.setAltura(1.72);
            Console.WriteLine(perso3.getNombre() + " " + perso3.getEdad() + " " + perso3.getSexo() + " " + perso3.getPeso() + " " + perso3.getAltura());
            Console.WriteLine("Peso de la persona 1");
            Console.WriteLine(perso3.calcularIMC());
            Console.WriteLine("Peso de la persona 2");
            Console.WriteLine(perso3.calcularIMC());
            Console.WriteLine("Peso de la persona 3");
            Console.WriteLine(perso3.calcularIMC());
            Console.WriteLine("Es mayor de edad la primera persona?");
            Console.WriteLine(perso3.esMayorDeEdad());
            Console.WriteLine("Es mayor de edad la segunda persona?");
            Console.WriteLine(perso3.esMayorDeEdad());
            Console.WriteLine("Es mayor de edad la tercera persona?");
            Console.WriteLine(perso3.esMayorDeEdad());



        }
    

        }
    }

