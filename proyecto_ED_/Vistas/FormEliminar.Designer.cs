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
			panelGuardarColas.SuspendLayout();
			SuspendLayout();
			// 
			// panelGuardarColas
			// 
			panelGuardarColas.BackColor = Color.FromArgb(135, 20, 31);
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
			// buttonEliminarMedio
			// 
			buttonEliminarMedio.Location = new Point(311, 129);
			buttonEliminarMedio.Margin = new Padding(3, 4, 3, 4);
			buttonEliminarMedio.Name = "buttonEliminarMedio";
			buttonEliminarMedio.Size = new Size(168, 33);
			buttonEliminarMedio.TabIndex = 2;
			buttonEliminarMedio.Text = "Eliminar del medio";
			buttonEliminarMedio.UseVisualStyleBackColor = true;
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
			// FormEliminar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(763, 696);
			Controls.Add(buttonCerarForm);
			Controls.Add(panelGuardarColas);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FormEliminar";
			Text = "FormEliminar";
			panelGuardarColas.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panelGuardarColas;
		private Button buttonEliminarMedio;
		private Button buttonEliminarFinal;
		private Button buttonEliminarFrente;
		private Button buttonCerarForm;
	}
}