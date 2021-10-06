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
	public partial class FrmCadLivro : Form
	{
		public FrmCadLivro()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			Livro livro = new Livro();

			livro = CarregarDados();

			this.Tag = livro;

			this.Close();
			
		}

		private Livro CarregarDados()
		{
			Livro livro = new Livro();

			try
			{
				Dictionary<Int64, Livro> mapaLivro = (Dictionary<Int64, Livro>)this.Tag;

				Int64 isbn;

				isbn = Convert.ToInt64(mtxbISBN.Text.Replace("-", ""));

				if (mapaLivro.Count() == null)
				{
					livro.ID = 0;
				}
				else
				{
					livro.ID = mapaLivro.Count();
				}
				livro.ISBN = isbn;
				livro.Editora = txbEditora.Text;
				livro.Autor = txbAutor.Text;
				livro.Titulo = txbTitulo.Text;
				livro.Paginas = Convert.ToInt16(nudPaginas);
				livro.DataChegada = Convert.ToDateTime(DateTime.Today);
				livro.AnoLancamento = Convert.ToInt16(nudAnoLancamento);
				livro.Status = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar usuário para pessoa: " + ex.Message);
			}

			return livro;
		}
	}
}
