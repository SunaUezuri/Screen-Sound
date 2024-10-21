//Criando um objeto para a música e Banda:
Banda imagineDragons = new Banda("Imagine Dragons");

//Criando a classe música e inserindo suas informações pelo construtor
Musica musica1 = new Musica(imagineDragons, "It´s Time")
{
    //Utiliza-se este tipo de dado para quando as informações não são obrigatórias
    Duracao = 200,
    Disponivel = true
};


Musica musica2 = new Musica(imagineDragons, "Radioactive") 
{ 
    Disponivel = true,
    Duracao = 358
};

Musica musica3 = new Musica(imagineDragons, "Demons")
{
    Duracao = 258,
    Disponivel = false
};

Album album = new Album("Night Visions");

//Adicionando músicas no álbum
album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);
album.AdicionarMusica(musica3);

//Exibindo as músicas do albúm
album.ExibirMusicasDoAlbum();

Console.WriteLine("\n");

//Adicionando e exibindo um álbum na classe banda
imagineDragons.AdicionarAlbum(album);
imagineDragons.ExibirDiscografia();

//Exibindo a ficha técnica das músicas
Console.WriteLine("\n");
musica1.ExibirFichaTecnica();
Console.WriteLine("\n");
musica2.ExibirFichaTecnica();
Console.WriteLine("\n");
musica3.ExibirFichaTecnica();

