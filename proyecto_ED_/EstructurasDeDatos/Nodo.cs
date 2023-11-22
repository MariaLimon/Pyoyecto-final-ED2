using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_ED_.Modelo;

namespace proyecto_ED_.EstructurasDeDatos
{

    public class Nodo
    {
        private Peliculas _pelicula;
        private Nodo _siguiente;

        //sobrecarga de metodo
        public Nodo(Peliculas pelicula)
        {

            _pelicula=pelicula;
            _siguiente = null;
        }
        //con esto podemos agregar en medio de la lista si queremos
                    /*los argumentos son llamados firmas */
        public Nodo(Peliculas pelicula, Nodo siguiente)
        {
            _pelicula = pelicula;
            _siguiente = siguiente;
        }

		
		public Nodo Siguiente
		{
			get { return _siguiente; }
			set { _siguiente = value; }
		}
		
        public Peliculas getDatos()
        {
            return _pelicula;
        }
        public void setDatos(Peliculas pelicula)
        {
            _pelicula = pelicula;
        }
        public Nodo getSiguiente()
        {
            return _siguiente;
        }
        
        public void setSiguiente(Nodo siguiente)
        {
            _siguiente = siguiente;
        }
        /*forma corta
        public Peliculas pelicula { get; }
        public Nodo siguiente { get; set; }
        */
	}
}
