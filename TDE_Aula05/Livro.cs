class Livro
{
    public string titulo;
    public string autor;
    public int ano;
    public int paginas;

    public void informacoes()
    {
        Console.WriteLine($"Autor: {autor}\nTitulo: {titulo}\n Ano: {ano}\n N° de páginas: {paginas}");
    }

    public Boolean TemMaisDe300Paginas()
    {
        return paginas >= 300;
    }
}