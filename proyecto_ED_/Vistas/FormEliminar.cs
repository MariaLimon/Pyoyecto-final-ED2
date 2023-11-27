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
	public partial class FormEliminar : Form
	{
		private int origen;

		listaEnlazadaSimple lista;
		public FormEliminar(int origen)
		{
			InitializeComponent();
			this.origen = origen;
		}

		private void buttonCerarForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonEliminarFrente_Click(object sender, EventArgs e)
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
				lista.EliminarDelFrente();
				var peliculas = lista.ObtenerPeliculas();
				foreach (var pelicula in peliculas)
				{
					int fila = dataGridView1.Rows.Add();
					dataGridView1.Rows[fila].Cells["Cid"].Value = pelicula.id;
					dataGridView1.Rows[fila].Cells["Cnombre"].Value = pelicula.Nombre;
					dataGridView1.Rows[fila].Cells["Cgenero"].Value = pelicula.Genero;
					dataGridView1.Rows[fila].Cells["Cduracion"].Value = pelicula.Duracion;
					dataGridView1.Rows[fila].Cells["Cyear"].Value = pelicula.Year;
				}
				
			}
			else
			{
				//pilas
			}
		}
	}
}
