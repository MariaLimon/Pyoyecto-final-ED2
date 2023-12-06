namespace proyecto_ED_
{
	partial class FormEliminar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panelGuardarColas = new Panel();
			textBoxResultadoGuardar = new TextBox();
			buttonEliminarMedio = new Button();
			buttonEliminarFinal = new Button();
			buttonEliminarFrente = new Button();
			buttonCerarForm = new Button();
			dataGridView1 = new DataGridView();
			Cid = new DataGridViewTextBoxColumn();
			Cnombre = new DataGridViewTextBoxColumn();
			Cgenero = new DataGridViewTextBoxColumn();
			Cduracion = new DataGridViewTextBoxColumn();
			Cyear = new DataGridViewTextBoxColumn();
			buttonEliminarNombrePila = new Button();
			panelGuardarColas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panelGuardarColas
			// 
			panelGuardarColas.BackColor = Color.FromArgb(135, 20, 31);
			panelGuardarColas.Controls.Add(buttonEliminarNombrePila);
			panelGuardarColas.Controls.Add(textBoxResultadoGuardar);
			panelGuardarColas.Controls.Add(buttonEliminarMedio);
			panelGuardarColas.Controls.Add(buttonEliminarFinal);
			panelGuardarColas.Controls.Add(buttonEliminarFrente);
			panelGuardarColas.Dock = DockStyle.Bottom;
			panelGuardarColas.Location = new Point(0, 408);
			panelGuardarColas.Margin = new Padding(3, 4, 3, 4);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(763, 288);
			panelGuardarColas.TabIndex = 14;
			// 
			// textBoxResultadoGuardar
			// 
			textBoxResultadoGuardar.BackColor = Color.FromArgb(135, 20, 31);
			textBoxResultadoGuardar.BorderStyle = BorderStyle.None;
			textBoxResultadoGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxResultadoGuardar.ForeColor = Color.White;
			textBoxResultadoGuardar.Location = new Point(253, 25);
			textBoxResultadoGuardar.Margin = new Padding(3, 4, 3, 4);
			textBoxResultadoGuardar.Name = "textBoxResultadoGuardar";
			textBoxResultadoGuardar.ReadOnly = true;
			textBoxResultadoGuardar.Size = new Size(261, 23);
			textBoxResultadoGuardar.TabIndex = 10;
			// 
			// buttonEliminarMedio
			// 
			buttonEliminarMedio.Location = new Point(311, 129);
			buttonEliminarMedio.Margin = new Padding(3, 4, 3, 4);
			buttonEliminarMedio.Name = "buttonEliminarMedio";
			buttonEliminarMedio.Size = new Size(168, 33);
			buttonEliminarMedio.TabIndex = 2;
			buttonEliminarMedio.Text = "Eliminar del medio";
			buttonEliminarMedio.UseVisualStyleBackColor = true;
			buttonEliminarMedio.Click += buttonEliminarMedio_Click;
			// 
			// buttonEliminarFinal
			// 
			buttonEliminarFinal.Location = new Point(544, 129);
			buttonEliminarFinal.Margin = new Padding(3, 4, 3, 4);
			buttonEliminarFinal.Name = "buttonEliminarFinal";
			buttonEliminarFinal.Size = new Size(142, 33);
			buttonEliminarFinal.TabIndex = 1;
			buttonEliminarFinal.Text = "Eliminar del final";
			buttonEliminarFinal.UseVisualStyleBackColor = true;
			buttonEliminarFinal.Click += buttonEliminarFinal_Click;
			// 
			// buttonEliminarFrente
			// 
			buttonEliminarFrente.Location = new Point(102, 129);
			buttonEliminarFrente.Margin = new Padding(3, 4, 3, 4);
			buttonEliminarFrente.Name = "buttonEliminarFrente";
			buttonEliminarFrente.Size = new Size(160, 33);
			buttonEliminarFrente.TabIndex = 0;
			buttonEliminarFrente.Text = "Eliminar del frente";
			buttonEliminarFrente.UseVisualStyleBackColor = true;
			buttonEliminarFrente.Click += buttonEliminarFrente_Click;
			// 
			// buttonCerarForm
			// 
			buttonCerarForm.BackColor = Color.FromArgb(151, 34, 20);
			buttonCerarForm.FlatAppearance.BorderSize = 0;
			buttonCerarForm.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 82, 124);
			buttonCerarForm.FlatStyle = FlatStyle.Flat;
			buttonCerarForm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			buttonCerarForm.ForeColor = SystemColors.ButtonFace;
			buttonCerarForm.Location = new Point(687, 16);
			buttonCerarForm.Margin = new Padding(3, 4, 3, 4);
			buttonCerarForm.Name = "buttonCerarForm";
			buttonCerarForm.Size = new Size(63, 33);
			buttonCerarForm.TabIndex = 15;
			buttonCerarForm.Text = "x";
			buttonCerarForm.UseVisualStyleBackColor = false;
			buttonCerarForm.Click += buttonCerarForm_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.Black;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cid, Cnombre, Cgenero, Cduracion, Cyear });
			dataGridView1.GridColor = Color.Black;
			dataGridView1.Location = new Point(54, 71);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(650, 295);
			dataGridView1.TabIndex = 17;
			// 
			// Cid
			// 
			Cid.HeaderText = "Id";
			Cid.MinimumWidth = 6;
			Cid.Name = "Cid";
			Cid.ReadOnly = true;
			Cid.Width = 125;
			// 
			// Cnombre
			// 
			Cnombre.HeaderText = "Nombre";
			Cnombre.MinimumWidth = 6;
			Cnombre.Name = "Cnombre";
			Cnombre.ReadOnly = true;
			Cnombre.Width = 125;
			// 
			// Cgenero
			// 
			Cgenero.HeaderText = "Genero";
			Cgenero.MinimumWidth = 6;
			Cgenero.Name = "Cgenero";
			Cgenero.ReadOnly = true;
			Cgenero.Width = 125;
			// 
			// Cduracion
			// 
			Cduracion.HeaderText = "Duración";
			Cduracion.MinimumWidth = 6;
			Cduracion.Name = "Cduracion";
			Cduracion.ReadOnly = true;
			Cduracion.Width = 125;
			// 
			// Cyear
			// 
			Cyear.HeaderText = "Año de lanzamiento";
			Cyear.MinimumWidth = 6;
			Cyear.Name = "Cyear";
			Cyear.ReadOnly = true;
			Cyear.Width = 125;
			// 
			// buttonEliminarNombrePila
			// 
			buttonEliminarNombrePila.Location = new Point(311, 129);
			buttonEliminarNombrePila.Margin = new Padding(3, 4, 3, 4);
			buttonEliminarNombrePila.Name = "buttonEliminarNombrePila";
			buttonEliminarNombrePila.Size = new Size(168, 33);
			buttonEliminarNombrePila.TabIndex = 11;
			buttonEliminarNombrePila.Text = "Eliminar por nombre";
			buttonEliminarNombrePila.UseVisualStyleBackColor = true;
			// 
			// FormEliminar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(763, 696);
			Controls.Add(dataGridView1);
			Controls.Add(buttonCerarForm);
			Controls.Add(panelGuardarColas);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormEliminar";
			Text = "FormEliminar";
			panelGuardarColas.ResumeLayout(false);
			panelGuardarColas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelGuardarColas;
		private Button buttonEliminarMedio;
		private Button buttonEliminarFinal;
		private Button buttonEliminarFrente;
		private Button buttonCerarForm;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Cid;
		private DataGridViewTextBoxColumn Cnombre;
		private DataGridViewTextBoxColumn Cgenero;
		private DataGridViewTextBoxColumn Cduracion;
		private DataGridViewTextBoxColumn Cyear;
		private TextBox textBoxResultadoGuardar;
		private Button buttonEliminarNombrePila;
	}
}