using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
	public partial class FrmPrincipal : Form
	{

		private Dictionary<Int64, Livro> mapaLivro;

		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{
			FrmLogin frmLogin = new FrmLogin();

			this.Hide();

			if (frmLogin.ShowDialog() == DialogResult.OK)
			{

			}
			else
			{

			}
		}

		private void tsmiNovoLivro_Click_1(object sender, EventArgs e)
		{
			FrmCadLivro cadLivro = new FrmCadLivro();

			cadLivro.Tag = mapaLivro;

			cadLivro.ShowDialog();

			Livro livro = (Livro)cadLivro.Tag;

			mapaLivro.Add(livro.ID, livro);
		}

		private void tsmiListar_Click(object sender, EventArgs e)
		{
			FrmListaLivros listaLivros = new FrmListaLivros();

			listaLivros.Tag = mapaLivro;

			listaLivros.ShowDialog();
		}
	}
}
