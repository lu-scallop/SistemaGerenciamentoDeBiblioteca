using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeBiblioteca
{
	public class Livro
	{
		public string Titulo { get; set; }
		public string Autor { get; set; }
		public string ISBN { get; set; }
		public int AnoPublicacao 
		{
			get 
			{ return AnoPublicacao; }
			set
			{
				int anoAtual = 2025;
                if (value > anoAtual)
                {
					Console.WriteLine("Ano inválido: O ano de publicação supera o ano atual");
                }
				else
				{
					AnoPublicacao = value;
				}

            } 
		}
		public bool Disponivel 
		{
			get{ return Disponivel;}
			set
			{
				Disponivel = true;
			}
		}

		public Livro(string titulo, string autor, string isbn,
			int anoDePublicacao, bool disponivel)
		{
			Titulo = titulo;
			Autor = autor;
			ISBN = isbn;
			AnoPublicacao = anoDePublicacao;
			Disponivel = disponivel;
		}

		public bool Emprestar(Livro livro)
		{
			return livro.Disponivel = (livro.Disponivel == true) ? true : false;
        }
		public bool Devolver(Livro livro)
		{
			return livro.Disponivel = (livro.Disponivel == false) ? false : true;
		}
		public string ObterInformacoes(Livro livro)
		{
			string informacoes = String.Format("*INFORMAÇÕES DO LIVRO*"+
				                               "\nTítulo:{0}"+
											   "\nAutor:{1}"+
											   "\nISBN:{2}"+
											   "\nAno de Publicação: {3}"+
											   "\nDisponível:{4}",
											   livro.Titulo, livro.Autor, 
											   livro.ISBN, livro.AnoPublicacao, 
											   livro.Disponivel);
			return informacoes;
		}
	}
}
