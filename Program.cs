// // 1 - Classe Autor:

// // Atributos: Nome (string), Nacionalidade (string).
// // Construtor para inicializar Nome e Nacionalidade.
// // Método MostrarInfo para exibir as informações do autor.

Console.WriteLine("Digite o nome do Autor");
string nome = Console.ReadLine();
Console.WriteLine("Digite sua nacionalidade");
string nacionalidade = Console.ReadLine();

Autor autor = new Autor(nome, nacionalidade);
autor.mostrarInfo();

// 2 - Classe Livro:

// Atributos: Titulo (string), Autor (Autor), Preco (double).
// Construtores:
// Um construtor que inicializa Titulo e Autor.
// Outro construtor que inicializa Titulo, Autor e Preco.
// Método MostrarInfo para exibir as informações do livro.
// Método sobrecarregado AplicarDesconto:
// Um método que aceita um double representando a porcentagem de desconto e aplica ao preço do livro.
// Outro método que aceita um int representando um valor fixo de desconto e aplica ao preço do livro.

Console.WriteLine("Digite o nome do Titulo");
string titulo = Console.ReadLine();
Console.WriteLine("Digite o preço do livro");
double preco = Convert.ToDouble(Console.ReadLine());

Livro livro = new Livro(titulo,autor,preco);
livro.mostrarInfo();
livro.AplicarDesconto(10.00);
livro.mostrarInfo();
livro.AplicarDesconto(10);
livro.mostrarInfo();
