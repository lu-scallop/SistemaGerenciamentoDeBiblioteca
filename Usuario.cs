using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeBiblioteca
{
	public class Usuario
	{
		public int Id { get; }
		public int NivelDeAcesso { get; private set; }
		public string Email { get; private set; }
		public string Senha { get; private set; }
		public string Nome { get; }
		public int Idade { get; private set; }
		public string Contato { get; private set; }

	}
		
}
