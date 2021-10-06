
namespace View
{
	partial class FrmCadReserva
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.mtxbISBN = new System.Windows.Forms.MaskedTextBox();
			this.txbIDLeitor = new System.Windows.Forms.TextBox();
			this.mtxbData = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mtxbHora = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "ISBN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 21);
			this.label2.TabIndex = 14;
			this.label2.Text = "ID Leitor";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCancelar.Location = new System.Drawing.Point(271, 233);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(80, 27);
			this.btnCancelar.TabIndex = 21;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F);
			this.btnCadastrar.Location = new System.Drawing.Point(175, 233);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(90, 27);
			this.btnCadastrar.TabIndex = 20;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			// 
			// mtxbISBN
			// 
			this.mtxbISBN.Location = new System.Drawing.Point(94, 29);
			this.mtxbISBN.Mask = "000-0-00-000000-0";
			this.mtxbISBN.Name = "mtxbISBN";
			this.mtxbISBN.Size = new System.Drawing.Size(150, 22);
			this.mtxbISBN.TabIndex = 23;
			// 
			// txbIDLeitor
			// 
			this.txbIDLeitor.Location = new System.Drawing.Point(94, 82);
			this.txbIDLeitor.Name = "txbIDLeitor";
			this.txbIDLeitor.Size = new System.Drawing.Size(122, 22);
			this.txbIDLeitor.TabIndex = 24;
			// 
			// mtxbData
			// 
			this.mtxbData.Location = new System.Drawing.Point(94, 134);
			this.mtxbData.Mask = "00/00/0000";
			this.mtxbData.Name = "mtxbData";
			this.mtxbData.Size = new System.Drawing.Size(150, 22);
			this.mtxbData.TabIndex = 25;
			this.mtxbData.ValidatingType = typeof(System.DateTime);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(43, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 21);
			this.label3.TabIndex = 26;
			this.label3.Text = "Data";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(41, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 21);
			this.label4.TabIndex = 27;
			this.label4.Text = "Hora";
			// 
			// mtxbHora
			// 
			this.mtxbHora.Location = new System.Drawing.Point(93, 186);
			this.mtxbHora.Mask = "90:00";
			this.mtxbHora.Name = "mtxbHora";
			this.mtxbHora.Size = new System.Drawing.Size(151, 22);
			this.mtxbHora.TabIndex = 28;
			this.mtxbHora.ValidatingType = typeof(System.DateTime);
			// 
			// FrmReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 271);
			this.Controls.Add(this.mtxbHora);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.mtxbData);
			this.Controls.Add(this.txbIDLeitor);
			this.Controls.Add(this.mtxbISBN);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmReserva";
			this.Text = "Reserva";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.MaskedTextBox mtxbISBN;
		private System.Windows.Forms.TextBox txbIDLeitor;
		private System.Windows.Forms.MaskedTextBox mtxbData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox mtxbHora;
	}
}