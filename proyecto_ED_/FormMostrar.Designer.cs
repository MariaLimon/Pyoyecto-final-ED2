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
			listBoxMostrar = new ListBox();
			buttonCerarForm = new Button();
			panelGuardarColas = new Panel();
			panelMostrar = new Panel();
			panel1 = new Panel();
			panelContenedor.SuspendLayout();
			SuspendLayout();
			// 
			// panelContenedor
			// 
			panelContenedor.BackColor = Color.Black;
			panelContenedor.Controls.Add(listBoxMostrar);
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
			// listBoxMostrar
			// 
			listBoxMostrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listBoxMostrar.BackColor = Color.Black;
			listBoxMostrar.BorderStyle = BorderStyle.None;
			listBoxMostrar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			listBoxMostrar.ForeColor = SystemColors.Info;
			listBoxMostrar.FormattingEnabled = true;
			listBoxMostrar.ItemHeight = 17;
			listBoxMostrar.Location = new Point(191, 57);
			listBoxMostrar.Name = "listBoxMostrar";
			listBoxMostrar.SelectionMode = SelectionMode.None;
			listBoxMostrar.Size = new Size(269, 204);
			listBoxMostrar.TabIndex = 16;
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
			panelGuardarColas.Dock = DockStyle.Bottom;
			panelGuardarColas.Location = new Point(0, 306);
			panelGuardarColas.Name = "panelGuardarColas";
			panelGuardarColas.Size = new Size(668, 216);
			panelGuardarColas.TabIndex = 14;
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
			ResumeLayout(false);
		}

		#endregion

		private Panel panelContenedor;
		private Panel panelMostrar;
		private Panel panel1;
		private Panel panelGuardarColas;
		private Button buttonCerarForm;
		private ListBox listBoxMostrar;
	}
}