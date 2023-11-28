using proyecto_ED_.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyecto_ED_.EstructurasDeDatos
{
    public class listaEnlazadaSimple
    {
        private static listaEnlazadaSimple instancia;

		public static listaEnlazadaSimple ObtenerInstancia()
		{
			if (instancia == null)
			{
				instancia = new listaEnlazadaSimple();
			}
			return instancia;
		}

		Nodo primero;
        Nodo ultimo;

        //lista vacia
        public listaEnlazadaSimple()
        {
            primero = ultimo = null;
        }

        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            return false;

            /*otra forma de hacerlo es con operador ternario solo se puede tener dos opciones
                return primero == null ? false : true;
             */
        }

		public int Longitud()
		{
			int contador = 0;
			if (ListaVacia())
			{
				return contador;
			}
			else
			{
				Nodo actual = primero;
				if (actual.getSiguiente() == null)
				{
					return ++contador;
				}
				else
				{
					while (actual.getSiguiente() != null)
					{
						contador++;
						actual = actual.getSiguiente();
					}
					return contador + 1;
				}
			}
		}


		public IEnumerable<Peliculas> ObtenerPeliculas()
		{
			Nodo actual = primero;
			while (actual != null)
			{
				yield return actual.getDatos();
				actual = actual.getSiguiente();
			}
		}

		public void ImprimirLista()
        {
            if (ListaVacia())
            {
                MessageBox.Show("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    MessageBox.Show($"{actual.getDatos()}");
                    
                    actual = actual.getSiguiente();
                }
                MessageBox.Show("->null");//enviar a un mendajebox
            }
        }



        //buscar un elemento especifico en la lista
        public void BuscarElemento(string elementoBuscado)
        {
            int centinela = -1;
            //Nodo elemento = elementoBuscado;
            if (ListaVacia())
            {
                MessageBox.Show("La lista esta vacia");
            }
            else
            {
                //Console.WriteLine("dame el numero que buscas");
                Nodo actual = primero;
                while (actual != null)
                {
                    if (actual.getDatos().Nombre == elementoBuscado)
                    {
                        centinela = 1;
						MessageBox.Show("el elemento se encuentra en la lista");
                        break;
                    }
                    else
                    {
                        actual = actual.getSiguiente();
                    }
                }
                if (centinela == -1)
                {
					    MessageBox.Show("el elemento NO encuentra en la lista");
                }
            }
        }

		//buscar y mostrar su informacion para ser editada
		public Peliculas BuscarElementoEditar(string elementoBuscado)
        { 
			//Nodo elemento = elementoBuscado;
			if (ListaVacia())
			{
				MessageBox.Show("La lista esta vacia");
                return null;
			}
			else
			{
				//Console.WriteLine("dame el numero que buscas");
				Nodo actual = primero;
				while (actual != null)
				{
					if (actual.getDatos().Nombre == elementoBuscado)
					{
						MessageBox.Show("el elemento se encuentra en la lista");
                        return actual.getDatos();
					}
					else
					{
						actual = actual.getSiguiente();
					}
				}
				
					MessageBox.Show("el elemento NO encuentra en la lista");
                    return null;
				
			}
		}

		//mostrar la posicion de un elemento
		public void PosicionElemento(Peliculas elementoBuscado)
        {
            //Nodo elemento = elementoBuscado;
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                int centinela = -1;
                int contador = 0;
                Nodo actual = primero;
                while (actual != null)
                {
                    if (actual.getDatos() == elementoBuscado)
                    {
                        centinela = 0;
                        Console.WriteLine($"el elemento se encuentra en la posicion {contador} de la lista");
                        break;
                    }
                    else
                    {
                        actual = actual.getSiguiente();
                        contador++;
                    }
                }
                if (centinela == -1)
                {
                    Console.WriteLine("el elemento NO se encuentra en la lista");
                }
            }
        }

        //insertar un numero al frente de la lista
        public void InsertarFrenteLista(Peliculas nuevaPeli)
        {
            /*los estados de la lista vacia, un elemento y llena*/
            if (ListaVacia())
            {
                primero = ultimo = new Nodo(nuevaPeli);
				MessageBox.Show("La pelicula fue agregada en la lista");

			}
			else
            {
                primero = new Nodo(nuevaPeli,primero);
				MessageBox.Show("La pelicula fue agregada en la lista");

			}
		}
        //insertar en el medio de la lista
        public void InsertarMedioLista(Peliculas nuevaPeli)
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
                primero = ultimo = new Nodo(nuevaPeli);
            }
            else
            {
                int logitud = Longitud();
                Nodo actual = primero;
                int iterador = 1;
                Nodo anterior = null;
                while (actual.getSiguiente() != null && iterador < logitud / 2)
                {
                    iterador++;
                    actual = actual.getSiguiente();

                }
                anterior = actual;
                Nodo nuevo = new Nodo(nuevaPeli, actual.getSiguiente());
                MessageBox.Show("la pelicula se agrego a la lista");
                anterior.setSiguiente(nuevo);
            }
        }

		public void InsertarFinalLista(Peliculas nuevaPeli)
		{
			if (ListaVacia())
			{
				primero = ultimo = new Nodo(nuevaPeli);
				MessageBox.Show("Pelicula agregada con existo");

			}
			else
			{
				ultimo = ultimo.Siguiente = new Nodo(nuevaPeli);
				MessageBox.Show("Pelicula agregada con existo");
			}
		}
		public Peliculas EliminarDelFrente()
		{
			if (ListaVacia())
			{
				return null;
			}

			Peliculas eliminarElemento = primero.getDatos(); // recupera los datos

			// restablece las referencias primero y ultimo si solo hay un elemento en la lista
			if (primero == ultimo)
			{
				primero = ultimo = null;
			}
			else
			{
				primero = primero.getSiguiente();
			}

			return eliminarElemento; // devuelve los datos eliminados
		}

        

	}

}
