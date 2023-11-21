using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_ED_.EstructurasDeDatos
{
    public class Nodo
    {
        private string _nombre;
        private string _genero;
        private string _duracion;
        private string _year;
        private Nodo _siguiente;
        //sobrecarga de metodo
        public Nodo(string nombre, string genero, string duracion, string year)
        {

            _nombre = nombre;
            _genero = genero;
            _duracion = duracion;
            _year = year;
            _siguiente = null;
        }
        //con esto podemos agregar en medio de la lista si queremos
                    /*los argumentos son llamados firmas */
        public Nodo(string nombre, string genero, string duracion, string year, Nodo siguiente)
        {
            _nombre = nombre;
            _genero = genero;
            _duracion = duracion;
            _year = year;
            _siguiente = siguiente;
        }

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public string Genero
		{
			get { return _genero; }
			set { _genero = value; }
		}
        public string Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }

        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }
		public Nodo Siguiente
		{
			get { return _siguiente; }
			set { _siguiente = value; }
		}
		
        public string getDatos()
        {
            return _nombre;
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
        public int datos { get; }
        public Nodo siguiente { get; set; }
        */
	}
}
