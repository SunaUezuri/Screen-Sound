
//Screen Sound
string mensagemDeBoasVindas = "Bem-vindo ao Screen Sound!";

/*Criando uma lista para as bandas
List<string> bandas = new List<string> { "Set it Off", "Imagine Dragons", "Aestheria"};
*/

//Criando um dicionário de listas
Dictionary<string, List<int>> bandasDict = new Dictionary<string, List<int>>();

//Adicionando bandas
bandasDict.Add("Imagine Dragons", new List<int> { 10, 8, 9 });
bandasDict.Add("Set it Off", new List<int>());

//Criando uma função que irá reaproveitar as linhas.
void ExibirLogo()
{
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

//Criando a função para exibir as opções do menu
void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para listar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média uma banda");
    Console.WriteLine("Digite -1 para sair");


    //Pedindo um input do usuário
    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!); //! = Neste caso impede que o usuário insira um valor nulo


    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;

        case 2:
            MostrarBandas();
            break;

        case 3:
            AvaliarBanda();
            break;

        case 4:
            ExibirMedia();
            break;

        case -1:
            Console.WriteLine("Operação cancelada!");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

//Criando a função para registrar uma banda
void RegistrarBanda()
{
    //Comando para limpar o console
    Console.Clear();

    Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string banda = Console.ReadLine()!;


    //Adicionando o conteúdo em um dicionário
    bandasDict.Add(banda, new List<int>());

    Console.WriteLine($"\nA banda {banda} foi registrada com sucesso!");

    /*Função para dar uma pausa e limpar o console retornando para o menu
     * Após a operação
    */
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

//Função para mostrar as bandas registradas
void MostrarBandas()
{
    Console.Clear();

    Console.WriteLine(@"
█▀▀ ▀▄▀ █ █▄▄ █ █▀▀ ▄▀█ █▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
██▄ █░█ █ █▄█ █ █▄▄ █▀█ █▄█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");


    //Utilizando o "foreach" para exibir as chaves do dicionário
    foreach (string banda in bandasDict.Keys)
    {
        Console.WriteLine($"\nBanda: {banda}");
    }


    Console.WriteLine("\nDigite uma tecla para voltar para o menu inicial.");

    //Comando para digitar uma tecla e ser redirecionado para o menu
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

//Função para exibir o título da opção
void ExibirOpcao(string titulo)
{
    int qntLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qntLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

//Função para avaliar uma banda
void AvaliarBanda()
{
    /*Digite a banda que deseja avaliar
     se a banda existir no dicionário -> avaliar a banda
    senão, volta ao menu pricipal
     */

    Console.Clear();
    ExibirOpcao("Avaliando Bandas");
    Console.Write("Coloque a banda que deseja avaliar");

    string nomeBanda = Console.ReadLine()!;

    //Vendo se existe a chave
    if (bandasDict.ContainsKey(nomeBanda))
    {
        Console.Write($"\nQual nota que a banda {nomeBanda} merece?: ");

        int nota = int.Parse(Console.ReadLine()!);

        if (nota > 10)
        {
            Console.WriteLine("Não pode se atribuir uma nota maior que 10");
        }
        else
        {
            bandasDict[nomeBanda].Add(nota);
            Console.WriteLine($"\nA nota foi registrada com sucesso para a banda {nomeBanda}");
        }

        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

//Função para exibir a média de notas da banda
void ExibirMedia()
{
    Console.Clear();
    ExibirOpcao("Média de notas");

    //Pedindo a banda que o usuário deseja ver a média de notas
    Console.Write("Insira o nome da banda: ");

    string banda = Console.ReadLine()!;

    //Verificando se a banda existe
    if (bandasDict.ContainsKey(banda))
    {
        double media = bandasDict[banda].Average();

        Console.WriteLine($"\nA média de notas da banda {banda} é {media}");

        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {banda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

//Chamando a Função
ExibirMenu();