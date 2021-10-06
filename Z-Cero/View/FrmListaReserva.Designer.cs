
namespace View
{
	partial class FrmListaReserva
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
			this.dgvReservas = new System.Windows.Forms.DataGridView();
			this.columnISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mtxbISBN = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txbCPF = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnBaixar = new System.Windows.Forms.Button();
			this.btnExtender = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvReservas
			// 
			this.dgvReservas.AllowUserToAddRows = false;
			this.dgvReservas.AllowUserToDeleteRows = false;
			this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnISBN,
            this.columnCPF,
            this.columnDevolucao});
			this.dgvReservas.Location = new System.Drawing.Point(60, 93);
			this.dgvReservas.Name = "dgvReservas";
			this.dgvReservas.ReadOnly = true;
			this.dgvReservas.RowHeadersVisible = false;
			this.dgvReservas.RowHeadersWidth = 51;
			this.dgvReservas.RowTemplate.Height = 24;
			this.dgvReservas.Size = new System.Drawing.Size(503, 301);
			this.dgvReservas.TabIndex = 29;
			// 
			// columnISBN
			// 
			this.columnISBN.HeaderText = "ISBN";
			this.columnISBN.MinimumWidth = 6;
			this.columnISBN.Name = "columnISBN";
			this.columnISBN.ReadOnly = true;
			this.columnISBN.Width = 150;
			// 
			// columnCPF
			// 
			this.columnCPF.HeaderText = "CPF";
			this.columnCPF.MinimumWidth = 6;
			this.columnCPF.Name = "columnCPF";
			this.columnCPF.ReadOnly = true;
			this.columnCPF.Width = 150;
			// 
			// columnDevolucao
			// 
			this.columnDevolucao.HeaderText = "Data Devolução";
			this.columnDevolucao.MinimumWidth = 6;
			this.columnDevolucao.Name = "columnDevolucao";
			this.columnDevolucao.ReadOnly = true;
			this.columnDevolucao.Width = 200;
			// 
			// mtxbISBN
			// 
			this.mtxbISBN.Location = new System.Drawing.Point(113, 12);
			this.mtxbISBN.Mask = "000-0-00-000000-0";
			this.mtxbISBN.Name = "mtxbISBN";
			this.mtxbISBN.Size = new System.Drawing.Size(128, 22);
			this.mtxbISBN.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(59, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 21);
			this.label1.TabIndex = 30;
			this.label1.Text = "ISBN";
			// 
			// txbCPF
			// 
			this.txbCPF.Location = new System.Drawing.Point(113, 49);
			this.txbCPF.Name = "txbCPF";
			this.txbCPF.Size = new System.Drawing.Size(209, 22);
			this.txbCPF.TabIndex = 33;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 21);
			this.label2.TabIndex = 32;
			this.label2.Text = "CPF";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(349, 49);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 34;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnBaixar
			// 
			this.btnBaixar.Location = new System.Drawing.Point(60, 411);
			this.btnBaixar.Name = "btnBaixar";
			this.btnBaixar.Size = new System.Drawing.Size(94, 29);
			this.btnBaixar.TabIndex = 35;
			this.btnBaixar.Text = "Baixar";
			this.btnBaixar.UseVisualStyleBackColor = true;
			// 
			// btnExtender
			// 
			this.btnExtender.Location = new System.Drawing.Point(160, 411);
			this.btnExtender.Name = "btnExtender";
			this.btnExtender.Size = new System.Drawing.Size(94, 29);
			this.btnExtender.TabIndex = 36;
			this.btnExtender.Text = "Extender";
			this.btnExtender.UseVisualStyleBackColor = true;
			// 
			// FrmListaReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 477);
			this.Controls.Add(this.btnExtender);
			this.Controls.Add(this.btnBaixar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txbCPF);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mtxbISBN);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvReservas);
			this.Name = "FrmListaReserva";
			this.Text = "FrmListaReserva";
			((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvReservas;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnISBN;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnCPF;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnDevolucao;
		private System.Windows.Forms.MaskedTextBox mtxbISBN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbCPF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnBaixar;
		private System.Windows.Forms.Button btnExtender;
	}
}