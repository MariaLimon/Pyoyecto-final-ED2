using proyecto_ED_.EstructurasDeDatos;
using proyecto_ED_.Modelo;
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

		listaEnlazadaSimple lista;

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


		//funcionalidad de los botones
		private void buttonGuardarFrente_Click(object sender, EventArgs e)
		{
			/*
			string nombre = textBoxNombrePelicula.Text;
			string genero = textBoxGeneroPelicula.Text;
			string duracion = textBoxDuracionPelicula.Text;
			string year = textBoxAño.Text;

			Peliculas peliculaAgergada = new Peliculas(nombre,genero,duracion,year);
			*/
			//peliculaAgergada.Nombre = textBoxNombrePelicula;

			Peliculas peliculaAgregada = new Peliculas(textBoxNombrePelicula.Text, textBoxGeneroPelicula.Text,textBoxDuracionPelicula.Text,textBoxAño.Text);

			peliculaAgregada.Nombre = textBoxNombrePelicula.Text;
			peliculaAgregada.Genero = textBoxGeneroPelicula.Text;
			peliculaAgregada.Duracion = textBoxDuracionPelicula.Text;
			peliculaAgregada.Year = textBoxAño.Text;
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
				lista = new listaEnlazadaSimple();
				//lista.InsertarFrenteLista(peliculaAgergada);
				lista.InsertarFrenteLista(peliculaAgregada);
				MessageBox.Show("la pelicula fue agregada en la lista");
				
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
				
			}
			else
			{
				//pilas
			}
		}


	}
}
