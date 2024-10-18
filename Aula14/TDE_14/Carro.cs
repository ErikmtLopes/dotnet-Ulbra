public class Carro : Veiculo, iAceleravel, IFreavel
{
    public Carro(string marca, string modelo):base(marca, modelo)
    {

    }

    public override void Ligar()
    {
        Console.WriteLine("O carro está ligado");
    }

    public void Acelerar()
    {
        Console.WriteLine("O carro está ficand FIAAAAAAAAUM, FRANCHESCO VIRGOLINI, FIAAAAAAUM");
    }
     public void Frear()
    {
        Console.WriteLine("O carro está freando");
    }
}