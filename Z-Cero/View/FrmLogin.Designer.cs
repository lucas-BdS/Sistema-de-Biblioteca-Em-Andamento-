
namespace View
{
	partial class FrmLogin
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
			this.txb_Matricula = new System.Windows.Forms.TextBox();
			this.txb_Senha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Login = new System.Windows.Forms.Button();
			this.btn_Cancelar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txb_Matricula
			// 
			this.txb_Matricula.Location = new System.Drawing.Point(100, 85);
			this.txb_Matricula.Name = "txb_Matricula";
			this.txb_Matricula.Size = new System.Drawing.Size(200, 22);
			this.txb_Matricula.TabIndex = 0;
			// 
			// txb_Senha
			// 
			this.txb_Senha.Location = new System.Drawing.Point(100, 185);
			this.txb_Senha.Name = "txb_Senha";
			this.txb_Senha.PasswordChar = '*';
			this.txb_Senha.Size = new System.Drawing.Size(200, 22);
			this.txb_Senha.TabIndex = 1;
			this.txb_Senha.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(143, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Matrícula";
			// 
			// btn_Login
			// 
			this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Login.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Login.Location = new System.Drawing.Point(100, 243);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(80, 30);
			this.btn_Login.TabIndex = 4;
			this.btn_Login.Text = "Login";
			this.btn_Login.UseVisualStyleBackColor = true;
			// 
			// btn_Cancelar
			// 
			this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Cancelar.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cancelar.Location = new System.Drawing.Point(220, 243);
			this.btn_Cancelar.Name = "btn_Cancelar";
			this.btn_Cancelar.Size = new System.Drawing.Size(80, 30);
			this.btn_Cancelar.TabIndex = 5;
			this.btn_Cancelar.Text = "Cancelar";
			this.btn_Cancelar.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(158, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 29);
			this.label2.TabIndex = 6;
			this.label2.Text = "Senha";
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(382, 299);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Cancelar);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txb_Senha);
			this.Controls.Add(this.txb_Matricula);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txb_Matricula;
		private System.Windows.Forms.TextBox txb_Senha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Button btn_Cancelar;
		private System.Windows.Forms.Label label2;
	}
}