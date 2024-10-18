public class Bicicleta : Veiculo, iAceleravel
{
    public Bicicleta(string marca, string modelo):base(marca, modelo)
    {

    }

    public override void Ligar()
    {
        Console.WriteLine("A bicicleta está pronta para uso");
    }

    public void Acelerar()
    {
        Console.WriteLine("A bicicleta está pedalando mais rápido");
    }
}