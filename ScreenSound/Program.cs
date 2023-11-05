Album albumTheStrokes = new()
{
    Nome = "Room On Fire",
    Genero = "Indie Rock"
}; 

Musica musica1 = new();
musica1.Nome = "Reptilia";
musica1.Duracao = 213;

Musica musica2 = new();
musica2.Nome = "Under Control";
musica2.Duracao = 230;

albumTheStrokes.AdicionarMusica(musica1);
albumTheStrokes.AdicionarMusica(musica2);

Banda theStrokes = new();
theStrokes.Nome = "The Strokes";
theStrokes.AdicionarAlbum(albumTheStrokes);
theStrokes.ExibirDiscografia();
albumTheStrokes.ExibirMusicasAlbum();
