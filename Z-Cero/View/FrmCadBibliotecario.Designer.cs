
namespace View
{
	partial class FrmCadBibliotecario
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
			this.btnUpload = new System.Windows.Forms.Button();
			this.mtxbCPF = new System.Windows.Forms.MaskedTextBox();
			this.txbNome = new System.Windows.Forms.TextBox();
			this.mtxbNascimento = new System.Windows.Forms.MaskedTextBox();
			this.txbSenha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ckbMostrarSenhar = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(20, 163);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(75, 30);
			this.btnUpload.TabIndex = 6;
			this.btnUpload.Text = "Upload";
			this.btnUpload.UseVisualStyleBackColor = true;
			// 
			// mtxbCPF
			// 
			this.mtxbCPF.Location = new System.Drawing.Point(163, 45);
			this.mtxbCPF.Mask = "000,000,000-00";
			this.mtxbCPF.Name = "mtxbCPF";
			this.mtxbCPF.Size = new System.Drawing.Size(110, 22);
			this.mtxbCPF.TabIndex = 7;
			// 
			// txbNome
			// 
			this.txbNome.Location = new System.Drawing.Point(163, 105);
			this.txbNome.Name = "txbNome";
			this.txbNome.Size = new System.Drawing.Size(150, 22);
			this.txbNome.TabIndex = 8;
			// 
			// mtxbNascimento
			// 
			this.mtxbNascimento.Location = new System.Drawing.Point(347, 45);
			this.mtxbNascimento.Mask = "00/00/0000";
			this.mtxbNascimento.Name = "mtxbNascimento";
			this.mtxbNascimento.Size = new System.Drawing.Size(96, 22);
			this.mtxbNascimento.TabIndex = 9;
			this.mtxbNascimento.ValidatingType = typeof(System.DateTime);
			// 
			// txbSenha
			// 
			this.txbSenha.Location = new System.Drawing.Point(163, 167);
			this.txbSenha.Name = "txbSenha";
			this.txbSenha.Size = new System.Drawing.Size(150, 22);
			this.txbSenha.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(159, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 21);
			this.label1.TabIndex = 12;
			this.label1.Text = "CPF";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(159, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 21);
			this.label2.TabIndex = 13;
			this.label2.Text = "Nome";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(343, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 14;
			this.label3.Text = "Nascimento";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(159, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 21);
			this.label5.TabIndex = 16;
			this.label5.Text = "Senha";
			// 
			// ckbMostrarSenhar
			// 
			this.ckbMostrarSenhar.AutoSize = true;
			this.ckbMostrarSenhar.Location = new System.Drawing.Point(343, 163);
			this.ckbMostrarSenhar.Name = "ckbMostrarSenhar";
			this.ckbMostrarSenhar.Size = new System.Drawing.Size(128, 21);
			this.ckbMostrarSenhar.TabIndex = 17;
			this.ckbMostrarSenhar.Text = "Mostrar Senhar";
			this.ckbMostrarSenhar.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCancelar);
			this.groupBox1.Controls.Add(this.btnCadastrar);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.ckbMostrarSenhar);
			this.groupBox1.Controls.Add(this.btnUpload);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.mtxbNascimento);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txbSenha);
			this.groupBox1.Controls.Add(this.mtxbCPF);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txbNome);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(669, 222);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Principais";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(11, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 136);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCadastrar.Location = new System.Drawing.Point(487, 186);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(90, 30);
			this.btnCadastrar.TabIndex = 18;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCancelar.Location = new System.Drawing.Point(583, 186);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(80, 30);
			this.btnCancelar.TabIndex = 19;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// FrmCadBibliotecario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 246);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmCadBibliotecario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Formulário de Cadastro de Bibliotecario";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.MaskedTextBox mtxbCPF;
		private System.Windows.Forms.TextBox txbNome;
		private System.Windows.Forms.MaskedTextBox mtxbNascimento;
		private System.Windows.Forms.TextBox txbSenha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox ckbMostrarSenhar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnCadastrar;
	}
}