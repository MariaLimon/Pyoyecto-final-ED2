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
        private static Matriz instancia;

        public static Matriz ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Matriz();
            }
            return instancia;
        }

		public bool MatrizLlena(Peliculas[] matrizPeliculas)
		{ 
			
			if (matrizPeliculas[matrizPeliculas.Length-1] == null)
				return false;
			
			return true;
		}

            public bool MatrizVacia(Peliculas[] matrizPeliculas)
			{
				if (matrizPeliculas[0] != null)
					return false;

				return true;
			}



		public void OrdenarDecendente(Peliculas[] matrizPeliculas)
		{

			// Implementación de la ordenación descendente usando el método de burbuja
			int n = matrizPeliculas.Length;

			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - 1 - i; j++)
				{
					// Comparar los años de las películas y swap si es necesario
					if (matrizPeliculas[j].Year < matrizPeliculas[j + 1].Year)
					{
						Peliculas temp = matrizPeliculas[j];
						matrizPeliculas[j] = matrizPeliculas[j + 1];
						matrizPeliculas[j + 1] = temp;
					}
				}
			}
		}
		public void OrdenarAscendente(Peliculas[] matrizPeliculas)
		{
			// Implementación de la ordenación descendente usando el método de burbuja
			int n = matrizPeliculas.Length;

			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - 1 - i; j++)
				{
					// Comparar los años de las películas y swap si es necesario
					if (matrizPeliculas[j].Year > matrizPeliculas[j + 1].Year)
					{
						Peliculas temp = matrizPeliculas[j];
						matrizPeliculas[j] = matrizPeliculas[j + 1];
						matrizPeliculas[j + 1] = temp;
					}
				}
			}
		}


		public void BuscarPorNombre(string nombre ,Peliculas[] matrizPeliculas)
		{
            int n = matrizPeliculas.Length;
            string nombreObjetivo = nombre;
			int centinela = -1;
			int posicion = 0;

			for (int i = 0; i < n; i++)
			{
				if (matrizPeliculas[i].Nombre == nombreObjetivo)
				{
					posicion = i + 1;
					break;
				}
			}

			if (centinela != -1)
			{
                MessageBox.Show($"El {nombreObjetivo} está en la posición [{posicion}] de la matriz");
            }
			else
			{
                MessageBox.Show($"El {nombreObjetivo} no está en la matriz");
            }
		}

        public void InsertarFrenteMatriz(Peliculas[] matrizPeliculas, Peliculas peliNueva)
        {
            //Peliculas actual = matrizPeliculas[0];

            if (MatrizLlena(matrizPeliculas))
            {
                MessageBox.Show("La matriz esta llena no se puede incertar una nueva pelicula");
            }
            else if (MatrizVacia(matrizPeliculas))
            {
                matrizPeliculas[0] = peliNueva;
                MessageBox.Show("La pelicula se agrego en la primera pocicion");
            }
            else
            {

                int primerEspacioVacio = 0;
                while (matrizPeliculas[primerEspacioVacio] != null)
                {
                    primerEspacioVacio++;
                }

                // Desplaza todos los elementos hacia la derecha a partir del último elemento no nulo
                for (int i = primerEspacioVacio - 1; i >= 0; i--)
                {
                    matrizPeliculas[i + 1] = matrizPeliculas[i];
                }

                // Ahora puedes colocar el nuevo elemento en el primer espacio vacío
                matrizPeliculas[0] = peliNueva;
            }
        }
        public void incertarfinal(Peliculas[] matrizPeliculas, Peliculas peliNueva)
        {
            if (MatrizLlena(matrizPeliculas))
            {
                MessageBox.Show("La matriz esta llena no se puede incertar una nueva pelicula");
            }
            else
            {
                int cont = 0;
                while (matrizPeliculas[cont] != null)
                {
                    cont++;
                }
                matrizPeliculas[cont] = peliNueva;
            }
        }
    }
}
