using proyecto_ED_.EstructurasDeDatos;
using proyecto_ED_.Modelo;


namespace proyecto_ED_
{
	public partial class FormMostrar : Form
	{
		Peliculas peliculaRecibida = new Peliculas();
		public FormMostrar(Peliculas peliculaMostrar)
		{
			InitializeComponent();
			peliculaRecibida = peliculaMostrar;
			/*
			peliculaRecibida.Nombre = peliculaMostrar.Nombre;
			peliculaRecibida.Genero = peliculaMostrar.Genero;
			peliculaRecibida.Duracion = peliculaMostrar.Duracion;
			peliculaRecibida.Year = peliculaMostrar.Year;}
			*/
		}

		private int origen;
		public FormMostrar(int origen)
		{
			InitializeComponent();
			this.origen = origen;
		}

		private void buttonCerarForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonMostrar_Click(object sender, EventArgs e)
		{
			int fila = dataGridView1.Rows.Add();
			if (peliculaRecibida.Nombre != null)
			{
				dataGridView1.Rows[fila].Cells["Cnombre"].Value = peliculaRecibida.Nombre;
				dataGridView1.Rows[fila].Cells["Cgenero"].Value = peliculaRecibida.Genero;
				dataGridView1.Rows[fila].Cells["Cduracion"].Value = peliculaRecibida.Duracion;
				dataGridView1.Rows[fila].Cells["Cyear"].Value = peliculaRecibida.Year;
			}
			else
			{
				textBoxMensajeMostrar.Text = "no hay datos para agregar";
			}


		}


	}
}
