using System.Drawing;

internal class Program
{

    public class Electrodomestico
    {

        private double precioBase;
        private string color;
        private char consumo;
        private double peso;

        private const string ColorPorDefecto = "blanco";
        private const char ConsumoEnergeticoPorDefecto = 'F';
        private const double PrecioBasePorDefecto = 100;
        private const double PesoPorDefecto = 5;


        
        public Electrodomestico()
        {
            color = ColorPorDefecto;
            consumo = ConsumoEnergeticoPorDefecto;
            precioBase = PrecioBasePorDefecto;
            peso = PesoPorDefecto;
        }

        public Electrodomestico(double precioBase, double peso)
        {
            color = ColorPorDefecto;
            consumo = ConsumoEnergeticoPorDefecto;
            this.precioBase = precioBase;
            this.peso = peso;
        }

        public Electrodomestico(double precio, string color, char consumoEnergetico, double peso)
        {
            color = comprobarColor(color);
            consumo = comprobarConsumoEnergetico(consumoEnergetico);
            precioBase = precio;
            peso = peso;
        }

        public void setPrecioBase(double precioBase)
        {
            this.precioBase = precioBase;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setConsumo(char consumo)
        {
            this.consumo = consumo;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }


        public double getPrecioBase()
        {
            return precioBase;
        }

        public string getColor()
        {
            return color;
        }

        public char getConsumo()
        {
            return consumo;
        }

        public double getPeso()
        {
            return peso;
        }



        private char comprobarConsumoEnergetico(char letra)
        {

            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };
            letra = char.ToUpper(letra);

            if (Array.Exists(letras, letrita => letrita == letra))
            {
                return letra;
            }
            else
            {
                return ConsumoEnergeticoPorDefecto;
            }
        }


        private string comprobarColor(string color)
        {

            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
            color = color.ToLower();

            if (Array.Exists(colores, colorcito => colorcito == color))
            {
                return color;
            }
            else
            {
                return ColorPorDefecto;
            }
        }



        public virtual double precioFinal()
        {
            double precioFinal = precioBase;

            switch (consumo)
            {
                case 'A':
                    precioFinal += 100;
                    break;
                case 'B':
                    precioFinal += 80;
                    break;
                case 'C':
                    precioFinal += 60;
                    break;
                case 'D':
                    precioFinal += 50;
                    break;
                case 'E':
                    precioFinal += 30;
                    break;
                case 'F':
                    precioFinal += 10;
                    break;
            }

            if (peso >= 0 && peso < 20)
                precioFinal += 10;
            else if (peso >= 20 && peso < 50)
                precioFinal += 50;
            else if (peso >= 50 && peso < 80)
                precioFinal += 80;
            else if (peso >= 80)
                precioFinal += 100;

            return precioFinal;
        }
    }

    public class Lavadora : Electrodomestico
    {

        private double carga;

        private const double CargaPorDefecto = 5;



        public Lavadora() : base()
        {
            carga = CargaPorDefecto;
        }

        public Lavadora(double precio, double peso) : base(precio, peso)
        {
            carga = CargaPorDefecto;
        }

        public Lavadora(double precio, string color, char consumoEnergetico, double peso, double carga)
            : base(precio, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }


        public void setCarga(double carga)
        {
            this.carga = carga;
        }


        public double getCarga()
        {
            return carga;
        }

        public override double precioFinal()
        {
            double precioFinal = base.precioFinal();

            if (carga > 30)
            {
                precioFinal += 50;
            }

            return precioFinal;
        }
    }

    public class Television : Electrodomestico
    {

        private int resolucion;
        private bool sintonizadorTDT;

        private const int ResolucionPorDefecto = 20;
        private const bool SintonizadorTDTPorDefecto = false;


        public Television() : base()
        {
            resolucion = ResolucionPorDefecto;
            sintonizadorTDT = SintonizadorTDTPorDefecto;
        }

        public Television(double precio, double peso) : base(precio, peso)
        {
            resolucion = ResolucionPorDefecto;
            sintonizadorTDT = SintonizadorTDTPorDefecto;
        }

        public Television(double precio, string color, char consumoEnergetico, double peso, int resolucion, bool sintonizadorTDT)
            : base(precio, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public void setResolucion(int resolucion)
        {
            this.resolucion = resolucion;
        }

        public void setSintonizadorTDT(bool sintonizadorTDT)
        {
            this.sintonizadorTDT = sintonizadorTDT;
        }


        public int getResolucion()
        {
            return resolucion;
        }


        public bool getSintonizadorTDT()
        {
            return sintonizadorTDT;
        }

   

        public override double precioFinal()
        {
            double precioFinal = base.precioFinal();

            if (resolucion > 40)
            {
                precioFinal *= 1.3;
            }

            if (sintonizadorTDT)
            {
                precioFinal += 50;
            }

            return precioFinal;
        }
    }



    public static void Main(string[] args)
    {
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            electrodomesticos[0] = new Lavadora(250, "blanco", 'A', 30, 7);
            electrodomesticos[1] = new Television(400, "negro", 'B', 20, 42, true);
            electrodomesticos[2] = new Lavadora(300, "rojo", 'F', 35, 8);
            electrodomesticos[3] = new Television(500, "azul", 'C', 25, 32, false);
            electrodomesticos[4] = new Electrodomestico(150, "gris", 'E', 15);
            electrodomesticos[5] = new Television(600, "negro", 'D', 50, 55, true);
            electrodomesticos[6] = new Lavadora(280, "blanco", 'A', 30, 6);
            electrodomesticos[7] = new Television(450, "rojo", 'F', 40, 48, false);
            electrodomesticos[8] = new Lavadora(320, "azul", 'B', 32, 7);
            electrodomesticos[9] = new Television(550, "gris", 'C', 28, 40, true);

            double precioElectrodomesticos = 0;
            double precioLavadoras = 0;
            double precioTelevisores = 0;

            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {
                if (electrodomestico is Lavadora lavadora)
                {
                    precioLavadoras += lavadora.precioFinal();
                }
                else if (electrodomestico is Television television)
                {
                    precioTelevisores += television.precioFinal();
                }

                precioElectrodomesticos += electrodomestico.precioFinal();
            }

            Console.WriteLine("Precio total Electrodomesticos: " + precioElectrodomesticos);
            Console.WriteLine("Precio total Lavadoras: " + precioLavadoras );
            Console.WriteLine("Precio total Televisores: " + precioTelevisores);

            Console.ReadLine();
        }
    }

