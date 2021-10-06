
using System;

namespace View
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsdbLivros = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsmiListar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBuscarLivro = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNovoLivro = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEditarLivro = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExcluirLivro = new System.Windows.Forms.ToolStripMenuItem();
			this.tsdbLeitores = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsmiListarLeitores = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBuscar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCadastrar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEditarLeitor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDeletarLeitor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsdbEmprestimo = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsmiListarEmprestimos = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEmprestimo = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiRenovar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsdbReserva = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsmiListaReserva = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNovaReserva = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEditarReserva = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdbLivros,
            this.tsdbLeitores,
            this.tsdbEmprestimo,
            this.tsdbReserva});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(145, 383);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsdbLivros
			// 
			this.tsdbLivros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdbLivros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListar,
            this.tsmiBuscarLivro,
            this.tsmiNovoLivro,
            this.tsmiEditarLivro,
            this.tsmiExcluirLivro});
			this.tsdbLivros.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
			this.tsdbLivros.Image = ((System.Drawing.Image)(resources.GetObject("tsdbLivros.Image")));
			this.tsdbLivros.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdbLivros.Name = "tsdbLivros";
			this.tsdbLivros.Size = new System.Drawing.Size(142, 28);
			this.tsdbLivros.Text = "Livros";
			// 
			// tsmiListar
			// 
			this.tsmiListar.Name = "tsmiListar";
			this.tsmiListar.Size = new System.Drawing.Size(224, 28);
			this.tsmiListar.Text = "Listar";
			this.tsmiListar.Click += new System.EventHandler(this.tsmiListar_Click);
			// 
			// tsmiBuscarLivro
			// 
			this.tsmiBuscarLivro.Name = "tsmiBuscarLivro";
			this.tsmiBuscarLivro.Size = new System.Drawing.Size(224, 28);
			this.tsmiBuscarLivro.Text = "Buscar Livro";
			// 
			// tsmiNovoLivro
			// 
			this.tsmiNovoLivro.Name = "tsmiNovoLivro";
			this.tsmiNovoLivro.Size = new System.Drawing.Size(224, 28);
			this.tsmiNovoLivro.Text = "Novo Livro";
			this.tsmiNovoLivro.Click += new System.EventHandler(this.tsmiNovoLivro_Click_1);
			// 
			// tsmiEditarLivro
			// 
			this.tsmiEditarLivro.Name = "tsmiEditarLivro";
			this.tsmiEditarLivro.Size = new System.Drawing.Size(224, 28);
			this.tsmiEditarLivro.Text = "Editar Livro";
			// 
			// tsmiExcluirLivro
			// 
			this.tsmiExcluirLivro.Name = "tsmiExcluirLivro";
			this.tsmiExcluirLivro.Size = new System.Drawing.Size(224, 28);
			this.tsmiExcluirLivro.Text = "Excluir Livro";
			// 
			// tsdbLeitores
			// 
			this.tsdbLeitores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdbLeitores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListarLeitores,
            this.tsmiBuscar,
            this.tsmiCadastrar,
            this.tsmiEditarLeitor,
            this.tsmiDeletarLeitor});
			this.tsdbLeitores.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
			this.tsdbLeitores.Image = ((System.Drawing.Image)(resources.GetObject("tsdbLeitores.Image")));
			this.tsdbLeitores.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdbLeitores.Name = "tsdbLeitores";
			this.tsdbLeitores.Size = new System.Drawing.Size(142, 28);
			this.tsdbLeitores.Text = "Leitores";
			// 
			// tsmiListarLeitores
			// 
			this.tsmiListarLeitores.Name = "tsmiListarLeitores";
			this.tsmiListarLeitores.Size = new System.Drawing.Size(296, 28);
			this.tsmiListarLeitores.Text = "Listar";
			// 
			// tsmiBuscar
			// 
			this.tsmiBuscar.Name = "tsmiBuscar";
			this.tsmiBuscar.Size = new System.Drawing.Size(296, 28);
			this.tsmiBuscar.Text = "Buscar";
			// 
			// tsmiCadastrar
			// 
			this.tsmiCadastrar.Name = "tsmiCadastrar";
			this.tsmiCadastrar.Size = new System.Drawing.Size(296, 28);
			this.tsmiCadastrar.Text = "Cadastrar Leitor";
			// 
			// tsmiEditarLeitor
			// 
			this.tsmiEditarLeitor.Name = "tsmiEditarLeitor";
			this.tsmiEditarLeitor.Size = new System.Drawing.Size(296, 28);
			this.tsmiEditarLeitor.Text = "Editar Dados de Leitor";
			// 
			// tsmiDeletarLeitor
			// 
			this.tsmiDeletarLeitor.Name = "tsmiDeletarLeitor";
			this.tsmiDeletarLeitor.Size = new System.Drawing.Size(296, 28);
			this.tsmiDeletarLeitor.Text = "Exluir Leitor";
			// 
			// tsdbEmprestimo
			// 
			this.tsdbEmprestimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdbEmprestimo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListarEmprestimos,
            this.tsmiEmprestimo,
            this.tsmiRenovar});
			this.tsdbEmprestimo.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
			this.tsdbEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("tsdbEmprestimo.Image")));
			this.tsdbEmprestimo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdbEmprestimo.Name = "tsdbEmprestimo";
			this.tsdbEmprestimo.Size = new System.Drawing.Size(142, 28);
			this.tsdbEmprestimo.Text = "Empréstimos";
			// 
			// tsmiListarEmprestimos
			// 
			this.tsmiListarEmprestimos.Name = "tsmiListarEmprestimos";
			this.tsmiListarEmprestimos.Size = new System.Drawing.Size(285, 28);
			this.tsmiListarEmprestimos.Text = "Listar";
			// 
			// tsmiEmprestimo
			// 
			this.tsmiEmprestimo.Name = "tsmiEmprestimo";
			this.tsmiEmprestimo.Size = new System.Drawing.Size(285, 28);
			this.tsmiEmprestimo.Text = "Novo Emprestimo";
			// 
			// tsmiRenovar
			// 
			this.tsmiRenovar.Name = "tsmiRenovar";
			this.tsmiRenovar.Size = new System.Drawing.Size(285, 28);
			this.tsmiRenovar.Text = "Renovar Empréstimo";
			// 
			// tsdbReserva
			// 
			this.tsdbReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdbReserva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListaReserva,
            this.tsmiNovaReserva,
            this.tsmiEditarReserva});
			this.tsdbReserva.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
			this.tsdbReserva.Image = ((System.Drawing.Image)(resources.GetObject("tsdbReserva.Image")));
			this.tsdbReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdbReserva.Name = "tsdbReserva";
			this.tsdbReserva.Size = new System.Drawing.Size(142, 28);
			this.tsdbReserva.Text = "Reservas";
			// 
			// tsmiListaReserva
			// 
			this.tsmiListaReserva.Name = "tsmiListaReserva";
			this.tsmiListaReserva.Size = new System.Drawing.Size(273, 28);
			this.tsmiListaReserva.Text = "Listar";
			// 
			// tsmiNovaReserva
			// 
			this.tsmiNovaReserva.Name = "tsmiNovaReserva";
			this.tsmiNovaReserva.Size = new System.Drawing.Size(273, 28);
			this.tsmiNovaReserva.Text = "Nova Reserva";
			// 
			// tsmiEditarReserva
			// 
			this.tsmiEditarReserva.Name = "tsmiEditarReserva";
			this.tsmiEditarReserva.Size = new System.Drawing.Size(273, 28);
			this.tsmiEditarReserva.Text = "Editar uma Reserva";
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 383);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formulário Principal";
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void tsmiNovoLivro_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton tsdbLivros;
		private System.Windows.Forms.ToolStripMenuItem tsmiListar;
		private System.Windows.Forms.ToolStripMenuItem tsmiNovoLivro;
		private System.Windows.Forms.ToolStripMenuItem tsmiEditarLivro;
		private System.Windows.Forms.ToolStripMenuItem tsmiExcluirLivro;
		private System.Windows.Forms.ToolStripDropDownButton tsdbLeitores;
		private System.Windows.Forms.ToolStripMenuItem tsmiListarLeitores;
		private System.Windows.Forms.ToolStripMenuItem tsmiCadastrar;
		private System.Windows.Forms.ToolStripMenuItem tsmiEditarLeitor;
		private System.Windows.Forms.ToolStripMenuItem tsmiDeletarLeitor;
		private System.Windows.Forms.ToolStripDropDownButton tsdbEmprestimo;
		private System.Windows.Forms.ToolStripMenuItem tsmiListarEmprestimos;
		private System.Windows.Forms.ToolStripMenuItem tsmiEmprestimo;
		private System.Windows.Forms.ToolStripMenuItem tsmiBuscarLivro;
		private System.Windows.Forms.ToolStripMenuItem tsmiBuscar;
		private System.Windows.Forms.ToolStripMenuItem tsmiRenovar;
		private System.Windows.Forms.ToolStripDropDownButton tsdbReserva;
		private System.Windows.Forms.ToolStripMenuItem tsmiListaReserva;
		private System.Windows.Forms.ToolStripMenuItem tsmiNovaReserva;
		private System.Windows.Forms.ToolStripMenuItem tsmiEditarReserva;
	}
}

