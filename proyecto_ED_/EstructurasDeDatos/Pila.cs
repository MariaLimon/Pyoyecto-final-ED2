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
				return "La pila está llena";
			}
			else
			{
				for (int i = _cima; i >= 0; i--)
				{
					listaPila[i + 1] = listaPila[i];
				}
				listaPila[0] = nuevaPeli;
				_cima++;
				return "La película se agregó al frente de la pila";
			}
		}
		public string InsertarFinalPila(Peliculas nuevaPeli)
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
		//public Peliculas EliminarFrentePila()
		//{
		//	if (PilaVacia())
		//	{
		//		MessageBox.Show("la pila esta vacia");
		//		return null;
		//	}
		//	else
		//	{ 
		//		//Peliculas auxiliar = listaPila[]; 
		//		//--;
		//		//MessageBox.Show("se elimino de la pila");
		//		//return auxiliar;
		//	}
		//}
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

		public Peliculas EliminarFrentePila()
		{
			if (PilaVacia())
			{
				MessageBox.Show("La pila está vacía");
				return null;
			}
			else
			{
				Peliculas auxiliar = listaPila[0];
				for (int i = 0; i < _cima; i++)
				{
					listaPila[i] = listaPila[i + 1];
				}
				_cima--;
				MessageBox.Show("Se eliminó de la pila");
				return auxiliar;
			}
		}

		//limpiar elementos de la pila: LimpiarPila
		//public bool Limpiar()
		//{
		//	if (PilaVacia())
		//	{
		//		return false;
		//	}
		//	else
		//	{
		//		while (!PilaVacia())
		//		{
		//			EliminarFrentePila();
		//		}
		//		return true;
		//	}
		//}

		// Imprimir los datos de la pila: ImprimirDatos
		public void ImprimirDatos(DataGridView dataGridView)
		{
			if (PilaVacia())
			{
				MessageBox.Show("La pila está vacía");
			}
			else
			{
				dataGridView.Rows.Clear();
				for (int i = 0; i < _cima + 1; i++)
				{
					Peliculas pelicula = listaPila[i];
					int fila = dataGridView.Rows.Add(pelicula.id, pelicula.Nombre, pelicula.Genero, pelicula.Duracion, pelicula.Year);
				}
			}
		}

		// Buscar los datos de la pila: BuscarPila
		public void BuscarPila(string nombre, DataGridView dataGridView)
		{
			int centinela = -1;
			if (PilaVacia())
			{
				MessageBox.Show("La pila está vacía");
			}
			else
			{
				for (int i = 0; i < _cima + 1; i++)
				{
					Peliculas pelicula = listaPila[i];
					if (pelicula.Nombre == nombre)
					{
						centinela = 1;
						int fila = dataGridView.Rows.Add(pelicula.id, pelicula.Nombre, pelicula.Genero, pelicula.Duracion, pelicula.Year);
						break;
					}
				}
				if (centinela == -1)
				{
					MessageBox.Show("el elemento no se encuentra en la pila");
				}
			}
		}



		//editar datos de la pila
		// Buscar los datos de la pila: BuscarPila
		public Peliculas EditarPila(string nombre)
		{
			int centinela = -1;
			if (PilaVacia())
			{
				MessageBox.Show("La pila está vacía");
				return null;
			}
			else
			{
				for (int i = 0; i < _cima + 1; i++)
				{
					Peliculas pelicula = listaPila[i];
					if (pelicula.Nombre == nombre)
					{
						centinela = 1;
						return pelicula;
						break;
					}
					return null;
				}
				if (centinela == -1)
				{
					MessageBox.Show("el elemento no se encuentra en la pila");
					return null;
				}
				return null;
			}
		}




		public void OrdenarDecendentePila()
		{
			if (PilaVacia())
			{
				MessageBox.Show("La pila está vacía");
			}
			else
			{
				for (int i = 0; i < _cima; i++)
				{
					for (int j = i + 1; j <= _cima; j++)
					{
						if (listaPila[i].Year < listaPila[j].Year)
						{
							// Intercambiar las películas si el año es menor
							Peliculas temp = listaPila[i];
							listaPila[i] = listaPila[j];
							listaPila[j] = temp;
						}
					}
				}
			}
		}

		public void OrdenarAscendentePila()
		{
			if (PilaVacia())
			{
				MessageBox.Show("La pila está vacía");
			}
			else
			{
				for (int i = 0; i < _cima; i++)
				{
					for (int j = i + 1; j <= _cima; j++)
					{
						if (listaPila[i].Year > listaPila[j].Year)
						{
							// Intercambiar las películas si el año es menor
							Peliculas temp = listaPila[i];
							listaPila[i] = listaPila[j];
							listaPila[j] = temp;
						}
					}
				}
			}
		}
	}

}
	
		

