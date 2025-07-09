using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeBiblioteca
{
	public class Livro
	{
		public string Titulo { get; private set; }
		public string Autor { get; private set; }
		public string ISBN { get; }
		public int AnoPublicacao { get; private set; }
		public bool Disponivel { get; private set; }

		public Livro(string titulo, string autor, string isbn, 
			int anoPublicacao, bool disponivel)
		{
			Titulo = titulo;
			Autor = autor;
			ISBN = isbn;
			AnoPublicacao = anoPublicacao;
			Disponivel = disponivel;
		}
	}
}
