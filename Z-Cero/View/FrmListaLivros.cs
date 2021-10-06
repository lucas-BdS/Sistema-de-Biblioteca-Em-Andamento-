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
	public partial class FrmListaLivros : Form
	{
		public FrmListaLivros()
		{
			InitializeComponent();
		}

		private void FrmListaLivros_Load(object sender, EventArgs e)
		{
			try
			{
				Dictionary<Int64, Livro> mapaLivro = (Dictionary<Int64, Livro>)this.Tag;

				foreach (Livro livro in mapaLivro.Values)
				{
					dgvListaLivros.Rows.Add(livro.ID, livro.ISBN, livro.Titulo, livro.Autor, livro.Status);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao listar os livros cadastrados: " + ex.Message);
			}
		}
	}
}
