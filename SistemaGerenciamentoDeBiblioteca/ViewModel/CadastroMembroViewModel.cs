using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SistemaGerenciamentoDeBiblioteca.ViewModel
{
    public class CadastroMembroViewModel : INotifyPropertyChanged
    {
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf {  get; set; }

        public string Email { get; set; }
        public string Celular {  get; set; }
        public int Cep {  get; set; }

        public string Rua {  get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string TipoDeMembro { get; set; }

        public string Profissao { get; set; }

        public string Genero { get; set; }

        public ICommand CadastrarCommand { get; set; }

        public ICommand AtualizarCommand { get; set; }

        public ICommand VisualizarPerfilCommand { get; set; }

        public CadastroMembroViewModel()
        {
        }

		public event PropertyChangedEventHandler? PropertyChanged;
	}
}
