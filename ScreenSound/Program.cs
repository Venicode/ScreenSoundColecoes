Banda theStrokes = new("The Strokes");

Album albumTheStrokes = new("Room On Fire");

Musica musica1 = new(theStrokes, "Reptilia")
{
    //inicializando propriedades não obrigatórias
    Duracao = 213,
    Disponivel = true
};

Musica musica2 = new(theStrokes, "Under Control")
{
    Duracao = 230,
    Disponivel = false
};


albumTheStrokes.AdicionarMusica(musica1);
albumTheStrokes.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

theStrokes.AdicionarAlbum(albumTheStrokes);
albumTheStrokes.ExibirMusicasAlbum();
theStrokes.ExibirDiscografia();
