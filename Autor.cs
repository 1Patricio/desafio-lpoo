// // 1 - Classe Autor:

// // Atributos: Nome (string), Nacionalidade (string).
// // Construtor para inicializar Nome e Nacionalidade.
// // Método MostrarInfo para exibir as informações do autor.

public class Autor{
    public string nome;
    string nacionalidade;

    public Autor(string nome, string nacionalidade){
        this.nome = nome;
        this.nacionalidade = nacionalidade; 
    }
    public void mostrarInfo(){ //como não precisa ter retorno utilizamos void
        Console.WriteLine($"Nome: {this.nome} || Nacionalidade: {this.nacionalidade}");
    }
}