public abstract class FormaGeometrica
{
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();

    public void Desenhar()
    {
        Console.WriteLine("Desenhando a forma.");
    }
}