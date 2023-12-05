namespace proyecto_ED_
{
	partial class FormRegistrar
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
			labelNombre = new Label();
			labelGenero = new Label();
			labelDuracion = new Label();
			textBoxDuracionPelicula = new TextBox();
			textBoxGeneroPelicula = new TextBox();
			textBoxNombrePelicula = new TextBox();
			buttonCerarForm = new Button();
			panelGuardarColas = new Panel();
			textBoxResultadoGuardar = new TextBox();
			buttonGuardarMedio = new Button();
			buttonGuardarFinalColas = new Button();
			buttonGuardarFrente = new Button();
			labelAño = new Label();
			textBoxAño = new TextBox();
			panelGuardarColas.SuspendLayout();
			SuspendLayout();
			// 
			// labelNombre
			// 
			labelNombre.AutoSize = true;
			labelNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelNombre.ForeColor = SystemColors.ButtonFace;
			labelNombre.Location = new Point(96, 65);
			labelNombre.Name = "labelNombre";
			labelNombre.Size = new Size(77, 23);
			labelNombre.TabIndex = 0;
			labelNombre.Text = "Nombre:";
			// 
			// labelGenero
			// 
			labelGenero.AutoSize = true;
			labelGenero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelGenero.ForeColor = SystemColors.ButtonFace;
			labelGenero.Location = new Point(96, 131);
			labelGenero.Name = "labelGenero";
			labelGenero.Size = new Size(70, 23);
			labelGenero.TabIndex = 1;
			labelGenero.Text = "Genero:";
			// 
			// labelDuracion
			// 
			labelDuracion.AutoSize = true;
			labelDuracion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelDuracion.ForeColor = SystemColors.ButtonFace;
			labelDuracion.Location = new Point(96, 204);
			labelDuracion.Name = "labelDuracion";
			labelDuracion.Size = new Size(83, 23);
			labelDuracion.TabIndex = 2;
			labelDuracion.Text = "Duración:";
			// 
			// textBoxDuracionPelicula
			// 
			textBoxDuracionPelicula.BackColor = Color.FromArgb(135, 20, 30);
			textBoxDuracionPelicula.BorderStyle = BorderStyle.None;
			textBoxDuracionPelicula.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxDuracionPelicula.ForeColor = Color.White;
			textBoxDuracionPelicula.Location = new Point(96, 233);
			textBoxDuracionPelicula.Margin = new Padding(3, 4, 3, 4);
			textBoxDuracionPelicula.MaxLength = 3;
			textBoxDuracionPelicula.Name = "textBoxDuracionPelicula";
			textBoxDuracionPelicula.PlaceholderText = "duración en minutos";
			textBoxDuracionPelicula.Size = new Size(166, 23);
			textBoxDuracionPelicula.TabIndex = 4;
			textBoxDuracionPelicula.KeyPress += textBoxDuracionPelicula_KeyPress;
			// 
			// textBoxGeneroPelicula
			// 
			textBoxGeneroPelicula.BackColor = Color.FromArgb(135, 20, 31);
			textBoxGeneroPelicula.BorderStyle = BorderStyle.None;
			textBoxGeneroPelicula.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxGeneroPelicula.ForeColor = Color.White;
			textBoxGeneroPelicula.Location = new Point(96, 160);
			textBoxGeneroPelicula.Margin = new Padding(3, 4, 3, 4);
			textBoxGeneroPelicula.Name = "textBoxGeneroPelicula";
			textBoxGeneroPelicula.Size = new Size(166, 23);
			textBoxGeneroPelicula.TabIndex = 3;
			// 
			// textBoxNombrePelicula
			// 
			textBoxNombrePelicula.BackColor = Color.FromArgb(135, 20, 31);
			textBoxNombrePelicula.BorderStyle = BorderStyle.None;
			textBoxNombrePelicula.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxNombrePelicula.ForeColor = Color.White;
			textBoxNombrePelicula.Location = new Point(96, 92);
			textBoxNombrePelicula.Margin = new Padding(3, 4, 3, 4);
			textBoxNombrePelicula.Name = "textBoxNombrePelicula";
			textBoxNombrePelicula.Size = new Size(166, 23);
			textBoxNombrePelicula.TabIndex = 2;
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
			buttonCerarForm.Location = new Point(687, 16);
			buttonCerarForm.Margin = new Padding(3, 4, 3, 4);
			buttonCerarForm.Name = "buttonCerarForm";
			buttonCerarForm.Size = new Size(63, 33);
			buttonCerarForm.TabIndex = 1;
			buttonCerarForm.Text = "x";
			buttonCerarForm.UseVisualStyleBackColor = false;
			buttonCerarForm.Click += buttonCerarForm_Click;
			// 
			// panelGuardarColas
			// 
			panelGuardarColas.BackColor = Color.FromArgb(135, 20, 31);
			panelGuardarColas.Controls.Add(textBoxResultadoGuardar);
			panelGuardarColas.Controls.Add(buttonGuardarMedio);
			panelGuardarColas.Controls.Add(buttonGuardarFinalColas);
			panelGuardarColas.Controls.Add(buttonGuardarFrente);
			panelGuardarColas.Dock = DockStyle.Bottom;
			panelGuardarColas.Location = new Point(0, 408);
			panelGuardarColas.Margin = new Padding(3, 4, 3, 4);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(763, 288);
			panelGuardarColas.TabIndex = 13;
			// 
			// textBoxResultadoGuardar
			// 
			textBoxResultadoGuardar.BackColor = Color.FromArgb(135, 20, 31);
			textBoxResultadoGuardar.BorderStyle = BorderStyle.None;
			textBoxResultadoGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxResultadoGuardar.ForeColor = Color.White;
			textBoxResultadoGuardar.Location = new Point(203, 23);
			textBoxResultadoGuardar.Margin = new Padding(3, 4, 3, 4);
			textBoxResultadoGuardar.Name = "textBoxResultadoGuardar";
			textBoxResultadoGuardar.ReadOnly = true;
			textBoxResultadoGuardar.Size = new Size(336, 23);
			textBoxResultadoGuardar.TabIndex = 9;
			// 
			// buttonGuardarMedio
			// 
			buttonGuardarMedio.Location = new Point(342, 129);
			buttonGuardarMedio.Margin = new Padding(3, 4, 3, 4);
			buttonGuardarMedio.Name = "buttonGuardarMedio";
			buttonGuardarMedio.Size = new Size(137, 33);
			buttonGuardarMedio.TabIndex = 7;
			buttonGuardarMedio.Text = "Guardar al medio";
			buttonGuardarMedio.UseVisualStyleBackColor = true;
			buttonGuardarMedio.Click += buttonGuardarMedio_Click;
			// 
			// buttonGuardarFinalColas
			// 
			buttonGuardarFinalColas.Location = new Point(549, 129);
			buttonGuardarFinalColas.Margin = new Padding(3, 4, 3, 4);
			buttonGuardarFinalColas.Name = "buttonGuardarFinalColas";
			buttonGuardarFinalColas.Size = new Size(137, 33);
			buttonGuardarFinalColas.TabIndex = 8;
			buttonGuardarFinalColas.Text = "Guardar al final";
			buttonGuardarFinalColas.UseVisualStyleBackColor = true;
			buttonGuardarFinalColas.Click += buttonGuardarFinalColas_Click;
			// 
			// buttonGuardarFrente
			// 
			buttonGuardarFrente.Location = new Point(125, 129);
			buttonGuardarFrente.Margin = new Padding(3, 4, 3, 4);
			buttonGuardarFrente.Name = "buttonGuardarFrente";
			buttonGuardarFrente.Size = new Size(137, 33);
			buttonGuardarFrente.TabIndex = 6;
			buttonGuardarFrente.Text = "Guardar al frente";
			buttonGuardarFrente.UseVisualStyleBackColor = true;
			buttonGuardarFrente.Click += buttonGuardarFrente_Click;
			// 
			// labelAño
			// 
			labelAño.AutoSize = true;
			labelAño.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelAño.ForeColor = SystemColors.ButtonFace;
			labelAño.Location = new Point(96, 269);
			labelAño.Name = "labelAño";
			labelAño.Size = new Size(168, 23);
			labelAño.TabIndex = 14;
			labelAño.Text = "Año de lanzamiento:";
			// 
			// textBoxAño
			// 
			textBoxAño.BackColor = Color.FromArgb(135, 20, 30);
			textBoxAño.BorderStyle = BorderStyle.None;
			textBoxAño.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxAño.ForeColor = Color.White;
			textBoxAño.Location = new Point(96, 299);
			textBoxAño.Margin = new Padding(3, 4, 3, 4);
			textBoxAño.MaxLength = 4;
			textBoxAño.Name = "textBoxAño";
			textBoxAño.Size = new Size(166, 23);
			textBoxAño.TabIndex = 5;
			// 
			// FormRegistrar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(763, 696);
			Controls.Add(textBoxAño);
			Controls.Add(labelAño);
			Controls.Add(panelGuardarColas);
			Controls.Add(buttonCerarForm);
			Controls.Add(textBoxNombrePelicula);
			Controls.Add(textBoxGeneroPelicula);
			Controls.Add(textBoxDuracionPelicula);
			Controls.Add(labelDuracion);
			Controls.Add(labelGenero);
			Controls.Add(labelNombre);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormRegistrar";
			Text = "Registrar pelicula";
			panelGuardarColas.ResumeLayout(false);
			panelGuardarColas.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelNombre;
		private Label labelGenero;
		private Label labelDuracion;
		private Button buttonCerarForm;
		private Panel panelGuardarColas;
		private Button buttonGuardarMedio;
		private Button buttonGuardarFinalColas;
		private Button buttonGuardarFrente;
		private Label labelAño;
		private TextBox textBoxResultadoGuardar;
		public TextBox textBoxDuracionPelicula;
		public TextBox textBoxGeneroPelicula;
		public TextBox textBoxNombrePelicula;
		public TextBox textBoxAño;
	}
}