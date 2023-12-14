class Episodio
{
    private List<string> convidados = new();
    //Construtor
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }
    //propriedades
    public int Ordem { get;}
    public string Titulo { get;}
    public int Duracao { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - " +
        $"{string. Join(", ", convidados)}";

    public void AddConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}
