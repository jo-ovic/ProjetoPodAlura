class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string host,string nome) 
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios { get; set; }
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        TotalEpisodios++;
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}\n");

        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine($"Episódio: {episodio.Ordem} - {episodio.Titulo}");
            Console.WriteLine($"Resumo: {episodio.Resumo}");
            episodio.ExibirConvidados();
            Console.WriteLine($"Duração do Episódio: {episodio.Duracao}.\n");
        }

        Console.WriteLine($"Total de Episódios: {TotalEpisodios}.");
    }
}