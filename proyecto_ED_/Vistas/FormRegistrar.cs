using proyecto_ED_.EstructurasDeDatos;
using proyecto_ED_.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_ED_
{
	public partial class FormRegistrar : Form
	{
		private int origen;

		Matriz matrizPelicula;

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



		//cerrar fromulario
		private void buttonCerarForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		int contadorGuardarFrente = 0;
		public Peliculas[] peliculas;

		//funcionalidad de los botones
		private void buttonGuardarFrente_Click(object sender, EventArgs e)
		{
			contadorGuardarFrente++;
			listaEnlazadaSimple lista = listaEnlazadaSimple.ObtenerInstancia();

			Peliculas pelicula = new Peliculas();
			{
				pelicula.Nombre = textBoxNombrePelicula.Text;
				pelicula.Genero = textBoxGeneroPelicula.Text;
				pelicula.Duracion = textBoxDuracionPelicula.Text;
				pelicula.Year = Convert.ToInt16(textBoxAño.Text);
			};


			Peliculas[] peliculaAgregada = new Peliculas[10];
			{
				peliculaAgregada[contadorGuardarFrente] = pelicula;
			}


			if (origen == 1)
			{
				//colas
			}
			else if (origen == 2)
			{
				//matriz
				matrizPelicula = new Matriz();
			}
			else if (origen == 3)
			{
				//listas

				peliculaAgregada[contadorGuardarFrente].id = contadorGuardarFrente;
				lista.InsertarFrenteLista(pelicula);


			}
			else
			{
				//pilas
			}


		}

		private void buttonGuardarMedio_Click(object sender, EventArgs e)
		{

			listaEnlazadaSimple lista = listaEnlazadaSimple.ObtenerInstancia();

			Peliculas pelicula = new Peliculas();
			{
				pelicula.Nombre = textBoxNombrePelicula.Text;
				pelicula.Genero = textBoxGeneroPelicula.Text;
				pelicula.Duracion = textBoxDuracionPelicula.Text;
				pelicula.Year = Convert.ToInt16(textBoxAño.Text);
			};

			Peliculas[] peliculaAgregada = new Peliculas[10];
			{
				peliculaAgregada[contadorGuardarFrente] = pelicula;
			}

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
				peliculaAgregada[contadorGuardarFrente].id = contadorGuardarFrente;
				lista.InsertarMedioLista(pelicula);
			}
			else
			{
				//pilas
			}
		}

		private void buttonGuardarFinalColas_Click(object sender, EventArgs e)
		{
			listaEnlazadaSimple lista = listaEnlazadaSimple.ObtenerInstancia();

			Peliculas pelicula = new Peliculas();
			{
				pelicula.Nombre = textBoxNombrePelicula.Text;
				pelicula.Genero = textBoxGeneroPelicula.Text;
				pelicula.Duracion = textBoxDuracionPelicula.Text;
				pelicula.Year = Convert.ToInt16(textBoxAño.Text);
			};

			Peliculas[] peliculaAgregada = new Peliculas[10];
			{
				peliculaAgregada[contadorGuardarFrente] = pelicula;
			}

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
				peliculaAgregada[contadorGuardarFrente].id = contadorGuardarFrente;
				lista.InsertarFinalLista(pelicula);
			}
			else
			{
				//pilas
			}
		}


	}
}
