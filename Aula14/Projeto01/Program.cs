var circulo = new Circulo(5);
var retangulo = new Retangulo(4, 6);

var formas = new List <FormaGeometrica>();
formas.Add(circulo);
formas.Add(retangulo);

foreach(var forma in formas)
{
  Console.WriteLine(forma.GetType());
  Console.WriteLine($"Área: {forma.CalcularArea():F2}");
  Console.WriteLine($"Perimetro: {forma.CalcularPerimetro():F2}"); 
}
