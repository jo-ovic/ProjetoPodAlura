Podcast podcast = new Podcast("Beto", "Matando Robôs Gigantes");
Episodio episodio1 = new Episodio("Como Ser Um Matador de Robôs Gigantes!", "Se " +
    "Deseja ser um Matador de Robôs Gigantes não perca esse papo " +
    "descontraído e divertido.", 30);

episodio1.AdicionarConvidados(new Convidado("Affonso"));
episodio1.AdicionarConvidados(new Convidado("Diogo"));

Episodio episodio2 = new Episodio("Por que não se deve comer churros enquanto " +
    "pilota um Robô Gigante.", "Se está pensando em pilotar um Robô Gigante " +
    "sem medo de ser feliz escute esse nosso tutorial de como ser um melhor " +
    "piloto da resistência.", 30);

episodio2.AdicionarConvidados(new Convidado("Affonso"));
episodio2.AdicionarConvidados(new Convidado("Diogo"));

podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhes();