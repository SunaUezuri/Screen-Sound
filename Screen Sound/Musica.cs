
//Estrutura de uma classe C#
public class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    //Método para receber o disponível que agora está privado
    public void EscreveDisponivel(bool valor)
    {
        disponivel = valor;
    }

    //Método para retornar o valor do disponível
    public bool LeDisponivel()
    {
        return disponivel;
    }

    //Método para exibir as informações da classe
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Música disponível no plano!");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+.");
        }
        
    }
}
