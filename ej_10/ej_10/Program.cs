using static Program;

internal class Program
{
    public class Cartas
    {
        private int numero;
        private string palo;

        public Cartas(int numero, string palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

        public int getNumero()
        {
            return numero;
        }

        public string getPalo()
        {
            return palo;
        }

        public string ToString()
        {
            return numero + " de " + palo;
        }
    } 
    

    public class Baraja
    {
        private List<Cartas> cartas;
        private List<Cartas> mazo;

        public Baraja() 
        {
            this.cartas = new List<Cartas>();
            this.mazo = new List<Cartas>();
            CrearBaraja();
        }


        public void CrearBaraja()
        {
            String[] palo = { "Oro", "Espada", "Basto", "Copas" };
            for (int i = 0; i < palo.Length; i++)
            {
                for (int j = 1; j <=12; j++)
                {
                    if(j != 8 && j != 9)
                    {
                        cartas.Add(new Cartas(j, palo[i]));
                    }
                }
            }

        }


        public void barajar()
        {
            
            Random random = new Random();
            if(CartasDisponibles() == 0)
                Console.WriteLine("Ya no hay mas cartas");
            else
            {
                for (int i = 0; i < cartas.Count; i++)
                {
                    Cartas carta = cartas[i];
                    int pos_aleat = random.Next(0, (cartas.Count - 1) + 1);
                    cartas[i] = cartas[pos_aleat];
                    cartas[pos_aleat] = carta;
                }
                Console.WriteLine("Las cartas se mezclaron");
            }
            
        }


        public int CartasDisponibles()
        {
            return cartas.Count;
        }


        public int CartasFaltantes()
        {
            return mazo.Count;
        }


        public void darCartas(int pedido)
        {

            if (pedido > CartasDisponibles())
                Console.WriteLine("No hay tantas cartas flaquito, solo podes retirar hasta: " + CartasDisponibles() + " cartas");
            
            else if (pedido == CartasDisponibles())
                Console.WriteLine("No te puedo dar todas hermano");

            else
            {
                for (int i = pedido; i > 0; i--)
                {
                    mazo.Add(cartas[0]);
                    cartas.RemoveAt(0);
                }
                Console.WriteLine("Estas son tus cartas: ");
                foreach (var cartaspedidas in mazo)
                {
                    Console.WriteLine(cartaspedidas.getNumero() + " de " + cartaspedidas.getPalo());
                }
            }
        }
        /*public List<Cartas> darCartas(int pedido)
        {
            List<Cartas> cartaspedidas = new List<Cartas>();
            
            if ( pedido > CartasDisponibles() ) 
            { 
                Console.WriteLine("No hay tantas cartas flaquito, solo podes retirar hasta: " + CartasDisponibles() + " cartas");
                return cartaspedidas;
            }
            else
            {
                for (int i = pedido; i > 0; i--)
                {
                    mazo.Add(cartas[0]);
                    cartaspedidas.Add(cartas[0]);
                    cartas.RemoveAt(0);
                }
                return cartaspedidas;
            }
        */


        public void MostrarMazo ()
        {
            if( mazo.Count == 0 )
                Console.WriteLine("No se saco ninguna carta");
            else
            {
                Console.WriteLine("Las cartas del mazo son:");
                foreach (var cartasmazo in mazo) {
                    Console.WriteLine("El " + cartasmazo.getNumero() + " de " + cartasmazo.getPalo());
 
                }
            }
        }


        public void MostrarBaraja()
        {
            
            if (CartasDisponibles() == 0)
                Console.WriteLine("Ya no hay mas cartas");
            else
            {
                Console.WriteLine("Las cartas de la baraja son:");
                
                foreach (var cartasbaraja in cartas)
                    Console.WriteLine("El " + cartasbaraja.getNumero() + " de " + cartasbaraja.getPalo());
            }
        }
    }


    public static void Main(string[] args)
    {
        Baraja baraja = new Baraja();

        bool juego = true;
        Console.WriteLine("¡Baraja de cartas!\n¿Que queres hacer?");
        Console.WriteLine("| 1 | Barajar " + "\n| 2 | Repartir " + "\n| 3 | Mostrar las cartas del mazo " + "\n| 4 | Mostrar las cartas de la baraja " + "\n| 5 | Saber cuantas cartas quedan " + "\n| 6 | Saber cuantas faltan " + "\n| 7 | Salir ");
        int op;
        
            while (juego)
            {
                op = int.Parse(Console.ReadLine());
                if (op < 1 || op > 7)
                    Console.WriteLine("Tenes que seleccionar una opción válida");
                else
                {
                    switch (op)
                    {
                    case 1:
                        baraja.barajar();
                        break;

                    case 2:
                        Console.WriteLine("Cuantas cartas queres?");
                        int pedido = int.Parse(Console.ReadLine());
                        baraja.darCartas(pedido);
                        
                        break;

                    case 3:
                        baraja.MostrarMazo();
                        break;

                    case 4:
                        baraja.MostrarBaraja();
                        break;

                    case 5:
                        Console.WriteLine(baraja.CartasDisponibles());
                        break;
                    case 6:
                        Console.WriteLine(baraja.CartasFaltantes());
                        break;
                    case 7:
                        Console.WriteLine("Nos vemos gil");
                        juego = false;
                        break;
                    }
                }
            }
    }
        
}
