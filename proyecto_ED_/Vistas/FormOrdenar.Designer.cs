namespace proyecto_ED_.Vistas
{
	partial class FormOrdenar
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
			buttonOrdenarAscendente = new Button();
			textBoxResultadoGuardar = new TextBox();
			buttonOrdenarDescendente = new Button();
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
			panelGuardarColas.Controls.Add(buttonOrdenarAscendente);
			panelGuardarColas.Controls.Add(textBoxResultadoGuardar);
			panelGuardarColas.Controls.Add(buttonOrdenarDescendente);
			panelGuardarColas.Dock = DockStyle.Bottom;
			panelGuardarColas.Location = new Point(0, 408);
			panelGuardarColas.Margin = new Padding(3, 4, 3, 4);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(763, 288);
			panelGuardarColas.TabIndex = 26;
			// 
			// buttonOrdenarAscendente
			// 
			buttonOrdenarAscendente.Location = new Point(461, 112);
			buttonOrdenarAscendente.Margin = new Padding(3, 4, 3, 4);
			buttonOrdenarAscendente.Name = "buttonOrdenarAscendente";
			buttonOrdenarAscendente.Size = new Size(137, 33);
			buttonOrdenarAscendente.TabIndex = 17;
			buttonOrdenarAscendente.Text = "Ascendente";
			buttonOrdenarAscendente.UseVisualStyleBackColor = true;
			buttonOrdenarAscendente.Click += buttonOrdenarAscendente_Click;
			// 
			// textBoxResultadoGuardar
			// 
			textBoxResultadoGuardar.BackColor = Color.FromArgb(135, 20, 31);
			textBoxResultadoGuardar.BorderStyle = BorderStyle.None;
			textBoxResultadoGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxResultadoGuardar.ForeColor = Color.White;
			textBoxResultadoGuardar.Location = new Point(242, 18);
			textBoxResultadoGuardar.Margin = new Padding(3, 4, 3, 4);
			textBoxResultadoGuardar.Name = "textBoxResultadoGuardar";
			textBoxResultadoGuardar.ReadOnly = true;
			textBoxResultadoGuardar.Size = new Size(235, 23);
			textBoxResultadoGuardar.TabIndex = 16;
			// 
			// buttonOrdenarDescendente
			// 
			buttonOrdenarDescendente.Location = new Point(178, 112);
			buttonOrdenarDescendente.Margin = new Padding(3, 4, 3, 4);
			buttonOrdenarDescendente.Name = "buttonOrdenarDescendente";
			buttonOrdenarDescendente.Size = new Size(137, 33);
			buttonOrdenarDescendente.TabIndex = 0;
			buttonOrdenarDescendente.Text = "Descendente";
			buttonOrdenarDescendente.UseVisualStyleBackColor = true;
			buttonOrdenarDescendente.Click += buttonOrdenarDescendente_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.Black;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cid, Cnombre, Cgenero, Cduracion, Cyear });
			dataGridView1.GridColor = Color.Black;
			dataGridView1.Location = new Point(29, 80);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(703, 321);
			dataGridView1.TabIndex = 27;
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
			// FormOrdenar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(763, 696);
			Controls.Add(dataGridView1);
			Controls.Add(panelGuardarColas);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormOrdenar";
			Text = "FormOrdenar";
			panelGuardarColas.ResumeLayout(false);
			panelGuardarColas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelGuardarColas;
		private Button buttonOrdenarAscendente;
		private TextBox textBoxResultadoGuardar;
		private Button buttonOrdenarDescendente;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Cid;
		private DataGridViewTextBoxColumn Cnombre;
		private DataGridViewTextBoxColumn Cgenero;
		private DataGridViewTextBoxColumn Cduracion;
		private DataGridViewTextBoxColumn Cyear;
	}
}