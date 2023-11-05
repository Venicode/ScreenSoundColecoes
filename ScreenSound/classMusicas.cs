//Classe
class Musica {
    //Anteriormente atributos, agora estamos usando
    //propriedade com get e set (leitura e escrita)
    public string Nome { get; set; }
    public string Artista { get; set; }
    public double Duracao { get; set; }
    public bool Disponivel { get; set; }
    //Propriedade somente leitura (get) usando o lambda
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";

    //Comportamento/Metodo da classe
    //(o void significa que não haverá retorno)
    public void ExibirFichaTecnica() {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel){
            Console.WriteLine("A música está disponível.");
        }
        else { 
            Console.WriteLine("Música não disponível. Adquira o plano Premium.");
        }
    }

}

//TO DO:
//Praticar conceitos como lambda, get e set, metodos