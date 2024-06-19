// 2 - Classe Livro:

// Atributos: Titulo (string), Autor (Autor), Preco (double).
// Construtores:
// Um construtor que inicializa Titulo e Autor.
// Outro construtor que inicializa Titulo, Autor e Preco.
// Método MostrarInfo para exibir as informações do livro.
// Método sobrecarregado AplicarDesconto:
// Um método que aceita um double representando a porcentagem de desconto e aplica ao preço do livro.
// Outro método que aceita um int representando um valor fixo de desconto e aplica ao preço do livro.

public class Livro{
    string titulo;
    public Autor autor;
    double preco;

    public Livro(string titulo, Autor autor){
        this.titulo = titulo;
        this.autor = autor;
    }

    public Livro(string titulo, Autor autor, double preco){
        this.titulo = titulo; // recebe por parametro
        this.autor = autor;
        this.preco = preco;
    }

    public void mostrarInfo(){
        Console.WriteLine($"O livro com titulo {titulo}, autor {autor.nome} e preço {preco}");
    }

    public void AplicarDesconto(double valor){
        preco = preco - (preco * (valor/100));
    }
    public void AplicarDesconto(int valor){
        preco = preco - valor;
    }
}