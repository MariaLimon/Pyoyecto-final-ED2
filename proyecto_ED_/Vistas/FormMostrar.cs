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
				lista.ImprimirLista(dataGridView1);
			}
			else if(origen == 4)
			{
				//pilas
				Pila pila = Pila.ObtenerInstancia();
				pila.ImprimirDatos(dataGridView1);
			}
			else
			{
				MessageBox.Show("hubo un error al intentar entrar al formulario");
			}
		}

		private void buttonCerarForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
	}
}
