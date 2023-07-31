internal class Program
{
    
    public class Revolver
    {
        private int pos_actual;
        private int pos_bala;

        public int NumAleatorio()
        {
            Random random = new Random();
            return random.Next(1, 6 + 1);
        }

        public Revolver()
        {
            pos_actual = NumAleatorio();
            pos_bala = NumAleatorio();
        }

        public bool Disparar()
        {
            if (pos_actual == pos_bala)
                return true;
            else
                siguienteBala();
                return false;
        }
        
        public void siguienteBala()
        {
            pos_actual++;
            if (pos_actual > 6)
                pos_actual = 1;
        }

        public string ToString()
        {
            return "Posicion del tambor: " + pos_actual + " | Posicion de la bala: " + pos_bala;
        }
    }

    public class Jugador {

        private int id;
        private string nombre;
        private bool vivo;

        public Jugador(int id)
        {
            this.id = id;
            this.nombre = "Jugador " + id;
            this.vivo = true;
        }

        public bool dispara(Revolver revolver)
        {
            Console.WriteLine(revolver.ToString() );
            Console.WriteLine("¡El " + nombre + " se dispara!");
            
            if (revolver.Disparar() == true)
            {
                Console.WriteLine(nombre + " murió...");
                this.vivo = false;
                return vivo;
            }
            else
                Console.WriteLine(nombre + " safó");
                return vivo;    
        }

        public bool EstaVivo()
        {
            return vivo;
        }
    }


    public class Juego
    {
        private Jugador[] jugadores;
        private Revolver revolver;

        
        public Juego(int cant_jugadores)
        {
            if (cant_jugadores > 6 || cant_jugadores < 1)
                cant_jugadores = 6;
            jugadores = new Jugador[cant_jugadores];
            pibes(jugadores);
            revolver = new Revolver();
            
        }


        public bool ronda()
        {
            bool intento;
            for (int i = 0; i < jugadores.Length; i++)
            {
                if (jugadores[i].EstaVivo())
                {
                    intento = jugadores[i].dispara(revolver);

                    if (intento == false)
                        return false;
                }
            }
            return true;
        }


        public void pibes(Jugador[] jugadores)
        {
            for(int i = 0; i < jugadores.Length; i++)
            {
                jugadores[i] = new Jugador(i+1);
            }
        }


        /*public void ronda()
        {
            for(int i = 0;i < jugadores.Length; i++)
            {
                bool viveza = jugadores[i].SigueVivo(revolver);
                if (!viveza)
                {
                    finJuego()  
                }
            }
        }*/


    }
    
    
    
    public static void Main(string[] args)
    {
        Console.WriteLine("¡Ruleta rusa!" + "\n¿Cuantos jugadores van a jugar?");
        int players = Int32.Parse(Console.ReadLine());
        Juego jogo = new Juego(players);
        
        bool seguirJugando = true; 

        do
        {
            seguirJugando = jogo.ronda();

        } while (seguirJugando);

         


    }
}