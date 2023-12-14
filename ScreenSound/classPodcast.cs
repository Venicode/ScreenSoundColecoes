class Podcast
{
    private List<Episodio> ListaEpisodios = new();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string nome;
    public string Nome { get;}
    public string Host { get;}
    public int TotalEpisodios => ListaEpisodios.Count;

    public void AdicionarEpisodios(Episodio episodio)
    {
        ListaEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        foreach (Episodio episodio in ListaEpisodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nEste podcast possui {TotalEpisodios} episódios.");
    }
}