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
			buttonBuscar = new Button();
			dataGridView1 = new DataGridView();
			Cid = new DataGridViewTextBoxColumn();
			Cnombre = new DataGridViewTextBoxColumn();
			Cgenero = new DataGridViewTextBoxColumn();
			Cduracion = new DataGridViewTextBoxColumn();
			Cyear = new DataGridViewTextBoxColumn();
			textBoxNombrePelicula = new TextBox();
			labelNombre = new Label();
			buttonCerarForm = new Button();
			panelGuardarColas = new Panel();
			panelMostrar = new Panel();
			panel1 = new Panel();
			panelContenedor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panelContenedor
			// 
			panelContenedor.BackColor = Color.Black;
			panelContenedor.Controls.Add(buttonBuscar);
			panelContenedor.Controls.Add(dataGridView1);
			panelContenedor.Controls.Add(textBoxNombrePelicula);
			panelContenedor.Controls.Add(labelNombre);
			panelContenedor.Controls.Add(buttonCerarForm);
			panelContenedor.Controls.Add(panelGuardarColas);
			panelContenedor.Controls.Add(panelMostrar);
			panelContenedor.Controls.Add(panel1);
			panelContenedor.Dock = DockStyle.Fill;
			panelContenedor.Location = new Point(0, 0);
			panelContenedor.Margin = new Padding(3, 4, 3, 4);
			panelContenedor.Name = "panelContenedor";
			panelContenedor.Size = new Size(763, 696);
			panelContenedor.TabIndex = 3;
			// 
			// buttonBuscar
			// 
			buttonBuscar.Location = new Point(500, 72);
			buttonBuscar.Margin = new Padding(3, 4, 3, 4);
			buttonBuscar.Name = "buttonBuscar";
			buttonBuscar.Size = new Size(79, 33);
			buttonBuscar.TabIndex = 16;
			buttonBuscar.Text = "Buscar";
			buttonBuscar.UseVisualStyleBackColor = true;
			buttonBuscar.Click += buttonBuscar_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.Black;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cid, Cnombre, Cgenero, Cduracion, Cyear });
			dataGridView1.GridColor = Color.Black;
			dataGridView1.Location = new Point(78, 157);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(622, 222);
			dataGridView1.TabIndex = 18;
			// 
			// Cid
			// 
			Cid.HeaderText = "Id";
			Cid.MaxInputLength = 3276;
			Cid.MinimumWidth = 6;
			Cid.Name = "Cid";
			Cid.ReadOnly = true;
			Cid.Width = 60;
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
			// textBoxNombrePelicula
			// 
			textBoxNombrePelicula.BackColor = Color.FromArgb(135, 20, 31);
			textBoxNombrePelicula.BorderStyle = BorderStyle.None;
			textBoxNombrePelicula.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxNombrePelicula.ForeColor = Color.White;
			textBoxNombrePelicula.Location = new Point(303, 72);
			textBoxNombrePelicula.Margin = new Padding(3, 4, 3, 4);
			textBoxNombrePelicula.Name = "textBoxNombrePelicula";
			textBoxNombrePelicula.Size = new Size(163, 23);
			textBoxNombrePelicula.TabIndex = 17;
			// 
			// labelNombre
			// 
			labelNombre.AutoSize = true;
			labelNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			labelNombre.ForeColor = SystemColors.ButtonFace;
			labelNombre.Location = new Point(200, 72);
			labelNombre.Name = "labelNombre";
			labelNombre.Size = new Size(77, 23);
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
			buttonCerarForm.Location = new Point(687, 16);
			buttonCerarForm.Margin = new Padding(3, 4, 3, 4);
			buttonCerarForm.Name = "buttonCerarForm";
			buttonCerarForm.Size = new Size(63, 33);
			buttonCerarForm.TabIndex = 15;
			buttonCerarForm.Text = "x";
			buttonCerarForm.UseVisualStyleBackColor = false;
			buttonCerarForm.Click += buttonCerarForm_Click;
			// 
			// panelGuardarColas
			// 
			panelGuardarColas.BackColor = Color.FromArgb(135, 20, 31);
			panelGuardarColas.Dock = DockStyle.Bottom;
			panelGuardarColas.Location = new Point(0, 408);
			panelGuardarColas.Margin = new Padding(3, 4, 3, 4);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(763, 288);
			panelGuardarColas.TabIndex = 14;
			// 
			// panelMostrar
			// 
			panelMostrar.Location = new Point(1, 3);
			panelMostrar.Margin = new Padding(3, 4, 3, 4);
			panelMostrar.Name = "panelMostrar";
			panelMostrar.Size = new Size(0, 0);
			panelMostrar.TabIndex = 3;
			// 
			// panel1
			// 
			panel1.Location = new Point(2, 0);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(0, 0);
			panel1.TabIndex = 2;
			// 
			// FormBuscar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(763, 696);
			Controls.Add(panelContenedor);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormBuscar";
			Text = "FormBuscar";
			panelContenedor.ResumeLayout(false);
			panelContenedor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Cid;
		private DataGridViewTextBoxColumn Cnombre;
		private DataGridViewTextBoxColumn Cgenero;
		private DataGridViewTextBoxColumn Cduracion;
		private DataGridViewTextBoxColumn Cyear;
	}
}