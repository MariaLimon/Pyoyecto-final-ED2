namespace proyecto_ED_
{
	partial class FormMostrar
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
			dataGridView1 = new DataGridView();
			Cid = new DataGridViewTextBoxColumn();
			Cnombre = new DataGridViewTextBoxColumn();
			Cgenero = new DataGridViewTextBoxColumn();
			Cduracion = new DataGridViewTextBoxColumn();
			Cyear = new DataGridViewTextBoxColumn();
			buttonCerarForm = new Button();
			panelGuardarColas = new Panel();
			textBoxMensajeMostrar = new TextBox();
			buttonMostrar = new Button();
			panelMostrar = new Panel();
			panel1 = new Panel();
			panelContenedor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panelGuardarColas.SuspendLayout();
			SuspendLayout();
			// 
			// panelContenedor
			// 
			panelContenedor.BackColor = Color.Black;
			panelContenedor.Controls.Add(dataGridView1);
			panelContenedor.Controls.Add(buttonCerarForm);
			panelContenedor.Controls.Add(panelGuardarColas);
			panelContenedor.Controls.Add(panelMostrar);
			panelContenedor.Controls.Add(panel1);
			panelContenedor.Dock = DockStyle.Fill;
			panelContenedor.Location = new Point(0, 0);
			panelContenedor.Name = "panelContenedor";
			panelContenedor.Size = new Size(668, 522);
			panelContenedor.TabIndex = 2;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.Black;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cid, Cnombre, Cgenero, Cduracion, Cyear });
			dataGridView1.GridColor = Color.Black;
			dataGridView1.Location = new Point(59, 60);
			dataGridView1.Margin = new Padding(3, 2, 3, 2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(553, 221);
			dataGridView1.TabIndex = 16;
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
			panelGuardarColas.Controls.Add(textBoxMensajeMostrar);
			panelGuardarColas.Controls.Add(buttonMostrar);
			panelGuardarColas.Dock = DockStyle.Bottom;
			panelGuardarColas.Location = new Point(0, 306);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(668, 216);
			panelGuardarColas.TabIndex = 14;
			// 
			// textBoxMensajeMostrar
			// 
			textBoxMensajeMostrar.BackColor = Color.FromArgb(135, 20, 31);
			textBoxMensajeMostrar.BorderStyle = BorderStyle.None;
			textBoxMensajeMostrar.ForeColor = Color.White;
			textBoxMensajeMostrar.Location = new Point(245, 15);
			textBoxMensajeMostrar.Name = "textBoxMensajeMostrar";
			textBoxMensajeMostrar.ReadOnly = true;
			textBoxMensajeMostrar.Size = new Size(165, 16);
			textBoxMensajeMostrar.TabIndex = 10;
			// 
			// buttonMostrar
			// 
			buttonMostrar.Location = new Point(287, 74);
			buttonMostrar.Margin = new Padding(3, 2, 3, 2);
			buttonMostrar.Name = "buttonMostrar";
			buttonMostrar.Size = new Size(82, 22);
			buttonMostrar.TabIndex = 0;
			buttonMostrar.Text = "Refrescar";
			buttonMostrar.UseVisualStyleBackColor = true;
			buttonMostrar.Click += buttonMostrar_Click;
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
			// FormMostrar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(668, 522);
			Controls.Add(panelContenedor);
			Name = "FormMostrar";
			Text = "FormMostrar";
			panelContenedor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panelGuardarColas.ResumeLayout(false);
			panelGuardarColas.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelContenedor;
		private Panel panelMostrar;
		private Panel panel1;
		private Panel panelGuardarColas;
		private Button buttonCerarForm;
		private DataGridView dataGridView1;
		private Button buttonMostrar;
		public TextBox textBoxMensajeMostrar;
		private DataGridViewTextBoxColumn Cid;
		private DataGridViewTextBoxColumn Cnombre;
		private DataGridViewTextBoxColumn Cgenero;
		private DataGridViewTextBoxColumn Cduracion;
		private DataGridViewTextBoxColumn Cyear;
	}
}