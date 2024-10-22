
public class Episodio
{
    private List<string> convidados = new();

    public Episodio(int ordem, string titulo, double duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public double Duracao { get; }
    public string Resumo => $"\n{Ordem}. {Titulo} ({Duracao} horas) - {string.Join(", ", convidados)}";
    

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

    
}