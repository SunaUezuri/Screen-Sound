
//Estrutura de uma classe C#
public class Musica
{
    public string nome;
    public string artista;
    public int duracao;

    /*
     Ao utilizar get e set o padrão de nomenclatura muda para
    PascalCase já que ele se torna uma Propriedade
     */
    public bool Disponivel {  get; set; }

    //Método para exibir as informações da classe
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
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
