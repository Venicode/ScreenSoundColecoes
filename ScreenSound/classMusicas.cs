//Classe
class Musica
{
    //Anteriormente atributos, agora estamos usando
    //propriedade com get e set (leitura e escrita):
    //Com atributos voce altera ou consome o valor de uma variavel 
    //diretamente acessando a propria variavel, ja com propriedades voce precisa 
    //passar por validacoes para chegar ate sua variavel.

    //Construtor:
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    //Propriedade somente leitura (get) usando o lambda
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";

    //Comportamento/Metodo da classe
    //(o void significa que não haverá retorno)
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("A música está disponível.");
        }
        else
        {
            Console.WriteLine("Música não disponível. Adquira o plano Premium.");
        }
    }

}

//TO DO:
//Praticar conceitos como lambda, get e set, metodos
