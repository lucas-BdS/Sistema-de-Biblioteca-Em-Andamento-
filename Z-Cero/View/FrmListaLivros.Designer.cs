
namespace View
{
	partial class FrmListaLivros
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
			this.label1 = new System.Windows.Forms.Label();
			this.mtxbISBN = new System.Windows.Forms.MaskedTextBox();
			this.dgvListaLivros = new System.Windows.Forms.DataGridView();
			this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txbTitulo = new System.Windows.Forms.TextBox();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaLivros)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(43, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 21);
			this.label1.TabIndex = 14;
			this.label1.Text = "ISBN";
			// 
			// mtxbISBN
			// 
			this.mtxbISBN.Location = new System.Drawing.Point(97, 28);
			this.mtxbISBN.Mask = "000-0-00-000000-0";
			this.mtxbISBN.Name = "mtxbISBN";
			this.mtxbISBN.Size = new System.Drawing.Size(128, 22);
			this.mtxbISBN.TabIndex = 21;
			// 
			// dgvListaLivros
			// 
			this.dgvListaLivros.AllowUserToAddRows = false;
			this.dgvListaLivros.AllowUserToDeleteRows = false;
			this.dgvListaLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnISBN,
            this.columnTitulo,
            this.columnAutor,
            this.columnStatus});
			this.dgvListaLivros.Location = new System.Drawing.Point(47, 134);
			this.dgvListaLivros.Name = "dgvListaLivros";
			this.dgvListaLivros.ReadOnly = true;
			this.dgvListaLivros.RowHeadersVisible = false;
			this.dgvListaLivros.RowHeadersWidth = 51;
			this.dgvListaLivros.RowTemplate.Height = 24;
			this.dgvListaLivros.Size = new System.Drawing.Size(628, 335);
			this.dgvListaLivros.TabIndex = 22;
			// 
			// columnID
			// 
			this.columnID.HeaderText = "ID";
			this.columnID.MinimumWidth = 6;
			this.columnID.Name = "columnID";
			this.columnID.ReadOnly = true;
			this.columnID.Width = 125;
			// 
			// columnISBN
			// 
			this.columnISBN.HeaderText = "ISBN";
			this.columnISBN.MinimumWidth = 6;
			this.columnISBN.Name = "columnISBN";
			this.columnISBN.ReadOnly = true;
			this.columnISBN.Width = 125;
			// 
			// columnTitulo
			// 
			this.columnTitulo.HeaderText = "Título";
			this.columnTitulo.MinimumWidth = 6;
			this.columnTitulo.Name = "columnTitulo";
			this.columnTitulo.ReadOnly = true;
			this.columnTitulo.Width = 125;
			// 
			// columnAutor
			// 
			this.columnAutor.HeaderText = "Autor";
			this.columnAutor.MinimumWidth = 6;
			this.columnAutor.Name = "columnAutor";
			this.columnAutor.ReadOnly = true;
			this.columnAutor.Width = 125;
			// 
			// columnStatus
			// 
			this.columnStatus.HeaderText = "Status";
			this.columnStatus.MinimumWidth = 6;
			this.columnStatus.Name = "columnStatus";
			this.columnStatus.ReadOnly = true;
			this.columnStatus.Width = 125;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(231, 105);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 23;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 21);
			this.label2.TabIndex = 24;
			this.label2.Text = "Título";
			// 
			// txbTitulo
			// 
			this.txbTitulo.Location = new System.Drawing.Point(97, 64);
			this.txbTitulo.Name = "txbTitulo";
			this.txbTitulo.Size = new System.Drawing.Size(209, 22);
			this.txbTitulo.TabIndex = 25;
			// 
			// btnDeletar
			// 
			this.btnDeletar.Location = new System.Drawing.Point(119, 475);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(79, 23);
			this.btnDeletar.TabIndex = 32;
			this.btnDeletar.Text = "Deletar";
			this.btnDeletar.UseVisualStyleBackColor = true;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(47, 475);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(66, 23);
			this.btnAlterar.TabIndex = 31;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// FrmListaLivros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 534);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.txbTitulo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dgvListaLivros);
			this.Controls.Add(this.mtxbISBN);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FrmListaLivros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmListaLivros";
			this.Load += new System.EventHandler(this.FrmListaLivros_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaLivros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox mtxbISBN;
		private System.Windows.Forms.DataGridView dgvListaLivros;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnISBN;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnTitulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnAutor;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbTitulo;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.Button btnAlterar;
	}
}