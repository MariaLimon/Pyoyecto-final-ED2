using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_ED_.Modelo;

namespace proyecto_ED_.EstructurasDeDatos
{
	public class Matriz
	{
		int indice = 5;
		public bool MatrizLlena(Peliculas[] matrizPeliculas)
		{ 
			
			if (matrizPeliculas[5] == null)
				return false;
			
			return true;
		}

		public bool MatrizVacia(Peliculas[] matrizPeliculas)
		{
			if (matrizPeliculas[0] != null)
				return false;

			return true;
		}

		

		public void OrdenarDecendente()
		{

		}

		public void OrdenarAscendente()
		{

		}


		public void BuscarPorId(int id, Peliculas[] matrizPeliculas)
		{
			int objetivo = id;
			bool encontrado = false;

			for (int i = 0; i < indice; i++)
			{
				if (matrizPeliculas[i].id == objetivo)
				{
					MessageBox.Show($"El {objetivo} está en la posición [{i}] de la matriz");
					encontrado = true;
					break;
				}

				if (encontrado)
				{
					break;
				}
			}

			if (!encontrado)
			{
				MessageBox.Show($"El {objetivo} no está en la matriz");
			}
		}

	}
}
