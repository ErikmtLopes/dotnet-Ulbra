public class Retangulo : FormaGeometrica
{
    public double Altura {get; set;}
    public double Largura {get; set;}
    public Retangulo(double altura, double largura)
    {
        Altura = altura;
        Largura = largura;
    }
    public override double CalcularArea()
    {
        return Largura * Altura;
    }
    public override double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}