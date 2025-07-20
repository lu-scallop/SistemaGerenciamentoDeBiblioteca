using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeBiblioteca
{
    public class Membro
    {
        public List<Livro> HistoricoDeEmprestimo { get; set; }
        public bool DisponivelParaPegarEmprestado {  get; set; }

    }
}
