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

			}
			else
			{
				//pilas
			}
		}
	}
}
