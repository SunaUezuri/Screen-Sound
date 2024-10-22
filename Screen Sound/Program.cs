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

//Instanciando as classes em questão
Episodio episodio1 = new Episodio(1, "A vida de um estudante de T.I", 2.5);

Episodio episodio2 = new Episodio(2, "Como é programar em JAVA", 4);



//Adicionando um convidado ao episódio
episodio1.AdicionarConvidados("Wesley");
episodio2.AdicionarConvidados("Samara");

Podcast podcast = new Podcast("Leandro Figueira", "A vida em códigos");

//Adicionando os episódios:
podcast.AdicionarEpisodios(episodio1);
podcast.AdicionarEpisodios(episodio2);

//Exibindo os detalhes do episódio
Console.WriteLine(episodio1.Resumo);
Console.WriteLine(episodio2.Resumo);

//Exibindo os detalhes do podcast:
podcast.ExibirDetalhes();


