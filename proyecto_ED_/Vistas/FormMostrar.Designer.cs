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
			panelMostrar = new Panel();
			panel1 = new Panel();
			textBoxResultadoGuardar = new TextBox();
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
			panelContenedor.Margin = new Padding(3, 4, 3, 4);
			panelContenedor.Name = "panelContenedor";
			panelContenedor.Size = new Size(763, 696);
			panelContenedor.TabIndex = 2;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.Black;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cid, Cnombre, Cgenero, Cduracion, Cyear });
			dataGridView1.GridColor = Color.Black;
			dataGridView1.Location = new Point(67, 80);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(632, 321);
			dataGridView1.TabIndex = 16;
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
			panelGuardarColas.Controls.Add(textBoxResultadoGuardar);
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
			// textBoxResultadoGuardar
			// 
			textBoxResultadoGuardar.BackColor = Color.FromArgb(135, 20, 31);
			textBoxResultadoGuardar.BorderStyle = BorderStyle.None;
			textBoxResultadoGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxResultadoGuardar.ForeColor = Color.White;
			textBoxResultadoGuardar.Location = new Point(260, 27);
			textBoxResultadoGuardar.Margin = new Padding(3, 4, 3, 4);
			textBoxResultadoGuardar.Name = "textBoxResultadoGuardar";
			textBoxResultadoGuardar.ReadOnly = true;
			textBoxResultadoGuardar.Size = new Size(213, 23);
			textBoxResultadoGuardar.TabIndex = 11;
			// 
			// FormMostrar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(763, 696);
			Controls.Add(panelContenedor);
			Margin = new Padding(3, 4, 3, 4);
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
		private DataGridViewTextBoxColumn Cid;
		private DataGridViewTextBoxColumn Cnombre;
		private DataGridViewTextBoxColumn Cgenero;
		private DataGridViewTextBoxColumn Cduracion;
		private DataGridViewTextBoxColumn Cyear;
		private TextBox textBoxResultadoGuardar;
	}
}