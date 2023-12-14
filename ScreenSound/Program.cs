//Banda theStrokes = new("The Strokes");

//Album albumTheStrokes = new("Room On Fire");

//Musica musica1 = new(theStrokes, "Reptilia")
//{
//    //inicializando propriedades não obrigatórias
//    Duracao = 213,
//    Disponivel = true
//};

//Musica musica2 = new(theStrokes, "Under Control")
//{
//    Duracao = 230,
//    Disponivel = false
//};


//albumTheStrokes.AdicionarMusica(musica1);
//albumTheStrokes.AdicionarMusica(musica2);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();

//theStrokes.AdicionarAlbum(albumTheStrokes);
//albumTheStrokes.ExibirMusicasAlbum();
//theStrokes.ExibirDiscografia();

Episodio episodioUm = new(4, "Técnicas de facilitação", 45);
episodioUm.AddConvidados("Maria Albuquerque");
episodioUm.AddConvidados("Marcelo Almeida");

Episodio episodioDois = new(2, "Técnicas de aprendizado", 45);
episodioDois.AddConvidados("Maria Outra Pessoa");
episodioDois.AddConvidados("Marcelo Outra Pessoa");

Episodio episodioTres = new(3, "Técnicas de sobrevivencia", 45);
episodioTres.AddConvidados("Maria Não Albuquerque");
episodioTres.AddConvidados("Marcelo Não Almeida");

Episodio episodioQuatro = new(1, "Técnicas de meditação", 45);
episodioQuatro.AddConvidados("Maria Talvez Alburqueque");
episodioQuatro.AddConvidados("Marcelo Talvez Almeida");

Podcast podcast = new("Um Podcast", "Um host");
podcast.AdicionarEpisodios(episodioUm);
podcast.AdicionarEpisodios(episodioDois);
podcast.AdicionarEpisodios(episodioTres);
podcast.AdicionarEpisodios(episodioQuatro);
podcast.ExibirDetalhes();

