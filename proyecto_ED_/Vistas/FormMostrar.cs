using proyecto_ED_.EstructurasDeDatos;
using proyecto_ED_.Modelo;


namespace proyecto_ED_
{
	public partial class FormMostrar : Form
	{
		Peliculas[] peliculaRecibida = new Peliculas[10];
		listaEnlazadaSimple listaAgrgada = listaEnlazadaSimple.ObtenerInstancia();
		public FormMostrar(Peliculas[] peliculaMostrar = null)
		{
			InitializeComponent();
			peliculaRecibida = peliculaMostrar;


		}

		public FormMostrar(listaEnlazadaSimple listam)
		{
			InitializeComponent();
			listam = listaEnlazadaSimple.ObtenerInstancia();
		}

		private int origen;
		public FormMostrar(int origen)
		{
			InitializeComponent();
			this.origen = origen;
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

		private void buttonCerarForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
	}
}
