//Criando um objeto para a música:
Musica musica1 = new Musica();
Musica musica2 = new Musica();

//Instanciando as informações
musica1.nome = "If We Have Eachother";
musica1.artista = "Alec Benjamin";
musica1.duracao = 3;
musica1.disponivel = true;

musica2.nome = "Bad Liar";
musica2.artista = "Imagine Dragons";

Console.WriteLine($"Nome da música: {musica1.nome}");
Console.WriteLine($"Nome do artista: {musica1.artista}");
Console.WriteLine($"Duração: {musica1.duracao} minutos");
Console.WriteLine($"Disponível em streamings?: {musica1.disponivel}");

Console.WriteLine($"\nNome da música: {musica2.nome}");
Console.WriteLine($"Nome do artista: {musica2.artista}");