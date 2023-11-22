using proyecto_ED_.EstructurasDeDatos;

namespace proyecto_ED_
{
	public partial class FormMostrar : Form
	{
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
