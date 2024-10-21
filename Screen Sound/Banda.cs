public class Banda
{

    private List<Album> albums = new List<Album>();
    public string Nome { get; }

    //Construtor da classe banda:
    public Banda(string nome)
    {
        Nome = nome;
    }

    //Método para inserir Álbums na lista
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    //Método para exibir os albuns feitos
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");

        foreach(Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}