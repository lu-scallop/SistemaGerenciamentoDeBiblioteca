using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeBiblioteca
{
	public class Membro : Usuario
	{
		public DateTime QuandoPegouLivroEmprestado { get; private set; }
		public bool PodePegarLivroEmprestado { get; private set; }
		public Livro QualLivroPossui { get; private set; }

		public void PegaLivroEmprestado(Livro livro)
		{
			if (livro.Disponivel == false && PodePegarLivroEmprestado == false)
			{
				Console.WriteLine($"O livro não está disponível ou o usuário {Nome} " +
					$"já pegou livro emprestado.");
				return;
			}
			else
			{
				QualLivroPossui = livro;
				Console.WriteLine($"O livro {livro.Titulo} foi emprestado a {Nome} com sucesso.");
			}

		}

		public void DevolveLivroEmprestado(Livro livro)
		{
			if (livro.Titulo == QualLivroPossui.Titulo)
			{
				QualLivroPossui = null;
			}
		}
	}
}
