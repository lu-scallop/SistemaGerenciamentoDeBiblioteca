using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeBiblioteca
{
	public class Usuario
	{
		public string Id { get; set; }
		public string Nome { get; set; }

		public int Idade { get; set; }

		public bool PodePegarLivroEmprestado { get; set; }
	}
}
