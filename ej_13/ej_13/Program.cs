using System.Transactions;
using static Program;

internal class Program
{

    public abstract class Empleados
    {
        private string nombre;
        private int edad;
        private double sueldo;
        private const int PLUS = 300;


        public Empleados(string nombre, int edad, double sueldo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }


        public void setEdad(int edad)
        {
            this.edad = edad;
        }


        public void setSueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }


        public string getNombre()
        {
            return nombre;
        }


        public int getEdad()
        {
            return edad;
        }


        public double getSueldo()
        {
            return sueldo;
        }

        public string ToString()
        {
            return "Nombre: " + nombre + " Edad: " + edad + " Sueldo: " + sueldo;
        }


        public double SueldoConPlus(double sueldo)
        {
            return sueldo + PLUS;
        }
    }




    public class Comercial : Empleados
    {
        private double comision;

        public Comercial(string nombre, int edad, double sueldo, double comision)
            : base (nombre, edad, sueldo)
        {
            this.comision = comision;
        }


        public void setComision(double comision)
        {
            this.comision = comision;
        }


        public double getComision()
        {
            return comision;
        }


        public void SueldoPlus_Comercial(Comercial comercial)
        {
            string nombre = comercial.getNombre();
            double sueldo = comercial.getSueldo();
            int edad = comercial.getEdad();
            double comision = comercial.getComision();

            if (edad > 30 && comision > 200)
            {
                sueldo = SueldoConPlus(sueldo);
                Console.WriteLine("Se le aplico un PLUS al comercial " + nombre + " contando con un sueldo total de: $" + sueldo);
            }
            else
                Console.WriteLine("El comercial " + nombre + " no cumple con los requisitos para el PLUS de su sueldo");
        }
    }



    public class Repartidor : Empleados
    {
        private string zona;


        public Repartidor(string nombre, int edad, double sueldo, string zona)
            : base(nombre, edad, sueldo)
        {
            this.zona = zona;
        }


        public void setZona(string zona)
        {
            this.zona = zona;
        }


        public string getZona()
        {
            return zona;
        }


        public void SueldoPlus_Repartidor(Repartidor repartidor)
        {

            string nombre = repartidor.getNombre();
            double sueldo = repartidor.getSueldo();
            int edad = repartidor.getEdad();
            string zona = repartidor.getZona();

            if (edad < 25 && zona.ToLower().Replace(" ", "") == "zona3")
            {
                sueldo = SueldoConPlus(sueldo);
                Console.WriteLine("Se le aplico un PLUS al repartidor " + nombre + " contando con un sueldo total de: $" + sueldo);
            }
            else
                Console.WriteLine("El repartidor " + nombre + " no cumple con los requisitos para el PLUS de su sueldo");
        }
    }
    
    
    
    
    
    public static void Main(string[] args)
    {
        Comercial comer1 = new Comercial("Juan", 42, 2500, 435);
        Repartidor repar1 = new Repartidor("Mengano", 19, 900, "Zona 3");
        Repartidor repar2 = new Repartidor("Mayra", 18, 1000, "Zona 4");

        Console.WriteLine("El comercial " + comer1.getNombre() + " tiene un sueldo de " + comer1.getSueldo());
        Console.WriteLine("El repartidor " + repar1.getNombre() + " tiene un sueldo de " + repar1.getSueldo());
        Console.WriteLine("El repartidor " + repar2.getNombre() + " tiene un sueldo de " + repar2.getSueldo() + Environment.NewLine);

        comer1.SueldoPlus_Comercial(comer1);
        repar1.SueldoPlus_Repartidor(repar1);
        repar2.SueldoPlus_Repartidor(repar2);

    }
}