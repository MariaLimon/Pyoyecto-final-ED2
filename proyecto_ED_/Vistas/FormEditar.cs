using proyecto_ED_.EstructurasDeDatos;
using proyecto_ED_.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_ED_.Vistas
{
	public partial class FormEditar : Form
	{

		private int origen;

		public FormEditar(int origen)
		{
			InitializeComponent();
			this.origen = origen;
		}

		private void buttonCerarForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonBuscar_Click(object sender, EventArgs e)
		{
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
				listaEnlazadaSimple lista = listaEnlazadaSimple.ObtenerInstancia();
				Peliculas peliculaEdita = lista.BuscarElementoEditar(textBoxNombrePelicula.Text);
				textBoxNombrePelicula.Text = peliculaEdita.Nombre;
				textBoxGeneroPelicula.Text = peliculaEdita.Genero;
				textBoxDuracionPelicula.Text = peliculaEdita.Duracion;
				textBoxAño.Text = Convert.ToString(peliculaEdita.Year);
			}
			else if (origen == 4)
			{
				//pilas
				Pila pila = Pila.ObtenerInstancia();
				Peliculas peliculaEdita = pila.EditarPila(textBoxNombrePelicula.Text);
				textBoxNombrePelicula.Text = peliculaEdita.Nombre;
				textBoxGeneroPelicula.Text = peliculaEdita.Genero;
				textBoxDuracionPelicula.Text = peliculaEdita.Duracion;
				textBoxAño.Text = Convert.ToString(peliculaEdita.Year);
			}
			else
			{
				MessageBox.Show("hubo un error al intentar entrar al formulario");
			}
		}
		private void buttonGuardarCambios_Click(object sender, EventArgs e)
		{
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
				listaEnlazadaSimple lista = listaEnlazadaSimple.ObtenerInstancia();
				Peliculas peliculaEdita = lista.BuscarElementoEditar(textBoxNombrePelicula.Text);
				if (peliculaEdita != null)
				{
					peliculaEdita.Nombre = textBoxNombrePelicula.Text;
					peliculaEdita.Genero = textBoxGeneroPelicula.Text;
					peliculaEdita.Duracion = textBoxDuracionPelicula.Text;
					peliculaEdita.Year = Convert.ToInt32(textBoxAño.Text);

					MessageBox.Show("Los datos de la película se han actualizado correctamente");

				}
				else
				{
					MessageBox.Show("La película no se encontró en la lista");
				}
			}
			else if (origen == 4)
			{
				//pilas
				Pila pila = Pila.ObtenerInstancia();
				Peliculas peliculaEdita = pila.EditarPila(textBoxNombrePelicula.Text);
				if (peliculaEdita != null)
				{
					peliculaEdita.Nombre = textBoxNombrePelicula.Text;
					peliculaEdita.Genero = textBoxGeneroPelicula.Text;
					peliculaEdita.Duracion = textBoxDuracionPelicula.Text;
					peliculaEdita.Year = Convert.ToInt32(textBoxAño.Text);

					MessageBox.Show("Los datos de la película se han actualizado correctamente");

				}
				else
				{
					MessageBox.Show("La película no se encontró en la lista");
				}
			}
			else
			{
				MessageBox.Show("hubo un error al intentar entrar al formulario");
			}
		}
	}
}
