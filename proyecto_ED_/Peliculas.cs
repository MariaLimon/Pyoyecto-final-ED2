using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_ED_
{
	public class Peliculas
	{
		public string Nombre { get; set; }
		public string Genero { get; set; }
		public string Duracion { get; set; }
		public string Year { get; set; }

		public Peliculas(string nombre, string genero, string duracion, string year)
		{
			Nombre = nombre;
			Genero = genero;
			Duracion = duracion;
			Year = year;
		}
	}
}
