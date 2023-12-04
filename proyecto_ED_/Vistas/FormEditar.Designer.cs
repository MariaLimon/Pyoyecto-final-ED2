namespace proyecto_ED_.Vistas
{
	partial class FormEditar
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
			buttonCerarForm = new Button();
			textBoxAño = new TextBox();
			labelAño = new Label();
			textBoxNombrePelicula = new TextBox();
			textBoxGeneroPelicula = new TextBox();
			textBoxDuracionPelicula = new TextBox();
			labelDuracion = new Label();
			labelGenero = new Label();
			labelNombre = new Label();
			panelGuardarColas = new Panel();
			textBoxResultadoGuardar = new TextBox();
			buttonGuardarCambios = new Button();
			buttonBuscar = new Button();
			panelGuardarColas.SuspendLayout();
			SuspendLayout();
			// 
			// buttonCerarForm
			// 
			buttonCerarForm.Anchor = AnchorStyles.None;
			buttonCerarForm.BackColor = Color.FromArgb(151, 34, 20);
			buttonCerarForm.FlatAppearance.BorderSize = 0;
			buttonCerarForm.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 82, 124);
			buttonCerarForm.FlatStyle = FlatStyle.Flat;
			buttonCerarForm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			buttonCerarForm.ForeColor = SystemColors.ButtonFace;
			buttonCerarForm.Location = new Point(601, 12);
			buttonCerarForm.Name = "buttonCerarForm";
			buttonCerarForm.Size = new Size(55, 25);
			buttonCerarForm.TabIndex = 13;
			buttonCerarForm.Text = "x";
			buttonCerarForm.UseVisualStyleBackColor = false;
			buttonCerarForm.Click += buttonCerarForm_Click;
			// 
			// textBoxAño
			// 
			textBoxAño.BackColor = Color.FromArgb(135, 20, 30);
			textBoxAño.BorderStyle = BorderStyle.None;
			textBoxAño.ForeColor = Color.White;
			textBoxAño.Location = new Point(129, 248);
			textBoxAño.MaxLength = 4;
			textBoxAño.Name = "textBoxAño";
			textBoxAño.Size = new Size(134, 16);
			textBoxAño.TabIndex = 24;
			// 
			// labelAño
			// 
			labelAño.AutoSize = true;
			labelAño.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelAño.ForeColor = SystemColors.ButtonFace;
			labelAño.Location = new Point(129, 226);
			labelAño.Name = "labelAño";
			labelAño.Size = new Size(134, 19);
			labelAño.TabIndex = 23;
			labelAño.Text = "Año de lanzamiento:";
			// 
			// textBoxNombrePelicula
			// 
			textBoxNombrePelicula.BackColor = Color.FromArgb(135, 20, 31);
			textBoxNombrePelicula.BorderStyle = BorderStyle.None;
			textBoxNombrePelicula.ForeColor = Color.White;
			textBoxNombrePelicula.Location = new Point(129, 94);
			textBoxNombrePelicula.Name = "textBoxNombrePelicula";
			textBoxNombrePelicula.Size = new Size(134, 16);
			textBoxNombrePelicula.TabIndex = 21;
			// 
			// textBoxGeneroPelicula
			// 
			textBoxGeneroPelicula.BackColor = Color.FromArgb(135, 20, 31);
			textBoxGeneroPelicula.BorderStyle = BorderStyle.None;
			textBoxGeneroPelicula.ForeColor = Color.White;
			textBoxGeneroPelicula.Location = new Point(129, 146);
			textBoxGeneroPelicula.Name = "textBoxGeneroPelicula";
			textBoxGeneroPelicula.Size = new Size(134, 16);
			textBoxGeneroPelicula.TabIndex = 20;
			// 
			// textBoxDuracionPelicula
			// 
			textBoxDuracionPelicula.BackColor = Color.FromArgb(135, 20, 30);
			textBoxDuracionPelicula.BorderStyle = BorderStyle.None;
			textBoxDuracionPelicula.ForeColor = Color.White;
			textBoxDuracionPelicula.Location = new Point(129, 199);
			textBoxDuracionPelicula.MaxLength = 3;
			textBoxDuracionPelicula.Name = "textBoxDuracionPelicula";
			textBoxDuracionPelicula.PlaceholderText = "duración en minutos";
			textBoxDuracionPelicula.Size = new Size(134, 16);
			textBoxDuracionPelicula.TabIndex = 19;
			// 
			// labelDuracion
			// 
			labelDuracion.AutoSize = true;
			labelDuracion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelDuracion.ForeColor = SystemColors.ButtonFace;
			labelDuracion.Location = new Point(129, 177);
			labelDuracion.Name = "labelDuracion";
			labelDuracion.Size = new Size(67, 19);
			labelDuracion.TabIndex = 18;
			labelDuracion.Text = "Duración:";
			// 
			// labelGenero
			// 
			labelGenero.AutoSize = true;
			labelGenero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelGenero.ForeColor = SystemColors.ButtonFace;
			labelGenero.Location = new Point(129, 124);
			labelGenero.Name = "labelGenero";
			labelGenero.Size = new Size(57, 19);
			labelGenero.TabIndex = 17;
			labelGenero.Text = "Genero;";
			// 
			// labelNombre
			// 
			labelNombre.AutoSize = true;
			labelNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelNombre.ForeColor = SystemColors.ButtonFace;
			labelNombre.Location = new Point(129, 74);
			labelNombre.Name = "labelNombre";
			labelNombre.Size = new Size(60, 17);
			labelNombre.TabIndex = 16;
			labelNombre.Text = "Nombre:";
			// 
			// panelGuardarColas
			// 
			panelGuardarColas.BackColor = Color.FromArgb(135, 20, 31);
			panelGuardarColas.Controls.Add(textBoxResultadoGuardar);
			panelGuardarColas.Controls.Add(buttonGuardarCambios);
			panelGuardarColas.Dock = DockStyle.Bottom;
			panelGuardarColas.Location = new Point(0, 306);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(668, 216);
			panelGuardarColas.TabIndex = 25;
			// 
			// textBoxResultadoGuardar
			// 
			textBoxResultadoGuardar.BackColor = Color.FromArgb(135, 20, 31);
			textBoxResultadoGuardar.BorderStyle = BorderStyle.None;
			textBoxResultadoGuardar.ForeColor = Color.White;
			textBoxResultadoGuardar.Location = new Point(288, 13);
			textBoxResultadoGuardar.Name = "textBoxResultadoGuardar";
			textBoxResultadoGuardar.ReadOnly = true;
			textBoxResultadoGuardar.Size = new Size(143, 16);
			textBoxResultadoGuardar.TabIndex = 16;
			// 
			// buttonGuardarCambios
			// 
			buttonGuardarCambios.Location = new Point(257, 95);
			buttonGuardarCambios.Name = "buttonGuardarCambios";
			buttonGuardarCambios.Size = new Size(120, 25);
			buttonGuardarCambios.TabIndex = 0;
			buttonGuardarCambios.Text = "Guardar cambios";
			buttonGuardarCambios.UseVisualStyleBackColor = true;
			buttonGuardarCambios.Click += buttonGuardarCambios_Click;
			// 
			// buttonBuscar
			// 
			buttonBuscar.Location = new Point(295, 85);
			buttonBuscar.Name = "buttonBuscar";
			buttonBuscar.Size = new Size(66, 25);
			buttonBuscar.TabIndex = 26;
			buttonBuscar.Text = "Buscar";
			buttonBuscar.UseVisualStyleBackColor = true;
			buttonBuscar.Click += buttonBuscar_Click;
			// 
			// FormEditar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(668, 522);
			Controls.Add(buttonBuscar);
			Controls.Add(panelGuardarColas);
			Controls.Add(textBoxAño);
			Controls.Add(labelAño);
			Controls.Add(textBoxNombrePelicula);
			Controls.Add(textBoxGeneroPelicula);
			Controls.Add(textBoxDuracionPelicula);
			Controls.Add(labelDuracion);
			Controls.Add(labelGenero);
			Controls.Add(labelNombre);
			Controls.Add(buttonCerarForm);
			Name = "FormEditar";
			Text = "FormEditar";
			panelGuardarColas.ResumeLayout(false);
			panelGuardarColas.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonCerarForm;
		public TextBox textBoxAño;
		private Label labelAño;
		public TextBox textBoxNombrePelicula;
		public TextBox textBoxGeneroPelicula;
		public TextBox textBoxDuracionPelicula;
		private Label labelDuracion;
		private Label labelGenero;
		private Label labelNombre;
		private Panel panelGuardarColas;
		private TextBox textBoxResultadoGuardar;
		private Button buttonGuardarCambios;
		private Button buttonBuscar;
	}
}