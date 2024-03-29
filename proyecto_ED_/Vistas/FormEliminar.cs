﻿using proyecto_ED_.EstructurasDeDatos;
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
	public partial class FormEliminar : Form
	{
		private int origen;

		listaEnlazadaSimple lista;
		public FormEliminar(int origen)
		{
			InitializeComponent();
			this.origen = origen;
			
			if (origen == 1)
			{
				//colas
				buttonEliminarMedio.Visible = false;
				buttonEliminarCima.Visible = false;
				buttonEliminarTodoPia.Visible = false;
			}
			else if (origen == 2)
			{
				//matriz
				buttonEliminarCima.Visible = false;
				buttonEliminarTodoPia.Visible = false;
			}
			else if (origen == 3)
			{
				//listas
				buttonEliminarCima.Visible = false;
				buttonEliminarTodoPia.Visible = false;
				listaEnlazadaSimple lista = listaEnlazadaSimple.ObtenerInstancia();
				lista.ImprimirLista(dataGridView1);
			}
			else if (origen == 4)
			{
				//pilas

				Pila pila = Pila.ObtenerInstancia();
				pila.ImprimirDatos(dataGridView1, textBoxResultadoGuardar);
				buttonEliminarMedio.Visible = false;
				buttonEliminarFinal.Visible = false;
				buttonEliminarFrente.Visible = false;
				buttonEliminarCima.Visible = true;
				buttonEliminarTodoPia.Visible = true;

			}
			else
			{
				MessageBox.Show("Ocurrio un error al abrir el formulario D:");
			}
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
				lista.ImprimirLista(dataGridView1);
			}
			else if (origen == 4)
			{
				//pilas
				Pila pila = Pila.ObtenerInstancia();
				pila.EliminarFrentePila(textBoxResultadoGuardar);
				dataGridView1.Rows.Clear();
				pila.ImprimirDatos(dataGridView1, textBoxResultadoGuardar);
			}
			else
			{
				MessageBox.Show("Ocurrio un error al abrir el formulario D:");
			}
		}

		private void buttonEliminarMedio_Click(object sender, EventArgs e)
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

				lista.EliminarMedioLista();
				lista.ImprimirLista(dataGridView1);
			}
			else if (origen == 4)
			{
				//pilas
				Pila pila = Pila.ObtenerInstancia();

			}
			else
			{
				MessageBox.Show("Ocurrio un error al abrir el formulario D:");
			}
		}

		private void buttonEliminarFinal_Click(object sender, EventArgs e)
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

				lista.EliminarFinalLista();
				lista.ImprimirLista(dataGridView1);
			}
			else if (origen == 4)
			{
				//pilas
				Pila pila = Pila.ObtenerInstancia();
				pila.EliminarFinalPila(textBoxResultadoGuardar);
				dataGridView1.Rows.Clear();
				pila.ImprimirDatos(dataGridView1, textBoxResultadoGuardar);
			}
			else
			{
				MessageBox.Show("Ocurrio un error al abrir el formulario D:");
			}
		}

		private void buttonEliminarCima_Click(object sender, EventArgs e)
		{
			//pilas
			Pila pila = Pila.ObtenerInstancia();
			pila.EliminarFrentePila(textBoxResultadoGuardar);
			dataGridView1.Rows.Clear();
			pila.ImprimirDatos(dataGridView1, textBoxResultadoGuardar);
		}

		private void buttonEliminarTodoPia_Click(object sender, EventArgs e)
		{
			Pila pila = Pila.ObtenerInstancia();
			pila.EliminarTodoPila(textBoxResultadoGuardar);
			dataGridView1.Rows.Clear();
			pila.ImprimirDatos(dataGridView1, textBoxResultadoGuardar);
		}
	}
}
