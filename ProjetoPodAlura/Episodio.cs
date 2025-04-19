class Episodio
{
    private static int contador = 0;
    private List<Convidado> convidados = new List<Convidado>();
    public Episodio(string titulo,string resumo,int duracao) 
    {
        Titulo = titulo;
        Resumo = resumo;
        Duracao = duracao;
        Ordem = ++contador;
    }
    public string Titulo { get; }
    public string Resumo { get; }
    public int Duracao { get; }
    public int Ordem { get; }

    public void AdicionarConvidados(Convidado convidado)
    {
        convidados.Add(convidado);
    }
    public void ExibirConvidados()
    {
        var nomes = convidados.Select(c => c.Nome);
        Console.WriteLine("Convidados: " + string.Join(", ", nomes)+".");
    }

}