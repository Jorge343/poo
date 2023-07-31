internal class Program
{
    public class Contacto
    {
        private string nombre;
        private int telefono;


        public Contacto (string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        //Creo otro constructor para usarlo en el main con el metodo de existeContacto()
        public Contacto(string nombre)
        {
            this.nombre = nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre() 
        {
        return nombre;
        }

        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public int getTelefono()
        {
            return telefono;
        }

        public string ToString()
        {
            return "Nombre: " + nombre + " | Telefono: " + telefono;
        }
    }


    public class Agenda 
    {
        List<Contacto> agenda = new List<Contacto>();
        private int tamaño;


        public Agenda (int tamaño) 
        {
            agenda = new List<Contacto>();
            this.tamaño = tamaño;
        }


        public void setTamaño(int tamaño)
        {
            this.tamaño = tamaño;
        }

        public void Tamaño_Agenda(int tamaño)
        {
            Console.WriteLine("¿Cuantos contactos quiere dentro de su agenda?");
            tamaño = Int32.Parse(Console.ReadLine());
            if (tamaño <= 0)
                tamaño = 10;
            setTamaño(tamaño);
        }

        
        public bool existeContacto(Contacto c)
        {
            return agenda.Contains(c);
        }

        
        public void añadirContacto(Contacto c)
        {
            if (agendaLlena(tamaño))
                Console.WriteLine("La agenda se encuentra llena");
            else if (existeContacto(c))
                Console.WriteLine("Este contacto ya existe dentro de la agenda");
            else
                agenda.Add(c);
        }


        public void listarContactos()
        {
            if (agenda.Count == 0)
                Console.WriteLine("No hay contactos dentro de la agenda");
            else
            {
                Console.WriteLine("Contactos:");
                foreach(Contacto c in agenda)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }


        public void buscaContacto(String nombre)
        {
            foreach (Contacto c in agenda)
            {
                if(c.getNombre().Trim() == nombre.Trim())
                    Console.Write(c.getTelefono());
            }
        }


        public void eliminarContacto(Contacto c)
        {
            if(existeContacto(c))
            {
                agenda.Remove(c);
                Console.WriteLine("Se ha eliminado el contacto.");
            }
            else
                Console.WriteLine("El contacto que ha especificado no existe.");
        }


        public bool agendaLlena(int tamaño)
        {
            if (huecosLibres() == 0)
                return true;
            
            else return false;
        }


        public int huecosLibres()
        {
            int huecos = tamaño - agenda.Count;
            return huecos;
        }

    }
    
    
    
    
    public static void Main(string[] args)
    {

        int telefono;
        string nombre;
        int op;
        bool menu = true;
        int tamaño = 10;
        
        Agenda agenda = new Agenda(tamaño);
        agenda.Tamaño_Agenda(tamaño);

        Console.WriteLine("\n------- Menú -------");
        Console.WriteLine("1. Añadir contacto");
        Console.WriteLine("2. Comprobar si un contacto existe");
        Console.WriteLine("3. Listar contactos");
        Console.WriteLine("4. Buscar telefono de un contacto");
        Console.WriteLine("5. Eliminar contacto");
        Console.WriteLine("6. Contactos disponibles");
        Console.WriteLine("7. Verificar si la agenda esta llena");
        Console.WriteLine("8. Modificar el tamaño de la agenda");
        Console.WriteLine("0. Salir");
        Console.Write("\nElija una opción: ");
        


        while (menu)
        {
            op = Int32.Parse(Console.ReadLine());
            switch (op)
            {
                
                case 1:
                    Console.WriteLine("Nombre:");
                    nombre = Console.ReadLine();
                    
                    Console.WriteLine("Telefono:");
                    telefono = Int32.Parse(Console.ReadLine());
                    
                    Contacto contacto1 = new Contacto(nombre, telefono);
                    agenda.añadirContacto(contacto1);
                    
                    break;
                
                case 2:
                    Console.WriteLine("Nombre:");
                    nombre = Console.ReadLine();
                    
                    Console.WriteLine("Telefono:");
                    telefono = Int32.Parse(Console.ReadLine());
                    
                    Contacto contacto2 = new Contacto(nombre, telefono);
                    if (agenda.existeContacto(contacto2))
                        Console.WriteLine("Sí existe");
                    else 
                        Console.WriteLine("No existe :/");
                    
                    break;
                
                case 3:
                    agenda.listarContactos();
                    
                    break;
                
                case 4:
                    Console.WriteLine("Nombre:");
                    nombre = Console.ReadLine();
                    
                    agenda.buscaContacto(nombre);
                    Console.WriteLine(Environment.NewLine);

                    break;
                
                case 5:
                    Console.WriteLine("Nombre:");
                    nombre = Console.ReadLine();
                    
                    Console.WriteLine("Telefono:");
                    telefono = Int32.Parse(Console.ReadLine());

                    Contacto contacto5 = new Contacto(nombre, telefono);
                    agenda.eliminarContacto(contacto5);

                    break;
                
                case 6:
                    Console.WriteLine("Cantidad disponible: " + agenda.huecosLibres());
                    
                    break;
                
                case 7:
                    if (!(agenda.agendaLlena(tamaño)))
                        Console.WriteLine("La agenda todavia tiene huecos disponibles");
                    else
                        Console.WriteLine("La agenda esta llena");
                    
                    break;
                
                case 8:
                    agenda.Tamaño_Agenda(tamaño);
                    
                    break;
                
                case 0:
                    Console.WriteLine("Chau chau");
                    menu = false;
                    
                    break;
                
                default:
                    Console.WriteLine("Debe introducir una opcion valida (numero)");
                    
                    break;
            }
        }


    }
}