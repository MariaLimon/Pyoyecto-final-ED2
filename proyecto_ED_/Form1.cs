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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			personalisarSubPaneles();
		}
		private void personalisarSubPaneles()
		{
			panelColasSubmenu.Visible = false;
			panelListasSubmenu.Visible = false;
			panelMatricesSubmenu.Visible = false;
			panelPilasSubmenu.Visible = false;

		}
		private void OcultarSubmenu()
		{
			if (panelColasSubmenu.Visible == true)
				panelColasSubmenu.Visible = false;
			if (panelListasSubmenu.Visible == true)
				panelListasSubmenu.Visible = false;
			if (panelMatricesSubmenu.Visible == true)
				panelMatricesSubmenu.Visible = false;
			if (panelPilasSubmenu.Visible == true)
				panelPilasSubmenu.Visible = false;
		}

		public void MostrarSubmenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				OcultarSubmenu();
				subMenu.Visible = true;
			}
			else
			{
				subMenu.Visible = false;
			}
		}





		#region COLAS
		private void buttonColas_Click(object sender, EventArgs e)
		{
			MostrarSubmenu(panelColasSubmenu);
		}

		private void buttonGuardarColas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormRegistrar(1));
			OcultarSubmenu();
		}

		private void buttonEliminarColas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormEliminar(1));
			OcultarSubmenu();
		}

		private void buttonEditarColas_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
		}

		private void buttonMostarColas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormMostrar(1));
			OcultarSubmenu();
		}

		private void buttonOrdenarColas_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
		}

		private void buttonBuscarColas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormBuscar(1));
			OcultarSubmenu();
		}
		#endregion

		#region MATRICES
		private void buttonMatrices_Click(object sender, EventArgs e)
		{
			MostrarSubmenu(panelMatricesSubmenu);
		}

		private void buttonGuardarMatrices_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormRegistrar(2));
			OcultarSubmenu();
		}

		private void buttonEliminarMatrices_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormEliminar(2));
			OcultarSubmenu();
		}

		private void buttonEditarMatrices_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
		}

		private void buttonMostrarMatrices_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormMostrar(2));
			OcultarSubmenu();
		}

		private void buttonOrdenarMatrices_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
		}

		private void buttonBuscarMatrices_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormMostrar(2));
			OcultarSubmenu();
		}
		#endregion

		#region LISTAS
		private void button8_Click(object sender, EventArgs e)
		{
			MostrarSubmenu(panelListasSubmenu);
		}

		private void buttonGuardarListas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormRegistrar(3));
			OcultarSubmenu();
		}

		private void buttonEliminarListas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormEliminar(3));
			OcultarSubmenu();
		}

		private void buttonEditarListas_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
		}

		private void buttonMostrarListas_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
			abrilFormulario(new FormMostrar(3));

		}

		private void buttonOrdenarListas_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
		}

		private void buttonBuscarListas_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
			abrilFormulario(new FormBuscar(3));
		}
		#endregion

		#region PILAS
		private void buttonPilas_Click(object sender, EventArgs e)
		{
			MostrarSubmenu(panelPilasSubmenu);
		}

		private void buttonGuardarPilas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormRegistrar(4));
			OcultarSubmenu();
		}

		private void buttonEliminarPilas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormEliminar(4));
			OcultarSubmenu();
		}

		private void buttonEditarPilas_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
		}

		private void buttonMostrarPilas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormMostrar(4));
			OcultarSubmenu();
		}

		private void buttonOrdenarPilas_Click(object sender, EventArgs e)
		{
			OcultarSubmenu();
		}

		private void buttonBuscarPilas_Click(object sender, EventArgs e)
		{
			abrilFormulario(new FormBuscar(4));
			OcultarSubmenu();
		}
		#endregion


		private Form formularioActual = null;

		private void abrilFormulario(Form formulario)
		{
			if (formularioActual != null)
			{
				formularioActual.Close();
			}
			formularioActual = formulario;
			formulario.TopLevel = false;
			formulario.FormBorderStyle = FormBorderStyle.None;
			formulario.Dock = DockStyle.Fill;
			panelContenedor.Controls.Add(formulario);
			panelContenedor.Tag = formulario;
			formulario.BringToFront();
			formulario.Show();
		}


	}
}
