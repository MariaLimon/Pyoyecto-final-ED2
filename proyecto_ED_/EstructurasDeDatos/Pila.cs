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
		public void InsertarFrentePila(Peliculas nuevaPeli, TextBox mensaje)
		{
			
			if (PilaLlena())
			{
				mensaje.Text = "La pila está llena";
				
			}
			else
			{
				for (int i = _cima; i >= 0; i--)
				{
					listaPila[i + 1] = listaPila[i];
				}
				listaPila[0] = nuevaPeli;
				_cima++;
				mensaje.Text = "La película se agregó al frente de la pila";
			}
		}
		
		public void InsertarFinalPila(Peliculas nuevaPeli, TextBox mensaje)
		{
			if (PilaLlena())
			{
				mensaje.Text = "la pila esta llena";
			}
			else
			{
				_cima++;
				listaPila[_cima] = nuevaPeli;

				mensaje.Text = "la pelicula se agrego al final de la pila";
			}
		}


		public Peliculas EliminarFinalPila(TextBox mensaje)
		{
			if (PilaVacia())
			{
				mensaje.Text="la pila esta vacia";
				return null;
			}
			else
			{
				Peliculas auxiliar = listaPila[_cima];
				while(_cima > 0)
				{
					_cima--;
				}
				
				mensaje.Text = "se elimino del final de la pila";
				return auxiliar;
			}
		}
		public Peliculas EliminarTodoPila(TextBox mensaje)
		{
			if (PilaVacia())
			{
				mensaje.Text = "la pila esta vacia";
				return null;
			}
			else
			{
				Peliculas auxiliar = listaPila[_cima];
				while (_cima > -1)
				{
					_cima--;
				}

				mensaje.Text = "se elimino del final de la pila";
				return auxiliar;
			}
		}

		public Peliculas EliminarFrentePila(TextBox mensaje)
		{
			if (PilaVacia())
			{
				mensaje.Text = "La pila está vacía";
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
				mensaje.Text = "Se eliminó del frente de la pila";
				return auxiliar;
			}
		}


		// Imprimir los datos de la pila: ImprimirDatos
		public void ImprimirDatos(DataGridView dataGridView, TextBox mensaje)
		{
			if (PilaVacia())
			{
				mensaje.Text = "La pila está vacía";
			}
			else
			{
				dataGridView.Rows.Clear();
				for (int i = 0; i < _cima + 1; i++)
				{
					Peliculas pelicula = listaPila[i];
					if (listaPila[i] != null)
					{

						dataGridView.Rows.Add(pelicula.id, pelicula.Nombre, pelicula.Genero, pelicula.Duracion, pelicula.Year);
					}
					else
					{
						MessageBox.Show("algo salio mal con una pelicula");
					}
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
						dataGridView.Rows.Add(pelicula.id, pelicula.Nombre, pelicula.Genero, pelicula.Duracion, pelicula.Year);
						break;
					}
				}
				if (centinela == -1)
				{
					MessageBox.Show("el elemento no se encuentra en la pila");
				}
			}
		}



		//editar datos de la pila: EditarPila
		/*
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
				for (int i = _cima; i >= 0; i--)
				{
					listaPila[i + 1] = listaPila[i];
				}
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
		*/


		// Método para editar un elemento en la pila
		/*
		public void EditarElementoEnPila(int elementoBuscado, int nuevoValor)
		{
			Pila pilaAuxiliar = new Pila(); // Pila auxiliar para mantener temporalmente los elementos
			Pila pila = Pila.ObtenerInstancia();
			// Desapilar elementos de la pila original a la pila auxiliar hasta encontrar el elemento deseado
			while (pila.Count > 0 && pila.Peek() != elementoBuscado)
			{
				pilaAuxiliar.InsertarFrentePila(pila.EliminarFrentePila());
			}

			// Si se encontró el elemento en la pila original
			if (pila.Count > 0)
			{
				pila.Pop(); // Eliminar el elemento antiguo
				pila.Push(nuevoValor); // Agregar el nuevo elemento editado a la pila original
			}
			else
			{
				Console.WriteLine("El elemento no se encuentra en la pila");
			}

			// Volver a apilar los elementos desde la pila auxiliar a la pila original
			while (pilaAuxiliar.Count > 0)
			{
				pila.Push(pilaAuxiliar.Pop());
			}
		}

		// ... otros métodos de la clase Pila ...
	*/



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
	
		

