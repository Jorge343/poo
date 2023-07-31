using static Program;

internal class Program
{
    
    public class Productos
    {

        private string nombre;
        private double precio;

        
        public Productos(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        
        public string getNombre()
        {
            return nombre;
        }

        
        public double getPrecio()
        {
            return precio;
        }

        
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }


        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public string ToString()
        {
            return "Producto: " + nombre + " | Precio: " + precio;
        }


        public virtual double Calcular(int cantidad)
        {
            return precio * cantidad;
        }

    }


    public class Perecedero : Productos 
    {

        private int diasCaducar;


        public Perecedero(string nombre, double precio, int diasCaducar) : base (nombre, precio)
        {
            this.diasCaducar = diasCaducar;
        }


        public void setDiasCaducar(int diasCaducar)
        {
            this.diasCaducar = diasCaducar;
        }

        public int getDiasCaducar()
        {
            return diasCaducar;
        }

        public string ToString()
        {
            return base.ToString() + " | Dias restantes para caducar: " + diasCaducar;
        }


        public override double Calcular(int cantidad)
        {
            switch(diasCaducar)
            {
                case 1:
                    return base.Calcular(cantidad) / 4;
                case 2:
                    return base.Calcular(cantidad) / 3;
                case 3:
                    return base.Calcular(cantidad) / 2;
            }
            
            return base.Calcular(cantidad);
        }



    }


    public class NoPerecedero : Productos
    {
        private string tipo;


        public NoPerecedero(string nombre, double precio, string tipo) : base(nombre, precio)
        {
            this.tipo = tipo;
        }


        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }


        public string getTipo()
        {
            return tipo;
        }

        public string ToString()
        {
            return base.ToString() + " | Tipo: " + tipo;
        }
    }
    
    
    private static void Main(string[] args)
    {
        List<Productos> productos = new List<Productos> { new Productos("Galletitas", 500), new Perecedero("Pan", 1500, 1), new NoPerecedero("Cafe", 750, "Bebida") };
        
        foreach (Productos p in productos)
        {
            Console.WriteLine(p.ToString());
            Console.WriteLine("El precio por 5 productos de estos es de: " + p.Calcular(5) + Environment.NewLine);
        }

    }
}