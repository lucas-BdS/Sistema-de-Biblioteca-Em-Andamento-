
namespace View
{
	partial class FrmCadLivro
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pcbCapa = new System.Windows.Forms.PictureBox();
			this.btnUpload = new System.Windows.Forms.Button();
			this.mtxbISBN = new System.Windows.Forms.MaskedTextBox();
			this.txbEditora = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txbAutor = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txbTitulo = new System.Windows.Forms.TextBox();
			this.nudPaginas = new System.Windows.Forms.NumericUpDown();
			this.nudAnoLancamento = new System.Windows.Forms.NumericUpDown();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pcbCapa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAnoLancamento)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(166, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "ISBN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(150, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 14;
			this.label2.Text = "Editora";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(163, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 21);
			this.label3.TabIndex = 15;
			this.label3.Text = "Título";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(144, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 21);
			this.label4.TabIndex = 16;
			this.label4.Text = "Páginas";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(41, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 21);
			this.label5.TabIndex = 17;
			this.label5.Text = "Capa";
			// 
			// pcbCapa
			// 
			this.pcbCapa.Location = new System.Drawing.Point(15, 30);
			this.pcbCapa.Name = "pcbCapa";
			this.pcbCapa.Size = new System.Drawing.Size(100, 150);
			this.pcbCapa.TabIndex = 18;
			this.pcbCapa.TabStop = false;
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(15, 186);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(75, 30);
			this.btnUpload.TabIndex = 19;
			this.btnUpload.Text = "Upload";
			this.btnUpload.UseVisualStyleBackColor = true;
			// 
			// mtxbISBN
			// 
			this.mtxbISBN.Location = new System.Drawing.Point(220, 30);
			this.mtxbISBN.Mask = "000-0-00-000000-0";
			this.mtxbISBN.Name = "mtxbISBN";
			this.mtxbISBN.Size = new System.Drawing.Size(128, 22);
			this.mtxbISBN.TabIndex = 20;
			// 
			// txbEditora
			// 
			this.txbEditora.Location = new System.Drawing.Point(220, 82);
			this.txbEditora.Name = "txbEditora";
			this.txbEditora.Size = new System.Drawing.Size(200, 22);
			this.txbEditora.TabIndex = 21;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(162, 135);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 21);
			this.label6.TabIndex = 22;
			this.label6.Text = "Autor";
			// 
			// txbAutor
			// 
			this.txbAutor.Location = new System.Drawing.Point(220, 134);
			this.txbAutor.Name = "txbAutor";
			this.txbAutor.Size = new System.Drawing.Size(200, 22);
			this.txbAutor.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(77, 283);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 21);
			this.label7.TabIndex = 24;
			this.label7.Text = "Ano Lançamento";
			// 
			// txbTitulo
			// 
			this.txbTitulo.Location = new System.Drawing.Point(220, 186);
			this.txbTitulo.Name = "txbTitulo";
			this.txbTitulo.Size = new System.Drawing.Size(200, 22);
			this.txbTitulo.TabIndex = 25;
			// 
			// nudPaginas
			// 
			this.nudPaginas.Location = new System.Drawing.Point(220, 230);
			this.nudPaginas.Name = "nudPaginas";
			this.nudPaginas.Size = new System.Drawing.Size(200, 22);
			this.nudPaginas.TabIndex = 26;
			// 
			// nudAnoLancamento
			// 
			this.nudAnoLancamento.Location = new System.Drawing.Point(220, 282);
			this.nudAnoLancamento.Name = "nudAnoLancamento";
			this.nudAnoLancamento.Size = new System.Drawing.Size(200, 22);
			this.nudAnoLancamento.TabIndex = 27;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCancelar.Location = new System.Drawing.Point(432, 324);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(80, 30);
			this.btnCancelar.TabIndex = 29;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCadastrar.Location = new System.Drawing.Point(333, 324);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(93, 30);
			this.btnCadastrar.TabIndex = 28;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// FrmCadLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 365);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.nudAnoLancamento);
			this.Controls.Add(this.nudPaginas);
			this.Controls.Add(this.txbTitulo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txbAutor);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txbEditora);
			this.Controls.Add(this.mtxbISBN);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.pcbCapa);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmCadLivro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Formulário de Cadastro de Livro";
			((System.ComponentModel.ISupportInitialize)(this.pcbCapa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAnoLancamento)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pcbCapa;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.MaskedTextBox mtxbISBN;
		private System.Windows.Forms.TextBox txbEditora;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txbAutor;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txbTitulo;
		private System.Windows.Forms.NumericUpDown nudPaginas;
		private System.Windows.Forms.NumericUpDown nudAnoLancamento;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnCadastrar;
	}
}