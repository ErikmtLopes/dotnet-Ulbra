Livro livro1 = new Livro();
livro1.titulo = "Harry Potter e o Prisoneiro de Azkabam";
livro1.autor = "J.K Rolling Motther Fucking G";
livro1.ano = 1999;
livro1.paginas = 288;

livro1.informacoes();

Livro livro2 = new Livro();
livro2.titulo = "007 - Cassino Royale";
livro2.autor = "Ian Flaming";
livro2.ano = 1953;
livro2.paginas = 176;

livro2.informacoes();
livro2.TemMaisDe300Paginas();

if(livro2.TemMaisDe300Paginas())
{
    Console.WriteLine("Tem mais de 300 páginas!");
}
else
{
    Console.WriteLine("Tem menos de 300 páginas");
}