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

			int anoAtual = DateTime.Now.Year;
            if (anoPublicacao > anoAtual || anoPublicacao <= 0)
            {
				Console.WriteLine("Ano inválido! Ano de publicação alterada para ano atual");
				AnoPublicacao = anoAtual;
            }
            else
            {
				AnoPublicacao = anoPublicacao;
            }
            Disponivel = true;
		}

		public bool Emprestar()
		{
            if (Disponivel)
            {
				Disponivel = false;
				Console.WriteLine("Livro emprestado!");
				return true;
            }
			else 
			{
				Console.WriteLine("Erro: Esse livro já foi emprestado");
				return false;
			}
        }
		public bool Devolver(Livro livro)
		{
            if (!Disponivel)
            {
				Disponivel = true;
				Console.WriteLine("O livro foi devolvido com sucesso! Obrigado!");
				return true;
            }
            else
            {
                Console.WriteLine("Erro: O livro já está disponível!");
				return false;
            }
        }
		public string ObterInformacoes()
		{
			string statusDisponibilidade = Disponivel ? "Sim" : "Não";
			return $"*INFORMAÇÕES DO LIVRO*\n"+
					$"Título: {Titulo}\n"+
					$"Autor: {Autor}\n"+
					$"ISBN: {ISBN}\n"+
					$"Ano de Publicação: {AnoPublicacao}\n"+
					$"Disponível: {statusDisponibilidade}";
		}
	}
}
