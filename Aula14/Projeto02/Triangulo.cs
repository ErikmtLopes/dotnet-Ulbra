public class Triangulo : ICalculavel
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double LadoA { get; set; }
    public double LadoB { get; set; }
    public double LadoC { get; set; }

    public Triangulo(double baseTriangulo, double altura, double ladoA, double ladoB, double ladoC)
    {
        Base = baseTriangulo;
        Altura = altura;
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
    }

    public double CalcularArea()
    {
        return (Base * Altura) / 2;
    }

    public double CalcularPerimetro()
    {
        return LadoA + LadoB + LadoC;
    }
}