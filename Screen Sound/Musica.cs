
//Estrutura de uma classe C#
public class Musica
{

    //Criando o construtor da classe
    public Musica(Banda artista)
    {
        Artista = artista;
    }

    public string Nome { get; set; }
    public Banda Artista { get;  }
    public int Duracao { get; set; }

    /*
     Ao utilizar get e set o padrão de nomenclatura muda para
    PascalCase já que ele se torna uma Propriedade
     */
    public bool Disponivel {  get; set; }

    public string NomeCompleto { get; set; }

    //Método para exibir as informações da classe
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Música disponível no plano!");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+.");
        }
        
    }
}
