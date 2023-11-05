class Album
{
    private List<Musica> musicas = new();
    public string Nome { get; set; }
    public string Genero { get; set; }
    public double DuracaoTotal => musicas.Sum(tempo => tempo.Duracao/60);
    //Metodo para adicionar música usando como parametro a
    //variavel musica da classe Musica
    public void AdicionarMusica (Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum() {
        Console.WriteLine($"Lista de músicas do álbum {Nome}");
        foreach (var musica in musicas) {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        
    }
}
