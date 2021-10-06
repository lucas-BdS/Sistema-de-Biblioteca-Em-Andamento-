
namespace View
{
	partial class FrmCadEmprestimo
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
			this.txbIDLivro = new System.Windows.Forms.TextBox();
			this.txbIDLeitor = new System.Windows.Forms.TextBox();
			this.mtxbDataDevolucao = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.mtxbDataEmprestimo = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txbIDLivro
			// 
			this.txbIDLivro.Location = new System.Drawing.Point(160, 30);
			this.txbIDLivro.Name = "txbIDLivro";
			this.txbIDLivro.Size = new System.Drawing.Size(200, 22);
			this.txbIDLivro.TabIndex = 18;
			// 
			// txbIDLeitor
			// 
			this.txbIDLeitor.Location = new System.Drawing.Point(160, 82);
			this.txbIDLeitor.Name = "txbIDLeitor";
			this.txbIDLeitor.Size = new System.Drawing.Size(200, 22);
			this.txbIDLeitor.TabIndex = 19;
			// 
			// mtxbDataDevolucao
			// 
			this.mtxbDataDevolucao.Location = new System.Drawing.Point(160, 186);
			this.mtxbDataDevolucao.Mask = "00/00/0000";
			this.mtxbDataDevolucao.Name = "mtxbDataDevolucao";
			this.mtxbDataDevolucao.Size = new System.Drawing.Size(96, 22);
			this.mtxbDataDevolucao.TabIndex = 20;
			this.mtxbDataDevolucao.ValidatingType = typeof(System.DateTime);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(84, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 21);
			this.label1.TabIndex = 21;
			this.label1.Text = "ID Livro";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(78, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 21);
			this.label2.TabIndex = 22;
			this.label2.Text = "ID Leitor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 21);
			this.label3.TabIndex = 23;
			this.label3.Text = "Data Devolução";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCancelar.Location = new System.Drawing.Point(280, 229);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(80, 30);
			this.btnCancelar.TabIndex = 26;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCadastrar.Location = new System.Drawing.Point(181, 229);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(93, 30);
			this.btnCadastrar.TabIndex = 25;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			// 
			// mtxbDataEmprestimo
			// 
			this.mtxbDataEmprestimo.Location = new System.Drawing.Point(160, 134);
			this.mtxbDataEmprestimo.Mask = "00/00/0000";
			this.mtxbDataEmprestimo.Name = "mtxbDataEmprestimo";
			this.mtxbDataEmprestimo.Size = new System.Drawing.Size(96, 22);
			this.mtxbDataEmprestimo.TabIndex = 27;
			this.mtxbDataEmprestimo.ValidatingType = typeof(System.DateTime);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 21);
			this.label4.TabIndex = 28;
			this.label4.Text = "Data Empréstimo";
			// 
			// FrmEmprestimo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 271);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.mtxbDataEmprestimo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mtxbDataDevolucao);
			this.Controls.Add(this.txbIDLeitor);
			this.Controls.Add(this.txbIDLivro);
			this.Name = "FrmEmprestimo";
			this.Text = "FrmEmprestimo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txbIDLivro;
		private System.Windows.Forms.TextBox txbIDLeitor;
		private System.Windows.Forms.MaskedTextBox mtxbDataDevolucao;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.MaskedTextBox mtxbDataEmprestimo;
		private System.Windows.Forms.Label label4;
	}
}