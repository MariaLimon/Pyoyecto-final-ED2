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
			panelGuardarColas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panelGuardarColas
			// 
			panelGuardarColas.BackColor = Color.FromArgb(135, 20, 31);
			panelGuardarColas.Controls.Add(buttonEliminarMedio);
			panelGuardarColas.Controls.Add(buttonEliminarFinal);
			panelGuardarColas.Controls.Add(buttonEliminarFrente);
			panelGuardarColas.Dock = DockStyle.Bottom;
			panelGuardarColas.Location = new Point(0, 306);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(668, 216);
			panelGuardarColas.TabIndex = 14;
			// 
			// buttonEliminarMedio
			// 
			buttonEliminarMedio.Location = new Point(272, 97);
			buttonEliminarMedio.Name = "buttonEliminarMedio";
			buttonEliminarMedio.Size = new Size(147, 25);
			buttonEliminarMedio.TabIndex = 2;
			buttonEliminarMedio.Text = "Eliminar del medio";
			buttonEliminarMedio.UseVisualStyleBackColor = true;
			// 
			// buttonEliminarFinal
			// 
			buttonEliminarFinal.Location = new Point(476, 97);
			buttonEliminarFinal.Name = "buttonEliminarFinal";
			buttonEliminarFinal.Size = new Size(124, 25);
			buttonEliminarFinal.TabIndex = 1;
			buttonEliminarFinal.Text = "Eliminar del final";
			buttonEliminarFinal.UseVisualStyleBackColor = true;
			// 
			// buttonEliminarFrente
			// 
			buttonEliminarFrente.Location = new Point(89, 97);
			buttonEliminarFrente.Name = "buttonEliminarFrente";
			buttonEliminarFrente.Size = new Size(140, 25);
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
			buttonCerarForm.Location = new Point(601, 12);
			buttonCerarForm.Name = "buttonCerarForm";
			buttonCerarForm.Size = new Size(55, 25);
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
			dataGridView1.Location = new Point(47, 53);
			dataGridView1.Margin = new Padding(3, 2, 3, 2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(553, 221);
			dataGridView1.TabIndex = 17;
			// 
			// Cid
			// 
			Cid.HeaderText = "Id";
			Cid.Name = "Cid";
			Cid.ReadOnly = true;
			// 
			// Cnombre
			// 
			Cnombre.HeaderText = "Nombre";
			Cnombre.Name = "Cnombre";
			Cnombre.ReadOnly = true;
			// 
			// Cgenero
			// 
			Cgenero.HeaderText = "Genero";
			Cgenero.Name = "Cgenero";
			Cgenero.ReadOnly = true;
			// 
			// Cduracion
			// 
			Cduracion.HeaderText = "Duración";
			Cduracion.Name = "Cduracion";
			Cduracion.ReadOnly = true;
			// 
			// Cyear
			// 
			Cyear.HeaderText = "Año de lanzamiento";
			Cyear.Name = "Cyear";
			Cyear.ReadOnly = true;
			// 
			// FormEliminar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(668, 522);
			Controls.Add(dataGridView1);
			Controls.Add(buttonCerarForm);
			Controls.Add(panelGuardarColas);
			Name = "FormEliminar";
			Text = "FormEliminar";
			panelGuardarColas.ResumeLayout(false);
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
	}
}