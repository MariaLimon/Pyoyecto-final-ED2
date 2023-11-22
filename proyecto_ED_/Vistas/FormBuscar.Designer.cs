namespace proyecto_ED_
{
	partial class FormBuscar
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
			panelContenedor = new Panel();
			textBoxNombrePelicula = new TextBox();
			labelNombre = new Label();
			buttonCerarForm = new Button();
			panelGuardarColas = new Panel();
			buttonBuscar = new Button();
			panelMostrar = new Panel();
			panel1 = new Panel();
			panelContenedor.SuspendLayout();
			panelGuardarColas.SuspendLayout();
			SuspendLayout();
			// 
			// panelContenedor
			// 
			panelContenedor.BackColor = Color.Black;
			panelContenedor.Controls.Add(textBoxNombrePelicula);
			panelContenedor.Controls.Add(labelNombre);
			panelContenedor.Controls.Add(buttonCerarForm);
			panelContenedor.Controls.Add(panelGuardarColas);
			panelContenedor.Controls.Add(panelMostrar);
			panelContenedor.Controls.Add(panel1);
			panelContenedor.Dock = DockStyle.Fill;
			panelContenedor.Location = new Point(0, 0);
			panelContenedor.Name = "panelContenedor";
			panelContenedor.Size = new Size(668, 522);
			panelContenedor.TabIndex = 3;
			// 
			// textBoxNombrePelicula
			// 
			textBoxNombrePelicula.BackColor = Color.FromArgb(135, 20, 31);
			textBoxNombrePelicula.BorderStyle = BorderStyle.None;
			textBoxNombrePelicula.ForeColor = Color.White;
			textBoxNombrePelicula.Location = new Point(309, 101);
			textBoxNombrePelicula.Name = "textBoxNombrePelicula";
			textBoxNombrePelicula.Size = new Size(100, 16);
			textBoxNombrePelicula.TabIndex = 17;
			// 
			// labelNombre
			// 
			labelNombre.AutoSize = true;
			labelNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelNombre.ForeColor = SystemColors.ButtonFace;
			labelNombre.Location = new Point(234, 102);
			labelNombre.Name = "labelNombre";
			labelNombre.Size = new Size(60, 17);
			labelNombre.TabIndex = 16;
			labelNombre.Text = "Nombre:";
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
			buttonCerarForm.TabIndex = 15;
			buttonCerarForm.Text = "x";
			buttonCerarForm.UseVisualStyleBackColor = false;
			buttonCerarForm.Click += buttonCerarForm_Click;
			// 
			// panelGuardarColas
			// 
			panelGuardarColas.BackColor = Color.FromArgb(135, 20, 31);
			panelGuardarColas.Controls.Add(buttonBuscar);
			panelGuardarColas.Dock = DockStyle.Bottom;
			panelGuardarColas.Location = new Point(0, 306);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(668, 216);
			panelGuardarColas.TabIndex = 14;
			// 
			// buttonBuscar
			// 
			buttonBuscar.Location = new Point(278, 105);
			buttonBuscar.Name = "buttonBuscar";
			buttonBuscar.Size = new Size(120, 25);
			buttonBuscar.TabIndex = 16;
			buttonBuscar.Text = "Buscar";
			buttonBuscar.UseVisualStyleBackColor = true;
			buttonBuscar.Click += buttonBuscar_Click;
			// 
			// panelMostrar
			// 
			panelMostrar.Location = new Point(1, 2);
			panelMostrar.Name = "panelMostrar";
			panelMostrar.Size = new Size(0, 0);
			panelMostrar.TabIndex = 3;
			// 
			// panel1
			// 
			panel1.Location = new Point(2, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(0, 0);
			panel1.TabIndex = 2;
			// 
			// FormBuscar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(668, 522);
			Controls.Add(panelContenedor);
			Name = "FormBuscar";
			Text = "FormBuscar";
			panelContenedor.ResumeLayout(false);
			panelContenedor.PerformLayout();
			panelGuardarColas.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panelContenedor;
		private Button buttonCerarForm;
		private Panel panelGuardarColas;
		private Panel panelMostrar;
		private Panel panel1;
		private Button buttonBuscar;
		private Label labelNombre;
		public TextBox textBoxNombrePelicula;
	}
}