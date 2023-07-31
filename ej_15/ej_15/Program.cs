internal class Program
{
    public class Bebida
    {
        private string identificador;
        private double litros;
        private double precio;
        private string marca;

        public Bebida(string identificador, double litros, double precio, string marca)
        {
            this.identificador = identificador;
            this.litros = litros;
            this.precio = precio;
            this.marca = marca;
        }


        public void setIdentificador(string identificador)
        {
            this.identificador= identificador;
        }

        public void setLitros(double litros)
        {
            this.litros = litros;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }


        public string getIdentificador()
        {
            return identificador;
        }

        public double getLitros()
        {
            return litros;
        }

        public double getPrecio()
        {
            return precio;
        }

        public string getMarca()
        {
            return marca;
        }

        public override string ToString()
        {
            return "Identificador: " + identificador + " | Litros: " + litros + " | Precio: " + precio + " | Marca: " + marca;
        }
    }

 

    public class AguaMineral : Bebida
    {
        private string origen;

        public AguaMineral(string identificador, double litros, double precio, string marca, string origen)
            : base(identificador, litros, precio, marca)
        {
            this.origen = origen;
        }

        public void setOrigen(string origen)
        {
            this.origen = origen;
        }


        public string getOrigen()
        {
            return origen;
        }

        public override string ToString()
        {
            return base.ToString() + " | Origen: " + origen;
        }
    }

 

    public class BebidaAzucarada : Bebida
    {
        private double azucar;
        private bool promo;

        public BebidaAzucarada(string identificador, double litros, double precio, string marca, double azucar, bool promo)
            : base(identificador, litros, precio, marca)
        {
            this.azucar = azucar;
            this.promo = promo;
        }

        public void setAzucar(double azucar)
        {
            this.azucar = azucar;
        }

        public void setPromo(bool promo)
        {
            this.promo = promo;
        }

        public bool getPromo()
        {
            return promo;
        }

        public double getAzucar()
        {
            return azucar;
        }


        public override string ToString()
        {
            string promocion = promo ? "Sí" : "No";
            return base.ToString() + " | Porcentaje de azúcar: " + azucar + " | ¿Tiene promoción?: " + promo;
        }
    }

 
    public class Almacen
    {
        private Bebida[,] estanterias;
        private int filas;
        private int columnas;

        public Almacen(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            estanterias = new Bebida[filas, columnas];
        }

        public double CalcularPrecioTodasLasBebidas()
        {
            double precioTotal = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (estanterias[i, j] != null)
                    {
                        precioTotal += estanterias[i, j].getPrecio();
                    }
                }
            }

            return precioTotal;
        }

        public double CalcularPrecioMarcaBebida(string marca)
        {
            double precioTotal = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (estanterias[i, j] != null && estanterias[i, j].getMarca() == marca)
                    {
                        precioTotal += estanterias[i, j].getPrecio();
                    }
                }
            }

            return precioTotal;
        }

        public double CalcularPrecioEstanteria(int columna)
        {
            if (columna < 0 || columna >= columnas)
            {
                Console.WriteLine("Columna inválida.");
            }

            double precioTotal = 0;

            for (int i = 0; i < filas; i++)
            {
                if (estanterias[i, columna] != null)
                {
                    precioTotal += estanterias[i, columna].getPrecio();
                }
            }

            return precioTotal;
        }

        public void AgregarProducto(Bebida bebida)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (estanterias[i, j] == null)
                    {
                        estanterias[i, j] = bebida;
                        return;
                    }
                }
            }

            Console.WriteLine("El almacén está lleno :/.");
        }

        public void EliminarProducto(string identificador)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (estanterias[i, j] != null && estanterias[i, j].getIdentificador() == identificador)
                    {
                        estanterias[i, j] = null;
                        return;
                    }
                }
            }

            Console.WriteLine("No se encontró un producto con ese identificador.");
        }

        public void MostrarInformacion()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (estanterias[i, j] != null)
                    {
                        Console.WriteLine(estanterias[i, j].ToString());
                    }
                }
            }
        }
    }

 
        public static void Main(string[] ags)
        {
            Almacen almacen = new Almacen(3, 3);

            almacen.AgregarProducto(new AguaMineral("AAA1", 1.5, 400, "Kin", "Argentina"));
            almacen.AgregarProducto(new BebidaAzucarada("AAA2", 0.5, 150, "Coca-Cola", 10, true));
            almacen.AgregarProducto(new BebidaAzucarada("AAA3", 2, 500, "Fanta", 15, false));
            almacen.AgregarProducto(new AguaMineral("AAA4", 0.75, 300, "Glaciar", "Argentina"));
            almacen.AgregarProducto(new BebidaAzucarada("AAA5", 1, 350, "Pepsi", 12.5, true));

            double precioTotalBebidas = almacen.CalcularPrecioTodasLasBebidas();
            Console.WriteLine("Precio total de todas las bebidas del almacén: " + precioTotalBebidas);

            double precioTotalCocaCola = almacen.CalcularPrecioMarcaBebida("Coca-Cola");
            Console.WriteLine("Precio total de bebidas marca Coca-Cola: " + precioTotalCocaCola);

            double precioEstanteria2 = almacen.CalcularPrecioEstanteria(2);
            Console.WriteLine("Precio total de las bebidas en la estantería 2: " + precioEstanteria2);

            almacen.MostrarInformacion();

            almacen.EliminarProducto("AAA4");
            almacen.MostrarInformacion();

            Console.ReadLine();
        }
    }
