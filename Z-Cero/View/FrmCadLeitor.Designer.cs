
namespace View
{
	partial class FrmCadLeitor
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txbEmail = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txbSobrenome = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnUpload = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.mtxbNascimento = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mtxbCPF = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbNome = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txbLogradouro = new System.Windows.Forms.TextBox();
			this.lbxTipoEnd = new System.Windows.Forms.ListBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txbEmail);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txbSobrenome);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.btnUpload);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.mtxbNascimento);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.mtxbCPF);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txbNome);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(669, 211);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Principais";
			// 
			// txbEmail
			// 
			this.txbEmail.Location = new System.Drawing.Point(163, 163);
			this.txbEmail.Name = "txbEmail";
			this.txbEmail.Size = new System.Drawing.Size(141, 22);
			this.txbEmail.TabIndex = 21;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(159, 139);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 21);
			this.label10.TabIndex = 20;
			this.label10.Text = "Email";
			// 
			// txbSobrenome
			// 
			this.txbSobrenome.Location = new System.Drawing.Point(347, 105);
			this.txbSobrenome.Name = "txbSobrenome";
			this.txbSobrenome.Size = new System.Drawing.Size(150, 22);
			this.txbSobrenome.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(343, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 21);
			this.label4.TabIndex = 18;
			this.label4.Text = "Sobrenome";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(11, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 136);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(10, 163);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(75, 30);
			this.btnUpload.TabIndex = 6;
			this.btnUpload.Text = "Upload";
			this.btnUpload.UseVisualStyleBackColor = true;
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
			// mtxbNascimento
			// 
			this.mtxbNascimento.Location = new System.Drawing.Point(347, 45);
			this.mtxbNascimento.Mask = "00/00/0000";
			this.mtxbNascimento.Name = "mtxbNascimento";
			this.mtxbNascimento.Size = new System.Drawing.Size(96, 22);
			this.mtxbNascimento.TabIndex = 9;
			this.mtxbNascimento.ValidatingType = typeof(System.DateTime);
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
			// mtxbCPF
			// 
			this.mtxbCPF.Location = new System.Drawing.Point(163, 45);
			this.mtxbCPF.Mask = "000,000,000-00";
			this.mtxbCPF.Name = "mtxbCPF";
			this.mtxbCPF.Size = new System.Drawing.Size(110, 22);
			this.mtxbCPF.TabIndex = 7;
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
			// txbNome
			// 
			this.txbNome.Location = new System.Drawing.Point(163, 105);
			this.txbNome.Name = "txbNome";
			this.txbNome.Size = new System.Drawing.Size(150, 22);
			this.txbNome.TabIndex = 8;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.mtbCelular);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.mtbCEP);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txbLogradouro);
			this.groupBox2.Controls.Add(this.lbxTipoEnd);
			this.groupBox2.Location = new System.Drawing.Point(12, 229);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(669, 163);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Endereço";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(411, 95);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 21);
			this.label9.TabIndex = 23;
			this.label9.Text = "Celular";
			// 
			// mtbCelular
			// 
			this.mtbCelular.Location = new System.Drawing.Point(415, 119);
			this.mtbCelular.Mask = "(00) 0 0000-0000";
			this.mtbCelular.Name = "mtbCelular";
			this.mtbCelular.Size = new System.Drawing.Size(120, 22);
			this.mtbCelular.TabIndex = 22;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(411, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 21);
			this.label8.TabIndex = 21;
			this.label8.Text = "CEP";
			// 
			// mtbCEP
			// 
			this.mtbCEP.Location = new System.Drawing.Point(415, 57);
			this.mtbCEP.Mask = "00000-000";
			this.mtbCEP.Name = "mtbCEP";
			this.mtbCEP.Size = new System.Drawing.Size(120, 22);
			this.mtbCEP.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(159, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 21);
			this.label7.TabIndex = 19;
			this.label7.Text = "Logradouro";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 18;
			this.label6.Text = "Tipo de End.";
			// 
			// txbLogradouro
			// 
			this.txbLogradouro.Location = new System.Drawing.Point(163, 57);
			this.txbLogradouro.Multiline = true;
			this.txbLogradouro.Name = "txbLogradouro";
			this.txbLogradouro.Size = new System.Drawing.Size(200, 84);
			this.txbLogradouro.TabIndex = 1;
			// 
			// lbxTipoEnd
			// 
			this.lbxTipoEnd.FormattingEnabled = true;
			this.lbxTipoEnd.ItemHeight = 16;
			this.lbxTipoEnd.Items.AddRange(new object[] {
            "Rua",
            "Avenida",
            "Travessa",
            "Alameda",
            "Rodovia"});
			this.lbxTipoEnd.Location = new System.Drawing.Point(6, 57);
			this.lbxTipoEnd.Name = "lbxTipoEnd";
			this.lbxTipoEnd.Size = new System.Drawing.Size(120, 84);
			this.lbxTipoEnd.TabIndex = 0;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCadastrar.Location = new System.Drawing.Point(502, 398);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(93, 30);
			this.btnCadastrar.TabIndex = 21;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCancelar.Location = new System.Drawing.Point(601, 398);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(80, 30);
			this.btnCancelar.TabIndex = 22;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// FrmCadLeitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 434);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmCadLeitor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Formulário de Cadastro de Leitor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox mtxbNascimento;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox mtxbCPF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbNome;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.MaskedTextBox mtbCelular;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MaskedTextBox mtbCEP;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txbLogradouro;
		private System.Windows.Forms.ListBox lbxTipoEnd;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txbSobrenome;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbEmail;
		private System.Windows.Forms.Label label10;
	}
}