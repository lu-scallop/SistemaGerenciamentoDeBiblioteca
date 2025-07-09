namespace SistemaGerenciamentoDeBiblioteca
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Livro> listaDeLivros = new List<Livro>();

			listaDeLivros.Add(new Livro("O Senhor dos Aneis", "Tolkien", "978-65-89999-01-3", 1954, true));
			listaDeLivros.Add(new Livro("1984", "George Orwell", "978-85-359-0275-2", 1949, true));
			listaDeLivros.Add(new Livro("Orgulho e Preconceito", "Jane Austen", "978-85-316-0189-7", 1813, false));
			listaDeLivros.Add(new Livro("Cem Anos de Solidão", "Gabriel García Márquez", "978-85-01-01256-4", 1967, true));
			listaDeLivros.Add(new Livro("Dom Quixote", "Miguel de Cervantes", "978-85-7971-057-0", 1605, false));
			listaDeLivros.Add(new Livro("A Revolução dos Bichos", "George Orwell", "978-85-359-0276-9", 1945, true));
			listaDeLivros.Add(new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", "978-85-7232-472-7", 1943, true));
			listaDeLivros.Add(new Livro("Crime e Castigo", "Fiódor Dostoiévski", "978-85-7326-170-1", 1866, false));
			listaDeLivros.Add(new Livro("Ulisses", "James Joyce", "978-85-7164-672-8", 1922, false));
			listaDeLivros.Add(new Livro("Moby Dick", "Herman Melville", "978-85-7971-032-7", 1851, true));
			listaDeLivros.Add(new Livro("A Metamorfose", "Franz Kafka", "978-85-7232-601-1", 1915, true));
		}
	}
}
