
namespace View
{
	partial class FrmListaLeitor
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
			this.txbCPF = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvLeitores = new System.Windows.Forms.DataGridView();
			this.columnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).BeginInit();
			this.SuspendLayout();
			// 
			// txbCPF
			// 
			this.txbCPF.Location = new System.Drawing.Point(104, 41);
			this.txbCPF.Name = "txbCPF";
			this.txbCPF.Size = new System.Drawing.Size(209, 22);
			this.txbCPF.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 21);
			this.label2.TabIndex = 26;
			this.label2.Text = "CPF";
			// 
			// dgvLeitores
			// 
			this.dgvLeitores.AllowUserToAddRows = false;
			this.dgvLeitores.AllowUserToDeleteRows = false;
			this.dgvLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLeitores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCPF,
            this.columnNome,
            this.columnEmail,
            this.columnContato});
			this.dgvLeitores.Location = new System.Drawing.Point(51, 86);
			this.dgvLeitores.Name = "dgvLeitores";
			this.dgvLeitores.ReadOnly = true;
			this.dgvLeitores.RowHeadersVisible = false;
			this.dgvLeitores.RowHeadersWidth = 51;
			this.dgvLeitores.RowTemplate.Height = 24;
			this.dgvLeitores.Size = new System.Drawing.Size(503, 301);
			this.dgvLeitores.TabIndex = 28;
			// 
			// columnCPF
			// 
			this.columnCPF.HeaderText = "CPF";
			this.columnCPF.MinimumWidth = 6;
			this.columnCPF.Name = "columnCPF";
			this.columnCPF.ReadOnly = true;
			this.columnCPF.Width = 125;
			// 
			// columnNome
			// 
			this.columnNome.HeaderText = "Nome";
			this.columnNome.MinimumWidth = 6;
			this.columnNome.Name = "columnNome";
			this.columnNome.ReadOnly = true;
			this.columnNome.Width = 125;
			// 
			// columnEmail
			// 
			this.columnEmail.HeaderText = "Email";
			this.columnEmail.MinimumWidth = 6;
			this.columnEmail.Name = "columnEmail";
			this.columnEmail.ReadOnly = true;
			this.columnEmail.Width = 125;
			// 
			// columnContato
			// 
			this.columnContato.HeaderText = "Contato";
			this.columnContato.MinimumWidth = 6;
			this.columnContato.Name = "columnContato";
			this.columnContato.ReadOnly = true;
			this.columnContato.Width = 125;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(51, 408);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(66, 23);
			this.btnAlterar.TabIndex = 29;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// btnDeletar
			// 
			this.btnDeletar.Location = new System.Drawing.Point(123, 408);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(79, 23);
			this.btnDeletar.TabIndex = 30;
			this.btnDeletar.Text = "Deletar";
			this.btnDeletar.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(319, 40);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 31;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// FrmListaLeitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 461);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.dgvLeitores);
			this.Controls.Add(this.txbCPF);
			this.Controls.Add(this.label2);
			this.Name = "FrmListaLeitor";
			this.Text = "FrmLeitor";
			((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txbCPF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvLeitores;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnCPF;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnContato;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.Button btnBuscar;
	}
}