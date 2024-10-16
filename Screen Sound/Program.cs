//Criando um objeto para a música:
Musica musica1 = new Musica();
Musica musica2 = new Musica();

//Instanciando as informações
musica1.Nome = "If We Have Eachother";
musica1.Artista = "Alec Benjamin";
musica1.Duracao = 3;
musica1.Disponivel = true;

musica2.Nome = "Bad Liar";
musica2.Artista = "Imagine Dragons";
musica2.Duracao = 3;
musica2.Disponivel = false;

//Exibindo as informações pelo método

musica1.ExibirFichaTecnica();
Console.WriteLine("\n");
musica2.ExibirFichaTecnica();
