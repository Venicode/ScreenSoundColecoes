class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new();

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(tempo => tempo.Duracao);
    //Metodo para adicionar música usando como parametro a
    //variavel musica da classe Musica
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }

    }
}
