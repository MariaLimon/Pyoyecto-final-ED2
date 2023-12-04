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
	public partial class FormBuscar : Form
	{
		private int origen;
		public FormBuscar(int origen)
		{
			InitializeComponent();
			this.origen = origen;
		}

		//cerrar formulario
		private void buttonCerarForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		//funcionalidad botones
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
				lista.BuscarElemento(textBoxNombrePelicula.Text, dataGridView1);

			}
			else if (origen == 4)
			{
				//pilas
				Pila pila = Pila.ObtenerInstancia();
				pila.BuscarPila(textBoxNombrePelicula.Text, dataGridView1);
			}
			else
			{
				MessageBox.Show("hubo un error al intentar entrar al formulario");
			}
			textBoxNombrePelicula.Clear();
		}


	}
}
