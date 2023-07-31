using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_5
{
    class Serie
    {
        string titulo;
        int n_temp = 3;
        bool entregado = false;
        string genero;
        string creador;

        public Serie() { }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }
        public Serie(string titulo, int n_temp, bool entregado, string genero, string creador)
        {
            this.titulo = titulo;
            this.n_temp = n_temp;
            this.genero = genero;
            this.creador = creador;
        }
        public void set_titulo()
        {
            this.titulo = titulo;
        }
        public void set_n_temp()
        {
            this.n_temp = n_temp;
        }
        public void set_genero()
        {
            this.genero = genero;
        }
        public void set_creador()
        {
            this.creador = creador;
        }
        public string get_titulo()
        {
            return titulo;
        }
        public int get_n_temp()
        {
            return n_temp;
        }
        public string get_genero()
        {
            return genero;
        }
        public string get_creador()
        {
            return creador;
        }
    }
    class Videojuego
    {
        string titulo;
        int h_estimadas = 10;
        bool entregado = false;
        string genero;
        string compañia;

        public Videojuego() { }

        public Videojuego(string titulo, int h_estimadas)
        {
            this.titulo = titulo;
            this.h_estimadas = h_estimadas;
        }
        public Videojuego(string titulo, int h_estimadas, string genero, string compañia)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.compañia = compañia;
            this.h_estimadas = h_estimadas;
        }
        public void set_titulo()
        {
            this.titulo = titulo;
        }
        public void set_h_e()
        {
            this.h_estimadas = h_estimadas;
        }
        public void set_genero()
        {
            this.genero = genero;
        }
        public void set_compañia()
        {
            this.compañia = compañia;
        }
        public string get_titulo()
        {
            return titulo;
        }
        public int get_h_e()
        {
            return h_estimadas;
        }
        public string get_genero()
        {
            return genero;
        }
        public string get_compañia()
        {
            return compañia;
        }
    public  

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
