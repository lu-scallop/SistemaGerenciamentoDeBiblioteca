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
using SistemaGerenciamentoDeBiblioteca.Views;

namespace SistemaGerenciamentoDeBiblioteca.Views
{
	/// <summary>
	/// Lógica interna para Login.xaml
	/// </summary>
	public partial class Login : Window
	{
		MainWindow main = new MainWindow();
		public Login()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Em desenvolvimento... Clique em Admin");
        }

		private void AdminLabel_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
			main.Show();
		}
    }
}
