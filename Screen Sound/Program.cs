//Criando um objeto para a música e Banda:
Banda imagineDragons = new Banda();
imagineDragons.Nome = "Imagine Dragons";

Musica musica1 = new Musica(imagineDragons);
Musica musica2 = new Musica(imagineDragons);
Musica musica3 = new Musica(imagineDragons);

//Instanciando as informações
musica1.Nome = "It´s Time";
musica1.Duracao = 200;
musica1.Disponivel = true;

musica2.Nome = "Radioactive";
musica2.Duracao = 120;
musica2.Disponivel = false;

musica3.Nome = "Demons";
musica3.Duracao = 120;
musica3.Disponivel = true;

Album album = new Album();

album.Nome = "Night Visions";

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

