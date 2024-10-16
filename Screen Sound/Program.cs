//Criando um objeto para a música:
Musica musica1 = new Musica();
Musica musica2 = new Musica();

//Instanciando as informações
musica1.nome = "If We Have Eachother";
musica1.artista = "Alec Benjamin";
musica1.duracao = 3;
musica1.EscreveDisponivel(true);
musica1.LeDisponivel();

musica2.nome = "Bad Liar";
musica2.artista = "Imagine Dragons";
musica2.duracao = 3;
musica2.EscreveDisponivel(false);
musica2.LeDisponivel();

//Exibindo as informações pelo método

musica1.ExibirFichaTecnica();
Console.WriteLine("\n");
musica2.ExibirFichaTecnica();
