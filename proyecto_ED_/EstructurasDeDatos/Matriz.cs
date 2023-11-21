using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_ED_.EstructurasDeDatos
{
    public class Matriz
    {

        private Peliculas[,] matrizPeliculas;

        public Matriz(int filas, int columnas)
        {
            matrizPeliculas = new Peliculas[filas, columnas];
        }

        public void AgregarPelicula(int fila, int columna, Peliculas pelicula)
        {
            if (fila < matrizPeliculas.GetLength(0) && columna < matrizPeliculas.GetLength(1))
            {
                matrizPeliculas[fila, columna] = pelicula;
            }
            else
            {
                // Manejar el caso cuando la posición está fuera de los límites de la matriz
            }
        }
    }
}
