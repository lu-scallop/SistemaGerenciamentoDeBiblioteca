using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistemaGerenciamentoDeBiblioteca.Views
{
	/// <summary>
	/// Lógica interna para CadastroMembro.xaml
	/// </summary>
	public partial class CadastroMembro : Window
	{
		public CadastroMembro()
		{
			InitializeComponent();
			CarregarComboBox();
		}

		private void CarregarComboBox()
		{
			var unidadesFederativas = new List<string>
			{
				"SC",
				"PA",
				"MG"

			};

			cmbBoxUnidadesFedrativas.ItemsSource = unidadesFederativas;

		}
		
	}
}
