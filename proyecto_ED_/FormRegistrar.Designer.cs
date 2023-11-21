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
			label1 = new Label();
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
			labelNombre.Location = new Point(84, 71);
			labelNombre.Name = "labelNombre";
			labelNombre.Size = new Size(60, 17);
			labelNombre.TabIndex = 0;
			labelNombre.Text = "Nombre:";
			// 
			// labelGenero
			// 
			labelGenero.AutoSize = true;
			labelGenero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelGenero.ForeColor = SystemColors.ButtonFace;
			labelGenero.Location = new Point(84, 115);
			labelGenero.Name = "labelGenero";
			labelGenero.Size = new Size(57, 19);
			labelGenero.TabIndex = 1;
			labelGenero.Text = "Genero;";
			// 
			// labelDuracion
			// 
			labelDuracion.AutoSize = true;
			labelDuracion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelDuracion.ForeColor = SystemColors.ButtonFace;
			labelDuracion.Location = new Point(84, 153);
			labelDuracion.Name = "labelDuracion";
			labelDuracion.Size = new Size(67, 19);
			labelDuracion.TabIndex = 2;
			labelDuracion.Text = "Duración:";
			// 
			// textBoxDuracionPelicula
			// 
			textBoxDuracionPelicula.BackColor = Color.FromArgb(135, 20, 30);
			textBoxDuracionPelicula.BorderStyle = BorderStyle.None;
			textBoxDuracionPelicula.ForeColor = Color.White;
			textBoxDuracionPelicula.Location = new Point(159, 155);
			textBoxDuracionPelicula.MaxLength = 3;
			textBoxDuracionPelicula.Name = "textBoxDuracionPelicula";
			textBoxDuracionPelicula.Size = new Size(100, 16);
			textBoxDuracionPelicula.TabIndex = 7;
			textBoxDuracionPelicula.KeyPress += textBoxDuracionPelicula_KeyPress;
			// 
			// textBoxGeneroPelicula
			// 
			textBoxGeneroPelicula.BackColor = Color.FromArgb(135, 20, 31);
			textBoxGeneroPelicula.BorderStyle = BorderStyle.None;
			textBoxGeneroPelicula.ForeColor = Color.White;
			textBoxGeneroPelicula.Location = new Point(147, 114);
			textBoxGeneroPelicula.Name = "textBoxGeneroPelicula";
			textBoxGeneroPelicula.Size = new Size(100, 16);
			textBoxGeneroPelicula.TabIndex = 8;
			// 
			// textBoxNombrePelicula
			// 
			textBoxNombrePelicula.BackColor = Color.FromArgb(135, 20, 31);
			textBoxNombrePelicula.BorderStyle = BorderStyle.None;
			textBoxNombrePelicula.ForeColor = Color.White;
			textBoxNombrePelicula.Location = new Point(159, 70);
			textBoxNombrePelicula.Name = "textBoxNombrePelicula";
			textBoxNombrePelicula.Size = new Size(100, 16);
			textBoxNombrePelicula.TabIndex = 9;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = SystemColors.ButtonFace;
			label1.Location = new Point(265, 155);
			label1.Name = "label1";
			label1.Size = new Size(51, 15);
			label1.TabIndex = 10;
			label1.Text = "minutos";
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
			buttonCerarForm.TabIndex = 12;
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
			panelGuardarColas.Location = new Point(0, 306);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(668, 216);
			panelGuardarColas.TabIndex = 13;
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
			// buttonGuardarMedio
			// 
			buttonGuardarMedio.Location = new Point(299, 97);
			buttonGuardarMedio.Name = "buttonGuardarMedio";
			buttonGuardarMedio.Size = new Size(120, 25);
			buttonGuardarMedio.TabIndex = 2;
			buttonGuardarMedio.Text = "Guardar al medio";
			buttonGuardarMedio.UseVisualStyleBackColor = true;
			buttonGuardarMedio.Click += buttonGuardarMedio_Click;
			// 
			// buttonGuardarFinalColas
			// 
			buttonGuardarFinalColas.Location = new Point(480, 97);
			buttonGuardarFinalColas.Name = "buttonGuardarFinalColas";
			buttonGuardarFinalColas.Size = new Size(120, 25);
			buttonGuardarFinalColas.TabIndex = 1;
			buttonGuardarFinalColas.Text = "Guardar al final";
			buttonGuardarFinalColas.UseVisualStyleBackColor = true;
			// 
			// buttonGuardarFrente
			// 
			buttonGuardarFrente.Location = new Point(109, 97);
			buttonGuardarFrente.Name = "buttonGuardarFrente";
			buttonGuardarFrente.Size = new Size(120, 25);
			buttonGuardarFrente.TabIndex = 0;
			buttonGuardarFrente.Text = "Guardar al frente";
			buttonGuardarFrente.UseVisualStyleBackColor = true;
			buttonGuardarFrente.Click += buttonGuardarFrente_Click;
			// 
			// labelAño
			// 
			labelAño.AutoSize = true;
			labelAño.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			labelAño.ForeColor = SystemColors.ButtonFace;
			labelAño.Location = new Point(84, 202);
			labelAño.Name = "labelAño";
			labelAño.Size = new Size(134, 19);
			labelAño.TabIndex = 14;
			labelAño.Text = "Año de lanzamiento:";
			// 
			// textBoxAño
			// 
			textBoxAño.BackColor = Color.FromArgb(135, 20, 30);
			textBoxAño.BorderStyle = BorderStyle.None;
			textBoxAño.ForeColor = Color.White;
			textBoxAño.Location = new Point(224, 205);
			textBoxAño.MaxLength = 4;
			textBoxAño.Name = "textBoxAño";
			textBoxAño.Size = new Size(100, 16);
			textBoxAño.TabIndex = 15;
			// 
			// FormRegistrar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(668, 522);
			Controls.Add(textBoxAño);
			Controls.Add(labelAño);
			Controls.Add(panelGuardarColas);
			Controls.Add(buttonCerarForm);
			Controls.Add(label1);
			Controls.Add(textBoxNombrePelicula);
			Controls.Add(textBoxGeneroPelicula);
			Controls.Add(textBoxDuracionPelicula);
			Controls.Add(labelDuracion);
			Controls.Add(labelGenero);
			Controls.Add(labelNombre);
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
		private TextBox textBoxDuracionPelicula;
		private TextBox textBoxGeneroPelicula;
		private TextBox textBoxNombrePelicula;
		private Label label1;
		private Button buttonCerarForm;
		private Panel panelGuardarColas;
		private Button buttonGuardarMedio;
		private Button buttonGuardarFinalColas;
		private Button buttonGuardarFrente;
		private Label labelAño;
		private TextBox textBoxAño;
		private TextBox textBoxResultadoGuardar;
	}
}