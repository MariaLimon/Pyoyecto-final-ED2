using proyecto_ED_.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_ED_.EstructurasDeDatos
{
	public class Pila
	{
		private int _cima;
		private Peliculas[] listaPila;
		private int longitudPila = 10;

		private static Pila instancia;

		public static Pila ObtenerInstancia()
		{
			if (instancia == null)
			{
				instancia = new Pila();
			}
			return instancia;
		}


		// Constructor
		public Pila()
		{
			_cima = -1;
			listaPila = new Peliculas[longitudPila];
		}

		//la pila esta vacia: PilaVacia
		public bool PilaVacia()
		{
			return _cima == -1 ? true : false;
			/*
            if (_cima == -1)
            {
                return true;
            }
			return false;
            /*otra forma de hacerlo es con operador ternario solo se puede tener dos opciones
                return _cima == -1 ? false : true;
             */
		}

		public bool PilaLlena()
		{
			return _cima == longitudPila - 1 ? true : false;
		}

		//tamaño de la pila: TamañoPila
		public int TamañoPila()
		{
			return longitudPila;
		}

		//cantidad de elementos de la pila: CantidadElementosPila
		public int CantidadElementosPila()
		{
			return _cima + 1;
		}

		//leer el valor de la cima: ValorCima
		//public int ValorCima()
		//{
		//	return listaPila[_cima];
		//}

		// Insertar elementos en la pila: Push
		public string InsertarFrentePila(Peliculas nuevaPeli)
		{
			if (PilaLlena())
			{
				return "la pila esta llena";
			}
			else
			{
				_cima++;
				listaPila[_cima] = nuevaPeli;
				return "la pelicula se agrego a la pila";
			}
		}

		// Extraer un elemento de la pila: Pop
		public Peliculas EliminarFrentePila()
		{
			if (PilaVacia())
			{
				MessageBox.Show("la pila esta vacia");
				return null;
			}
			else
			{ 
				//Peliculas auxiliar = listaPila[]; 
				//--;
				//MessageBox.Show("se elimino de la pila");
				//return auxiliar;
			}
		}
		public Peliculas EliminarFinalPila()
		{
			if (PilaVacia())
			{
				MessageBox.Show("la pila esta vacia");
				return null;
			}
			else
			{
				Peliculas auxiliar = listaPila[_cima];
				_cima--;
				MessageBox.Show("se elimino de la pila");
				return auxiliar;
			}
		}

		//limpiar elementos de la pila: LimpiarPila
		public bool Limpiar()
		{
			if (PilaVacia())
			{
				return false;
			}
			else
			{
				while (!PilaVacia())
				{
					EliminarFrentePila();
				}
				return true;
			}
		}

		// Imprimir los datos de la pila: ImprimirDatos
		public void ImprimirDatos(DataGridView dataGridView)
		{
			if (PilaVacia())
			{
				MessageBox.Show( "La pila está vacía");
			}
			else
			{
				for (int i = 0; i < _cima + 1; i++)
				{
					Peliculas pelicula = listaPila[i];
					int fila = dataGridView.Rows.Add(pelicula.id, pelicula.Nombre, pelicula.Genero, pelicula.Duracion, pelicula.Year);
				}
			}
		}
		
		
		/*
		public void ImprimirDatos()
		{
			if (PilaVacia())
			{
				Console.WriteLine("la pila esta vacia");
			}
			else
			{
				int contador = 0;
				while (_cima+1 != contador)
				{

					Console.WriteLine($"{listaPila[contador]}->");
					contador++;
				}
				Console.WriteLine("->null");
			}
		}
		*/
	}
}

