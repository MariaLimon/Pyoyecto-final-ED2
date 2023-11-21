using proyecto_ED_.EstructurasDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_ED_
{
	public partial class FormRegistrar : Form
	{
		private int origen;
		

		public FormRegistrar(int origen)
		{
			InitializeComponent();
			this.origen = origen;
		}

		//para solo aceptar numeros en la duracion de la pelicula
		private void textBoxDuracionPelicula_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
			{
				MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
		}

		private void buttonCerarForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		Peliculas[,] matrizPeliculas = new Peliculas[4, 10];
		public listaEnlazadaSimple listaPeliculas = new listaEnlazadaSimple();

		private void buttonGuardarFrente_Click(object sender, EventArgs e)
		{
			string nombre = textBoxNombrePelicula.Text;
			string genero = textBoxGeneroPelicula.Text;
			string duracion = textBoxDuracionPelicula.Text;
			string year = textBoxAño.Text;
			if (origen == 1)
			{
				//colas
			}
			else if (origen == 2)
			{
				//matriz
				matrizPeliculas[0, 0] = new Peliculas(nombre, genero, duracion, year);
				MessageBox.Show(matrizPeliculas[0, 0].Nombre);
			}
			else if (origen == 3)
			{
				//listas
				int longitudVieja = listaPeliculas.Longitud();
				listaPeliculas.InsertarFrenteLista(nombre, genero, duracion, year);

				//saber si se guardo en la lista
				if (listaPeliculas.ListaVacia != null || listaPeliculas.Longitud() > longitudVieja)
					textBoxResultadoGuardar.Text = "Se guardo en la lista";
				else
					textBoxResultadoGuardar.Text = "No se guardo";
			}
			else
			{
				//pilas
			}
		}

		private void buttonGuardarMedio_Click(object sender, EventArgs e)
		{
			string nombre = textBoxNombrePelicula.Text;
			string genero = textBoxGeneroPelicula.Text;
			string duracion = textBoxDuracionPelicula.Text;
			string year = textBoxAño.Text;
			if (origen == 1)
			{
				//colas
			}
			else if (origen == 2)
			{
				//matriz
			}
			else if (origen == 3)
			{
				//listas
				int longitudVieja = listaPeliculas.Longitud();
				listaPeliculas.InsertarMedioLista(nombre, genero, duracion, year);

				if (listaPeliculas.ListaVacia != null || listaPeliculas.Longitud() > longitudVieja)
					textBoxResultadoGuardar.Text = "Se guardo en la lista";
				else
					textBoxResultadoGuardar.Text = "No se guardo";
			}
			else
			{
				//pilas
			}
		}


	}
}
